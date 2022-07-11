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

    Public Class PNC302
        Inherits CommonControls.UiControl
        '====================================================================================================
        Private Sub PNC302_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|����;Orders;40;;;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|�����ڵ�;ReaderCd;40;;;" & "o;n;n;8;"       '(10)
            gridAttributes = gridAttributes & "|���ڸ�;ReaderNm;40;;;" & "o;n;n;10;"       '(20)           
            gridAttributes = gridAttributes & "|�ο������ڵ�;DivCd;40;;;" & "o;n;n;10;"       '(40)          
            gridAttributes = gridAttributes & "|�ο�������;ReceiptDt;40;;;" & "o;n;n;50;"       '(60)
            gridAttributes = gridAttributes & "|���ڱ����ڵ�;ReaderDivCd;40;;;" & "io;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|���ڻ����ڵ�;ReaderStateCd;40;;;" & "io;n;n;10;"       '(30)
            gridAttributes = gridAttributes & "|Ȯ�屸���ڵ�;ExpandDivCd;40;;;" & "io;n;n;10;"       '(40)
            gridAttributes = gridAttributes & "|��������;FixedStDt;40;;;" & "io;n;n;8;"       '(50)
            gridAttributes = gridAttributes & "|���Ժμ�;SubscribePagerNum;40;;;" & "io;n;n;4;"       '(60)
            gridAttributes = gridAttributes & "|��ȭ��ȣ1;PhoneNum1;40;;;" & "io;n;n;30;"       '(80)
            gridAttributes = gridAttributes & "|�ſ����ȣ;NewPostNum;40;;;" & "io;n;n;10;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;90;;c;" & "o;n;y;5;"       '(90)
            gridAttributes = gridAttributes & "|���ּ�;NewAddr1;50;;;" & "io;n;n;50;"       '(100)
            gridAttributes = gridAttributes & "|�������ȣ;OldPostNum;40;;;" & "io;n;n;10;�����ȣ;CodeHangulName"
            gridAttributes = gridAttributes & "|�ּ�;CodeHangulName;90;;c;" & "o;n;y;5;"       '(110)
            gridAttributes = gridAttributes & "|���ּ�;OldAddr1;50;;;" & "io;n;n;50;"       '(120)
            gridAttributes = gridAttributes & "|�����ڵ�;SubscribeCd;50;;;" & "io;n;n;50;"       '(120)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "DivCd;�ο������ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReaderDivCd;���ڱ����ڵ�"
            gridCodeNameList = gridCodeNameList & "/ReaderStateCd;���ڻ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")


         

        End Sub



      
    End Class

End Namespace
