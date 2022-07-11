'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : UI ����
' form ���� : UI ������ ��ȸ, �߰�, ����, �����Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2006-07-04
'////////////////////////////////////////////////////////////////////////////////////////////////////

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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEB01
        Inherits CommonControls.UiControl

        Private Sub SMEB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    

            gridAttributes = gridAttributes & "||����;����;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|�ý��� ����;SystemDivision;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ID;ProgramID;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;300;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|���α׷� ����;ProgramExplanation;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|L1;Level1;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|L2;Level2;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|L3;Level3;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|L4;Level4;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�޴����ļ���;MenuStandInRowOrder;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|���� ����;LastYesOrNo;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;300;;l;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1
        End Sub

        Private Sub BtnImageOpen1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                        BtnImageOpen1.Click _

            Me.OpenFileDialog1.InitialDirectory = "c:\"
            Me.OpenFileDialog1.Filter = "�̹��� ���� (*.jpg)|*.jpg|�̹��� ���� (*.bmp)|*.bmp|��� ���� (*.*)|*.*"

            Try
                'MsgBox("���� ���� ���Դϴ�.")
                If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Me.picUiImage.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'If cnnSQL.State = ConnectionState.Open Then cnnSQL.Close()
                'cnnSQL = Nothing
            End Try

        End Sub

        Private Sub BtnImageSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImageSave.Click
            '-- �̹��� ����
            Call UpLoadImage()
        End Sub

        Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
            Dim DefaultString As String = vbNullString

            DefaultString = ""
            If chkRequestYesOrNo.Checked = True Then '��ȸ ���� ��
                DefaultString = DefaultString & vbCrLf & "�� ��ȸ"
                DefaultString = DefaultString & vbCrLf & "   1. �˻� ������ �Է� �� �� ��ȸ ��ư�� Ŭ�� �Ѵ�."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkCreateYesOrNo.Checked = True Then '���� ���� ��
                DefaultString = DefaultString & vbCrLf & "�� ����"
                DefaultString = DefaultString & vbCrLf & "   1. �ش� �ڷḦ �Է� �� �� ���� ��ư�� Ŭ�� �Ѵ�."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkUpdateYesOrNo.Checked = True Then '���� ���� ��
                DefaultString = DefaultString & vbCrLf & "�� ����"
                DefaultString = DefaultString & vbCrLf & "   1. �ش� �ڷḦ ���� �� �� ���� ��ư�� Ŭ�� �Ѵ�."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkDeleteYesOrNo.Checked = True Then '���� ���� ��
                DefaultString = DefaultString & vbCrLf & "�� ����"
                DefaultString = DefaultString & vbCrLf & "   1. ���� ��ư�� Ŭ���Ͽ� ���� �Ѵ�."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkPrintYesOrNo.Checked = True Then '��� ���� ��
                DefaultString = DefaultString & vbCrLf & "�� ���"
                DefaultString = DefaultString & vbCrLf & "   1. �̸����� ��ư�� Ŭ�� �ϰų� ��� ��ư�� Ŭ�� �Ͽ� ��� �Ѵ�."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            DefaultString = DefaultString & vbCrLf & ""
            DefaultString = DefaultString & vbCrLf & ""
            txtSkillExplanation.Text = DefaultString
        End Sub

        
        Private Sub btnAutoImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoImage.Click

            '' �̹������ӵ�� 
            'Dim intII As Integer = 0
            'Dim sFilePath As String = "\\172.17.60.66\99. ���� ����\2��ȭ�� ĸ��"
            'Dim sSystemDiv As String = ""
            'Dim sFileName As String = ""

            'sFilePath = "D:\Test"
            'For intII = 0 To grd_1.Rows - 1
            '    If intII >= grd_1.FixedRows Then
            '        sSystemDiv = grd_1.get_TextMatrix(intII, grd_1.get_ColIndex("SystemDivision"))
            '        sFileName = grd_1.get_TextMatrix(intII, grd_1.get_ColIndex("ProgramID"))
            '        sbImageReg(sFilePath & "\" & sSystemDiv, sFileName)
            '    End If
            'Next

        End Sub

        Private Sub sbImageReg(ByVal sFilePath As String, ByVal sFileName As String)


            Try
                'MsgBox("���� ���� ���Դϴ�.")
                Me.picUiImage.Image = Image.FromFile(sFilePath & "\" & sFileName & ".jpg")

                ''-- �̹��� ����
                'Call UpLoadImage()


            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'If cnnSQL.State = ConnectionState.Open Then cnnSQL.Close()
                'cnnSQL = Nothing
            End Try

        End Sub

    
    End Class

End Namespace
