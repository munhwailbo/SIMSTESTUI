'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form �?:  [PNA205]?�?�코?�등�?
' form ?�명 :  [PNA205]?�?�코?�등�?
' ?�성??: 
' ?�성??: 2011-06-28 ?�후 1:34:53
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

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

Namespace ubiLease.UI.BusinessUi.AC

    Public Class PNA205
        Inherits CommonControls.UiControl

        ''' <summary>
        ''' ?�수�?: Initialize
        ''' 리턴�?: 
        ''' �? ??: ??�?그리??초기??
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            Dim gridAttributes As String = ""

            '���� mode(0 - �Ұ�, 1 - Ű����, 2 - Ű���� & ���콺); ���� mode(1 - cell, 2 - row); �ڵ� Size Y/N(1/0))
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|�ŷ�ó �ڵ�;CustomerCode;0;;l;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|�ŷ�ó ��;FirmName;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|���λ���� ����;IndividualBizDivision;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|����ڹ�ȣ;BizRegNumber;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�ֹι�ȣ;ResRegNumber;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|�ŷ�ó ����;CustomerDivision;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|����;BizCondition;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|����;BizItem;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|���� ����;DeleteYesOrNo;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "| ;dummy;60;;l;" & "o;n;n;6;"

            'Set Grid Combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "IndividualBizDivision;���� ����� ���� ��"
            'gridCodeNameList = gridCodeNameList & "/CustomerDivision;�ŷ�ó ���� ��"

            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
            Me.grd_1.FrozenCols = 3

        End Sub
        ''' <summary>
        ''' ?�수�?: PNA205_Load
        ''' 리턴�?: 
        ''' �? ??: Dock
        ''' ?�성??: 
        ''' ?�성??: 2012-07-19
        ''' ?�정??: 
        ''' ?�정??: 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PNA205_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Me.DesignMode = False Then
                Me.Dock = DockStyle.Fill
                '' ''         Me.MinimumSize = New System.Drawing.Size(800, 640) 
            End If
        End Sub
      
        Private Sub btnCodeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodeIn.Click
            Call SaveData()
        End Sub
  
    End Class
End Namespace