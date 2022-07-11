'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 지국계약등록
' form 설명 : 지국계약등록 한다.
' 작성자 : 황인중
' 작성일 : 2008-09-17
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB202
        Inherits CommonControls.UiControl

        Private Sub PNB202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill  ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
            End If
        End Sub

        ''' <summary>
        ''' 함수명 : PNB202_Enter 
        ''' 기  능 : 화면 전환(지국 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB202_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetBranchCd(ShareParameters(1))
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        '====================================================================================================
        Public Sub Initialize()

            '담당자 셋팅
            popChargeEmpNum.Enabled = True
            If GmainBusinessFunction.GetValue("관리담당여부") = "0" Then
                popChargeEmpNum.Enabled = False
                popChargeEmpNum.TextValue = IIf(GmainBusinessFunction.GetValue("역할대행사번").ToString.Length < 1, _
                                                GmainBusinessFunction.GetValue("로그인 ID"), _
                                                GmainBusinessFunction.GetValue("역할대행사번"))
            End If

            ' 납입보증금계와 완납적립금 계
            lbl_napkum.Visible = False
            lbl_wankum.Visible = False
            num_napTkum.Visible = False
            num_wanTkum.Visible = False

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;120;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;150;;c;" & "o;n;y;7;지국 명;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|회수;ChangeNum;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|계약일자;ContractDt;120;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|계약완결여부;ContractYN;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|지국장성명;BranchChiefCdName;80;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;80;;c;" & "o;n;n;10;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 1

            '==============================================================                                                                           
            '  grid_3 를 초기화 한다.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"

            gridAttributes = gridAttributes & "|이전일자;TransferDate;8;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|이전횟수;TransferNum;4;;l;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|처리구분코드;ProcessDivCd;10;;c;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|계약구분코드;ContractDivCd;10;;c;" & "io;n;y;10;"

            gridAttributes = gridAttributes & "|건물주;OwnerNm;30;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|임차보증금;RentDepositAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|월세;RentAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|계약만료일자;ContractEdDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|지국우편번호;PostNum;10;;c;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|지국주소;Addr;100;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|채권확보;Obligation;30;;l;" & "io;n;n;30;"

            '' '' ''2009.01.23 하정호 차장에 의하여 최종 정리 됨(그리드 항목 전체 재정의)
            gridAttributes = gridAttributes & "|약도이미지파일경로;OutlineMapFilePath;0;;l;" & "o;n;y;0;"
            gridAttributes = gridAttributes & "|대지평수;SiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|건물평수;BuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|사용평수;UseArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|층구분;Floor;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|제한물건;LimitedItem;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|대물담보-소유자명;SecurityOwnerNm;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|대물담보-우편번호;SecurityPostNum;10;;l;" & "io;n;y;10;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;CodeHangulName;90;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|대물담보-주소;SecurityAddr;100;;l;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|대물담보-대지평수;SecuritySiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|대물담보-건물평수;SecurityBuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|대물담보-제한물건;SecurityLimitedItem;50;;l;" & "io;n;y;50;"
            gridAttributes = gridAttributes & "|은행구분코드;BankCd;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|건물주와의관계;OwnerRelation;10;;l;" & "io;n;y;10;"

            'grd_3 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ProcessDivCd;처리구분코드"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;계약구분코드"
            gridCodeNameList = gridCodeNameList & "/BankCd;은행구분코드"
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_3.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_4 를 초기화 한다.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "io;n;n;7;지국코드;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|순번;Orders;4;;r;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|공장구분코드;PrintOfficeCd;10;;l;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;10;;l;" & "io;n;n;10;"       '(40)
            'grd_4 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_4.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_4.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_5 를 초기화 한다.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "io;n;n;7;지국코드;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|순번;Orders;4;;;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|장비구분코드;DivisionCd;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|장비상세내용;EquipmentNm;30;;;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|수량;Cnt;4;;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|금액;Amount;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|불출일자;StartDt;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|폐기일자;EndDt;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|비고;Remark;1000;;;" & "io;n;n;1000;"
            'grd_5 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DivisionCd;장비구분코드"
            grd_5.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_5.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_6 를 초기화 한다.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "io;n;n;7;지국코드;BranchNm"       '(10)
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;4;;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|우편번호코드;ZipSeriesNum;10;;l;" & "io;n;n;10;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;CodeHangulName;90;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|주소;Addr;100;;l;" & "o;n;n;100;"
            'grd_6 code combo                                                                                                                       
            gridCodeNameList = ""
            grd_6.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_6.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_7 를 초기화 한다.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;7;;;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|구비서류코드;ReqDocCd;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|제출여부;SubmitYN;7;;;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|비고;remark;10;;;" & "io;n;n;10;"

            'grd_7 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ReqDocCd;구비서류코드"
            grd_7.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_7.ExplorerBar = 1


            '==============================================================                                                                           
            '  grd_8 를 초기화 한다.                                                                                                                
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;7;;l;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|순번;Orders;8;;r;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|보증금-완납적립금 구분;DepositDivCd;7;;c;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|적용일자;ReceiptDt;10;####-##-##;c;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|계정코드;AccountCd;7;;c;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|금액;DepositAmt;10;#,##0;r;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|지대년월;PayYYYYMM;10;####-##;c;" & "io;n;n;10;"

            'grd_8 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DepositDivCd;보증금적립금구분코드"
            gridCodeNameList = gridCodeNameList & "/AccountCd;입금구분코드"


            grd_8.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_8.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_9 를 초기화 한다.    단가                                                                                                             
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;7;;l;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;7;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|순번;Orders;8;;r;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|적용일자;ApplyDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|납입단가1;ValAmount1;20;#,##0;c;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|납입단가2;ValAmount2;20;#,##0;c;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|납입단가3;ValAmount3;20;#,##0;c;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|납입단가4;ValAmount4;20;#,##0;c;" & "io;n;y;20;"
            gridAttributes = gridAttributes & "|적요;AccountCd;20;;c;" & "io;n;y;200;"
            gridAttributes = gridAttributes & "|;Dummy;20;;c;" & "io;n;n;10;"

            'grd_9 code combo                                                                                                                       
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "DepositDivCd;보증금적립금구분코드"

            grd_9.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_9.ExplorerBar = 1

            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            '==============================================================                                                                           
            '  grd_10 를 초기화 한다.    경리거래처                                                                                                             
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;7;;l;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;7;;l;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|적용일자;StDate;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|거래처코드;CustomerCode;7;;l;" & "io;n;n;7;거래처코드;CustomerName"
            gridAttributes = gridAttributes & "|거래처명;CustomerName;7;;l;" & "o;n;n;7;"
            gridAttributes = gridAttributes & "|적요;Remark;20;;c;" & "io;n;n;200;"
            gridAttributes = gridAttributes & "|;Dummy;20;;c;" & "io;n;n;10;"

            gridCodeNameList = ""
            grd_10.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_10.ExplorerBar = 1
            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


        End Sub

        Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrd_3.Click, _
         btngrd_4.Click, btngrd_5.Click, btngrd_6.Click, btngrd_7.Click, btngrd_8.Click, btngrd_9.Click, btngrd_10.Click

            grd_3.Visible = False
            grd_4.Visible = False
            grd_5.Visible = False
            grd_6.Visible = False
            grd_7.Visible = False
            grd_8.Visible = False
            grd_9.Visible = False
            grd_10.Visible = False

            ' 납입보증금계와 완납적립금 계
            lbl_napkum.Visible = False
            lbl_wankum.Visible = False
            num_napTkum.Visible = False
            num_wanTkum.Visible = False

            Me.lbl_grd_Title.Text = "[" & Me.ActiveControl.Text & "]"
            btnPlus.Visible = False : btnSave.Visible = False : btnDelete.Visible = False

            Dim strGridName As String = Mid(Me.ActiveControl.Name, 4, 6)  '???????????????????????? 10해도 되나?.. 안될꺼 같은데

            If Me.grd_3.Name = strGridName Then
                Me.grd_3.Focus() : Me.grd_3.Visible = True
            ElseIf Me.grd_4.Name = strGridName Then
                Me.grd_4.Focus() : Me.grd_4.Visible = True
            ElseIf Me.grd_5.Name = strGridName Then
                Me.grd_5.Focus() : Me.grd_5.Visible = True
            ElseIf Me.grd_6.Name = strGridName Then
                Me.grd_6.Focus() : Me.grd_6.Visible = True
            ElseIf Me.grd_7.Name = strGridName Then    '구비서류
                Me.grd_7.Focus() : Me.grd_7.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
            ElseIf Me.grd_8.Name = strGridName Then    '지대보증금
                Me.grd_8.Focus() : Me.grd_8.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
                lbl_napkum.Visible = True : lbl_wankum.Visible = True
                num_napTkum.Visible = True : num_wanTkum.Visible = True   ' 납입보증금과 완납적립금 계
            ElseIf Me.grd_9.Name = strGridName Then    '단가
                Me.grd_9.Focus() : Me.grd_9.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
            ElseIf Me.grd_10.Name = strGridName Then   '경리거래처
                Me.grd_10.Focus() : Me.grd_10.Visible = True
                btnPlus.Visible = True : btnSave.Visible = True : btnDelete.Visible = True
            End If

        End Sub

        Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click

            If Me.txtNewGubn.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Me.grd_3.AddRow()
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BranchCd"), Me.txtBranchNum.TextValue)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SiteArea"), 0) '
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("UseArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecuritySiteArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecurityBuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentDepositAmt"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentAmt"), 0)
                ElseIf Me.grd_4.Visible = True Then
                    Me.grd_4.AddRow()
                    Me.grd_4.set_TextMatrix(Me.grd_4.Rows - 1, Me.grd_4.get_ColIndex("BranchCd"), Me.popBranchCd.TextValue)
                ElseIf Me.grd_5.Visible = True Then
                    Me.grd_5.AddRow()
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("BranchCd"), Me.popBranchCd.TextValue)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Cnt"), 0)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Amount"), 0)
                ElseIf Me.grd_6.Visible = True Then
                    Me.grd_6.AddRow()
                    Me.grd_6.set_TextMatrix(Me.grd_6.Rows - 1, Me.grd_6.get_ColIndex("BranchCd"), Me.popBranchCd.TextValue)
                ElseIf Me.grd_7.Visible = True Then
                    Me.grd_7.AddRow()
                    Me.grd_7.set_TextMatrix(Me.grd_7.Rows - 1, Me.grd_7.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                ElseIf Me.grd_8.Visible = True Then
                    Me.grd_8.AddRow()
                    Me.grd_8.set_TextMatrix(Me.grd_8.Rows - 1, Me.grd_8.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                    Me.grd_8.set_TextMatrix(Me.grd_8.Rows - 1, Me.grd_8.get_ColIndex("DepositAmt"), 0)
                ElseIf Me.grd_9.Visible = True Then
                    Me.grd_9.AddRow()
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount1"), 0)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount2"), 0)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount3"), 0)
                    Me.grd_9.set_TextMatrix(Me.grd_9.Rows - 1, Me.grd_9.get_ColIndex("ValAmount4"), 0)
                ElseIf Me.grd_10.Visible = True Then
                    Me.grd_10.AddRow()
                    Me.grd_10.set_TextMatrix(Me.grd_10.Rows - 1, Me.grd_10.get_ColIndex("BranchNum"), Me.txtBranchNum.TextValue)
                End If
            Else
                MsgBox("지국 계약 사항을 먼저 저장하세요", MsgBoxStyle.Information)
            End If

        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If Me.txtNewGubn.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Call Me.SaveData_2()
                ElseIf Me.grd_4.Visible = True Then
                    Call Me.SaveData_3()
                ElseIf Me.grd_5.Visible = True Then
                    Call Me.SaveData_4()
                ElseIf Me.grd_6.Visible = True Then
                    Call Me.SaveData_5()
                ElseIf Me.grd_7.Visible = True Then
                    Call Me.SaveData_6()
                ElseIf Me.grd_8.Visible = True Then
                    Call Me.SaveData_7()
                ElseIf Me.grd_9.Visible = True Then
                    Call Me.SaveData_8()
                ElseIf Me.grd_10.Visible = True Then
                    Call Me.SaveData_10()
                End If
            End If
        End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            If Me.txtNewGubn.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Call Me.DeleteData_2()
                ElseIf Me.grd_4.Visible = True Then
                    Call Me.DeleteData_3()
                ElseIf Me.grd_5.Visible = True Then
                    Call Me.DeleteData_4()
                ElseIf Me.grd_6.Visible = True Then
                    Call Me.DeleteData_5()
                ElseIf Me.grd_7.Visible = True Then
                    Call Me.DeleteData_6()
                ElseIf Me.grd_8.Visible = True Then
                    Call Me.DeleteData_7()
                ElseIf Me.grd_9.Visible = True Then
                    Call Me.DeleteData_8()
                ElseIf Me.grd_10.Visible = True Then
                    Call Me.DeleteData_10()
                End If
            End If
        End Sub

        ''' <summary>
        ''' 함수명 : SetBranchCd
        ''' 기  능 : 다른 화면에서 지국 코드 를 받아서 해당 지국내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetBranchCd(ByVal strBranchCd As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.popBaseBranchCd_R.TextValue = strBranchCd  '지국코드 

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub btnJumpChiefCd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpChiefCd.Click
            '독자구독정보화면으로 이동
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strBranchChiefName As String '지국장명
            Dim strChiefCd As String '지국장코드

            strBranchChiefName = popBranchChiefCd.NameText  '지국장명
            strChiefCd = popBranchChiefCd.TextValue         '지국장코드

            GmainBusinessFunction.SetValue("화면 전환", "PNB201;" & strBranchChiefName & ";" & strChiefCd)
            Me.ShowUiControl("PNB201", strBranchChiefName)
        End Sub

        Private Sub btnJumpBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpBranch.Click
            '지국정보화면으로 이동
            If Me.grd_1.Rows <= Me.grd_1.FixedRows Then Exit Sub

            Dim strBranchCd As String '지국코드
            Dim strBranchNm As String '지국명

            strBranchCd = popBranchCd.TextValue   '지국코드
            strBranchNm = popBranchCd.NameText    '지국명

            GmainBusinessFunction.SetValue("화면 전환", "PNB101;" & strBranchCd & ";" & strBranchNm)
            Me.ShowUiControl("PNB101", strBranchNm)
        End Sub

    End Class

End Namespace
