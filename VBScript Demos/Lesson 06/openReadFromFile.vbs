Option Explicit
Dim fso, myfile, data, strtextfilePath
strtextfilePath="D:\Users\npadmawa\Desktop\formatted new\VBScripts_pending few files\VBScripts\VBScript Demos\Lesson 06\myfile.txt"
Set fso = createobject("Scripting.FileSystemObject")  
     
Msgbox "Text file visible"
Set myfile = fso.OpenTextFile(strtextfilePath, 1, True)

Do while myfile.AtEndOfStream <> True
data = myfile.ReadLine()
Msgbox data
Loop 
 