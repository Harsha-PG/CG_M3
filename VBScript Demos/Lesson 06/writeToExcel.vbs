Option Explicit
Dim obj, obj1, strExcelPath
strExcelPath="D:\Users\npadmawa\Desktop\formatted new\VBScripts_pending few files\VBScripts\VBScript Demos\Lesson 06\myexcel.xlsx"
Set obj = createobject("Excel.Application")  
 obj.visible=True      
 Msgbox "true"
 obj.WorkBooks.Open strExcelPath
 Set obj1 = obj.ActiveWorkbook.Worksheets(1)
 obj1.Cells(1,1).Value="Hello"        
 
 