
Set objDictionary = CreateObject("Scripting.Dictionary")

objDictionary.Add "Printer 1", "Printing"
objDictionary.Add "Printer 2", "Offline"

objDictionary.Remove("Offline")

colKeys = objDictionary.Keys

For Each strKey in colKeys
msgbox strKey
Next
