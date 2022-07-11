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
        ''' 함수명 : NewData_2 
        ''' 기  능 : 삭제
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData_2()
            Me.grd_2.AddRow()
            If Me.grd_2.BottomRow > 0 Then
                Me.grd_2.Select(Me.grd_2.BottomRow, 0)
            End If
        End Sub
        ''' <summary>
        ''' 함수명 : RequestData_2 
        ''' 기  능 : 삭제
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AEmployeeNumber", Me.grd_1.get_TextMatrix(grd_1.Row, grd_1.get_ColIndex("EmployeeNumber")))
                .SetSqlParameter(GmainsqlParameters, "@ARoleCode", Me.cboRoleCode.TextValue)

                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB03_2_R", False, True, GmainsqlParameters)
                Me.grd_2.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing

                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub
        ''' <summary>
        ''' 함수명 : SaveData_2 
        ''' 기  능 : 삭제
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData_2()
            GmainsqlParameters = Nothing

            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(False))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB03_2_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .SaveDataMessage(Me)
            End With

        End Sub
        
    End Class

End Namespace
