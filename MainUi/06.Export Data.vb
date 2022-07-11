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

Imports System.Reflection
Imports C1.C1PrintDocument

Namespace ubiLease.UI.MainUi
    Partial Class frmMainUi

        Private MprintUi As Object = Nothing
        Private MbetweenTextSpace As Integer = 0
        Private MpageWidth As Integer = 0
        Private MtitleStyleText As C1DocStyle = Nothing
        Private MregularStyleText As C1DocStyle = Nothing

        Private MgridTemp As GridControl.grd = Nothing
        Private MoriginalGridFontSize As Integer = 0

        '====================================================================================================
        Private Sub mnuExportDataToPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles _
            mnuExportDataToPreview.Click _
            , btnExportDataToPreview.Click _
            , mnuExportDataToPrinter.Click _
            , btnExportDataToPrinter.Click


            GmainCommonFunction.GdataProcessing = True

            If LCase(Strings.Right(sender.Name, 5)) = "excel" Then
                GmainCommonFunction.ExportDataToExcel(Me)
                GmainCommonFunction.GdataProcessing = False
                Exit Sub
            End If



            Try

                If LCase(Strings.Right(sender.Name, 7)) = "printer" Then

                    GmainCommonFunction.GisGridDataExport = True

                    CallByName(Me.pnlRight.Controls(GmainCommonFunction.GactiveUiControlName), "ExportData", CallType.Method)

                    If GmainCommonFunction.GisGridDataExport = False Then
                        ' 크리스탈레포트 호출명이 없으면 빠져 나간다.
                        If GmainCommonFunction.GreportFileName = "" Then
                            Exit Sub
                        Else
                            ' 크리스탈 레포트 실행
                            ViewReport( _
                            "XmlReport" _
                            , GmainCommonFunction.GreportFileName _
                            , GmainCommonFunction.GreportSpName _
                            , GmainCommonFunction.GreportSelectFormulaString _
                            , GmainCommonFunction.GreportSqlParams _
                            , GmainCommonFunction.GreportFormulaParams _
                            , True _
                            )
                            Exit Sub
                        End If
                    End If

                    Exit Sub
                End If



                '===========================================================================================================
                GmainCommonFunction.GisGridDataExport = True

                ' 미리보기에서 그리드/크리스탈 레포트 미리보기 구분 지원 이벤트 발생시 현재 페이지의 "ExportData" 함수 실행

                CallByName(Me.pnlRight.Controls(GmainCommonFunction.GactiveUiControlName), "ExportData", CallType.Method)

                '===========================================================================================================
                If GmainCommonFunction.GisGridDataExport = False Then
                    ' 크리스탈레포트 호출명이 없으면 빠져 나간다.
                    If GmainCommonFunction.GreportFileName = "" Then
                        Exit Sub
                    Else
                        ' 크리스탈 레포트 실행
                        ViewReport( _
                        "XmlReport" _
                        , GmainCommonFunction.GreportFileName _
                        , GmainCommonFunction.GreportSpName _
                        , GmainCommonFunction.GreportSelectFormulaString _
                        , GmainCommonFunction.GreportSqlParams _
                        , GmainCommonFunction.GreportFormulaParams _
                        )
                        Exit Sub
                    End If
                End If
                '===========================================================================================================


                If GmainCommonFunction.GprintTitleName = "" Then
                    GmainCommonFunction.GprintTitleName = Trim(Split(Me.Text, "-")(1))
                    GmainCommonFunction.GprintTitleName = Replace(GmainCommonFunction.GprintTitleName, "등록", "조회")
                End If

                If GmainCommonFunction.GprintGridName = "" Then
                    GmainCommonFunction.GprintGridName = "grd_1"
                End If
            Catch ex As Exception
                Gexception.getException(ex)
                GmainCommonFunction.GprintTitleName = Trim(Split(Me.Text, "-")(1))
                GmainCommonFunction.GprintTitleName = Replace(GmainCommonFunction.GprintTitleName, "등록", "조회")

                GmainCommonFunction.GprintGridName = "grd_1"
                GmainCommonFunction.GisLandscape = True
                GmainCommonFunction.GfontSize = 10
            End Try

            MprintUi = Me.pnlRight.Controls(Me.GmainCommonFunction.GactiveUiControlName)

            If LCase(Strings.Right(sender.Name, 7)) = "Preview" Then


                ExportGridDataToPreview()

            End If

            GmainCommonFunction.GdataProcessing = False

            MtitleStyleText = Nothing
            MregularStyleText = Nothing
            MgridTemp = Nothing
            MprintUi = Nothing

        End Sub

    End Class
End Namespace
