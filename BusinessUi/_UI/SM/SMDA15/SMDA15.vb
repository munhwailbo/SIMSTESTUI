'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ����� ���α׷� ������Ȳ
' form ���� : ����� ���α׷� ������Ȳ�� ��ȸ�Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-02-02 �����
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA15
        Inherits CommonControls.UiControl

        Private Sub SMDA15_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================


        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code    

            gridAttributes = gridAttributes & "||����;����;20;;4;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��������;CheckDate;100;;c;" & "io;y;y;30;"
            gridAttributes = gridAttributes & "|��������;WorkDivision;70;;l;" & "io;y;n;30;"
            gridAttributes = gridAttributes & "|����;Seq;35;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|����ID;CheckID;350;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;StateCode;80;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�����Ǽ�;ErrorCount;80;;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���˳���;CheckContent;450;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|ó������;TreatDate;60;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó����;TreatEmployee;40;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó�����;TreatResult;40;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;;50;;c;" & "o;n;n;30;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "PlanDiligenceLazinessCode;���� �ڵ� ��"
            'gridCodeNameList = gridCodeNameList & "/WorkDiligenceLazinessCode;���� �ڵ� ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            gridAttributes = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;20;;4;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��������;CheckDate;100;;c;" & "io;y;y;30;"
            gridAttributes = gridAttributes & "|��������;WorkDivision;70;;l;" & "io;y;y;30;"
            gridAttributes = gridAttributes & "|����;Seq;35;;r;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|����ID;CheckID;350;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;StateCode;80;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�����Ǽ�;ErrorCount;80;;r;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���˳���;CheckContent;500;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|ó������;TreatDate;60;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó����;TreatEmployee;40;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|ó�����;TreatResult;40;;c;" & "o;n;y;30;"
            gridAttributes = gridAttributes & "|;Dummy;10;;l;" & "o;n;n;30;"                   '����


            'grid code combo
            gridCodeNameList = ""

            grd_2.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            Me.grd_2.ExplorerBar = 3

        End Sub

    End Class

End Namespace
