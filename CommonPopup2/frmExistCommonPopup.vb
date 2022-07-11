Imports Microsoft.VisualBasic
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports ubiLease.CommonFunction
Imports ubiLease.DAT


Namespace ubiLease.CommonPopup

    Public Class frmExistReader

        Private GmainExecuteDbCommand As ubiLease.DAT.ExecuteDbCommand = New ubiLease.DAT.ExecuteDbCommand
        Private GmainsqlParameters() As SqlParameter
        Private GmainCommonFunction As ubiLease.CommonFunction.Common = New ubiLease.CommonFunction.Common

        Private _DokjaName As String

        Public Property DokjaName() As String
            Get
                Return _DokjaName
            End Get
            Set(ByVal value As String)
                _DokjaName = value
            End Set
        End Property

        Private _Addr As String

        Public Property strAddr() As String
            Get
                Return _Addr
            End Get
            Set(ByVal value As String)
                _Addr = value
            End Set
        End Property

        Private _TelNum As String

        Public Property strTelNum() As String
            Get
                Return _TelNum
            End Get
            Set(ByVal value As String)
                _TelNum = value
            End Set
        End Property



        Public Sub RequestData(Optional ByVal AprocessMessage As Boolean = True)

            GmainsqlParameters = Nothing

            Dim ���ڸ� As String = txtDokName.TextValue
            Dim �ּ� As String = TxtAddr.TextValue
            Dim ��ȭ��ȣ As String = txtTelNum.TextValue
            Dim ���ŵ��ڿ��� As String = ""
            Dim ���絶�ڿ��� As String = ""
            Dim ����Ȯ�����Կ��� As String = ""
            Dim ���Ȯ�����Կ��� As String = ""

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Adokname", ���ڸ�)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Aaddr", �ּ�)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Atel", ��ȭ��ȣ)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOldOnly", ���ŵ��ڿ���)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APresentOnly", ���絶�ڿ���)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AJisaInclude", ����Ȯ�����Կ���)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmpInclude", ���Ȯ�����Կ���)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "ExistReaderList", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub
        Private Sub btnRequestData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestData.Click


            RequestData(True)


        End Sub

        Private Sub frmExistReader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


            'grid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|Ȯ�屸��;dokjagu;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|��������;bancd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|���ڸ�;dokname;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|��ȭ��ȣ;tel;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|���Ժμ�;busu;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|�����ȣ;post;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|�ּ�;addr1;200;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|���ּ�;addr2;200;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|��������;kymd;100;yyyy-MM-dd;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|����������;jymd;100;yyyy-MM-dd;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|���ݳ��;sym;100;yyyy-MM;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|��������;bymd;100;yyyy-MM-dd;l;" & "o;n;n;"

            gridAttributes = gridAttributes & "|��������;jisacd;100;;l;" & "o;n;n;"

            gridAttributes = gridAttributes & "|��������;kjisacd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|���;damcd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|�����ڸ�;kname;100;;l;" & "o;n;n;"
            
            gridAttributes = gridAttributes & "|�������;gudokgu;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|�Ҽӻ�;sosokcd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|(��)���ڹ�ȣ;dokjano;100;;l;" & "o;n;y;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "gudokgu;��������ڵ�"
            gridCodeNameList = gridCodeNameList & "/dokjagu;Ȯ�屸���ڵ�"
            gridCodeNameList = gridCodeNameList & "/bancd;���������ڵ�"
            grd_1.Initialize(gridAttributes, gridCodeNameList)

            '--------------------------------------------------
            grd_1.ExplorerBar = 3
            '--------------------------------------------------

            txtDokName.TextValue = Me.DokjaName
            TxtAddr.TextValue = Me.strAddr
            txtTelNum.TextValue = Me.strTelNum

        End Sub

        Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
            Me.Close()
        End Sub
    End Class
End Namespace

