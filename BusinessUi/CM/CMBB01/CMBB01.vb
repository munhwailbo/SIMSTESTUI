'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 입퇴점관리
' form 설명 : 입점 퇴점 이력을 조회, 추가, 수정, 삭제한다.			
' 작성자 : 김성훈
' 작성일 : 2007-10-30
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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.CM

    Public Class CMBB01
        Inherits CommonControls.UiControl

        Dim mBolInit As Boolean = False

        Private Sub CMBB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

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
            gridAttributes = gridAttributes & "|조직코드;OrganizationCode;100;;l;" & "io;n;n;20;"
            gridAttributes = gridAttributes & "|조직명;CodeName;100;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|최종 여부;LastYesOrNo;100;;c;" & "o;n;Y;100;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;100;;c;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|출력 순서;PrintOrder;100;;c;" & "io;n;n;100;"
            gridAttributes = gridAttributes & "|;;100;;c;" & "o;n;n;100;"
            'grid code combo
            Dim gridCodeNameList As String = ""

            'grd_1.ComboItem(4)

            'gridCodeNameList = gridCodeNameList & "CodeDivisionCode;조직 구분"
            'gridCodeNameList = gridCodeNameList & "/BusinessPlaceCode;사업장 명"
            'gridCodeNameList = gridCodeNameList & "/BranchCode;조직 지점 명,본부"
            'gridCodeNameList = gridCodeNameList & "/TeamCode;조직 팀 명,본부,지점"


            

            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;사업장 명"
            'grd_1.Clear(C1.Win.C1FlexGrid.Classic.ClearWhereSettings.flexClearSelection)
            'grd_1.Clear(C1.Win.C1FlexGrid.Classic.ClearWhereSettings.flexClearEverywhere)
            Debug.Print("행" & gridAttributes)
            Debug.Print("콤보" & gridCodeNameList)
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '-- copy 및 붙여 넣기 허용
            'grd_1.AutoClipboard = True

            mBolInit = True

            'grd_1.ColumnCollection("BusinessPlaceCode").AllowEditing = False
            'grd_1.ColumnCollection("BranchCode").AllowEditing = False
            'grd_1.ColumnCollection("TeamCode").AllowEditing = False
            'grd_1.ColumnCollection("PartCode").AllowEditing = False
            'grd_1.ColumnCollection("PCCode").AllowEditing = False
            'grd_1.ColumnCollection("CornerCode").AllowEditing = False

            'Select Case strLevel
            '    Case "1"
            '        grd_1.ColumnCollection("BusinessPlaceCode").AllowEditing = True
            '    Case "2"
            '        grd_1.ColumnCollection("BranchCode").AllowEditing = True
            '    Case "3"
            '        grd_1.ColumnCollection("TeamCode").AllowEditing = True
            '    Case "4"
            '        grd_1.ColumnCollection("PartCode").AllowEditing = True
            '    Case "5"
            '        grd_1.ColumnCollection("PCCode").AllowEditing = True
            '    Case "6"
            '        grd_1.ColumnCollection("CornerCode").AllowEditing = True
            'End Select

            '--------------------------------------------------
        End Sub

        Private Sub txtManagementTrustName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub


        Private Sub OrganizationCodeInitialize()
            '' 귀속 조직 구분에 따른 조직 코드 항목을 셋팅 한다.
            Dim blnBusinessPlaceCode As Boolean = False '본부 코드
            Dim blnBranchCode As Boolean = False '점 코드
            Dim blnTeamCode As Boolean = False '팀 코드
            Dim blnPartCode As Boolean = False '파트 코드
            Dim blnPCCode As Boolean = False 'PC 코드
            Dim blnCornerCode As Boolean = False '코너 코드

            'If Len(cboReversionDivisionCode.TextValue) > 0 Then
            'If cboOrganizationLevel.TextValue >= "1" Then blnBusinessPlaceCode = True '본부 코드  
            'If cboOrganizationLevel.TextValue >= "2" Then blnBranchCode = True '점 코드
            'If cboOrganizationLevel.TextValue >= "3" Then blnTeamCode = True '팀 코드
            'If cboOrganizationLevel.TextValue >= "4" Then blnPartCode = True '파트 코드
            'If cboOrganizationLevel.TextValue >= "5" Then blnPCCode = True 'PC 코드
            'If cboOrganizationLevel.TextValue >= "6" Then blnCornerCode = True '코너 코드

            '조직 코드 컨트롤 Visible 제어
            'lblBusinessPlaceCode.Visible = blnBusinessPlaceCode '본부 코드  
            'lblBranchCode.Visible = blnBranchCode '점 코드    
            'lblTeamCode.Visible = blnTeamCode '팀 코드    
            'lblPartCode.Visible = blnPartCode '파트 코드  
            'lblPCCode.Visible = blnPCCode 'PC 코드    
            'lblCornerCode.Visible = blnCornerCode '코너 코드  
            ''cboBusinessPlaceCode.Visible = blnBusinessPlaceCode '본부 코드  
            'cboBranchCode.Visible = blnBranchCode '점 코드    
            'cboTeamCode.Visible = blnTeamCode '팀 코드    
            'cboPartCode.Visible = blnPartCode '파트 코드  
            'cboPCCode.Visible = blnPCCode 'PC 코드    
            'cboCornerCode.Visible = blnCornerCode '코너 코드  
            'End If
        End Sub

        Private Sub cboOrganizationLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            '-- 조회 콤보 세팅
            Call OrganizationCodeInitialize()


            '-- 그리드 재 세팅
            '-- 
            If mBolInit = True Then
                Call Initialize()
            End If

        End Sub
        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell

            With Me.grd_1
                .Editable = EditableSettings.flexEDKbdMouse
                If .Rows > 1 Then
                    Select Case .ColSel
                        Case .get_ColIndex("선택")
                            .Editable = EditableSettings.flexEDKbdMouse
                        Case .get_ColIndex("PrintOrder")
                            .Editable = EditableSettings.flexEDKbdMouse
                        Case Else
                            .Editable = EditableSettings.flexEDNone
                    End Select
                End If
            End With
        End Sub
    End Class

End Namespace
