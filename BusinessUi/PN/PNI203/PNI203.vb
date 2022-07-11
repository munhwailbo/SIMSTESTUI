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

    Public Class PNI203
        Inherits CommonControls.UiControl

#Region "폼 초기화"


        Public Sub Initialize()

            Me.NewData()

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
        Private Sub PNI203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


        Private Sub btnClosing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosing.Click
            'Dim message As String = Me.dtpClosingYearMonths.TextValue.Substring(0, 4) & "년 " & Me.dtpClosingYearMonths.TextValue.Substring(4, 2) & "월"

            If Me.dtpNextClosingYearMonths.TextValue Is Nothing Then
                MessageBox.Show("최종 마감 정보를 조회 후 처리 하세요", "정산 마감 처리경고")
                Exit Sub
            Else
                Me.SaveData()
                'MessageBox.Show("정산 마감 처리 됐습니다")
                Me.RequestData()
            End If

        End Sub

        Private Sub btnClosingCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosingCancel.Click

            'Dim message As String = Me.dtpClosingYearMonths.TextValue.Substring(0, 4) & "년 " & Me.dtpClosingYearMonths.TextValue.Substring(4, 2) & "월"

            If Me.dtpNextClosingYearMonths.TextValue Is Nothing Then
                MessageBox.Show("최종 마감 정보를 조회 후 처리 하세요", "정산 마감 처리경고")
                Exit Sub
            Else
                Me.DeleteData()
                MessageBox.Show("정산 마감취소 처리 됐습니다")
                Me.RequestData()
            End If

        End Sub

    End Class

End Namespace
