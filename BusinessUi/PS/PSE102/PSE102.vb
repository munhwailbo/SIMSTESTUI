'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSE102] 지국 확장비 비용 발생 전표
' form 설명 :  [PSE102] 지국 확장비 비용 발생 전표
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:08:26
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
 
Imports C1.Win.C1FlexGrid 
Imports C1.Win.C1FlexGrid.Classic  
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic  
 
Namespace ubiLease.UI.BusinessUi.PS 
 
    Public Class PSE102 
        Inherits CommonControls.UiControl  
 
        Private Sub PSE102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
             If Me.DesignMode = False Then                          
                 Me.Dock = DockStyle.Fill                           
        '' ''         Me.MinimumSize = New System.Drawing.Size(800, 640) 
                 Me.MinimumSize = New System.Drawing.Size(700, 500) 
             End If 
         End Sub    
 
        '==================================================================================================== 
        Public Sub Initialize()  

            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;37;;1;" & "i;n;n;;;"
            'gridAttributes = gridAttributes & "|구분;TreePath;70;;1;" & "io;n;n;5;    
            gridAttributes = gridAttributes & "|공제년월;DeduYYMM;63;yyyy-MM;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|공제순번;DeduSeq;63;;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|공제구분;DeduType;63;;4;" & "io;n;y;8;"
            gridAttributes = gridAttributes & "|확장년월;CalYearMonths;63;yyyy-MM;4;" & "io;y;n;8;"
            gridAttributes = gridAttributes & "|주차;WeekNumber;37;;4;" & "io;y;n;4;"
            gridAttributes = gridAttributes & "|담당코드;ChargeEmpNum;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|담당명;EmployeeNameHangul;50;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당확인여부;RegYesOrNo;83;;1;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|관리승인여부;ApplyYesOrNo;0;;1;" & "o;n;y;8;"
            gridAttributes = gridAttributes & "|지국코드;BranchNum;69;;4;" & "io;n;n;12;"
            gridAttributes = gridAttributes & "|지국명;BranchNm;58;;1;" & "o;n;n;12;"
            gridAttributes = gridAttributes & "|지역구분코드;BranchRegionCd;0;;4;" & "o;n;y;10;지국지역코드;"
            gridAttributes = gridAttributes & "|지역구분명;BranchRegionNm;0;;4;" & "o;n;y;10;"
            gridAttributes = gridAttributes & "|확장부수;ExpandPapNum;62;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|확장비;ExpandAmount;70;#,##0;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|비용전표번호;AccSlipNum;90;;l;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "| ;col_adjust;1;;c;" & "o;n;n;;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

            'Me.popEmployeeNumber.TextValue = GmainBusinessFunction.GetValue("로그인 ID")
            'Me.popEmployeeNumber.Enabled = GmainBusinessFunction.GetValue("로그인 ID") = "999999"

            '담당자 셋팅
            popEmployeeNumber.Enabled = True
         
        End Sub 
 
    End Class
End Namespace                                                                                                                                            