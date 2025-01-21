Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class InvApproval
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, Ada1 As SqlDataAdapter
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
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1, invtt1 As String
    Public ss, body As String

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
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents Txtss As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtMail As System.Web.UI.WebControls.TextBox
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected strCountry As String
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel10 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel11 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents RadBt2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadBt1 As System.Web.UI.WebControls.RadioButton

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
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Inv_No,Inv_Com, Convert(varchar(10),Inv_Dt,103) as InvDt,Inv_pono, Inv_TotVal , Inv_TotQty,Inv_flag2 from InhInv where Inv_flag1='Approved' and Inv_flag2='Select' order by inv_no", objConn)

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

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Inv_No,Inv_Com, Convert(varchar(10),Inv_Dt,103) as InvDt,Inv_pono, Inv_TotVal , Inv_TotQty,Inv_flag2 from InhInv where Inv_flag1='Approved' and Inv_flag2='Select' order by inv_no", objConn)

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
        Dim StrInvCode As String
        Dim strtotval As String

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
            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()

            ADA = New SqlDataAdapter("SELECT * FROM InhInv WHERE Inv_No='" & strInvNo & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InhInv")

            Count1 = DS.Tables("InhInv").Rows.Count
            If Count1 <> 0 Then
                For Each dr1 In DS.Tables("InhInv").Rows
                    strInvNo = dr1("Inv_no")
                    strInvCom = dr1("Inv_Com")
                    strdt = dr1("Inv_dt")
                    strtotval = dr1("Inv_totval")
                    strTotQty = dr1("Inv_totqty")
                    StrInvCode = dr1("Inv_Code")
                Next
            End If

            strfg = "Approved"
            strSql = "UPDATE InhInv SET Inv_Flag2='" & strfg & "' WHERE Inv_Flag2='Select' and Inv_No='" & strInvNo & "'"
            cmdCustomers = New SqlCommand(strSql, CON)
            ' objConn.Open()
            cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()

            'ADA1 = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '33333'", CON)
            'DS1 = New DataSet
            'ADA1.Fill(DS1, "EmpMast")
            '
            'Count1 = DS1.Tables("EmpMast").Rows.Count
            'If Count1 <> 0 Then
            'For Each dr2 In DS1.Tables("EmpMast").Rows
            'str_no = dr2("Emp_no")
            'str_name = dr2("Emp_name")
            'str_mail = dr2("Emp_email")
            'Next
            'End If

            body += "<table width='1000' border='0'>"
            body += "<tr>"
            body += "<td width='218' height='40'><form id='form3' name='form3' method='post' action=''>"
            body += "<label></label>"
            body += "<label></label>"
            body += "<label></label>"
            body += "<label>"
            body += "<input type='image' name='imageField3' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/imgs/logo.cnn.com.gif' />"
            body += "</label>"
            body += "</form>    </td>"
            body += "<td width='750'><form id='form2' name='form2' method='post' action=''>"
            body += "<label></label>"
            body += "<label></label>"
            body += "<label></label>"
            body += "<input type='image' name='imageField' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/BANNER.jpg' />"
            body += "</form>    </td>"
            body += "<td width='154'>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='174'><form id='form4' name='form4' method='post' action=''>"
            body += "<label>"
            body += "<input type='image' name='imageField2' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/Audit.gif' />"
            body += "</label>"
            body += "</form>    </td>"
            body += "<td><form id='form1' name='form1' method='post' action=''>"
            body += "<table width='525' height='126' border='0'>"
            body += "<tr>"
            body += "<td height='33'><label>Invoice No</label></td>"
            body += "<td>" & strInvNo & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td width='155' height='30'><label>Company</label></td>"
            body += "<td width='169'>" & strInvCom & "</td>"
            body += "<td width='187'>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='25'><label>Total Value</label></td>"
            body += "<td>" & strtotval & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='28'><label>Total Qty </label></td>"
            body += "<td>" & strTotQty & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='28'><label>Invoice Date </label></td>"
            body += "<td>" & strdt & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='28'><label>Created By </label></td>"
            body += "<td>" & StrInvCode & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "</table>"
            body += "<label></label>"
            body += "<label></label>"
            body += "</form>    </td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += " <tr><td align='left' colSpan='2'><table width='200' border='0'>"
            body += "<tr>"
            body += "<td><form method='post' action=http://sgcsser/Insu/NewApp3.aspx?TYPE=" & strInvNo & " name='frm1'><input name='sbb1' type='image' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/Print.jpg' width='100' height='30'> </form></td>"
            body += "</tr>"
            body += "</table>"
            body += "</td>"
            body += "<td align='left' colSpan='2'>&nbsp;</td>"
            body += "<td width='163' colSpan='3' align='left'>&nbsp;</td>"
            body += "<td></td>"
            body += "</tr>"
            body += "</table>"

            'TxtNam.Text = dr1("Emp_Name")
            'TxtToLv.Text = dr1("Emp_ToLv")
            'TxtTaLv.Text = dr1("Emp_TaLv")
            'TxtCntNo.Text = dr1("Emp_CntNo")
            ' cmdCustomers.Connection = objConn
            'Dim SS As String
            ' SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
            '''cmdCustomers = New SqlCommand(SS, objConn)
            '''objConn.Open()
            '''cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)








            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "chamindas@dsisamson.com"
            ''emailMessage.To = "chamindas@dsisamson.com"

            If StrInvCode = "66666" Then
                emailMessage.To = "trading@dsisamson.com"
            Else
                emailMessage.To = "suranjie@dsisamson.com"
            End If


            emailMessage.Subject = "Inv No :" + strInvNo + " " + strInvCom + " " + " Inv Date :" + strdt + " Your Approval is OK" + " "

            emailMessage.Body = body

            emailMessage.BodyFormat = MailFormat.Html

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


        Dim cmdCustomers As SqlCommand
        Dim strid As String = CType(e.Item.FindControl("lblInvNo"), Label).Text
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()


        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & strid & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")
        Global.PInvno = strid

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")

            InvPono1 = Dtr1("Inv_pono")
            Invvat1 = Dtr1("Inv_vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            invtt1 = Dtr1("Inv_tt")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & invtt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next

            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        'If Invvat1 = "No" Then

        ' If Invflag31 = "Yes" Then
        'Dim strReport As String = ""
        ' strReport = "PopView5.aspx"
        ' Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=800,width=750,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        ' Page.RegisterStartupScript("OpenWindow", strJS)

        ' Else
        '  Dim strReport As String = ""
        '  strReport = "PopView2.aspx"
        '  Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=800,width=750,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        ' Page.RegisterStartupScript("OpenWindow", strJS)
        ' End If




        'Else

        Dim strReport As String = ""
        strReport = "NewApp8.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=800,width=750,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
        ' End If


    End Sub




    Private Sub RadBt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBt1.CheckedChanged
        'RadBt2.Checked = False
        Dim strReport As String = ""
        strReport = "ViewReport1.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)

    End Sub

    Private Sub RadBt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBt2.CheckedChanged
        'RadBt1.Checked = False
        Dim strReport As String = ""
        strReport = "ViewReport2.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)


    End Sub


    Private Sub dtgCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCustomers.SelectedIndexChanged

    End Sub
End Class
