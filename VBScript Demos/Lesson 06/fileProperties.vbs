Option Explicit
Dim fso, myfile, strtextfilePath, dc
strtextfilePath="D:\Users\npadmawa\Desktop\formatted new\VBScripts_pending few files\VBScripts\VBScript Demos\Lesson 06\myfile.txt"

Set fso = createobject("Scripting.FileSystemObject")   
Set myfile = fso.GetFile(strtextfilePath)

dc = myfile.Name
Msgbox ("***Details of myfile.txt ***" & vbcrlf &_
"FileName: " & myfile.Name & vbcrlf &_
"DateCreated: " & myfile.DateCreated & vbcrlf &_
"DateLastAccessed: " & myfile.DateLastAccessed & vbcrlf &_
"Drive: " & myfile.Drive & vbcrlf &_
"ParentFolder: " & myfile.ParentFolder & vbcrlf &_
"Path: " & myfile.Path & vbcrlf &_
"Size: " & myfile.Size & vbcrlf &_
"Type: " & myfile.Type)


 