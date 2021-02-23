' app:  This program uses a DLL
'

Option Explicit
Option Strict

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports UtilityNS

Public Class Greet
   Inherits System.Windows.Forms.Form

   Friend WithEvents username As Textbox ' really System.Windows.Forms.Textbox
   Friend WithEvents say As Button       ' really System.Windows.Forms.Button

   Public Sub New()
      MyBase.New()

      ' Form
      me.Text = "Enter your name below"
      me.Height = 120


      ' TextBox:  username
      username = New TextBox
      username.Location = New System.Drawing.Point(32, 8)
      username.Size = New System.Drawing.Size(208, 20)
      me.Controls.Add(username)

      ' Button:  say
      say = New Button
      say.Text = "How many letters?"
      say.Location = New System.Drawing.Point(32, 38)
      say.Size = New System.Drawing.Size(208, 25)
      me.Controls.Add(say)

      me.AcceptButton = say

   End Sub

   ' Handle a click of the say button
   Private Sub say_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles say.Click
      Dim utl as Utility
      Dim dllversion as String
      Dim numletters as Integer
      dllversion = "blank"
      utl = new Utility()
      numletters = utl.NumLetters(username.Text, dllversion)
      MsgBox("Number of letters: "&numletters,,dllversion)
      username.Clear()
   End Sub

   Public Shared Sub Main()
      Application.Run(New Greet())
   End Sub

End Class


