' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명   : 사원확장비 청구 생성 처리
' form설명 : 사원확장비(본사) 청구생성처리 한다
' 작성자   : 김성훈
' 작성일   : 2008-09-22
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI201
        Inherits CommonControls.UiControl
        '====================================================================================================


#Region "폼 초기화"

        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|청구년월;CollectYYYYMM;60;;c;" & "o;y;n;5;"

            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;60;;l;" & "o;y;n;5;"
            gridAttributes = gridAttributes & "|확장명;ExpandNm;70;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "o;n;n;40;확장처 명;CompanyNm;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"
        
            gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;70;;c;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구주기코드;BillPeriodCd;60;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|회차;DemandOrders;70;;c;" & "o;n;y;50;"
            gridAttributes = gridAttributes & "|총청구대상금액;TotBillAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구누계금액;TotDemandAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|구독료단가;SubscriptionAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|부수;FixedPaperNum;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|청구금액;BillAmt;60;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|미청구잔액;RemainAmt;60;#,###;r;" & "o;n;n;5;"

            'gridAttributes = gridAttributes & "|수금형태코드;CollectionDivCd;60;;c;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|청구방법코드;BillDivCd;70;;c;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|수금액;CollectionAmt;70;#,##0;c;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|적요;Remark;70;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|적용시작 년월;SYYYYMM;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|적용만료 년월;EYYYYMM;70;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|입금 일자;ReceiveDt;70;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|수금 여부;CollectionYN;70;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|;Dummy;70;;c;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "CollectionDivCd;수금형태코드"
            gridCodeNameList = gridCodeNameList & "/BillDivCd;청구방법코드"    ''2321
            gridCodeNameList = gridCodeNameList & "/BillPeriodCd;수금주기코드"   ''2111
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

        End Sub
#End Region

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
        Private Sub PNI201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If

        End Sub
#End Region

        Private Sub btnCreateSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSale.Click
            '''''''RequestData2()
            SaveData()
        End Sub

    End Class

End Namespace
