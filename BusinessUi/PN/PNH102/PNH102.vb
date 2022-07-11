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

    Public Class PNH102
        Inherits CommonControls.UiControl

        Private Sub PNH102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "|����;TreePath;113;;1;" & "io;n;n;5;"
            gridAttributes = gridAttributes & "|���;YYYYMM;60;yyyy-MM;4;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�μ���;DeptNm;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����ڵ�;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|����;EmployeeNameHangul;53;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;79;;4;" & "o;n;n;10;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|������;BranchNm;68;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���;PrintPaperNum_avg;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|01;PrintPaperNum_01;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|02;PrintPaperNum_02;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|03;PrintPaperNum_03;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|04;PrintPaperNum_04;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|05;PrintPaperNum_05;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|06;PrintPaperNum_06;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|07;PrintPaperNum_07;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|08;PrintPaperNum_08;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|09;PrintPaperNum_09;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|10;PrintPaperNum_10;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|11;PrintPaperNum_11;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|12;PrintPaperNum_12;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|13;PrintPaperNum_13;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|14;PrintPaperNum_14;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|15;PrintPaperNum_15;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|16;PrintPaperNum_16;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|17;PrintPaperNum_17;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|18;PrintPaperNum_18;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|19;PrintPaperNum_19;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|20;PrintPaperNum_20;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|21;PrintPaperNum_21;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|22;PrintPaperNum_22;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|23;PrintPaperNum_23;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|24;PrintPaperNum_24;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|25;PrintPaperNum_25;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|26;PrintPaperNum_26;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|27;PrintPaperNum_27;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|28;PrintPaperNum_28;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|29;PrintPaperNum_29;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|30;PrintPaperNum_30;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|31;PrintPaperNum_31;40;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���屸��;PrintOfficeCd;56;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�Ǳ���;PrintPlateCd;53;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��;PrintPaperNum_tot;60;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;0;;4;" & "o;n;y;10;���������ڵ�;"
            gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;60;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;40;;7;" & "o;n;n;4;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "PrintOfficeCd;���屸���ڵ�"
            'gridCodeNameList = gridCodeNameList & "/PrintPlateCd;�Ǳ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '--------------------------------------------------------------------
            '---  2008.10.23 ���� ...  �� ... ���ط�... 
            '--------------------------------------------------------------------
            'gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            'gridAttributes = gridAttributes & "|���;YYYYMM;60;;l;" & "io;n;n;6;"       '(10)
            'gridAttributes = gridAttributes & "|��;DD;20;;l;" & "io;n;n;2;"       '(20)
            'gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;90;;c;" & "o;n;n;10;���������ڵ�;;"
            'gridAttributes = gridAttributes & "|�������и�;BranchRegionNm;90;;c;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|������ȣ;BranchNum;90;;c;" & "io;n;n;10;�����ڵ�;BranchNm"
            ' ''gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;60;;c;" & "io;n;n;5;�����ڵ�;BranchNm"
            'gridAttributes = gridAttributes & "|������;BranchNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|���屸���ڵ�;PrintOfficeCd;100;;l;" & "io;n;n;10;"       '(40)
            'gridAttributes = gridAttributes & "|�Ǳ����ڵ�;PrintPlateCd;100;;l;" & "io;n;n;10;"       '(50)
            'gridAttributes = gridAttributes & "|�μ�μ�;PrintPaperNum;40;#,##0;r;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|����;Remark;40;;l;" & "io;n;n;4;"       '(60)
            'gridAttributes = gridAttributes & "|;Dummy;40;;r;" & "o;n;n;4;"       '(60)
            '--------------------------------------------------------------------

        End Sub
#End Region

        Private Sub lblCodeDivisionHangulName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Private Sub dtpBaseYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

  
    End Class

End Namespace
