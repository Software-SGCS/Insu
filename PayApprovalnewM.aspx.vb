Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class PayApprovalnewM
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
    Dim Dtr, Dtr1, dtr2, drt2, drt1, drt3 As DataRow
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Public ss As String
    Protected WithEvents Txtvehno As System.Web.UI.WebControls.TextBox
    Protected WithEvents BttApp As System.Web.UI.WebControls.Button
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPwd1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtMail As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtss As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtUser1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm

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

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim PFlag, pSEC As String
        Dim COUNT1, COUNT2 As Integer

        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        ' CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()


        PFlag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        count1 = DS.Tables("UsdMaster").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                Count2 = drt2("User_lvl")
                pSEC = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If





        If Count2 = "1" Then
            PFlag = "Y"

        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level5='1'", CON)

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


        Dim User1 As String
        Dim Pwd1 As String
        Dim Count As Double
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



        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ,convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,Veh_TotChqpay,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where ALLOW2='Select' ", objConn)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ,convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,Veh_TotChqpay,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where ALLOW2<>'Approved' and ALLOW1<>'Select' ", objConn)


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



        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ,convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,Veh_TotChqpay,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where ALLOW2='Select' ", objConn)

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
        Dim strConn As String = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
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

        ' SS = "UPDATE EMPMAST SET EMP_NAME='" & Txtpayfdt.Text & "',EMP_TOLV='" & Txtpayfdt.Text & "',Allow2='Select'" & "',EMP_TALV='" & Txtbpay.Text & "',EMP_CNTNO='" & Txtval.Text & "' WHERE EMP_NO=" & IDNO & " AND EMP_COM='" & COM & "'"

        strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & strid & "'"
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
            emailMessage.To = str_mail
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Your Payment Notice is Ok"

            emailMessage.Body = "Vehcle No :" + strid + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://192.168.12.181/Insu/Crs.aspx"
            ' emailMessage.Body = "http://192.168.12.181/Insu/CrsCertificate.aspx"

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
                emailMessage.From = TxtMail.Text
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
        Dim aa As String

        Global.PVehno = CType(e.Item.FindControl("lblno"), Label).Text

        'aa = CType(e.Item.FindControl("lblno"), Label).Text
        Dim strReport As String = ""
        strReport = "NewApp6.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=900,width=750,left=10,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
        BindTheGrid()

    End Sub

    Private Sub dtgCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCustomers.SelectedIndexChanged



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

        'strSql = "UPDATE VehMast SET Allow1='" & strfg & "' WHERE Allow1='Select' and Veh_No='" & Global.PVehno & "'"
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

        ADA1 = New SqlDataAdapter("SELECT * FROM VehMast WHERE Allow2='Select'", CON)
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
                emailMessage.From = "udanip@samsoncorporates.com"


                emailMessage.To = str_mail
                'emailMessage.To = "palithan@samsoncorporates.com"

                'emailMessage.Subject = "Your Certificate is Ok"

                ' emailMessage.Body = "Vehcle No :" + strvehno + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://192.168.12.181/Insu/CrsCertificate.aspx"

                emailMessage.Subject = "Your Payment Notice is Ok"

                emailMessage.Body = "Vehcle No :" + strvehno + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://192.168.12.181/Insu/Crs.aspx"

                SmtpMail.SmtpServer = "mail.dsisamson.com"
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

        strSql = "UPDATE VehMast SET Allow2='" & strfg & "' WHERE Allow2='Select'"
        'strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & Global.PVehno & "'"
        cmdCustomers = New SqlCommand(strSql, CON)

        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        CON.Close()


        BindTheGrid()
    End Sub
End Class
