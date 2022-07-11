'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �ڵ����
' form ���� : ��ȭ�Ϻ� �ڵ� ����
' �ۼ��� : ������
' �ۼ��� : 2008.09.01
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

Namespace ubiLease.UI.BusinessUi.BM

    Public Class BMB102
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"
        ''' <summary>
        ''' �Լ��� : Initialize
        ''' ��  �� : �� �� �׸��� �ʱ�ȭ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2008.09.01
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�μ�;DeptNm;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�����;ChargeEmpNumNm;1253;;l;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|������ �ڵ�;BranchChiefCd;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|������ ��;BranchChiefCdName;1253;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;Orders;1253;;l;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|���γ��;MutualYearMonth;1253;####-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����ȸ��;MutualSocietyDues;1253;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���ο���;MutualYesOrNo;1253;#,##0;r;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|���αݾ�;MutualAmount;1253;#,##0;r;" & "o;n;n;5;"

            gridAttributes = gridAttributes & "|���������ڵ�;MutualBranchCode;3000;;l;" & "o;n;y;200;�����ڵ�;MutualBranchCodeName"
            gridAttributes = gridAttributes & "|����������;MutualBranchCodeName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|�������;SideJobBranchName;3000;;l;" & "o;n;n;200;"
            gridAttributes = gridAttributes & "|����;Note;1358;;l;" & "o;n;n;10;"

            gridAttributes = gridAttributes & "|��������;JoinDate;80;####-##-##;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|Ż������;SecessionDate;70;####-##-##;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|Ż�𿩺�;SecessionYON;50;;l;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|;Dumi;50;;l;" & "o;n;n"

            'grid code combo
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            Me.grd_1.ExplorerBar = 3
            '--------------------------------------------------
            Me.chkPaymentPerson.Checked = True
        End Sub
#End Region

#Region "�� �̺�Ʈ"

        Private Sub BMB102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Dock = DockStyle.Fill
        End Sub

#End Region

        Private Sub chkPaymentPerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaymentPerson.CheckedChanged
            If chkPaymentPerson.Visible Then
                If chkPaymentPerson.Checked = False And chkPersonInArrears.Checked = False Then
                    chkPaymentPerson.Checked = True
                End If
            End If
        End Sub

        Private Sub chkPersonInArrears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonInArrears.CheckedChanged
            If chkPersonInArrears.Visible Then
                If chkPersonInArrears.Checked = False And chkPaymentPerson.Checked = False Then
                    chkPersonInArrears.Checked = True
                End If
            End If
        End Sub
    End Class

End Namespace
