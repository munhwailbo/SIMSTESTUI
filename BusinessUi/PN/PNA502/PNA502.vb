'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 관리비항목수정삭제
' form 설명 : 관리비 항목을 등록 수정 합니다.
' 작성자 : 임종성
' 작성일 : 2006-03-07
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

    Public Class PNA502
        Inherits CommonControls.UiControl

        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|우편번호코드;ZipSeriesNum;10;;;" & "o;n;n;10;"       '(10)
            gridAttributes = gridAttributes & "|우편번호;ZipCd;10;;;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|도;Do;30;;;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|시군구;City;30;;;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|읍면동;Dong;30;;;" & "o;n;n;30;"       '(50)
            gridAttributes = gridAttributes & "|리;Ri;30;;;" & "o;n;n;30;"       '(60)
            gridAttributes = gridAttributes & "|도서;Island;30;;;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|산번지;San;30;;;" & "o;n;n;30;"       '(80)
            gridAttributes = gridAttributes & "|시작번지-주;SHouseNumJu;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|시작번지-부;SHouseNum1Bu;30;;;" & "o;n;n;30;"       '(100)
            gridAttributes = gridAttributes & "|끝번지-주;EHouseNumJu;30;;;" & "o;n;n;30;"       '(110)
            gridAttributes = gridAttributes & "|끝번지-부;EHouseNumBu;30;;;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|아파트/건물명;ApartmentNm;30;;;" & "o;n;n;30;"       '(130)
            gridAttributes = gridAttributes & "|아파트시작동;ApartmentSDong;30;;;" & "o;n;n;30;"       '(140)
            gridAttributes = gridAttributes & "|아파트끝동;ApartmentEDong;30;;;" & "o;n;n;30;"       '(150)
            gridAttributes = gridAttributes & "|변경일;ProcessDt;8;;;" & "o;n;n;8;"       '(160)
            gridAttributes = gridAttributes & "|주소;Addr;100;;;" & "o;n;n;100;"       '(170)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "o;n;n;7;"       '(180)
            gridAttributes = gridAttributes & "|지국명;BranchNm;30;;;" & "o;n;n;30;"       '(190)
            gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;10;;;" & "o;n;n;10;"       '(200)
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;7;;;" & "o;n;n;7;"       '(210)
            gridAttributes = gridAttributes & "|지국지역코드;BranchRegionCd;10;;;" & "o;n;n;10;"       '(250)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "o;n;n;7;"       '(260)
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;4;;;" & "o;n;n;4;"       '(270)
            gridAttributes = gridAttributes & "|우편번호코드;ZipSeriesNum;10;;;" & "o;n;n;10;"       '(280)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub



        Private Sub PNA502_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub



        
    End Class

End Namespace
