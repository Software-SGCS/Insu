Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class Outword
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim sinvno As String
    Dim LOD, body As String
    Dim dt1 As Date
    Dim drt2, drt3 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim SS As String
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim q, r, s As String
    Dim p, t As Double
    Dim InvFlag2 As String
    Dim count1 As Integer
    Dim depno As String
    Dim depname As String
    Dim S1(10) As String
    Dim epfno As String

    Protected WithEvents LstTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents TxtInvNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents LstCode As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents LstFlag2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtPer As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents ImgBt As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtLInvNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents LstTT As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Lstvat1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDatagrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Deplist As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents txtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BttEmpNo As System.Web.UI.WebControls.Button
    Protected WithEvents TxtEpfNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDepNo As System.Web.UI.WebControls.TextBox
    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtInvDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Lstcom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstInvNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtPoNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents LstCntry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstBrnd As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstItmNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label

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


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='Outword.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            ' Response.Redirect("InsuDept.aspx")
        End If



        CMD = New SqlCommand("SELECT Emp_No,Emp_Nam,Emp_depno from EmpAdmin order by Emp_depNo ,Id", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                Lstcom.Items.Add(TT)
            End While
        End If








        DR.Close()
        CMD = New SqlCommand("SELECT Inv_No From InhInv where id =(select max(id) from inhInv)", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                LstInvNo.Items.Add(TT)
                TxtLInvNo.Text = DR.GetValue(0)
            End While
        End If
        DR.Close()






        CMD = New SqlCommand("SELECT sys_rno,sys_des1,sys_des2 From SysMast where sys_rtp='01' order by Sys_rno", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " " + DR.GetValue(1)
                LstTyp.Items.Add(TT)
            End While
        End If
        DR.Close()
        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='02' order by Sys_rno", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " " + DR.GetValue(1)
                LstCntry.Items.Add(TT)
            End While
        End If

        DR.Close()
        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and sys_des2='03'", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " " + DR.GetValue(1)
                LstBrnd.Items.Add(TT)
            End While
        End If
        DR.Close()

        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='04' order by Sys_rno", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                Deplist.Items.Add(TT)
            End While
        End If
        DR.Close()




        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where substring(itm_no,1,2)='03' and substring(itm_no,3,2)='00' and substring(itm_no,5,2)='C1'", CON)

        DR = CMD.ExecuteReader

        If Not IsPostBack Then

            dt1 = Date.Today


            TxtInvDt.Text = Format(dt1, ("dd/MM/yyyy"))

            Calendar1.Visible = False



            While DR.Read
                Dim str1, str2 As String
                str1 = Space(30)
                str2 = Space(20)
                str1 = DR.GetValue(1) + str1
                str1 = Left(str1, 30)
                str2 = str2 + Str(DR.GetValue(3))
                str2 = Right(str2, 20)
                TT = DR.GetValue(0) + " " + str1 + " " + str2

                LstItmNo.Items.Add(TT)
            End While
        End If

        DR.Close()
        CMD = New SqlCommand("SELECT ad_no,ad_nam from admin", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " " + DR.GetValue(1)
                LstCode.Items.Add(TT)
            End While
            LstCode.SelectedValue = "44444 Suranji"
        End If
        DR.Close()
        CMD = New SqlCommand("SELECT Vat from vat", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                LstVat.Items.Add(TT)
            End While
            LstVat.SelectedValue = "Yes"
        End If
        DR.Close()
        CMD = New SqlCommand("SELECT Vat from vat", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                LstFlag2.Items.Add(TT)
            End While

        End If

        DR.Close()
        CMD = New SqlCommand("SELECT Vat from vat", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                LstTT.Items.Add(TT)
            End While
            LstTT.SelectedValue = "Yes"
        End If

        DR.Close()
        CMD = New SqlCommand("SELECT Vat from vat", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                Lstvat1.Items.Add(TT)
            End While
            Lstvat1.SelectedValue = "No"
        End If

        DR.Close()



        If Not Page.IsPostBack Then
            BindTheGrid()
            LstFlag2.SelectedValue = "No"
            Label11.Visible = False
            LstFlag2.Visible = False
            TxtPer.Visible = False
            TxtPer.Text = 0
            Label12.Visible = False
        End If

        If Not IsPostBack Then
            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()


            ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "EmpAdmin")

            SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
            CMD = New SqlCommand("SELECT Emp_DepNo FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "'", CON)


            DR = CMD.ExecuteReader


            'If Not IsPostBack Then
            While DR.Read
                depno = DR.GetValue(0)
                'LstTyp.Items.Add(TT)
            End While
            'End If
            DR.Close()


            'count1 = DS.Tables("EmpAdmin").Rows.Count
            'If count1 <> 0 Then
            '    For Each DR1 In DS.Tables("EmpAdmin").Rows
            '        depno = DR1("Emp_dep")

            '    Next
            'End If





            CMD = New SqlCommand("SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'", CON)
            SS = "SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'"

            DR = CMD.ExecuteReader

            depname = "Other"
            'If Not IsPostBack Then
            While DR.Read
                depname = DR.GetValue(0)
                'LstTyp.Items.Add(TT)
            End While
            'End If
            DR.Close()


            Deplist.SelectedItem.Text = depno + " - " + depname


            BindTheGrid2()

        End If

    End Sub
    Public Sub BindTheGrid()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))

        ' CON.Open()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        epfno = Trim(S1(0))


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select a.Id as id,a.Inv_Itmno as Inv_Itmno,b.Itm_Des as Inv_Des, a.Inv_Qty as InvQty,a.Inv_no as EntryNo,a.Inv_Dt as EntDt  from InlInv a,ItmMast b where (a.Inv_Itmno=b.Itm_no) and a.Inv_com='" & Trim(TxtEpfNo.Text) & "' and a.inv_Itmno='" & Mid(LstItmNo.SelectedValue, 1, 8) & "'", CON)
        SS = "Select a.Id as id,a.Inv_Itmno as Inv_Itmno,b.Itm_Des as Inv_Des, a.Inv_Qty as InvQty,a.Inv_no as EntryNo,a.Inv_Dt as EntDt  from InlInv a,ItmMast b where (a.Inv_Itmno=b.Itm_no) and a.Inv_com='" & Trim(TxtEpfNo.Text) & "' and a.inv_Itmno='" & Mid(LstItmNo.SelectedValue, 1, 8) & "'"
        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        MyDatagrid1.DataSource = cmdCustomers.ExecuteReader()
        MyDatagrid1.DataBind()
        CON.Close()

    End Sub

    Public Sub BindTheGrid1()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        'objConn = New SqlConnection
        'objConn.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        'objConn.Open()
        ' CON.Open()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, Inv_pr as InvPr,Inv_Qty as InvQty, Inv_val as InvVal from InlTemp where Inv_no='" & Trim(TxtInvNo.Text) & "'", CON)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()
    End Sub

    Public Sub BindTheGrid2()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))

        'CON.Open()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        epfno = Trim(S1(0))

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select a.Id as id,a.Inv_Itmno as Inv_Itmno,b.Itm_Des as Inv_Des, a.Inv_Qty as InvQty,a.Inv_no as EntryNo,a.Inv_Dt as EntDt  from InlInv a,ItmMast b where (a.Inv_Itmno=b.Itm_no) and a.Inv_com='" & Trim(TxtEpfNo.Text) & "' order by Inv_no", CON)
        SS = "Select a.Id as id,a.Inv_Itmno as Inv_Itmno,b.Itm_Des as Inv_Des, a.Inv_Qty as InvQty,a.Inv_no as EntryNo,a.Inv_Dt as EntDt  from InlInv a,ItmMast b where (a.Inv_Itmno=b.Itm_no) and a.Inv_com='" & Trim(TxtEpfNo.Text) & "' and a.inv_Itmno='" & Mid(LstItmNo.SelectedValue, 1, 8) & "'"
        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        Datagrid2.DataSource = cmdCustomers.ExecuteReader()
        Datagrid2.DataBind()
        CON.Close()

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

    Public Sub SetDropDownIndex(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ed As System.Web.UI.WebControls.DropDownList
        ed = sender
        ed.SelectedIndex = ed.Items.IndexOf(ed.Items.FindByText(strCountry))
    End Sub
    Private Sub LstTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstTyp.SelectedIndexChanged
        DR.Close()
        Dim TT1, tt2 As String
        TT1 = Mid(LstTyp.SelectedValue, 1, 2)
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and substring(sys_des2,1,2)='" & TT1 & "'", CON)


        DR = CMD.ExecuteReader


        LstBrnd.Items.Clear()
        While DR.Read
            TT = DR.GetValue(0) + " " + DR.GetValue(1)
            LstBrnd.Items.Add(TT)
        End While


        DR.Close()

        CRI1 = Mid(LstTyp.SelectedValue, 1, 2)
        CRI2 = Mid(LstCntry.SelectedValue, 1, 2)
        CRI3 = Mid(LstBrnd.SelectedValue, 1, 2)


        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk,Itm_dis From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'", CON)


        DR = CMD.ExecuteReader
        LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2
            LstItmNo.Items.Add(TT)
        End While
        ' End If

        DR.Close()
        BindTheGrid()
        BindTheGrid2()
    End Sub

    Private Sub LstBrnd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBrnd.SelectedIndexChanged

        CRI1 = Mid(LstTyp.SelectedValue, 1, 2)
        CRI2 = Mid(LstCntry.SelectedValue, 1, 2)
        CRI3 = Mid(LstBrnd.SelectedValue, 1, 2)

        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        DR = CMD.ExecuteReader
        LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2
            LstItmNo.Items.Add(TT)
        End While
        ' End If

        DR.Close()

        BindTheGrid()
        BindTheGrid2()

    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        Dim Sitmno As String
        Dim Sdes As String
        Dim Spri As Double
        Dim SQty As Double
        Dim SVal As Double

        Sitmno = Mid(LstItmNo.SelectedValue, 1, 8)
        Sdes = Mid(LstItmNo.SelectedValue, 10, 50)
        Spri = Val(Mid(LstItmNo.SelectedValue, 62, 20))
        SQty = Val(TxtQty.Text)
        SVal = SQty * Spri


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        If BtnEdit.Enabled = True Then
            CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        Else
            CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & TxtInvNo.Text & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        End If

        CMD.ExecuteNonQuery()
        BindTheGrid1()

    End Sub

    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = e.Item.ItemIndex
        BindTheGrid1()
    End Sub
    Sub MyDataGrid_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid1()
    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from Inltemp Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        BindTheGrid1()
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

    Private Sub LstInvNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstInvNo.SelectedIndexChanged

        Dim Dtr, Dtr1 As DataRow

        CMD = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = CMD.ExecuteReader
        DR1.Close()
        Dim stridt, strpono, strcom, strcomnam, strvat As String
        Dim Intstk As Integer
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & LstInvNo.SelectedValue & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV")

        For Each Dtr1 In DS.Tables("INHINV").Rows
            stridt = Format(Dtr1("Inv_dt"), "dd/MM/yyyy")
            strpono = Dtr1("Inv_pono")
            strcom = Dtr1("Inv_Com")
            strvat = Dtr1("Inv_vat")
        Next
        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & strcom & "' and Emp_com='SGC'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")
        For Each Dtr1 In DS.Tables("COMPANY").Rows
            strcomnam = Dtr1("Emp_nam")
        Next


        TxtPoNo.Text = strpono
        TxtInvDt.Text = stridt
        Lstcom.SelectedValue = strcom + " - " + strcomnam
        LstVat.SelectedValue = strvat


        ADA = New SqlDataAdapter("SELECT * FROM INLINV WHERE INV_NO = '" & LstInvNo.SelectedValue & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INLINV1")
        Dim Count As Integer
        Dim strinvno, strinvitmno, strinvdes As String
        Dim strinvqty, strinvpri, strinvval As Double
        Dim tempstk As Double

        Count = DS.Tables("INLINV1").Rows.Count
        If Count <> 0 Then
            For Each Dtr In DS.Tables("INLINV1").Rows

                strinvno = Dtr("Inv_no")
                strinvitmno = Dtr("Inv_itmno")
                strinvpri = Dtr("Inv_pri")
                strinvval = Dtr("Inv_val")
                strinvqty = Dtr("Inv_qty")

                ADA = New SqlDataAdapter("SELECT * FROM ITMMAST WHERE ITM_NO = '" & strinvitmno & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "ITMMAST")
                Count = DS.Tables("ITMMAST").Rows.Count
                For Each Dtr1 In DS.Tables("ITMMAST").Rows
                    strinvdes = Dtr1("Itm_des")
                    Intstk = Dtr1("Itm_Stk")
                Next
                tempstk = (Val(Intstk) - Val(strinvqty))
                CMD.CommandText = ("INSERT INTO Inltemp (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pr,Inv_val,Inv_des) VALUES ('" & LstInvNo.SelectedValue & "','" & strinvitmno & "','" & strinvqty & "','" & strinvpri & "','" & strinvval & "','" & strinvdes & "')")
                CMD.ExecuteNonQuery()

                'CMD.CommandText = ("UPDATE ITMMAST SET ITM_STK=" & tempstk & " WHERE Itm_no='" & strinvitmno & "'")
                'CMD.ExecuteNonQuery()

            Next
            BindTheGrid1()
            BindTheGrid()
            BindTheGrid2()
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ''BindTheGrid()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        CMD1 = New SqlCommand("SELECT Inv_No From InhInv where id =(select max(id) from inhInv)", CON)


        DR = CMD1.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            TT = DR.GetValue(0)
            LstInvNo.Items.Add(TT)
            TxtLInvNo.Text = DR.GetValue(0)
        End While
        'End If
        DR.Close()






        LstInvNo.Visible = False
        LstInvNo.Enabled = False
        TxtInvNo.Visible = True
        TxtInvNo.Enabled = True
        TxtInvNo.Text = " "
        ' TxtInvDt.Text = " "
        TxtPoNo.Text = " "

        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)
        DS = New DataSet
        ADA.Fill(DS, "InvoiceNo")
        Dim ct As Integer
        ct = DS.Tables("InvoiceNo").Rows.Count
        If ct <> 0 Then


            For Each drt2 In DS.Tables("InvoiceNo").Rows

                Dim q, r, s As String
                Dim p As Double
                's = drt2("Inv_no")

                s = TxtLInvNo.Text
                'p = Val(drt2("Inv_no")) + 1
                p = Val(TxtLInvNo.Text) + 1
                q = Format(p, "00000")


                TxtInvNo.Text = "" + q
            Next

        End If




        If BtnEdit.Enabled = True Then
        Else

            sinvno = Mid(TxtInvNo.Text, 3, 9)

            Dim Cmd11 As New SqlCommand("UPDATE InvoiceNo SET Inv_No='" & sinvno & "'", CON)
            Cmd11.ExecuteNonQuery()
        End If



        Dim DeleteCmd As String = "DELETE from Inltemp "
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        'Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        BindTheGrid1()

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        LstInvNo.Visible = True
        LstInvNo.Enabled = True
        TxtInvNo.Visible = False
        TxtInvNo.Enabled = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = False
        BtnEdit.Enabled = False

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim SS As String
        If Mid(LstVat.SelectedValue, 1, 3) = "Yes" Then
            LstFlag2.SelectedValue = "No"
            TxtPer.Text = 0

        End If
        Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        epfno = Trim(S1(0))
        If BtnEdit.Enabled = True Then
            Dim DeleteCmd1 As String = "DELETE from InlInv where Inv_no='" & LstInvNo.SelectedValue & "'"
            Dim Cmd As New SqlCommand(DeleteCmd1, CON)
            Cmd.ExecuteNonQuery()

            
            DeleteCmd1 = "DELETE from InlInv where Inv_no='" & LstInvNo.SelectedValue & "'"

            SS = "UPDATE InhInv SET Inv_com='" & epfno & "',Inv_dt='" & DateValue(Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4)) & "',Inv_pono= '" & TxtPoNo.Text & "',Inv_Code= '" & Mid(LstCode.SelectedValue, 1, 5) & "',Inv_flag3= '" & Mid(LstFlag2.SelectedValue, 1, 5) & "',Inv_pec= " & TxtPer.Text & ",Inv_vat= '" & Mid(LstVat.SelectedValue, 1, 3) & "' WHERE Inv_no='" & LstInvNo.SelectedValue & "'"
            Cmd.Connection = CON
            Cmd.CommandText = ("UPDATE InhInv SET Inv_com='" & Trim(TxtEpfNo.Text) & "',Inv_dt='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "',Inv_pono= '" & TxtPoNo.Text & "',Inv_Code= '" & Mid(LstCode.SelectedValue, 1, 5) & "',Inv_flag3= '" & Mid(LstFlag2.SelectedValue, 1, 5) & "',Inv_per= " & TxtPer.Text & "',Inv_TT= " & Mid(LstTT.SelectedValue, 1, 3) & "',Inv_Flg= " & Mid(Lstvat1.SelectedValue, 1, 3) & ",Inv_vat= '" & Mid(LstVat.SelectedValue, 1, 3) & "' WHERE Inv_no='" & LstInvNo.SelectedValue & "'")
            Cmd.ExecuteNonQuery()

            sinvno = LstInvNo.SelectedValue
        Else

            Cmd.Connection = CON
            Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Flag2,Inv_Code,Inv_flag3,Inv_per,Inv_tt,Inv_flg,Inv_Vat) VALUES ('" & TxtInvNo.Text & "','" & Trim(TxtEpfNo.Text) & "','" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & TxtPoNo.Text & "','Select'," & "'A','" & Mid(Trim(Global.PUserId), 1, 5) & "','" & Mid(Trim(LstFlag2.SelectedValue), 1, 5) & "','" & TxtPer.Text & "','" & Mid(Trim(LstTT.SelectedValue), 1, 3) & "','" & Mid(Trim(Lstvat1.SelectedValue), 1, 3) & "','" & Mid(Trim(LstVat.SelectedValue), 1, 3) & "')")
            'Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code) VALUES ('" & TxtInvNo.Text & "','" & Mid(Lstcom.SelectedValue, 1, 3) & "','" & DateValue(Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4)) & "','" & TxtPoNo.Text & "','Select','" & "','" & Mid(Trim(LstCode.SelectedValue), 1, 5) & "' )")
            Cmd.ExecuteNonQuery()
            sinvno = TxtInvNo.Text

        End If





        Dim gridrow As DataGridItem
        Dim i As Integer
        Dim t1, t2, t3, t4, t5, t6, t7, t8, t9 As String

        'Dim SS As String
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



            ADA = New SqlDataAdapter("SELECT Itm_dis FROM ITMMAST WHERE ITM_NO= '" & t1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "ITMMAST")

            Count = DS.Tables("ITMMAST").Rows.Count
            If Count <> 0 Then


                For Each drt2 In DS.Tables("ITMMAST").Rows
                    t9 = drt2("ITM_DIS")
                Next

            End If


            If BtnEdit.Enabled = True Then
                Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val,Inv_dis,Inv_Com,Inv_Dt) VALUES ('" & LstInvNo.SelectedValue & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "','" & t9 & "','" & Trim(TxtEpfNo.Text) & "','" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "')")
            Else
                Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val,Inv_Dis,Inv_Com,Inv_Dt) VALUES ('" & TxtInvNo.Text & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "','" & t9 & "','" & Trim(TxtEpfNo.Text) & "','" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "')")
            End If
            Cmd.ExecuteNonQuery()
            Dim T4INT As Double
            T4INT = Val(t4)

            Cmd.CommandText = ("UPDATE ITMMAST SET ITM_STK=ITM_STK-" & T4INT & " WHERE Itm_no='" & t1 & "'")
            Cmd.ExecuteNonQuery()
            tot1 = tot1 + t4
            tot2 = tot2 + t5
        Next

        InvFlag2 = "A"

        Cmd.Connection = CON
        Cmd.CommandText = ("UPDATE InhInv SET Inv_TotQty=" & tot1 & ",Inv_TotVal=" & tot2 & ",Inv_Flag2='" & InvFlag2 & "' WHERE Inv_no='" & sinvno & "'")
        Cmd.ExecuteNonQuery()

        If BtnEdit.Enabled = True Then
        Else

            sinvno = Mid(TxtInvNo.Text, 3, 9)

            Dim Cmd11 As New SqlCommand("UPDATE InvoiceNo SET Inv_No='" & sinvno & "'", CON)
            Cmd11.ExecuteNonQuery()
        End If


        Dim Cmd12 As New SqlCommand("UPDATE EmpAdmin SET Emp_DepNo='" & Trim(TxtDepNo.Text) & "' where Emp_no='" & Trim(TxtEpfNo.Text) & "'", CON)
        Cmd12.ExecuteNonQuery()


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
            body += "<td>" & sinvno & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td width='155' height='30'><label>Company</label></td>"
            body += "<td width='169'>" & Mid(Lstcom.SelectedValue, 1, 3) & "</td>"
            body += "<td width='187'>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='25'><label>Total Value</label></td>"
            body += "<td>" & Str(tot2) & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='28'><label>Total Qty </label></td>"
            body += "<td>" & Str(tot1) & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"
            body += "<tr>"
            body += "<td height='28'><label>Invoice Date </label></td>"
            body += "<td>" & TxtInvDt.Text & "</td>"
            body += "<td>&nbsp;</td>"
            body += "</tr>"

            body += "<tr>"
            body += "<td height='28'><label>Created By </label></td>"
            body += "<td>" & LstCode.SelectedValue & "</td>"
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
            body += "<td><form method='post' action=http://sgcsser/Insu/NewApp1.aspx?TYPE=" & Trim(TxtInvNo.Text) & " name='frm1'><input name='sbb1' type='image' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/approve.jpg' width='100' height='30'> </form></td>"


            body += "</tr>"
            body += "</table>"

            body += "</td>"


            body += "<td align='left' colSpan='2'>&nbsp;</td>"


            body += "<td width='163' colSpan='3' align='left'>&nbsp;</td>"
            body += "<td></td>"
            body += "</tr>"

            body += "</table>"





            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            If Mid(LstCode.SelectedValue, 1, 5) = "66666" Then
                emailMessage.From = "trading@dsisamson.com"

            Else
                emailMessage.From = "system@dsisamson.com"
            End If


            emailMessage.To = "palithan@samsoncorporates.com"
            'emailMessage.To = "palithan@samsoncorporates.com"

            emailMessage.Subject = "Inv No :" + sinvno + " " + Mid(Lstcom.SelectedValue, 1, 3) + " Total Qty " + Str(tot1) + " Total Value " + Str(tot2) + " For Check "

            'emailMessage.Body = "Inv No :" + Sinvno + " " + Mid(Lstcom.SelectedValue, 1, 3) + " Total Qty " + Str(tot1) + " Total Value " + Str(tot2) + " http://sgcsser/Insu/InvCheck.aspx"
            emailMessage.Body = body

            emailMessage.BodyFormat = MailFormat.Html

            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try
        End If
        Dim DeleteCmd As String
        If BtnEdit.Enabled = True Then
            DeleteCmd = "DELETE from Inltemp where Inv_no='" & LstInvNo.SelectedValue & "'"
        Else
            DeleteCmd = "DELETE from Inltemp where Inv_no='" & TxtInvNo.Text & "'"
        End If

        Dim Cmd2 As New SqlCommand(DeleteCmd, CON)
        Cmd2.ExecuteNonQuery()

        BtnSave.Enabled = False
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True

    End Sub


    Private Sub LstItmNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstItmNo.SelectedIndexChanged
        Dim V1, V2, V3 As String
        BindTheGrid()
        BindTheGrid2()
        If BtnAdd.Enabled = True Then
            V1 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "1.jpg"
        Else
            V1 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "1.jpg"
        End If
        If BtnAdd.Enabled = True Then
            V2 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "2.jpg"
        Else
            V2 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "2.jpg"
        End If

        V3 = "http://sgcsser\Insu\Itm\"

        If IsDBNull(V1) = False Then
            '  Img1.Visible = True
            ' Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            ' Img2.Visible = True
            ' Img2.ImageUrl = V2
        End If
    End Sub

    Private Sub LstCntry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCntry.SelectedIndexChanged
        '  DR.Close()
        Dim TT1, tt2 As String
        TT1 = Mid(LstTyp.SelectedValue, 1, 2)

        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and substring(sys_des2,1,2)='" & TT1 & "'", CON)


        DR = CMD.ExecuteReader


        LstBrnd.Items.Clear()
        While DR.Read
            TT = DR.GetValue(0) + " " + DR.GetValue(1)
            LstBrnd.Items.Add(TT)
        End While

        DR.Close()


        CRI1 = Mid(LstTyp.SelectedValue, 1, 2)
        CRI2 = Mid(LstCntry.SelectedValue, 1, 2)
        CRI3 = Mid(LstBrnd.SelectedValue, 1, 2)

        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk,Itm_dis From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        DR = CMD.ExecuteReader
        LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2
            LstItmNo.Items.Add(TT)
        End While
        ' End If
        'BtnAdd.Enabled = True
        'BtnEdit.Enabled = True
        DR.Close()
        BindTheGrid()
        BindTheGrid2()
    End Sub
    Private Sub LstVat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVat.SelectedIndexChanged
        If LstVat.SelectedValue = "No" Then
            LstFlag2.Visible = True
            Label11.Visible = True
            ' Label12.Visible = True

        Else
            LstFlag2.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            TxtPer.Text = 0
            TxtPer.Visible = False

        End If


    End Sub

    Private Sub LstFlag2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFlag2.SelectedIndexChanged
        If LstFlag2.SelectedValue = "No" Then
            TxtPer.Visible = False
            TxtPer.Text = 0
            Label12.Visible = False
            Label11.Visible = True
        Else
            Label11.Visible = True
            Label12.Visible = True
            TxtPer.Visible = True
            TxtPer.Text = 6
        End If

    End Sub

    Private Overloads Sub ImgBt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBt.Click
        Calendar1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtInvDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
        BindTheGrid()
    End Sub

    Private Sub MyDatagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstcom.SelectedIndexChanged
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")
        Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        epfno = Trim(S1(0))
        TxtEpfNo.Text = epfno
        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"


        CMD = New SqlCommand("SELECT Emp_DepNo FROM EmpAdmin WHERE Emp_No = '" & Trim(TxtEpfNo.Text) & "'", CON)


        DR = CMD.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            TxtDepNo.Text = Trim(DR.GetValue(0))
            depno = DR.GetValue(0)
            'LstTyp.Items.Add(TT)
        End While
        'End If
        DR.Close()


        'count1 = DS.Tables("EmpAdmin").Rows.Count
        'If count1 <> 0 Then
        '    For Each DR1 In DS.Tables("EmpAdmin").Rows
        '        depno = DR1("Emp_dep")

        '    Next
        'End If





        CMD = New SqlCommand("SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'", CON)
        SS = "SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'"

        DR = CMD.ExecuteReader

        depname = "Other"
        'If Not IsPostBack Then
        While DR.Read
            depname = DR.GetValue(0)
            'LstTyp.Items.Add(TT)
        End While
        'End If
        DR.Close()


        Deplist.SelectedItem.Text = depno + " - " + depname



        BindTheGrid()
        BindTheGrid2()

    End Sub

    Private Sub TxtInvDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInvDt.TextChanged

    End Sub

    Private Sub LstCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCode.SelectedIndexChanged

    End Sub

    Private Sub TxtInvNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInvNo.TextChanged


    End Sub

    Private Sub BttEmpNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttEmpNo.Click
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim DeleteCmd As String = "DELETE from Inltemp "
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        'Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        BindTheGrid1()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        TxtEpfNo.Text = Trim(txtEmpNo.Text)
        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "' AND Emp_No='SGC'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")

        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
        CMD = New SqlCommand("SELECT Emp_DepNo,Emp_Nam,Emp_No FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)


        DR = CMD.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            TxtDepNo.Text = Trim(DR.GetValue(0))
            depno = DR.GetValue(0)
            Lstcom.SelectedItem.Text = (DR.GetValue(2) + " - " + DR.GetValue(1))
        End While
        'End If
        DR.Close()

        'Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        'epfno = Trim(S1(0))

        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")

        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
        CMD = New SqlCommand("SELECT Emp_DepNo FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)


        DR = CMD.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            depno = Trim(DR.GetValue(0))
            'LstTyp.Items.Add(TT)
        End While
        'End If
        DR.Close()


        'count1 = DS.Tables("EmpAdmin").Rows.Count
        'If count1 <> 0 Then
        '    For Each DR1 In DS.Tables("EmpAdmin").Rows
        '        depno = DR1("Emp_dep")

        '    Next
        'End If





        CMD = New SqlCommand("SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'", CON)
        SS = "SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'"

        DR = CMD.ExecuteReader

        depname = "00 - Other"
        'If Not IsPostBack Then
        While DR.Read
            depname = DR.GetValue(0)
            'LstTyp.Items.Add(TT)
        End While
        'End If
        DR.Close()


        Deplist.SelectedItem.Text = Trim(depno) + " - " + depname



        BindTheGrid()
        BindTheGrid2()
    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

    End Sub

    Private Sub Deplist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deplist.SelectedIndexChanged
        TxtDepNo.Text = Trim(Deplist.SelectedValue)
    End Sub
End Class
