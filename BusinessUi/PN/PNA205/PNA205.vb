'//////////////////////////////////////////////////////////////////////////////////////////////////// 
' form ëª?:  [PNA205]?€?‰ì½”?œë“±ë¡?
' form ?¤ëª… :  [PNA205]?€?‰ì½”?œë“±ë¡?
' ?‘ì„±??: 
' ?‘ì„±??: 2011-06-28 ?¤í›„ 1:34:53
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
        ''' ?¨ìˆ˜ëª?: Initialize
        ''' ë¦¬í„´ê°?: 
        ''' ê¸? ??: ??ë°?ê·¸ë¦¬??ì´ˆê¸°??
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()

            'VSFlexGrid¸¦ ÃÊ±âÈ­ ÇÑ´Ù.
            Dim gridAttributes As String = ""

            '¼öÁ¤ mode(0 - ºÒ°¡, 1 - Å°º¸µå, 2 - Å°º¸µå & ¸¶¿ì½º); ¼±ÅÃ mode(1 - cell, 2 - row); ÀÚµ¿ Size Y/N(1/0))
            gridAttributes = gridAttributes & "n;r;y"

            'È­¸é ¸íÄª; key ¸íÄª; ³ÐÀÌ; format; Á¤·Ä(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input outup io (i:input/o:output); ÇÊ¼ö ÀÔ·Â y/n; ¼û±â±â y/n; ÃÖ´ë ¹®ÀÚ ±æÀÌ; popup code
            gridAttributes = gridAttributes & "||¼±ÅÃ;¼±ÅÃ;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|°Å·¡Ã³ ÄÚµå;CustomerCode;0;;l;" & "o;n;n;2;"
            gridAttributes = gridAttributes & "|°Å·¡Ã³ ¸í;FirmName;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|°³ÀÎ»ç¾÷ÀÚ ±¸ºÐ;IndividualBizDivision;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|»ç¾÷ÀÚ¹øÈ£;BizRegNumber;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|ÁÖ¹Î¹øÈ£;ResRegNumber;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|°Å·¡Ã³ ±¸ºÐ;CustomerDivision;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|¾÷ÅÂ;BizCondition;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|Á¾¸ñ;BizItem;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|»èÁ¦ ¿©ºÎ;DeleteYesOrNo;60;;l;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "| ;dummy;60;;l;" & "o;n;n;6;"

            'Set Grid Combo
            Dim gridCodeNameList As String = ""
            'gridCodeNameList = gridCodeNameList & "IndividualBizDivision;°³ÀÎ »ç¾÷ÀÚ ±¸ºÐ ¸í"
            'gridCodeNameList = gridCodeNameList & "/CustomerDivision;°Å·¡Ã³ ±¸ºÐ ¸í"

            Me.grd_1.Initialize(gridAttributes, gridCodeNameList)

            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExplorerBar = 1
            Me.grd_1.FrozenCols = 3

        End Sub
        ''' <summary>
        ''' ?¨ìˆ˜ëª?: PNA205_Load
        ''' ë¦¬í„´ê°?: 
        ''' ê¸? ??: Dock
        ''' ?‘ì„±??: 
        ''' ?‘ì„±??: 2012-07-19
        ''' ?˜ì •??: 
        ''' ?˜ì •??: 
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