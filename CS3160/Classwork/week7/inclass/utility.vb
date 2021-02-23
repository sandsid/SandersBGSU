' Utility Dll: contains one function

Option Explicit
Option Strict

Imports System

Namespace UtilityNS
   Public Class Utility
      Public Function NumLetters(ByVal name as String, ByRef whichone as String) As Integer
          whichone = "VB dll"
	  return name.Length()
      End Function
   End Class
End Namespace
