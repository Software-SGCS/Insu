Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class HthEmployeeMaster1
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim Sinvno As String
    Dim TempEmpno, TempCom As String
    Dim ss As String
    Dim Tno As String
    Dim Tno1 As String
    Dim Tno2 As String
    Dim count1, Count2 As Integer
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno, strEmpAdd, StrEmpDoA, Strcld, strOld, PFlag, psec As String

    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents LstEmpNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtRNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents LstReltyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstCom1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEmpNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtIdNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEmpAdd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtDoA As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRelId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtOldepfno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtchd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtrelage As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg As System.Web.UI.WebControls.TextBox
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtOldepfno1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldepfno2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldepfno3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldepfno4 As System.Web.UI.WebControls.TextBox
    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init

        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        PFlag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        count1 = DS.Tables("UsdMaster").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                Count2 = drt2("User_lvl")
                psec = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If





        If Count2 = "1" Then
            PFlag = "Y"

        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HthEmployeeMaster.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If

                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                PFlag = "Y"
            End While

            DR.Close()

        End If


        If PFlag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else

            Response.Redirect("POSDispaly11.aspx")
        End If

        'BtnUpdate.Enabled = True





        If Not IsPostBack Then
            If psec = "ALL" Then
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
            Else
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(psec) & "'", CON)
            End If

            DR = CMD.ExecuteReader

            LstCom1.Items.Clear()

            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCom1.Items.Add(TT)
            End While



            BindTheGrid()

            DR.Close()

        End If
        If Not IsPostBack Then

            CON.Open()
            CMD = New SqlCommand("SELECT EpfNo,EmployeeName,Com From HthMaster where com='" & Mid(Trim(LstCom1.SelectedValue), 1, 3) & "'and EmpAct='P' order by Com,EpfNo", CON)

            DR = CMD.ExecuteReader



            LstEmpNo.Items.Clear()

            While DR.Read
                Tno = "00000"
                Tno = Tno + Trim(DR.GetValue(0))
                Tno = Right(Tno, 5)
                Tno1 = Space(30)
                Tno1 = DR.GetValue(1) + Tno1
                Tno1 = Mid(Tno1, 1, 30)
                Tno2 = Mid(DR.GetValue(2), 1, 3)
                TT = Tno + " - " + Tno2 + " - " + Tno1
                LstEmpNo.Items.Add(TT)
            End While

            DR.Close()


        End If




        CMD = New SqlCommand("SELECT Emp_RelType From RelationType", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                LstReltyp.Items.Add(TT)
            End While
        End If

        DR.Close()

        'BindTheGrid()

        CON.Close()
    End Sub
    Public Sub BindTheGrid()
        'Try
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()




        If CHKDUP = True Then
            TempEmpno = Mid(TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom1.SelectedValue, 1, 3)

        Else
            TempEmpno = Mid(TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom1.SelectedValue, 1, 3)

        End If

        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"

        If Trim(TxtEmpNam.Text) = "" Then
            Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Rel_Nam,Rel_Type,CONVERT(VARCHAR(10),Rel_DOB,103) AS Rel_DOB,Rel_IdNo,Dea_Flag from EmpMaster2 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='999'", CON)
            cmdCustomers.CommandType = CommandType.Text

            MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
            MyDataGrid.DataBind()

            MyDataGrid.Visible = True
            CON.Close()




        Else
            Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Rel_Nam,Rel_Type,CONVERT(VARCHAR(10),Rel_DOB,103) AS Rel_DOB,Rel_IdNo,Dea_Flag from EmpMaster2 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'", CON)
            cmdCustomers.CommandType = CommandType.Text

            MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
            MyDataGrid.DataBind()

            MyDataGrid.Visible = True
            CON.Close()


        End If
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)


        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub BindTheGrid1()




        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, Inv_pr as InvPr,Inv_Qty as InvQty, Inv_val as InvVal from InlTemp", CON)

        cmdCustomers.CommandType = CommandType.Text

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()
    End Sub




    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'Lstcom.Visible = False
        LstEmpNo.Enabled = False
        LstEmpNo.Visible = False
        TxtEmpNo.Visible = True
        CHKDUP = True
        TxtEmpNo.Text = " "

        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)
        DS = New DataSet
        ADA.Fill(DS, "InvoiceNo")


    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        LstEmpNo.Enabled = True
        LstEmpNo.Visible = True
        TxtEmpNo.Visible = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        CHKDUP = False
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    End Sub

    Public Function BindTheCountry()
        Dim strConn As String = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        Dim MySQL As String = "Select Emp_No,Emp_name, Emp_des, " & _
        "Emp_talv, Emp_balv, Emp_tolv from EmpMast"
        Dim MyConn As New SqlConnection(strConn)
        Dim objDR As SqlDataReader
        Dim Cmd As New SqlCommand(MySQL, MyConn)
        MyConn.Open()
        objDR = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()

        Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT Flag FROM Flag", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        Return cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Sub dtgCustomers_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        ' Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        'objConn = New SqlConnection
        'objConn.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        'objConn.Open()


        Dim cmdCustomers As SqlCommand
        Dim strid As String = CType(e.Item.FindControl("lblNo"), Label).Text
        Dim strfg As String = CType(e.Item.FindControl("ddlCountry"), DropDownList).SelectedItem.Value
        Dim strTpay As Double = Val(CType(e.Item.FindControl("lblTpay"), Label).Text)
        Dim strEfdt As String = CType(e.Item.FindControl("lblEfdt"), Label).Text
        Dim strExdt As String = CType(e.Item.FindControl("lblExdt"), Label).Text
        Dim strVal As String = CType(e.Item.FindControl("lblVal"), Label).Text
        Dim strCom As String = CType(e.Item.FindControl("lblCom"), Label).Text

        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String

        strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "' WHERE ALLOW2='Select' and Veh_No='" & strid & "'"
        cmdCustomers = New SqlCommand(strSql, objConn)
        ' objConn.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        dtgCustomers.EditItemIndex = -1
        BindTheGrid1()
        dtgCustomers.Visible = True

        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", objConn)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count1 = DS.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each dr1 In DS.Tables("EmpMast").Rows
                Talv = dr1("Emp_talv")
                Balv = dr1("Emp_balv")
                str_no = dr1("Emp_no")
                str_name = dr1("Emp_name")
                str_mail = dr1("Emp_email")
            Next
        End If

        'TxtNam.Text = dr1("Emp_Name")
        'TxtToLv.Text = dr1("Emp_ToLv")
        'TxtTaLv.Text = dr1("Emp_TaLv")
        'TxtCntNo.Text = dr1("Emp_CntNo")
        ' cmdCustomers.Connection = objConn
        Dim SS As String
        ' SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
        '''cmdCustomers = New SqlCommand(SS, objConn)
        '''objConn.Open()
        '''cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        If strfg = "Approved" Then
            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "121212"
            'TxtMail.Text
            emailMessage.To = str_mail
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Your Payment Notice is Ok"

            emailMessage.Body = "Vehcle No :" + strid + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://sgcsser/Insu/Crs.aspx"
            ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)
                'labelStatus.Text = "Message sent!"
                'Button1.Enabled = False
            Catch ex As Exception
                'labelStatus.Text="Unable to send the e-mail message"
                ' labelStatus.Text = ex.ToString
            End Try
        Else
            If strfg = "Not Approved" Then
                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "1212"
                'TxtMail.Text()
                emailMessage.To = str_mail
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Your Insu Approval is not Ok"

                emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"
                ' SS = "ID NO: " + TxtId.Text + " " + TxtNam.Text + "  For Your Approval " + "http://192.168.12.207/Insu/LeaveApproval.aspx"

                SmtpMail.SmtpServer = "mail.dsisamson.com"
                Try
                    SmtpMail.Send(emailMessage)
                    'labelStatus.Text = "Message sent!"
                    'Button1.Enabled = False
                Catch ex As Exception
                    'labelStatus.Text="Unable to send the e-mail message"
                    ' labelStatus.Text = ex.ToString
                End Try


            End If



        End If

        BindTheGrid()


    End Sub
    Sub MyDataGrid_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        Dim J As Integer
        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text


        Dim StrSql As String
        J = MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))

        StrSql = "UPDATE InlTemp SET Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"
        cmdCustomers = New SqlCommand(StrSql, CON)
        ' objConn.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid1()
        MyDataGrid.Visible = True

    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim EMPCOM, EMPNO, RELNAM, RELTYPE, RELAGE, RELIDNO, ENTCODE, ENTDATE As String
        Dim I As Double
        I = MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))
        ADA = New SqlDataAdapter("SELECT * from EmpMaster2 Where id = " & I, CON)

        DS = New DataSet
        ADA.Fill(DS, "EmpMaster2")

        count1 = DS.Tables("EmpMaster2").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("EmpMaster2").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")
                EMPCOM = drt2("Emp_Com")
                EMPNO = drt2("Emp_No")
                RELNAM = drt2("Rel_Nam")
                RELTYPE = drt2("Rel_Type")
                'RELAGE = drt2("Rel_Age")
                RELIDNO = drt2("Rel_Idno")
                'ENTCODE = drt2("Ent_Code")

                ss = IIf(IsDBNull(drt2("Ent_Date")), Today(), drt2("Ent_Date"))

                ENTDATE = Format(CDate(ss), "MM/dd/yyyy")

                'ENTDATE = Format(drt2("Ent_Date"), "dd/MM/yyyy")
            Next

        End If
        'If Trim(RELNAM) <> "Nil" Then


        Dim DeleteCmd As String = "DELETE from EmpMaster2 Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)


        ' If Trim(L1.Text) = "SHAKILA" Then


        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))



        'Dim MyConn As New SqlConnection(CON)

        CON.Open()
        Cmd.ExecuteNonQuery()

        Dim emailMessage As MailMessage
        emailMessage = New MailMessage
        emailMessage.From = "insurance@dsisamson.com"
        'TxtMail.Text
        emailMessage.To = "udanip@samsoncorporates.com,shakilaw@samsoncorporates.com"
        'emailMessage.Attachments.Add("c:\RtnTxt.txt")
        'emailMessage.Cc = str_mail
        'emailMessage.Bcc = em1
        emailMessage.Subject = "Record Deleted -Health Fund"

        emailMessage.Body += "Company:" + Trim(EMPCOM) + " EmpNo" + EMPNO + " Employee " + Trim(TxtEmpNam.Text) & vbCrLf
        emailMessage.Body += "Folowing Record Deleted" & vbCrLf
        emailMessage.Body += "----------------------" & vbCrLf
        emailMessage.Body += "Name:" + Trim(RELNAM) + " Type: " + Trim(RELTYPE) & vbCrLf
        emailMessage.Body += "User Code:" + Trim(ENTCODE) + " Date: " + Format(DateValue(ENTDATE), "dd/MM/yyyy") & vbCrLf
        emailMessage.Body += "Deleted By:" + Trim(Trim(L1.Text)) & vbCrLf


        ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

        SmtpMail.SmtpServer = "mail.dsisamson.com"
        Try
            SmtpMail.Send(emailMessage)
            'labelStatus.Text = "Message sent!"
            'Button1.Enabled = False
        Catch ex As Exception
            'labelStatus.Text="Unable to send the e-mail message"
            ' labelStatus.Text = ex.ToString
        End Try
        ' Else
        'If ENTDATE = Format(DateValue(Today()), "dd/MM/yyyy") Then

        '    Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))



        '    'Dim MyConn As New SqlConnection(CON)

        '    CON.Open()
        '    Cmd.ExecuteNonQuery()

        'End If


        'End If



        ' End If








        ' Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        ' CON.Open()
        'Cmd.ExecuteNonQuery()
        'CON.Close()







        BindTheGrid()
    End Sub
    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = e.Item.ItemIndex
        BindTheGrid()
    End Sub
    Sub MyDataGrid_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
    End Sub


    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNo.TextChanged
        LstCom1.Enabled = True


        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Val(TxtEmpNo.Text) & " and Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "' and EmpAct='P' ", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = " & Val(TxtEmpNo.Text) & "' and com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthMaster")

        count1 = DS.Tables("HthMaster").Rows.Count

        If count1 <> 0 Then
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtEmpAdd.Enabled = True
            TxtDoA.Enabled = True
            For Each drt2 In DS.Tables("HthMaster").Rows
                StrEmpno = drt2("Epfno")
                StrEmpCom = drt2("Com")
                StrEmpNam = drt2("EmployeeName")
                strEmpIdno = drt2("EmpIdno")
                strEmpAdd = IIf(IsDBNull(drt2("EmpAdd")) = True, "Blank ", drt2("EmpAdd"))
                StrEmpDoA = IIf(IsDBNull(drt2("Dob")) = True, CDate(Today()), Format(CDate(drt2("dob")), "dd/MM/yyyy"))
                Strcld = IIf(IsDBNull(drt2("EmpCld")) = True, "0", drt2("EmpCld"))
                strOld = IIf(IsDBNull(drt2("OldEpfNo")) = True, drt2("Epfno"), drt2("OldEpfNo"))
                TxtEmpNam.Text = StrEmpNam
                TxtIdNo.Text = strEmpIdno
                TxtEmpAdd.Text = strEmpAdd
                TxtDoA.Text = StrEmpDoA
                Txtchd.Text = Strcld
                TxtOldepfno.Text = strOld
                TxtOldepfno1.Text = IIf(IsDBNull(drt2("OldEpfNo1")) = True, drt2("Epfno"), drt2("OldEpfNo1"))
                TxtOldepfno2.Text = IIf(IsDBNull(drt2("OldEpfNo2")) = True, drt2("Epfno"), drt2("OldEpfNo2"))
                TxtOldepfno3.Text = IIf(IsDBNull(drt2("OldEpfNo3")) = True, drt2("Epfno"), drt2("OldEpfNo3"))
                TxtOldepfno4.Text = IIf(IsDBNull(drt2("OldEpfNo4")) = True, drt2("Epfno"), drt2("OldEpfNo4"))

                Txtfg.Text = IIf(IsDBNull(drt2("EmpAct")) = True, "D", drt2("EmpAct"))
            Next
        Else
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtDoA.Enabled = True
            TxtEmpAdd.Enabled = True

            TxtEmpNam.Text = " "
            TxtIdNo.Text = " "
            TxtEmpAdd.Text = " "
            TxtDoA.Text = " "
            Txtchd.Text = " "
            TxtOldepfno.Text = " "

        End If

        TxtRNam.Text = " "
        TxtRelId.Text = " "
        Txtrelage.Text = " "
        Txtfg.Text = "Y"

        BindTheGrid()


    End Sub

    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpNo.SelectedIndexChanged
        TxtRNam.Text = " "
        TxtRNam.Text = " "
        TxtRelId.Text = " "
        Txtrelage.Text = " "
        Txtfg.Text = "N"
        TxtEmpNo.Text = Val(Trim(Mid(LstEmpNo.SelectedValue, 1, 5)))

        LstCom1.Enabled = True


        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = " & TxtEmpNo.Text & ") and (Com ='" & Mid(Trim(LstCom1.SelectedValue), 1, 3) & "')", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthMaster WHERE (EpfNo = " & TxtEmpNo.Text & ") and (Com ='" & Mid(Trim(LstCom1.SelectedValue), 1, 3) & "')"



        ADA.Fill(DS, "HthMaster")

        count1 = DS.Tables("HthMaster").Rows.Count

        If count1 <> 0 Then
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtEmpAdd.Enabled = True
            TxtDoA.Enabled = True
            For Each drt2 In DS.Tables("HthMaster").Rows
                StrEmpno = drt2("Epfno")
                StrEmpCom = drt2("Com")
                StrEmpNam = drt2("EmployeeName")
                strEmpIdno = drt2("EmpIdno")
                strEmpAdd = IIf(IsDBNull(drt2("EmpAdd")) = True, "Blank ", drt2("EmpAdd"))
                StrEmpDoA = IIf(IsDBNull(drt2("Dob")) = True, CDate(Today()), Format(CDate(drt2("dob")), "dd/MM/yyyy"))
                Strcld = IIf(IsDBNull(drt2("EmpCld")) = True, "0", drt2("EmpCld"))
                strOld = IIf(IsDBNull(drt2("OldEpfNo")) = True, drt2("Epfno"), drt2("OldEpfNo"))
                TxtEmpNam.Text = StrEmpNam
                TxtIdNo.Text = strEmpIdno
                TxtEmpAdd.Text = strEmpAdd
                TxtDoA.Text = StrEmpDoA
                Txtchd.Text = Strcld
                TxtOldepfno.Text = strOld
                Txtfg.Text = IIf(IsDBNull(drt2("EmpAct")) = True, "D", drt2("EmpAct"))
                TxtOldepfno1.Text = IIf(IsDBNull(drt2("OldEpfNo1")) = True, drt2("Epfno"), drt2("OldEpfNo1"))
                TxtOldepfno2.Text = IIf(IsDBNull(drt2("OldEpfNo2")) = True, drt2("Epfno"), drt2("OldEpfNo2"))
                TxtOldepfno3.Text = IIf(IsDBNull(drt2("OldEpfNo3")) = True, drt2("Epfno"), drt2("OldEpfNo3"))
                TxtOldepfno4.Text = IIf(IsDBNull(drt2("OldEpfNo4")) = True, drt2("Epfno"), drt2("OldEpfNo4"))
            Next
        Else
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtDoA.Enabled = True
            TxtEmpAdd.Enabled = True

            TxtEmpNam.Text = " "
            TxtIdNo.Text = " "
            TxtEmpAdd.Text = " "
            TxtDoA.Text = " "
            Txtchd.Text = " "
            TxtOldepfno.Text = " "

        End If

        TxtRNam.Text = " "
        TxtRelId.Text = " "
        Txtrelage.Text = " "
        Txtfg.Text = "Y"

        BindTheGrid()




        'BindTheGrid()
    End Sub

    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
    End Sub

    Private Sub BttIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttIns.Click
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpNam As String
        Dim SEmpRetype As String
        Dim SEmpAge As String
        Dim SEmpIdno As String
        Dim SEmpFlag As String
        Dim SEmpChqNo As String
        'Dim SEmpFlag As String




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        SEmpno = Mid(TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(LstCom1.SelectedValue, 1, 3)
        SEmpNam = Trim(TxtRNam.Text)
        SEmpRetype = LstReltyp.SelectedValue
        SEmpAge = Trim(Txtrelage.Text)
        SEmpIdno = Trim(TxtRelId.Text)
        SEmpChqNo = Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4)
        'SEmpChqNo = TxtChqNo.Text
        SEmpFlag = Trim(Txtfg.Text)



        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = '" & Trim(TxtEmpNo.Text) & "' and Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"

        ADA.Fill(DS, "HthMaster")

        count1 = DS.Tables("HthMaster").Rows.Count

        If Trim(TxtOldepfno.Text) = "" Then
            TxtOldepfno.Text = Trim(TxtEmpNo.Text)
        End If
        If Trim(TxtOldepfno1.Text) = "" Then
            TxtOldepfno1.Text = Trim(TxtEmpNo.Text)
        End If
        If Trim(TxtOldepfno2.Text) = "" Then
            TxtOldepfno2.Text = Trim(TxtEmpNo.Text)
        End If

        If Trim(TxtOldepfno3.Text) = "" Then
            TxtOldepfno3.Text = Trim(TxtEmpNo.Text)
        End If

        If Trim(TxtOldepfno4.Text) = "" Then
            TxtOldepfno4.Text = Trim(TxtEmpNo.Text)
        End If




        If count1 <> 0 Then

            CMD.Connection = CON
            CMD.CommandText = ("UPDATE HthMaster SET Epfno='" & Trim(TxtEmpNo.Text) & "',Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "',EmployeeName= '" & TxtEmpNam.Text & "',EmpAct1= 'N',EmpIdno= '" & TxtIdNo.Text & "',EmpAdd= '" & TxtEmpAdd.Text & "',OldEpfno= '" & TxtOldepfno.Text & "',OldEpfno1= " & TxtOldepfno1.Text & ",OldEpfno2= " & TxtOldepfno2.Text & ",OldEpfno3= " & TxtOldepfno3.Text & ",OldEpfno4= " & TxtOldepfno4.Text & ",Empcld= '" & Txtchd.Text & "',Dob= '" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "' WHERE Epfno=" & TxtEmpNo.Text & " and Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'")
            CMD.ExecuteNonQuery()

        Else
            CMD.Connection = CON
            ss = "INSERT INTO HthMaster(Epfno,Com,EmployeeName,EmpIdno,EmpAdd,EmpAct,EmpAct1,dob,empcld,oldepfno,oldepfno1,oldepfno2,oldepfno3,oldepfno4,Ent_code,Ent_Time,Ent_date) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom1.SelectedValue, 1, 3) & "','" & TxtEmpNam.Text & "','" & TxtIdNo.Text & "','" & TxtEmpAdd.Text & "','P','N','" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "','" & Txtchd.Text & "','" & TxtOldepfno.Text & "','" & TxtOldepfno1.Text & "','" & TxtOldepfno2.Text & "','" & TxtOldepfno3.Text & "','" & TxtOldepfno4.Text & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')"
            ss = "INSERT INTO HthMaster(Epfno,Com,EmployeeName,EmpIdno,EmpAdd,EmpAct,EmpAct1,dob,empcld,oldepfno,oldepfno1,oldepfno2,oldepfno3,oldepfno4,Ent_code,Ent_Time,Ent_date) VALUES ('" & Trim(TxtEmpNo.Text) & "','" & Trim(Mid(LstCom1.SelectedValue, 1, 3)) & "','" & Trim(TxtEmpNam.Text) & "','" & Trim(TxtIdNo.Text) & "','" & Trim(TxtEmpAdd.Text) & "','P','N','" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "','" & Trim(Txtchd.Text) & "','" & Trim(TxtOldepfno.Text) & "','" & Trim(TxtOldepfno1.Text) & "','" & Trim(TxtOldepfno2.Text) & "','" & Trim(TxtOldepfno3.Text) & "','" & Trim(TxtOldepfno4.Text) & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')"

            CMD.CommandText = ("INSERT INTO HthMaster(Epfno,Com,EmployeeName,EmpIdno,EmpAdd,EmpAct,EmpAct1,dob,empcld,oldepfno,oldepfno1,oldepfno2,oldepfno3,oldepfno4,Ent_code,Ent_Time,Ent_date) VALUES ('" & Trim(TxtEmpNo.Text) & "','" & Trim(Mid(LstCom1.SelectedValue, 1, 3)) & "','" & Trim(TxtEmpNam.Text) & "','" & Trim(TxtIdNo.Text) & "','" & Trim(TxtEmpAdd.Text) & "','P','N','" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "','" & Trim(Txtchd.Text) & "','" & Trim(TxtOldepfno.Text) & "','" & Trim(TxtOldepfno1.Text) & "','" & Trim(TxtOldepfno2.Text) & "','" & Trim(TxtOldepfno3.Text) & "','" & Trim(TxtOldepfno4.Text) & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
            CMD.ExecuteNonQuery()
        End If

        '''Act_Code='" & Trim(L1.Text) & "',Act_time='" & FormatDateTime(TimeOfDay) & "',Act_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") &

        ADA1 = New SqlDataAdapter("SELECT * FROM EmpMaster2 WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)

        'ADA1 = New SqlDataAdapter("SELECT * FROM EmpMaster1 WHERE Emp_No = '" & TxtEmpNo.Text & "'", CON)
        DS1 = New DataSet
        ss = "SELECT * FROM EmpMaster2 WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA1.Fill(DS1, "EMPMASTER2")

        Count2 = DS1.Tables("EmpMaster2").Rows.Count

        If Count2 <> 0 Then
            Count2 = Count2 + 1
        Else
            Count2 = 1
        End If
        ss = "INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & Count2 & ",'" & Trim(SEmpno) & "','" & SEmpcom & "','" & SEmpNam & "','Nil','" & Mid(Trim(SEmpAge), 4, 2) + "/" + Mid(Trim(SEmpAge), 1, 2) + "/" + Mid(Trim(SEmpAge), 7, 4) & "','" & SEmpIdno & "','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')"



        If Trim(TxtRNam.Text) = "" Then

            CMD.Connection = CON

            CMD.CommandText = ("INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & Count2 & ",'" & Trim(SEmpno) & "','" & SEmpcom & "','Nil','Nil','" & Format(DateValue(Today()), "MM/dd/yyyy") & "','Nil','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
            CMD.ExecuteNonQuery()

            Txtfg.Text = "Y"
            TxtRelId.Text = " "
            TxtRNam.Text = " "

            TxtOldepfno.Text = ""
            TxtOldepfno1.Text = ""
            TxtOldepfno2.Text = ""
            TxtOldepfno3.Text = ""
            TxtOldepfno4.Text = ""


        Else
            CMD.Connection = CON
            ss = "INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & Count2 & ",'" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "','" & Mid(Trim(SEmpAge), 4, 2) + "/" + Mid(Trim(SEmpAge), 1, 2) + "/" + Mid(Trim(SEmpAge), 7, 4) & "','" & SEmpIdno & "','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')"
            CMD.CommandText = ("INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & Count2 & ",'" & Trim(SEmpno) & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "','" & Mid(Trim(SEmpAge), 4, 2) + "/" + Mid(Trim(SEmpAge), 1, 2) + "/" + Mid(Trim(SEmpAge), 7, 4) & "','" & SEmpIdno & "','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & Trim(FormatDateTime(TimeOfDay)) & "','" & Trim(Format(DateValue(Today()), "MM/dd/yyyy")) & "')")
            CMD.ExecuteNonQuery()

            Txtfg.Text = "Y"
            TxtRelId.Text = " "
            TxtRNam.Text = " "
            TxtOldepfno.Text = ""
            TxtOldepfno1.Text = ""
            TxtOldepfno2.Text = ""
            TxtOldepfno3.Text = ""
            TxtOldepfno4.Text = ""
        End If




        BindTheGrid()

    End Sub

    Private Sub LstCom1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom1.SelectedIndexChanged
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        ss = "SELECT EpfNo,EmployeeName,Com From HthMaster where com='" & Mid(Trim(LstCom1.SelectedValue), 1, 3) & "' order by Com,EpfNo"

        CMD = New SqlCommand("SELECT EpfNo,EmployeeName,Com From HthMaster where com='" & Trim(Mid(Trim(LstCom1.SelectedValue), 1, 3)) & "' and EmpAct='P' order by Com,EpfNo", CON)

        DR = CMD.ExecuteReader


        ' If Not IsPostBack Then
        LstEmpNo.Items.Clear()

        While DR.Read
            Tno = "00000"
            Tno = Tno + Trim(DR.GetValue(0))

            Tno1 = Tno
            Tno = Right(Tno, 5)


            Tno1 = Space(30)
            Tno1 = DR.GetValue(1) + Tno1
            Tno1 = Mid(Tno1, 1, 30)
            Tno2 = Mid(DR.GetValue(2), 1, 3)
            TT = Tno + " - " + Tno2 + " - " + Tno1
            LstEmpNo.Items.Add(TT)
        End While
        'End If

        DR.Close()



    End Sub

    Private Sub TxtIdNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdNo.TextChanged

    End Sub
End Class

