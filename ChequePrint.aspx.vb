
Imports System.Data.Sqlclient
Imports System.Data
Public Class ChequePrint

    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader

    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    'Dim pos1 As String
    Public pos1 As String

    Dim Typ As String
    Dim Count As Integer
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtdt As System.Web.UI.WebControls.TextBox


    Dim DSS As CrystalReport2 = New CrystalReport2

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList

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
        Dim dd As String
        If Not IsPostBack Then
            dd = Format(Today, "dd/MM/yyyy")

            Txtdt.Text = Mid(dd, 1, 2) + "/" + Mid(dd, 4, 2) + "/" + Mid(dd, 7, 4)
        End If

        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='CrsCertificate.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            'Response.Redirect("InsuDept.aspx")
        End If

        If Not IsPostBack Then
            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT Com_No,Com_Nam FROM Supplier where Com_No<>''", CON)

            DR = CMD.ExecuteReader

            If Not IsPostBack Then


                While DR.Read
                    TT = DR.GetValue(0) + "-" + DR.GetValue(1)
                    LstId.Items.Add(TT)
                End While
            End If
            DR.Close()



        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label1.Visible = False
        Button1.Visible = False
        LstId.Visible = False


        Label2.Visible = False
        Label3.Visible = False
        Txtdt.Visible = False
        TxtAmt.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True

        Dim Amt1 As Double
        Dim Com1 As String
        Dim Amt2 As String
        Dim txtdt1 As String


        Amt1 = Val(TxtAmt.Text)
        Amt2 = Format(Amt1, "*************###,###,###.00")
        Amt2 = Right(Amt2, 15)
        Com1 = Mid((LstId.SelectedValue), 1, 4)
        txtdt1 = Txtdt.Text


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperEnvelope10
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        DSS.SetParameterValue("ComCode", "" & Com1 & "")
        DSS.SetParameterValue("Amt", "" & Amt1 & "")
        DSS.SetParameterValue("AmtStr", "" & Amt2 & "")
        DSS.SetParameterValue("Chqdt", "" & txtdt1 & "")

        CrystalReportViewer1.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()

    End Sub

    Private Sub Txtdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtdt.TextChanged
    End Sub

    Private Sub LstId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstId.SelectedIndexChanged

    End Sub
End Class
