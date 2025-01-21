Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class DeathDonationEntry1
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS As DataSet
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
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents LstEmpNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents LstCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents LstReNAM As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Txtappdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtflag As System.Web.UI.WebControls.TextBox
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
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init

        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DeathDonation2.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        'If Global.PwFlag = "Y" Then

        'Else
        '    Response.Redirect("InsuDept.aspx")
        'End If


        CMD = New SqlCommand("SELECT EPFNO,NAME,COM From HltMast where flag='Y' order by COM,EPFNO", CON)

        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                Tno = "00000"
                Tno = Tno + DR.GetValue(0)
                Tno = Right(Tno, 5)
                Tno1 = Space(30)
                Tno1 = DR.GetValue(1) + Tno1
                Tno1 = Mid(Tno1, 1, 30)
                Tno2 = Mid(DR.GetValue(2), 1, 3)
                TT = Tno + " - " + Tno2 + " - " + Tno1
                LstEmpNo.Items.Add(TT)
            End While
        End If

        DR.Close()

        TempCom = Mid(Trim(LstEmpNo.SelectedValue), 9, 3)
        TempEmpno = Trim(Str(Val(Mid(Trim(LstEmpNo.SelectedValue), 1, 5))))


        CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & TempCom & "'", CON)


        DR = CMD.ExecuteReader



        While DR.Read
            TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            LstCom.Text = TT
        End While


        DR.Close()

        If Not IsPostBack Then
            'TxtYr.Text = Year(Today())


            CMD = New SqlCommand("SELECT Tre_Typ From TreType", CON)

            DR = CMD.ExecuteReader



            While DR.Read
                TT = DR.GetValue(0)
                Lsttyp.Items.Add(TT)
            End While


            DR.Close()
        End If


        ss = "SELECT EPFNO,NAME,COM From HltMast where flag='N' AND EPFNO='" & TempEmpno & "' order by COM,EPFNO"


        CMD = New SqlCommand("SELECT EPFNO,NAME,COM From HltMast where EPFNO='" & TempEmpno & "'", CON)


        DR = CMD.ExecuteReader

        LstReNAM.Items.Clear()
        'If Not IsPostBack Then
        While DR.Read
            TT = DR.GetValue(1)
            LstReNAM.Items.Add(TT)
        End While
        'End If

        DR.Close()

        BindTheGrid()


    End Sub
    Public Sub BindTheGrid()
        'Try
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        If CHKDUP = True Then
            TempEmpno = Mid(TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom.Text, 1, 3)

        Else
            TempEmpno = Mid(LstEmpNo.SelectedValue, 1, 5)
            TempCom = Mid(LstCom.Text, 1, 3)

        End If

        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dob,'dd/MM/yyyy') as Emp_Dob,format(Emp_DeathAmt,'#,###.00') as Emp_Deathamt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Trim(Emp_Com)='" & Trim(TempCom) & "'", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub BindTheGrid1()




        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, Format(Inv_pr,'#,###.00') as InvPr,format(Inv_Qty,'#,###') as InvQty, format(Inv_val,'#,###.00') as InvVal from InlTemp", CON)

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

        If BtnEdit.Enabled = True Then
            Dim DeleteCmd1 As String = "DELETE from InlInv where Inv_no='" & LstEmpNo.SelectedValue & "'"
            Dim Cmd As New SqlCommand(DeleteCmd1, CON)
            Cmd.ExecuteNonQuery()

            DeleteCmd1 = "DELETE from InlInv where Inv_no='" & LstEmpNo.SelectedValue & "'"


            Cmd.Connection = CON
            Cmd.CommandText = ("UPDATE InhInv SET Inv_com='" & Mid(LstCom.Text, 1, 3) & "',Inv_dt='" & DateValue(Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4)) & "',Inv_pono= '" & TxtEmpNo.Text & "',Inv_Code= '" & Mid(LstEmpNo.SelectedValue, 1, 5) & "',Inv_vat= '" & Mid(LstEmpNo.SelectedValue, 1, 3) & "' WHERE Inv_no='" & LstEmpNo.SelectedValue & "'")
            Cmd.ExecuteNonQuery()

            Sinvno = LstEmpNo.SelectedValue
        Else

            Cmd.Connection = CON
            Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code,Inv_Vat) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom.Text, 1, 3) & "','" & DateValue(Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4)) & "','" & TxtEmpNo.Text & "','Select','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 5) & "','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 3) & "' )")
            'Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code) VALUES ('" & TxtInvNo.Text & "','" & Mid(Lstcom.text, 1, 3) & "','" & DateValue(Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4)) & "','" & TxtPoNo.Text & "','Select','" & "','" & Mid(Trim(LstCode.SelectedValue), 1, 5) & "' )")
            Cmd.ExecuteNonQuery()
            Sinvno = TxtEmpNo.Text

        End If

        Dim gridrow As DataGridItem
        Dim i As Integer
        Dim t1, t2, t3, t4, t5, t6, t7, t8 As String

        Dim SS As String
        Dim sEmps As String
        Dim dr As DataRow
        Dim SysRtp As Integer
        Dim SysRno As String
        Dim Sysdes1 As String
        Dim sysdes2 As String
        Dim Count As Double
        Dim CMD1 As SqlCommand

        Dim TT As String
        Dim tot1, tot2 As Double
        tot1 = 0
        tot2 = 0

        For Each gridrow In MyDataGrid.Items

            t1 = gridrow.Cells(2).Text()
            t2 = gridrow.Cells(3).Text()
            t3 = gridrow.Cells(4).Text()
            t4 = gridrow.Cells(5).Text()
            t5 = gridrow.Cells(6).Text()


            Dim T3n As Double


            If BtnEdit.Enabled = True Then
                Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val) VALUES ('" & LstEmpNo.SelectedValue & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "')")
            Else
                Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val) VALUES ('" & TxtEmpNo.Text & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "')")
            End If
            Cmd.ExecuteNonQuery()
            Dim T4INT As Double
            T4INT = Val(t4)

            Cmd.CommandText = ("UPDATE ITMMAST SET ITM_STK=ITM_STK+" & T4INT & " WHERE Itm_no='" & t1 & "'")
            Cmd.ExecuteNonQuery()
            tot1 = tot1 + t4
            tot2 = tot2 + t5
        Next
        Cmd.Connection = CON
        Cmd.CommandText = ("UPDATE InhInv SET Inv_TotQty=" & tot1 & ",Inv_TotVal=" & tot2 & " WHERE Inv_no='" & Sinvno & "'")
        Cmd.ExecuteNonQuery()

        Cmd.CommandText = ("UPDATE InvoiceNo SET Inv_No='" & Mid(Sinvno, 3, 9) & "'")
        Cmd.ExecuteNonQuery()


        Dim User1 As String
        Dim Pwd1 As String
        Dim Count1, Count2 As Double

        'User1 = TxtUser1.Text
        'Pwd1 = TxtPwd1.Text
        User1 = "22222"
        Pwd1 = "22222"
        ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_User = '" & User1 & "' AND AD_pwd = '" & Pwd1 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "ADMIN")
        Dim Femail, Temail, Ename As String
        Count = DS.Tables("ADMIN").Rows.Count
        If Count <> 0 Then


            For Each drt2 In DS.Tables("Admin").Rows
                Ename = drt2("Ad_Nam")
                Temail = drt2("Ad_email")

            Next
            Dim ss1 As String
            Dim ln As Integer

            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "trading@dsisamson.com"
            emailMessage.To = Temail

            emailMessage.Subject = "Invoice Details For Check "

            emailMessage.Body = "Inv No :" + Sinvno + " " + Mid(LstCom.Text, 1, 3) + " Total Qty " + Str(tot1) + " Total Value " + Str(tot2) + " http://sgcsser/Insu/InvCheck.aspx"


            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try
        End If
        BtnSave.Enabled = False
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
        objConn.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
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

        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text


        Dim StrSql As String


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
        Dim DeleteCmd As String = "DELETE from RelationMaster Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        CON.Open()
        Cmd.ExecuteNonQuery()
        CON.Close()
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



    Private Sub MyDataGrid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtInvNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCle.Click

    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

    End Sub

    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNo.TextChanged

    End Sub

    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpNo.SelectedIndexChanged
        ' TxtRNam.Text = " "
        TxtPay.Text = " "
        'TxtChqNo.Text = " "
        'TxtDoD.Text = " "
        TxtPdt.Text = " "

        BindTheGrid()
    End Sub

    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
    End Sub

    Private Sub BttIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttIns.Click
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpFlag As String
        Dim SEmpTretyp As String
        Dim SEmpAmt As Double
        Dim SEmpAppDt As String
        Dim SEmpNam As String




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        SEmpno = Mid(LstEmpNo.SelectedValue, 1, 5)
        SEmpcom = Mid(LstCom.Text, 1, 3)
        SEmpFlag = Txtflag.Text
        SEmpNam = LstReNAM.SelectedValue
        SEmpAmt = TxtPay.Text
        SEmpTretyp = Lsttyp.SelectedValue
        SEmpAppDt = Txtappdt.Text
        'SEmpChqNo = TxtChqNo.Text
        SEmpFlag = "Y"

        CMD.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        CMD.CommandText = ("INSERT INTO HthMaster(Emp_No,Emp_Com,Emp_Nam,Emp_TreTyp,Emp_AppDt,Emp_Amt,Emp_Flag) VALUES ('" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpTretyp & "','" & Mid(Trim(SEmpAppDt), 4, 2) + "/" + Mid(Trim(SEmpAppDt), 1, 2) + "/" + Mid(Trim(SEmpAppDt), 7, 4) & "'," & SEmpAmt & ",'" & SEmpFlag & "')")
        CMD.ExecuteNonQuery()

        BindTheGrid()



    End Sub
End Class

