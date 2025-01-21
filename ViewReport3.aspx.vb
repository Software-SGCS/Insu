Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class ViewReport3
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim Dtr, Dtr1, dtr2 As DataRow
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1 As String

    Dim dt1 As Date
    Dim dt2 As Date
    Dim ss, ss1 As String
    'Public ss As String
    Dim date1 As Date
    Dim date2 As Date
    Dim dd1, dd2, fdate1, fdate2 As String
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
    Protected WithEvents Txtss As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtMail As System.Web.UI.WebControls.TextBox
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected strCountry As String
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents ImgBtt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Imgbtt2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Txttdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TxtFdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel10 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel

    Dim DSS As CryTaxInv = New CryTaxInv

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
        CON.Open()


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ViewReport3.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            Response.Redirect("InsuDept.aspx")
        End If



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



        Else
            'dtgCustomers.Visible = False
        End If
        '-------------


        Txtss.Visible = False
        TxtMail.Visible = False

        If Not IsPostBack Then
            'dtgCustomers.Visible = False
            Txtss.Visible = False
            dt1 = Date.Today

            dt2 = Date.Today
            TxtFdt.Text = Format(dt1, ("dd/MM/yyyy"))

            Txttdt.Text = Format(dt2, ("dd/MM/yyyy"))


            Calendar1.Visible = False

            Calendar2.Visible = False



            BindTheGrid()
        End If
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
    End Sub
    Public Sub BindTheGrid()


        dd1 = Mid(TxtFdt.Text, 1, 2) + "/" + Mid(TxtFdt.Text, 4, 2) + "/" + Mid(TxtFdt.Text, 7, 4)
        dd2 = Mid(Txttdt.Text, 1, 2) + "/" + Mid(Txttdt.Text, 4, 2) + "/" + Mid(Txttdt.Text, 7, 4)
        date1 = (dd1)
        date2 = (dd2)

        fdate1 = CDate(Format(date1, "MM/dd/yyyy"))

        fdate2 = CDate(Format(date2, "MM/dd/yyyy"))

        ' SELECT InhInv.Inv_No, InhInv.Inv_Com, InhInv.Inv_Dt, InhInv.Inv_TotVal, InhInv.Inv_TotQty, InhInv.Inv_Flag1, InhInv.Inv_pono, InhInv.Inv_code, InhInv.Inv_Flag2, InhInv.Inv_vat
        ' FROM(InhInv)'
        'WHERE (((InhInv.Inv_Dt)>=#7/1/2006# And (InhInv.Inv_Dt)<=#7/15/2006#) AND ((InhInv.Inv_Flag2)="Approved"));'

        ss1 = "Approved"
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, format(Inv_pr,'#,###.00') as InvPr,format(Inv_Qty,'#,###') as InvQty, format(Inv_val,'#,###.00') as InvVal from InlTemp", CON)
        ss = "Select InhInv.Inv_No,InhInv.Inv_Com, convert(varchar(10),InhInv.Inv_Dt,103) as InvDt,InhInv.Inv_pono, InhInv.Inv_TotVal, InhInv.Inv_TotQty,InhInv.Inv_flag2 from (InhInv) where (((InhInv.Inv_dt)>=#" & fdate1 & "# And (InhInv.Inv_dt)<=#" & fdate2 & "#) and ((InhInv.Inv_Flag2)='" & ss1 & "'))"
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ,convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where (((VehMast.Veh_paydt)>='" & fdate1 & "' And (VehMast.Veh_paydt)<='" & fdate2 & "') and ((VehMast.allow1)='" & ss1 & "'))", objConn)
        ' Dim cmdCustomers As SqlCommand = New SqlCommand("Select InhInv.Inv_No,InhInv.Inv_Com, InhInv.Inv_Dt,InhInv.Inv_pono, InhInv.Inv_TotVal, InhInv.Inv_TotQty,InhInv.Inv_flag2 from (InhInv) where (((InhInv.Inv_dt)>=#6/1/2006# And (InhInv.Inv_dt)<=#6/30/2006#) and ((InhInv.Inv_Flag2)='" & ss1 & "'))", objConn)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select InhInv.Inv_No,InhInv.Inv_Com, InhInv.Inv_Dt,InhInv.Inv_pono, InhInv.Inv_TotVal, InhInv.Inv_TotQty,InhInv.Inv_flag2 from (InhInv) where InhInv.Inv_Flag2='" & ss1 & "'", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        dtgCustomers.DataSource = cmdCustomers.ExecuteReader()
        dtgCustomers.DataBind()
        objConn.Close()
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()




    End Sub



    Public Sub BindTheGrid1()
        dd1 = Mid(TxtFdt.Text, 4, 2) + "/" + Mid(TxtFdt.Text, 1, 2) + "/" + Mid(TxtFdt.Text, 7, 4)
        dd2 = Mid(Txttdt.Text, 4, 2) + "/" + Mid(Txttdt.Text, 1, 2) + "/" + Mid(Txttdt.Text, 7, 4)
        date1 = (dd1)
        date2 = (dd2)

        fdate1 = CDate(Format(date1, "MM/dd/yyyy"))

        fdate2 = CDate(Format(date2, "MM/dd/yyyy"))

        ' SELECT InhInv.Inv_No, InhInv.Inv_Com, InhInv.Inv_Dt, InhInv.Inv_TotVal, InhInv.Inv_TotQty, InhInv.Inv_Flag1, InhInv.Inv_pono, InhInv.Inv_code, InhInv.Inv_Flag2, InhInv.Inv_vat
        ' FROM(InhInv)'
        'WHERE (((InhInv.Inv_Dt)>=#7/1/2006# And (InhInv.Inv_Dt)<=#7/15/2006#) AND ((InhInv.Inv_Flag2)="Approved"));'

        ss1 = "Approved"
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, format(Inv_pr,'#,###.00') as InvPr,format(Inv_Qty,'#,###') as InvQty, format(Inv_val,'#,###.00') as InvVal from InlTemp", CON)
        ss = "Select InhInv.Inv_No,InhInv.Inv_Com, convert(varchar(10),InhInv.Inv_Dt,103) as InvDt,InhInv.Inv_pono, InhInv.Inv_TotVal, InhInv.Inv_TotQty,InhInv.Inv_flag2 from (InhInv) where (((InhInv.Inv_dt)>=#" & fdate1 & "# And (InhInv.Inv_dt)<=#" & fdate2 & "#) and ((InhInv.Inv_Flag2)='" & ss1 & "'))"
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Veh_No,Veh_Com, Veh_Typ,convert(varchar(10),Veh_EfDt,103) as Veh_EfDt, convert(varchar(10),Veh_Exdt,103) as Veh_Exdt, Veh_tpay ,Veh_val,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where (((VehMast.Veh_paydt)>='" & fdate1 & "' And (VehMast.Veh_paydt)<='" & fdate2 & "') and ((VehMast.allow1)='" & ss1 & "'))", objConn)
        ' Dim cmdCustomers As SqlCommand = New SqlCommand("Select InhInv.Inv_No,InhInv.Inv_Com, InhInv.Inv_Dt,InhInv.Inv_pono, InhInv.Inv_TotVal, InhInv.Inv_TotQty,InhInv.Inv_flag2 from (InhInv) where (((InhInv.Inv_dt)>=#6/1/2006# And (InhInv.Inv_dt)<=#6/30/2006#) and ((InhInv.Inv_Flag2)='" & ss1 & "'))", objConn)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select InhInv.Inv_No,InhInv.Inv_Com, InhInv.Inv_Dt,InhInv.Inv_pono, InhInv.Inv_TotVal, InhInv.Inv_TotQty,InhInv.Inv_flag2 from (InhInv) where InhInv.Inv_Flag2='" & ss1 & "'", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        dtgCustomers.DataSource = cmdCustomers.ExecuteReader()
        dtgCustomers.DataBind()
        objConn.Close()
        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()
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
    Public Sub OnViewCommand(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
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
        Dim strInvNo As String = CType(e.Item.FindControl("lblInvNo"), Label).Text
        Dim strfg As String = CType(e.Item.FindControl("ddlCountry"), DropDownList).SelectedItem.Value
        'Dim strTotVal As Double = Val(CType(e.Item.FindControl("lblTotVal"), Label).Text)
        Dim strTotQty As Double = Val(CType(e.Item.FindControl("lblTotQty"), Label).Text)
        Dim strdt As String = CType(e.Item.FindControl("lblInvdt"), Label).Text
        Dim strPono As String = CType(e.Item.FindControl("lblInvpono"), Label).Text
        Dim strInvCom As String = CType(e.Item.FindControl("lblInvCom"), Label).Text


        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String

        strSql = "UPDATE InhInv SET Inv_Flag2='" & strfg & "' WHERE Inv_Flag2='Select' and Inv_No='" & strInvNo & "'"
        cmdCustomers = New SqlCommand(strSql, objConn)
        ' objConn.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        dtgCustomers.EditItemIndex = -1
        BindTheGrid1()
        dtgCustomers.Visible = True

        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '33333'", objConn)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count1 = DS.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each dr1 In DS.Tables("EmpMast").Rows
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
            emailMessage.Subject = "Your Approval is Ok"

            emailMessage.Body = "Inv No :" + strInvNo + " " + strInvCom + " " + " Inv Date :" + strdt + " Approval is Ok" + "      " + "http://192.168.12.181/Insu/CrsTaxInvoice.aspx"
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

                emailMessage.Body = "Inv No :" + strInvNo + " " + strInvCom + " " + " Inv Date :" + strdt + " Approval is not Ok"
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

    Sub MyDataGrid_DeleteCommand(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)

        Dim ss1 As String
        ss = CType(e.Item.FindControl("lblNo"), Label).Text

        Global.PVehno = CType(e.Item.FindControl("lblNo"), Label).Text

        Dim strReport As String = ""
        strReport = "PopView4.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=900,width=750,left=10,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
    End Sub


    Private Sub dtgCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCustomers.SelectedIndexChanged

    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged, Calendar1.SelectionChanged
        TxtFdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
        BindTheGrid()
    End Sub
    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        Txttdt.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False
        BindTheGrid()
    End Sub

    Private Sub ImgBtt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtt1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub Imgbtt2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbtt2.Click
        Calendar2.Visible = True
    End Sub
End Class
