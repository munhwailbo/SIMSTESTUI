Imports Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports VBN = Microsoft.VisualBasic

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Configuration

Namespace ubiLease.CommonPopup

    Public Class frmCodeName

        'Private McodeDivisionHangulName As String = "" '������ ����
        Private McodeDivisionHangulName() As String = Nothing
        Private MReturnKey() As String = Nothing
        Private stringMcodeDivisionHangulName As String = ""
        Private stringMReturnKey As String = ""

        Private McodeSqlParameterName As String = ""
        Private MnameSqlParameterName As String = ""
        Private MwhereSqlParameterName As String = ""
        Private McodeGridName As String = ""
        Private MnameGridName As String = ""
        ' Stored Procedure ���� �ڵ� ����
        Private MsubCode As String = ""

        Private MpopupLayout As Generic.IDictionary(Of String, Object)
        Private popupmanager As popupManager = New popupManager()

        Private _popupType As Boolean

        ' �˾� �����
        Private strActvateOrHide As String = "1"

        Public Property PopupType() As Boolean

            Get
                Return _popupType
            End Get

            Set(ByVal value As Boolean)
                _popupType = value
            End Set

        End Property
        ''' <summary>
        ''' �Լ��� : DynamicControlAdd 
        ''' ��  �� : �߰� ��Ʈ�� ����
        ''' �ۼ��� : ������
        ''' �ۼ��� : 2007-10-12
        ''' ������ : 
        ''' ������ : 
        ''' </summary>
        ''' <param name="vMcodeDivisionHangulName"></param>
        ''' <remarks></remarks>
        Private Sub DynamicControlAdd(ByVal vMcodeDivisionHangulName As String)

            If vMcodeDivisionHangulName = "�ŷ�ó ��" Then
                popupmanager.dynamicDesign(Me, 0, 2)
                '
                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblBizNumber", "�����", 56, 0, 1, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtBizNumber", "", 110, 1, 1, "format(&&&-&&-&&&&&);")

                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblJuminNumber", "�ֹι�ȣ", 56, 2, 1, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtJuminNumber", "", 150, 3, 1, "format(&&&&&&-&&&&&&&);")

                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblRepresentativeName", "��ǥ�ڸ�", 56, 0, 2, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtRepresentativeName", "", 110, 1, 2, "")

                'popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblCustomerGroupingCode", "�׷�з�", 56, 2, 2, "")
                'popupmanager.ControlAdd(Me, ubiControlType.cbo, "cboCustomerGroupingCode", "", 150, 3, 2, "code(�ŷ�ó �з�|�����ϼ���);")
            ElseIf vMcodeDivisionHangulName = "��ǥ �ŷ�ó ��" Then
                popupmanager.dynamicDesign(Me, 0, 2)
                '
                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblBizNumber", "�����", 56, 0, 1, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtBizNumber", "", 110, 1, 1, "format(&&&-&&-&&&&&);")

                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblJuminNumber", "�ֹι�ȣ", 56, 2, 1, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtJuminNumber", "", 150, 3, 1, "format(&&&&&&-&&&&&&&);")

                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblRepresentativeName", "��ǥ�ڸ�", 56, 0, 2, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtRepresentativeName", "", 110, 1, 2, "")

                'popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblCustomerGroupingCode", "�׷�з�", 56, 2, 2, "")
                'popupmanager.ControlAdd(Me, ubiControlType.cbo, "cboCustomerGroupingCode", "", 150, 3, 2, "code(�ŷ�ó �з�|�����ϼ���);")
            ElseIf vMcodeDivisionHangulName = "�׷� �迭�� ��" Then
                popupmanager.dynamicDesign(Me, 0, 2)
                '
                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblBizNumber", "�����", 56, 0, 1, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtBizNumber", "", 110, 1, 1, "format(&&&-&&-&&&&&);")

                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblJuminNumber", "�ֹι�ȣ", 56, 2, 1, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtJuminNumber", "", 150, 3, 1, "format(&&&&&&-&&&&&&&);")

                popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblRepresentativeName", "��ǥ�ڸ�", 56, 0, 2, "")
                popupmanager.ControlAdd(Me, ubiControlType.txt, "txtRepresentativeName", "", 110, 1, 2, "")

                'popupmanager.ControlAdd(Me, ubiControlType.lbl, "lblCustomerGroupingCode", "�׷�з�", 56, 2, 2, "")
                'popupmanager.ControlAdd(Me, ubiControlType.cbo, "cboCustomerGroupingCode", "", 150, 3, 2, "code(�ŷ�ó �з�|�����ϼ���);")
            End If

        End Sub

        '====================================================================================================
        Public Sub Initialize(ByVal AcodeDivisionHangulName As String, Optional ByVal Awhere As String = "" _
                                , Optional ByVal AreturnKey As String = "", Optional ByVal AsubCode As String = "")

            Dim reciveDataSet As DataSet
            Dim strSql As String = ""
            Dim CodeDivision As String = ""
            Dim intII As Integer = 0
            Dim strColLogNm As String = ""      '�÷� ����
            Dim strColPhyNm As String = ""      '�÷� ������
            Dim strColWidth As String = ""      '�÷� ���̸�
            Dim strColVisible As String = ""    'ǥ�� ����

            Debug.Print("�˾� where �� : " & Awhere)

            ' �˾��� �ƿ� ���� �ʰ�
            If Awhere = "Escape" Then
                strActvateOrHide = "0"
            End If

            ' �⺻ �˾� Ÿ��
            MpopupLayout = popupmanager.GetLayout(Me)

            McodeDivisionHangulName = Split(AcodeDivisionHangulName, ",") '������ �߰�
            MReturnKey = Split(AreturnKey, ",")
            stringMcodeDivisionHangulName = AcodeDivisionHangulName '������ �߰�
            stringMReturnKey = AreturnKey '������ �߰�

            MsubCode = AsubCode

            Me.Text = McodeDivisionHangulName(0) & " ��ȸ"

            ' �������� �˾� ���¸� �����Ѵ�.

            DynamicControlAdd(McodeDivisionHangulName(0))

            'ȭ�� ��Ī; key ��Ī; ����; format; ����(1 - flexAlignLeftCenter, 4 - flexAlignCenterCenter, 7 - flexAlignRightCenter);
            '& input output io (i:input/o:output); �ʼ� �Է� y/n; ����� y/n; �ִ� ���� ����; popup code

            'If _
            '    McodeDivisionHangulName(0) = "����� ��" _
            '    Or McodeDivisionHangulName(0) = "������ ����� ��" _
            '    Or McodeDivisionHangulName(0) = "����� ���� ��" Then

            '================================================================
            '   ���� �ڵ� ���� Ȯ��
            '================================================================ 
            '    select IsNull(max(CodeDivision),'') from CommonCodeDivision 
            '     where len(CodeDivision) = 4 and CodeDivision like '8%' 
            '       and CodeDivisionHangulName  = '�������ڵ�' --@codeDivisionHangulName  
            strSql = " select IsNull(max(CodeDivision),'') as CodeDivision from CommonCodeDivision " & _
                      " where len(CodeDivision) = 4 and CodeDivision like '8%' " & _
                      "    and CodeDivisionHangulName  = '" & McodeDivisionHangulName(0) & "'"
            reciveDataSet = GmainExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), strSql)
            If reciveDataSet.Tables(0).Rows.Count > 0 Then
                CodeDivision = (reciveDataSet.Tables(0).Rows(0)(0)) ' �ٷ� �� ������ ����� ���� �Ѵ�.
            End If
            If CodeDivision.ToString().Length > 0 Then   '���� �ڵ� �ƴ� ���
                McodeSqlParameterName = "@Acode"
                MnameSqlParameterName = "@AcodeName"

                McodeGridName = "Code"
                MnameGridName = "CodeHangulName"
            Else
                McodeSqlParameterName = "@Acode"
                MnameSqlParameterName = "@AcodeName"

                McodeGridName = "Code"
                MnameGridName = "CodeHangulName"
            End If

            ' Where ���� �� (and �ڿ� �ٴ´�.)
            MwhereSqlParameterName = ""
            If Awhere <> "" Then
                If Awhere.Substring(0, 3) = "Pro" And Awhere.Length = 16 Then
                    MwhereSqlParameterName = " and " & Awhere.Remove(Awhere.Length - 1, 1)
                Else
                    Debug.Print("�˾� where �� : " & Awhere)
                    MwhereSqlParameterName = " and " & Awhere
                End If
            End If

            'VSFlexGrid�� �ʱ�ȭ �Ѵ�.
            '--------------------------------------------------
            Dim gridAttributes As String = ""

            '���� mode(0 - �Ұ�, 1 - Ű����, 2 - Ű���� & ���콺); ���� mode(1 - cell, 2 - row); �ڵ� Size Y/N(1/0))
            gridAttributes = gridAttributes & "0;2;1"

            'If McodeDivisionHangulName.Length < 2 Then   ' ��Ƽ������ �ƴ� �͸� �߰��ϰ� ��Ƽ������ �Ʒ� �߰��Ȱ��� ����Ѵ�.
            If True Then
                gridAttributes = gridAttributes & "|"
                If CodeDivision.ToString().Length > 0 Then     '���� �ڵ� �ƴ� ���
                    '==========================================================================
                    ' ���� �ڵ� ��
                    '==========================================================================
                    strSql = "select Note1, Note2, Note3, Note4  From CommonCode " & _
                             " where len(CodeDivision) = 4 and CodeDivision like '8%' and Note1 > '' and CodeDivision = '" & _
                             CodeDivision.ToString() & "' " & _
                             " order by Code  "

                    reciveDataSet = GmainExecuteDbCommand.ExecuteSql(ConfigurationManager.AppSettings("SystemDB"), strSql)
                    ' ��� ��ŭ ������ ���鼭 ���� 
                    For intII = 0 To reciveDataSet.Tables(0).Rows.Count - 1     ' �����ڵ� 8xxx ���1:�÷�ĸ�Ǹ�, ���2:������, ���3:width, ���4:visible 
                        strColLogNm = reciveDataSet.Tables(0).Rows(intII)("Note1")      '�÷� ����
                        strColPhyNm = reciveDataSet.Tables(0).Rows(intII)("Note2")      '�÷� ������
                        strColWidth = reciveDataSet.Tables(0).Rows(intII)("Note3")      '�÷� ���̸�
                        strColVisible = reciveDataSet.Tables(0).Rows(intII)("Note4")    'ǥ�� ����

                        gridAttributes = gridAttributes & "|" & strColLogNm & ";" & strColPhyNm & ";" & _
                                                          IIf(strColWidth.ToString.Length > 1, strColWidth, 0) & _
                                                          ";;1;" & "o;n;" & IIf(strColVisible.ToString.Length > 1, strColVisible, 0) & ";0;"
                        'gridAttributes = gridAttributes & "|" & Mid(McodeDivisionHangulName(0), 1, Len(McodeDivisionHangulName(0)) - 1) & "�ڵ�;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
                        'gridAttributes = gridAttributes & "|" & McodeDivisionHangulName(0) & ";" & MnameGridName & ";100;;1;" & "o;n;n;0;"
                    Next
                Else
                    gridAttributes = gridAttributes & "|" & Mid(McodeDivisionHangulName(0), 1, Len(McodeDivisionHangulName(0)) - 1) & "�ڵ�;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
                    gridAttributes = gridAttributes & "|" & McodeDivisionHangulName(0) & ";" & MnameGridName & ";100;;1;" & "o;n;n;0;"
                End If


                'ElseIf McodeDivisionHangulName.Length >= 2 Then '���� common Popup���� ������ code(����� ��, ǥ�� ���� ��); ó�� �ΰ��� ���� ���?
                '    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                '    '��Ƽ ������ ��쿡 �� ������ ���� �������� �߰��Ѵ�. 

                '    If stringMcodeDivisionHangulName = "����� ��,��� ȣ��,�ΰ� ���� ����,�ΰ� �Ϸ� ����" Then
                '        gridAttributes = gridAttributes & "||����� ID;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
                '        gridAttributes = gridAttributes & "|����� ��;" & MnameGridName & ";100;;1;" & "o;n;n;0;"

                '    ElseIf stringMcodeDivisionHangulName = "ǰ�Ǽ� ����,�����,ǰ�� �ݾ�,�� ǰ�� ��" Then
                '        gridAttributes = gridAttributes & "||ǰ�Ǽ� ���� ��ȣ;" & McodeGridName & ";100;;4;" & "o;n;n;0;"
                '        gridAttributes = gridAttributes & "|ǰ�Ǽ� ����;" & MnameGridName & ";100;;1;" & "o;n;n;0;"
                '    End If

            End If

            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'If MReturnKey.Length = McodeDivisionHangulName.Length Then  '�߰� ���� ���� �ְ� ���� ��� �÷��� ���� ���� ���
            '    For mcodeDivisionHangulNameCount As Integer = 1 To UBound(McodeDivisionHangulName) Step 1
            '        gridAttributes = gridAttributes & "|" & McodeDivisionHangulName(mcodeDivisionHangulNameCount) & ";" & MReturnKey(mcodeDivisionHangulNameCount) & ";100;;4;" & "o;n;n;0;"
            '    Next
            'Else
            '    Debug.Print("���ϸ�� ��� �÷��� ���� ���� �ʽ��ϴ�.")
            '    Exit Sub
            'End If

            grdMain.Initialize(gridAttributes)
            grdMain.ExplorerBar = 3 'c1.Win.C1FlexGrid.DragModeEnum. ' flexExMove ' 1
            reciveDataSet = Nothing



        End Sub

        Public GcurrentPop As Object = Nothing

        '====================================================================================================

        Private Sub frmCodeName_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

            If Me.strActvateOrHide = "0" Then
                Me.txtName.Focus()
                Me.Hide()
            End If

            Me.grdMain.GParentObject = Me

            If TypeOf GcurrentPop Is CommonControls.pop Then
                If VBN.Left(GcurrentPop.TextValue, 1) = ";" Or CommonControls.basCotrnol.isHangul(VBN.Left(GcurrentPop.TextValue, 1)) Then
                    Me.txtCode.Text = vbNullString
                    If VBN.Left(GcurrentPop.TextValue, 1) = ";" Then
                        Me.txtName.Text = VBN.Mid(GcurrentPop.TextValue, 2, VBN.Len(GcurrentPop.TextValue))
                    ElseIf CommonControls.basCotrnol.isHangul(VBN.Left(GcurrentPop.TextValue, 1)) Then
                        Me.txtName.Text = VBN.Mid(GcurrentPop.TextValue, 1, VBN.Len(GcurrentPop.TextValue))
                    End If

                    Me.txtWhere.Text = MwhereSqlParameterName
                Else
                    Me.txtCode.Text = Trim(GcurrentPop.TextValue)
                    Me.txtName.Text = vbNullString
                    Me.txtWhere.Text = MwhereSqlParameterName
                End If
                Me.txtName.Focus()
            Else

                '' �˾��� �ε� �Ǿ����� 

                beforeEditGridRowDataSave()

                If MwhereSqlParameterName <> "" Then
                    SetCirteriaCollection(MwhereSqlParameterName)
                    Me.txtWhere.Text = MwhereSqlParameterName
                    Debug.Print("�˾� MwhereSqlParameterName �� : " & MwhereSqlParameterName)
                End If
                If GcurrentPop.get_TextMatrix(GcurrentPop.Row, GcurrentPop.Col) <> "" Then

                    Dim _codeString As String = GcurrentPop.get_TextMatrix(GcurrentPop.Row, GcurrentPop.Col)

                    If VBN.Left(_codeString, 1) = ";" Or CommonControls.basCotrnol.isHangul(VBN.Left(_codeString, 1)) Then
                        If VBN.Left(_codeString, 1) = ";" Then
                            Me.txtName.Text = VBN.Mid(_codeString, 2, VBN.Len(_codeString))
                        ElseIf CommonControls.basCotrnol.isHangul(VBN.Left(_codeString, 1)) Then
                            Me.txtName.Text = VBN.Mid(_codeString, 1, VBN.Len(_codeString))
                        End If
                    Else
                        Me.txtCode.Text = VBN.Mid(_codeString, 1, VBN.Len(_codeString))
                    End If

                Else

                End If
                'Me.txtWhere.Text = MwhereSqlParameterName '�߰� - ������20060626

            End If

            '���� ��ȣ �϶�
            'If Not (McodeDivisionHangulName(0) = "�����ȣ" And Len(Me.txtCode.Text) + Len(Me.txtName.Text) = 0) Then
            '    btnRequestData_Click(sender, e)
            'End If

            '' �ڵ� & �ڵ���� �μ��� �޾��� �� �ڵ����� ��ȸ ��ư Ŭ�� 
            If Me.txtCode.Text.Length > 0 Or Me.txtName.Text.Length > 0 Then
                btnRequestData_Click(Me.btnYes, Nothing)

                If grdMain.Rows > 1 Then
                Else
                    Me.txtName.Focus()
                End If
            Else
                If grdMain.Rows > 1 Then
                Else
                    Me.txtName.Focus()
                End If
                
            End If

        End Sub

        Private CirteriaCollection As New Collection


        Private Sub SetCirteriaCollection(ByVal WhereSqlParameter As String)

            If WhereSqlParameter <> "" Then
                Debug.Print(WhereSqlParameter)
                CirteriaCollection.Clear()
                Dim strings() As String = Split(WhereSqlParameter, " and ")


                For Each whereString As String In strings
                    If LCase(whereString).Trim <> "" Then
                        If Split(LCase(whereString), "=").Length > 1 Then
                            Dim key As String = Split(LCase(whereString), "=")(0)
                            Dim value As String = Split(LCase(whereString), "=")(1)
                            CirteriaCollection.Add(value, key)
                        ElseIf Split(LCase(whereString), "like").Length > 1 Then
                            Dim key As String = Split(LCase(whereString), "like")(0)
                            Dim value As String = Split(LCase(whereString), "like")(1)
                        End If
                    Else

                    End If
                Next


            End If
        End Sub

        Public GmainExecuteDbCommand As New DAT.ExecuteDbCommand
        Public GmainCommonFunction As New ubiLease.CommonFunction.Common
        Private MmainsqlParameters() As Data.SqlClient.SqlParameter

        '====================================================================================================
        Private Sub btnRequestData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestData.Click
            Debug.Print("�˾� MwhereSqlParameterName �� : " & MwhereSqlParameterName)
            SetCriteriaWhereString()

            Dim privateSubCode As String = ""

            ' ���� ��ġ ����

            If MsubCode = "" Then
                privateSubCode = "popfrm"
            Else
                privateSubCode = "popfrm;" & MsubCode
            End If

            ' �Ϲ� �˾� ó��
            Dim reciveDataSet As Object = GmainCommonFunction.GetPopupRecordset( _
                GcurrentPop _
                , stringMcodeDivisionHangulName _
                , Trim(Me.txtCode.Text) _
                , Trim(Me.txtName.Text) _
                , Trim(Me.txtWhere.Text) _
                , stringMReturnKey _
                , privateSubCode _
            )

            
            If IsNothing(reciveDataSet) = False Then
                GmainExecuteDbCommand.GrequestCount = 1
                Me.grdMain.SetDataSet(reciveDataSet)
                Me.grdMain.Focus()
            Else
                Me.txtName.Focus()
            End If
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub SetCriteriaWhereString()
            Dim strTemp As String = ""

            'stringMcodeDivisionHangulName �� �����..... �϶�
            'CirteriaCollection Ű������ Value �����ͼ� Where ���� ����� txtWhere�� �������� 
            ' ������ �����Ѵ�.
            Debug.Print("�˾� Awhere TextBox �� : " & Me.txtWhere.Text)

            If stringMcodeDivisionHangulName = "���� ��,���� ��,���� ���,���� ���" Then

                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = " and " + Replace(CirteriaCollection.Item("RequestCriteriaYearsMonth").ToString, "-", "") + " between ApplicationBeginningDate and ApplicationEndDate "
                    'Me.txtWhere.Visible = True
                End If

            ElseIf stringMcodeDivisionHangulName = "����� ��,��� ȣ��,�ΰ� ���� ����,�ΰ� �Ϸ� ����" Then
                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = Replace(Replace(CirteriaCollection.Item("BugaCriteriaDate").ToString, "-", ""), "'", "").ToString
                End If

            ElseIf stringMcodeDivisionHangulName = "���� ���� ��" Then

                If Me.txtWhere.Text = "" Then
                    Me.txtWhere.Text = GcurrentPop.Parent.Controls(0).TextValue
                Else
                    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim().Substring(0, 6)
                End If


                'ElseIf stringMcodeDivisionHangulName = "���� ���� ��1" Then
                '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
                'ElseIf stringMcodeDivisionHangulName = "���� ���� ��2" Then
                '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
                'ElseIf stringMcodeDivisionHangulName = "���� ���� ��3" Then
                '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
                'ElseIf stringMcodeDivisionHangulName = "���� ���� ��4" Then
                '    Me.txtWhere.Text = Replace(LCase(txtWhere.Text), "and ", "").Trim()
            ElseIf stringMcodeDivisionHangulName = "ǰ�Ǽ� ����,�����,ǰ�� �ݾ�,�� ǰ�� ��" Then

                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    strTemp = CirteriaCollection.Item("BudgetYears").ToString().Replace("'", "") + CirteriaCollection.Item("BudgetMonths").ToString().Replace("'", "")
                    Me.txtWhere.Text = " and left(t1.ValidBeginDate, 6) <= '" & strTemp & "' and left(t1.ValidEndDate, 6) >= '" & strTemp & "' and left(t1.OrganizationCode, 8) = '" & CirteriaCollection.Item("OrganizationCode").ToString().Replace("'", "") & "' and t1.AccountCode = '" & CirteriaCollection.Item("AccountCode").ToString().Replace("'", "") & "' "

                End If

            ElseIf stringMcodeDivisionHangulName = "������ �з� ��, ������ �׸� �ڵ�, ������ �׸� ��,�ܰ�" Then

                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = Replace(Replace(CirteriaCollection.Item("BugaYearsMonths").ToString, "-", ""), "'", "").ToString
                    Me.txtWhere.Text = Replace(Replace(CirteriaCollection.Item("SaYongRoomCode").ToString, "-", ""), "'", "").ToString
                End If

                ' ������ �߰�
            ElseIf stringMcodeDivisionHangulName = "������ �޿� �׸� ��" Then
                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = " and t1.AllowanceYearMonth = " & CirteriaCollection.Item("AllowanceYearMonth").ToString & " " _
                                     & " and t1.[Order] = " & CirteriaCollection.Item("Order").ToString & " " _
                                     & " and t3.AllowanceDivisionCode = (select AllowanceDivisionCode from PersnalAffairsHeader where employeeNumber = " & CirteriaCollection.Item("employeeNumber").ToString & ") "
                End If

            ElseIf stringMcodeDivisionHangulName = "���� ���� ��" Then

                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = " and t1.Years = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(0, 4)) & "'"
                    Me.txtWhere.Text = Me.txtWhere.Text & " and t1.Months = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(4, 2)) & "'"
                End If

                'ElseIf stringMcodeDivisionHangulName = "���� ���� ��" Then

                '    'Me.txtWhere.Text = ""
                '    Me.txtWhere.Text = Trim(Replace(Replace(Me.txtWhere.Text, "and", ""), "'", ""))

                'If CirteriaCollection.Count > 0 Then
                '    Me.txtWhere.Text = " and t1.Years = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(0, 4)) & "'"
                '    Me.txtWhere.Text = Me.txtWhere.Text & " and t1.Months = '" & Trim(Replace(Replace(CirteriaCollection.Item("distributionYearsMonths").ToString, "-", ""), "'", "").ToString.Substring(4, 2)) & "'"
                'End If

            ElseIf stringMcodeDivisionHangulName = "���� ����� ��,���ȣ��,���� �ݾ�,���� �ݾ�" Then

                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = " and " + Replace(Replace(CirteriaCollection.Item("ExactCalculationYearsMonths").ToString, "-", ""), "'", "").ToString
                End If

            ElseIf stringMcodeDivisionHangulName = "���� �׸� ��" Then

                Me.txtWhere.Text = ""
                'If CirteriaCollection.Count > 0 Then
                strTemp = CType(Me.GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls("lblManagementItemNumber").Text
                If strTemp = "���¹�ȣ" Then
                    Me.txtWhere.Text = " and BankBranchCode LIKE '" + CType(CType(Me.GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls("popSideItemCode"), ubiLease.CommonControls.pop).TextValue + "' + '%' "
                ElseIf strTemp = "ȣ�ǹ�ȣ" Then
                    Me.txtWhere.Text = " and BankBranchCode LIKE '" + CType(CType(Me.GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls("popSideItemCode"), ubiLease.CommonControls.pop).TextValue + "' + '%' "
                End If
                'End If
            ElseIf stringMcodeDivisionHangulName = "�ŷ�ó ��" Then
                Dim strAddWhere As String = ""
                Dim strResidentRegistrationNumber As String = ""
                Dim strWorkRegistrationNumber As String = ""
                Dim strRepresentativeName As String = ""

                strResidentRegistrationNumber = CType(Me.Controls.Find("txtJuminNumber", True)(0), ubiLease.CommonControls.txt).TextValue
                strWorkRegistrationNumber = CType(Me.Controls.Find("txtBizNumber", True)(0), ubiLease.CommonControls.txt).TextValue
                strRepresentativeName = CType(Me.Controls.Find("txtRepresentativeName", True)(0), ubiLease.CommonControls.txt).TextValue

                Me.txtWhere.Text = ""
                ''If CirteriaCollection.Count > 0 Then
                strAddWhere += " AND ResidentRegistrationNumber LIKE '" & strResidentRegistrationNumber & "' + '%' "
                strAddWhere += " AND WorkRegistrationNumber LIKE '" & strWorkRegistrationNumber & "'  + '%' "
                strAddWhere += " AND RepresentativeName LIKE '" & strRepresentativeName & "'  + '%' "

                Me.txtWhere.Text = strAddWhere
                'End If
            ElseIf stringMcodeDivisionHangulName = "��ǥ �ŷ�ó ��" Then
                Dim strAddWhere As String = ""
                Dim strResidentRegistrationNumber As String = ""
                Dim strWorkRegistrationNumber As String = ""
                Dim strRepresentativeName As String = ""

                strResidentRegistrationNumber = CType(Me.Controls.Find("txtJuminNumber", True)(0), ubiLease.CommonControls.txt).TextValue
                strWorkRegistrationNumber = CType(Me.Controls.Find("txtBizNumber", True)(0), ubiLease.CommonControls.txt).TextValue
                strRepresentativeName = CType(Me.Controls.Find("txtRepresentativeName", True)(0), ubiLease.CommonControls.txt).TextValue

                Me.txtWhere.Text = ""
                ''If CirteriaCollection.Count > 0 Then
                strAddWhere += " AND ResidentRegistrationNumber LIKE '" & strResidentRegistrationNumber & "' + '%' "
                strAddWhere += " AND WorkRegistrationNumber LIKE '" & strWorkRegistrationNumber & "'  + '%' "
                strAddWhere += " AND RepresentativeName LIKE '" & strRepresentativeName & "'  + '%' "
                Me.txtWhere.Text = strAddWhere

            ElseIf stringMcodeDivisionHangulName = "�׷� �迭�� ��" Then
                Dim strAddWhere As String = ""
                Dim strResidentRegistrationNumber As String = ""
                Dim strWorkRegistrationNumber As String = ""
                Dim strRepresentativeName As String = ""

                strResidentRegistrationNumber = CType(Me.Controls.Find("txtJuminNumber", True)(0), ubiLease.CommonControls.txt).TextValue
                strWorkRegistrationNumber = CType(Me.Controls.Find("txtBizNumber", True)(0), ubiLease.CommonControls.txt).TextValue
                strRepresentativeName = CType(Me.Controls.Find("txtRepresentativeName", True)(0), ubiLease.CommonControls.txt).TextValue

                Me.txtWhere.Text = ""
                ''If CirteriaCollection.Count > 0 Then
                strAddWhere += " AND ResidentRegistrationNumber LIKE '" & strResidentRegistrationNumber & "' + '%' "
                strAddWhere += " AND WorkRegistrationNumber LIKE '" & strWorkRegistrationNumber & "'  + '%' "
                strAddWhere += " AND RepresentativeName LIKE '" & strRepresentativeName & "'  + '%' "
                strAddWhere += " AND CustomerType = '01' "
                Me.txtWhere.Text = strAddWhere

            ElseIf stringMcodeDivisionHangulName = "����� �����ȹ ���� ��" Then

                Me.txtWhere.Text = ""
                If CirteriaCollection.Count > 0 Then
                    Me.txtWhere.Text = " and t1.PlanYears = " & Trim(CirteriaCollection.Item("PlanYears")) & " "
                    Me.txtWhere.Text = Me.txtWhere.Text & " and t1.PlanOrders = " & Trim(CirteriaCollection.Item("PlanOrders").ToString()) & " "
                End If

            End If

        End Sub

        '====================================================================================================
        Private Sub btnYesNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles btnYes.Click _
            , btnNo.Click

            With Me.grdMain
                If sender.Name = "btnYes" Then

                    If .Rows <= .FixedRows Then
                        'MsgBox("���õ� ���� �����ϴ�.", MsgBoxStyle.Information, GmainCommonFunction.GmessageTile)
                        Exit Sub
                    End If
                    Dim SelDataCollection As Collection = New Collection
                    If TypeOf GcurrentPop Is CommonControls.pop Then

                        If .Cols > 2 Then

                            SelDataCollection.Clear()

                            For ColNum As Integer = 1 To .Cols - 1 Step 1
                                SelDataCollection.Add(.GetData(.Row, ColNum), .get_ColKey(ColNum))
                            Next
                            CType(GcurrentPop, ubiLease.CommonControls.pop).SelRowDataCollection = SelDataCollection
                        End If

                        Dim strstag As String() = CType(GcurrentPop, ubiLease.CommonControls.pop).Tag.Split(";")

                        Dim i As Integer = 1

                        For Each s As String In strstag
                            If s.Trim.ToLower.StartsWith("rtnvalue(") Then
                                s = s.ToLower.Replace("rtnvalue(", "")
                                s = s.ToLower.Replace(")", "")
                                Dim strs() As String = s.Split(",")

                                For Each ss As String In strs
                                    For Each c As Control In CType(GcurrentPop, ubiLease.CommonControls.pop).Parent.Controls
                                        
                                        If c.Name.Trim.ToLower = ss.Trim.ToLower Then
                                            If TypeOf c Is ubiLease.CommonControls.pop Then
                                                If IsNothing(SelDataCollection("rtnValue" & i.ToString())) Then
                                                    CType(c, Object).CodeText = ""
                                                Else
                                                    CType(c, Object).CodeText = SelDataCollection("rtnValue" & i.ToString()).ToString()
                                                End If

                                            Else
                                                If IsNothing(SelDataCollection("rtnValue" & i.ToString())) Then
                                                    CType(c, Object).TextValue = ""
                                                Else
                                                    CType(c, Object).TextValue = SelDataCollection("rtnValue" & i.ToString()).ToString()
                                                End If


                                            End If
                                            i = i + 1
                                        End If
                                    Next
                                Next
                            End If
                        Next

                        GcurrentPop.popFormAction = True

                        GcurrentPop.TextValue = .get_TextMatrix(.Row, .get_ColIndex(McodeGridName))
                        GcurrentPop.NameText = .get_TextMatrix(.Row, .get_ColIndex(MnameGridName))

                        
                        GcurrentPop.popFormAction = False

                        GcurrentPop.txtUserControl.Select()
                        GcurrentPop.txtUserControl.Focus()
                        'End If

                    Else
                        Dim colDatas() As String = Split(GcurrentPop.get_ColData(GcurrentPop.Col), ";")
                        Dim nameColKey As String = ""
                        Dim returnKey() As String = Split(Trim(colDatas(5)), ",")
                        Dim returnCount As Integer = returnKey.Length

                        If colDatas.Length >= 6 Then

                            If _
                                Trim(colDatas(5)) <> "" _
                                And Trim(colDatas(5)) <> "0" _
                                Then

                                GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, .get_TextMatrix(.Row, .get_ColIndex(McodeGridName)))
                                GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(0)), .get_TextMatrix(.Row, .get_ColIndex(MnameGridName)))
                                If returnKey.Length >= 2 Then
                                    Dim i As Int16 = 1
                                    For Each colum As String In returnKey
                                        If returnKey(0) = colum Then
                                        Else
                                            GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(colum), grdMain.get_TextMatrix(grdMain.Row, grdMain.get_ColIndex("rtnValue" & i)))
                                            i = i + 1
                                        End If
                                        'For returnKeyNumber As Integer = 1 To returnCount - 1 Step 1
                                        '    'GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(returnKeyNumber)), .get_TextMatrix(.Row, .get_ColIndex(returnKey(returnKeyNumber))))
                                        '    'If Me.grdMain.get_ColIndex(returnKey(returnKeyNumber).ToString()) > 0 Then
                                        '    '    Debug.Print(":")
                                        '    'End If

                                        '    'Debug.Print("��Ƽ���� : ���ð� : " & " �� : " & .Row & " �� :" & .get_ColIndex(returnKey(returnKeyNumber).ToString()) & " : " & returnKey(returnKeyNumber).ToString() & " : " & .get_TextMatrix(.Row, .get_ColIndex(returnKey(returnKeyNumber).ToString())).ToString())
                                        '    'Debug.Print("��Ƽ���� : ����� �� : " & " �� : " & GcurrentPop.Row & " �� : " & " : " & GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(returnKeyNumber)) & Split(colDatas(5), ",")(returnKeyNumber).ToString() & " : " & GcurrentPop.get_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(Split(colDatas(5), ",")(returnKeyNumber))))
                                        'Next
                                    Next
                                End If

                                afterEditGridRowDataChangeCheck()
                            Else
                                nameColKey = Trim(colDatas(5))
                                If nameColKey = "" Then
                                    nameColKey = GcurrentPop.get_ColKey(GcurrentPop.Col) & "Name"
                                End If
                                GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, .get_TextMatrix(.Row, .get_ColIndex(McodeGridName)))
                                GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(nameColKey), .get_TextMatrix(.Row, .get_ColIndex(MnameGridName)) _
                                )

                                afterEditGridRowDataChangeCheck()
                            End If


                        Else
                            nameColKey = Trim(colDatas(4))
                            If nameColKey = "" Then
                                nameColKey = GcurrentPop.get_ColKey(GcurrentPop.Col) & "Name"
                            End If
                            GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.Col, .get_TextMatrix(.Row, .get_ColIndex(McodeGridName)))
                            GcurrentPop.set_TextMatrix(GcurrentPop.Row, GcurrentPop.get_ColIndex(nameColKey), .get_TextMatrix(.Row, .get_ColIndex(MnameGridName)) _
                            )

                            afterEditGridRowDataChangeCheck()

                        End If
                    End If

                End If

            End With
            Me.txtName.Focus()
            Me.Hide()
            SizeReset()
        End Sub

        Private tmpRowDatas As Collection

        Private Sub beforeEditGridRowDataSave()

            If IsNothing(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.Data) Then

            Else
                tmpRowDatas = New Collection
                For i As Integer = CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols To CType(GcurrentPop, ubiLease.GridControl.grd).Cols - CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols

                    If IsNothing(CType(GcurrentPop, ubiLease.GridControl.grd).get_TextMatrix(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.r1, i)) Then

                        tmpRowDatas.Add("", CType(GcurrentPop, ubiLease.GridControl.grd).get_ColKey(i))
                    Else
                        tmpRowDatas.Add(CType(GcurrentPop, ubiLease.GridControl.grd).get_TextMatrix(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.r1, i), CType(GcurrentPop, ubiLease.GridControl.grd).get_ColKey(i))
                    End If

                Next
            End If

        End Sub

        Private Sub afterEditGridRowDataChangeCheck()

            If IsNothing(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.Data) Then

            Else
                If IsNothing(tmpRowDatas) Then
                Else

                    Dim dataDiff As Boolean = False

                    For i As Integer = CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols To CType(GcurrentPop, ubiLease.GridControl.grd).Cols - CType(GcurrentPop, ubiLease.GridControl.grd).FixedCols

                        If tmpRowDatas(CType(GcurrentPop, ubiLease.GridControl.grd).get_ColKey(i)) = CType(GcurrentPop, ubiLease.GridControl.grd).get_TextMatrix(CType(GcurrentPop, ubiLease.GridControl.grd).CursorCell.r1, i) Then

                        Else
                            dataDiff = True
                        End If

                    Next
                    If dataDiff = True Then
                        Dim �����÷� As Integer = 0
                        �����÷� = CType(GcurrentPop, ubiLease.GridControl.grd).get_ColIndex("����")
                        If �����÷� > 0 Then
                            CType(GcurrentPop, ubiLease.GridControl.grd).set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpChecked, GcurrentPop.Row, �����÷�, C1.Win.C1FlexGrid.Classic.CellCheckedSettings.flexChecked)
                        End If
                    End If
                End If
            End If

        End Sub

        '====================================================================================================
        Private Sub frmCodeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            If e.KeyCode = Keys.Enter Then
                If Me.btnRequestData.Focused = True Then
                    btnYesNo_Click(Me.btnYes, Nothing)
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.txtName.Focus()
                Me.Hide()
                SizeReset()
            End If
        End Sub


        '====================================================================================================
        Private Sub grdMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
            btnYesNo_Click(Me.btnYes, Nothing)
        End Sub

        '====================================================================================================
        Private Sub grdMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdMain.KeyPress
            If e.KeyChar = ChrW(Keys.Return) Then
                btnYesNo_Click(Me.btnYes, Nothing)
            End If
        End Sub

        '====================================================================================================
        Private Sub frmCodeName_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
            Me.txtName.Focus()
            Me.Hide()
            SizeReset()
        End Sub

        '====================================================================================================
        Private Sub frmCodeName_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
            Me.StartPosition = FormStartPosition.CenterParent
        End Sub

        Private Sub SizeReset()
            'popupmanager.SetLayout(Me, MpopupLayout)
        End Sub
    End Class



End Namespace
