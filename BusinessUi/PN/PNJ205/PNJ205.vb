'////////////////////////////////////////////////////////////////////////////////////////////////////
' form 명 : 코드관리
' form 설명 : 문화일보 코드 관리
' 작성자 : 권진성
' 작성일 : 2008.09.01
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

#Region "폼 초기화"
        ''' <summary>
        ''' 함수명 : Initialize
        ''' 기  능 : 폼 및 그리드 초기화
        ''' 작성자 : 
        ''' 작성일 : 2008.09.01
        ''' 수정자 : 
        ''' 수정일 : 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Initialize()
            sbGridInit()
        End Sub

        Private Sub sbGridInit()

            'grid를 초기화 한다.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '수정 mode(n - no, k-keyboard, a - keyboard & mouse); 선택 mode(c - cell, r - row); 자동 Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            '화면 명칭; key 명칭; 넓이; format; 정렬(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); 필수 입력(y - yes, n - no); 숨기기 (y - yes, n - no); 최대 문자 길이; popup code
            gridAttributes = gridAttributes & "||선택;선택;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|구분;TreePath;80;;l;" & "io;n;n;5;"   ''  
            '' '' ===============================================================================
            '' '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
            If Me.optMode1.Checked = True Then '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
                gridAttributes = gridAttributes & "|담당사번;ChargeEmpNum;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;70;;l;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|거래선;BranchCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|거래선명;BranchNm;70;;l;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;120;;l;" & "o;n;n;40;"
            End If
            If Me.optMode2.Checked = True Then '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
                gridAttributes = gridAttributes & "|담당사번;ChargeEmpNum;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;70;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|거래선;BranchCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|거래선명;BranchNm;120;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;120;;l;" & "o;n;y;40;"
            End If
            If Me.optMode3.Checked = True Then '' optMode1 : 소속사별,  optMode2 : 거래선별,  optMode3 : 거래선/소속사별
                gridAttributes = gridAttributes & "|담당사번;ChargeEmpNum;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|담당명;ChargeEmpNm;70;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|거래선;BranchCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|거래선명;BranchNm;70;;l;" & "o;n;n;40;"
                gridAttributes = gridAttributes & "|소속사코드;CouponCorpCd;70;;c;" & "o;n;y;40;"
                gridAttributes = gridAttributes & "|소속사명;CouponCorpNm;120;;l;" & "o;n;n;40;"
            End If

            gridAttributes = gridAttributes & "|금액;Amount;80;#,###;c;" & "o;n;n;5;"   ''  
            gridAttributes = gridAttributes & "|TOTAL;total;80;#,###;c;" & "o;n;n;5;"   ''  
            '' =============================================================================
            '' 가변 필드 처리
            '' =============================================================================
            If Me.dtpRedeemDt.TextValue.ToString.Length > 1 Then
                GmainsqlParameters = Nothing
                With GmainCommonFunction
                    .SetSqlParameter(GmainsqlParameters, "@ARedeemDt", Me.dtpRedeemDt.TextValue)      ' 회수년월
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
            gridAttributes = gridAttributes & "|정렬;SortOrders;80;;c;" & "o;n;y;5;"   ''  
            gridAttributes = gridAttributes & "|;mErONG;90;;l;" & "o;n;n;5;"

            'grid code combo
            Dim gridCodeNameList As String = ""
            ''gridCodeNameList = gridCodeNameList & "ProjectID;프로젝트 명"
            'gridCodeNameList = gridCodeNameList & "SolicitorDivCd;권유자구분코드"
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
