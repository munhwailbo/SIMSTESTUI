'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : Role ���
' form ���� : Role ������ ��ȸ, �߰�, ����, �����Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2006-06-10
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

    Public Class SMCA01
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���� �ڵ�;RoleCode;80;;c;" & "io;y;n;7;"
            gridAttributes = gridAttributes & "|���� �̸�;RoleName;170;;l;" & "io;y;n;40;"
            gridAttributes = gridAttributes & "|���� ����;RoleExplanation;300;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|���� ����;SystemDivision;100;;c;" & "io;y;n;40;"
            gridAttributes = gridAttributes & "|��� ����;PrivateUseYesOrNo;80;;l;" & "io;y;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;�ý��� ���� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            Dim Ds As DataSet = New DataSet
            Ds.Tables.Add()
            Ds.Tables.Item(0).Columns.Add("fromEmail")
            Ds.Tables.Item(0).Columns.Add("toEmail")
            Ds.Tables.Item(0).Columns.Add("subjectEmail")
            Ds.Tables.Item(0).Columns.Add("contentEmail")
            Ds.Tables.Item(0).Columns.Add("smtpEmail")
            Ds.Tables.Item(0).Columns.Add("cclistEmail")
            Ds.Tables.Item(0).Columns.Add("attachEmail")
            Ds.Tables.Item(0).Columns.Add("doctypeEmail")


            Dim aa As Object = Me.ParentForm
            For i As Integer = 0 To 10
                Dim param As String() = Split(",,,,,,,", ",")


                param(0) = aa.GetMasterEmailAddress.ToString()
                param(1) = "getmail@empal.com"
                param(2) = "�׽�Ʈ ����  : " & i
                param(3) = Me.RichTextBox1.Text
                param(4) = aa.GetSmtpServerIp.ToString()
                param(5) = ""
                param(6) = ""
                param(7) = "HTML"

                Ds.Tables.Item(0).Rows.Add(param)

            Next
            GmainCommonFunction.DataSetToSendMail(Ds, "fromEmail", "toEmail", "subjectEmail", "contentEmail", "smtpEmail", "cclistEmail", "attachEmail", "doctypeEmail")
        End Sub

        Private Sub SMCA01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        End Sub
    End Class

End Namespace
