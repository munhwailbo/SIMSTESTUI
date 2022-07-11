'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �������׸��������
' form ���� : ������ �׸��� ��� ���� �մϴ�.
' �ۼ��� : ������
' �ۼ��� : 2006-03-07
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
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|���Ȯ���ȣ;EmployeeExpNum;80;;c;" & "io;n;n;5;"   '' PK
            gridAttributes = gridAttributes & "|Ȯ���;EmployeeExpNm;70;;l;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|����;SeriesNum;80;;c;" & "io;n;y;5;"                '' PK
            gridAttributes = gridAttributes & "|Ȯ��ó�ڵ�;CompanyCd;70;;c;" & "o;n;y;40;Ȯ��ó ��;CompanyNm;"
            gridAttributes = gridAttributes & "|Ȯ��ó��;CompanyNm;70;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|Ȯ������;ExpandDt;80;;c;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|�������ڵ�;SolicitorEmpNum;80;;c;" & "o;n;n;5;��� ��;SolicitorEmpNumNm"
            gridAttributes = gridAttributes & "|�����;SolicitorEmpNumNm;60;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����ڱ����ڵ�;SolicitorDivCd;80;;c;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�����μ��ڵ�;SoliDeptCd;80;;c;" & "o;n;n;40;�μ� ��;SoliDeptNm;"
            gridAttributes = gridAttributes & "|�����μ���;SoliDeptNm;80;;l;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|(��Ȯ)Ȯ��;ExFixedPaperNum;70;#,###;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|����;TargetPaperTotNum;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�ű�Ȯ��;FixedPaperNum;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|��Ȯ��;ReFixedPaperNum;70;#,###;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����(�ű�);NewStopPaperNum;70;#,###;r;" & "io;n;n;40;"
            gridAttributes = gridAttributes & "|����(������);ReStopPaperNum;70;#,###;r;" & "io;n;n;40;"
            '' '' ''�ǹ� ����.
            ' '' '' '' ''gridAttributes = gridAttributes & "|���ν�������;IndividualYN;80;;c;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|���޿���;PaymentYesOrNo;80;;c;" & "io;n;y;5;"
            gridAttributes = gridAttributes & "|��������;PaymentDate;80;;c;" & "io;n;y;5;"

            gridAttributes = gridAttributes & "|���;PayRemark;80;;l;" & "io;n;n;5;"

            gridAttributes = gridAttributes & "|;mErONG;90;;l;" & "io;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "ProjectID;������Ʈ ��"
            'gridCodeNameList = gridCodeNameList & "SolicitorDivCd;�����ڱ����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/NationalityCd;�����ڵ�"
            'gridCodeNameList = gridCodeNameList & "/ResidenceDivCd;���ֱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

        End Sub

        Private Sub PNE201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
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
