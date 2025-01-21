Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data
Imports System.Web.Mail

Public Class LeaveApproval
    Inherits System.Web.UI.Page
    Dim CON As OleDbConnection
    Dim objConn As OleDbConnection
    Dim ADA As OleDbDataAdapter
    Dim CMD As OleDbCommand
    Dim DR, DR1, dr2, dr3 As OleDbDataReader
    Dim DS, DS1, ds2 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As OleDbCommand
    Dim RE As OleDbDataReader
    Dim RE1 As OleDbDataReader
    Public ss As String

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
        Txtss.Visible = False
        TxtMail.Visible = False

        If Not IsPostBack Then
            dtgCustomers.Visible = False
            Txtss.Visible = False
            BindTheGrid()
        End If
        CON = New OleDbConnection
        CON.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        CON.Open()
    End Sub
    Public Sub BindTheGrid()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        objConn = New OleDbConnection
        objConn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        objConn.Open()
        Dim cmdCustomers As OleDbCommand = New OleDbCommand("Select A.Emp_No,A.Emp_name, A.Emp_des,A.Emp_COM, B.Trn_ApDt, B.Trn_fdt,B.Trn_Tdt,B.Trn_NoLv,B.Trn_fg,A.Emp_Tolv,A.Emp_Balv ,A.Emp_Talv from EmpMast A ,TrnMast B where A.Emp_No=B.Trn_no and B.Trn_fg='Select'", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        dtgCustomers.DataSource = cmdCustomers.ExecuteReader()
        dtgCustomers.DataBind()
        objConn.Close()
    End Sub

    Public Sub BindTheGrid1()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        objConn = New OleDbConnection
        objConn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        objConn.Open()

        Dim cmdCustomers As OleDbCommand = New OleDbCommand("Select A.Emp_No,A.Emp_name, A.Emp_des,A.Emp_COM, B.Trn_ApDt, B.Trn_fdt,B.Trn_Tdt,B.Trn_NoLv,B.Trn_fg,A.Emp_Tolv,A.Emp_Balv ,A.Emp_Talv from EmpMast A ,TrnMast B where A.Emp_No=B.Trn_no and B.Trn_fg='Select' and A.Emp_com in(" & Txtss.Text & ")", objConn)

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
        Dim strConn As String = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        Dim MySQL As String = "Select Emp_No,Emp_name, Emp_des, " & _
        "Emp_talv, Emp_balv, Emp_tolv from EmpMast"
        Dim MyConn As New OleDbConnection(strConn)
        Dim objDR As OleDbDataReader
        Dim Cmd As New OleDbCommand(MySQL, MyConn)
        MyConn.Open()
        objDR = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

        objConn = New OleDbConnection
        objConn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        objConn.Open()

        Dim cmdCustomers As OleDbCommand = New OleDbCommand("SELECT Flag FROM Flag", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        Return cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Sub dtgCustomers_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        ' Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        objConn = New OleDbConnection
        objConn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        objConn.Open()


        Dim cmdCustomers As OleDbCommand
        Dim strid As String = CType(e.Item.FindControl("lblID"), Label).Text
        Dim strfg As String = CType(e.Item.FindControl("ddlCountry"), DropDownList).SelectedItem.Value
        Dim strNolv As Double = CType(e.Item.FindControl("lblNolv"), Label).Text
        Dim strfdt As String = CType(e.Item.FindControl("lblfdt"), Label).Text
        Dim strTdt As String = CType(e.Item.FindControl("lblTdt"), Label).Text
        Dim strApdt As String = CType(e.Item.FindControl("lblApdt"), Label).Text
        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String

        strSql = "UPDATE TrnMast SET Trn_fg='" & strfg & "' WHERE Trn_fg='Select' and Trn_No='" & strid & "' and Trn_apdt='" & strApdt & "'"
        cmdCustomers = New OleDbCommand(strSql, objConn)
        ' objConn.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        dtgCustomers.EditItemIndex = -1
        BindTheGrid1()
        dtgCustomers.Visible = True

        ADA = New OleDbDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '" & strid & "'", objConn)
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
        SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
        cmdCustomers = New OleDbCommand(SS, objConn)
        objConn.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        If strfg = "Approved" Then
            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = TxtMail.Text
            emailMessage.To = str_mail
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Your Leave Approval is Ok"

            emailMessage.Body = "ID NO: " + str_no + " " + str_name + " " + " Leave From :" + strfdt + " to :" + strTdt + " No of Leave :" + Str(strNolv) + " Approval is Ok"

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
                emailMessage.Subject = "Your Leave Approval is not Ok"

                emailMessage.Body = "ID NO: " + str_no + " " + str_name + " " + " Leave From :" + strfdt + " to :" + strTdt + " No of Leave :" + Str(strNolv) + " Approval is Not Ok"
                ' SS = "ID NO: " + TxtId.Text + " " + TxtNam.Text + "  For Your Approval " + "http://192.168.12.207/Leave/LeaveApproval.aspx"

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
        Dim User1 As String
        Dim Pwd1 As String
        Dim Count, Count1, Count2 As Double
        Dim dr1, dr2, dr3 As DataRow
        User1 = TxtUser1.Text
        Pwd1 = TxtPwd1.Text

        ADA = New OleDbDataAdapter("SELECT * FROM ADMIN WHERE AD_User = '" & User1 & "' AND AD_pwd = '" & Pwd1 & "'", CON)
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
            dtgCustomers.Visible = False
        End If

    End Sub


End Class
