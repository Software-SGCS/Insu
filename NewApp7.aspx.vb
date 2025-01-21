Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Configuration

Public Class NewApp7
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS, ds1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim Dtr, Dtr1, dtr2 As DataRow
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    'Dim pos1 As String
    Public pos1 As String
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1 As String
    Dim Intstk As Integer
    Dim Typ, BODY As String
    Dim AAA As String
    Dim InvVat As String
    Dim InvNo11 As String
    Dim customerId As String
    Dim StrInvcom, Strdt, strtotval, strtotqty, StrInvCode, StrInvFlag1, StrInvFlag2 As String
    Dim Count As Integer
    Dim Todt As String
    Dim DSS As Certificate = New Certificate
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents Image3 As System.Web.UI.WebControls.Image
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Image5 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image7 As System.Web.UI.WebControls.Image
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

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

        Button3.Enabled = True
        Button1.Enabled = True

        Button3.Text = "Not Approve"
        Button1.Text = "Approve"
        CrystalReportViewer1.Visible = True



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Vehno", "" & Global.PVehno & "")

        CrystalReportViewer1.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()


        'CrystalReportViewer1.Visible = True

        'DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait



        'CrystalReportViewer1.SeparatePages = True

        'CrystalReportViewer1.ReportSource = DSS

        'CrystalReportViewer1.HasRefreshButton = False
        'CrystalReportViewer1.HasZoomFactorList = False
        'CrystalReportViewer1.HasPageNavigationButtons = False
        'CrystalReportViewer1.HasDrillUpButton = False

        'CrystalReportViewer1.DataBind()
        'CrystalReportViewer1.RefreshReport()
        'DSS.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String
        strfg = "Approved"

        strSql = "UPDATE VehMast SET Allow1='" & strfg & "' WHERE Veh_No='" & Global.PVehno & "'"
        'strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & Global.PVehno & "'"
        cmdCustomers = New SqlCommand(strSql, CON)

        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        CON.Close()




       


        Button1.Enabled = False
        Button1.Text = "O K"
        'If strfg = "Not Approved" Then
        '    Dim emailMessage As MailMessage
        '    emailMessage = New MailMessage
        '    emailMessage.From = "chamindas@dsisamson.com"
        '    emailMessage.To = str_mail

        '    emailMessage.Subject = "Your Insu Approval is not Ok"

        '    emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"


        '    SmtpMail.SmtpServer = "mail.dsisamson.com"
        '    Try
        '        SmtpMail.Send(emailMessage)

        '    Catch ex As Exception

        '    End Try


        'End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String
        strfg = "Not Approved"


        strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & Global.PVehno & "'"
        cmdCustomers = New SqlCommand(strSql, CON)

        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)

        CON.Close()
        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count1 = DS.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each Dtr1 In DS.Tables("EmpMast").Rows
                Talv = Dtr1("Emp_talv")
                Balv = Dtr1("Emp_balv")
                str_no = Dtr1("Emp_no")
                str_name = Dtr1("Emp_name")
                str_mail = Dtr1("Emp_email")
            Next
        End If

        ADA = New SqlDataAdapter("SELECT * FROM VehMast WHERE Veh_No='" & Global.PVehno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehMast")

        Count1 = DS.Tables("VehMast").Rows.Count
        If Count1 <> 0 Then
            For Each dtr2 In DS.Tables("VehMast").Rows
                strTpay = dtr2("Veh_Tpay")
                strEfdt = dtr2("Veh_EfDt")
                strExdt = dtr2("Veh_ExDt")
                strVal = dtr2("Veh_Val")
                strCom = dtr2("Veh_Com")
            Next
        End If
        Dim SS As String

        If strfg = "Not Approved" Then
            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "chamindas@dsisamson.com"


            emailMessage.To = str_mail
            'emailMessage.To = "palithan@samsoncorporates.com"

            emailMessage.Subject = "Your Insu Approval is not Ok"

            emailMessage.Body = "Vehcle No :" + Global.PVehno + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://sgcsser/Insu/Crs.aspx"


            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try
        End If

        'If strfg = "Not Approved" Then
        '    Dim emailMessage As MailMessage
        '    emailMessage = New MailMessage
        '    emailMessage.From = "chamindas@dsisamson.com"
        '    emailMessage.To = str_mail

        '    emailMessage.Subject = "Your Insu Approval is not Ok"

        '    emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"


        '    SmtpMail.SmtpServer = "mail.dsisamson.com"
        '    Try
        '        SmtpMail.Send(emailMessage)

        '    Catch ex As Exception

        '    End Try


        'End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String
        strfg = "Not Approved"

        strSql = "UPDATE VehMast SET Allow1='" & strfg & "' WHERE Allow1='Select' and Veh_No='" & Global.PVehno & "'"
        ' strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "',ALLOW1='Select' WHERE ALLOW2='Select' and Veh_No='" & Global.PVehno & "'"
        cmdCustomers = New SqlCommand(strSql, CON)

        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)

        CON.Close()
        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count1 = DS.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each Dtr1 In DS.Tables("EmpMast").Rows
                Talv = Dtr1("Emp_talv")
                Balv = Dtr1("Emp_balv")
                str_no = Dtr1("Emp_no")
                str_name = Dtr1("Emp_name")
                str_mail = Dtr1("Emp_email")
            Next
        End If

        ADA = New SqlDataAdapter("SELECT * FROM VehMast WHERE Veh_No='" & Global.PVehno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehMast")

        Count1 = DS.Tables("VehMast").Rows.Count
        If Count1 <> 0 Then
            For Each dtr2 In DS.Tables("VehMast").Rows
                strTpay = dtr2("Veh_Tpay")
                strEfdt = dtr2("Veh_EfDt")
                strExdt = dtr2("Veh_ExDt")
                strVal = dtr2("Veh_Val")
                strCom = dtr2("Veh_Com")
            Next
        End If
        Dim SS As String

        If strfg = "Not Approved" Then
            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "chamindas@dsisamson.com"


            emailMessage.To = str_mail
            'emailMessage.To = "palithan@samsoncorporates.com"

            emailMessage.Subject = "Your Certificate  is not Ok"

            emailMessage.Body = "Vehcle No :" + Global.PVehno + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"


            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try
        End If

        Button3.Enabled = False
        Button3.Text = "O K"


        'If strfg = "Not Approved" Then
        '    Dim emailMessage As MailMessage
        '    emailMessage = New MailMessage
        '    emailMessage.From = "chamindas@dsisamson.com"
        '    emailMessage.To = str_mail

        '    emailMessage.Subject = "Your Insu Approval is not Ok"

        '    emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"


        '    SmtpMail.SmtpServer = "mail.dsisamson.com"
        '    Try
        '        SmtpMail.Send(emailMessage)

        '    Catch ex As Exception

        '    End Try


        'End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


    End Sub
End Class
