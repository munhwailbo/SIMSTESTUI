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

            Dim 독자명 As String = txtDokName.TextValue
            Dim 주소 As String = TxtAddr.TextValue
            Dim 전화번호 As String = txtTelNum.TextValue
            Dim 과거독자여부 As String = ""
            Dim 현재독자여부 As String = ""
            Dim 지국확장포함여부 As String = ""
            Dim 사원확장포함여부 As String = ""

            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Adokname", 독자명)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Aaddr", 주소)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@Atel", 전화번호)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AOldOnly", 과거독자여부)
            GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@APresentOnly", 현재독자여부)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AJisaInclude", 지국확장포함여부)
            'GmainCommonFunction.SetSqlParameter(GmainsqlParameters, "@AEmpInclude", 사원확장포함여부)

            Dim reciveDataSet As DataSet = GmainExecuteDbCommand.ExecuteStoredProcedure("PN", "ExistReaderList", False, True, GmainsqlParameters)
            Me.grd_1.SetDataSet(reciveDataSet)
            reciveDataSet = Nothing

            'GmainCommonFunction.SetAllBusinessUiInitialValue(Me)
        End Sub
        Private Sub btnRequestData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestData.Click


            RequestData(True)


        End Sub

        Private Sub frmExistReader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;y"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "o;n;y;"
            gridAttributes = gridAttributes & "|확장구분;dokjagu;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|중지구분;bancd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|독자명;dokname;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|전화번호;tel;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|투입부수;busu;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|우편번호;post;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|주소;addr1;200;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|상세주소;addr2;200;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|구독일자;kymd;100;yyyy-MM-dd;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|재투입일자;jymd;100;yyyy-MM-dd;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|수금년월;sym;100;yyyy-MM;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|중지일자;bymd;100;yyyy-MM-dd;l;" & "o;n;n;"

            gridAttributes = gridAttributes & "|투입지국;jisacd;100;;l;" & "o;n;n;"

            gridAttributes = gridAttributes & "|권유지국;kjisacd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|담당;damcd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|권유자명;kname;100;;l;" & "o;n;n;"
            
            gridAttributes = gridAttributes & "|구독경로;gudokgu;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|소속사;sosokcd;100;;l;" & "o;n;n;"
            gridAttributes = gridAttributes & "|(구)독자번호;dokjano;100;;l;" & "o;n;y;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            gridCodeNameList = gridCodeNameList & "gudokgu;접수경로코드"
            gridCodeNameList = gridCodeNameList & "/dokjagu;확장구분코드"
            gridCodeNameList = gridCodeNameList & "/bancd;중지사유코드"
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

