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

Namespace ubiLease.UI.BusinessUi.PN

    Public Class PNJ205
        Inherits CommonControls.UiControl

        Private Sub PNJ205_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

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
            sbGridInit()
        End Sub

        Private Sub sbGridInit()

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|����;TreePath;80;;l;" & "io;n;n;5;"   ''  
            '' '' ===============================================================================
            '' '' optMode1 : �Ҽӻ纰,  optMode2 : �ŷ�����,  optMode3 : �ŷ���/�Ҽӻ纰
            If Me.optMode1.Checked = True Then '' optMode1 : �Ҽӻ纰,  optMode2 : �ŷ�����,  optMode3 : �ŷ���/�Ҽӻ纰
                gridAttributes = gridAttributes & "|�����;ChargeEmpNum;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|����;ChargeEmpNm;70;;l;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�ŷ���;BranchCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�ŷ�����;BranchNm;70;;l;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;120;;l;" & "o;n;n;40;"
            End If
            If Me.optMode2.Checked = True Then '' optMode1 : �Ҽӻ纰,  optMode2 : �ŷ�����,  optMode3 : �ŷ���/�Ҽӻ纰
                gridAttributes = gridAttributes & "|�����;ChargeEmpNum;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|����;ChargeEmpNm;70;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|�ŷ���;BranchCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�ŷ�����;BranchNm;120;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;120;;l;" & "o;n;y;40;"
            End If
            If Me.optMode3.Checked = True Then '' optMode1 : �Ҽӻ纰,  optMode2 : �ŷ�����,  optMode3 : �ŷ���/�Ҽӻ纰
                gridAttributes = gridAttributes & "|�����;ChargeEmpNum;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|����;ChargeEmpNm;70;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|�ŷ���;BranchCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�ŷ�����;BranchNm;70;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|�Ҽӻ��ڵ�;CouponCorpCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|�Ҽӻ��;CouponCorpNm;120;;l;" & "o;n;n;40;"
            End If

            gridAttributes = gridAttributes & "|�ݾ�;Amount;80;#,###;c;" & "o;n;n;5;"   ''  
            gridAttributes = gridAttributes & "|TOTAL;total;80;#,###;c;" & "o;n;n;5;"   ''  
            '' =============================================================================
            '' ���� �ʵ� ó��
            '' =============================================================================
            If Me.dtpRedeemDt.TextValue.ToString.Length > 1 Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt", Me.dtpRedeemDt.TextValue)      ' ȸ�����
                    Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNJ205_9_R", False, True, GmainsqlParameters)
                    If reciveDataSet.Tables.Count > 0 Then
                        For intII As Integer = 0 To reciveDataSet.Tables(0).Columns.Count - 1
                            gridAttributes = gridAttributes & "|" & reciveDataSet.Tables(0).Rows(0)(intII).ToString() & ";cnt_" & (intII + 1).ToString() & ";70;#,###;r;" & "o;n;n;40;"
                        Next
                    End If
                    reciveDataSet = Nothing
                End With
            End If
            '' =============================================================================
            gridAttributes = gridAttributes & "|����;SortOrders;80;;c;" & "o;n;y;5;"   ''  
            gridAttributes = gridAttributes & "|;mErONG;90;;l;" & "o;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "ProjectID;������Ʈ ��"
            'gridCodeNameList = gridCodeNameList & "SolicitorDivCd;�����ڱ����ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------
            grd_1.ExplorerBar = 3

        End Sub

#End Region

 
        Private Sub optMode1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMode1.CheckedChanged
            sbGridInit()
        End Sub

        Private Sub optMode2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMode2.CheckedChanged
            sbGridInit()
        End Sub

        Private Sub optMode3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMode3.CheckedChanged
            sbGridInit()
        End Sub
    End Class

End Namespace
