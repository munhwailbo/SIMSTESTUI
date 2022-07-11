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

    Public Class PNI104
        Inherits CommonControls.UiControl
        '====================================================================================================
        

#Region "�� �ʱ�ȭ"

        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|���;CalYearMonths;63;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;96;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;76;;1;" & "o;n;y;9;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;76;;4;" & "o;n;y;5;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;65;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�Ϲݴܰ�;ValPaperUnit1;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����Ǵܰ�;ValPaperUnit2;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��Ÿ�ܰ�1;ValPaperUnit3;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|��Ÿ�ܰ�2;ValPaperUnit4;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�Ϲ������μ�;ValPaperNum1;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����������μ�;ValPaperNum2;86;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��Ÿ�����μ�1;ValPaperNum3;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|��Ÿ�����μ�2;ValPaperNum4;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�����μ���;ValPaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����μ���;NoValPaperNum;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�߼ۺμ���;PaperNumT;74;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�Ϲݸ���;ValPaperSale1;76;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�����Ǹ���;ValPaperSale2;76;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|��Ÿ����1;ValPaperSale3;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|��Ÿ����2;ValPaperSale4;76;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|�����;SalesAmt;78;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;80;;4;" & "o;n;n;10;���������ڵ�;BranchRegionNm"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;96;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            ''gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            sbSetGridColDisp()

            '����� ����
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("������翩��") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("���Ҵ�����").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("�α��� ID"), _
                                                GmainBusinessFunction.GetValue("���Ҵ�����"))
            End If

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
        Private Sub ACA003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


#Region "�׸��� ȭ�� ǥ��"
        '' <summary>
        ''  �׸��� ȭ�� ǥ�� 
        '' </summary>
        '' <param name="sender"></param>
        '' <param name="e"></param>
        '' <remarks></remarks>
        '' ---- �׸��� �׸� ǥ�� ���� 
        Private Sub sbSetGridColDisp()

            With Me.grd_1
                '' �μ�ǥ��
                'If chkPaperNum.Checked = True Then
                'End If

                '' �ܰ�ǥ��
                'If chkPaperNum.Checked = True Then
                'End If

                '' �Ϲ�����
                .set_ColHidden(.get_ColIndex("ValPaperNum1"), Not (chkValPaper1.Checked))    ' �μ�
                .set_ColHidden(.get_ColIndex("ValPaperUnit1"), Not (chkValPaper1.Checked))   ' �ܰ�
                .set_ColHidden(.get_ColIndex("ValPaperSale1"), Not (chkValPaper1.Checked))   ' ����
                If chkValPaper1.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum1"), Not (chkPaperNum.Checked))      ' �Ϲݺμ�
                    .set_ColHidden(.get_ColIndex("ValPaperUnit1"), Not (chkUnitAmount.Checked))   ' �Ϲݴܰ�
                End If
                '' ����������  
                .set_ColHidden(.get_ColIndex("ValPaperNum2"), Not (chkValPaper2.Checked))    ' �μ�
                .set_ColHidden(.get_ColIndex("ValPaperUnit2"), Not (chkValPaper2.Checked))   ' �ܰ�
                .set_ColHidden(.get_ColIndex("ValPaperSale2"), Not (chkValPaper2.Checked))   ' ����
                If chkValPaper2.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum2"), Not (chkPaperNum.Checked))      ' �����Ǻμ�
                    .set_ColHidden(.get_ColIndex("ValPaperUnit2"), Not (chkUnitAmount.Checked))   ' �����Ǵܰ�
                End If
                '' ��Ÿ����1
                .set_ColHidden(.get_ColIndex("ValPaperNum3"), Not (chkValPaper3.Checked))    ' �μ�
                .set_ColHidden(.get_ColIndex("ValPaperUnit3"), Not (chkValPaper3.Checked))   ' �ܰ�
                .set_ColHidden(.get_ColIndex("ValPaperSale3"), Not (chkValPaper3.Checked))   ' ����
                If chkValPaper3.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum3"), Not (chkPaperNum.Checked))      ' ��Ÿ�μ�1
                    .set_ColHidden(.get_ColIndex("ValPaperUnit3"), Not (chkUnitAmount.Checked))   ' ��Ÿ�ܰ�1
                End If
                '' ��Ÿ����2
                .set_ColHidden(.get_ColIndex("ValPaperNum4"), Not (chkValPaper4.Checked))    ' �μ�
                .set_ColHidden(.get_ColIndex("ValPaperUnit4"), Not (chkValPaper4.Checked))   ' �ܰ�
                .set_ColHidden(.get_ColIndex("ValPaperSale4"), Not (chkValPaper4.Checked))   ' ����
                If chkValPaper4.Checked = True Then
                    .set_ColHidden(.get_ColIndex("ValPaperNum4"), Not (chkPaperNum.Checked))      ' ��Ÿ�μ�2
                    .set_ColHidden(.get_ColIndex("ValPaperUnit4"), Not (chkUnitAmount.Checked))   ' ��Ÿ�ܰ�2
                End If
            End With

        End Sub

        Private Sub chkValPaper1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper1.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkValPaper2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper2.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkValPaper3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper3.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkValPaper4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkValPaper4.Click
            sbSetGridColDisp()
        End Sub


        Private Sub chkPaperNum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPaperNum.Click
            sbSetGridColDisp()
        End Sub

        Private Sub chkUnitAmount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUnitAmount.Click
            sbSetGridColDisp()
        End Sub
#End Region

    End Class

End Namespace
