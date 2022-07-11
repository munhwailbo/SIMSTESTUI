'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 사용자별 업무조직 등록
' form 설명 : 사용자별 업무조직을 조회, 추가, 수정, 삭제한다. 
' 작성자 : 강동훈
' 작성일 : 2006-08-30
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

    Public Class SMCB03
        Inherits CommonControls.UiControl

        Private tmpOrganizationCode As String = ""
#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize 
        ''' 기  능 : 그리드 초기화 
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            gridAttributes = gridAttributes & "||선택;선택;40;;c;" & "o;n;y;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;300;;l;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;300;;l;" & "o;n;n;6;사원 명;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;100;;c;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "RoleCode;롤 코드 명"


            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    
            gridAttributes = gridAttributes & "||선택;선택;40;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;300;;l;" & "io;n;n;5;롤 코드 명;RoleName"
            gridAttributes = gridAttributes & "|역할 명;RoleName;300;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;300;;l;" & "io;n;y;6;사원 명;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;100;;c;" & "o;n;y;30;"

            gridAttributes = gridAttributes & "|조직 코드;OrganizationCode;300;;l;" & "o;n;n;5;부서 명;CodeName"
            gridAttributes = gridAttributes & "|조직 명;CodeName;300;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|코드 구분 코드;CodeDivisionCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|코드 속성 코드;CodeAttributeCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|최종 조직 여부;LastYesOrNo;300;;l;" & "o;n;y;;"

            gridAttributes = gridAttributes & "|사업장 코드;BusinessPlaceCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|지점 코드;BranchCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|팀 코드;TeamCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|파트 코드;PartCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|PC 코드;PCCode;300;;l;" & "o;n;y;2;"
            gridAttributes = gridAttributes & "|코너 코드;CornerCode;300;;l;" & "o;n;y;3;"
            gridAttributes = gridAttributes & "|신규 구분;IsExist;300;;l;" & "o;n;y;3;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "RoleCode;롤 코드 명;"

            grd_2.Initialize(gridAttributes, gridCodeNameList)

        End Sub
#End Region

#Region "폼 이벤트"

        Private Sub SaveBreak()
            ' 1. 뭔가 체크를 할 것이다.
            ' 2. DB 저장을 건너 뛰고 싶다.
            ' 3. 그리고 재 조회도 막고 싶다.

            Me.GLogicCheckPassYesOrNo = True ' 저장하지 않음
            Me.GmainExecuteDbCommand.GerrorNumber = 1
            Me.GmainExecuteDbCommand.GerrorDescription = " 재조회를 막습니다."

        End Sub


        ''' <summary>
        ''' 함수명 : grd_1_BeforeSelChange 
        ''' 기  능 : 그리드 선택 
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_1_BeforeSelChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles grd_1.BeforeSelChange
            'Dim isNoneSaveDataExist As Boolean = False

            'If Me.grd_2.Rows > 0 And Me.grd_2.get_ColKey(1) = "선택" Then
            '    For i As Integer = 1 To grd_2.BottomRow Step 1
            '        If grd_2.GetCellCheck(i, 1) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
            '            isNoneSaveDataExist = True
            '        End If
            '    Next
            'End If

            'If Me.grd_1.Rows > 1 And Me.grd_1.RowSel > 0 Then
            '    If isNoneSaveDataExist = False Then
            '        'Me.RequestData_2(True)
            '    Else
            '        MsgBox("저장되지 않은 데이터가 존재합니다." & Environment.NewLine & "저장 후 다시 하세요")
            '        e.Cancel = True
            '    End If
            'End If
        End Sub
        ''' <summary>
        ''' 함수명 : grd_2_LostFocus 
        ''' 기  능 : 그리드 포커스 이동시 수행할 이벤트 
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
            'If grd_2.Rows > 1 Then
            '    If grd_2.get_ColKey(grd_2.CursorCell.c1) = "OrganizationCode" Then
            '        tmpOrganizationCode = ""
            '        tmpOrganizationCode = grd_2.get_TextMatrix(grd_2.CursorCell.r1, grd_2.CursorCell.c1)
            '    End If
            'End If

        End Sub
        ''' <summary>
        ''' 함수명 : grd_2_EnterCell 
        ''' 기  능 : Key Lock
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs)

            With Me.grd_2
                .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                If .get_TextMatrix(.RowSel, .get_ColIndex("IsExist")) = "U" Then
                    .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                Else
                    If .ColSel = .get_ColIndex("RoleCode") Then
                        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDNone
                    Else
                        .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
                    End If
                End If
            End With
        End Sub
#End Region

        
        Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AsystemDivisionCode", Me.cboBizGubun.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AemployeeNumber", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("EmployeeNumber")))
            End With

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM", "SMCB03_3_R", False, True, GmainsqlParameters)
            Me.grd_2.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            Dim intII As Integer
            For intII = 1 To grd_2.Rows - grd_2.FixedRows
                Me.grd_2.set_TextMatrix(intII, 0, "신규")
                Me.grd_2.SetCellCheck(intII, Me.grd_2.get_ColIndex("선택"), C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next
        End Sub
    End Class

End Namespace
