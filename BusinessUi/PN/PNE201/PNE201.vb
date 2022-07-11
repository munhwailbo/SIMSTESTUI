'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 관리비항목수정삭제
' form 설명 : 관리비 항목을 등록 수정 합니다.
' 작성자 : 임종성
' 작성일 : 2006-03-07
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

    Public Class PNE201
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
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원확장번호;EmployeeExpNum;80;;c;" & "io;n;n;5;"   '' PK
            gridAttributes = gridAttributes & "|확장명;EmployeeExpNm;70;;l;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|연번;SeriesNum;80;;c;" & "io;n;y;5;"                '' PK
            gridAttributes = gridAttributes & "|확장처코드;CompanyCd;70;;c;" & "o;n;y;40;확장처 명;CompanyNm;"
            gridAttributes = gridAttributes & "|확장처명;CompanyNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|확장일자;ExpandDt;80;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|권유자코드;SolicitorEmpNum;80;;c;" & "o;n;n;5;사원 명;SolicitorEmpNumNm"
            gridAttributes = gridAttributes & "|사원명;SolicitorEmpNumNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|권유자구분코드;SolicitorDivCd;80;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|권유부서코드;SoliDeptCd;80;;c;" & "o;n;n;40;부서 명;SoliDeptNm;"
            gridAttributes = gridAttributes & "|권유부서명;SoliDeptNm;80;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|(사확)확정;ExFixedPaperNum;70;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|접수;TargetPaperTotNum;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|신규확장;FixedPaperNum;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|재확장;ReFixedPaperNum;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|조정(신규);NewStopPaperNum;70;#,###;r;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|조정(재접수);ReStopPaperNum;70;#,###;r;" & "io;n;n;40;"
            '' '' ''의미 없슴.
            ' '' '' '' ''gridAttributes = gridAttributes & "|개인실적여부;IndividualYN;80;;c;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|지급여부;PaymentYesOrNo;80;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|지급일자;PaymentDate;80;;c;" & "io;n;y;5;"

            gridAttributes = gridAttributes & "|비고;PayRemark;80;;l;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|;mErONG;90;;l;" & "io;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"
            'gridCodeNameList = gridCodeNameList & "SolicitorDivCd;권유자구분코드"
            'gridCodeNameList = gridCodeNameList & "/NationalityCd;국적코드"
            'gridCodeNameList = gridCodeNameList & "/ResidenceDivCd;거주구분코드"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNE201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' 개발자모드에서는 조정하지 않고 실행모드에서만 작동하도록한다.
                Me.Dock = DockStyle.Fill                                               ' 개발된 화면이 메인화면의 사이즈에 따라 유동적으로 커지게 한다.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub


        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            ' '' ''Me.grd_1.Editable = EditableSettings.flexEDKbdMouse

            ' '' ''If Me.grd_1.Rows > 1 Then
            ' '' ''    With Me.grd_1
            ' '' ''        Select Case .ColSel
            ' '' ''            Case .get_ColIndex("SeriesNum")
            ' '' ''                .Editable = EditableSettings.flexEDNone
            ' '' ''            Case Else
            ' '' ''                .Editable = EditableSettings.flexEDKbdMouse
            ' '' ''        End Select
            ' '' ''    End With
            ' '' ''End If

        End Sub

      
    End Class

End Namespace
