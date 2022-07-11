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


Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC107
        Inherits CommonControls.UiControl
        '====================================================================================================
        Dim blnApprovalAll As Boolean = False

#Region "�� �ʱ�ȭ"

        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ���ϰ� : 
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
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
            gridAttributes = gridAttributes & "k;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;37;;1;" & "io;n;n;;;"
            gridAttributes = gridAttributes & "|���������ڵ�;ReceiptCd;0;;1;" & "io;n;y;13;"
            gridAttributes = gridAttributes & "|���ڻ���;ReaderStateCd;86;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|���ο���;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|��������;ApprovalDt;85;yyyy-MM-dd;4;" & "o;n;y;8;"

            gridAttributes = gridAttributes & "|(M)���;MonitoringResultCd;80;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)����;RefuseReasonCd;80;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)�����;MonitoringEmpNum;60;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)����ڸ�;MonitoringEmpNm;60;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|(M)ó������;MonitoringProcDt;70;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)���;MonitoringRemark;100;;1;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|�����μ�;ContactPaperNum;62;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���Ժμ�;FixedPagerNum;62;;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;0;;1;" & "o;n;y;12;"
            gridAttributes = gridAttributes & "|Ȯ��ó;CompanyCd;72;;1;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;138;;1;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|��������;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|���ڸ�;SubscriberNm;178;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;116;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�ڵ�����ȣ;MobileNum;106;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�����ȣ;OldPostNum;62;;4;" & "o;n;n;10;�����ȣ;OldAddr1"
            gridAttributes = gridAttributes & "|�ּ�;OldAddr1;244;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|���ּ�;OldAddr2;286;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|���������ڵ�;DeliveryBranchCd;67;c;4;" & "o;n;n;7;�����ڵ�;DeliveryBranchNm "
            gridAttributes = gridAttributes & "|����������;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�������޻���;Note2;87;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|��������;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|������������;FixedEdDt;87;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|������;AdEmployeeNm;50;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����μ�;AdEmployeeDeptCd;62;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����μ���;AdEmployeeDeptNm;75;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�ֱ����ڸ�;TrAdEmployeeNm;74;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�ֱ����ںμ�;TrAdEmployeeDeptCd;87;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�ֱ����ںμ���;TrAdEmployeeDeptNm;99;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�����ڻ��;AdEmployeeNum;74;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|�ֱ����ڻ��;TrAdEmployeeNum;87;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|;Dummy;40;;4;" & "o;n;n;4;"


            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;����Ͱ��ó���ڵ�"
            gridCodeNameList = gridCodeNameList & "/RefuseReasonCd;����͹���������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;���ڻ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.FrozenCols = 8
            Me.grd_1.ExplorerBar = 3

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            NewData()
        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : PNC107_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC107_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        ''' <summary>
        ''' �Լ��� : btnApprovalAll_Click 
        ''' ��  �� : �ϰ� ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>

        Private Sub btnApprovalAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovalAll.Click
            Dim inti As Integer
            Try

                ' ''If blnApprovalAll = False Then
                With grd_1
                    If (.Rows > .FixedRows) Then
                        For inti = .FixedRows To .Rows - 1
                            '''' ���� ����, ȸ�� ����, ȸ�� ���� ���� Ȯ�� �� ó�� 
                            If .GetCellCheck(inti, .get_ColIndex("����")) = CheckEnum.Checked Then
                                ''If cboMonitoringResultCd_E.Text.ToString.Length >= 1 Then
                                .set_TextMatrix(inti, .get_ColIndex("MonitoringResultCd"), cboMonitoringResultCd_E.Text)
                                ''End If
                                ''If cboRefuseReasonCd_E.Text.ToString.Length >= 1 Then
                                .set_TextMatrix(inti, .get_ColIndex("RefuseReasonCd"), cboRefuseReasonCd_E.Text)
                                ''End If
                                ''If popMonitoringEmpNum_E.Text.ToString.Length >= 1 Then
                                .set_TextMatrix(inti, .get_ColIndex("MonitoringEmpNum"), popMonitoringEmpNum_E.TextValue)
                                ''End If
                                ''If popMonitoringEmpNum_E.Text.ToString.Length >= 1 Then
                                .set_TextMatrix(inti, .get_ColIndex("MonitoringEmpNm"), popMonitoringEmpNum_E.NameText)
                                ''        End If
                                ''If dtpMonitoringProcDt_E.Text.ToString.Length >= 1 Then
                                .set_TextMatrix(inti, .get_ColIndex("MonitoringProcDt"), dtpMonitoringProcDt_E.Text)
                                ''        End If
                                ''If txtMonitoringRemark_E.Text.ToString.Length >= 1 Then
                                .set_TextMatrix(inti, .get_ColIndex("MonitoringRemark"), .get_TextMatrix(inti, .get_ColIndex("MonitoringRemark")) & vbCrLf & dtpMonitoringProcDt_E.Text & " " & txtMonitoringRemark_E.Text)
                                ''End If
                                .SetCellCheck(inti, .get_ColIndex("����"), CheckEnum.Checked)
                            End If
                        Next inti
                    End If
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
#End Region

    End Class

End Namespace
