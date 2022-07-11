Imports Microsoft.VisualBasic
Imports VBN = Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Configuration
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports System.Reflection
Imports System.Runtime.InteropServices

Namespace ubiLease.UI.Login


    Public Class frmLogin

        Private Declare Function ReleaseCapture Lib "user32" () As Integer
        Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParm As Integer, ByRef lParm As String) As Long

        Private Gexception As DAT.CustomException = New DAT.CustomException
        Private GmainCommonFunction As CommonFunction.Common = New CommonFunction.Common

        '====================================================================================================
        Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
            Me.WebBrowser1.Region = New Region(New Rectangle(1, 76, 653, 438))
            Me.lblVersion.Text = GmainCommonFunction.versionInfo()

        End Sub

        Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown, picMain.MouseDown
            Call ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0&)
        End Sub

        Private BizForm As New frmBusinessSelect
        '====================================================================================================
        Private Sub picLogin_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLogin.MouseClick

            '����(üũ)
            'If Me.VersionCheck() = False Then
            '    '�ֽ� ������ �ƴ� ��� ƨ�ܳ���. �ֽ� ���� ��ġ�� ����
            '    MessageDialog.ShowDialog()
            '    Exit Sub
            'End If

            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim tempCommonFunction As New ubiLease.CommonFunction.Common
            tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AuserId", Trim(Me.txtLoginID.Text))
            tempCommonFunction.SetSqlParameter(tempSqlParameter, "@Apassword", Trim(Me.txtPassword.Text))
            tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AIpAddress", Trim(ubiLease.DAT.localhostinfo.localIPAddress()))
            ' sp Id �߰�

            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "CheckUser", False, True, tempSqlParameter)

            If reciveDataSet.Tables.Count > 0 Then

            Else
                MsgBox("������ ���̽� ���� ������ �ùٸ��� �ʽ��ϴ�. �����ڿ��� ���� �Ͻʽÿ�.", MsgBoxStyle.Information, "DB ���� ����")
                Me.txtLoginID.Text = ""
                Me.txtPassword.Text = ""
                Me.txtLoginID.Focus()

                Exit Sub
            End If

            If reciveDataSet.Tables(0).Rows.Count = 0 Then
                MsgBox("�������� �ʴ� ���̵� �̰ų�, ��й�ȣ�� �ٸ��� �ʽ��ϴ�. �ٸ��� �ۼ� �� �α����Ͽ� �ֽʽÿ�!", MsgBoxStyle.Information, "�α��� ����")
                Exit Sub
            End If

            Me.Hide()
            Me.ShowInTaskbar = False





            With reciveDataSet.Tables(0)

                BizForm.GRoleEmpNum = .Rows(0).Item("RoleEmpNum").ToString() ' ������ ���

                BizForm.GUserGrade = .Rows(0).Item("UserGrade").ToString() ' ����� ��Ȱ

                BizForm.GBizEmpYN = .Rows(0).Item("BizEmpYN").ToString() ' ��������� ����

                BizForm.GMngEmpYN = .Rows(0).Item("MngEmpYN").ToString() ' ��������� ����

                BizForm.GLoginName = .Rows(0).Item("UserName").ToString() '�α��� ��

                BizForm.GbusinessPalceCode = .Rows(0).Item("OrganizationCode").ToString() '���� �ڵ�
                BizForm.GbranchCode = .Rows(0).Item("OrganizationCode").ToString() '�� �ڵ�
                BizForm.GteamCode = .Rows(0).Item("OrganizationCode").ToString() '�� �ڵ�
                BizForm.GpartCode = .Rows(0).Item("OrganizationCode").ToString() '��Ʈ �ڵ�
                BizForm.GpcCode = .Rows(0).Item("OrganizationCode").ToString() 'PC �ڵ�
                BizForm.GcornerCode = .Rows(0).Item("OrganizationCode").ToString() '�ڳ� �ڵ�

                BizForm.GbusinessPalceName = .Rows(0).Item("CodeName").ToString() '���� �ڵ�
                BizForm.GbranchName = .Rows(0).Item("CodeName").ToString() '�� �ڵ�
                BizForm.GteamName = .Rows(0).Item("CodeName").ToString() '�� �ڵ�
                BizForm.GpartName = .Rows(0).Item("CodeName").ToString() '��Ʈ �ڵ�
                BizForm.GpcName = .Rows(0).Item("CodeName").ToString() 'PC �ڵ�
                BizForm.GcornerName = .Rows(0).Item("CodeName").ToString() '�ڳ� �ڵ�


                ' '' ''For rowNumber As Integer = 0 To .Rows.Count - 1 Step 1

                ' '' ''    If .Rows(rowNumber).Item("CodeAttributeCode") = "1" Then
                ' '' ''        BizForm.GLoginName = Convert.ToString(.Rows(rowNumber).Item("UserName")) '�α��� ��
                ' '' ''        BizForm.GbusinessPalceCode = .Rows(rowNumber).Item("OrganizationCode").ToString().Substring(0, 2) '����� �ڵ�
                ' '' ''        BizForm.GbusinessPalceName = .Rows(rowNumber).Item("CodeName") '����� ��
                ' '' ''        'BizForm.GorganizationCode = .Rows(rowNumber).Item("OrganizationCode") '���� �ڵ�
                ' '' ''        'Debug.Print(.Rows(rowNumber).Item("OrganizationCode").ToString())

                ' '' ''    ElseIf .Rows(rowNumber).Item("CodeAttributeCode") = "2" Then
                ' '' ''        BizForm.GbranchCode = .Rows(rowNumber).Item("OrganizationCode").ToString().Substring(0, 4) '�� �ڵ�
                ' '' ''        BizForm.GbranchName = .Rows(rowNumber).Item("CodeName") '�� ��
                ' '' ''        'BizForm.GorganizationCode = .Rows(rowNumber).Item("OrganizationCode") '���� �ڵ�
                ' '' ''        Debug.Print(.Rows(rowNumber).Item("OrganizationCode").ToString())

                ' '' ''    ElseIf .Rows(rowNumber).Item("CodeAttributeCode") = "3" Then
                ' '' ''        BizForm.GteamCode = .Rows(rowNumber).Item("OrganizationCode").ToString().Substring(0, 6) '�� �ڵ�
                ' '' ''        BizForm.GteamName = .Rows(rowNumber).Item("CodeName") '�� ��
                ' '' ''        'BizForm.GorganizationCode = .Rows(rowNumber).Item("OrganizationCode") '���� �ڵ�
                ' '' ''        Debug.Print(.Rows(rowNumber).Item("OrganizationCode").ToString())

                ' '' ''    ElseIf .Rows(rowNumber).Item("CodeAttributeCode") = "4" Then
                ' '' ''        BizForm.GpartCode = .Rows(rowNumber).Item("OrganizationCode").ToString().Substring(0, 8) '��Ʈ �ڵ�
                ' '' ''        BizForm.GpartName = .Rows(rowNumber).Item("CodeName") '��Ʈ ��
                ' '' ''        'BizForm.GorganizationCode = .Rows(rowNumber).Item("OrganizationCode") '���� �ڵ�
                ' '' ''        Debug.Print(.Rows(rowNumber).Item("OrganizationCode").ToString())

                ' '' ''    ElseIf .Rows(rowNumber).Item("CodeAttributeCode") = "5" Then
                ' '' ''        BizForm.GpcCode = .Rows(rowNumber).Item("OrganizationCode").ToString().Substring(0, 10) 'pc �ڵ�
                ' '' ''        BizForm.GpcName = .Rows(rowNumber).Item("CodeName") ' pc ��
                ' '' ''        'BizForm.GorganizationCode = .Rows(rowNumber).Item("OrganizationCode") '���� �ڵ�
                ' '' ''        Debug.Print(.Rows(rowNumber).Item("OrganizationCode").ToString())

                ' '' ''    ElseIf .Rows(rowNumber).Item("CodeAttributeCode") = "6" Then
                ' '' ''        BizForm.GcornerCode = .Rows(rowNumber).Item("OrganizationCode").ToString().Substring(0, 12) '�ڳ� �ڵ�
                ' '' ''        BizForm.GcornerName = .Rows(rowNumber).Item("CodeName") ' �ڳ� ��
                ' '' ''        'BizForm.GorganizationCode = .Rows(rowNumber).Item("OrganizationCode") '���� �ڵ�
                ' '' ''        Debug.Print(.Rows(rowNumber).Item("OrganizationCode").ToString())
                ' '' ''    End If
                ' '' ''Next rowNumber
            End With

            BizForm.GLoginId = Trim(Me.txtLoginID.Text) '�α��� id
            BizForm.GLoginPassword = Me.txtPassword.Text '�α��� �н�����

            reciveDataSet = Nothing
            tempExecuteDbCommand = Nothing
            tempCommonFunction = Nothing
            tempSqlParameter = Nothing

            BizForm.Login(Me)

        End Sub



        '====================================================================================================
        Private Function VersionCheck()
            '2007 06 09 �� �ۼ� - ������ �������� ���� ���� ��ġ�� ���� / ���� �� ��� ����
            '�ӽ� ��� / �ֽ� ���� Ȯ�� �� �ƴ� ��� �ֽ� ������ ��ġ �ϵ��� ����
            VersionCheck = False

            Dim tempAssemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName()
            Dim currentAssemblyName As String()
            currentAssemblyName = Split(tempAssemblyName, ",")

            Dim tempsqlparameter() As SqlParameter = Nothing
            Dim tempexecutedbcommand As New DAT.ExecuteDbCommand

            GmainCommonFunction.SetSqlParameter(tempsqlparameter, "@AAssemblyName", currentAssemblyName(0).ToString())
            Dim recivedataset As DataSet = tempexecutedbcommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "DEPLOYINFO_R", False, True, tempsqlparameter)

            '�ֽ� ���� �� ���� ����-DB�� ��� �ִ� �ֽ� ���� ������ ������ �� ���� ������� ���� ������ ��
            If recivedataset.Tables(0).Rows.Count > 0 Then
                If recivedataset.Tables(0).Rows(0).Item(0).ToString() = GmainCommonFunction.versionInfo() Then
                    VersionCheck = True
                Else
                    'DB���� �ҷ��� �޼��� ���!
                    MessageDialog.rTxtBoxContents.Text = ""
                    MessageDialog.rTxtBoxContents.Text = recivedataset.Tables(0).Rows(0).Item(1).ToString()
                    VersionCheck = False
                End If
            Else
                'DB���� �޽��� �� ������ �� ������ ���� �ϵ� �ڵ� �޼��� ���!
                MessageDialog.rTxtBoxContents.Text = ""
                MessageDialog.rTxtBoxContents.Text = "�����ڿ��� ���� �ϼ���. (���� : )"
                VersionCheck = False
            End If

        End Function

        '====================================================================================================
        Private Sub txtLoginID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoginID.KeyPress
            If e.KeyChar = ChrW(Keys.Return) Then
                Me.txtPassword.Focus()
            End If
        End Sub

        '====================================================================================================
        Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
            If e.KeyChar = ChrW(Keys.Return) Then
                picLogin_MouseClick(Nothing, Nothing)
            End If
        End Sub

        '====================================================================================================
        Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
            Me.Close()
            Me.Dispose()
        End Sub

        '====================================================================================================
        Private Sub picLogin_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogin.MouseEnter
            Me.picLogin.Image = Global.My.Resources.Resources.login00
            Me.Cursor = Cursors.Hand
        End Sub

        '====================================================================================================
        Private Sub picLogin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogin.MouseLeave

            Me.picLogin.Image = Global.My.Resources.Resources.login01
            Me.Cursor = Cursors.Default
        End Sub

        '====================================================================================================
        Private Sub picClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.MouseEnter
            sender.Image = Global.My.Resources.Resources.close01
            Me.Cursor = Cursors.Hand
        End Sub

        '====================================================================================================
        Private Sub picClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.MouseLeave
            sender.Image = Global.My.Resources.Resources.close
            Me.Cursor = Cursors.Default
        End Sub

        '��ȣ ����� �ش� ��Ʈ�� visible ����
        Private Sub sbSetChangePasswordMode(ByVal PasswordChangeYes As Boolean)

            lblNewPassword.Visible = PasswordChangeYes
            txtNewPassword.Visible = PasswordChangeYes
            txtNewPassword2.Visible = PasswordChangeYes
            picOk.Visible = PasswordChangeYes
            picCancel.Visible = PasswordChangeYes

            picLogin.Visible = Not (PasswordChangeYes)
            picChangePassword.Visible = Not (PasswordChangeYes)

        End Sub

        '��ȣ ���� ��ư Ŭ��
        Private Sub picChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChangePassword.Click
            sbSetChangePasswordMode(IIf(txtNewPassword.Visible, False, True))
        End Sub

        '��ȣ ���� ����
        Private Sub picOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOk.Click

            Dim blnPasswordChangeMode As Boolean = False
            Dim blnPasswordChangeOk As Boolean = True
            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim tempCommonFunction As New ubiLease.CommonFunction.Common

            Try
                '��ȣ ���� 
                If txtNewPassword.Text <> txtNewPassword2.Text Then
                    MessageBox.Show("�ű� ��ȣ�� ������ Ʋ���ϴ�.")
                    blnPasswordChangeOk = False
                End If

                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AuserId", Trim(Me.txtLoginID.Text))
                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@Apassword", Trim(Me.txtPassword.Text))
                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AnewPassword", Trim(Me.txtNewPassword.Text))
                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AIpAddress", Trim(ubiLease.DAT.localhostinfo.localIPAddress()))
                ' sp Id �߰�

                Dim tempExecuteDbCommand As New ubiLease.DAT.ExecuteDbCommand
                Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "ChangePassword", False, True, tempSqlParameter)

                If reciveDataSet.Tables(0).Rows.Count = 0 Then
                    MsgBox("�������� �ʴ� ���̵� �̰ų�, ��й�ȣ�� �ٸ��� �ʽ��ϴ�. �ٸ��� �ۼ� �� �α����Ͽ� �ֽʽÿ�!", MsgBoxStyle.Information, "��ȣ ���� ����")
                    Exit Sub
                End If

                If reciveDataSet.Tables(0).Rows(0).Item(0) <> "OK" Then
                    MsgBox(reciveDataSet.Tables(0).Rows(0).Item(1), MsgBoxStyle.Information, "��ȣ ���� ����")
                    Exit Sub
                End If

                '���� ����� 
                If blnPasswordChangeOk Then
                    blnPasswordChangeMode = False
                Else
                    blnPasswordChangeMode = True
                    txtNewPassword.Focus()
                End If

                sbSetChangePasswordMode(blnPasswordChangeMode)
            Catch ex As Exception
                Gexception.getException(ex)
            End Try

        End Sub

        '��ȣ ���� ���
        Private Sub picCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.Click
            txtNewPassword.Text = vbNullString
            txtNewPassword2.Text = vbNullString
            sbSetChangePasswordMode(IIf(txtNewPassword.Visible, False, True))
        End Sub

        Private Sub frmLogin_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
            BizForm.Dispose()
        End Sub

        Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                Me.lblTitle.Text = ConfigurationManager.AppSettings("SystemTitle").ToString()
                'Panel1.BackColor = Color.FromArgb(238, 238, 222)
                Panel1.BackColor = Color.FromArgb(246, 246, 246)
                If Me.DesignMode = False Then

                    Dim fdm As FontDeployManager = New FontDeployManager()
                    fdm.FontDeploy()
                    'Me.WebBrowser1.Url = New System.Uri(ConfigurationManager.AppSettings("LoginFlashPath").ToString())
                End If
            Catch mainException As Exception
                Gexception.getException(mainException)
            End Try
        End Sub

        Public Shared Sub copyShortcut(ByVal manufacturerName As String, ByVal shortcutFileName As String)

            Dim desktopPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + shortcutFileName
            Dim startPath As String = My.Computer.FileSystem.SpecialDirectories.Programs + "\" + manufacturerName + "\" + shortcutFileName
            Try
                System.IO.File.Copy(startPath, desktopPath, True)
            Catch mainException As Exception
                'Gexception.getException(mainException)
            End Try
        End Sub

        Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
            Me.txtLoginID.Focus()
        End Sub



        Private Sub picOk_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOk.MouseEnter
            Me.picOk.Image = Global.My.Resources.ok_01
            Me.Cursor = Cursors.Hand
        End Sub


        Private Sub picOk_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOk.MouseLeave
            Me.picOk.Image = Global.My.Resources.ok_00
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub picCancel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.MouseEnter
            Me.picCancel.Image = Global.My.Resources.cancle_01
            Me.Cursor = Cursors.Hand
        End Sub

        Private Sub picCancel_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.MouseLeave
            Me.picCancel.Image = Global.My.Resources.cancle_00
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub picChangePassword_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChangePassword.MouseEnter
            Me.picChangePassword.Image = Global.My.Resources.password01
            Me.Cursor = Cursors.Hand
        End Sub

        Private Sub picChangePassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChangePassword.MouseLeave
            Me.picChangePassword.Image = Global.My.Resources.password00
            Me.Cursor = Cursors.Default
        End Sub

    End Class

End Namespace

