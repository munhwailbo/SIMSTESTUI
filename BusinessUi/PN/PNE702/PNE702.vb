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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class PNE702
        Inherits CommonControls.UiControl

        Private Sub PNE702_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            '=================== grid1 �ʱ�ȭ �Ѵ�. =================== 
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;c;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ�� ���� ����;AdDivision;130;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|�ٽ��� ��ȣ;BasketCd;50;;c;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|�ٽ��� �̸�;BasketHangulNm;100;;l;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|�ű� �μ�;NewSum;70;;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|������ �μ�;ReSum;70;;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|�ű� ��ȯ��;NewSumAmt;100;#,###;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|������ ��ȯ��;ReSumAmt;100;#,###;r;" & "io;y;n;5;"
            gridAttributes = gridAttributes & "|;Dummy;50;;l;" & "o;n;n;5;"


            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "AdDivision;���Ȯ�� ���� ����"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub grd_1_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_1.EnterCell
            With Me.grd_1
                .ImeMode = System.Windows.Forms.ImeMode.Hangul
                .Editable = Classic.EditableSettings.flexEDKbdMouse
                If .Rows > 1 Then
                    .Editable = Classic.EditableSettings.flexEDNone
                End If
            End With
        End Sub


    End Class

End Namespace
