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

    Public Class PNB303
        Inherits CommonControls.UiControl

        Private Sub PNB303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;9;;;" & "o;n;n;9;"       '(10)
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "o;n;n;7;"       '(20)
            gridAttributes = gridAttributes & "|지국명;BranchNm;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|교체횟수;ChangeNum;4;;;" & "o;n;n;4;"       '(30)
            gridAttributes = gridAttributes & "|이전일자;TransferDate;8;;;" & "o;n;n;8;"       '(440)
            gridAttributes = gridAttributes & "|이전횟수;TransferNum;4;;;" & "o;n;n;4;"       '(450)
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;10;;;" & "o;n;n;10;"       '(80)
            gridAttributes = gridAttributes & "|지국장명;BranchChiefCdNm;10;;;" & "o;n;n;10;"       '(80)

            gridAttributes = gridAttributes & "|계약일자;ContractDt;8;;;" & "o;n;n;8;"       '(40)
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;8;;;" & "o;n;y;8;"       '(50)
            gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;8;;;" & "o;n;y;8;"       '(60)
            gridAttributes = gridAttributes & "|계약해지일자;ContractCancelDt;8;;;" & "o;n;y;8;"       '(70)

            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;7;;;" & "o;n;y;7;"       '(100)
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNumNm;7;;;" & "o;n;y;7;"       '(100)
            gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;10;;;" & "o;n;y;10;"       '(110)
            gridAttributes = gridAttributes & "|부서코드;DeptCd;10;;;" & "o;n;y;10;"       '(120)
            gridAttributes = gridAttributes & "|부서명;DeptNm;10;;;" & "o;n;y;10;"       '(120)
            gridAttributes = gridAttributes & "|부서구분코드(출력용);DeptDivCd;10;;;" & "o;n;y;10;"       '(130)
            gridAttributes = gridAttributes & "|운영개시년월;OpenYYYYMM;6;;;" & "o;n;y;6;"       '(140)
            gridAttributes = gridAttributes & "|운영종료년월;EndYYYYMM;6;;;" & "o;n;y;6;"       '(150)
            gridAttributes = gridAttributes & "|교체구분코드;ChangeDivCd;10;;;" & "o;n;y;10;"       '(160)
            gridAttributes = gridAttributes & "|운영구분코드;ManageDivCd;10;;;" & "o;n;y;10;"       '(170)
            gridAttributes = gridAttributes & "|인쇄지역코드;PrintRegionCd;10;;;" & "o;n;y;10;"       '(180)
            gridAttributes = gridAttributes & "|지국지역코드;BranchRegionCd;10;;;" & "o;n;n;10;"       '(190)
            gridAttributes = gridAttributes & "|지국전화번호1;PhoneNum1;30;;;" & "o;n;n;30;"       '(200)
            gridAttributes = gridAttributes & "|지국전화번호2;PhoneNum2;30;;;" & "o;n;n;30;"       '(210)
            gridAttributes = gridAttributes & "|지국팩스번호;FaxNum;30;;;" & "o;n;n;30;"       '(220)
            gridAttributes = gridAttributes & "|분국수;OfficeNum;4;;;" & "o;n;n;4;"       '(230)
            gridAttributes = gridAttributes & "|가구수;HouseNum;4;;;" & "o;n;n;4;"       '(240)
            gridAttributes = gridAttributes & "|지국보증금;DepositAmt;15;#,##0;r;" & "o;n;n;15;"       '(250)
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;30;;;" & "o;n;n;30;"       '(260)
            gridAttributes = gridAttributes & "|은행코드;BankCd;10;;;" & "o;n;n;10;"       '(270)
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;30;;;" & "o;n;n;30;"       '(280)
            gridAttributes = gridAttributes & "|일반단가;UnitCost;15;#,##0;r;" & "o;n;y;15;"       '(290)
            gridAttributes = gridAttributes & "|특수단가;SpecUnitCost;15;#,##0;r;" & "o;n;y;15;"       '(300)
            gridAttributes = gridAttributes & "|발송부수;DeliveryPaperNum;4;;c;" & "o;n;n;4;"       '(310)
            gridAttributes = gridAttributes & "|본사유가;ValPaperNum;4;#,##0;r;" & "o;n;n;4;"       '(320)
            gridAttributes = gridAttributes & "|지국유가;BranchValPaperNum;4;#,##0;r;" & "o;n;y;4;"       '(330)
            gridAttributes = gridAttributes & "|교체사유;ChangeReason;1000;;;" & "o;n;n;1000;"       '(340)
            gridAttributes = gridAttributes & "|보증인성명;GuarantorNm;30;;;" & "o;n;n;30;"       '(350)
            gridAttributes = gridAttributes & "|보증인관계;GuarantorRelation;10;;;" & "o;n;n;10;"       '(360)
            gridAttributes = gridAttributes & "|보증인주민번호;GuarantorSocialNum;30;;;" & "o;n;n;30;"       '(370)
            gridAttributes = gridAttributes & "|보증인재산세납부;GuarantorPropertyTaxAmt;1;;;" & "o;n;n;1;"       '(380)
            gridAttributes = gridAttributes & "|운영자성명;OperatorName;30;;;" & "o;n;n;30;"       '(390)
            gridAttributes = gridAttributes & "|운영자관계;OperatorRelation;10;;;" & "o;n;n;10;"       '(400)
            gridAttributes = gridAttributes & "|운영자주민번호;OperatorSocialNum;30;;;" & "o;n;n;30;"       '(410)
            gridAttributes = gridAttributes & "|계약완결여부;ContractYN;1;;;" & "o;n;n;1;"       '(420)

            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "o;n;y;7;"       '(430)
            gridAttributes = gridAttributes & "|처리구분코드;ProcessDivCd;10;;;" & "o;n;y;10;"       '(460)
            gridAttributes = gridAttributes & "|계약구분코드;ContractDivCd;10;;;" & "o;n;y;10;"       '(470)
            gridAttributes = gridAttributes & "|지국주소;Addr;100;;;" & "o;n;n;100;"       '(500)
            gridAttributes = gridAttributes & "|임차보증금;RentDepositAmt;15;#,##0;r;" & "o;n;y;15;"       '(660)
            gridAttributes = gridAttributes & "|임차료;RentAmt;15;#,##0;r;" & "o;n;y;15;"       '(670)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;담당자유형코드"
            gridCodeNameList = gridCodeNameList & "/ChangeDivCd;교체구분코드"
            gridCodeNameList = gridCodeNameList & "/ManageDivCd;운영구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintRegionCd;인쇄지역코드"
            gridCodeNameList = gridCodeNameList & "/BranchRegionCd;지국지역코드"
            gridCodeNameList = gridCodeNameList & "/ProcessDivCd;처리구분코드"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;계약구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

        End Sub
#End Region



    End Class

End Namespace
