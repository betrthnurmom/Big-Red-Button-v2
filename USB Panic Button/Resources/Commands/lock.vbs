Set oShell = CreateObject("WScript.Shell")  
sCmd = "%windir%\SYSTEM32\rundll32.exe user32.dll,LockWorkStation"  
oShell.Run sCmd, 0, False
