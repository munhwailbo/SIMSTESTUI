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

    Public Class PND101
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
            'gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            'gridAttributes = gridAttributes & "|Pkey;Pkey;0;;1;" & "io;n;y;4;"
            'gridAttributes = gridAttributes & "|���� ����;RscDate;87;yyyy-MM-dd;4;" & "io;n;n;8;"
            'gridAttributes = gridAttributes & "|����;RscTitle;128;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|����ó �ڵ�;RscCompanyCd;100;;4;" & "io;n;n;4;Ȯ��ó ��;CompanyHangulNm"
            'gridAttributes = gridAttributes & "|����ó ��;CompanyHangulNm;160;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|��ȭ �� ��;munhwa;71;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|���� �� ��;Cho;71;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|�߾� �� ��;Joong;71;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|���� �� ��;DongPnum;64;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|��Ÿ �� ��;EtcPnum;70;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|��� ���� �ڵ�;RscBranchNum;8;;4;" & "io;n;n;9;�����ڵ�;BranchNm"
            'gridAttributes = gridAttributes & "|���� ��;BranchNm;101;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|����ó �ּ�;RscCompanyAddr;221;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|����;Remark;200;;1;" & "io;n;n;4000;"
            gridAttributes = gridAttributes & "||����;����;40;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|Pkey;Pkey;0;;1;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|���� ����;RscDate;87;yyyy-MM-dd;4;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|����;RscTitle;119;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|����ó �ڵ�;RscCompanyCd;15;;4;" & "io;n;n;4;Ȯ��ó ��;CompanyHangulNm"
            gridAttributes = gridAttributes & "|����ó ��;CompanyHangulNm;107;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|��ȭ;munhwa;39;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����;Cho;37;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|�߾�;Joong;42;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|����;DongPnum;35;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��Ÿ;EtcPnum;40;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|��� ���� �ڵ�;RscBranchNum;10;;4;" & "io;n;n;9;�����ڵ�;BranchNm"
            gridAttributes = gridAttributes & "|���� ��;BranchNm;62;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|����ó �ּ�;RscCompanyAddr;221;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|����;Remark;200;;1;" & "io;n;n;4000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
        End Sub

#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PND101_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PND101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

       
      
     
    End Class

End Namespace
