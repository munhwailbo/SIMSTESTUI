'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 테이블 목록 등록
' form 설명 : 테이블 목록을 등록 한다.
' 작성자 : 반영철
' 작성일 : 2008-09-19
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic


Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNC301
        Inherits CommonControls.UiControl

        ' 템플릿 파일 경로 변수
        Public strFilePath As String = ""

        ' 저장 경로 변수
        Public strSaveFilePath As String = ""

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|독자 코드;ReaderCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|독자 명;ReaderNm;90;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;70;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|전화번호2;PhoneNum2;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|핸드폰 번호;MobileNum;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신주소;NewAddr1;90;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신상세주소;NewAddr2;70;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구 우편번호;OldPostNum;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구주소;OldAddr1;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구상세주소;OldAddr2;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독코드;SubscribeCd;60;;l;" & "o;n;y;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1


            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|접수일자;ReceiptDt;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;50;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|접수시간;ReceiptTime;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|구독코드;SubscribeCd;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|민원구분코드;DivCd;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|독자명비고;ReaderNmNote;90;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|전화번호비고;PhoneNumNote;90;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|주소비고;AddrNote;90;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|지국명비고;BranchNmNote;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|부명;DeptNm;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|내용;Content;100;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|지국통보코드;ResultInformCd;80;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|처리결과;ResultNote;70;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|모니터처리자아이디;MonitoringEmpNum;100;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|모니터처리일자;MonitoringProcDt;70;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|진행상태코드;IngStateCd;80;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|;dumi;80;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "ParType;컬럼 타입 명"

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

        End Sub


#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : ACA003_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ACA003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub btnPRB002_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRB002.Click

            'If Me.txtChiefCd.Text.Replace(" ", "") = "" Then
            '    GrecordProcessMode = "1"
            'Else
            '    GrecordProcessMode = "2"
            'End If
            Dim sDateTime As String
            sDateTime = Format(Now, "HH:MM:ss")
            Dim sSubscribe As String
            sSubscribe = grd_1.GetCurrentRowCellValue("SubscribeCd")

            GmainsqlParameters = Nothing

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ArecordprocessMode", GrecordProcessMode)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue.Replace("-", "").Substring(0, 8))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", IIf(IsNumeric(Me.grd_2.GetCurrentRowCellValue("Orders")) = False, 0, Me.grd_2.GetCurrentRowCellValue("Orders")))
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptTime", Me.dtpReceiptDt.Text) 'Me.cboBusinessPlaceCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptTime", sDateTime) 'Me.cboBusinessPlaceCode.TextValue)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.cboDivCd.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", Me.txtReaderNmNote.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", Me.txtPhoneNumNote.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AAddrNote", Me.txtAddrNote.Text)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", Me.txtBranchNmNote.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADeptNm", Me.txtDeptNm.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AContent", Me.txtContent.Text)

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", sSubscribe)


            GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC301_CUD", True, False, GmainsqlParameters)

            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)

            RequestData()
        End Sub
    End Class

End Namespace
