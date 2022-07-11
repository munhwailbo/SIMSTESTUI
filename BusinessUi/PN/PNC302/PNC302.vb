' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : 
' form설명 :
' 작성자 : 
' 작성일 : 
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

    Public Class PNC302
        Inherits CommonControls.UiControl
        '====================================================================================================
        Private Sub PNC302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
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
            gridAttributes = gridAttributes & "|순번;Orders;40;;;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;40;;;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|독자명;ReaderNm;40;;;" & "o;n;n;10;"       '(20)           
            gridAttributes = gridAttributes & "|민원구분코드;DivCd;40;;;" & "o;n;n;10;"       '(40)          
            gridAttributes = gridAttributes & "|민원접수일;ReceiptDt;40;;;" & "o;n;n;50;"       '(60)
            gridAttributes = gridAttributes & "|독자구분코드;ReaderDivCd;40;;;" & "io;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|독자상태코드;ReaderStateCd;40;;;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|확장구분코드;ExpandDivCd;40;;;" & "io;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|투입일자;FixedStDt;40;;;" & "io;n;n;8;"       '(50)
            gridAttributes = gridAttributes & "|투입부수;SubscribePagerNum;40;;;" & "io;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|전화번호1;PhoneNum1;40;;;" & "io;n;n;30;"       '(80)
            gridAttributes = gridAttributes & "|신우편번호;NewPostNum;40;;;" & "io;n;n;10;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;CodeHangulName;90;;c;" & "o;n;y;5;"       '(90)
            gridAttributes = gridAttributes & "|신주소;NewAddr1;50;;;" & "io;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|구우편번호;OldPostNum;40;;;" & "io;n;n;10;우편번호;CodeHangulName"
            gridAttributes = gridAttributes & "|주소;CodeHangulName;90;;c;" & "o;n;y;5;"       '(110)
            gridAttributes = gridAttributes & "|구주소;OldAddr1;50;;;" & "io;n;n;50;"       '(120)
            gridAttributes = gridAttributes & "|구독코드;SubscribeCd;50;;;" & "io;n;n;50;"       '(120)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DivCd;민원구분코드"
            gridCodeNameList = gridCodeNameList & "/ReaderDivCd;독자구분코드"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;독자상태코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")


         

        End Sub



      
    End Class

End Namespace
