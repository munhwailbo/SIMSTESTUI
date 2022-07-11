'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : Table 명세서 등록
' form 설명 : Table 명세서 등록 추가, 수정, 삭제, 조회한다.
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

Imports c1.Win.C1FlexGrid
Imports c1.Win.C1FlexGrid.Classic
Imports c1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Imports System.Text
Imports System.IO

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEB02
        Inherits CommonControls.UiControl

        Private Sub SMEB02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String
            Dim gridCodeNameList As String

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = ""
            gridCodeNameList = ""
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|ObjectType;ObjectType;1000;;c;" & "o;n;n;2"
            gridAttributes = gridAttributes & "|ObjectId;ObjectId;500;;l;" & "o;n;n;10"
            gridAttributes = gridAttributes & "|ObjectName;ObjectName;500;;l;" & "o;n;n;2"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            'gridAttributes = ""
            'gridCodeNameList = ""

            ''수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            'gridAttributes = gridAttributes & "n;r;y"

            ''화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ''& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            'gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            'gridAttributes = gridAttributes & "|업무 구분;SystemDivision;1000;;c;" & "o;n;y;6"
            'gridAttributes = gridAttributes & "|테이블 ID;TableName;500;;l;" & "o;n;y;2"
            'gridAttributes = gridAttributes & "|테이블 명;TableDesc;500;;l;" & "o;n;y;50"
            'gridAttributes = gridAttributes & "|ID;ColumnID;500;#,###;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|컬럼 명;ColumnName;2000;;l;" & "o;n;n;50"
            'gridAttributes = gridAttributes & "|컬럼 개요;ColumnDesc;100;;l;" & "o;n;n;1"
            'gridAttributes = gridAttributes & "|타입;Type;500;;c;" & "o;n;n;5"
            'gridAttributes = gridAttributes & "|길이;Length;500;;c;" & "o;n;n;2"
            'gridAttributes = gridAttributes & "|정렬 순서;TableOrder;500;;c;" & "o;n;y;50"
            'gridAttributes = gridAttributes & "|Null 여부;Is_Null;100;;c;" & "o;n;n;1"

            'grd_2.Initialize(gridAttributes, gridCodeNameList)
            'grd_2.ExplorerBar = 3

            Me.txtPath.Text = "C:\irisDBscript"

        End Sub

        Private Sub btnTaxBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaxBill.Click
            Dim AprocessMessage = True

            'Validation
            'If fnValidation() = False Then
            '    Exit Sub
            'End If

            If MessageBox.Show("스크립트 파일을 생성하시겠습니까?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Exit Sub
            End If

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AreportYears", Me.dtpReportYears.TextValue)
            '    .SetSqlParameter(GmainsqlParameters, "@AreportGubun", Me.cboReportDivisionCode.TextValue)

            '    Using reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("AC","ACG009_2_R", False, True, GmainsqlParameters)
            '        .SetDataSetToControls(reciveDataSet, Me)

            '        '해당 데이터가 없는 경우는 헤더와 집계 내용만 있으므로 행수가 3보다 커야한다.
            '        If reciveDataSet.Tables(0).Rows.Count < 4 Then
            '            MessageBox.Show("계산서 전산 매체를 생성할 데이터가 없습니다." + vbCrLf + "계산서 데이터가 생성되었는지 확인해 주십시오.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '            Exit Sub
            '        End If

            If Me.txtContents.Text.Trim() = "" Then
                MessageBox.Show("생성할 스크립트 내용이 없습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            '전산 매체 파일 생성
            If WriteMediaText(Me.grd_1.GetCurrentRowCellValue("ObjectName")) = True Then
                MessageBox.Show("스크립트 파일을 정상적으로 생성했습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("스크립트 파일 생성에 실패했습니다. 다시 시도해 주십시오.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Cursor = Cursors.Default
            '    End Using

            '.SetAllBusinessUiInitialValue(Me)
            'If AprocessMessage = True Then .RequestDataMessage(Me)

            'End With

        End Sub
        '====================================================================================================
        ' 전산매체 파일 작성
        '====================================================================================================
        Public Function WriteMediaText(ByVal strFileName As String) As Boolean
            Dim strFileFullPath As String   '파일 생성 경로

            Try
                WriteMediaText = False

                ''파일명을 가져오기위해 제출자의 사업자 번호를 가져온다.
                'If mediaGubun = "1" Then        '세금계산서
                '    strFileName = ds.Tables(0).Rows(0)("MediaText").ToString().Substring(1, 10)
                'ElseIf mediaGubun = "2" Then    '계산서
                '    strFileName = ds.Tables(0).Rows(0)("MediaText").ToString().Substring(19, 10)
                'ElseIf mediaGubun = "3" Then    '신용카드매출전표
                '    strFileName = ds.Tables(0).Rows(0)("MediaText").ToString().Substring(8, 10)
                'End If

                'If mediaGubun = "1" Then
                '    strPrefix = "K"
                'ElseIf mediaGubun = "2" Then
                '    strPrefix = "H"
                'ElseIf mediaGubun = "3" Then
                '    strPrefix = "J"
                'End If

                '전산매체 파일( K(세금계산서) 또는 H(계산서) + 사업자번호(좌측에서 7자리 숫자) + "." + 사업자번호(우측에서 3자리 숫자)   
                strFileName = strFileName + "." + "sql"

                '파일 경로 Full PATH
                strFileFullPath = Me.txtPath.Text + "\" + strFileName

                '존재하는 파일은 삭제할지 여부를 묻고 파일을 생성한다.
                If File.Exists(strFileFullPath) = True Then
                    If MessageBox.Show("기존에 생성된 스크립트 파일이 존재합니다." + vbCrLf + "삭제하고 다시 생성하시겠습니까?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        File.Delete(strFileFullPath)

                        'Using (ds)
                        '    '마지막 행까지 LOOP를 돌면서 텍스트를 작성한다.
                        '    For inti = 0 To ds.Tables(0).Rows.Count - 1
                        File.AppendAllText(strFileFullPath, Me.txtContents.Text, Encoding.Default)
                        '    Next inti

                        'End Using
                    End If
                Else
                    'Using (ds)
                    '디렉토리가 존재하지 않는다면 생성한다.
                    If Directory.Exists(Me.txtPath.Text) = False Then
                        Directory.CreateDirectory(Me.txtPath.Text)
                    End If

                    '마지막 행까지 LOOP를 돌면서 텍스트를 작성한다.    
                    'For inti = 0 To ds.Tables(0).Rows.Count - 1
                    File.AppendAllText(strFileFullPath, Me.txtContents.Text, Encoding.Default)
                    'Next inti
                    'End Using

                End If

                WriteMediaText = True

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Function
        ''====================================================================================================
        '' 컨트롤의 값 Validation
        ''====================================================================================================
        'Public Function fnValidation() As Boolean
        '    fnValidation = False

        '    '신고년도 체크
        '    If Me.dtpReportYears.TextValue = "" Or Me.dtpReportYears.TextValue.Length <> 4 Then
        '        MessageBox.Show("신고년도에 오류가 있습니다. 다시 입력해 주십시오.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        dtpReportYears.Focus()
        '        Exit Function
        '    End If

        '    '신고구분 체크
        '    If Me.cboReportDivisionCode.TextValue = "" Then
        '        MessageBox.Show("신고 구분을 선택해 주십시오.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        cboReportDivisionCode.Focus()
        '        Exit Function
        '    End If

        '    fnValidation = True
        'End Function

        Private Sub btnSearchDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchDir.Click
            FolderBrowserDialog1.SelectedPath() = "C:\"

            If FolderBrowserDialog1.ShowDialog <> DialogResult.Cancel Then
                Me.txtPath.Text = FolderBrowserDialog1.SelectedPath()
            End If
        End Sub
    End Class

End Namespace
