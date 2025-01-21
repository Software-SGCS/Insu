Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class PettyCashReport1
    Inherits System.Web.UI.Page

    Dim oStream As New MemoryStream
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TxtTdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TxtFdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents BTT2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents CRYSTALREPORTVIEWER1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents TxtSDate As System.Web.UI.WebControls.TextBox
    Protected WithEvents Imagebutton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar3 As System.Web.UI.WebControls.Calendar

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
        If Not IsPostBack Then
            Calendar2.Visible = False
            Calendar1.Visible = False

            Calendar3.Visible = False
            TxtSDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
            ''SS = System.DateTime.Now.ToString("HH:mm:ss")
            TxtFdt.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
            TxtTdt.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DSS As Admin1 = New Admin1
        'Button1.Visible = False


        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "0"
        CrystalReportViewer1.Visible = True



        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")

        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtPage.Text = "1"

        Dim DSS As AdminReport2 = New AdminReport2
        'Button1.Visible = False
        'Button2.Visible = False

        'AAA.Visible = False
        ImageButton1.Visible = True
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CRYSTALREPORTVIEWER1.Enabled = False



        CrystalReportViewer1.Visible = True

        'com11 = Mid(LstCom.SelectedValue, 1, 3)

        CRYSTALREPORTVIEWER1.Enabled = True

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If TxtPage.Text = "1" Then

            Dim DSS As AdminReport2 = New AdminReport2

            'Button1.Visible = False
            'Button2.Visible = False

            'AAA.Visible = False
            ImageButton1.Visible = True
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True



            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()


            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If
        If TxtPage.Text = "0" Then

            Dim DSS As Admin1 = New Admin1
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "0"
            CrystalReportViewer1.Visible = True



            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")

            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()


            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If

        If TxtPage.Text = "2" Then

            Dim DSS As AdminReport3 = New AdminReport3
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CrystalReportViewer1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()



            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If

        If TxtPage.Text = "3" Then

            Dim DSS As AdminReport4 = New AdminReport4
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CrystalReportViewer1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()



            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If
        If TxtPage.Text = "4" Then
            Dim DSS As ItemReport1 = New ItemReport1
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "4"
            CrystalReportViewer1.Visible = True



            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")

            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()
            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
        End If

        If TxtPage.Text = "5" Then
            Dim DSS As AdminReport5 = New AdminReport5
            ' Dim DSS As AdminReport3 = New AdminReport3
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CrystalReportViewer1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()



            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"
        End If

        If TxtPage.Text = "6" Then
            Dim DSS As AdminReport6 = New AdminReport6
            ' Dim DSS As AdminReport3 = New AdminReport3
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CRYSTALREPORTVIEWER1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()



            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"
        End If
    End Sub

    Private Sub Imagebutton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click
        Calendar3.Visible = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DSS As AdminReport4 = New AdminReport4
        'Button1.Visible = False


        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "3"
        CRYSTALREPORTVIEWER1.Visible = True

        'CrystalReportViewer1.RefreshReport()

        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CRYSTALREPORTVIEWER1.ReportSource = DSS

        CRYSTALREPORTVIEWER1.HasRefreshButton = False
        CRYSTALREPORTVIEWER1.HasZoomFactorList = False
        CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER1.HasDrillUpButton = False
        CRYSTALREPORTVIEWER1.DataBind()

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        If TxtPage.Text = "1" Then

            Dim DSS As AdminReport2 = New AdminReport2
            ' Button1.Visible = False
            ' Button2.Visible = False

            'AAA.Visible = False
            ImageButton1.Visible = True
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CRYSTALREPORTVIEWER1.Visible = True



            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()


            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If
        If TxtPage.Text = "0" Then

            Dim DSS As Admin1 = New Admin1
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "0"
            CRYSTALREPORTVIEWER1.Visible = True



            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")

            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()


            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If

        If TxtPage.Text = "2" Then

            Dim DSS As AdminReport3 = New AdminReport3
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CRYSTALREPORTVIEWER1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()



            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If

        If TxtPage.Text = "3" Then

            Dim DSS As AdminReport4 = New AdminReport4
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CRYSTALREPORTVIEWER1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()



            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
            'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            'Response.Clear()
            'Response.Buffer = True
            'Response.ContentType = "application/vnd.ms-excel"

        End If

        If TxtPage.Text = "4" Then
            Dim DSS As ItemReport1 = New ItemReport1
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "4"
            CRYSTALREPORTVIEWER1.Visible = True



            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")

            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()
            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
        End If
        If TxtPage.Text = "5" Then
            Dim DSS As AdminReport5 = New AdminReport5
            ' Dim DSS As AdminReport3 = New AdminReport3
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CRYSTALREPORTVIEWER1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()



            CRYSTALREPORTVIEWER1.DataBind()
            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
        End If

        If TxtPage.Text = "6" Then
            Dim DSS As AdminReport6 = New AdminReport6
            ' Dim DSS As AdminReport3 = New AdminReport3
            'Button1.Visible = False


            'AAA.Visible = False

            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)

            'TxtPage.Text = "2"
            CRYSTALREPORTVIEWER1.Visible = True

            ' CrystalReportViewer1.RefreshReport()

            'com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CRYSTALREPORTVIEWER1.ReportSource = DSS

            CRYSTALREPORTVIEWER1.HasRefreshButton = False
            CRYSTALREPORTVIEWER1.HasZoomFactorList = False
            CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
            CRYSTALREPORTVIEWER1.HasDrillUpButton = False

            CRYSTALREPORTVIEWER1.DataBind()



            CRYSTALREPORTVIEWER1.DataBind()
            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
            Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/vnd.ms-excel"

            Try
                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch err As Exception
                Response.Write("<BR>")
                Response.Write(err.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DSS As SignOn = New SignOn
        'Button1.Visible = False



        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "4"
        CRYSTALREPORTVIEWER1.Visible = True



        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA3
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")

        DSS.SetParameterValue("dt", "" & Mid(Trim(TxtSDate.Text), 4, 2) + "/" + Mid(Trim(TxtSDate.Text), 1, 2) + "/" + Mid(Trim(TxtSDate.Text), 7, 4) & "")

        CRYSTALREPORTVIEWER1.ReportSource = DSS

        CRYSTALREPORTVIEWER1.HasRefreshButton = False
        CRYSTALREPORTVIEWER1.HasZoomFactorList = False
        CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER1.HasDrillUpButton = False

        CRYSTALREPORTVIEWER1.DataBind()


        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DSS As AdminReport5 = New AdminReport5
        'Button1.Visible = False


        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "5"
        CRYSTALREPORTVIEWER1.Visible = True

        'CrystalReportViewer1.RefreshReport()

        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CRYSTALREPORTVIEWER1.ReportSource = DSS

        CRYSTALREPORTVIEWER1.HasRefreshButton = False
        CRYSTALREPORTVIEWER1.HasZoomFactorList = False
        CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER1.HasDrillUpButton = False
        CRYSTALREPORTVIEWER1.DataBind()


    End Sub

    Private Sub btt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btt1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub BTT2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BTT2.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtFdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TxtTdt.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim DSS As AdminReport3 = New AdminReport3
        'Button1.Visible = False


        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "2"
        CRYSTALREPORTVIEWER1.Visible = True

        ' CrystalReportViewer1.RefreshReport()

        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CRYSTALREPORTVIEWER1.ReportSource = DSS

        CRYSTALREPORTVIEWER1.HasRefreshButton = False
        CRYSTALREPORTVIEWER1.HasZoomFactorList = False
        CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER1.HasDrillUpButton = False

        CRYSTALREPORTVIEWER1.DataBind()



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DSS As AdminReport6 = New AdminReport6
        'Button1.Visible = False


        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "6"
        CRYSTALREPORTVIEWER1.Visible = True



        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")

        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CRYSTALREPORTVIEWER1.ReportSource = DSS

        CRYSTALREPORTVIEWER1.HasRefreshButton = False
        CRYSTALREPORTVIEWER1.HasZoomFactorList = False
        CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER1.HasDrillUpButton = False

        CRYSTALREPORTVIEWER1.DataBind()
    End Sub

    Private Sub Calendar3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar3.SelectionChanged
        TxtSDate.Text = Format((Calendar3.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar3.Visible = False

        Dim DSS As SignOn = New SignOn
        'Button1.Visible = False



        'AAA.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "4"
        CRYSTALREPORTVIEWER1.Visible = True



        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA3
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")

        DSS.SetParameterValue("dt", "" & Mid(Trim(TxtSDate.Text), 4, 2) + "/" + Mid(Trim(TxtSDate.Text), 1, 2) + "/" + Mid(Trim(TxtSDate.Text), 7, 4) & "")

        CRYSTALREPORTVIEWER1.ReportSource = DSS

        CRYSTALREPORTVIEWER1.HasRefreshButton = False
        CRYSTALREPORTVIEWER1.HasZoomFactorList = False
        CRYSTALREPORTVIEWER1.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER1.HasDrillUpButton = False

        CRYSTALREPORTVIEWER1.DataBind()


        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub
End Class
