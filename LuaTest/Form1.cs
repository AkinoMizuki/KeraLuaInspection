using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeraLua;

namespace LuaTest
{
    public partial class Form1 : Form
    {

        public bool LuaFlag = false;
        public bool ManualClockFlag = false;
        public string Receive =  "";

        public Form1()
        {
            InitializeComponent();
        }

        /************************************************************/
        /*                  フォーム関数                            */
        /************************************************************/
        private void LuaLeadButtton_Click(object sender, EventArgs e)
        {/*=== LuaFileセット===*/

            openFileDialog1.FileName = "man.lua";   //既定のファイル名
            openFileDialog1.DefaultExt = ".lua";    //既定のファイル拡張子
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Lua failes *Lua |*.lua";

            //ダイアログ表示
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //指定されたFileをテキストに表示する
                LuaTextBox.Text = openFileDialog1.FileName;
                //文字入力位置(キャレット)を末尾に設定する
                LuaTextBox.SelectionStart = LuaTextBox.Text.Length;

            }

        }/*=== END_LuaFileセット===*/
        private void LuaTextBox_DragEnter(object sender, DragEventArgs e)
        {
            //ファイルがドラッグされている場合、カーソルを変更する
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void LuaTextBox_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップされたファイルの一覧を取得
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if(fileName.Length <= 0)
            {
                return;
            }

            //ドロップ先がテキストボックスであるかチェック
            TextBox LuaTextBox = sender as TextBox;
            if(LuaTextBox == null)
            {
                return;
            }

            //テキストボックスの内容をファイル名に変更
            LuaTextBox.Text = fileName[0];

            LuaTextBox.Select(LuaTextBox.Text.Length, 0);

        }

        private void StartLuaButton_Click(object sender, EventArgs e)
        {/*=== Luaスタート===*/

            if(LuaTextBox.Text != "")
            {/*=== 空チェック === */

                //フォーム制御
                StartLuaButton.Enabled = false;
                LuaLeadButtton.Enabled = false;
                LuaTextBox.Enabled = false;

                ManualClockCheckBox.Enabled = false;
                if(ManualClockCheckBox.Checked == true)
                {
                    TapCmdClockButton.Enabled = true;
                    AutoCmdClockButton.Enabled = true;
                }

                //マニュアルClock用
                LuaFlag = true;
                ManualClockFlag = true;

                //メッセージ二重対策
                string BuffPrint = "";

                //開始メッセージ
                LogTextBox.AppendText("=== Start Lua Cmd ===" + Environment.NewLine);
                Task task = new Task(() =>
                {//別タスク処理

                    //Luaスタート
                    MainLua(LuaTextBox.Text);

                    LuaFlag = false;
                    this.Invoke((Action)(() =>
                    {//別タスクからUI制御します

                        //フォーム制御
                        StartLuaButton.Enabled = true;
                        LuaLeadButtton.Enabled = true;
                        LuaTextBox.Enabled = true;
                        ManualClockCheckBox.Enabled = true;
                        TapCmdClockButton.Enabled = true;
                        AutoCmdClockButton.Enabled = true;
                        LogTextBox.AppendText("=== END Lua Cmd ===" + Environment.NewLine);


                    }));//EDN_別タスクからUI制御します

                    GC.Collect();//アクセス不可能なオブジェクトを除去
                    GC.WaitForPendingFinalizers();//ファイナライゼーションが終わるまでスレット待機
                    GC.Collect();//ファイナライズされたばかりのオブジェクトに関するメモリを開放

                });//END_別タスク処理
                task.Start();

            }/*=== END_空チェック === */

        }/*=== END_Luaスタート===*/

        private void StopLuaButton_Click(object sender, EventArgs e)
        {/*=== Lua停止 ===*/

            if(LuaFlag == true)
            {
                //フォーム制御
                StartLuaButton.Enabled = true;
                LuaLeadButtton.Enabled = true;
                LuaTextBox.Enabled = true;
                ManualClockCheckBox.Enabled = true;
                TapCmdClockButton.Enabled = true;
                AutoCmdClockButton.Enabled = true;
                LogTextBox.AppendText("=== END Lua Cmd ===" + Environment.NewLine);
                LuaFlag = false;

            }

        }/*=== END_Lua停止 ===*/

        private void TapCmdClockButton_Click(object sender, EventArgs e)
        {/*=== TapCmdClock ===*/
            ManualClockFlag = false;
        }/*=== END_TapCmdClock ===*/

        private void AutoCmdClockButton_Click(object sender, EventArgs e)
        {/*=== AutoCmdClock ===*/

            ManualClockFlag = false;
            ManualClockCheckBox.Enabled = false;
            TapCmdClockButton.Enabled = false;
            AutoCmdClockButton.Enabled = false;

        }/*=== END_AutoCmdClock ===*/

        /************************************************************/
        /*                  Luaスタート                             */
        /************************************************************/
        public void MainLua(string Address)
        {/*=== コンストラクタ ===*/

            Lua MainLua = new Lua();

            //オープン
            MainLua.OpenLibs();
            MainLua.LoadFile(Address);

            /*=== Lua関数 ===*/
            MainLua.Register("print", print);//プリント関数
            MainLua.Register("sleep", sleep);//スリーブ関数

            try
            {
                MainLua.PCall(0, 0, 0);
            }
            catch
            { }//タスク破棄用

        }/*=== END_コンストラクタ ===*/

        /************************************************************/
        /*                  Lua関数                                 */
        /************************************************************/
        private int print(IntPtr Text)
        {/*=== テキストボックスに出力 ===*/

            if (LuaFlag == true)
            {//スキップ用

                if(ManualClockCheckBox.Checked == true)
                {//マニュアルクロック用
                    while(ManualClockFlag == true) { }
                    ManualClockFlag = true;
                }//END_マニュアルクロック用

                //ステートの取得
                Lua state = Lua.FromIntPtr(Text);

                //ログテキストに出力
                Receive = state.ToString(1);

                //一応stateを空にしておく
                state.Pop(state.GetTop());

                this.Invoke((Action)(() =>
                {//別タスクからUI制御します
                    LogTextBox.AppendText(Receive + Environment.NewLine);
                }));//END_別タスクからUI制御します

            }
            else
            {//タスク破棄用
                throw new Exception();
            }//END_スキップ用

            return 0;
        }/*=== END_テキストボックスに出力 ===*/

        private int sleep(IntPtr msec)
        {/*=== ウェイト ===*/

            if (LuaFlag == true)
            {//スキップ用

                //ステートの取得
                Lua state = Lua.FromIntPtr(msec);

                Thread.Sleep(int.Parse(state.ToString(1)));

            }
            else
            {//タスク破棄用
                throw new Exception();
            }//END_スキップ用

            return 0;
        }/*=== END_ウェイト ===*/


    }
}
