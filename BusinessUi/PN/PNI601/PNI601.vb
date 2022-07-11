'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화일보 코드 관리
' 작성자 : 권진성
' 작성일 : 2008.09.01
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

    Public Class PNI601
        Inherits CommonControls.UiControl

        Private Sub PNI601_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
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
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|전표 유형;SlipDivision;35;;c;" & "o;n;n;;"
            gridAttributes = gridAttributes & "|전표 일자;SlipDate;81;;c;" & "o;n;n;;"                                      '전표 일자 
            gridAttributes = gridAttributes & "|전표" & vbCrLf & "번호;SlipNumber;37;;c;" & "o;n;n;;"                       '전표 번호 
            gridAttributes = gridAttributes & "|항목" & vbCrLf & "번호;ItemNumber;37;;c;" & "o;n;n;;"                       '항목 번호
            gridAttributes = gridAttributes & "|전표대체구분;SlipType;51;;c;" & "o;n;n;;"                                   '대체구분
            gridAttributes = gridAttributes & "|작성 부서 코드;DrawUpDepartmentCode;49;;4;" & "o;n;n;;;"
            gridAttributes = gridAttributes & "|작성 부서;DrawUpDepartmentNm;91;;c;" & "o;n;n;;"                                            '부서
            gridAttributes = gridAttributes & "|작성 사원 코드;DrawUpDepartmentCode;64;;c;" & "o;n;n;;" '사원 코드
            gridAttributes = gridAttributes & "|작성 사원;DrawUpEmployeeNm;83;;c;" & "o;n;n;;"                                        '사원
            gridAttributes = gridAttributes & "|사업" & vbCrLf & "부문;EnterpriseCode;46;;c;" & "o;n;n;;"                  '사업 부문 
            gridAttributes = gridAttributes & "|제조" & vbCrLf & "구분;ManufactureDivision;60;;c;" & "o;n;y;;"             '제조 구분  
            gridAttributes = gridAttributes & "|계정 코드;AccountCode;55;;c;" & "o;n;n;;"                                  '계정 코드 
            gridAttributes = gridAttributes & "|계정 명;AccountName;126;;l;" & "o;n;n;;"                                    '계정
            gridAttributes = gridAttributes & "|차대" & vbCrLf & "구분;DrCrDivision;48;;c;" & "o;n;n;;"                    '차대 구분 
            gridAttributes = gridAttributes & "|보조항목" & vbCrLf & "구분;SideItemDivisionCode;50;;c;" & "o;n;y;;"        '보조 항목 구분 
            gridAttributes = gridAttributes & "|보조" & vbCrLf & "코드;SideItemCode;42;;c;" & "o;n;n;;"                    '보조 항목 코드 
            gridAttributes = gridAttributes & "|보조 항목;SideItemName;128;;l;" & "o;n;n;;"                                 '보조 항목 명 
            gridAttributes = gridAttributes & "|관리항목" & vbCrLf & "구분;MgtItemDivisionCode;121;;c;" & "o;n;y;;"         '관리 항목 구분 
            gridAttributes = gridAttributes & "|관리" & vbCrLf & "번호;MgtItemNumber;100;;l;" & "o;n;n;;"                  '관리 항목 번호
            gridAttributes = gridAttributes & "|차변 금액;DrAmount;78;#,##0;r;" & "o;n;n;;"                                '차변 금액 
            gridAttributes = gridAttributes & "|대변 금액;CrAmount;78;#,##0;r;" & "o;n;n;;"                                '대변 금액 
            gridAttributes = gridAttributes & "|적요;Remark;318;;l;" & "o;n;n;;"                                           '적요 
            gridAttributes = gridAttributes & "|메모;Memo;100;;l;" & "o;n;y;;"                                             '메모
            gridAttributes = gridAttributes & "|수량;DrAmount;80;;r;" & "o;n;y;;"                                          '수량
            gridAttributes = gridAttributes & "|단가;DrAmount;80;#,##0;r;" & "o;n;y;;"                                     '단가
            gridAttributes = gridAttributes & "|이자율;DrAmount;80;;r;" & "o;n;y;;"                                        '이자율
            gridAttributes = gridAttributes & "|시작 일자;BeginDate;75;;c;" & "o;n;y;;"                                     '시작 일자
            gridAttributes = gridAttributes & "|종료 일자;EndDate;75;;c;" & "o;n;y;;"                                       '종료 일자
            gridAttributes = gridAttributes & "|귀속" & vbCrLf & "부서코드;RevDepartmentCode;62;;c;" & "o;n;n;;"           '귀속 부서 코드 
            gridAttributes = gridAttributes & "|귀속" & vbCrLf & "부서명;RevDepartmentName;74;;l;" & "o;n;n;;"              '귀속 부서 코드 
            gridAttributes = gridAttributes & "|귀속" & vbCrLf & "사원번호;RevEmployee;65;;c;" & "o;n;y;;"                 '귀속 사원 번호 
            gridAttributes = gridAttributes & "|귀속" & vbCrLf & "사원명;RevEmployeeName;75;;l;" & "o;n;y;;"                '귀속 사원 번호 
            gridAttributes = gridAttributes & "|증빙" & vbCrLf & "구분;EvidenceDivision;75;;c;" & "o;n;y;;"                '증빙 구분 
            gridAttributes = gridAttributes & "|계산서" & vbCrLf & "발행여부;BillPublishYesOrNo;50;;c;" & "o;n;y;;"        '계산서 발행 여부 
            gridAttributes = gridAttributes & "|전자계산서" & vbCrLf & "여부;EBillYesOrNo;50;;c;" & "o;n;y;;"              '전자 계산서 여부 
            gridAttributes = gridAttributes & "|공급가;SupplyAmount;90;#,##0;r;" & "o;n;y;;"                               '공급가 
            gridAttributes = gridAttributes & "|세액;TaxAmount;85;#,##0;r;" & "o;n;y;;"                                    '세액 
            gridAttributes = gridAttributes & "|대행사;AgentCustomerCode;85;;c;" & "o;n;y;;"                               '대행사  
            gridAttributes = gridAttributes & "|ASP업체;ASPCode;85;;c;" & "o;n;y;;"                                        'ASP 업체 
            gridAttributes = gridAttributes & "|참조" & vbCrLf & "항번;RefItemNumber;40;;r;" & "o;n;y;;"                   '참조 항목 번호 
            gridAttributes = gridAttributes & "|예산" & vbCrLf & "코드;BudgetCode;65;;c;" & "o;n;n;;"                      '예산 코드 
            gridAttributes = gridAttributes & "|예산" & vbCrLf & "코드명;BudgetName;85;;l;" & "o;n;n;;"                     '예산 코드 명 
            gridAttributes = gridAttributes & "|예산" & vbCrLf & "귀속년월;BudgetRevYearMonth;90;;c;" & "o;n;n;;"          '예산 귀속 년월 
            gridAttributes = gridAttributes & "|예산" & vbCrLf & "적요;BudgetRemark;100;;l;" & "o;n;y;;"                   '예산 적요

            gridAttributes = gridAttributes & "|반제" & vbCrLf & "여부;BranchNum;75;;c;" & "o;n;y;;"                                  '전표 유형 
            gridAttributes = gridAttributes & "|접대비" & vbCrLf & "여부;YearMonths;75;;c;" & "o;n;y;;"                                      '전표 일자 
            gridAttributes = gridAttributes & "|세금 손금" & vbCrLf & "불산입여부;ExclusionYesOrNo;60;;c;" & "o;n;y;;"           '손금 불산입 여부 

            gridAttributes = gridAttributes & "|판매 참조키;DepositAmt;78;;r;" & "o;n;n;;"                       '전표 번호 
            gridAttributes = gridAttributes & "|회계전표 관리번호;AccountSlipNumber;115;;r;" & "o;n;n;;"                       '전표 번호 


            'grid code combo 
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SlipDivision;전표 유형 명;"
            gridCodeNameList = gridCodeNameList & "/EnterpriseCode;사업 부문 명;"
            gridCodeNameList = gridCodeNameList & "/SlipType;전표 대체 구분 명;"
            gridCodeNameList = gridCodeNameList & "/EnterpriseCode;사업 부문 명;"
            gridCodeNameList = gridCodeNameList & "/ManufactureDivision;제조 구분 명;"
            gridCodeNameList = gridCodeNameList & "/DrCrDivision;기준 변 구분 명;"
            gridCodeNameList = gridCodeNameList & "/EvidenceDivision;증빙 구분 명;"


            '' ''gridCodeNameList = gridCodeNameList & "BizTypeCd;휴간구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.txtCriteria.TextValue = "4"
            RequestData()

        End Sub
#End Region
        Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click
            SlipData()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            CancelSlip()
        End Sub
    End Class

End Namespace
