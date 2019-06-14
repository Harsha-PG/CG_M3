Option Explicit
Dim fso, myfile, filename, strtextfilePath
strtextfilePath="D:\Users\npadmawa\Desktop\formatted new\VBScripts_pending few files\VBScripts\VBScript Demos\Lesson 06\createdfile.txt"

Set fso = createobject("Scripting.FileSystemObject")  
Set myfile = fso.CreateTextFile(strtextfilePath, True)
filename = fso.GetFileName(strtextfilePath)
If fso.FileExists(strtextfilePath) then
Msgbox("file has been created")
myfile.WriteLine("I have written this line from the .vbs code...")
myfile.Close
Msgbox("content written into file")
End if
 