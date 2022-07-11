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

    Partial Class SMBA01

        ''' <summary>
        ''' �Լ��� : NewData_2 
        ''' ��  �� : �ű�
        ''' �ۼ��� : 
        ''' �ۼ��� : 2006-08-17
        ''' ������ : 
        ''' ������ :        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData_2()
            Me.grd_2.AddRow()
            Me.grd_2.SetCellCheck(Me.grd_2.Rows - 1, Me.grd_2.get_ColIndex("PrivateUseYesOrNo"), C1.Win.C1FlexGrid.CheckEnum.Checked)
        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData_2 
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 2006-08-17
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcodeDivision", Me.grd_1.get_TextMatrix(grd_1.Row, 2))

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBA01_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                'Me.grd_2.SetDataSetsToGrid(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With
        End Sub
        ''' <summary>
        ''' �Լ��� : SaveData_2 
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2006-08-17
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData_2()
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcodeDivision", Me.grd_1.get_TextMatrix(grd_1.Row, 2))
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBA01_2_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)

                Me.RequestData_2()
            End With
        End Sub
        ''' <summary>
        ''' �Լ��� : DeleteData_2
        ''' ��  �� : ����
        ''' �ۼ��� : 
        ''' �ۼ��� : 2006-08-17
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData_2()

            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AcodeDivision", Me.grd_1.get_TextMatrix(grd_1.Row, 2))
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMBA01_2_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .DeleteDataMessage(Me)
                Me.RequestData_2()
            End With
        End Sub

    End Class

End Namespace
