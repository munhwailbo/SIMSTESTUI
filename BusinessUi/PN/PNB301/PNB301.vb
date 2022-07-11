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

    Public Class PNB301
        Inherits CommonControls.UiControl

        Private Sub PNB301_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "n;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|구분;TreePath;114;;1;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|영업담당;ChargeEmpNumNm;63;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;76;;1;" & "o;n;n;9;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;89;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|계약자명;BranchChiefCdNm;62;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계약일자;ContractDt;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;0;yyyy-MM-dd;4;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;0;yyyy-MM-dd;4;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|계약해지일자;ContractCancelDt;87;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|발송부수;DeliveryPaperNum;61;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|본사유가;ValPaperNum;61;#,##0;7;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|지국유가;BranchValPaperNum;0;#,##0;7;" & "o;n;y;4;"
            gridAttributes = gridAttributes & "|지국보증금;DepositAmt;85;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|완납적립금;DepositDivCd;85;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|합계;SumAmt;85;#,##0;7;" & "o;n;n;15;"
            gridAttributes = gridAttributes & "|실운영자;RealOperatorName;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|운영자관계;OperatorRelation;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|운영구분코드;ManageDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|교체횟수;ChangeNum;50;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|교체사유;ChangeReason;68;;1;" & "o;n;n;1000;"
            gridAttributes = gridAttributes & "|지국주소;Addr;197;;1;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|지국전화번호1;PhoneNum1;99;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국전화번호2;PhoneNum2;95;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국팩스번호;FaxNum;106;;1;" & "o;n;n;30;"   
            gridAttributes = gridAttributes & "|보증인성명;GuarantorNm;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|보증인관계;GuarantorRelation;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|은행코드;BankCd;71;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;135;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국지역코드;BranchRegionCd;87;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|분국수;OfficeNum;50;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|가구수;HouseNum;44;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|이전일자;TransferDate;85;yyyy-MM-dd;4;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|이전횟수;TransferNum;62;;1;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|인쇄지역코드;PrintRegionCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|교체구분코드;ChangeDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|운영자성명;OperatorName;74;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|운영자주민번호;OperatorSocialNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|계약완결여부;ContractYN;76;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|보증인주민번호;GuarantorSocialNum;0;;1;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|보증인재산세납부여부;GuarantorPropertyTaxAmt;136;;1;" & "o;n;n;1;"
            gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|부서구분코드(출력용);DeptDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|운영개시년월;OpenYYYYMM;0;yyyy-MM;4;" & "o;n;y;6;"
            gridAttributes = gridAttributes & "|운영종료년월;EndYYYYMM;0;yyyy-MM;4;" & "o;n;y;6;"
            gridAttributes = gridAttributes & "|일반단가;UnitCost;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|특수단가;SpecUnitCost;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;1;" & "o;n;y;7;"
            gridAttributes = gridAttributes & "|처리구분코드;ProcessDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|계약구분코드;ContractDivCd;0;;1;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|임차보증금;RentDepositAmt;0;#,##0;7;" & "o;n;y;15;"
            gridAttributes = gridAttributes & "|임차료;RentAmt;0;#,##0;7;" & "o;n;y;15;"

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

            '담당자 셋팅
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("로그인 ID"), _
                                                GmainBusinessFunction.GetValue("역할대행사번"))
            End If

        End Sub
#End Region

        ''' <summary>
        ''' 함수명 : grd_1_DoubleClick 
        ''' 기  능 : 
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Private Sub grd_1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.DoubleClick
            '지국 정보 화면으로 지국 코드를 넘겨서 해당 지국 정보를 조회 한다.
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strBranchCd As String '지국 코드

            strBranchCd = Me.grd_1.get_TextMatrix(Me.grd_1.Row, Me.grd_1.get_ColIndex("BranchCd")) '지국 코드

            GmainBusinessFunction.SetValue("화면 전환", "PNB202;" & strBranchCd)
            Me.ShowUiControl("PNB202", strBranchCd)
        End Sub

        Private Sub picCriteria_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCriteria_1.Click

        End Sub
    End Class

End Namespace
