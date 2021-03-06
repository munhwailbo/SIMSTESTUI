'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : UI 명세서
' form 설명 : UI 명세서를 조회, 추가, 수정, 삭제한다.			
' 작성자 : 황인중
' 작성일 : 2006-07-04
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMF003
        Inherits CommonControls.UiControl
        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "o;n;y;"
            gridAttributes = gridAttributes & "|접수 일자;ReceiptDate;300;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;300;;r;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|조직 명;OnesPositionDepartmentCodeName;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|작업자;Worker;400;;c;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|;Dummy;400;;c;" & "o;n;n;200;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;시스템 구분 명"
            gridCodeNameList = gridCodeNameList & "/Worker;개발자 코드"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1


            Me.DateInit()

        End Sub

        '====================================================================================================
        Public Sub DateInit()
            '기본 날짜 셋팅
            '일주일 텀(필요에 따라 조정하기 바람)
            Me.dtpReceiptDateFrom.TextValue = Date.Today.AddDays(-6)
            Me.dtpReceiptDateTo.TextValue = Date.Today
        End Sub

        Private Sub SMF003_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub

    End Class

End Namespace
