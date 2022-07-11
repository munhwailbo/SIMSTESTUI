'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 확장처 등록
' form 설명 : 확장처를 등록합니다.
' 작성자 : 유비템즈
' 작성일 : 2008-09-22
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
Imports System.Collections.Generic

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC501
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code

            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|순번;Orders;40;;l;" & "o;n;y;"

            gridAttributes = gridAttributes & "|구분;GB;40;;l;" & "o;n;y;"

            gridAttributes = gridAttributes & "|접수키;vPkey;60;;c;" & "o;n;y;12;"
            'gridAttributes = gridAttributes & "|독자코드;SubscribeCd;60;;c;" & "o;n;y;5;"
            'gridAttributes = gridAttributes & "|접수코드;ReceiptCd;60;;c;" & "o;n;y;5;"


            gridAttributes = gridAttributes & "|접수일자;ReceiptDt;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|시간;ReceiptStTime;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|통화종료시간;ReceiptEdTime;60;;c;" & "o;n;y;5;"

            gridAttributes = gridAttributes & "|구분;ConsultationCd;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|확장구분;ExpandDivCd;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|독자명;SubscribeNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|전화번호;PhoneNumber;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|우편번호;PostNum;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|주소;Addr1;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|상세주소;Addr2;60;;l;" & "o;n;n;5;"



            'gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|지국 명;BranchNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|지국담당 명;BizEmpTeamCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|부명;BizEmpTeamNm;60;;l;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|지국담당사번;BizEmpNum;60;;c;" & "o;n;y;5;영업사원 명;BizEmpNm"
            gridAttributes = gridAttributes & "|담당;BizEmpNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|민원내용;Content;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|처리결과;Results;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|처리상태;StateCd;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|처리일자;FinishDt;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|상담원사번;CnsltEmpNum;60;;l;" & "o;n;y;5;모니터담당 명;CnsltEmpNm"
            gridAttributes = gridAttributes & "|상담원 명;CnsltEmpNm;60;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|전화수신여부;ReceiveSendBit;60;;l;" & "o;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ConsultationCd;민원구분코드"
            gridCodeNameList = gridCodeNameList & "/ExpandDivCd;확장구분코드"
            gridCodeNameList = gridCodeNameList & "/StateCd;민원상태코드"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNC501_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Private Sub grd_1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '사원확장 독자 등록 화면으로 JUMP.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub
            


            Dim ShowConsaultation As Collections.Generic.Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            ShowConsaultation.Add("민원접수일", Me.grd_1.GetCurrentRowCellValue("ReceiptDt"))
            ShowConsaultation.Add("민원접수키", Me.grd_1.GetCurrentRowCellValue("vPkey"))
            ShowConsaultation.Add("순번", Me.grd_1.GetCurrentRowCellValue("Orders"))
            ShowConsaultation.Add("독자명", Me.grd_1.GetCurrentRowCellValue("SubscribeNm"))

            Me.SendPhonenumber("PN", Me.Name, ShowConsaultation, Me.GmainBusinessFunction.GetValue("로그인 ID"))

        End Sub
    End Class

End Namespace
