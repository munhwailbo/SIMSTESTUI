'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 테이블 목록 등록
' form 설명 : 테이블 목록을 등록 한다.
' 작성자 : 반영철
' 작성일 : 2008-09-19
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


Imports System.IO

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB203
        Inherits CommonControls.UiControl

        ' 템플릿 파일 경로 변수
        Public strFilePath As String = ""

        ' 저장 경로 변수
        Public strSaveFilePath As String = ""

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;지국코드;BranchNm"
            gridAttributes = gridAttributes & "|지국명;BranchNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;60;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|계약자주민번호;SocialNum;90;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|계약자 명;Name;70;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|교체횟수;ChangeNum;60;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|계약일자;ContractDt;60;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;80;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;80;;c;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|계약해지일자;ContractCancelDt;80;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|계약자주민번호;SocialNum;90;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|계약자 명;Name;70;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|지국장코드;BranchChiefCd;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|계약자주민번호;SocialNum;90;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|계약자 명;Name;70;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|상호;CorparationNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|종목;BusiType;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|업태;BusiStatus;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|지국번호;BranchNum;60;;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|지국코드;BranchCd;60;;c;" & "o;n;n;5;"       '(10)
            'gridAttributes = gridAttributes & "|지국명;BranchNm;150;;c;" & "o;n;n;7;"
            'gridAttributes = gridAttributes & "|지국 명;BranchNm;60;;l;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|교체횟수;ChangeNum;60;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|계약일자;ContractDt;60;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|계약시작일자;ContractStDt;80;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|계약종료일자;ContractEdDt;80;;c;" & "o;n;n;40;"
            'gridAttributes = gridAttributes & "|계약해지일자;ContractCancelDt;80;;c;" & "o;n;n;40;"


            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 3

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|순번;Orders;50;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|보증금적립금구분코드;DepositDivCd;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|입금일자;ReceiptDt;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|계정코드;AccountCd;70;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|보증금금액;DepositAmt;70;#,###;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|지대년월;PayYYYYMM;80;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;dumi;80;;l;" & "o;n;n;30;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "ParType;컬럼 타입 명"
            gridCodeNameList = gridCodeNameList & "DepositDivCd;보증금적립금구분코드"
            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExplorerBar = 1

            'grid를 초기화 한다.
            '--------------------------------------------------
            gridAttributes = ""

        End Sub

#Region "팝업 이벤트"
        ''' <summary>
        ''' 함수명 : popSystemID
        ''' 기  능 : 팝업 Where절 추가 
        ''' 작성자 : 황인중
        ''' 작성일 : 2007-10-08
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub popSystemID_ButtonClick()
            'Me.popSystemID.Tag = ""
            Dim strProjectID As String = ""
            'If Me.popProjectID.NameText = "" Then
            '    strProjectID = "code(시스템 명);where(ProjectID like '%' + '" & Me.popProjectID.TextValue & "');"
            'Else
            '    strProjectID = "code(시스템 명);where(ProjectID='" & Me.popProjectID.TextValue & "0');"
            'End If

            'Me.popSystemID.Tag = strProjectID
            'MsgBox(strContractorIDTag)
        End Sub
#End Region

        Private Sub PNB203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If
        End Sub


#Region "템플릿 경로 설정"
        'Private Sub btnTampletFilePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    Dim FolderPath As New FolderBrowserDialog
        '    FolderPath.ShowNewFolderButton = True

        '    Dim result As DialogResult = FolderPath.ShowDialog()

        '    If result = DialogResult.OK Then
        '        'Me.lblTemplatePath.Text = " 파일 경로: " + FolderPath.SelectedPath
        '        strFilePath = FolderPath.SelectedPath

        '        Dim intTempCount As Integer = 0
        '        Dim temp() As String = System.IO.Directory.GetFiles(FolderPath.SelectedPath & "\")

        '        If temp.Length > 0 Then
        '            For inti As Integer = 0 To temp.Length - 1
        '                If temp(inti) = strFilePath & "\테이블목록.xls" Then
        '                    intTempCount = intTempCount + 1
        '                    Exit Sub
        '                End If
        '            Next
        '            MessageBox.Show("선택한 경로 안에 양식 템플릿 파일이 없습니다 생성후 경로 설정하세요 ", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Me.GetTempletPath()
        '            Exit Sub
        '        End If
        '    End If

        'End Sub
#End Region

#Region "저장 경로 설정"
        'Private Sub btnSavePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    Dim FolderPath As New FolderBrowserDialog
        '    FolderPath.ShowNewFolderButton = True

        '    Dim result As DialogResult = FolderPath.ShowDialog()
        '    If result = DialogResult.OK Then

        '        Me.strSaveFilePath = FolderPath.SelectedPath
        '        'Me.lblSavePath.Text = " 파일 경로: " + strSaveFilePath

        '    End If
        'End Sub
#End Region



        Dim intJJ As Integer

        Dim strProjectName As String = "" '프로젝트 명
        Dim strSystemName As String = "" '시스템 명
        Dim strUnitSystemName As String = "" '단위 시스템 명
        Dim strTodate As String = "" '오늘 날짜


#Region "테이블 목록 가져오기"


#End Region

        Private Sub grd_2_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_2.EnterCell

            With Me.grd_2
                If .Rows > 1 Then
                    .Editable = Classic.EditableSettings.flexEDKbdMouse

                    Select Case .ColSel
                        Case .get_ColIndex("BranchNum")
                            .Editable = Classic.EditableSettings.flexEDNone
                        Case .get_ColIndex("Orders")
                            .Editable = Classic.EditableSettings.flexEDNone
                        Case Else
                            .Editable = Classic.EditableSettings.flexEDKbdMouse
                    End Select
                    'End If
                End If

            End With

        End Sub
    End Class

End Namespace

