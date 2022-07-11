'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : Table ���� ���
' form ���� : Table ���� ��� �߰�, ����, ����, ��ȸ�Ѵ�.
' �ۼ��� : Ȳ����
' �ۼ��� : 2006-07-04
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

Imports System.Text
Imports System.IO

Namespace ubiLease.UI.BusinessUi.SM

    Public Class SMEB02
        Inherits CommonControls.UiControl

        Private Sub SMEB02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Dock = DockStyle.Fill
        End Sub

        '====================================================================================================
        Public Sub Initialize()
            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String
            Dim gridCodeNameList As String

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = ""
            gridCodeNameList = ""
            gridAttributes = gridAttributes & "n;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|ObjectType;ObjectType;1000;;c;" & "o;n;n;2"
            gridAttributes = gridAttributes & "|ObjectId;ObjectId;500;;l;" & "o;n;n;10"
            gridAttributes = gridAttributes & "|ObjectName;ObjectName;500;;l;" & "o;n;n;2"

            grd_1.Initialize(gridAttributes, gridCodeNameList)
            grd_1.ExplorerBar = 0
            grd_1.ExplorerBar = 1

            'gridAttributes = ""
            'gridCodeNameList = ""

            ''���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            'gridAttributes = gridAttributes & "n;r;y"

            ''ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            ''& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            'gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            'gridAttributes = gridAttributes & "|���� ����;SystemDivision;1000;;c;" & "o;n;y;6"
            'gridAttributes = gridAttributes & "|���̺� ID;TableName;500;;l;" & "o;n;y;2"
            'gridAttributes = gridAttributes & "|���̺� ��;TableDesc;500;;l;" & "o;n;y;50"
            'gridAttributes = gridAttributes & "|ID;ColumnID;500;#,###;c;" & "o;n;n;5;"
            'gridAttributes = gridAttributes & "|�÷� ��;ColumnName;2000;;l;" & "o;n;n;50"
            'gridAttributes = gridAttributes & "|�÷� ����;ColumnDesc;100;;l;" & "o;n;n;1"
            'gridAttributes = gridAttributes & "|Ÿ��;Type;500;;c;" & "o;n;n;5"
            'gridAttributes = gridAttributes & "|����;Length;500;;c;" & "o;n;n;2"
            'gridAttributes = gridAttributes & "|���� ����;TableOrder;500;;c;" & "o;n;y;50"
            'gridAttributes = gridAttributes & "|Null ����;Is_Null;100;;c;" & "o;n;n;1"

            'grd_2.Initialize(gridAttributes, gridCodeNameList)
            'grd_2.ExplorerBar = 3

            Me.txtPath.Text = "C:\irisDBscript"

        End Sub

        Private Sub btnTaxBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaxBill.Click
            Dim AprocessMessage = True

            'Validation
            'If fnValidation() = False Then
            '    Exit Sub
            'End If

            If MessageBox.Show("��ũ��Ʈ ������ �����Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Exit Sub
            End If

            'GmainsqlParameters = Nothing
            'With GmainCommonFunction
            '    .SetSqlParameter(GmainsqlParameters, "@AreportYears", Me.dtpReportYears.TextValue)
            '    .SetSqlParameter(GmainsqlParameters, "@AreportGubun", Me.cboReportDivisionCode.TextValue)

            '    Using reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("AC","ACG009_2_R", False, True, GmainsqlParameters)
            '        .SetDataSetToControls(reciveDataSet, Me)

            '        '�ش� �����Ͱ� ���� ���� ����� ���� ���븸 �����Ƿ� ����� 3���� Ŀ���Ѵ�.
            '        If reciveDataSet.Tables(0).Rows.Count < 4 Then
            '            MessageBox.Show("��꼭 ���� ��ü�� ������ �����Ͱ� �����ϴ�." + vbCrLf + "��꼭 �����Ͱ� �����Ǿ����� Ȯ���� �ֽʽÿ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '            Exit Sub
            '        End If

            If Me.txtContents.Text.Trim() = "" Then
                MessageBox.Show("������ ��ũ��Ʈ ������ �����ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            '���� ��ü ���� ����
            If WriteMediaText(Me.grd_1.GetCurrentRowCellValue("ObjectName")) = True Then
                MessageBox.Show("��ũ��Ʈ ������ ���������� �����߽��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("��ũ��Ʈ ���� ������ �����߽��ϴ�. �ٽ� �õ��� �ֽʽÿ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Cursor = Cursors.Default
            '    End Using

            '.SetAllBusinessUiInitialValue(Me)
            'If AprocessMessage = True Then .RequestDataMessage(Me)

            'End With

        End Sub
        '====================================================================================================
        ' �����ü ���� �ۼ�
        '====================================================================================================
        Public Function WriteMediaText(ByVal strFileName As String) As Boolean
            Dim strFileFullPath As String   '���� ���� ���

            Try
                WriteMediaText = False

                ''���ϸ��� ������������ �������� ����� ��ȣ�� �����´�.
                'If mediaGubun = "1" Then        '���ݰ�꼭
                '    strFileName = ds.Tables(0).Rows(0)("MediaText").ToString().Substring(1, 10)
                'ElseIf mediaGubun = "2" Then    '��꼭
                '    strFileName = ds.Tables(0).Rows(0)("MediaText").ToString().Substring(19, 10)
                'ElseIf mediaGubun = "3" Then    '�ſ�ī�������ǥ
                '    strFileName = ds.Tables(0).Rows(0)("MediaText").ToString().Substring(8, 10)
                'End If

                'If mediaGubun = "1" Then
                '    strPrefix = "K"
                'ElseIf mediaGubun = "2" Then
                '    strPrefix = "H"
                'ElseIf mediaGubun = "3" Then
                '    strPrefix = "J"
                'End If

                '�����ü ����( K(���ݰ�꼭) �Ǵ� H(��꼭) + ����ڹ�ȣ(�������� 7�ڸ� ����) + "." + ����ڹ�ȣ(�������� 3�ڸ� ����)   
                strFileName = strFileName + "." + "sql"

                '���� ��� Full PATH
                strFileFullPath = Me.txtPath.Text + "\" + strFileName

                '�����ϴ� ������ �������� ���θ� ���� ������ �����Ѵ�.
                If File.Exists(strFileFullPath) = True Then
                    If MessageBox.Show("������ ������ ��ũ��Ʈ ������ �����մϴ�." + vbCrLf + "�����ϰ� �ٽ� �����Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        File.Delete(strFileFullPath)

                        'Using (ds)
                        '    '������ ����� LOOP�� ���鼭 �ؽ�Ʈ�� �ۼ��Ѵ�.
                        '    For inti = 0 To ds.Tables(0).Rows.Count - 1
                        File.AppendAllText(strFileFullPath, Me.txtContents.Text, Encoding.Default)
                        '    Next inti

                        'End Using
                    End If
                Else
                    'Using (ds)
                    '���丮�� �������� �ʴ´ٸ� �����Ѵ�.
                    If Directory.Exists(Me.txtPath.Text) = False Then
                        Directory.CreateDirectory(Me.txtPath.Text)
                    End If

                    '������ ����� LOOP�� ���鼭 �ؽ�Ʈ�� �ۼ��Ѵ�.    
                    'For inti = 0 To ds.Tables(0).Rows.Count - 1
                    File.AppendAllText(strFileFullPath, Me.txtContents.Text, Encoding.Default)
                    'Next inti
                    'End Using

                End If

                WriteMediaText = True

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Function
        ''====================================================================================================
        '' ��Ʈ���� �� Validation
        ''====================================================================================================
        'Public Function fnValidation() As Boolean
        '    fnValidation = False

        '    '�Ű�⵵ üũ
        '    If Me.dtpReportYears.TextValue = "" Or Me.dtpReportYears.TextValue.Length <> 4 Then
        '        MessageBox.Show("�Ű�⵵�� ������ �ֽ��ϴ�. �ٽ� �Է��� �ֽʽÿ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        dtpReportYears.Focus()
        '        Exit Function
        '    End If

        '    '�Ű��� üũ
        '    If Me.cboReportDivisionCode.TextValue = "" Then
        '        MessageBox.Show("�Ű� ������ ������ �ֽʽÿ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        cboReportDivisionCode.Focus()
        '        Exit Function
        '    End If

        '    fnValidation = True
        'End Function

        Private Sub btnSearchDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchDir.Click
            FolderBrowserDialog1.SelectedPath() = "C:\"

            If FolderBrowserDialog1.ShowDialog <> DialogResult.Cancel Then
                Me.txtPath.Text = FolderBrowserDialog1.SelectedPath()
            End If
        End Sub
    End Class

End Namespace
