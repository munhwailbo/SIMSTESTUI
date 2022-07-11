'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 지국정보등록
' form 설명 : 지국정보등록 한다.
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

    Public Class PNB101
        Inherits CommonControls.UiControl

        Private Sub PNB101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill  ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
            End If
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.   <지국M>
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "a;r;y;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;90;;c;" & "o;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;50;"

            gridAttributes = gridAttributes & "|부서코드;DeptCd;80;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|부서명;DeptNm;80;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당자;ChargeEmpNum;80;;c;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNumNm;80;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당자유형;ChargeTypeCd;120;;c;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|관할지역;BizArea;120;;l;" & "o;n;n;10;"    ' 관할지역
            gridAttributes = gridAttributes & "|구독대상처;MkTargetGroup;120;;l;" & "o;n;n;10;"    ' 주요구독대상처
            gridAttributes = gridAttributes & "|계약일자;OpenDate;120;####-##-##;c;" & "o;n;n;10;"    ' 개국일자
            gridAttributes = gridAttributes & "|폐국일자;CloseDate;120;####-##-##;c;" & "o;n;n;10;"    ' 폐국일자
            gridAttributes = gridAttributes & "|폐국사유;CloseRemark;120;;l;" & "o;n;n;10;"    ' 폐국사유

            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '끝자리 맞추기 용

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;담당자유형코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3

            '==============================================================                                                                           
            '  grid_3 를 초기화 한다.   <지국사무실(임차)>                                                                                        
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;30;"
            '' '' '' ''2009.01.23 박근철 부장 요청에 의하여 이전일자 표기 안되게 변경
            gridAttributes = gridAttributes & "|이전일자;TransferDate;8;;l;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|이전횟수;TransferNum;4;;c;" & "io;n;n;4;"

            gridAttributes = gridAttributes & "|처리구분;ProcessDivCd;10;;c;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|계약구분;ContractDivCd;10;;c;" & "io;n;n;10;"

            gridAttributes = gridAttributes & "|건물주;OwnerNm;30;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|임차보증금;RentDepositAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|월세;RentAmt;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;8;;l;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|계약만료일자;ContractEdDt;8;;l;" & "io;n;n;8;"

            gridAttributes = gridAttributes & "|지국주소;Addr;100;;l;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|지국우편번호;PostNum;10;;c;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|채권확보;Obligation;30;;l;" & "io;n;n;30;"

            gridAttributes = gridAttributes & "|은행구분코드;BankCd;10;;l;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;30;;l;" & "io;n;n;30;"

            '' '' ''2009.01.23 하정호 차장에 의하여 최종 정리 됨(그리드 항목 전체 재정의)
            gridAttributes = gridAttributes & "|약도이미지파일경로;OutlineMapFilePath;0;;l;" & "o;n;y;0;"
            gridAttributes = gridAttributes & "|대지평수;SiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|건물평수;BuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|사용평수;UseArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|층구분;Floor;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|제한물건;LimitedItem;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|대물담보-소유자명;SecurityOwnerNm;30;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|대물담보-우편번호;SecurityPostNum;10;;l;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|대물담보-주소;SecurityAddr;100;;l;" & "io;n;y;100;"
            gridAttributes = gridAttributes & "|대물담보-대지평수;SecuritySiteArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|대물담보-건물평수;SecurityBuildingArea;4;;r;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|대물담보-제한물건;SecurityLimitedItem;50;;l;" & "io;n;y;50;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;30;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|건물주와의관계;OwnerRelation;10;;l;" & "io;y;n;10;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;y;10;"    '끝자리 맞추기 용

            'grd_3 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ProcessDivCd;지국사무실처리구분코드"
            gridCodeNameList = gridCodeNameList & "/ContractDivCd;지국사무실계약구분코드"
            gridCodeNameList = gridCodeNameList & "/OwnerRelation;건물주와의관계"
            grd_3.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_3.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_4 를 초기화 한다.      <지국인쇄공장>                                                                                   
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|순번;Orders;4;;r;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|인쇄처;PrintOfficeCd;10;;l;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|판구분코드;PrintPlateCd;10;;l;" & "io;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '끝자리 맞추기 용
            'grd_4 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "PrintOfficeCd;공장구분코드"
            gridCodeNameList = gridCodeNameList & "/PrintPlateCd;판구분코드"
            grd_4.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_4.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_5 를 초기화 한다.        <지국장비>                                                                                      
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|순번;Orders;4;;;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|장비구분코드;DivisionCd;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|장비상세내용;EquipmentNm;30;;;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|수량;Cnt;4;#,##0;r;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|금액;Amount;15;#,##0;r;" & "io;n;n;15;"
            gridAttributes = gridAttributes & "|불출일자;StartDt;8;####-##-##;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|폐기일자;EndDt;8;####-##-##;c;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|비고;Remark;1000;;;" & "io;n;n;1000;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '끝자리 맞추기 용
            'grd_5 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "DivisionCd;장비구분코드"
            grd_5.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_5.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_6 를 초기화 한다.       <지국관할지역>                                                            
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;c;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|일련번호;SeriesNum;4;;r;" & "io;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|우편번호코드;ZipSeriesNum;10;;l;" & "io;y;n;10;우편번호;Addr"       '(30)
            gridAttributes = gridAttributes & "|주소;Addr;100;;l;" & "o;n;n;100;"       '(40)
            gridAttributes = gridAttributes & "|구독대상처;MkTargetGroup;80;;l;" & "io;n;n;10;"    ' 주요구독대상처 '200801013
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '끝자리 맞추기 용
            'grd_6 code combo                                                                                                                       
            gridCodeNameList = ""
            grd_6.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_6.ExplorerBar = 1

            '==============================================================                                                                           
            '  grd_7 를 초기화 한다.       <지국담당>                                                             
            '--------------------------------------------------------------                                                                           
            gridAttributes = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)                            
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);                   
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;7;;;" & "io;n;n;7;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;120;;l;" & "o;n;n;30;" '(10)
            gridAttributes = gridAttributes & "|적용일자;ProcessDt;8;;;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;7;;;" & "io;n;n;7;영업사원 명;EmployeeNameHangul;"
            gridAttributes = gridAttributes & "|담당자명;ChargeEmpNumNm;7;;;" & "io;n;n;7;"
            gridAttributes = gridAttributes & "|담당자유형코드;ChargeTypeCd;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|부서코드;DeptCd;10;;;" & "io;n;y;10;"
            gridAttributes = gridAttributes & "|;Dummy;10;;;" & "io;n;n;10;"    '끝자리 맞추기 용
            'grd_7 code combo                                                                                                                       
            gridCodeNameList = ""
            gridCodeNameList = gridCodeNameList & "ChargeTypeCd;담당자유형코드"
            grd_7.Initialize(gridAttributes, gridCodeNameList)
            'Me.grd_7.ExplorerBar = 1

            '''''
            Me.grd_7.Focus() : Me.grd_7.Visible = True
            lbl_grd_Title.Text = "[ " & Me.btngrd_7.Text & " ]"

        End Sub

        Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrd_3.Click, _
         btngrd_4.Click, btngrd_5.Click, btngrd_6.Click, btngrd_7.Click

            grd_3.Visible = False
            grd_4.Visible = False
            grd_5.Visible = False
            grd_6.Visible = False
            grd_7.Visible = False

            Dim strGridName As String = Mid(Me.ActiveControl.Name, 4, 5)

            btnPlus.Visible = True
            btnSave.Visible = True
            btnDelete.Visible = True

            If Me.grd_3.Name = strGridName Then
                Me.grd_3.Focus() : Me.grd_3.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"

                ''' 2009.01.23  하정호 차장 요청으로 인하여 계약 등록 화면(별도) 에서 처리 - 서은희씨 확인
                btnPlus.Visible = False
                btnSave.Visible = False
                btnDelete.Visible = False

            ElseIf Me.grd_4.Name = strGridName Then
                Me.grd_4.Focus() : Me.grd_4.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            ElseIf Me.grd_5.Name = strGridName Then
                Me.grd_5.Focus() : Me.grd_5.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            ElseIf Me.grd_6.Name = strGridName Then
                Me.grd_6.Focus() : Me.grd_6.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            ElseIf Me.grd_7.Name = strGridName Then
                Me.grd_7.Focus() : Me.grd_7.Visible = True
                lbl_grd_Title.Text = "[ " & Me.ActiveControl.Text & " ]"
            End If

        End Sub

        Private Sub grdAddRow(ByVal _grd As ubiLease.GridControl.grd, ByVal pic As Windows.Forms.PictureBox)
            ''================================ 
            '' 해당 지국에 사무실, 인쇄 공장, 장비 지원, 담당자 정보를 등록하고 저장할때 지국의 행을 추가한다.
            '' 이동할 값
            '' 1. 지국 정보 가져감
            '' 2. 지국 담당자 가져감.
            '' 

        End Sub

        Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click

            If Me.txtBranchCd.TextValue <> "" Then
                If Me.grd_3.Visible = True Then
                    Me.grd_3.AddRow()
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SiteArea"), 0) '
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("BuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("UseArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecuritySiteArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("SecurityBuildingArea"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentDepositAmt"), 0)
                    Me.grd_3.set_TextMatrix(Me.grd_3.Rows - 1, Me.grd_3.get_ColIndex("RentAmt"), 0)
                ElseIf Me.grd_4.Visible = True Then
                    Me.grd_4.AddRow()
                    Me.grd_4.set_TextMatrix(Me.grd_4.Rows - 1, Me.grd_4.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue) '
                ElseIf Me.grd_5.Visible = True Then
                    Me.grd_5.AddRow()
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Cnt"), 0)
                    Me.grd_5.set_TextMatrix(Me.grd_5.Rows - 1, Me.grd_5.get_ColIndex("Amount"), 0)
                ElseIf Me.grd_6.Visible = True Then
                    Me.grd_6.AddRow()
                    Me.grd_6.set_TextMatrix(Me.grd_6.Rows - 1, Me.grd_6.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                ElseIf Me.grd_7.Visible = True Then
                    Me.grd_7.AddRow()
                    Me.grd_7.set_TextMatrix(Me.grd_7.Rows - 1, Me.grd_7.get_ColIndex("BranchCd"), Me.txtBranchCd.TextValue)
                End If
            End If

        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            'If Me.txtNewGubn.TextValue <> "" Then
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
                End If
            'End If
        End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            'If Me.txtNewGubn.TextValue <> "" Then
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
            End If
            'End If
        End Sub

        ''' <summary>
        ''' 함수명 : PNB101_Enter 
        ''' 기  능 : 화면 전환(지국 조회)
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNB101_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
            Dim ShareParameters As String() = Split(GmainBusinessFunction.GetValue("화면 전환"), ";")
            If ShareParameters(0) = Me.Name Then
                SetRequest(ShareParameters(1), ShareParameters(2))
                GmainBusinessFunction.SetValue("화면 전환", vbNullString)
            End If
        End Sub

        ''' <summary>
        ''' 함수명 : Request
        ''' 기  능 : 다른 화면에서 코드 를 받아서 해당 내역을 조회 한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2008-08-10
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        Public Sub SetRequest(ByVal strBranchCd As String, ByVal strBranchNm As String)
            '다른 화면에서 전표 번호를 받아서 해당 전표를 조회 한다.
            Me.txtBranchCd.TextValue = strBranchCd      '지국코드
            Me.txtBranchNm_2.TextValue = strBranchNm      '지국명

            GrecordProcessMode = "2"   ' 조회 모드로 변경
            Me.GmainCommonFunction.GRequestDataNumber = 1
            CallByName(Me, "RequestData", CallType.Method)
        End Sub

   
    End Class

End Namespace
