Imports System.Collections

Imports System
Imports Microsoft.VisualBasic
Namespace ubiLease.CommonPopup


    Public Enum ubiControlType
        txt = 1
        btn = 2
        dtp = 3
        num = 4
        cbo = 5
        chk = 6
        lbl = 7
    End Enum

    Public Class popupManager

        Private rowHeaderBottomMargin As Integer = 20
        Private rowMargin As Integer = 3
        Private ControlHight As Integer = 20
        Private columnLeftRightMargin As Integer = 20
        Private columnMargin As Integer = 3
        Private lableColumnWidth As Integer = 56
        Private ControlColumnWidth As Integer = 82

        Private ControlWidthCollaction As Generic.IDictionary(Of String, Integer) = New Generic.Dictionary(Of String, Integer)()

        Private LayoutCollaction As Generic.IDictionary(Of String, Object) = New Generic.Dictionary(Of String, Object)()

        Public Sub dynamicDesign(ByVal _frmcodename As frmCodeName, ByVal ControlNumber As Integer, ByVal RowNumber As Integer)
            'GetLayout(_frmcodename)

            ' 사이즈 조정
            _frmcodename.picMain.Size = GetControlSize(_frmcodename.picMain.Size, RowNumber)

            ' 그리드 위치 조정

            _frmcodename.grdMain.Size = GetGridSize(_frmcodename.grdMain.Size, RowNumber)
            _frmcodename.grdMain.Location = GetLocation(_frmcodename.grdMain.Location, RowNumber)


            ' 폼사이즈 조정
            _frmcodename.Size = GetControlSize(_frmcodename.Size, RowNumber)

        End Sub
        ''' <summary>
        ''' 함수명 : ControlAdd 
        ''' 기  능 : 추가 컨트롤 Type을 정의한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2007-10-12
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="_frmcodename"></param>
        ''' <param name="ubictrl"></param>
        ''' <param name="controlName"></param>
        ''' <param name="controlText"></param>
        ''' <param name="controlWidth"></param>
        ''' <param name="columnNumber"></param>
        ''' <param name="rowNumber"></param>
        ''' <param name="controlTag"></param>
        ''' <remarks></remarks>
        Public Sub ControlAdd(ByVal _frmcodename As frmCodeName, _
                              ByVal ubictrl As ubiControlType, _
                              ByVal controlName As String, _
                              ByVal controlText As String, _
                              ByVal controlWidth As Integer, _
                              ByVal columnNumber As Integer, _
                              ByVal rowNumber As Integer, _
                              ByVal controlTag As String)
            Select Case ubictrl

                Case ubiControlType.lbl '라벨
                    Dim tmpControl As System.Windows.Forms.Label = New System.Windows.Forms.Label

                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.TextAlign = Drawing.ContentAlignment.MiddleRight
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()

                Case ubiControlType.txt '텍스트

                    Dim tmpControl As CommonControls.txt = New CommonControls.txt
                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()

                Case ubiControlType.cbo '콤보박스

                    Dim tmpControl As CommonControls.cbo = New CommonControls.cbo
                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.CaptionName = "거래처 분류"
                    tmpControl.ListCount = 0
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()
                    'tmpControl.Focus()

                Case ubiControlType.dtp  '날짜

                    Dim tmpControl As CommonControls.dtp = New CommonControls.dtp
                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()

                Case ubiControlType.num  '숫자

                    Dim tmpControl As CommonControls.num = New CommonControls.num
                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()

                Case ubiControlType.chk   '체크박스

                    Dim tmpControl As CommonControls.chk = New CommonControls.chk
                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()

                Case ubiControlType.btn   '체크박스

                    Dim tmpControl As CommonControls.btn = New CommonControls.btn
                    SetControlValue(tmpControl, controlName, controlText, controlWidth, controlTag)
                    tmpControl.Location = GetControlLocation(columnNumber, rowNumber)
                    tmpControl.Tag = controlTag
                    _frmcodename.pnlMain.Controls.Add(tmpControl)
                    tmpControl.BringToFront()

                Case Else

            End Select

        End Sub

        

        ''' <summary>
        ''' 함수명 : SetControlValue 
        ''' 기  능 : 추가 컨트롤의 속성을 초기화한다.
        ''' 작성자 : 강동훈
        ''' 작성일 : 2007-10-12
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="tmpControl"></param>
        ''' <param name="controlName"></param>
        ''' <param name="controlText"></param>
        ''' <param name="controlWidth"></param>
        ''' <param name="controlTag"></param>
        ''' <remarks></remarks>
        Private Sub SetControlValue(ByVal tmpControl As System.Windows.Forms.Control, _
                                    ByVal controlName As String, _
                                    ByVal controlText As String, _
                                    ByVal controlWidth As Integer, _
                                    ByVal controlTag As String)

            Dim tmpSize As System.Drawing.Size

            tmpSize.Height = ControlHight
            tmpSize.Width = controlWidth
            tmpControl.Size = tmpSize
            tmpControl.Name = controlName
            tmpControl.Text = controlText
            'tmpControl.Tag = controlTag

        End Sub

        ''' <summary>
        ''' 상단 조건절의 컨트롤 위치를 가져온다.
        ''' </summary>
        ''' <param name="columnNumber"></param>
        ''' <param name="rowNumber"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetControlLocation(ByVal columnNumber As Integer, ByVal rowNumber As Integer) As System.Drawing.Point
            Dim L As System.Drawing.Point

            Dim rowLocation As Integer = rowHeaderBottomMargin
            Dim colLocation As Integer = columnLeftRightMargin

            For i As Integer = 1 To rowNumber
                rowLocation = rowLocation + ControlHight + rowMargin
            Next

            L.Y = rowLocation

            For i As Integer = 0 To columnNumber
                Select Case columnNumber

                    Case 0
                        colLocation = CType(LayoutCollaction("lblCode_Location"), System.Drawing.Point).X '0
                    Case 1
                        colLocation = CType(LayoutCollaction("txtCode_Location"), System.Drawing.Point).X '1
                    Case 2
                        colLocation = CType(LayoutCollaction("lblName_Location"), System.Drawing.Point).X '2 
                    Case 3
                        colLocation = CType(LayoutCollaction("txtName_Location"), System.Drawing.Point).X '3
                    Case Else

                End Select
            Next

            L.X = colLocation

            Return L
        End Function

        

        ''' <summary>
        ''' 컨트롤의 사이즈를 조정한다.
        ''' </summary>
        ''' <param name="controlSize"></param>
        ''' <param name="rowCount"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetGridSize(ByVal controlSize As System.Drawing.Size, ByVal rowCount As Integer) As System.Drawing.Size
            Dim s As System.Drawing.Size
            s = controlSize

            For i As Integer = 1 To rowCount
                s.Height = s.Height - ControlHight - rowMargin
            Next

            Return s
        End Function

        ''' <summary>
        ''' 컨트롤 크기 지정
        ''' </summary>
        ''' <param name="controlSize"></param>
        ''' <param name="rowCount"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetControlSize(ByVal controlSize As System.Drawing.Size, ByVal rowCount As Integer) As System.Drawing.Size
            Dim s As System.Drawing.Size

            s = controlSize

            For i As Integer = 1 To rowCount
                s.Height = s.Height + ControlHight + rowMargin
            Next

            Return s
        End Function

        ''' <summary>
        ''' 기존 컨트롤의 위치를 가져온다.
        ''' </summary>
        ''' <param name="objLocation"></param>
        ''' <param name="rowCount"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetLocation(ByVal objLocation As System.Drawing.Point, ByVal rowCount As Integer) As System.Drawing.Point

            Dim location As System.Drawing.Point = objLocation

            For rownumber As Integer = 1 To rowCount
                location.Y = location.Y + ControlHight + rowMargin
            Next

            Return location

        End Function

        ''' <summary>
        ''' 각각의 컨트롤의 위치와 크기를 셋팅한다.
        ''' </summary>
        ''' <param name="_frmcodename"></param>
        ''' <param name="mLayoutCollaction"></param>
        ''' <remarks></remarks>
        Public Sub SetLayout(ByVal _frmcodename As frmCodeName, ByVal mLayoutCollaction As Generic.Dictionary(Of String, Object))


            _frmcodename.Size = mLayoutCollaction(_frmcodename.Name + "_Size")

            For Each Ctrl As System.Windows.Forms.Control In _frmcodename.Controls

                Ctrl.Size = mLayoutCollaction(Ctrl.Name + "_Size")
                Ctrl.Location = mLayoutCollaction(Ctrl.Name + "_Location")

            Next


        End Sub

        ''' <summary>
        ''' 여러개의 컨트롤의 위치와 크기를 셋팅한다.
        ''' </summary>
        ''' <param name="ctrl"></param>
        ''' <param name="mLayoutCollaction"></param>
        ''' <remarks></remarks>
        Private Sub SetDictionary(ByVal ctrl As System.Windows.Forms.Control, ByVal mLayoutCollaction As Generic.Dictionary(Of String, Object))
            If ctrl.Controls.Count > 0 Then
                For Each tmpCtrl As System.Windows.Forms.Control In ctrl.Controls
                    If mLayoutCollaction.ContainsKey(ctrl.Name + "_Size") Then
                        tmpCtrl.Size = mLayoutCollaction(ctrl.Name + "_Size")
                    End If

                    If mLayoutCollaction.ContainsKey(ctrl.Name + "_Location") Then
                        tmpCtrl.Location = mLayoutCollaction(ctrl.Name + "_Location")
                    End If

                    If ctrl.Controls.Count > 0 Then
                        SetDictionary(ctrl, mLayoutCollaction)
                    End If

                Next
            End If
        End Sub

        ''' <summary>
        ''' 컨트롤을 collection에 담는다.
        ''' </summary>
        ''' <param name="ctrl"></param>
        ''' <param name="mLayoutCollaction"></param>
        ''' <remarks></remarks>
        Private Sub AddDictionary(ByVal ctrl As System.Windows.Forms.Control, ByVal mLayoutCollaction As Generic.Dictionary(Of String, Object))
            If ctrl.Controls.Count > 0 Then
                For Each tmpCtrl As System.Windows.Forms.Control In ctrl.Controls
                    If Not LayoutCollaction.ContainsKey(tmpCtrl.Name + "_Size") Then
                        If Not LayoutCollaction.ContainsKey(tmpCtrl.Name + "_Size") Then
                            LayoutCollaction.Add(tmpCtrl.Name + "_Size", tmpCtrl.Size)
                        End If
                    End If
                    If Not LayoutCollaction.ContainsKey(ctrl.Name + "_Location") Then
                        If Not LayoutCollaction.ContainsKey(tmpCtrl.Name + "_Location") Then
                            LayoutCollaction.Add(tmpCtrl.Name + "_Location", tmpCtrl.Location)
                        End If
                    End If
                    If tmpCtrl.Controls.Count > 0 Then
                        AddDictionary(tmpCtrl, LayoutCollaction)
                    End If
                Next
            End If

        End Sub
        ''' <summary>
        ''' 팝업명에 따른 컨트롤 정보를 Collection에 담아 둡니다.
        ''' </summary>
        ''' <param name="_frmcodename"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetLayout(ByVal _frmcodename As frmCodeName) As Generic.IDictionary(Of String, Object)
            If Not LayoutCollaction.ContainsKey(_frmcodename.Name + "_Size") Then
                LayoutCollaction.Add(_frmcodename.Name + "_Size", _frmcodename.Size)
            End If

            For Each Ctrl As System.Windows.Forms.Control In _frmcodename.Controls
                AddDictionary(Ctrl, LayoutCollaction)
            Next

            Return LayoutCollaction

        End Function

    End Class
End Namespace

