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

    Public Class PND201
        Inherits CommonControls.UiControl
        '====================================================================================================
        

#Region "�� �ʱ�ȭ"

        Public Sub Initialize()
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;n;"
            gridAttributes = gridAttributes & "|Pkey;PKey;10;;c;" & "o;n;y;4;"       '(10)
            gridAttributes = gridAttributes & "|ȸ��;MtOrders;100;;c;" & "o;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|����;MtDesc;400;;l;" & "o;n;n;4;"       '(20)
            gridAttributes = gridAttributes & "|ȸ�� ����;MtDate;100;;l;" & "o;n;n;8;"       '(30)
            gridAttributes = gridAttributes & "| ;Remark;150;;l;" & "o;n;n;50;"       '(80)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")


        End Sub
#End Region

#Region "�� �̺�Ʈ"
        ''' <summary>
        ''' �Լ��� : 
        ''' ��  �� : Form Dock ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PND201_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub
#End Region

        
        
     
        Private Sub picIo_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picIo_2.Click

        End Sub
    End Class

End Namespace
