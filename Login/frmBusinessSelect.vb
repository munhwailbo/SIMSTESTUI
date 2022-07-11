Imports Microsoft.VisualBasic
Imports VBN = Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Configuration

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Imports System.Reflection
Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.UI

Namespace ubiLease.UI.Login

    Public Class frmBusinessSelect

        'Private WithEvents BizSelect As ubiLease.CommonFunction.ubiUtility.BusinessSelect
        'Sub New()

        '    InitializeComponent()
        '    ''
        '    BizSelect = New ubiUtility.BusinessSelect
        '    BizSelect.Register(New ubiUtility.BusinessSelect._businessSelect(AddressOf selectBiz))
        'End Sub

        'Private Sub selectBiz(ByVal businessid As String)

        'End Sub


        Private Declare Function ReleaseCapture Lib "user32" () As Integer
        Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParm As Integer, ByRef lParm As String) As Long
        Private Gexception As DAT.CustomException = New DAT.CustomException

        'Private testName As frmAlarm.Alarm = Nothing

        Public GbusinessPalceCode As String = "" '����� �ڵ�
        Public GbusinessPalceName As String = "" '����� ��

        'Public GorganizationCode As String = "" '���� �ڵ�

        Public GbranchCode As String = "" '�� �ڵ�
        Public GbranchName As String = "" '���� ��

        Public GteamCode As String = "" '�� �ڵ�
        Public GteamName As String = "" '�� ��

        Public GpartCode As String = "" '��Ʈ �ڵ�
        Public GpartName As String = "" '��Ʈ ��

        Public GpcCode As String = "" 'pc �ڵ�
        Public GpcName As String = "" 'pc ��

        Public GcornerCode As String = "" '�ڳ� �ڵ�
        Public GcornerName As String = "" '�ڳ� ��

        Public GLoginId As String = "" '�α��� id
        Public GLoginName As String = "" '�α��� ��

        Public GMngEmpYN As String = ""

        Public GRoleEmpNum As String = "" ' ������ ���

        Public GUserGrade As String = "" ' ��پ��� ��Ȱ

        Public GBizEmpYN As String = "" ' ��������� ����




        Public GLoginPassword As String = "" '�α��� �н�����

        ' �Խ��� �߰��� ���� �ɹ� ��ü
        Private GmainCommonFunction As CommonFunction.Common = Nothing
        Private GmainExecuteDbCommand As DAT.ExecuteDbCommand = Nothing
        Private GmainsqlParameters() As SqlParameter = Nothing

        Private IsPermitionSettingApply As Boolean = False

        Private MloginForm As Form = Nothing


        '' ������ ���� Static Value �� ����Ͽ� ó���� ���
        '====================================================================================================
        Public Sub Login(ByVal AinputForm As Object)

            MloginForm = AinputForm
            Me.Show()

            For Each eachItem As Object In Me.notifyMenuStripMain.Items
                eachItem.Enabled = False
            Next
            ' ���� ���� 1
            If IsPermitionSettingApply = False Then
                CheckBusinessPermition()
            End If
        End Sub

        Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown, picMain.MouseDown
            Call ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0&)
        End Sub

        Public Sub frmBusinessSelect_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
            Me.notifyIconMain.Dispose()
        End Sub

        ' �ʱⰪ �ε�
        '====================================================================================================
        Private Sub frmBusinessSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            GmainCommonFunction = New CommonFunction.Common
            '' �������� ������Ʈ �ּ�
            '' Me.WebBrowser1.Url = New System.Uri(ConfigurationManager.AppSettings("NoticeWebPagePath").ToString(), System.UriKind.Absolute)

            LoadImage()
            LoadBusinessList()


            '===================================================================
            '' CTI ���
            Dim cti As ComRegDeploy = New ComRegDeploy()
            cti.CtiRegistor()
        End Sub

        Private Sub LoadBusinessList()

            Dim onClick As EventHandler = New EventHandler(AddressOf picBusiness_Click)
            Dim tempCommonFunction As New ubiLease.CommonFunction.Common
            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand
            Dim cmd As String = "select code, codeHangulName from commoncode where codedivision = '900' order by note4"
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), cmd)
            Dim titleFont As Font = New System.Drawing.Font("���� ���", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))

            If System.IO.File.Exists("C:\windows\fonts\H2HDRM.TTF") Then
                titleFont = New System.Drawing.Font("HY������M", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            End If


            ' =================================================
            ' ���� Ʈ���� �߰� , Disable ó����.
            Me.notifyMenuStripMain.Items.Clear()
            Me.flp_BusinessBtn.FlowDirection = FlowDirection.LeftToRight

            For Each dr As DataRow In reciveDataSet.Tables(0).Rows

                '' ==============================================================
                '' Ʈ���̿� ���� �߰�
                Me.notifyMenuStripMain.Items.Add(dr("codeHangulName", DataRowVersion.Current).ToString(), Nothing, onClick)

                ''===============================================================
                '' �÷ο쿡 ���� ��ư ����

                Dim imgbtn_tmp As ubiLease.CommonControls.imgbtn = New ubiLease.CommonControls.imgbtn()

                With imgbtn_tmp
                    '.BackColor = System.Drawing.Color.WhiteSmoke
                    '.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
                    .Border = False
                    .BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
                    '.BorderColor = Color.WhiteSmoke
                    .Font = titleFont
                    '.ForeColor = Color.WhiteSmoke
                    .ForeColor = Color.Black
                    .GroupKey = Nothing
                    .BackgroundImage = Global.My.Resources.Resources.bizB02
                    .BackgroundImageLayout = ImageLayout.Center
                    .HoverColor = System.Drawing.Color.Empty
                    '.HoverForeColor = System.Drawing.Color.White
                    .HoverImage = Global.My.Resources.Resources.bizB01
                    '.Image = Global.My.Resources.Resources.bizbg02
                    '.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
                    .Selected = False
                    .SelectedColor = System.Drawing.Color.LightGray
                    '.Size = New System.Drawing.Size(411, 40)
                    '.Size = New System.Drawing.Size(350, 60)
                    .Size = New System.Drawing.Size(355, 55)
                    .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    .Name = "imgbtn2_" + dr("code", DataRowVersion.Current).ToString()
                    .Text = Space(5) + dr("codeHangulName", DataRowVersion.Current).ToString() + " ����"
                    .Tag = dr("codeHangulName", DataRowVersion.Current).ToString()
                End With

                ' '' ==============================================================
                ' '' ��ư �߰�
                Me.flp_BusinessBtn.Controls.Add(imgbtn_tmp)
                AddHandler imgbtn_tmp.Click, onClick

            Next
            Me.notifyMenuStripMain.Items.Add("-")
            Me.notifyMenuStripMain.Items.Add("����", Nothing, onClick)

            For Each item As ToolStripItem In Me.notifyMenuStripMain.Items
                For Each dr As DataRow In reciveDataSet.Tables(0).Rows
                    If item.Text = dr("codehangulname", DataRowVersion.Current) Then
                        item.Name = "notiyMenu_" + dr("code", DataRowVersion.Current)
                        item.Enabled = False
                    End If
                Next
                If item.Text = "����" Then
                    item.Name = "notiyMenu_Exit"
                End If
                item.Select()
            Next

            ' =================================================
            ' ���� ��ư�� Disable ó����.
            picZS.Enabled = False
            picZS.Visible = False
            For Each eachItem As Control In Me.flp_BusinessBtn.Controls
                Dim getedType As Type = eachItem.GetType
                If getedType.Name = "imgbtn" Then
                    eachItem.Visible = False
                End If
            Next
        End Sub




        Private MmainUiForm() As Object = Nothing
        Private MrunProgramCount As Integer = 0

        ''====================================================================================================
        '' ���� ���� (�޴� ����)
        '' ������ ���� �޴����� ó���ϵ����մϴ�.
        '' ���ο��� �����ȣ�� ���α׷� ���� ������ üũ �Ҽ� �ֵ��� �մϴ�.
        '' get ���� ���� ����
        Private Sub CheckBusinessPermition()
            ' ��ư ��Ʈ���� �����´�.
            If IsPermitionSettingApply = False Then

                Dim tempCommonFunction As New ubiLease.CommonFunction.Common
                Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand

                Dim tempSqlParameter() As SqlClient.SqlParameter = Nothing
                tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", GLoginId)

                Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure(ConfigurationManager.AppSettings("SystemDB"), "GetBusinessPermintionByUser", False, True, tempSqlParameter)

                If IsNothing(reciveDataSet.Tables.Count) = False Then
                    For i As Integer = 0 To reciveDataSet.Tables(0).Rows.Count - 1

                        ' =================================================
                        ' �ش� ������ �̾����� ���� ��ư�� ���̰� ó����.
                        For Each eachItem As Control In Me.flp_BusinessBtn.Controls
                            Dim getedType As Type = eachItem.GetType
                            If getedType.Name = "imgbtn" Then
                                If reciveDataSet.Tables(0).Rows(i).Item(0).ToString = Strings.Right(eachItem.Name, 2) Then
                                    eachItem.Visible = True
                                    If reciveDataSet.Tables(0).Rows(i).Item(0).ToString = "SM" Then
                                        picZS.Enabled = True
                                        picZS.Visible = True
                                        eachItem.Visible = False
                                    End If
                                End If
                            End If
                        Next

                        ' ==============================================
                        ' Ʈ���� �����ܿ� ���� ���� ��Ȱ��ȭ �մϴ�.
                        ' Ʈ���� �������� ���� ����Ʈ�� ���̰� �մϴ�.

                        For Each eachItem As Object In Me.notifyMenuStripMain.Items
                            If reciveDataSet.Tables(0).Rows(i).Item(0).ToString = Strings.Right(eachItem.Name, 2) Then
                                eachItem.Enabled = True
                                eachItem.Visible = True
                            End If
                        Next
                    Next i
                End If
                ' ===================================================
                ' ���� Ȱ��ȭ
                Me.notifyMenuStripMain.Items("notiyMenu_Exit").Enabled = True

                reciveDataSet = Nothing
                tempExecuteDbCommand = Nothing
                tempCommonFunction = Nothing
                tempSqlParameter = Nothing
                IsPermitionSettingApply = True
            End If

        End Sub

        Private Sub picSysSetting_Click(sender As Object, e As EventArgs) Handles picZS.Click

            'LoadBusinessList()
            If sender.enabled Then
                sender.name = "SelectSM"
                sender.text = "�ý��۰���"
                picBusiness_Click(sender, e)
            End If

        End Sub

        '====================================================================================================
        ' �ش� ���� ����
        Private Sub picBusiness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            If ProcessExit(sender.Name) = True Then
                Exit Sub
            End If

            '' ���� ����
            Me.Visible = False


            '' ���ο� ���� ���� �������� ����
            If CheckCreadedProgram(sender.Name, True) = False Then
                Exit Sub
            End If

            ''  
            Dim businessDivisionName As String = ""

            If Replace(sender.Tag, " ", "") <> "" Then
                businessDivisionName = Replace(sender.Tag, " ", "")
            Else
                businessDivisionName = Replace(sender.Text, "", "")
            End If

            ''
            If InStr(sender.Name, "Select") = 0 Then
                sender.Name = "Select" & Strings.Right(sender.Name, 9)
            End If

            ''

            If IsNothing(MmainUiForm) = True Then
                ReDim MmainUiForm(0)
            Else
                ReDim Preserve MmainUiForm(MmainUiForm.Length)
            End If


            ''
            MmainUiForm(MmainUiForm.Length - 1) = New UI.MainUi.frmMainUi


            ''
            With MmainUiForm(MmainUiForm.Length - 1)


                .GmainBusinessFunction.SetValue("����� �ڵ�", GbusinessPalceCode)
                .GmainBusinessFunction.SetValue("����� ��", GbusinessPalceName)

                .GmainBusinessFunction.SetValue("�� �ڵ�", GbranchCode)
                .GmainBusinessFunction.SetValue("�� ��", GbranchName)

                .GmainBusinessFunction.SetValue("�� �ڵ�", GteamCode)
                .GmainBusinessFunction.SetValue("�� ��", GteamName)

                .GmainBusinessFunction.SetValue("��Ʈ �ڵ�", GpartCode)
                .GmainBusinessFunction.SetValue("��Ʈ ��", GpartName)

                .GmainBusinessFunction.SetValue("PC �ڵ�", GpcCode)
                .GmainBusinessFunction.SetValue("PC ��", GpcName)

                .GmainBusinessFunction.SetValue("�ڳ� �ڵ�", GcornerCode)
                .GmainBusinessFunction.SetValue("�ڳ� ��", GcornerName)

                ' �α��� ���� ����
                .GmainBusinessFunction.SetValue("�α��� ID", GLoginId)

                .GmainBusinessFunction.SetValue("�α��� ��", GLoginName)

                .GmainBusinessFunction.SetValue("���Ҵ�����", GRoleEmpNum)

                .GmainBusinessFunction.SetValue("����ڵ��", GUserGrade)

                .GmainBusinessFunction.SetValue("������翩��", GBizEmpYN)

                .GmainBusinessFunction.SetValue("������翩��", GMngEmpYN)


                .lblLogin.Text = GpartName & " / " & GLoginName
                .lblLoginTime.Text = Format(Now, "HH:mm:ss")

                ' ���� �������� ����
                Try
                    .BusinessSelect(Me, Strings.Right(sender.Name, 2), businessDivisionName)

                Catch ex As Exception
                    Gexception.getException(ex)
                End Try

            End With

            'Debug.Print(Strings.Right(sender.Name, 2), Replace(sender.Text, " ", ""))
        End Sub

        Private Declare Sub SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer)
        Private Const HWND_TOP = 0
        Private Const SWP_SHOWWINDOW = &H40

        '====================================================================================================
        ' ���� MainForm ȣ�� ���� �Ǵ�
        Public Function CheckCreadedProgram(ByVal AbusinessDivision As String, ByVal ACheck As Boolean) As Boolean

            CheckCreadedProgram = False

            If IsNothing(MmainUiForm) = False Then
                For forNumber As Integer = 0 To MmainUiForm.Length - 1 Step 1
                    If IsNothing(MmainUiForm(forNumber)) = False Then
                        If MmainUiForm(forNumber).GmainCommonFunction.GbusinessDivisionCode = Strings.Right(AbusinessDivision, 2) Then
                            If ACheck = True Then
                                MmainUiForm(forNumber).show()
                                Dim tempHandle As Integer = CInt(MmainUiForm(forNumber).Handle.ToString)

                                SetWindowPos(
                                    tempHandle, HWND_TOP, MmainUiForm(forNumber).Left, MmainUiForm(forNumber).Top, MmainUiForm(forNumber).Width, MmainUiForm(forNumber).Height - 1, SWP_SHOWWINDOW
                                )

                                Exit Function
                            Else
                                MmainUiForm(forNumber) = Nothing
                            End If
                        End If
                    End If
                Next forNumber
            End If

            If ACheck = True Then
                MrunProgramCount += 1
            Else
                MrunProgramCount -= 1
            End If

            For Each eachItem As Object In Me.notifyMenuStripMain.Items
                If Strings.Right(AbusinessDivision, 2) = Strings.Right(eachItem.Name, 2) Then
                    eachItem.Checked = ACheck
                    Exit For
                End If
            Next

            If ACheck = False Then
                For Each eachItem As Object In Me.flp_BusinessBtn.Controls
                    If _
                        Strings.Right(AbusinessDivision, 2) = Strings.Right(eachItem.Name, 2) _
                        And InStr(eachItem.Name, "imgbtn") >= 1 _
                        Then
                        eachItem.Name = Replace(eachItem.Name, "Select", "")
                        Exit For
                    End If
                Next
            End If

            CheckCreadedProgram = True

        End Function

        Private Sub LoadNotifyIconData()

            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), " select Code, CodeHangulName from CommonCode " _
             + "where codeDivisionHangulName = '�ý��� ���� ��'" +
             +"and PrivateUseYesOrNo = '1'"
            )

        End Sub

        '====================================================================================================
        ' �ش� ���� ���� ���� Ŭ��
        Private Sub notifyIconMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles notifyIconMain.DoubleClick

            Me.Show()

        End Sub

        '====================================================================================================
        ' ���� ���� ȭ�� �ݱ� Ŭ��
        Private Sub picClose_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
            Handles picClose.MouseClick _
            , picMinimumSize.MouseClick

            If sender.Name = "picClose" Then
                ProcessExit("Exit")
            ElseIf sender.Name = "picMinimumSize" Then
                Me.Hide()
            End If

        End Sub

        '====================================================================================================
        ' ���� ���� ó�� (����ǰ� �ִ� ���� ���� ���� ó��)
        Private Function ProcessExit(ByVal AmenuString As String) As Boolean
            If Strings.Right(AmenuString, 4) = "Exit" Then
                Dim returnMessageNumber As Integer = MsgBoxResult.Yes

                If MrunProgramCount >= 1 Then
                    Dim tempCommonFunction As New CommonFunction.Common

                    returnMessageNumber = MsgBox(
                        "'" & MrunProgramCount & "'" _
                        & "���� ���� ���� ���α׷��� ���� ���Դϴ�." _
                        & vbCrLf & "�׷��� �����Ͻðڽ��ϱ�?",
                        MsgBoxStyle.YesNo,
                        tempCommonFunction.GmessageTile
                    )
                    tempCommonFunction = Nothing
                End If

                If returnMessageNumber = MsgBoxResult.Yes Then
                    If IsNothing(MmainUiForm) = False Then
                        For forNumber As Integer = 0 To MmainUiForm.Length - 1 Step 1
                            If IsNothing(MmainUiForm(forNumber)) = False Then
                                MmainUiForm(forNumber).Close()

                                Try
                                    MmainUiForm(forNumber).Dispose()
                                Catch ex As Exception
                                    Gexception.getException(ex)
                                    Debug.WriteLine(ex.Message)
                                End Try
                            End If
                        Next forNumber
                    End If

                    MmainUiForm = Nothing

                    MloginForm.Close()
                    MloginForm.Dispose()

                    Me.notifyIconMain.Dispose()

                    LogOut()
                    Me.Close()
                    Me.Dispose()
                End If

                ProcessExit = True
            End If
        End Function
        Private Sub picZS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picZS.MouseEnter
            Me.Cursor = Cursors.Hand
            Try
                If sender.Name = "picZS" Then
                    sender.Image = Global.My.Resources.settings_on
                Else
                    sender.Image = Global.My.Resources.settings_on
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub
        Private Sub picZS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picZS.MouseLeave

            Me.Cursor = Cursors.Default
            Try
                If sender.Name = "picZS" Then
                    sender.Image = Global.My.Resources.settings
                Else
                    sender.Image = Global.My.Resources.settings
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub


        '====================================================================================================
        ' ���� ���� ȭ�� ���α׷� �����ư Ȱ��ȭ
        Private Sub picClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
           Handles picClose.MouseEnter _
           , picMinimumSize.MouseEnter

            Me.Cursor = Cursors.Hand
            Try
                If sender.Name = "picClose" Then
                    sender.Image = Global.My.Resources.close01
                ElseIf sender.Name = "picMinimumSize" Then
                    sender.Image = Global.My.Resources.�ּ�ȭ_01
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub

        '====================================================================================================
        ' ���� ���� ȭ�� ���α׷� �����ư ��Ȱ��ȭ
        Private Sub picClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles picClose.MouseLeave _
            , picMinimumSize.MouseLeave

            Me.Cursor = Cursors.Default
            Try
                If sender.Name = "picClose" Then
                    sender.Image = Global.My.Resources.close
                ElseIf sender.Name = "picMinimumSize" Then
                    sender.Image = Global.My.Resources.�ּ�ȭ_00
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                Debug.WriteLine(ex.Message)
            End Try
        End Sub

        '====================================================================================================
        ' ���� ���� ȭ�� ���α׷� ����
        Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles picClose.Click _
            , picMinimumSize.Click

            If sender.Name = "picClose" Then
                LogOut()
                Me.Close()
                Me.Dispose()
            ElseIf sender.Name = "picMinimumSize" Then
                Me.Hide()
            End If
        End Sub

        '====================================================================================================
        ' ���α׷� ����(�α� �ƿ� ó��)
        Private Sub LogOut()
            Dim QueryString As String = vbNullString
            Dim tempCommonFunction As New ubiLease.CommonFunction.Business
            Dim tempExecuteDbCommand As New DAT.ExecuteDbCommand

            'Dim tempSqlParameter() As SqlParameter = Nothing
            'tempCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", GLoginId)
            'Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteStoredProcedure("GetBusinessPermintionByUser", False, True, tempSqlParameter)

            QueryString = QueryString & "chkUserLogOut '" & tempCommonFunction.GetValue("�α��� ID") & "','" & ubiLease.DAT.localhostinfo.localIPAddress() & "'"
            Dim reciveDataSet As DataSet = tempExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), "Exec " & QueryString)

            reciveDataSet = Nothing
            tempExecuteDbCommand = Nothing
            tempCommonFunction = Nothing
        End Sub

        ' ���� ǥ��
        Private Sub frmBusinessSelect_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
            Me.lblVersion.Text = ConfigurationManager.AppSettings("SystemTitle").ToString() & Space(2) & GmainCommonFunction.versionInfo()
            Me.lblApplication.Text = Me.CompanyName & Space(2) & Me.GLoginId & Space(2) & Me.GLoginName
        End Sub

        ' ������ �亯
        Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
            Process.Start(ConfigurationManager.AppSettings("CustomRequestPagePath").ToString() & "?id=" & Me.GLoginId & "&pwd=" & Me.GLoginPassword)
        End Sub

        Public Sub LoadImage()
            Me.imgListMain.Images.Clear()
        End Sub

        ' Ʈ���� ������ ����/ �汤�� ���α׷� ����

        Private Sub frmBusinessSelect_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            notifyIconMain.Dispose()
        End Sub

    End Class
End Namespace

