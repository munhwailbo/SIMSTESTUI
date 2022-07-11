Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports ubiLease.CommonControls

Namespace ubiLease.CommonPopup

    Public Class frmMonthView

        Private Gexception As DAT.CustomException = New DAT.CustomException

        Private userSelectedDate As Date

        Public GcurrentDtpicker As Object = Nothing

        Private Sub clnUserControl_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles clnUserControl.ControlAdded
            Debug.Print("달력컨트롤추가됨")

        End Sub

        Private Sub clnUserControl_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles clnUserControl.DateChanged
            userSelectedDate = e.Start
            ChangeDate = e.Start
        End Sub

        '====================================================================================================
        Private Sub clnUserControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles clnUserControl.GotFocus

            If TypeOf GcurrentDtpicker Is CommonControls.dtp Then
                ''달력 컨트롤 처리 시작 ==============================

                If IsNothing(GcurrentDtpicker.Value) = False Then


                    Dim isTagContainError As Boolean = False

                    If IsNothing(GcurrentDtpicker.tag) Then

                        isTagContainError = False

                    Else
                        If GcurrentDtpicker.tag.ToString().Contains("error;") > 0 Then

                            isTagContainError = True

                        End If

                    End If



                    If isTagContainError = True Or GcurrentDtpicker.Text.ToString().Trim() = "" Then
                        '에러가 있는 경우
                        ' 에러가 있으면 오늘 날짜를 뿌려서 셋팅한다.
                        userSelectedDate = DateAndTime.Now()
                        clnUserControl.SelectionStart = userSelectedDate

                    Else

                        '' 에러가 없는 경우


                        If IsDate(GcurrentDtpicker.text) Then
                            userSelectedDate = CDate(GcurrentDtpicker.text)
                        Else

                            Dim dateTimeFormat As String = CType(GcurrentDtpicker, ubiLease.CommonControls.dtp).DateTimeFormatText
                            If dateTimeFormat = "yyyy" Then
                                userSelectedDate = New Date(Convert.ToDecimal(GcurrentDtpicker.Text), 1, 1)
                            End If
                            If dateTimeFormat = "MM" Then
                                userSelectedDate = New Date(Now.Year, Convert.ToDecimal(GcurrentDtpicker.Text), 1)
                            End If
                            If dateTimeFormat = "dd" Then
                                userSelectedDate = New Date(Now.Year, Now.Month, Convert.ToDecimal(GcurrentDtpicker.Text))
                            End If


                        End If
                    End If

                    clnUserControl.SelectionStart = userSelectedDate


                Else

                End If

                ''달력 컨트롤 처리 끝 ==============================

            Else
                ''그리드 달력 처리 시작 ==============================
                If IsNothing(CType(GcurrentDtpicker, ubiLease.GridControl.grd).CursorCell.Data) Then

                    clnUserControl.SelectionStart = Now

                Else
                    If CType(GcurrentDtpicker, ubiLease.GridControl.grd).CursorCell.Data.ToString() = "" Then

                        clnUserControl.SelectionStart = Now

                    Else

                        Dim grdCellStr As String = CType(GcurrentDtpicker, ubiLease.GridControl.grd).CursorCell.Data.ToString()


                        Dim grdCellcolFormat As String = CType(GcurrentDtpicker, ubiLease.GridControl.grd).get_ColFormat(CType(GcurrentDtpicker, ubiLease.GridControl.grd).CursorCell.c1)




                        If CommonControls.CheckDate(grdCellStr, grdCellcolFormat.ToString(), GetFormatMaskText(grdCellcolFormat.ToString())) Then
                            Try


                                If IsDate(grdCellStr) Then

                                    userSelectedDate = CDate(grdCellStr)

                                Else


                                    If grdCellcolFormat = "yyyy" Then
                                        userSelectedDate = New Date(Convert.ToDecimal(grdCellStr), 1, 1)
                                    End If
                                    If grdCellcolFormat = "MM" Then
                                        userSelectedDate = New Date(Now.Year, Convert.ToDecimal(grdCellStr), 1)
                                    End If
                                    If grdCellcolFormat = "dd" Then
                                        userSelectedDate = New Date(Now.Year, Now.Month, Convert.ToDecimal(grdCellStr))
                                    End If


                                End If

                                clnUserControl.SelectionStart = userSelectedDate

                            Catch ex As Exception

                                Gexception.getException(ex)

                                clnUserControl.SelectionStart = Now

                            End Try

                        Else

                            If IsDate(grdCellStr) Then

                                userSelectedDate = CDate(grdCellStr)

                            Else


                                If grdCellcolFormat = "yyyy" Then
                                    userSelectedDate = New Date(Convert.ToDecimal(grdCellStr), 1, 1)
                                End If
                                If grdCellcolFormat = "MM" Then
                                    userSelectedDate = New Date(Now.Year, Convert.ToDecimal(grdCellStr), 1)
                                End If
                                If grdCellcolFormat = "dd" Then
                                    userSelectedDate = New Date(Now.Year, Now.Month, Convert.ToDecimal(grdCellStr))
                                End If


                            End If

                            clnUserControl.SelectionStart = Now

                        End If
                    End If

                End If
                ''그리드 달력 처리 끝 ==============================

            End If





        End Sub

        Private Sub frmMonthView_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
            Me.clnUserControl.Focus()
        End Sub

        '====================================================================================================
        Private Sub clnUserControl_KeyDown( _
            ByVal sender As System.Object, ByVal e As KeyEventArgs _
        ) Handles MyBase.KeyDown

            If _
                e.Shift = 0 _
                And e.KeyCode = Keys.Escape _
                Then
                Me.Hide()
            End If

            If e.KeyCode = Keys.Enter Then


                If TypeOf GcurrentDtpicker Is CommonControls.dtp Then
                    Dim tempText As String = Format(ChangeDate, GcurrentDtpicker.DateTimeFormatText)
                    GcurrentDtpicker.Text = tempText
                Else
                    Dim tempCommonFunction As New CommonFunction.Common
                    Dim tempText As String = Format(ChangeDate, tempCommonFunction.GetDateTimeFormat(GcurrentDtpicker.get_TextMatrix(0, GcurrentDtpicker.Col)))
                    GcurrentDtpicker.set_TextMatrix(GcurrentDtpicker.Row, GcurrentDtpicker.Col, tempText)
                    CType(GcurrentDtpicker, ubiLease.GridControl.grd).frmMonthViewShown = False
                End If

                Me.Hide()

            End If

            If e.KeyCode = Keys.F4 Then

                If TypeOf GcurrentDtpicker Is CommonControls.dtp Then

                Else
                    CType(GcurrentDtpicker, ubiLease.GridControl.grd).frmMonthViewShown = False
                End If

                Me.Hide()


            End If

        End Sub
        Private ChangeDate As Date = Now()
        '====================================================================================================
        Private Sub clnUserControl_DateSelected( _
            ByVal sender As System.Object, ByVal e As DateRangeEventArgs _
        ) Handles clnUserControl.DateSelected

            ChangeDate = e.Start

            If TypeOf GcurrentDtpicker Is CommonControls.dtp Then
                Dim tempText As String = Format(e.Start, GcurrentDtpicker.DateTimeFormatText)
                GcurrentDtpicker.Text = tempText

            Else
                Dim tempCommonFunction As New CommonFunction.Common
                Dim dateTimeFormatText As String = tempCommonFunction.GetDateTimeFormat(GcurrentDtpicker.get_TextMatrix(0, GcurrentDtpicker.Col))
                Dim tempText As String = Format(e.Start, dateTimeFormatText)
                Dim CurrentDate As String = GcurrentDtpicker.get_TextMatrix(GcurrentDtpicker.Row, GcurrentDtpicker.Col)
                If CurrentDate = tempText Then

                Else
                    Dim 선택컬럼 As Integer = 0
                    선택컬럼 = CType(GcurrentDtpicker, ubiLease.GridControl.grd).get_ColIndex("선택")
                    If 선택컬럼 > 0 Then
                        CType(GcurrentDtpicker, ubiLease.GridControl.grd).set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpChecked, GcurrentDtpicker.Row, 선택컬럼, C1.Win.C1FlexGrid.Classic.CellCheckedSettings.flexChecked)
                    End If
                End If
                GcurrentDtpicker.set_TextMatrix(GcurrentDtpicker.Row, GcurrentDtpicker.Col, tempText)

                CType(GcurrentDtpicker, ubiLease.GridControl.grd).frmMonthViewShown = False

                tempCommonFunction = Nothing
            End If

            userSelectedDate = Now
            Me.Hide()

        End Sub

        '====================================================================================================
        Private Sub frmMonthView_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate

            userSelectedDate = Now
            Me.Hide()

        End Sub



    End Class

End Namespace
