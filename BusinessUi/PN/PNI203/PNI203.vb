' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : 
' form���� :
' �ۼ��� : 
' �ۼ��� : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI203
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"


        Public Sub Initialize()

            Me.NewData()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : ACA003_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub btnClosing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosing.Click
            'Dim message As String = Me.dtpClosingYearMonths.TextValue.Substring(0, 4) & "�� " & Me.dtpClosingYearMonths.TextValue.Substring(4, 2) & "��"

            If Me.dtpNextClosingYearMonths.TextValue Is Nothing Then
                MessageBox.Show("���� ���� ������ ��ȸ �� ó�� �ϼ���", "���� ���� ó�����")
                Exit Sub
            Else
                Me.SaveData()
                'MessageBox.Show("���� ���� ó�� �ƽ��ϴ�")
                Me.RequestData()
            End If

        End Sub

        Private Sub btnClosingCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosingCancel.Click

            'Dim message As String = Me.dtpClosingYearMonths.TextValue.Substring(0, 4) & "�� " & Me.dtpClosingYearMonths.TextValue.Substring(4, 2) & "��"

            If Me.dtpNextClosingYearMonths.TextValue Is Nothing Then
                MessageBox.Show("���� ���� ������ ��ȸ �� ó�� �ϼ���", "���� ���� ó�����")
                Exit Sub
            Else
                Me.DeleteData()
                MessageBox.Show("���� ������� ó�� �ƽ��ϴ�")
                Me.RequestData()
            End If

        End Sub

    End Class

End Namespace
