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

    Public Class PND101
        Inherits CommonControls.UiControl
        '====================================================================================================
       

#Region "폼 초기화"

        Public Sub Initialize()
            '==============================================================
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            'gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            'gridAttributes = gridAttributes & "|Pkey;Pkey;0;;1;" & "io;n;y;4;"
            'gridAttributes = gridAttributes & "|조사 일자;RscDate;87;yyyy-MM-dd;4;" & "io;n;n;8;"
            'gridAttributes = gridAttributes & "|제목;RscTitle;128;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|투입처 코드;RscCompanyCd;100;;4;" & "io;n;n;4;확장처 명;CompanyHangulNm"
            'gridAttributes = gridAttributes & "|투입처 명;CompanyHangulNm;160;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|문화 부 수;munhwa;71;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|조선 부 수;Cho;71;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|중앙 부 수;Joong;71;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|동아 부 수;DongPnum;64;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|기타 부 수;EtcPnum;70;#,##0;7;" & "io;n;n;4;"
            'gridAttributes = gridAttributes & "|담당 지국 코드;RscBranchNum;8;;4;" & "io;n;n;9;지국코드;BranchNm"
            'gridAttributes = gridAttributes & "|지국 명;BranchNm;101;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|투입처 주소;RscCompanyAddr;221;;1;" & "io;n;n;9;"
            'gridAttributes = gridAttributes & "|적요;Remark;200;;1;" & "io;n;n;4000;"
            gridAttributes = gridAttributes & "||선택;선택;40;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|Pkey;Pkey;0;;1;" & "io;n;y;4;"
            gridAttributes = gridAttributes & "|조사 일자;RscDate;87;yyyy-MM-dd;4;" & "io;n;n;8;"
            gridAttributes = gridAttributes & "|제목;RscTitle;119;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|투입처 코드;RscCompanyCd;15;;4;" & "io;n;n;4;확장처 명;CompanyHangulNm"
            gridAttributes = gridAttributes & "|투입처 명;CompanyHangulNm;107;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|문화;munhwa;39;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|조선;Cho;37;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|중앙;Joong;42;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|동아;DongPnum;35;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|기타;EtcPnum;40;#,##0;7;" & "io;n;n;4;"
            gridAttributes = gridAttributes & "|담당 지국 코드;RscBranchNum;10;;4;" & "io;n;n;9;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국 명;BranchNm;62;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|투입처 주소;RscCompanyAddr;221;;1;" & "io;n;n;9;"
            gridAttributes = gridAttributes & "|적요;Remark;200;;1;" & "io;n;n;4000;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
        End Sub

#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : PND101_Load 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PND101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

       
      
     
    End Class

End Namespace
