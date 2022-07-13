# KeraLuaInspection
C#(.NET 5)でのKeraLuaを実装メモです。

- Lua読み込み時のコードの静的解析(字句解析, 構文解析)は有りません
- モジュールは実装されていません

# 実装API
- print(value)
- sleep(msec)

# print(value)
GUI中央の黒いTextBoxに表示できます※日本語非対応
```lua
  print("文字表示")
```

# sleep(msec)
msecオーダーでウェイトを指定出来ます
```lua
 --100msウェイト
　sleep(100)
```
