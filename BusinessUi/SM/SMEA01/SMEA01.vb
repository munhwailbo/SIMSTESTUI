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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEA01
        Inherits CommonControls.UiControl

        Private Sub SMEA01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;c;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code    
    
            gridAttributes = gridAttributes & "||선택;선택;40;;4;" & "io;n;y;"
            gridAttributes = gridAttributes & "|사업장 코드;BusinessPlaceCode;300;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|상호;FirmName;300;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|사업자 번호;BusinessesNumber;300;###-##-#####;l;" & "o;n;y;30;"
            'gridAttributes = gridAttributes & "|법인 번호;JuridicalPersonNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|대표자 명;RepresentativeName;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|우편 번호;PostNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|주소 1;Address1;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|주소 2;Address2;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|전화 번호;PhoneNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|팩스 번호;FaxNumber;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|업태;BusinessConditions;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|종목;Item;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|세무서 코드;TaxOfficeCode;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|세무서 명;TaxOfficeName;300;;l;" & "o;n;n;30;"
            'gridAttributes = gridAttributes & "|비고;Note;300;;l;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "BusinessPlaceCode;사업장 명"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------



        End Sub

        

        
    End Class

End Namespace
