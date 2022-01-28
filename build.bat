
if x%VSCMD_VER%==x call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"


msbuild -t:Rebuild -p:Configuration=Release
signtool sign /tr http://timestamp.digicert.com /td sha256 /fd sha256 /sha1 48AE12F928CF727D16336D29BC2DC35FC7F129BC "bin\Release\Thorg Installer.exe"
