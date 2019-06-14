Option Explicit
Dim obj, obj1, strExcelPath
strExcelPath="D:\Users\npadmawa\Desktop\formatted new\VBScripts_pending few files\VBScripts\VBScript Demos\Lesson 06\myexcel.xlsx"

Set obj = createobject("Excel.Application")  
obj.visible=True 
obj.WorkBooks.Open strExcelPath

Set obj1 = obj.ActiveWorkbook.Worksheets(1)
obj1.Cells(2,1).Value="1001"   
obj1.Cells(2,2).Value="Viren Borade" 
obj1.Cells(2,3).Value=100000 
Msgbox "student data stored"  

Msgbox (obj1.Cells(2,1).Value & vbcrlf & obj1.Cells(2,2).Value & vbcrlf & obj1.Cells(2,3).Value)
 
 