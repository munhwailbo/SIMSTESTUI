Imports Microsoft.VisualBasic
Imports VBN = Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Configuration
Imports System.Windows.Forms
Imports System.IO

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Imports System.Reflection

Namespace ubiLease.UI.Login

    Public Class FontDeployManager

        <DllImport("gdi32.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True)> _
        Friend Shared Function AddFontResourceW(ByVal filename As String) As Integer
        End Function

        <DllImport("gdi32.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True)> _
        Friend Shared Function RemoveFontResourceW(ByVal filename As String) As Boolean
        End Function

        Public sFontFile As String = "BarCodeFont\CODE39-1.TTF"
        Public Sub FontDeploy()
            If System.IO.File.Exists("C:\windows\fonts\CODE39-1.TTF") Then
            Else
                System.IO.File.Copy(sFontFile, "C:\windows\fonts\CODE39-1.TTF")

                Dim ret As Integer = AddFontResourceW("C:\windows\fonts\CODE39-1.TTF")
                If ret = 0 Then
                    MessageBox.Show(Marshal.GetLastWin32Error())
                End If
            End If
        End Sub

    End Class

End Namespace

