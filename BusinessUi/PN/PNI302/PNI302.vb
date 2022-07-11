' ////////////////////////////////////////////////////////////////////////////////////////////////////
' form�� : 
' form���� :
' �ۼ��� : 
' �ۼ��� : 
' ////////////////////////////////////////////////////////////////////////////////////////////////////

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

Imports ubiLease.CommonFunction
Imports ubiLease.CommonControls
Imports ubiLease.GridControl
Imports ubiLease.DAT

Imports System.Reflection

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNI302
        Inherits CommonControls.UiControl

#Region "�� �ʱ�ȭ"

        Public Sub Initialize()

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input out'put); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code

            gridAttributes = gridAttributes & "||����;����;90;;1;" & "i;n;y;;;"
            gridAttributes = gridAttributes & "|�Ա�����;ColDt;85;yyyy-MM-dd;c;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;ColOrders;0;;7;" & "o;n;y;5;"
            gridAttributes = gridAttributes & "|�Աݱ����ڵ�;ColTypeCd;155;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�Աݰ��¹�ȣ;ColBankCd;170;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|���¹�ȣ;ColAccountNum;0;;4;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|�Ա��ڸ�;Recipient;66;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�Աݱݾ�;ColAmt;62;#,###;7;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|����;Note;90;;1;" & "o;n;n;5;"
            gridAttributes = gridAttributes & "|�����Աݳ��;CalYearMonths;87;yyyy-MM;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|������ȣ;BranchNum;76;;4;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;0;;4;" & "o;n;y;40;"
            gridAttributes = gridAttributes & "|������;BranchNm;50;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�����强��;BranchChiefCdName;74;;4;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|��������;ChargeEmpNm;74;;1;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|�Աݴ���;ProcEmpNm;74;;1;" & "o;n;n;40;"
            gridAttributes = gridAttributes & "|�������ڵ�;BranchChiefCd;84;;4;" & "o;n;n;40;�������ڵ�;BranchChiefCdName "
            gridAttributes = gridAttributes & "|�������;ChargeEmpNum;62;;4;" & "o;n;n;10;�����ȣ;ChargeEmpNm"
            gridAttributes = gridAttributes & "|�Աݴ����;ProcEmpNum;87;;4;" & "o;n;n;40; "
            gridAttributes = gridAttributes & "|;Jiral;85;;1;" & "o;n;n;40;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "ColBankCd;�Աݰ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ColTypeCd;�Աݱ����ڵ�"
            'gridCodeNameList = gridCodeNameList & "ProjectID;������Ʈ ��"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

            lblRecordState.Text = "�غ�"
            Me.grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 3

            Me.NewData()

        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : ACA003_Load 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNI302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region


    End Class

End Namespace
