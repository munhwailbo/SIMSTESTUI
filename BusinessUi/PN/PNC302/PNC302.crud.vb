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

    Partial Class PNC302

        ''' <summary>
        ''' �Լ��� : NewData 
        ''' ��  �� : �ű� 
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub NewData()
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
            'GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
        End Sub
        ''' <summary>
        ''' �Լ��� : RequestData
        ''' ��  �� : ��ȸ
        ''' �ۼ��� : 
        ''' �ۼ��� : 
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="AprocessMessage"></param>
        ''' <remarks></remarks>
        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                .SetSqlParameter(GmainsqlParameters, "@AReaderNm", Me.txtReaderNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.dtpReceiptDt.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReaderCd", Me.txtReaderCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.cboDivCd.TextValue)
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_R", False, True, GmainsqlParameters)
                Me.grd_1.SetDataSet(reciveDataSet)
                reciveDataSet = Nothing
                .SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then .RequestDataMessage(Me)
            End With

        End Sub


        ''====================================================================================================
        'Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)

        '    GmainsqlParameters = Nothing
        '    With GmainCommonFunction
        '        .SetSqlParameter(GmainsqlParameters, "@AReaderCd", Me.grd_1.GetCurrentRowCellValue(""))
        '        Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_2_R", False, True, GmainsqlParameters)
        '        Me.grd_2.SetDataSet(reciveDataSet)
        '        reciveDataSet = Nothing
        '        .SetAllBusinessUiInitialValue(Me)
        '        If AprocessMessage = True Then .RequestDataMessage(Me)
        '    End With

        'End Sub

        '====================================================================================================
        Public Sub RequestData_2(Optional ByVal AprocessMessage As Boolean = True)
            GmainsqlParameters = Nothing
            With GmainCommonFunction
                GmainCommonFunction.ControlNewData(Me, Me.picIo_2_1)
                GmainCommonFunction.ControlNewData(Me, Me.picIo_2_2)
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AReceiptDt", Me.grd_1.GetCurrentRowCellValue("�ο�������"))
                'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ADivCd", Me.grd_1.GetCurrentRowCellValue("�ο������ڵ�"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@ASubscribeCd", Me.grd_1.GetCurrentRowCellValue("�����ڵ�"))
                GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOrders", Me.grd_1.GetCurrentRowCellValue("����"))
                Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_2_R", False, True, GmainsqlParameters)
                GmainCommonFunction.SetDataSetToControls(reciveDataSet, Me)

                Me.cboDivCd_1.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DivCd").ToString().Split(".")(0)
                'Me.cboIngStateCd.TextValue = reciveDataSet.Tables(0).Rows(0).Item("IngStateCd").ToString().Split(".")(0)

                reciveDataSet = Nothing
                GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
                If AprocessMessage = True Then GmainCommonFunction.RequestDataMessage(Me)
                'Me.cboDivCd_1.TextValue = reciveDataSet.Tables(0).Rows(0).Item("DivCd").ToString().Split(".")(0)




            End With
        End Sub

        Public Sub SaveData()
            GmainsqlParameters = Nothing

            'If Me.grd_1.GetCurrentRowCellValue("�����ڵ�") = dtpReceiptDt.TextValue Then
            '    GrecordProcessMode = 2
            'Else
            '    GrecordProcessMode = 1
            'End If
            With GmainCommonFunction

                .SetSqlParameter(GmainsqlParameters, "@ARecordprocessMode", GrecordProcessMode)
                .SetSqlParameter(GmainsqlParameters, "@ALoginId", GmainBusinessFunction.GetValue("�α��� ID"))
                .SetSqlParameter(GmainsqlParameters, "@AReceiptDt_1", dtpReceiptDt.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AOrders", txtOrders.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ADivCd_1", cboDivCd.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", txtReaderNmNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", txtPhoneNumNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AAddrNote", txtAddrNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", txtBranchNmNote.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AContent", txtContent.Text)
                .SetSqlParameter(GmainsqlParameters, "@ADeptNm", txtDeptNm.TextValue)
                .SetSqlParameter(GmainsqlParameters, "@AResultInformCd", cboResultInformCd.TextValue)          ' ���� �뺸
                .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", cboIngStateCd.TextValue)                  ' �������
                .SetSqlParameter(GmainsqlParameters, "@AResultNote", txtResultNote.TextValue)                  ' ó���ᱳ�� 
                .SetSqlParameter(GmainsqlParameters, "@AMonitoringProcDt", dtpMonitoringProcDt.TextValue)      ' ó������
                GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_CUD", True, False, GmainsqlParameters)

                ',   @AReceiptDt_1                               nvarchar(8)           ----(10)   ��������
                '   ,   @AOrders int
                '   ,   @ADivCd_1                                   nvarchar(10)          ----(50)   �ο������ڵ�
                '   ,   @AReaderNmNote                            nvarchar(100)         ----(60)   ���ڸ���
                '   ,   @APhoneNumNote                            nvarchar(30)          ----(70)   ��ȭ��ȣ���
                '   ,   @AAddrNote                                nvarchar(100)         ----(80)   �ּҺ��
                '   ,   @ABranchNmNote                            nvarchar(30)          ----(90)   ��������
                '   ,   @ADeptNm                                  nvarchar(30)          ----(100)  �θ�
                '   ,   @AContent                                 nvarchar(1000)        ----(110)  ����
                '   ,   @AResultInformCd                          nvarchar(10)          ----(120)  �����뺸�ڵ�
                '   ,   @AIngStateCd
                '   ,   @AResultNote                              nvarchar(1000)        ----(130)  ó�����
                '   ,   @AMonitoringProcDt                        nvarchar(8)           ----(150)  �����ó������

                .SetAllBusinessUiInitialValue(Me)
                '' .SaveDataMessage(Me)
            End With
            If GmainExecuteDbCommand.GerrorNumber = 0 Then
                GmainCommonFunction.SaveDataMessage(Me)
            Else
                MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End Sub



        Public Sub DeleteData()

            Dim result As DialogResult
            result = MessageBox.Show("����Ÿ�� ���� �Ͻðڽ��ϱ�?", Me.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then   '' Result Start
                GmainsqlParameters = Nothing
                GrecordProcessMode = 3
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARecordprocessMode", GrecordProcessMode)
                    .SetSqlParameter(GmainsqlParameters, "@ALoginId", GmainBusinessFunction.GetValue("�α��� ID"))
                    .SetSqlParameter(GmainsqlParameters, "@AReceiptDt_1", dtpReceiptDt.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ADivCd_1", cboDivCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AReaderNmNote", txtReaderNmNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@APhoneNumNote", txtPhoneNumNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AAddrNote", txtAddrNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@ABranchNmNote", txtBranchNmNote.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AContent", txtContent.Text)
                    .SetSqlParameter(GmainsqlParameters, "@ADeptNm", txtDeptNm.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AResultInformCd", cboResultInformCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AIngStateCd", cboIngStateCd.TextValue)
                    .SetSqlParameter(GmainsqlParameters, "@AResultNote", txtResultNote.TextValue)

                    GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "PNC302_3_CUD", True, False, GmainsqlParameters)
                    .SetAllBusinessUiInitialValue(Me)
                    '' .SaveDataMessage(Me)
                End With
                If GmainExecuteDbCommand.GerrorNumber = 0 Then
                    MessageBox.Show("����Ÿ�� ���� �Ǿ����ϴ�", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(GmainExecuteDbCommand.GerrorDescription, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If   '' Result end

        End Sub

    End Class

End Namespace