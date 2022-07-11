' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 
' form설명 :
' 작성자 : 
' 작성일 : 
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

#Region "폼 초기화"

        ''' <summary>
        ''' 함수명 : Initialize
        ''' 리턴값 : 
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "k;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "io;n;n;;;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "io;n;y;13;"
            gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;86;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;62;;4;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;85;yyyy-MM-dd;4;" & "o;n;y;8;"

            gridAttributes = gridAttributes & "|(M)결과;MonitoringResultCd;80;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)사유;RefuseReasonCd;80;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)담당자;MonitoringEmpNum;60;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)담당자명;MonitoringEmpNm;60;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|(M)처리일자;MonitoringProcDt;70;;1;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|(M)비고;MonitoringRemark;100;;1;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|접수부수;ContactPaperNum;62;#,##0;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;62;;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;0;;1;" & "o;n;y;12;"
            gridAttributes = gridAttributes & "|확장처;CompanyCd;72;;1;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;138;;1;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;178;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;116;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|핸드폰번호;MobileNum;106;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;62;;4;" & "o;n;n;10;우편번호;OldAddr1"
            gridAttributes = gridAttributes & "|주소;OldAddr1;244;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;286;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;67;c;4;" & "o;n;n;7;지국코드;DeliveryBranchNm "
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|지국전달사항;Note2;87;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|구독만료일자;FixedEdDt;87;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|권유자;AdEmployeeNm;50;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|권유부서;AdEmployeeDeptCd;62;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|권유부서명;AdEmployeeDeptNm;75;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|주권유자명;TrAdEmployeeNm;74;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|주권유자부서;TrAdEmployeeDeptCd;87;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|주권유자부서명;TrAdEmployeeDeptNm;99;l;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|권유자사번;AdEmployeeNum;74;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|주권유자사번;TrAdEmployeeNum;87;c;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|;Dummy;40;;4;" & "o;n;n;4;"


            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;모니터결과처리코드"
            gridCodeNameList = gridCodeNameList & "/RefuseReasonCd;모니터미통과사유코드"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;독자상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.FrozenCols = 8
            Me.grd_1.ExplorerBar = 3

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            NewData()
        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC107_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC107_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        ''' <summary>
        ''' 함수명 : btnApprovalAll_Click 
        ''' 기  능 : 일괄 적용
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
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
                            '''' 선택 여부, 회수 여부, 회수 일자 여부 확인 후 처리 
                            If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
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
                                .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
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
