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
        ''' 함수명 : NewData 
        ''' 기  능 : 신규 
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
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
                MessageBox.Show("선택된 사원이 존재하지 않습니다.", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub
        ''' <summary>
        ''' 함수명 : RequestData
        ''' 기  능 : 조회
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
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
        ''' 함수명 : SaveData 
        ''' 기  능 : 저장
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub SaveData()
            'If grd_2.Focused Then
            SaveData_2()
            'End If
        End Sub
        ''' <summary>
        ''' 함수명 : DeleteData 
        ''' 기  능 : 삭제
        ''' 작성자 : 신현갑
        ''' 작성일 : 2006-09-02
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub DeleteData()
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AloginId", GmainBusinessFunction.GetValue("로그인 ID"))
                .SetSqlParameter(GmainsqlParameters, "@AxmlContext", Me.grd_2.GetXmlData(True))

                GmainExecuteDbCommand.ExecuteStoredProcedure("SM","SMCB03_2_CUD", True, False, GmainsqlParameters)

                .SetAllBusinessUiInitialValue(Me)
                .DeleteDataMessage(Me)
            End With

        End Sub

        
    End Class

End Namespace
