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

    Public Class PND202
        Inherits CommonControls.UiControl
        '===================================================================================================


#Region "폼 초기화"

        Public Sub Initialize()
            ' '' ''==============================================================
            ' '' ''  grid_1 를 초기화 한다.
            ' '' ''--------------------------------------------------------------
            '' ''Dim gridAttributes As String = ""
            ' '' ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            '' ''gridAttributes = gridAttributes & "a;r;y"

            ' '' ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ' '' ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            '' ''gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            '' ''gridAttributes = gridAttributes & "|Pkey;Pkey;4;;;" & "io;n;y;4;"       '(10)
            '' ''gridAttributes = gridAttributes & "|조사 일자;RscDate;8;;;" & "io;n;n;8;"       '(20)
            '' ''gridAttributes = gridAttributes & "|투입처 코드;RscCompanyCd;4;;;" & "io;n;n;4;확장처 명;CompanyHangulNm "       '(30)
            '' ''gridAttributes = gridAttributes & "|투입처 명;CompanyHangulNm ;9;;;" & "io;n;n;9;"
            '' ''gridAttributes = gridAttributes & "|투입처 주소;RscCompanyAddr ;9;;;" & "io;n;n;9;"
            '' ''gridAttributes = gridAttributes & "|담당 지국 코드;RscBranchNum;9;;;" & "io;n;n;9;지국코드;BranchNm"       '(40)
            '' ''gridAttributes = gridAttributes & "|지국 명;BranchNm;9;;;" & "io;n;n;9;"
            '' ''gridAttributes = gridAttributes & "|조선 부 수;Cho;4;#,##0;r;" & "io;n;n;4;"       '(50)
            '' ''gridAttributes = gridAttributes & "|중앙 부 수;Joong;4;#,##0;r;" & "io;n;n;4;"       '(60)
            '' ''gridAttributes = gridAttributes & "|동아 부 수;DongPnum;4;#,##0;r;" & "io;n;n;4;"       '(70)
            '' ''gridAttributes = gridAttributes & "|기타 부 수;EtcPnum;4;#,##0;r;" & "io;n;n;4;"       '(80)
            '' ''gridAttributes = gridAttributes & "|적요;Remark;4000;;l;" & "io;n;n;4000;"       '(90)
            ' '' ''grid_1 code combo    
            '' ''Dim gridCodeNameList As String = ""
            '' ''grd_1.Initialize(gridAttributes, gridCodeNameList)
            '' '' ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            RequestData()
        End Sub

#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PND202_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>



        Private Sub PND202_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

       
      
     
    End Class

End Namespace
