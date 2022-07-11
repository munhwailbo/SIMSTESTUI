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

Namespace ubiLease.UI.BusinessUi.SM

    Partial Class SMCB03

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            If Me.grd_1.Rows > Me.grd_1.FixedRows Then
                If Me.grd_2.Focused Then
                    NewData_2()
                    'grd_2.set_TextMatrix(grd_2.BottomRow, grd_2.get_ColIndex("RoleCode"), cboRoleCode.TextValue)
                    grd_2.set_TextMatrix(grd_2.BottomRow, grd_2.get_ColIndex("EmployeeNumber"), grd_1.get_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("EmployeeNumber")))
                    grd_2.set_TextMatrix(grd_2.BottomRow, grd_2.get_ColIndex("EmployeeNameHangul"), grd_1.get_TextMatrix(grd_1.RowSel, grd_1.get_ColIndex("EmployeeNameHangul")))
                End If
            Else
                MessageBox.Show("���õ� ����� �������� �ʽ��ϴ�.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB03_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet2(reciveDataSet, 1, True)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub
        ''' <summary>
        ''' �Լ��� : SaveData 
        ''' ��  �� : ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()
            'If grd_2.Focused Then
            SaveData_2()
            'End If
        End Sub
        ''' <summary>
        ''' �Լ��� : DeleteData 
        ''' ��  �� : ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2006-09-02
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB03_2_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .DeleteDataMessage(Me)
            End With

        End Sub

        
    End Class

End Namespace
