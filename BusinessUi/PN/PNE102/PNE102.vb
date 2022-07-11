'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �������׸��������
' form ���� : ������ �׸��� ��� ���� �մϴ�.
' �ۼ��� : ������
' �ۼ��� : 2006-03-07
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

    Public Class PNE102
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|��������;ExpandDt;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;Orders;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|Ȯ���;ExpandNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "o;n;n;40;Ȯ��ó ��;CompanyNm;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|����;TargetPaperTotNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ű�;NewExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;60;;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��ܾ��ºμ�;NoListPapNum;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ȯ��;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;SubscribePagerNum;60;#,###;r;" & "o;n;y;5;"   '�ӽ� ���� 02.18
            gridAttributes = gridAttributes & "|������;NoSubscribePagerNum;60;#,###;r;" & "o;n;y;5;" '�ӽ� ���� 02.18

            gridAttributes = gridAttributes & "|��ܻ����ڵ�;ListStatCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���������ڵ�;CollectionDivCd;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|û������ڵ�;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ��ڵ�;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������������;FixedStDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�������޻���;BranchNote;70;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;ApprovalDt;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���;Note;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ListStatCd;��ܻ����ڵ�"    '' 2401
            gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"   ''2323
            gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            '--------------------------------------------------
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3

            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;80;#,###;c;" & "io;n;y;12;"
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;60;#,###;r;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|�����ڱ����ڵ�;SolicitorDivCd;80;;c;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|�������ڵ�;SolicitorEmpNum;80;;c;" & "io;n;n;5;��� ��;EmployeeNameHangul,SoliDeptCd,SoliDeptNm"
            gridAttributes = gridAttributes & "|�����;EmployeeNameHangul;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����μ��ڵ�;SoliDeptCd;80;;c;" & "io;n;n;40;�μ� ��;SoliDeptNm;"
            gridAttributes = gridAttributes & "|�����μ���;SoliDeptNm;80;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�ű�Ȯ��;FixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReFixedPaperNum;70;#,###;r;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���Ȯ��;TargetPaperTotNum;70;#,###;r;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|�����μ�;StopPaperNum;70;#,###;r;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|���ν�������;IndividualYN;80;;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|����������;RealSolicitorInfo;70;;c;" & "io;n;y;40;"
            gridAttributes = gridAttributes & "|�� ��;PayRemark;100;;l;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "SolicitorDivCd;�����ڱ����ڵ�"
            Dim gridCriteriaPopupCodeList As String = ""
            gridCriteriaPopupCodeList = gridCriteriaPopupCodeList & "EmployeeNameHangul;�����μ��ڵ�,�����μ���"
            grd_2.Initialize(gridAttributes, gridCodeNameList, gridCriteriaPopupCodeList)
            Me.grd_2.ExplorerBar = 3

        End Sub

        Private Sub PNE102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ''' <summary>
        ''' �Լ��� : PNE102_Enter 
        ''' ��  �� : ȭ�� ��ȯ(���Ȯ�� ������ ��ȸ)
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNE102_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("ȭ�� ��ȯ"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2), ShareParameters(3), ShareParameters(4), ShareParameters(5))
                GmainBusinessFunction.SetValue("ȭ�� ��ȯ", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' �Լ��� : Request
        ''' ��  �� : �ٸ� ȭ�鿡�� �ڵ� �� �޾Ƽ� �ش� ������ ��ȸ �Ѵ�.
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2008-08-10
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        Public Sub SetRequest(ByVal strFromDt As String, ByVal strToDt As String, ByVal strCompanyCd As String, ByVal strCompanyNm As String, ByVal strEmployeeExpNum As String)
            '�ٸ� ȭ�鿡�� ��ǥ ��ȣ�� �޾Ƽ� �ش� ��ǥ�� ��ȸ �Ѵ�.
            Me.dtpFromExpand.TextValue = strFromDt  '��������
            Me.dtpToExpand.TextValue = strToDt      '��������
            Me.popCompanyCd.TextValue = strCompanyCd  'Ȯ��ó��ȣ
            Me.popCompanyCd.NameText = strCompanyNm  'Ȯ��ó��
            ''Me.popCompanyCd.TextValue = strEmployeeExpNum  'Ȯ��������ȣ

            GrecordProcessMode = "2"   ' ��ȸ ���� ����
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub SetTotalValue(ByVal CurruntRow As Long)

            Dim TotalValue As Long
            ''Dim CurruntRow As Long

            With grd_2
                If .Rows > 1 Then
                    ''CurruntRow = .GetCurrentRowCellValue("")
                    'Ȯ���μ� ó��
                    TotalValue = Val(.get_TextMatrix(CurruntRow, .get_ColIndex("FixedPaperNum")).ToString.Replace(",", "")) _
                                     + Val(.get_TextMatrix(CurruntRow, .get_ColIndex("ReFixedPaperNum")).ToString.Replace(",", ""))
                    .set_TextMatrix(CurruntRow, .get_ColIndex("TargetPaperTotNum"), TotalValue.ToString)
                End If
            End With
        End Sub

        Private Sub grd_2_AfterEdit1(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_2.AfterEdit
            SetTotalValue(e.Row)
        End Sub

    End Class

End Namespace
