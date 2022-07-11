'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 본부면적등록
' form 설명 : 본부 면적을 등록한다
' 작성자 : 임종성
' 작성일 : 2006-03-16
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

Namespace ubiLease.UI.BusinessUi.CM

    Public Class CMAA01
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;c;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "io;n;n;"
            gridAttributes = gridAttributes & "|번호;SEQ;1464;;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|제목;Title;1253;;l;" & "o;n;n;50;"
            gridAttributes = gridAttributes & "|내용;Content;1570;;l;" & "o;n;n;10000;"
            gridAttributes = gridAttributes & "|작성일자;RegistrationDate;1041;;c;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|작성자;Writer;1570;;l;" & "o;n;n;20;"
            gridAttributes = gridAttributes & "|공지 종료 일자;DayClose;1570;;c;" & "o;n;y;12;"
            'gridAttributes = gridAttributes & "|등록 ID;RegistrationIP;1570;;r;" & "o;n;n;12;"
            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

        End Sub


    End Class

End Namespace
