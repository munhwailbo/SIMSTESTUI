'////////////////////////////////////////////////////////////////////////////////////////////////////
' form �� : �������׸��������
' form ���� : ������ �׸��� ��� ���� �մϴ�.
' �ۼ��� : ������
' �ۼ��� : 2006-03-07
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

    Public Class PNA502
        Inherits CommonControls.UiControl

        Public Sub Initialize()

            '==============================================================
            '  grid_1 �� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------------------
            Dim gridAttributes As String = ""
            '���� mode(n - no, k-keyboard, a - keyboard & mouse); ���� mode(c - cell, r - row); �ڵ� Size(y - yes, n - no)
            gridAttributes = gridAttributes & "a;r;n"

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(l - flexAlignLeftCenter, c - flexAlignCenterCenter, r - flexAlignRightCenter);
            '& input outup(i - input, o - output, io - input output); �ʼ� �Է�(y - yes, n - no); ����� (y - yes, n - no); �ִ� ���� ����; popup code
            gridAttributes = gridAttributes & "||����;����;40;;l;" & "i;n;y;"
            gridAttributes = gridAttributes & "|�����ȣ�ڵ�;ZipSeriesNum;10;;;" & "o;n;n;10;"       '(10)
            gridAttributes = gridAttributes & "|�����ȣ;ZipCd;10;;;" & "o;n;n;10;"       '(20)
            gridAttributes = gridAttributes & "|��;Do;30;;;" & "o;n;n;30;"       '(30)
            gridAttributes = gridAttributes & "|�ñ���;City;30;;;" & "o;n;n;30;"       '(40)
            gridAttributes = gridAttributes & "|���鵿;Dong;30;;;" & "o;n;n;30;"       '(50)
            gridAttributes = gridAttributes & "|��;Ri;30;;;" & "o;n;n;30;"       '(60)
            gridAttributes = gridAttributes & "|����;Island;30;;;" & "o;n;n;30;"       '(70)
            gridAttributes = gridAttributes & "|�����;San;30;;;" & "o;n;n;30;"       '(80)
            gridAttributes = gridAttributes & "|���۹���-��;SHouseNumJu;30;;;" & "o;n;n;30;"       '(90)
            gridAttributes = gridAttributes & "|���۹���-��;SHouseNum1Bu;30;;;" & "o;n;n;30;"       '(100)
            gridAttributes = gridAttributes & "|������-��;EHouseNumJu;30;;;" & "o;n;n;30;"       '(110)
            gridAttributes = gridAttributes & "|������-��;EHouseNumBu;30;;;" & "o;n;n;30;"       '(120)
            gridAttributes = gridAttributes & "|����Ʈ/�ǹ���;ApartmentNm;30;;;" & "o;n;n;30;"       '(130)
            gridAttributes = gridAttributes & "|����Ʈ���۵�;ApartmentSDong;30;;;" & "o;n;n;30;"       '(140)
            gridAttributes = gridAttributes & "|����Ʈ����;ApartmentEDong;30;;;" & "o;n;n;30;"       '(150)
            gridAttributes = gridAttributes & "|������;ProcessDt;8;;;" & "o;n;n;8;"       '(160)
            gridAttributes = gridAttributes & "|�ּ�;Addr;100;;;" & "o;n;n;100;"       '(170)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "o;n;n;7;"       '(180)
            gridAttributes = gridAttributes & "|������;BranchNm;30;;;" & "o;n;n;30;"       '(190)
            gridAttributes = gridAttributes & "|����������ڵ�;ChargeTypeCd;10;;;" & "o;n;n;10;"       '(200)
            gridAttributes = gridAttributes & "|����ڻ��;ChargeEmpNum;7;;;" & "o;n;n;7;"       '(210)
            gridAttributes = gridAttributes & "|���������ڵ�;BranchRegionCd;10;;;" & "o;n;n;10;"       '(250)
            gridAttributes = gridAttributes & "|�����ڵ�;BranchCd;7;;;" & "o;n;n;7;"       '(260)
            gridAttributes = gridAttributes & "|�Ϸù�ȣ;SeriesNum;4;;;" & "o;n;n;4;"       '(270)
            gridAttributes = gridAttributes & "|�����ȣ�ڵ�;ZipSeriesNum;10;;;" & "o;n;n;10;"       '(280)
            'grid_1 code combo    
            Dim gridCodeNameList As String = ""
            grd_1.Initialize(gridAttributes, gridCodeNameList)
            ''Me.grd_1.ExplorerBar = Me.grd_1.get_ColIndex("EmployeeNumber")

        End Sub



        Private Sub PNA502_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.DesignMode = False Then                                           ' �����ڸ�忡���� �������� �ʰ� �����忡���� �۵��ϵ����Ѵ�.
                Me.Dock = DockStyle.Fill                                               ' ���ߵ� ȭ���� ����ȭ���� ����� ���� ���������� Ŀ���� �Ѵ�.
                'Me.MinimumSize = New System.Drawing.Size(811, 647)

            End If

        End Sub



        
    End Class

End Namespace
