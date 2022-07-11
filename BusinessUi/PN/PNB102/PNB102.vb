'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 테이블 정의서 등록
' form 설명 : 테이블 정의서를 등록 한다.
' 작성자 : 황인중
' 작성일 : 2007-07-11
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

    Public Class PNB102
        Inherits CommonControls.UiControl

        '' 템플릿 파일 경로 변수
        'Public strFilePath As String = ""

        '' 테이블 정의서 저장 경로 변수
        'Public strSaveFilePath As String = ""

        '' 테이블 스크립트 저장 경로 변수
        'Public strScriptSaveFilePath As String = ""

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
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "o;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;30;"

            gridAttributes = gridAttributes & "|이전일자;TransferDate;8;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|이전횟수;TransferNum;4;;c;" & "o;n;n;4;"

            gridAttributes = gridAttributes & "|처리구분;ProcessDivCd;10;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계약구분;ContractDivCd;10;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|건물주;OwnerNm;30;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|임차보증금;RentDepositAmt;15;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|월세;RentAmt;15;#,##0;r;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|월세보류여부;DeferPaymentYn;10;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|VAT포함여부;VatYn;10;;l;" & "o;n;y;10;"

            gridAttributes = gridAttributes & "|계약일자;ContractStDt;8;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|계약만료일자;ContractEdDt;8;;l;" & "o;n;n;8;"

            gridAttributes = gridAttributes & "|지국우편번호;PostNum;10;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|지국주소;Addr;100;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|채권확보;Obligation;30;;l;" & "o;n;n;30;"

            gridAttributes = gridAttributes & "|은행코드;BankCd;10;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;30;;l;" & "o;n;n;30;"

            '' '' ''2009.01.23 하정호 차장에 의하여 최종 정리 됨(그리드 항목 전체 재정의)
            gridAttributes = gridAttributes & "|약도이미지파일경로;OutlineMapFilePath;0;;l;" & "o;n;y;0;"
            gridAttributes = gridAttributes & "|대지평수;SiteArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|건물평수;BuildingArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|사용평수;UseArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|층구분;Floor;10;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|제한물건;LimitedItem;30;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|대물담보-소유자명;SecurityOwnerNm;30;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|대물담보-우편번호;SecurityPostNum;10;;l;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|대물담보-주소;SecurityAddr;100;;l;" & "o;n;y;100;"
            gridAttributes = gridAttributes & "|대물담보-대지평수;SecuritySiteArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|대물담보-건물평수;SecurityBuildingArea;4;;r;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|대물담보-제한물건;SecurityLimitedItem;50;;l;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;30;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|건물주와의관계;OwnerRelation;10;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "| ;jIrAL;10;;;" & "o;n;y;10;"    '끝자리 맞추기 용

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ProcessDivCd;지국사무실처리구분코드"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;지국사무실계약구분코드"
            gridCodeNameList = gridCodeNameList & "/BankCd;은행코드"
            ''gridCodeNameList = gridCodeNameList & "/OwnerRelation;건물주와의관계"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            'Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 3

            lblRecordState.Text = "준비"

            ''grid를 초기화 한다.
            ''--------------------------------------------------
            'gridAttributes = ""


            '' '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            ' '' ''gridAttributes = gridAttributes & "a;r;y"

            '' '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '' '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            ' '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            ' '' ''gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "o;n;n;7;지국코드;BranchNm"
            ' '' ''gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;y;30;"

            ' '' ''gridAttributes = gridAttributes & "|이전일자;TransferDate;8;;l;" & "o;n;n;8;"
            ' '' ''gridAttributes = gridAttributes & "|이전횟수;TransferNum;4;;c;" & "o;n;n;4;"

            ' '' ''gridAttributes = gridAttributes & "|처리구분코드;ProcessDivCd;10;;c;" & "o;n;n;10;"
            ' '' ''gridAttributes = gridAttributes & "|계약구분코드;ContractDivCd;10;;c;" & "o;n;n;10;"

            ' '' ''gridAttributes = gridAttributes & "|건물주;OwnerNm;30;;l;" & "o;n;n;30;"
            ' '' ''gridAttributes = gridAttributes & "|임차보증금;RentDepositAmt;15;#,##0;r;" & "o;n;n;15;"
            ' '' ''gridAttributes = gridAttributes & "|월세;RentAmt;15;#,##0;r;" & "o;n;n;15;"
            ' '' ''gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;8;;l;" & "o;n;n;8;"
            ' '' ''gridAttributes = gridAttributes & "|계약만료일자;ContractEdDt;8;;l;" & "o;n;n;8;"

            ' '' ''gridAttributes = gridAttributes & "|지국우편번호;PostNum;10;;c;" & "o;n;y;10;"
            ' '' ''gridAttributes = gridAttributes & "|지국주소;Addr;100;;l;" & "o;n;n;100;"
            ' '' ''gridAttributes = gridAttributes & "|채권확보;Obligation;30;;l;" & "o;n;n;30;"

            ' '' ''gridAttributes = gridAttributes & "|은행구분코드;BankCd;10;;l;" & "o;n;n;10;"
            ' '' ''gridAttributes = gridAttributes & "|계좌번호;AccountNum;30;;l;" & "o;n;n;30;"

            '' '' ''grid code combo
            ' '' ''gridCodeNameList = ""
            ' '' ''gridCodeNameList = gridCodeNameList & "ProcessDivCd;지국사무실처리구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/ContractDivCd;지국사무실계약구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/BankCd;은행구분코드"
            ' '' ''gridCodeNameList = gridCodeNameList & "/OwnerRelation;건물주와의관계"
            ' '' ''grd_2.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''--------------------------------------------------
            '' '' ''Me.grd_2.ExplorerBar = 0
            ' '' ''Me.grd_2.ExplorerBar = 3


        End Sub

        Private Sub PNB102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            ''RequestData2()
        End Sub

    End Class

End Namespace

