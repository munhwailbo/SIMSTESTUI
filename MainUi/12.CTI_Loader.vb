Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic
Imports System.Configuration
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection

Namespace ubiLease.UI.MainUi
    Partial Class frmMainUi

        ''' <summary>
        ''' CTI Loader
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub Load_cti_module()
            Dim loadedAssembly As [Assembly] = Nothing
            loadedAssembly = [Assembly].LoadFrom("http://127.0.0.1/sims_dll/DLL/CallCenterControl.dll")

            Dim getedTypes() As Type = loadedAssembly.GetTypes()

            For forNumber As Integer = 0 To getedTypes.Length - 1
                Debug.Print(getedTypes(forNumber).Name)
                If getedTypes(forNumber).Name = "AgentStateView" Then
                    Dim createdInstance As Control = Activator.CreateInstance(getedTypes(forNumber))

                    pnlLeftBottom.Controls.Add(createdInstance)
                    'createdInstance.Left = 1
                    'pnlLeftBottom.Controls(pnlLeftBottom.Controls.Count - 1).Focus()
                    'createdInstance = Nothing
                    createdInstance.Dock = DockStyle.Fill
                    Exit For
                End If
            Next forNumber
        End Sub

    End Class
End Namespace

