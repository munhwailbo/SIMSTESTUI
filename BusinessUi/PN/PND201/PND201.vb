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

    Public Class PND201
        Inherits CommonControls.UiControl
        '====================================================================================================
        

#Region "폼 초기화"

        Public Sub Initialize()
            '  grid_1 를 초기화 한다.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|Pkey;PKey;10;;c;" & "o;n;y;4;"       '(10)
            gridAttributes = gridAttributes & "|회차;MtOrders;100;;c;" & "o;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|개요;MtDesc;400;;l;" & "o;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|회의 일자;MtDate;100;;l;" & "o;n;n;8;"       '(30)
            gridAttributes = gridAttributes & "| ;Remark;150;;l;" & "o;n;n;50;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")


        End Sub
#End Region

#Region "폼 이벤트"
        ''' <summary>
        ''' 함수명 : 
        ''' 기  능 : Form Dock 설정
        ''' 작성자 : 
        ''' 작성일 : 
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PND201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

        
        
     
        Private Sub picIo_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picIo_2.Click

        End Sub
    End Class

End Namespace
