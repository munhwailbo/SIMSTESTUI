'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ���Ȯ���� ȸ�� ���
' form ���� : ���Ȯ���� ȸ�� ���
' �ۼ��� : Ȳ����
' �ۼ��� : 2008.11.14
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNJ201
        Inherits CommonControls.UiControl

        Private Sub PNJ201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|������;PublishYearMonth;70;####-##;c;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|ȸ��������ȣ;RedeemBranchNum;81;;l;" & "io;n;n;9;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|ȸ��������;BranchNm;89;;l;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|�����ǹ����ڵ�;CouponPublicCd_2;1;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;1;;c;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;95;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|����󼼼���;DetailOrders;85;;c;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��������;PublishDt;85;####-##-##;c;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|ȸ������;RedeemDt;85;####-##-##;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����;Orders;35;;c;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|���ڵ�;PublishBarCode;180;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|���ڸ������;ReaderListYN;80;;c;" & "io;n;n;1;"
            gridAttributes = gridAttributes & "|����ܰ�;UnitCost;80;#,##0;r;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|ȸ���ܰ�;RedeemUnitAmt;80;#,##0;r;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|ȸ�����;PayYYYYMM;80;;c;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|ȸ������;RedeemYN;55;;c;" & "io;n;n;1;"
            gridAttributes = gridAttributes & "|�����ǹ����ڵ�;CouponSeriesNum;1;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|;Dum;5;;l;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|�űԱ���;IsExist;1;;l;" & "o;n;y;9;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            ''
            Me.numRedeemUnitCost.Text = 15000



        End Sub
#End Region

        Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

            If Me.grd_1.Rows < 2 Then
                Exit Sub
            End If

            'If IsDate(strPayYYYYMM) = False Then
            '    MessageBox.Show("���޳����  Ȯ���� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            If ValidationChk() Then
            Else
                Exit Sub
            End If
            Dim strPublishDt As String = ""

            For inti As Integer = 0 To Me.grd_1.Rows - 1
                If Me.grd_1.GetCellCheck(inti, Me.grd_1.get_ColIndex("����")) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                    Me.grd_1.set_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemBranchNum"), Me.popBranchCd.TextValue)
                    Me.grd_1.set_TextMatrix(inti, Me.grd_1.get_ColIndex("BranchNm"), Me.popBranchCd.NameText)
                    Me.grd_1.set_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemDt"), Me.dtpRedeemDt.Text)
                    Me.grd_1.set_TextMatrix(inti, Me.grd_1.get_ColIndex("PayYYYYMM"), Me.dtpPayYYYYMM.Text)
                    Me.grd_1.SetCellCheck(inti, Me.grd_1.get_ColIndex("RedeemYN"), C1.Win.C1FlexGrid.CheckEnum.Checked)
                    Me.grd_1.set_TextMatrix(inti, Me.grd_1.get_ColIndex("RedeemUnitAmt"), Me.numRedeemUnitCost.Text)
                End If
            Next inti

        End Sub

        Private Function ValidationChk() As Boolean

            If Me.popBranchCd.NameText = "" Then
                MessageBox.Show("ȸ�������� �ݵ�� ������ �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim strRedeemDt As String = Me.dtpRedeemDt.Text
            Dim strPayYYYYMM As String = Me.dtpPayYYYYMM.Text + "-01"

            If IsDate(strRedeemDt) = False Then
                MessageBox.Show("ȸ��������  Ȯ���� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If Me.numRedeemUnitCost.TextValue = 0 Then
                MessageBox.Show("ȸ���ܰ���  �Է��� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If


            Return True
        End Function

        Private Sub grd_1_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1
                If Me.grd_1.Rows < 2 Then
                    Exit Sub
                End If

                If .ColSel = .get_ColIndex("DetailOrders") Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                Else
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                End If

            End With
        End Sub

        Private Sub btnContine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContine.Click

            If ValidationChk() Then
                If Me.txtBarCode.Text.Length = 0 Then
                    MessageBox.Show("�����ȣ��  �Է��� �۾��ϼ���", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Me.RequestData_BarcodeChk(False)
                Me.popBranchCd.Focus()
            Else
                Exit Sub
            End If

        End Sub

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try
                'If blnApprovalAll = False Then
                With grd_1
                    If (.Rows > .FixedRows) Then
                        For inti = .FixedRows To .Rows - 1
                            '''' ���� ����, ȸ�� ����, ȸ�� ���� ���� Ȯ�� �� ó�� 
                            If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked _
                               And .GetCellCheck(inti, .get_ColIndex("RedeemYN")) = CheckEnum.Checked _
                               And .get_TextMatrix(inti, .get_ColIndex("RedeemDt")).ToString() > "1" Then
                                .set_TextMatrix(inti, .get_ColIndex("RedeemUnitAmt"), numApplyUnitCost.TextValue)
                                .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                            End If
                        Next inti
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub chkRedeemDt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRedeemDt.CheckedChanged
            dtpRedeemDt_FR.Enabled = chkRedeemDt.Checked
            dtpRedeemDt_To.Enabled = chkRedeemDt.Checked
        End Sub
    End Class

End Namespace
