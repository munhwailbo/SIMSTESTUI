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

        '====================================================================================================
        Public Sub ExportGridDataToPreview()
            If GmainCommonFunction.GisLandscape = True Then
                MbetweenTextSpace = 55
                MpageWidth = 280
            Else
                MbetweenTextSpace = 30
                MpageWidth = 190
            End If

            Dim tempPrintDocument As New C1PrintDocument()

            MtitleStyleText = New C1DocStyle(tempPrintDocument)
            MtitleStyleText.Font = New Font("돋움체", 20, FontStyle.Regular)
            MtitleStyleText.TextAlignHorz = AlignHorzEnum.Center
            MtitleStyleText.TextAlignVert = AlignVertEnum.Top
            MtitleStyleText.TextColor = Color.Black

            MregularStyleText = New C1DocStyle(tempPrintDocument)
            MregularStyleText.Font = New Font("돋움체", GmainCommonFunction.GfontSize, FontStyle.Regular)
            MregularStyleText.TextAlignHorz = AlignHorzEnum.Left
            MregularStyleText.TextAlignVert = AlignVertEnum.Top
            MregularStyleText.TextColor = Color.Black

            AddHandler tempPrintDocument.NewPageStarted, AddressOf tempPrintDocument_NewPageStarted
            MakeDocumentToPrintPreview(tempPrintDocument, Nothing)

            Dim tempGridPrintPreview As New frmGridPrintPreview()
            tempGridPrintPreview.c1PrintPreviewMain.Document = tempPrintDocument

            AddHandler tempPrintDocument.GenerateDocument, New GenerateEventHandler(AddressOf MakeDocumentToPrintPreview)
            tempGridPrintPreview.WindowState = FormWindowState.Maximized
            tempGridPrintPreview.ShowDialog()

            RemoveHandler tempPrintDocument.GenerateDocument, New GenerateEventHandler(AddressOf MakeDocumentToPrintPreview)
            tempGridPrintPreview.Dispose()

            MgridTemp.FontSize = MoriginalGridFontSize
            MgridTemp.RowHeightMax = MoriginalGridFontSize * 2
        End Sub

        '====================================================================================================
        Private Sub MakeDocumentToPrintPreview( _
            ByVal AprintDocument As C1PrintDocument _
            , ByVal e As GenerateEventArgs _
        )
            AprintDocument.DefaultUnit = C1.C1PrintDocument.UnitTypeEnum.Mm
            AprintDocument.PageSettings.Landscape = GmainCommonFunction.GisLandscape

            AprintDocument.PageSettings.Margins.Left = 25
            AprintDocument.PageSettings.Margins.Right = 25
            AprintDocument.PageSettings.Margins.Top = 45
            AprintDocument.PageSettings.Margins.Bottom = 35

            AprintDocument.PageHeader.Height = 0
            AprintDocument.PageFooter.Height = 7

            'PageFooter
            AprintDocument.PageFooter.RenderText.Style.Font = New Font("돋움체", GmainCommonFunction.GfontSize, FontStyle.Regular)
            AprintDocument.PageFooter.RenderText.Style.TextAlignHorz = AlignHorzEnum.Center
            AprintDocument.PageFooter.RenderText.Style.TextAlignVert = AlignVertEnum.Bottom

            Dim pageFooterText As String = ""
            pageFooterText = pageFooterText & "작성자: " & GmainBusinessFunction.GetValue("로그인 명")
            pageFooterText = pageFooterText & Space(MbetweenTextSpace)
            pageFooterText = pageFooterText & "작성일시: " & GmainBusinessFunction.GetValue("현재 일시")
            pageFooterText = pageFooterText & Space(MbetweenTextSpace)
            pageFooterText = pageFooterText & "[@@PageNo@@]/[@@PageCount@@]"
            AprintDocument.PageFooter.RenderText.Text = pageFooterText

            AprintDocument.StartDoc()

            'grid
            Dim tempDataGridPrintInfo As New ControlPrinters.DataGridPrintInfo()
            tempDataGridPrintInfo.PageBreak = ControlPrinters.DataGridPrintInfo.PageBreaksEnum.FitIntoArea
            tempDataGridPrintInfo.VarRowHeight = ControlPrinters.DataGridPrintInfo.RowHeightEnum.LikeGrid
            tempDataGridPrintInfo.RepeatColumnHeaders = True

            MgridTemp = Me.pnlRight.Controls(Me.GmainCommonFunction.GactiveUiControlName).Controls(GmainCommonFunction.GprintGridName)

            Try
                MoriginalGridFontSize = MgridTemp.FontSize
            Catch ex As Exception
                Gexception.getException(ex)
                MoriginalGridFontSize = 10
            End Try

            MgridTemp.FontSize = GmainCommonFunction.GfontSize
            MgridTemp.RowHeightMax = GmainCommonFunction.GfontSize * 2

            AprintDocument.RenderBlockC1Printable(MgridTemp, AprintDocument.BodyAreaSize.Width, 1, tempDataGridPrintInfo, Nothing)

            AprintDocument.EndDoc()
        End Sub

        '====================================================================================================
        Private Sub tempPrintDocument_NewPageStarted(ByVal sender As C1PrintDocument, ByVal e As NewPageStartedEventArgs)
            '제목
            sender.RenderBlockText(GmainCommonFunction.GprintTitleName, MpageWidth, 14, MtitleStyleText)

            '조건
            Dim criteriaText As String = GetCriteriaText()

            If criteriaText <> "" Then
                sender.RenderBlockText(criteriaText, MpageWidth, 7, MregularStyleText)
            End If
        End Sub

        '====================================================================================================
        Private Function GetCriteriaText() As String
            GetCriteriaText = ""

            Dim eachControl As Object
            Dim controlTag As String = ""
            Dim getedType As Type = Nothing
            Dim getChildAtPointControl As Object = Nothing

            Dim sortKeyArray As Object = Nothing
            Dim criteriaArray As Object = Nothing
            Dim topArray As Object = Nothing

            For Each eachControl In MprintUi.Controls
                getedType = eachControl.GetType

                If _
                    getedType.Name = "txt" _
                    Or getedType.Name = "num" _
                    Or getedType.Name = "cbo" _
                    Or getedType.Name = "pop" _
                    Or getedType.Name = "dtp" _
                    Or getedType.Name = "opt" _
                    Or getedType.Name = "chk" _
                    Then
                    getChildAtPointControl = MprintUi.GetChildAtPoint(New Point(eachControl.Left, eachControl.Top - 1))

                    If IsNothing(getChildAtPointControl) = False Then
                        If _
                            Strings.Left(LCase(getChildAtPointControl.Name), 11) = "piccriteria" _
                            And eachControl.Visible = True _
                            Then
                            If IsNothing(criteriaArray) = True Then
                                ReDim sortKeyArray(0)
                                ReDim criteriaArray(0)
                            Else
                                ReDim Preserve sortKeyArray(sortKeyArray.Length)
                                ReDim Preserve criteriaArray(criteriaArray.Length)
                            End If

                            Dim currentTop As Integer = 0

                            If IsNothing(topArray) = True Then
                                ReDim topArray(0)
                                topArray(0) = eachControl.Top
                                currentTop = eachControl.Top
                            End If

                            For arrayNumber As Integer = 0 To topArray.length - 1 Step 1
                                If _
                                    eachControl.Top <= topArray(arrayNumber) + 8 _
                                    And eachControl.Top >= topArray(arrayNumber) - 8 _
                                    Then
                                    currentTop = topArray(arrayNumber)
                                    Exit For
                                ElseIf arrayNumber = topArray.length - 1 Then
                                    ReDim Preserve topArray(topArray.Length)
                                    topArray(topArray.Length - 1) = eachControl.Top
                                    currentTop = eachControl.Top
                                End If
                            Next arrayNumber

                            sortKeyArray(sortKeyArray.Length - 1) = Strings.Right("00000" & currentTop, 5) & Strings.Right("00000" & eachControl.Left, 5)

                            Dim tempCriteriaText As String = eachControl.CaptionName & ": "
                            Dim tempTextValue As String = ""

                            If getedType.Name = "cbo" Then
                                tempTextValue = eachControl.Text
                            ElseIf getedType.Name = "pop" Then
                                If Trim(eachControl.TextValue) <> "" Then
                                    tempTextValue = eachControl.TextValue & "." & eachControl.NameText
                                End If
                            ElseIf getedType.Name = "chk" Then
                                If eachControl.tempTextValue = "0" Then
                                    eachControl.tempTextValue = "No"
                                Else
                                    eachControl.tempTextValue = "Yes"
                                End If
                            ElseIf getedType.Name = "dtp" Then
                                tempTextValue = eachControl.Text
                            Else
                                tempTextValue = eachControl.TextValue
                            End If

                            If tempTextValue = "" Then
                                tempTextValue = "전체"
                            End If

                            tempCriteriaText += tempTextValue
                            criteriaArray(criteriaArray.Length - 1) = tempCriteriaText
                        End If
                    End If
                End If
            Next

            If IsNothing(sortKeyArray) = False Then
                Array.Sort(sortKeyArray, criteriaArray)

                For arrayNumber As Integer = 0 To criteriaArray.Length - 1 Step 1
                    If arrayNumber >= 1 Then
                        GetCriteriaText = GetCriteriaText & Space(4)
                    End If

                    GetCriteriaText = GetCriteriaText & criteriaArray(arrayNumber)
                Next arrayNumber
            End If

            GetCriteriaText = GetCriteriaText

            sortKeyArray = Nothing
            criteriaArray = Nothing
            topArray = Nothing

            getChildAtPointControl = Nothing
            eachControl = Nothing
            getedType = Nothing
        End Function

    End Class
End Namespace
