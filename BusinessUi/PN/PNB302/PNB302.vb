'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : SP ��� ���
' form ���� : SP ��� ��� �Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-07-12
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

    Public Class PNB302
        Inherits CommonControls.UiControl

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code

            gridAttributes = gridAttributes & "||����;����;40;;4;" & "i;n;n;"
            gridAttributes = gridAttributes & "|��������;PaymentDt;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;70;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchNm;70;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|��������;TransferDate;60;;c;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|���޳��;PayYYYYMM;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|������;RentAmt;80;#,##0;r;" & "io;n;n;30;"

            gridAttributes = gridAttributes & "|��� ��;EmployeeNameHangul;10;;;" & "io;n;n;10;"
            gridAttributes = gridAttributes & "|�����ڵ�;BankCd;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���¹�ȣ;AccountNum;80;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�����ָ�;DepositorNm;80;;l;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|�ǹ��ֿ��ǰ���;OwnerRelation;90;;c;" & "io;n;n;30;"
            gridAttributes = gridAttributes & "|���;Note;60;;l;" & "io;n;y;30;"
            gridAttributes = gridAttributes & "|;dumi;150;;l;" & "o;n;n;30;"

            'grid_1 code combo    
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

        End Sub


        Private Sub PNB302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)
            End If

        End Sub



    End Class

End Namespace

