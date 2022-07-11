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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI207
        Inherits CommonControls.UiControl

        Private Sub PNI207_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�⵵;YYYY;60;;l;" & "o;n;y;6;"       '(10)

            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;10;;c;" & "o;n;y;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;80;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|ǥ�ñ���;DispGb;50;;c;" & "o;n;y;10;;"
            gridAttributes = gridAttributes & "|��ü�ڵ�;CustCd;1;;c;" & "o;n;n;1;;"
            gridAttributes = gridAttributes & "|��ü��;CustNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��;MM_00;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|01;MM_01;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|02;MM_02;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|03;MM_03;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|04;MM_04;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|05;MM_05;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|06;MM_06;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|07;MM_07;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|08;MM_08;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|09;MM_09;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|10;MM_10;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|11;MM_11;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|12;MM_12;60;#,##0;r;" & "o;n;n;4;"       '(60)

            gridAttributes = gridAttributes & "|û�����;BillDivCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;60;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '==============================================================


            '==============================================================
            '  grid_2 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�⵵;YYYY;60;;l;" & "o;n;y;6;"       '(10)

            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;1;;c;" & "o;n;n;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;80;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|ǥ�ñ���;DispGb;70;;l;" & "o;n;n;10;;"
            gridAttributes = gridAttributes & "|��ü�ڵ�;CustCd;1;;c;" & "o;n;n;1;;"
            gridAttributes = gridAttributes & "|��ü��;CustNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��;MM_00;80;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|01;MM_01;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|02;MM_02;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|03;MM_03;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|04;MM_04;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|05;MM_05;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|06;MM_06;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|07;MM_07;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|08;MM_08;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|09;MM_09;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|10;MM_10;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|11;MM_11;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|12;MM_12;70;#,##0;r;" & "o;n;n;4;"       '(60)

            gridAttributes = gridAttributes & "|û�����;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_2 code combo    
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_2.ExplorerBar = 3
            '==============================================================

            '==============================================================
            '  grid_3 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            gridAttributes = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�⵵;YYYY;60;;l;" & "o;n;y;6;"       '(10)

            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;10;;c;" & "o;n;y;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;80;;l;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|ǥ�ñ���;DispGb;50;;c;" & "o;n;y;10;;"
            gridAttributes = gridAttributes & "|��ü�ڵ�;CustCd;1;;c;" & "o;n;n;1;;"
            gridAttributes = gridAttributes & "|��ü��;CustNm;120;;l;" & "o;n;n;40;"

            gridAttributes = gridAttributes & "|��;MM_00;70;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|01;MM_01;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|02;MM_02;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|03;MM_03;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|04;MM_04;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|05;MM_05;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|06;MM_06;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|07;MM_07;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|08;MM_08;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|09;MM_09;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|10;MM_10;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|11;MM_11;60;#,##0;r;" & "o;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|12;MM_12;60;#,##0;r;" & "o;n;n;4;"       '(60)

            gridAttributes = gridAttributes & "|û�����;BillDivCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|û���ֱ�;BillPeriodCd;60;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            'grid_3 code combo    
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "BillDivCd;û������ڵ�"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;�����ֱ��ڵ�"   ''2111
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 3
            '==============================================================

        End Sub
#End Region

        Private Sub optBranchPa1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBranchPa1.CheckedChanged
            grd_1.Visible = True
            grd_2.Visible = False
            grd_3.Visible = False
        End Sub

        Private Sub optBranchPa2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBranchPa2.CheckedChanged
            grd_1.Visible = False
            grd_2.Visible = True
            grd_3.Visible = False
        End Sub

        Private Sub optBranchPa3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBranchPa3.CheckedChanged
            grd_1.Visible = False
            grd_2.Visible = False
            grd_3.Visible = True
        End Sub
    End Class

End Namespace
