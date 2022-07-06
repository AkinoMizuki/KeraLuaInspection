
namespace LuaTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LuaTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LuaLeadButtton = new System.Windows.Forms.Button();
            this.ManualClockCheckBox = new System.Windows.Forms.CheckBox();
            this.StartLuaButton = new System.Windows.Forms.Button();
            this.StopLuaButton = new System.Windows.Forms.Button();
            this.TapCmdClockButton = new System.Windows.Forms.Button();
            this.AutoCmdClockButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LuaTextBox
            // 
            this.LuaTextBox.AllowDrop = true;
            this.LuaTextBox.Location = new System.Drawing.Point(72, 339);
            this.LuaTextBox.Name = "LuaTextBox";
            this.LuaTextBox.Size = new System.Drawing.Size(150, 23);
            this.LuaTextBox.TabIndex = 0;
            this.LuaTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LuaTextBox_DragDrop);
            this.LuaTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.LuaTextBox_DragEnter);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.LogTextBox.ForeColor = System.Drawing.Color.Lime;
            this.LogTextBox.Location = new System.Drawing.Point(12, 12);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(587, 307);
            this.LogTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lua Lead";
            // 
            // LuaLeadButtton
            // 
            this.LuaLeadButtton.Location = new System.Drawing.Point(228, 338);
            this.LuaLeadButtton.Name = "LuaLeadButtton";
            this.LuaLeadButtton.Size = new System.Drawing.Size(37, 23);
            this.LuaLeadButtton.TabIndex = 3;
            this.LuaLeadButtton.Text = "...";
            this.LuaLeadButtton.UseVisualStyleBackColor = true;
            this.LuaLeadButtton.Click += new System.EventHandler(this.LuaLeadButtton_Click);
            // 
            // ManualClockCheckBox
            // 
            this.ManualClockCheckBox.AutoSize = true;
            this.ManualClockCheckBox.Location = new System.Drawing.Point(12, 368);
            this.ManualClockCheckBox.Name = "ManualClockCheckBox";
            this.ManualClockCheckBox.Size = new System.Drawing.Size(98, 19);
            this.ManualClockCheckBox.TabIndex = 4;
            this.ManualClockCheckBox.Text = "Manual Clock";
            this.ManualClockCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartLuaButton
            // 
            this.StartLuaButton.Location = new System.Drawing.Point(187, 368);
            this.StartLuaButton.Name = "StartLuaButton";
            this.StartLuaButton.Size = new System.Drawing.Size(78, 22);
            this.StartLuaButton.TabIndex = 3;
            this.StartLuaButton.Text = "Start Lua";
            this.StartLuaButton.UseVisualStyleBackColor = true;
            this.StartLuaButton.Click += new System.EventHandler(this.StartLuaButton_Click);
            // 
            // StopLuaButton
            // 
            this.StopLuaButton.Location = new System.Drawing.Point(187, 396);
            this.StopLuaButton.Name = "StopLuaButton";
            this.StopLuaButton.Size = new System.Drawing.Size(78, 22);
            this.StopLuaButton.TabIndex = 3;
            this.StopLuaButton.Text = "Stop Lua";
            this.StopLuaButton.UseVisualStyleBackColor = true;
            this.StopLuaButton.Click += new System.EventHandler(this.StopLuaButton_Click);
            // 
            // TapCmdClockButton
            // 
            this.TapCmdClockButton.Location = new System.Drawing.Point(12, 393);
            this.TapCmdClockButton.Name = "TapCmdClockButton";
            this.TapCmdClockButton.Size = new System.Drawing.Size(141, 45);
            this.TapCmdClockButton.TabIndex = 3;
            this.TapCmdClockButton.Text = "Tap Cmd Clock";
            this.TapCmdClockButton.UseVisualStyleBackColor = true;
            this.TapCmdClockButton.Click += new System.EventHandler(this.TapCmdClockButton_Click);
            // 
            // AutoCmdClockButton
            // 
            this.AutoCmdClockButton.Location = new System.Drawing.Point(159, 423);
            this.AutoCmdClockButton.Name = "AutoCmdClockButton";
            this.AutoCmdClockButton.Size = new System.Drawing.Size(106, 22);
            this.AutoCmdClockButton.TabIndex = 3;
            this.AutoCmdClockButton.Text = "Auto Cmd Clock";
            this.AutoCmdClockButton.UseVisualStyleBackColor = true;
            this.AutoCmdClockButton.Click += new System.EventHandler(this.AutoCmdClockButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 457);
            this.Controls.Add(this.ManualClockCheckBox);
            this.Controls.Add(this.TapCmdClockButton);
            this.Controls.Add(this.AutoCmdClockButton);
            this.Controls.Add(this.StopLuaButton);
            this.Controls.Add(this.StartLuaButton);
            this.Controls.Add(this.LuaLeadButtton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.LuaTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LuaTextBox;
        public System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LuaLeadButtton;
        private System.Windows.Forms.CheckBox ManualClockCheckBox;
        private System.Windows.Forms.Button StartLuaButton;
        private System.Windows.Forms.Button StopLuaButton;
        private System.Windows.Forms.Button TapCmdClockButton;
        private System.Windows.Forms.Button AutoCmdClockButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

