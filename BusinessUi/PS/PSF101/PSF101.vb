'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form 명 :  [PSF101] 배달비 대체 전표
' form 설명 :  [PSF101] 배달비 대체 전표
' 작성자 : 
' 작성일 : 2013-11-28 오후 5:32:07
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
 
    Public Class PSF101 
        Inherits CommonControls.UiControl  
 
        Private Sub PSF101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  
             If Me.DesignMode = False Then                          
                 Me.Dock = DockStyle.Fill                           
        '' ''         Me.MinimumSize = New System.Drawing.Size(800, 640) 
                 Me.MinimumSize = New System.Drawing.Size(700, 500) 
             End If 
         End Sub    
 
        '==================================================================================================== 
        Public Sub Initialize()  
 
            'grid를 초기화 한다. 
            '-------------------------------------------------- 
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input out'put); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code

            gridAttributes = gridAttributes & "||선택;선택;40;;1;" & "i;n;n;;;"
            gridAttributes = gridAttributes & "|입금일자;ColDt;85;yyyy-MM-dd;c;" & "io;n;n;5;"
            'gridAttributes = gridAttributes & "|순번;ColOrders;0;;7;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|입금구분코드;ColTypeCd;155;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|입금계좌번호;ColBankCd;170;;1;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|계좌번호;ColAccountNum;0;;4;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|입금자명;Recipient;66;;4;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|지대입금년월;CalYearMonths;87;yyyy-MM;4;" & "io;n;n;40;"
            'gridAttributes = gridAttributes & "|지국번호;BranchNum;76;;4;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;4;" & "o;n;y;40;"
            'gridAttributes = gridAttributes & "|지국명;BranchNm;50;;1;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;84;;4;" & "o;n;n;40;지국장코드;BranchChiefCdName "
            'gridAttributes = gridAttributes & "|지국장성명;BranchChiefCdName;74;;4;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|영업담당;ChargeEmpNum;62;;4;" & "o;n;n;10;사원번호;ChargeEmpNm"
            'gridAttributes = gridAttributes & "|영업담당명;ChargeEmpNm;74;;1;" & "o;n;n;10;"
            'gridAttributes = gridAttributes & "|입금담당명;ProcEmpNm;74;;1;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|입금담당사번;ProcEmpNum;87;;4;" & "o;n;n;40; "
            gridAttributes = gridAttributes & "|입금금액;ColAmt;62;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|대체전표번호;AccSlipNum;90;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|적요;Note;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|;Jiral;85;;1;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ColBankCd;입금계좌코드"
            gridCodeNameList = gridCodeNameList & "/ColTypeCd;입금구분코드"
            'gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            'lblRecordState.Text = "준비"
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3
 
        End Sub 
 
    End Class
End Namespace                                                                                                                                            