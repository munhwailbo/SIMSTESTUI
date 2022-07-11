'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 입퇴점관리
' form 설명 : 입점 퇴점 이력을 조회, 추가, 수정, 삭제한다.			
' 작성자 : 박민정
' 작성일 : 2006-03-09
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

Namespace ubiLease.UI.BusinessUi.CO

    Public Class SMCA02
        Inherits CommonControls.UiControl

        Private Sub SMCA02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;100;;c;" & "io;n;n;6;권한 사용자 사원 명;EmployeeNameHangul"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|비밀 번호;SecretNumber;100;;c;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|초기화 여부;NewYesNo;80;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|조직 명;OrganizationCodeName;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사용자 등급;UserGrade;80;;c;" & "io;n;n;"
            gridAttributes = gridAttributes & "|대행 사원 번호;RoleEmpNum;100;;c;" & "io;n;n;6;권한 사용자 사원 명;RoleEmpNm"
            gridAttributes = gridAttributes & "|대행 사원 명;RoleEmpNm;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;100;;c;" & "io;n;n;1;"

            'gridAttributes = gridAttributes & "|비고;Note;3000;;l;" & "io;n;n;255;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "UserGrade;사용자 등급 명"
            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;사업장 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            grd_1.ExplorerBar = grd_1.get_ColIndex("EmployeeNumber")
            grd_1.ExplorerBar = grd_1.get_ColIndex("EmployeeNameHangul")

            grd_1.FrozenCols = 3

            '--------------------------------------------------
        End Sub

        Private Sub txtManagementTrustName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtProfitDistributionRatio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub grd_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_1.Click
            'Call sbSetGridToControl()
        End Sub

        Private Sub btnPromiseAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Me.grd_3.AddRow()
        End Sub

        Private Sub popEarningsOrganizationCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popEarningsOrganizationCode.Load

        End Sub
    End Class

End Namespace
