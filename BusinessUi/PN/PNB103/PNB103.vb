'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : SP 목록 등록
' form 설명 : SP 목록 등록 한다.
' 작성자 : 황인중
' 작성일 : 2007-07-12
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNB103
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;0;;1;" & "o;n;y;;;"
            gridAttributes = gridAttributes & "|담당 명;ChargeEmpNm;108;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|담당자사번;ChargeEmpNum;0;;4;" & "o;n;y;30;영업사원 명;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|지국번호;BranchNum;76;;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchCd;0;;4;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|지국코드;BranchNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지급년월;PayYYYYMM;63;yyyy-MM;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|임차료금액;RentAmt;74;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|부가세액;RentVat;62;#,##0;7;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|지급일자;PaymentDt;85;yyyy-MM-dd;4;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|은행코드;BankCd;109;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|계좌번호;AccountNum;135;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|예금주명;DepositorNm;62;;1;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|;dumi;150;;1;" & "o;n;n;30;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "BankCd;은행코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 3 

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

        Private Sub PNB103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub

        ' 그리드 Key Lock

        Private Sub grd_2_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Me.grd_2.Editable = EditableSettings.flexEDKbdMouse

            'If Me.grd_2.Rows > 1 Then
            '    With Me.grd_2
            '        Select Case .ColSel
            '            Case .get_ColIndex("Seq")
            '                .Editable = EditableSettings.flexEDNone
            '            Case .get_ColIndex("ProjectID")
            '                .Editable = EditableSettings.flexEDNone
            '            Case Else
            '                .Editable = EditableSettings.flexEDKbdMouse
            '        End Select
            '    End With
            'End If
        End Sub

        Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            SaveData()
        End Sub
    End Class

End Namespace

