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

    Public Class PNA301
        Inherits CommonControls.UiControl
        Private Sub PNA301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Public Sub Initialize()

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code

            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;6;;;" & "o;n;n;6;"       '(90)
            gridAttributes = gridAttributes & "|사원 명 한글;EmployeeNameHangul;20;;;" & "o;n;n;20;"       '(110)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "o;n;n;7;"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;30;;;" & "o;n;n;30;"       '(20)
            ''gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;10;;;" & "o;n;y;10;"       '(30)
            ''gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;7;;;" & "o;n;y;7;"       '(40)
            'grid_1 code combo    

            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)


            '==============================================================
            '  grid_3 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;9;;;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "io;n;n;7;"       '(20)
            gridAttributes = gridAttributes & "|교체횟수;ChangeNum;4;;;" & "io;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|계약일자;ContractDt;8;;;" & "io;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;8;;;" & "io;n;n;8;"       '(50)
            gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;8;;;" & "io;n;n;8;"       '(60)
            gridAttributes = gridAttributes & "|계약해지일자;ContractCancelDt;8;;;" & "io;n;n;8;"       '(70)
            gridAttributes = gridAttributes & "|지국명;BranchNm;30;;;" & "io;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;7;;;" & "io;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;10;;;" & "io;n;n;10;"       '(110)
            gridAttributes = gridAttributes & "|부서코드;DeptCd;10;;;" & "io;n;n;10;"       '(120)
            gridAttributes = gridAttributes & "|부서구분코드(출력용);DeptDivCd;10;;;" & "io;n;n;10;"       '(130)
            gridAttributes = gridAttributes & "|운영개시년월;OpenYYYYMM;6;;;" & "io;n;n;6;"       '(140)
            gridAttributes = gridAttributes & "|운영종료년월;EndYYYYMM;6;;;" & "io;n;n;6;"       '(150)
            gridAttributes = gridAttributes & "|교체구분코드;ChangeDivCd;10;;;" & "io;n;n;10;"       '(160)
            gridAttributes = gridAttributes & "|운영구분코드;ManageDivCd;10;;;" & "io;n;n;10;"       '(170)
            gridAttributes = gridAttributes & "|지국지역코드;BranchRegionCd;10;;;" & "io;n;n;10;"       '(190)
            'grid_3 code combo    
            gridCodeNameList = ""
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_3.ExplorerBar = Me.grd_3.get_ColIndex("EmployeeNumber")

            '==============================================================
            '  grid_2 를 초기화 한다.
            '--------------------------------------------------------------
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;9;;;" & "io;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "io;n;n;7;"       '(20)
            gridAttributes = gridAttributes & "|교체횟수;ChangeNum;4;;;" & "io;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|계약일자;ContractDt;8;;;" & "io;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;8;;;" & "io;n;n;8;"       '(50)
            gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;8;;;" & "io;n;n;8;"       '(60)
            gridAttributes = gridAttributes & "|계약해지일자;ContractCancelDt;8;;;" & "io;n;n;8;"       '(70)
            gridAttributes = gridAttributes & "|지국명;BranchNm;30;;;" & "io;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;7;;;" & "io;n;n;7;"       '(100)
            gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;10;;;" & "io;n;n;10;"       '(110)
            gridAttributes = gridAttributes & "|부서코드;DeptCd;10;;;" & "io;n;n;10;"       '(120)
            gridAttributes = gridAttributes & "|부서구분코드(출력용);DeptDivCd;10;;;" & "io;n;n;10;"       '(130)
            gridAttributes = gridAttributes & "|운영개시년월;OpenYYYYMM;6;;;" & "io;n;n;6;"       '(140)
            gridAttributes = gridAttributes & "|운영종료년월;EndYYYYMM;6;;;" & "io;n;n;6;"       '(150)
            gridAttributes = gridAttributes & "|교체구분코드;ChangeDivCd;10;;;" & "io;n;n;10;"       '(160)
            gridAttributes = gridAttributes & "|운영구분코드;ManageDivCd;10;;;" & "io;n;n;10;"       '(170)
            gridAttributes = gridAttributes & "|지국지역코드;BranchRegionCd;10;;;" & "io;n;n;10;"       '(190)
            'grid_4 code combo    
            gridCodeNameList = ""
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_4.ExplorerBar = Me.grd_4.get_ColIndex("EmployeeNumber")

        End Sub
       

        
    End Class

End Namespace
