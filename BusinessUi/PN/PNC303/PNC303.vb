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

    Public Class PNC303
        Inherits CommonControls.UiControl
        '====================================================================================================
        Private Sub PNC303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "k;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|접수일자;ReceiptDt;80;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|독자코드;ReaderCd;50;;;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|독자명;ReaderNm;80;;;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|순번;Orders;40;;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|민원구분코드;DivCd;100;;l;" & "o;n;n;10;"           
            gridAttributes = gridAttributes & "|독자명비고;ReaderNmNote;200;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|전화번호비고;PhoneNumNote;200;;l;" & "o;n;n;30;"          
            gridAttributes = gridAttributes & "|주소비고;AddrNote;200;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|지국명비고;BranchNmNote;200;;l;" & "o;n;n;30;"           
            gridAttributes = gridAttributes & "|부명;DeptNm;200;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|내용;Content;200;;l;" & "o;n;n;1000;"
            gridAttributes = gridAttributes & "|지국통보코드;ResultInformCd;100;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|처리결과;ResultNote;200;;l;" & "o;n;n;1000;"
            gridAttributes = gridAttributes & "|모니터처리일자;MonitoringProcDt;100;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|진행상태코드;IngStateCd;100;;l;" & "o;n;n;10;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
        End Sub

    End Class

End Namespace
