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

    Public Class PNC104
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
            gridAttributes = gridAttributes & "|독자상태;ReaderStateCd;82;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|모니터처리코드;MonitoringResultCd;99;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|승인여부;ApprovalYN;58;;4;" & "io;n;n;1;"
            gridAttributes = gridAttributes & "|승인일자;ApprovalDt;85;yyyy-MM-dd;4;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|독자명;SubscriberNm;140;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|투입부수;FixedPagerNum;56;;4;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|전화1;PhoneNum1;91;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|전화2;PhoneNum2;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|핸드폰;MobileNum;91;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|우편번호;OldPostNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|주소;OldAddr1;200;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|상세주소;OldAddr2;210;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|신주소;NewAddr1;0;;1;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;0;;1;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|투입지국코드;DeliveryBranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|투입지국명;DeliveryBranchNm;74;;1;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|접수독자코드;ReceiptCd;0;;1;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|접수일자;ContactDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|;Dummy;40;;4;" & "o;n;n;4;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "MonitoringResultCd;모니터결과처리코드"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;독자상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.FrozenCols = 5
            Me.grd_1.ExplorerBar = 3

            Me.dtpReceiptDtFrom.TextValue = System.DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 8) & "01"
            NewData()
        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PNC104_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNC104_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
        ''' <summary>
        ''' 함수명 : btnApprovalAll_Click 
        ''' 기  능 : 일괄 승인
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
                If blnApprovalAll = False Then
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                    .SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Checked)
                                    .set_TextMatrix(inti, .get_ColIndex("ApprovalDt"), dtpApprovalDt.Text)
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = True
                Else
                    With grd_1
                        If (.Rows > .FixedRows) Then
                            For inti = .FixedRows To .Rows - 1
                                If .GetCellCheck(inti, .get_ColIndex("선택")) = CheckEnum.Checked Then
                                    If .GetCellCheck(inti, .get_ColIndex("ApprovalYN")) = CheckEnum.Checked Then
                                        .SetCellCheck(inti, .get_ColIndex("ApprovalYN"), CheckEnum.Unchecked)
                                        .set_TextMatrix(inti, .get_ColIndex("ApprovalDt"), "")
                                        '''' .SetCellCheck(inti, .get_ColIndex("선택"), CheckEnum.Checked)
                                    End If
                                End If
                            Next inti
                        End If
                    End With
                    blnApprovalAll = False
                End If
                '' 'btnApprovalAll.Text = IIf(blnApprovalAll, "승인 취소", "일괄 승인")
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
#End Region

        

        Private Sub grd_1_LeaveEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles grd_1.LeaveEdit
            With grd_1
                If .get_ColKey(.CursorCell.c1) = "ApprovalYN" Then
                    If .GetCellCheck(.CursorCell.r1, .CursorCell.c1) = CheckEnum.Unchecked Then
                        .set_TextMatrix(.CursorCell.r1, .get_ColIndex("ApprovalDt"), dtpApprovalDt.Text)
                    Else
                        .set_TextMatrix(.CursorCell.r1, .get_ColIndex("ApprovalDt"), "")
                    End If
                End If
            End With
        End Sub

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click

        End Sub

        Private Sub popMonitoringEmpNum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popMonitoringEmpNum.Load

        End Sub
    End Class

End Namespace
