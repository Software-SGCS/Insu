Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class InsuApproval
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Public ss As String
    Dim Dtr, Dtr1, dtr2 As DataRow
    Public PVehno As String
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtUser As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Pan1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtUser1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtPwd1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents Txtss As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtMail As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Radiobutton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Radiobutton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents BttApp As System.Web.UI.WebControls.Button
    Protected strCountry As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        '---------------
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")


        Dim User1 As String
        Dim Pwd1 As String
        Dim Count, Count1, Count2 As Double
        Dim dr1, dr2, dr3 As DataRow
        'User1 = TxtUser1.Text
        'Pwd1 = TxtPwd1.Text
        User1 = "11111"
        Pwd1 = "11111"
        ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_User = '" & User1 & "' AND AD_pwd = '" & Pwd1 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "ADMIN")

        Count = DS.Tables("ADMIN").Rows.Count
        If Count <> 0 Then
            dtgCustomers.Visible = True
            TxtNam.Enabled = True
            TxtNam.ReadOnly = True

            ss = ""

            For Each dr1 In DS.Tables("Admin").Rows
                TxtNam.Text = dr1("Ad_Nam")
                TxtMail.Text = dr1("Ad_email")
                ss = ss + "'" + dr1("Ad_Com") + "',"
            Next
            Dim ss1 As String
            Dim ln As Integer
            ss1 = ss
            ln = Len(ss)
            ss = Mid(ss, 1, (ln - 1))
            Txtss.Text = ss
            BindTheGrid1()

        Else
            'dtgCustomers.Visible = False
        End If
        '-------------


        Txtss.Visible = False
        TxtMail.Visible = False

        If Not IsPostBack Then
            'dtgCustomers.Visible = False
            Txtss.Visible = False
            BindTheGrid()
        End If
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
    End Sub
    Public Sub BindTheGrid()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()

        '"Select Inv_No,Inv_Com, Format(Inv_Dt,'dd/MM/yyyy') as InvDt,Inv_pono, Format(Inv_TotVal,'#,###.00') as Inv_TotVal, Format(Inv_TotQty,'###') as Inv_TotQty,Inv_flag2 from InhInv where Inv_flag2='Select'", objConn)

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ, Convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, Convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,Veh_TotChqPay,Allow1,Veh_bpay,Veh_rcc,Veh_tr from VehMast where Allow1='Select' and Veh_CertifyNo<>' '", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        dtgCustomers.DataSource = cmdCustomers.ExecuteReader()
        dtgCustomers.DataBind()
        objConn.Close()
    End Sub

    Public Sub BindTheGrid1()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()

        ' Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ,Veh_EfDt, Veh_Exdt, Veh_tpay,Veh_val,Veh_bpay,Veh_rcc,Veh_tr,Allow1 from VehMast where Allow1='Select'", objConn)
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ, Convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, Convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,Veh_TotChqPay,Allow1,Veh_bpay,Veh_rcc,Veh_tr from VehMast where Allow1='Select' and Veh_CertifyNo<>' '", objConn)
        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        dtgCustomers.DataSource = cmdCustomers.ExecuteReader()
        dtgCustomers.DataBind()
        objConn.Close()
    End Sub

    Sub dtgCustomers_Edit(ByVal Sender As Object, ByVal E As DataGridCommandEventArgs)
        strCountry = CType(E.Item.FindControl("lblfg"), Label).Text
        dtgCustomers.EditItemIndex = CInt(E.Item.ItemIndex)
        BindTheGrid1()
    End Sub

    Public Sub dtgCustomers_Cancel(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        dtgCustomers.EditItemIndex = -1
        BindTheGrid1()
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
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()


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

        strSql = "UPDATE VehMast SET Allow1='" & strfg & "' WHERE Allow1='Select' and Veh_No='" & strid & "'"
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
            emailMessage.From = TxtMail.Text
            emailMessage.To = "insurance@dsisamson.com"
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Your Approval is Ok"

            emailMessage.Body = "Vehcle No :" + strid + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://sgcsser/Insu/CrsCertificate.aspx"
            ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

            SmtpMail.SmtpServer = "192.168.12.6"
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
                emailMessage.From = TxtMail.Text
                emailMessage.To = str_mail
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Your Insu Approval is not Ok"

                emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"
                ' SS = "ID NO: " + TxtId.Text + " " + TxtNam.Text + "  For Your Approval " + "http://192.168.12.207/Insu/LeaveApproval.aspx"

                SmtpMail.SmtpServer = "192.168.12.6"
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

    Public Sub SetDropDownIndex(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ed As System.Web.UI.WebControls.DropDownList
        ed = sender
        ed.SelectedIndex = ed.Items.IndexOf(ed.Items.FindByText(strCountry))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub


    Private Sub TxtUser1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUser1.TextChanged

    End Sub

    Sub MyDataGrid_DeleteCommand(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        Dim ss1 As String
        ss = CType(e.Item.FindControl("lblNo"), Label).Text

        Global.PVehno = CType(e.Item.FindControl("lblNo"), Label).Text

        Dim strReport As String = ""
        strReport = "NewApp7.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=900,width=750,left=10,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)




    End Sub

    Private Sub dtgCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCustomers.SelectedIndexChanged

    End Sub

    Private Sub Radiobutton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiobutton1.CheckedChanged
        'RadBt2.Checked = False
        Dim strReport As String = ""
        strReport = "ViewReport3.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)

    End Sub

    Private Sub Radiobutton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiobutton2.CheckedChanged
        'RadBt1.Checked = False
        Dim strReport As String = ""
        strReport = "ViewReport4.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)

    End Sub

    Private Sub BttApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttApp.Click
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        Dim strfg As String
        Dim cmdCustomers As SqlCommand

        Dim strTpay As Double
        Dim strEfdt As String
        Dim strExdt As String
        Dim strVal As String
        Dim strCom As String
        Dim strvehno As String

        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String
        strfg = "Approved"

        strSql = "UPDATE VehMast SET Allow1='" & strfg & "' WHERE Allow1='Select' and Veh_No='" & Global.PVehno & "'"
        'strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & Global.PVehno & "'"
        'cmdCustomers = New SqlCommand(strSql, CON)

        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        'CON.Close()




        ADA1 = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", CON)
        DS1 = New DataSet
        ADA1.Fill(DS1, "EmpMast")

        Count1 = DS1.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each Dtr1 In DS1.Tables("EmpMast").Rows
                Talv = Dtr1("Emp_talv")
                Balv = Dtr1("Emp_balv")
                str_no = Dtr1("Emp_no")
                str_name = Dtr1("Emp_name")
                str_mail = Dtr1("Emp_email")
            Next
        End If

        ADA1 = New SqlDataAdapter("SELECT * FROM VehMast WHERE Allow1='Select'", CON)
        DS = New DataSet
        ADA1.Fill(DS, "VehMast")

        Count1 = DS.Tables("VehMast").Rows.Count
        If Count1 <> 0 Then
            For Each dtr2 In DS.Tables("VehMast").Rows
                strvehno = dtr2("Veh_No")
                strTpay = dtr2("Veh_Tpay")
                strEfdt = dtr2("Veh_EfDt")
                strExdt = dtr2("Veh_ExDt")
                strVal = dtr2("Veh_Val")
                strCom = dtr2("Veh_Com")

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "chamindas@dsisamson.com"


                emailMessage.To = str_mail
                'emailMessage.To = "palithan@dsisamson.com"

                emailMessage.Subject = "Your Certificate is Ok"

                emailMessage.Body = "Vehcle No :" + strvehno + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://sgcsser/Insu/CrsCertificate.aspx"


                SmtpMail.SmtpServer = "192.168.12.6"
                Try
                    SmtpMail.Send(emailMessage)

                Catch ex As Exception

                End Try




            Next
        End If

        CON.Close()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        strSql = "UPDATE VehMast SET Allow1='" & strfg & "' WHERE Allow1='Select'"
        'strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & Global.PVehno & "'"
        cmdCustomers = New SqlCommand(strSql, CON)

        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        CON.Close()


        BindTheGrid()






        Dim SS As String

        If strfg = "Approved" Then

        End If


        ' Button1.Enabled = False
        'Button1.Text = "O K"
        'If strfg = "Not Approved" Then
        '    Dim emailMessage As MailMessage
        '    emailMessage = New MailMessage
        '    emailMessage.From = "chamindas@dsisamson.com"
        '    emailMessage.To = str_mail

        '    emailMessage.Subject = "Your Insu Approval is not Ok"

        '    emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"


        '    SmtpMail.SmtpServer = "192.168.12.6"
        '    Try
        '        SmtpMail.Send(emailMessage)

        '    Catch ex As Exception

        '    End Try


        'End If

    End Sub

End Class
