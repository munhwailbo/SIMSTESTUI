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

    Public Class PNC303
        Inherits CommonControls.UiControl
        '====================================================================================================
        Private Sub PNC303_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
            End If
        End Sub

        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "k;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|��������;ReceiptDt;80;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;50;;;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|���ڸ�;ReaderNm;80;;;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|����;Orders;40;;r;" & "o;n;n;4;"
            gridAttributes = gridAttributes & "|�ο������ڵ�;DivCd;100;;l;" & "o;n;n;10;"           
            gridAttributes = gridAttributes & "|���ڸ���;ReaderNmNote;200;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ���;PhoneNumNote;200;;l;" & "o;n;n;30;"          
            gridAttributes = gridAttributes & "|�ּҺ��;AddrNote;200;;l;" & "o;n;n;100;"
            gridAttributes = gridAttributes & "|��������;BranchNmNote;200;;l;" & "o;n;n;30;"           
            gridAttributes = gridAttributes & "|�θ�;DeptNm;200;;l;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|����;Content;200;;l;" & "o;n;n;1000;"
            gridAttributes = gridAttributes & "|�����뺸�ڵ�;ResultInformCd;100;;l;" & "o;n;n;10;"
            gridAttributes = gridAttributes & "|ó�����;ResultNote;200;;l;" & "o;n;n;1000;"
            gridAttributes = gridAttributes & "|�����ó������;MonitoringProcDt;100;;l;" & "o;n;n;8;"
            gridAttributes = gridAttributes & "|��������ڵ�;IngStateCd;100;;l;" & "o;n;n;10;"
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")
        End Sub

    End Class

End Namespace
