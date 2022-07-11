'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : ����� ���α׷� ������Ȳ
' form ���� : ����� ���α׷� ������Ȳ�� ��ȸ�Ѵ�.			
' �ۼ��� : Ȳ����
' �ۼ��� : 2007-02-02 �����
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

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMDA12
        Inherits CommonControls.UiControl

        Private Sub SMDA12_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()

            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "n;r;y;"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|���α׷�ID;UiId;100;;c;" & "o;n;n;6;"
            gridAttributes = gridAttributes & "|���α׷���;ProgramName;100;;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|�Ѱ�;Tot;100;#,##0;c;" & "o;n;n;30;"
            gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;100;;c;" & "o;n;n;6;"

            'grid code combo
            Dim gridCodeNameList As String = ""

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            '--------------------------------------------------

        End Sub


        Public Sub DynamicInitialize(ByRef reciveDataSet As DataSet)
            Dim intII As Integer = 0
            Dim intj As Integer = 0
            Dim intCol As Integer = 0

            Dim strColName As String = ""

            Me.grd_1.FixedRows = 1


            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""
            Dim strMerge As String = ""

            If reciveDataSet.Tables(1).Rows.Count <> 0 Then
                '���� mode(0 - �Ұ�, 1 - Ű����, 2 - Ű���� & ���콺); ���� mode(1 - cell, 2 - row); �ڵ� Size Y/N(1/0))
                With reciveDataSet.Tables(1)
                    gridAttributes = gridAttributes & "n;r;y"

                    'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
                    '& input outup io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code
                    gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
                    gridAttributes = gridAttributes & "|���α׷� ID;UiId;100;;l;" & "o;n;n;6;"
                    gridAttributes = gridAttributes & "|���α׷� ��;ProgramName;100;;l;" & "o;n;n;30;"
                    gridAttributes = gridAttributes & "|�Ѱ�;Tot;100;#,##0;c;" & "o;n;n;30;"

                    intCol = 0

                    ' �������� RoleCode�� �޾� �´�
                    For intII = 3 To .Columns.Count - 1
                        intCol += 1
                        strColName = .Rows(1).Item(intII).ToString
                        gridAttributes = gridAttributes & "|" & strColName & ";EmployeeNumber_" & VBN.Right("000" & CStr(intCol), 3) & ";100;#,###;c;" & "o;n;n;50;"
                    Next
                   
                End With

                gridAttributes = gridAttributes & "|;Dummy;100;;c;" & "o;n;n;30;"

                'grid code combo
                Dim gridCodeNameList As String = ""

                grd_1.Initialize(gridAttributes, gridCodeNameList)

                'Fixed �÷� Merge
                With Me.grd_1

                    .Rows = 2 '2���� ���� �̸� ����� ���´�

                    .FixedRows = 2
                    .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly

                    For intRows As Integer = 0 To reciveDataSet.Tables(1).Rows.Count - 1
                        For intCols As Integer = 0 To reciveDataSet.Tables(1).Columns.Count - 1
                            .set_TextMatrix(intRows, intCols + 2, reciveDataSet.Tables(1).Rows(intRows).Item(intCols).ToString)
                            ' SP ���� ó��..
                            '' �÷� ���� ���ٸ� ����~
                            'If .get_TextMatrix(intRows, intCols + 2) = "" Then
                            '    .set_ColHidden(intCols + 2, True)
                            'End If
                        Next
                    Next

                    For intC As Integer = 0 To 4
                        .set_MergeCol(intC, True)
                    Next
                    .set_MergeRow(0, True)
                End With

                Me.grd_1.ExplorerBar = 0
                Me.grd_1.ExplorerBar = 1
                'Me.grd_1.FixedCols = 4
            Else
                'grid�� �ʱ�ȭ �Ѵ�.
                '--------------------------------------------------
                gridAttributes = ""

                '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
                gridAttributes = gridAttributes & "n;r;y;"

                'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
                '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
                gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
                gridAttributes = gridAttributes & "|���α׷�ID;UiId;100;;c;" & "o;n;n;6;"
                gridAttributes = gridAttributes & "|���α׷���;ProgramName;100;;c;" & "o;n;n;30;"
                gridAttributes = gridAttributes & "|�Ѱ�;Tot;100;#,##0;c;" & "o;n;n;30;"
                gridAttributes = gridAttributes & "|��� ��ȣ;EmployeeNumber;100;;c;" & "o;n;n;6;"
                'grid code combo
                Dim gridCodeNameList As String = ""

                grd_1.Initialize(gridAttributes, gridCodeNameList)
                '--------------------------------------------------
            End If
            'End With
        End Sub
    End Class

End Namespace
