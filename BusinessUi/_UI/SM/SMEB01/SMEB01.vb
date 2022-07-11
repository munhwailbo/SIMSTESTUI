'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : UI 명세서
' form 설명 : UI 명세서를 조회, 추가, 수정, 삭제한다.			
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEB01
        Inherits CommonControls.UiControl

        Private Sub SMEB01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    

            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "io;n;n;"
            gridAttributes = gridAttributes & "|시스템 구분;SystemDivision;300;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 ID;ProgramID;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|프로그램 명;ProgramName;300;;l;" & "io;n;n;50;"
            gridAttributes = gridAttributes & "|프로그램 설명;ProgramExplanation;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|L1;Level1;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|L2;Level2;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|L3;Level3;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|L4;Level4;300;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|메뉴정렬순서;MenuStandInRowOrder;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|최종 여부;LastYesOrNo;300;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|사용 여부;PrivateUseYesOrNo;300;;l;" & "io;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1
        End Sub

        Private Sub BtnImageOpen1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                        BtnImageOpen1.Click _

            Me.OpenFileDialog1.InitialDirectory = "c:\"
            Me.OpenFileDialog1.Filter = "이미지 파일 (*.jpg)|*.jpg|이미지 파일 (*.bmp)|*.bmp|모든 파일 (*.*)|*.*"

            Try
                'MsgBox("사진 저장 중입니다.")
                If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Me.picUiImage.Image = Image.FromFile(OpenFileDialog1.FileName)
                End If
            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'If cnnSQL.State = ConnectionState.Open Then cnnSQL.Close()
                'cnnSQL = Nothing
            End Try

        End Sub

        Private Sub BtnImageSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImageSave.Click
            '-- 이미지 저장
            Call UpLoadImage()
        End Sub

        Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
            Dim DefaultString As String = vbNullString

            DefaultString = ""
            If chkRequestYesOrNo.Checked = True Then '조회 선택 시
                DefaultString = DefaultString & vbCrLf & "◎ 조회"
                DefaultString = DefaultString & vbCrLf & "   1. 검색 조건을 입력 한 후 조회 버튼을 클릭 한다."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkCreateYesOrNo.Checked = True Then '생성 선택 시
                DefaultString = DefaultString & vbCrLf & "◎ 생성"
                DefaultString = DefaultString & vbCrLf & "   1. 해당 자료를 입력 한 후 저장 버튼을 클릭 한다."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkUpdateYesOrNo.Checked = True Then '수정 선택 시
                DefaultString = DefaultString & vbCrLf & "◎ 수정"
                DefaultString = DefaultString & vbCrLf & "   1. 해당 자료를 변경 한 후 저장 버튼을 클릭 한다."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkDeleteYesOrNo.Checked = True Then '삭제 선택 시
                DefaultString = DefaultString & vbCrLf & "◎ 삭제"
                DefaultString = DefaultString & vbCrLf & "   1. 삭제 버튼을 클릭하여 삭제 한다."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            If chkPrintYesOrNo.Checked = True Then '출력 선택 시
                DefaultString = DefaultString & vbCrLf & "◎ 출력"
                DefaultString = DefaultString & vbCrLf & "   1. 미리보기 버튼을 클릭 하거나 출력 버튼을 클릭 하여 출력 한다."
                DefaultString = DefaultString & vbCrLf & ""
            End If
            DefaultString = DefaultString & vbCrLf & ""
            DefaultString = DefaultString & vbCrLf & ""
            txtSkillExplanation.Text = DefaultString
        End Sub

        
        Private Sub btnAutoImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoImage.Click

            '' 이미지연속등록 
            'Dim intII As Integer = 0
            'Dim sFilePath As String = "\\172.17.60.66\99. 문서 공유\2차화면 캡쳐"
            'Dim sSystemDiv As String = ""
            'Dim sFileName As String = ""

            'sFilePath = "D:\Test"
            'For intII = 0 To grd_1.Rows - 1
            '    If intII >= grd_1.FixedRows Then
            '        sSystemDiv = grd_1.get_TextMatrix(intII, grd_1.get_ColIndex("SystemDivision"))
            '        sFileName = grd_1.get_TextMatrix(intII, grd_1.get_ColIndex("ProgramID"))
            '        sbImageReg(sFilePath & "\" & sSystemDiv, sFileName)
            '    End If
            'Next

        End Sub

        Private Sub sbImageReg(ByVal sFilePath As String, ByVal sFileName As String)


            Try
                'MsgBox("사진 저장 중입니다.")
                Me.picUiImage.Image = Image.FromFile(sFilePath & "\" & sFileName & ".jpg")

                ''-- 이미지 저장
                'Call UpLoadImage()


            Catch exp As Exception
                MessageBox.Show(exp.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'If cnnSQL.State = ConnectionState.Open Then cnnSQL.Close()
                'cnnSQL = Nothing
            End Try

        End Sub

    
    End Class

End Namespace
