'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �翬�����
' form ���� : �翬�� �׸��� �����ϴ� ���α׷�
' �ۼ��� : �赿��
' �ۼ��� : 2009-02-28
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
Imports System.ComponentModel
Imports System.Data.SqlClient

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNE305
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;91;;1;" & "io;n;n;"
            gridAttributes = gridAttributes & "|Ȯ������;ExpandDt;93;yyyy-MM-dd;4;" & "o;n;n;"
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;90;;1;" & "o;n;n;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;90;;1;" & "o;n;n;"
            gridAttributes = gridAttributes & "|Ȯ�� ��;ExpandNm;150;;1;" & "o;n;n;"
            gridAttributes = gridAttributes & "|�����μ�;TargetPaperTotNum;60;;1;" & "o;n;n;"
            '�翬��μ�
            gridAttributes = gridAttributes & "|�翬��μ�;ReContPapNum;60;;1;" & "io;n;n;"
            '�����μ�


            gridAttributes = gridAttributes & "|������������;FixedStDt;91;yyyy-MM-dd;4;" & "o;n;n;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;82;yyyy-MM-dd;4;" & "o;n;n;"
            '������
            gridAttributes = gridAttributes & "|�����ڻ��;SolicitorEmpNum;82;;4;" & "o;n;n;"
            '�ϷῩ��

            '���
            gridAttributes = gridAttributes & "|���;Note;82;;4;" & " o;n;n;"


            'gridAttributes = gridAttributes & "|����;Orders;74;;1; " & " o;n;n;40"
            'gridAttributes = gridAttributes & "|�ű�Ȯ��;NewExpPapNum;58;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|��Ȯ��;ReExpPapNum;55;;1; " & " o;n;n;4"
            'gridAttributes = gridAttributes & "|��ܾ��ºμ�;NoListPapNum;61;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|Ȯ���μ�;FixedPaperNum;56;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;51;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|�����Ժμ�;NoSubscribePapNum;50;;1; " & " o;n;n"
            'gridAttributes = gridAttributes & "|��ܻ����ڵ�(2401);ListStatCd;70;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|���������ڵ�(2323);CollectionDivCd;78;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|û������ڵ�(2321);BillDivCd;99;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|û���ֱ��ڵ�(2111);BillPeriodCd;92;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|������ܰ�;SubscriptionAmt;78;;1; " & " o;n;n"
            'gridAttributes = gridAttributes & "|�������޻���;BranchNote;84;;1; " & " o;n;"
            'gridAttributes = gridAttributes & "|���ο���;ApprovalYN;77;;1; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|���;Note;117;;1; " & " o;n;n;40"
            'gridAttributes = gridAttributes & "|��������;ApprovalDt;79;yyyy-MM-dd;4; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|�������Ȯ���ȣ;OldEmployeeExpNum;92;;1; " & " o;"
            'gridAttributes = gridAttributes & "|������;CreateEmployee;93;;1; " & " o;n;n;4"
            'gridAttributes = gridAttributes & "|���� �Ͻ�;CreateDateTime;81;yyyy-MM-dd:HH:mm:ss;4; " & " o;n;n;"
            'gridAttributes = gridAttributes & "|������;UpdateEmployee;149;;1; " & " o;n;n;4"
            'gridAttributes = gridAttributes & "|���� �Ͻ�;UpdateDateTime;149;yyyy-MM-dd:HH:mm:ss;4; " & " o;n;n;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "ListStatCd;��ܻ����ڵ�"    '' 2401
            'gridCodeNameList = gridCodeNameList & "/CollectionDivCd;���������ڵ�"   ''2323
            'gridCodeNameList = gridCodeNameList & "/BillDivCd;û������ڵ�"    ''2321
            'gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNE305_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

       

        ''' <summary>
        ''' �޺� �� ����
        ''' </summary>
        ''' <param name="_grd">������ �׸���</param>
        ''' <param name="row">������ ���ȣ</param>
        ''' <param name="colName">������ �÷���</param>
        ''' <param name="key">�޺� ��</param>
        ''' <remarks>�޺� ���� ��� �Բ� �׸��忡 ǥ���Ѵ�.</remarks>
        Private Sub ComboValueSetting(ByVal _grd As ubiLease.GridControl.grd, ByVal row As Integer, ByVal colName As String, ByVal key As String)
            Dim strs() As String = _grd.get_ColComboList(_grd.get_ColIndex(colName)).Split("|")
            For Each str As String In strs
                If str.Split(".")(0) = key Then
                    _grd.SetData(row, colName, str)
                    Exit For
                End If
            Next
        End Sub
    End Class

End Namespace
