'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �Ҽӵ��
' form ���� : 
' �ۼ��� : ������
' �ۼ��� : 2008-09-30
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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNA203
        Inherits CommonControls.UiControl
        Private Sub PNA203_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub

        Public Sub Initialize()
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|�μ��ڵ�;DeptCd;100;;l;" & "io;n;n;10;"       '(10)
            gridAttributes = gridAttributes & "|�μ���;DeptNm;200;;l;" & "io;n;n;30;"       '(20)
            gridAttributes = gridAttributes & "|�μ�����;DeptLvl;100;;l;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|�����μ��ڵ�;ParentDeptCd;100;;l;" & "io;n;n;10;�μ� ��;ParentDeptNm;"       '(10)
            gridAttributes = gridAttributes & "|�����μ���;ParentDeptNm;200;;l;" & "o;n;n;30;"       '(20)
            gridAttributes = gridAttributes & "|��������;FinalYesOrNo;10;;c;" & "io;n;n;1;"       '(40)
            gridAttributes = gridAttributes & "|��뿩��;UseYN;10;;c;" & "io;n;n;1;"       '(40)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DeptLvl;�μ� ����"
            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
            Me.grd_1.ExplorerBar = 3

        End Sub

    End Class

End Namespace
