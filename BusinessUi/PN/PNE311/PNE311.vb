'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ�Ϻ� �ڵ� ����
' �ۼ��� : ������
' �ۼ��� : 2008.09.01
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

    Public Class PNE311
        Inherits CommonControls.UiControl
        Dim blnApprovalAll As Boolean = False

        Private Sub PNE311_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;0;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|����;ChargeEmpNm;93;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;76;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;4;" & "o;n;y;5;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;62;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ����;CalYearMonths;63;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�űԺμ�(a);Ext_Sa_New;78;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��Ȯ�� ����;Ext_Sa_ReNew1;78;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��Ȯ�� �ߺ�;Ext_Sa_Dup;78;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��Ȯ�� �ű�;Ext_Sa_ReNew2;78;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��Ȯ�� ��(b);Ext_Sa_ReNewTot;83;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��Ȯ������(c);Ext_Sa_ReNewInc;91;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��Ȯ��μ�(a+b);Ext_Sa_Tot;106;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|���Ȯ������(e);Stp_Sa_Tot;103;#,##0;4;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|;uZZALCA;200;;1;" & "o;n;n;1000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ColTypeCd;�Աݱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

           
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region

        '' '' ''Private Sub grd_1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.AfterEdit
        '' '' ''    SetTotalValue()
        '' '' ''End Sub

        '' '' ''Private Sub SetTotalValue()

        '' '' ''    Dim TotalValue As Long
        '' '' ''    Dim CurruntRow As Long

        '' '' ''    With grd_1
        '' '' ''        If .Rows > 1 Then
        '' '' ''            CurruntRow = .GetCurrentRowCellValue("")

        '' '' ''            '��ü �ݾ� ó�� (Ȯ��� - ��ü�ݾ� = ��ü�ݾ�)
        '' '' ''            TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("SupAmt")).ToString.Replace(",", "")) _
        '' '' ''                             - Val(.get_TextMatrix(CurruntRow, .get_ColIndex("DeductAmt")).ToString.Replace(",", ""))
        '' '' ''            .set_TextMatrix(CurruntRow, .get_ColIndex("TransferAmt"), TotalValue.ToString)
        '' '' ''        End If
        '' '' ''    End With

        '' '' ''End Sub

    End Class

End Namespace
