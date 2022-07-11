'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : Role 등록
' form 설명 : Role 정보를 조회, 추가, 수정, 삭제한다.			
' 작성자 : 황인중
' 작성일 : 2006-06-10
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

    Public Class SMCA01
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|역할 코드;RoleCode;80;;c;" & "io;y;n;7;"
            gridAttributes = gridAttributes & "|역할 이름;RoleName;170;;l;" & "io;y;n;40;"
            gridAttributes = gridAttributes & "|역할 설명;RoleExplanation;300;;l;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|업무 구분;SystemDivision;100;;c;" & "io;y;n;40;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;80;;l;" & "io;y;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "SystemDivision;시스템 구분 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            Dim Ds As DataSet = New DataSet
            Ds.Tables.Add()
            Ds.Tables.Item(0).Columns.Add("fromEmail")
            Ds.Tables.Item(0).Columns.Add("toEmail")
            Ds.Tables.Item(0).Columns.Add("subjectEmail")
            Ds.Tables.Item(0).Columns.Add("contentEmail")
            Ds.Tables.Item(0).Columns.Add("smtpEmail")
            Ds.Tables.Item(0).Columns.Add("cclistEmail")
            Ds.Tables.Item(0).Columns.Add("attachEmail")
            Ds.Tables.Item(0).Columns.Add("doctypeEmail")


            Dim aa As Object = Me.ParentForm
            For i As Integer = 0 To 10
                Dim param As String() = Split(",,,,,,,", ",")


                param(0) = aa.GetMasterEmailAddress.ToString()
                param(1) = "getmail@empal.com"
                param(2) = "테스트 메일  : " & i
                param(3) = Me.RichTextBox1.Text
                param(4) = aa.GetSmtpServerIp.ToString()
                param(5) = ""
                param(6) = ""
                param(7) = "HTML"

                Ds.Tables.Item(0).Rows.Add(param)

            Next
            GmainCommonFunction.DataSetToSendMail(Ds, "fromEmail", "toEmail", "subjectEmail", "contentEmail", "smtpEmail", "cclistEmail", "attachEmail", "doctypeEmail")
        End Sub

        Private Sub SMCA01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        End Sub
    End Class

End Namespace
