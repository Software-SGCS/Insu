Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class InvCheckM
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
    Dim invvat1, invvat, Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invdis1, Invflag31, invper1 As String
    Public ss As String

    Protected strCountry As String
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Dim DSS As CryTaxInv = New CryTaxInv

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
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='InvCheckM.aspx' and Form_level='" & Global.PwLevel & "'", CON)

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
        User1 = "22222"
        Pwd1 = "22222"
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
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Inv_No,Inv_Com, Convert(varchar(10),Inv_Dt,103) as InvDt,Inv_pono, Inv_TotVal, Inv_TotQty,Inv_flag1 from InhInv where Inv_flag1='Select'", objConn)

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
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Inv_No,Inv_Com, Convert(varchar(10),Inv_Dt,103) as InvDt,Inv_pono, Inv_TotVal, Inv_TotQty,Inv_flag1 from InhInv where Inv_flag1='Select'", objConn)

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
        Dim strfg As String

        Dim cmdCustomers As SqlCommand
        Dim strInvNo As String = CType(e.Item.FindControl("lblInvNo"), Label).Text
        ' strfg = CType(e.Item.FindControl("ddlCountry1"), DropDownList).SelectedItem.Text
        strfg = CType(e.Item.FindControl("ddlCountry"), DropDownList).SelectedItem.Value
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

        strSql = "UPDATE InhInv SET Inv_Flag1='" & strfg & "',Inv_Flag2= 'Select'" & " WHERE Inv_Flag1='Select' and Inv_No='" & strInvNo & "'"
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
            emailMessage.To = "chamindas@dsisamson.com"
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "For Your Approval"

            emailMessage.Body = "Inv No :" + strInvNo + " " + strInvCom + " " + " Inv Date :" + strdt + " For Approval" + "      " + "http://sgcsser/Insu/InvApproval.aspx"
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
                emailMessage.From = TxtMail.Text
                emailMessage.To = str_mail
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Your Invoce is not Ok"

                emailMessage.Body = "Inv No :" + strInvNo + " " + strInvCom + " " + " Inv Date :" + strdt + " Invoce is not Ok"
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


        ' CON.Open()


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
            Invvat = Dtr1("Inv_vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")

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

                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()
        Next


        'If Invvat1 = "No" Then

        ' If Invflag31 = "Yes" Then
        ' Dim strReport As String = ""
        ' strReport = "PopView5.aspx"
        ' Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=700,left=100,top=300,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)



        ' Else
        '   Dim strReport As String = ""
        '  strReport = "PopView2.aspx"
        '  Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=700,left=100,top=300,scrollbars=yes,status=no');<" & "/script>"
        '  Page.RegisterStartupScript("OpenWindow", strJS)
        ' End If




        'Else

        Dim strReport As String = ""
        strReport = "NewAdd9.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
        ' End If


    End Sub




    Private Sub dtgCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCustomers.SelectedIndexChanged

    End Sub
End Class
