Imports System.Data.Sqlclient
Imports System.Data
Public Class PopView4
    Inherits System.Web.UI.Page
    Dim DSS As Certificate = New Certificate

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

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


        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
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

End Class

