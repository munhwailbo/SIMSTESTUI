'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �λ�������
' form ���� : 
' �ۼ��� : Ȳ����
' �ۼ��� : 2006-05-12
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNA201
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;1000;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;5000;;l;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|�Ի�����;JoinCompanyDate;5000;;l;" & "o;n;y;2;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '-- ���� ���� ��ư�� ó������ ������ �ʰ� �Ѵ�.
            Me.picOpen.Visible = False
            Me.picSave.Visible = False

            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNameHangul")

            Me.chkNtnHltInsAppYesOrNo.Checked = True
            Me.chkUnmInsAppYesOrNo.Checked = True
            Me.txtMeritoriousNumber.Visible = False
            Me.Label2.Visible = False

        End Sub

        Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
            btnPRB002.Click, btnPRB003.Click, btnPRB004.Click, btnPRB005.Click _
            , btnPRB006.Click, btnPRB007.Click, btnPRB009.Click _
            , btnPRB010.Click, btnPRB011.Click, btnPRB012.Click, btnPRB013.Click _
            , btnPRB014.Click, btnPRB015.Click, btnPRB016.Click

            If txtEmployeeNumber.TextValue = "" Then
                MessageBox.Show("�ݵ�� ����� ��ȸ�� ȭ�� �̵��� �ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim SeviceStatesCode2 As String = Me.cboSeviceStatesCode2.TextValue
            Dim EmployeeNameHangul As String = Me.txtEmployeeNameHangul.TextValue

            If SeviceStatesCode2 <> "" Then
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", SeviceStatesCode2 & ";" & EmployeeNameHangul & ";")
                Dim UiControlId As String = Mid(Me.ActiveControl.Name, 4, 6)

                If Me.CheckDataAllowPermitionByUser(UiControlId, GmainBusinessFunction.GetValue("�α��� ID"), "RequestData") = True Then
                    ' ������ �ִ� ���
                    Me.ShowUiControl(UiControlId, "")
                Else
                    MessageBox.Show("ȭ�� ���� ������ �����ϴ�.", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MsgBox("��ȸ�� ����� �����ϴ�.")
            End If

        End Sub

        Private Function CheckDataAllowPermitionByUser(ByVal AUiId As String, ByVal ALogInID As String, ByVal APermition As String) As Boolean
            Dim tempSqlParameter() As SqlParameter = Nothing
            Dim reciveDataSet As DataSet = Nothing

            Dim RequestPermition As String = ""
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AemployeeNumber", ALogInID)
            GmainCommonFunction.SetSqlParameter(tempSqlParameter, "@AprogramId", AUiId)

            reciveDataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("sdb", "GetScreeenPermintionByUser", False, True, tempSqlParameter)
            If IsNothing(reciveDataSet) = False Then
                If reciveDataSet.Tables(0).Rows.Count > 0 Then
                    RequestPermition = CType(reciveDataSet.Tables(0).Rows(0).Item(0), Integer)

                    If APermition = "RequestData" Then
                        CheckDataAllowPermitionByUser = IIf(RequestPermition = 1, True, False)
                    End If
                End If

            End If
        End Function

        Private Sub cboMarriageYesOrNoCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMarriageYesOrNoCode.TextChanged

            If Me.cboMarriageYesOrNoCode.SelectedItem = "1.��ȥ" Then
                Me.dtpMarriageDate.Visible = False
                Me.lblMarriageDate.Visible = False
            Else
                Me.dtpMarriageDate.Visible = True
                Me.lblMarriageDate.Visible = True
            End If

        End Sub

        Private Sub BtnImageSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImageSave.Click
            '-- �̹��� ����
            Call UpLoadImage()

        End Sub

        Private Sub chkMeritoriousTargetYesOrNo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMeritoriousTargetYesOrNo.CheckedChanged
            If Me.chkMeritoriousTargetYesOrNo.Checked = True Then
                Me.txtMeritoriousNumber.Visible = True
                Me.Label2.Visible = True
            Else
                Me.txtMeritoriousNumber.Visible = False
                Me.Label2.Visible = False
            End If
        End Sub

        Private Sub picOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOpen.Click

            Me.OpenFileDialog1.InitialDirectory = "c:\"
            Me.OpenFileDialog1.Filter = "�̹��� ���� (*.jpg)|*.jpg|�̹��� ���� (*.bmp)|*.bmp|��� ���� (*.*)|*.*"

            Try
                If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub picSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSave.Click
            '-- �̹��� ����
            Call UpLoadImage()
        End Sub

        Private Sub picOpen_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpen.MouseEnter

            Me.picOpen.Image = Me.ImageList1.Images(1)
            Me.Cursor = Cursors.Hand

        End Sub

        Private Sub picOpen_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOpen.MouseLeave

            Me.picOpen.Image = Me.ImageList1.Images(0)
            Me.Cursor = Cursors.Default

        End Sub

        Private Sub picSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSave.MouseEnter
            Me.picSave.Image = Me.ImageList1.Images(3)
            Me.Cursor = Cursors.Hand
        End Sub

        Private Sub picSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSave.MouseLeave
            Me.picSave.Image = Me.ImageList1.Images(2)
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub cboOpenPalanquinDivisionCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOpenPalanquinDivisionCode.LostFocus

            If Trim(Me.cboOpenPalanquinDivisionCode.TextValue).Length <> 0 Then
                If Me.cboOpenPalanquinDivisionCode.TextValue = "2" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = False
                    Me.Label3.Visible = False
                End If
                If Me.cboOpenPalanquinDivisionCode.TextValue = "1" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = True
                    Me.Label3.Visible = True
                End If
            End If

        End Sub

        Private Sub cboOpenPalanquinDivisionCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOpenPalanquinDivisionCode.TextChanged
            If Trim(Me.cboOpenPalanquinDivisionCode.TextValue).Length <> 0 Then
                If Me.cboOpenPalanquinDivisionCode.TextValue = "2" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = False
                    Me.Label3.Visible = False
                End If
                If Me.cboOpenPalanquinDivisionCode.TextValue = "1" Then
                    Me.cboMilitaryServiceDivisionCode.Visible = True
                    Me.Label3.Visible = True
                End If
            End If

        End Sub

        Private Sub txtInhabitantsNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInhabitantsNumber.LostFocus

            If Trim(Me.txtInhabitantsNumber.TextValue).Length = 13 Then
                Me.dtpOnesBirthday.TextValue = DateTime.ParseExact("19" + Me.txtInhabitantsNumber.TextValue.Substring(0, 6), "yyyyMMdd", Nothing)
                If Me.txtInhabitantsNumber.TextValue.Substring(6, 1) = "1" Then
                    Me.cboOpenPalanquinDivisionCode.TextValue = "1"
                Else
                    Me.cboOpenPalanquinDivisionCode.TextValue = "2"
                End If
            End If

        End Sub

        Private Sub txtInhabitantsNumber_TextChanged() Handles txtInhabitantsNumber.TextChanged
            If Trim(Me.txtInhabitantsNumber.TextValue).Length = 13 Then
                Me.dtpOnesBirthday.TextValue = DateTime.ParseExact("19" + Me.txtInhabitantsNumber.TextValue.Substring(0, 6), "yyyyMMdd", Nothing)
                If Me.txtInhabitantsNumber.TextValue.Substring(6, 1) = "1" Then
                    Me.cboOpenPalanquinDivisionCode.TextValue = "1"
                Else
                    Me.cboOpenPalanquinDivisionCode.TextValue = "2"
                End If
            End If
        End Sub

        Private Sub popOnesPositionDepartmentCode_TextChanged() Handles popOnesPositionDepartmentCode.TextChanged

        End Sub

        Private Sub PNA201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

        End Sub

        Private Sub btnSyncPersnalAffairHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncPersnalAffairHeader.Click
            SaveData_2()
        End Sub
    End Class
End Namespace
