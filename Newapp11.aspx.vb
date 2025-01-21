Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Configuration

Public Class NewApp11
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
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1, invtt1 As String
    Dim Intstk As Integer
    Dim Typ, BODY As String
    Dim AAA As String
    Dim InvVat As String
    Dim InvNo11 As String
    Dim customerId As String
    Dim StrInvcom, Strdt, strtotval, strtotqty, StrInvCode, StrInvFlag1, StrInvFlag2 As String
    Dim Count As Integer
    Dim Todt As String

    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents Image3 As System.Web.UI.WebControls.Image
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Image5 As System.Web.UI.WebControls.Image
    Protected WithEvents Image6 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtInvNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Image7 As System.Web.UI.WebControls.Image
    Protected WithEvents CrystalReportViewer2 As CrystalDecisions.Web.CrystalReportViewer

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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

        If Not IsPostBack Then
            'InvNo11 = HttpContext.Current.Request.QueryString("Type").ToString()
            InvNo11 = Global.PInvno

            'InvNo11 = "T-00445"
            TxtInvNo.Text = InvNo11
            '-------------------



            Dim DSS As TaxInvA = New TaxInvA

            CrystalReportViewer2.Visible = True

            Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.SetParameterValue("Invno", "" & Trim(Invno1) & "")


            CrystalReportViewer2.SeparatePages = True

            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False
            CrystalReportViewer2.RefreshReport()
            CrystalReportViewer2.DataBind()

            DSS.Refresh()



        End If


        '--------------------





    End Sub




End Class
