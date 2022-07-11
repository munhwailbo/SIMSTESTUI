' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form명 : SMCB01
' form설명 : 예산계정 정보를 등록한다.
' 작성자 : 정태득
' 작성일 : 2006-01-24
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.AC

    Public Class SMCB01
        Inherits CommonControls.UiControl

        Private Sub SMCB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'VSFlexGrid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;84;;4;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;84;;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;200;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;200;;1;" & "o;n;n;30;조직 명;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|조직 명;OnesPositionDepartmentCodeName;200;;1;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "businessplacecode;사업장 명"
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            gridAttributes = ""
            Me.grd_1.ExplorerBar = 3


            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); 필수 입력 y/n; 숨기기 y/n; 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;84;;4;" & "io;n;y;6;"
            gridAttributes = gridAttributes & "|사원 번호;EmployeeNumber;84;;4;" & "io;n;n;6;"
            gridAttributes = gridAttributes & "|사원 명;EmployeeNameHangul;200;;1;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|조직 코드;OnesPositionDepartmentCode;200;;1;" & "io;n;n;30;조직 명;OnesPositionDepartmentCodeName"
            gridAttributes = gridAttributes & "|조직 명;OnesPositionDepartmentCodeName;200;;1;" & "io;n;n;30;"

            'grid code combo
            gridCodeNameList = ""
            'gridCodeNameList = gridCodeNameList & "branchcode_2;지점 명"
            Me.grd_2.Initialize(gridAttributes, gridCodeNameList)


            Me.grd_2.ExplorerBar = 3
        End Sub

        Private Sub btnMove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove1.Click
            '
            GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_1.GetXmlData(True))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

            CallByName(Me, "RequestData", CallType.Method)
        End Sub

        Private Sub btnMove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove2.Click
            '
            GmainsqlParameters = Nothing
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@RoleCode", Me.cboRoleCode.TextValue)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

            GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB01_2_CUD", True, False, GmainsqlParameters)

            GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
            GmainCommonFunction.SaveDataMessage(Me)

            CallByName(Me, "RequestData", CallType.Method)
        End Sub
    End Class

End Namespace
