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

    Public Class PND202
        Inherits CommonControls.UiControl
        '===================================================================================================


#Region "�� �ʱ�ȭ"

        Public Sub Initialize()
            ' '' ''==============================================================
            ' '' ''  grid_1 �� �ʱ�ȭ �Ѵ�.
            ' '' ''--------------------------------------------------------------
            '' ''Dim gridAttributes As String = ""
            ' '' ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            '' ''gridAttributes = gridAttributes & "a;r;y"

            ' '' ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            '' ''gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            '' ''gridAttributes = gridAttributes & "|Pkey;Pkey;4;;;" & "io;n;y;4;"       '(10)
            '' ''gridAttributes = gridAttributes & "|���� ����;RscDate;8;;;" & "io;n;n;8;"       '(20)
            '' ''gridAttributes = gridAttributes & "|����ó �ڵ�;RscCompanyCd;4;;;" & "io;n;n;4;Ȯ��ó ��;CompanyHangulNm "       '(30)
            '' ''gridAttributes = gridAttributes & "|����ó ��;CompanyHangulNm ;9;;;" & "io;n;n;9;"
            '' ''gridAttributes = gridAttributes & "|����ó �ּ�;RscCompanyAddr ;9;;;" & "io;n;n;9;"
            '' ''gridAttributes = gridAttributes & "|��� ���� �ڵ�;RscBranchNum;9;;;" & "io;n;n;9;�����ڵ�;BranchNm"       '(40)
            '' ''gridAttributes = gridAttributes & "|���� ��;BranchNm;9;;;" & "io;n;n;9;"
            '' ''gridAttributes = gridAttributes & "|���� �� ��;Cho;4;#,##0;r;" & "io;n;n;4;"       '(50)
            '' ''gridAttributes = gridAttributes & "|�߾� �� ��;Joong;4;#,##0;r;" & "io;n;n;4;"       '(60)
            '' ''gridAttributes = gridAttributes & "|���� �� ��;DongPnum;4;#,##0;r;" & "io;n;n;4;"       '(70)
            '' ''gridAttributes = gridAttributes & "|��Ÿ �� ��;EtcPnum;4;#,##0;r;" & "io;n;n;4;"       '(80)
            '' ''gridAttributes = gridAttributes & "|����;Remark;4000;;l;" & "io;n;n;4000;"       '(90)
            ' '' ''grid_1 code combo    
            '' ''Dim gridCodeNameList As String = ""
            '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            RequestData()
        End Sub

#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PND202_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>



        Private Sub PND202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

       
      
     
    End Class

End Namespace
