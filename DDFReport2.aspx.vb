
Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
'Imports System.Configuration
'Imports System.Data
'Imports System.Data.SqlClient
Imports CrystalDecisions.ReportSource
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
'Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Net
Imports System.Drawing.Printing
Public Class DDFReport2
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim Conn As OleDbConnection
    Dim ADADB, ADADB1 As OleDbDataAdapter
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
    Dim Dtr, Dtr1, dtr2, drt1, drt2 As DataRow
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    'Dim pos1 As String
    Public pos1 As String
    Dim com11 As String
    Dim ss, ss1, tt, PSEC As String
    Dim oStream As New MemoryStream
    Dim Typ, PFLAG, StrEmpDel As String
    Dim Count, tot1, tot2, tot3, Count1, Count2 As Integer
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents CRYSTALREPORTVIEWER2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Report1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtFdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents btt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtTdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button8 As System.Web.UI.WebControls.Button
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtyr As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button9 As System.Web.UI.WebControls.Button
    Protected WithEvents Button10 As System.Web.UI.WebControls.Button
    Protected WithEvents Button12 As System.Web.UI.WebControls.Button
    Protected WithEvents Button13 As System.Web.UI.WebControls.Button
    Protected WithEvents Button11 As System.Web.UI.WebControls.Button
    Protected WithEvents Button14 As System.Web.UI.WebControls.Button
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton



#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
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
        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        PFLAG = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)




        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        COUNT1 = DS.Tables("UsdMaster").Rows.Count


        If COUNT1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                COUNT2 = drt2("User_lvl")
                PSEC = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If




        If Not IsPostBack Then
            PFLAG = "N"

            If COUNT2 = "1" Then
                PFLAG = "Y"

            Else

                If COUNT2 = "2" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DDFReport2.aspx' and Form_level2='1'", CON)

                Else
                    If COUNT2 = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DDFReport2.aspx' and Form_level3='1'", CON)

                    Else
                        If COUNT2 = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DDFReport2.aspx' and Form_level4='1'", CON)
                        Else
                            If COUNT2 = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DDFReport2.aspx' and Form_level5='1'", CON)

                            Else
                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & COUNT2 & "'", CON)

                            End If




                        End If
                    End If

                End If
                'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                DR = CMD.ExecuteReader
                While DR.Read
                    PFLAG = "Y"
                End While

                DR.Close()

            End If


            If PFLAG = "Y" Then
                Response.AddHeader("Refresh", 1800)
            Else

                Response.Redirect("POSDispaly11.aspx")
            End If
        End If
        'If Global.PwFlag = "Y" Then

        'Else
        '    Response.Redirect("InsuDept.aspx")
        'End If

        CMD = New SqlCommand("SELECT Com_No,Com_nam From Company", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                ' LstCom.Items.Add(DR.GetValue(0) + " - " + DR.GetValue(1))
            End While

            TxtFdt.Text = Format(Today(), "dd/MM/yyyy")
            TxtTdt.Text = Format(Today(), "dd/MM/yyyy")

            Calendar1.Visible = False
            Calendar2.Visible = False


        End If

        DR.Close()

        CMD = New SqlCommand("SELECT mt,mtn From MonthName", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then



            While DR.Read
                ' TxtYr.Text = Year(Today())
                'TxtYr1.Text = Year(Today())
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                'LstMt.Items.Add(DR.GetValue(0) + " - " + DR.GetValue(1))
                ' LstMt1.Items.Add(DR.GetValue(0) + " - " + DR.GetValue(1))
            End While
        End If

        DR.Close()


        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DSS As DeathReport1 = New DeathReport1


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim DSS As DeathReport2 = New DeathReport2


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim DSS As DeathReport2 = New DeathReport2


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim DSS As DeathReport2 = New DeathReport2


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DSS As DeathReport2 = New DeathReport2


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim DSS As DeathReport1 = New DeathReport1


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()



        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtFdt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TxtTdt.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False
    End Sub

    Private Sub btt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btt1.Click
        Calendar1.Visible = True
    End Sub


    Private Sub Imagebutton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton2.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Report1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Report1.Click
        Dim DSS As DeathReport1 = New DeathReport1


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DSS As Summery3 = New Summery3
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        ' Button11.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        ' LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        'BTT2.Visible = False
        ' AA.Visible = False
        ' BB.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        '  Button8.Visible = False
        ' TxtFlg.Text = "4"
        ImageButton1.Visible = True
        Label2.Visible = False
        ' Button9.Visible = False
        ' Button10.Visible = False
        ' DropDownList1.Visible = False
        Imagebutton2.Visible = True
        ' Button12.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrEmpDel As String
        'CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS1"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Dim DeleteCmd1 As String = "DELETE from MAS2"
        Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        Cmd1.ExecuteNonQuery()

        Dim DeleteCmd3 As String = "DELETE from MAS3"
        Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
        Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        'LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False



        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)


        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE  eMPdEL='N' order by Emp_com,Emp_No", CON)

        DS = New DataSet
        ADA.Fill(DS, "EmpMaster")
        Count = 0
        tot1 = 0
        tot2 = 0
        tot3 = 0
        Strcom = "AAA"




        For Each Dtr1 In DS.Tables("EmpMaster").Rows

            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("Emp_com"))
                tt = Trim(Dtr1("Emp_com"))
            End If

            If Trim(Strcom) = Trim(Dtr1("Emp_com")) Then
                tt = Trim(Dtr1("Emp_com"))
                StrEpfno = Dtr1("Emp_No")
                StrEname = Dtr1("Emp_Nam")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = IIf(IsDBNull(Dtr1("Emp_IdNo")), " ", Dtr1("Emp_IdNo"))
                StrEmpDel = Dtr1("EmpDel")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)


                If DateValue(StrEdate) < DateValue(Trim(ss)) And Trim(StrEmpAct) = "Y" Then


                    tot1 = tot1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        tot2 = tot2 + 1
                        'Try
                        Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                        tt = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                        'Catch ex As Exception

                        'End Try

                    End If
                End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                    tot3 = tot3 + 1

                    ' Try
                    Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                    tt = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                    'Catch ex As Exception
                    '
                    ' End Try


                End If



            Else
                'Strcom = Trim(Dtr1("Emp_com"))

                Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')")
                tt = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')"
                Cmd.ExecuteNonQuery()
                Count = 0
                tot1 = 0
                tot2 = 0
                tot3 = 0
                Strcom = Trim(Dtr1("Emp_com"))
                tt = Trim(Dtr1("Emp_com"))
                StrEpfno = Dtr1("Emp_No")
                StrEname = Dtr1("Emp_Nam")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = IIf(IsDBNull(Dtr1("Emp_IdNo")), " ", Dtr1("Emp_IdNo"))
                StrEmpDel = Dtr1("EmpDel")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)


                If DateValue(StrEdate) < DateValue(Trim(ss)) And Trim(StrEmpAct) = "Y" Then


                    tot1 = tot1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        tot2 = tot2 + 1
                        'Try
                        Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                        tt = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                        'Catch ex As Exception

                        'End Try

                    End If
                End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                    tot3 = tot3 + 1

                    ' Try
                    Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                    tt = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                    'Catch ex As Exception
                    '
                    ' End Try


                End If





                ' Try


                'Catch ex As Exception

                'End Try





            End If





        Next

        Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')")
        tt = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')"
        Cmd.ExecuteNonQuery()


        'Catch ex As Exception

        'End Try


        ' Strcom = Trim(Dtr1("Emp_com"))
        'Count = 0
        'tot1 = 0
        'tot2 = 0
        'tot3 = 0


        CRYSTALREPORTVIEWER2.Visible = True



        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim DSS As Summery3 = New Summery3
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        ' Button11.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        ' LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        'BTT2.Visible = False
        ' AA.Visible = False
        ' BB.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        '  Button8.Visible = False
        ' TxtFlg.Text = "4"
        ImageButton1.Visible = True
        Label2.Visible = False
        ' Button9.Visible = False
        ' Button10.Visible = False
        ' DropDownList1.Visible = False
        Imagebutton2.Visible = True
        ' Button12.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrEmpDel As String
        'CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS1"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Dim DeleteCmd1 As String = "DELETE from MAS2"
        Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        Cmd1.ExecuteNonQuery()

        Dim DeleteCmd3 As String = "DELETE from MAS3"
        Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
        Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        'LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False



        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE  eMPdEL='N' order by Emp_com,Emp_No", CON)

        DS = New DataSet
        ADA.Fill(DS, "EmpMaster")
        Count = 0
        tot1 = 0
        tot2 = 0
        tot3 = 0
        Strcom = "AAA"




        For Each Dtr1 In DS.Tables("EmpMaster").Rows

            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("Emp_com"))
                tt = Trim(Dtr1("Emp_com"))
            End If

            If Trim(Strcom) = Trim(Dtr1("Emp_com")) Then
                tt = Trim(Dtr1("Emp_com"))
                StrEpfno = Dtr1("Emp_No")
                StrEname = Dtr1("Emp_Nam")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = IIf(IsDBNull(Dtr1("Emp_IdNo")), " ", Dtr1("Emp_IdNo"))
                StrEmpDel = Dtr1("EmpDel")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)


                If DateValue(StrEdate) < DateValue(Trim(ss)) And Trim(StrEmpAct) = "Y" Then


                    tot1 = tot1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        tot2 = tot2 + 1
                        'Try
                        Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                        tt = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                        'Catch ex As Exception

                        'End Try

                    End If
                End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                    tot3 = tot3 + 1

                    ' Try
                    Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                    tt = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                    'Catch ex As Exception
                    '
                    ' End Try


                End If



            Else
                'Strcom = Trim(Dtr1("Emp_com"))
              
                Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')")
                tt = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')"
                Cmd.ExecuteNonQuery()
                Count = 0
                tot1 = 0
                tot2 = 0
                tot3 = 0
                Strcom = Trim(Dtr1("Emp_com"))
                tt = Trim(Dtr1("Emp_com"))
                StrEpfno = Dtr1("Emp_No")
                StrEname = Dtr1("Emp_Nam")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = IIf(IsDBNull(Dtr1("Emp_IdNo")), " ", Dtr1("Emp_IdNo"))
                StrEmpDel = Dtr1("EmpDel")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)


                If DateValue(StrEdate) < DateValue(Trim(ss)) And Trim(StrEmpAct) = "Y" Then


                    tot1 = tot1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        tot2 = tot2 + 1
                        'Try
                        Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                        tt = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                        'Catch ex As Exception

                        'End Try

                    End If
                End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                    tot3 = tot3 + 1

                    ' Try
                    Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                    tt = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                    'Catch ex As Exception
                    '
                    ' End Try


                End If





                ' Try
             

                'Catch ex As Exception

                'End Try



               

            End If





        Next

        Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')")
        tt = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')"
        Cmd.ExecuteNonQuery()


        'Catch ex As Exception

        'End Try


        ' Strcom = Trim(Dtr1("Emp_com"))
        'Count = 0
        'tot1 = 0
        'tot2 = 0
        'tot3 = 0





        CRYSTALREPORTVIEWER2.Visible = True



        'com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrEmpDel As String
        'CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS1"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Dim DeleteCmd1 As String = "DELETE from MAS2"
        Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        Cmd1.ExecuteNonQuery()

        Dim DeleteCmd3 As String = "DELETE from MAS3"
        Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
        Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        'LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False

        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE  eMPdEL='N' order by Emp_com,Emp_No", CON)

        DS = New DataSet
        ADA.Fill(DS, "EmpMaster")
        Count = 0
        tot1 = 0
        tot2 = 0
        tot3 = 0
        Strcom = "AAA"




        For Each Dtr1 In DS.Tables("EmpMaster").Rows

            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("Emp_com"))
                tt = Trim(Dtr1("Emp_com"))
            End If

            If Trim(Strcom) = Trim(Dtr1("Emp_com")) Then
                tt = Trim(Dtr1("Emp_com"))
                StrEpfno = Dtr1("Emp_No")
                StrEname = Dtr1("Emp_Nam")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = IIf(IsDBNull(Dtr1("Emp_IdNo")), " ", Dtr1("Emp_IdNo"))
                StrEmpDel = Dtr1("EmpDel")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)


                If DateValue(StrEdate) < DateValue(Trim(ss)) And Trim(StrEmpAct) = "Y" Then


                    tot1 = tot1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        tot2 = tot2 + 1
                        'Try
                        Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                        tt = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                        'Catch ex As Exception

                        'End Try

                    End If
                End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                    tot3 = tot3 + 1

                    ' Try
                    Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                    tt = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                    'Catch ex As Exception
                    '
                    ' End Try


                End If



            Else
                'Strcom = Trim(Dtr1("Emp_com"))

                Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')")
                tt = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')"
                Cmd.ExecuteNonQuery()



                Dim emailMessage As MailMessage
                emailMessage = New MailMessage

                emailMessage.From = "insurance@dsisamson.com"

                emailMessage.Subject = Strcom + " DDF Fund New Employee  From " + TxtFdt.Text + " to " + TxtTdt.Text

                ADA = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_TEmail1,Com_Eout from Company where Com_no='" & Strcom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "Company")

                Count2 = DS.Tables("Company").Rows.Count
                Dim SCNam, StEmail As String
                If Count2 <> 0 Then
                    For Each dtr2 In DS.Tables("Company").Rows

                        SCNam = dtr2("Com_Nam")
                        StEmail = Trim(dtr2("Com_TEmail1"))
                    Next


                    'emailMessage.To = dtr2("Com_TEmail")

                    ' emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += "No of Previous Employees:" + "" + Str(tot1 + tot3) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "New Employee :" & vbCrLf
                    emailMessage.Body += "Epf No  Name                   Date      " & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    ADA = New SqlDataAdapter("Select com,epfno,empnam,empidno,ent_date from Mas1 where Com='" & Strcom & "'", CON)
                    DS = New DataSet
                    ADA.Fill(DS, "Mas1")

                    Count2 = DS.Tables("Mas1").Rows.Count
                    Dim Scom, SEpfno, SEmpNam, SEmpIdno, SEdate As String

                    For Each dtr2 In DS.Tables("Mas1").Rows

                        Scom = dtr2("com")
                        SEpfno = dtr2("Epfno")
                        SEmpNam = dtr2("empnam")
                        SEmpIdno = dtr2("empidno")
                        SEdate = Format(CDate(dtr2("ent_date")), "dd/MM/yyyy")

                        emailMessage.Body += SEpfno + " " + Mid(SEmpNam, 1, 35) + " " + SEdate & vbCrLf

                    Next
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += "No of New Employees:" + "" + Str(tot2) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf


                    emailMessage.Body += "Left Employee :" & vbCrLf
                    emailMessage.Body += "Epf No  Name                   Left Date      " & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    ADA = New SqlDataAdapter("Select com,epfno,empnam,empidno,ent_date from Mas2 where Com='" & Strcom & "'", CON)
                    DS = New DataSet
                    ADA.Fill(DS, "Mas1")

                    Count2 = DS.Tables("Mas1").Rows.Count
                    'Dim Scom, SEpfno, SEmpNam, SEmpIdno, SEdate As String

                    For Each dtr2 In DS.Tables("Mas1").Rows

                        Scom = dtr2("com")
                        SEpfno = dtr2("Epfno")
                        SEmpNam = dtr2("empnam")
                        SEmpIdno = dtr2("empidno")
                        SEdate = Format(CDate(dtr2("ent_date")), "dd/MM/yyyy")

                        emailMessage.Body += SEpfno + " " + Mid(SEmpNam, 1, 35) + SEdate & vbCrLf

                    Next
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += "No of Left Employees:" + "" + Str(tot3) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    emailMessage.Body += "No of New Employees:" + "" + Str(tot1 + tot2) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += "Created By:" + Trim(L1.Text) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    ' emailMessage.To = "palithan@samsoncorporates.com,chamindas@samsoncorporates.com,shakilaw@samsoncorporates.com"
                    'emailMessage.To = "palithan@samsoncorporates.com"
                    emailMessage.To = Trim(StEmail) + ",suranjie@samsoncorporates.com"


                    SmtpMail.SmtpServer = "mail.dsisamson.com"
                    Try
                        SmtpMail.Send(emailMessage)

                    Catch ex As Exception

                    End Try

                End If


                Count = 0
                tot1 = 0
                tot2 = 0
                tot3 = 0
                Strcom = Trim(Dtr1("Emp_com"))
                tt = Trim(Dtr1("Emp_com"))
                StrEpfno = Dtr1("Emp_No")
                StrEname = Dtr1("Emp_Nam")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = IIf(IsDBNull(Dtr1("Emp_IdNo")), " ", Dtr1("Emp_IdNo"))
                StrEmpDel = Dtr1("EmpDel")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)


                If DateValue(StrEdate) < DateValue(Trim(ss)) And Trim(StrEmpAct) = "Y" Then


                    tot1 = tot1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        tot2 = tot2 + 1
                        'Try
                        Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                        tt = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                        'Catch ex As Exception

                        'End Try

                    End If
                End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                    tot3 = tot3 + 1

                    ' Try
                    Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                    tt = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                    'Catch ex As Exception
                    '
                    ' End Try


                End If





                ' Try


                'Catch ex As Exception

                'End Try





            End If





        Next

        Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')")
        tt = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & tot1 & "," & tot2 & "," & tot3 & ",'" & Trim(L1.Text) & "')"
        Cmd.ExecuteNonQuery()


        'Catch ex As Exception

        'End Try


        ' Strcom = Trim(Dtr1("Emp_com"))
        'Count = 0
        'tot1 = 0
        'tot2 = 0
        'tot3 = 0





    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim DSS As DDReport1 = New DDReport1


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        'DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        'DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("Myr", "" & Trim(Txtyr.Text) & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim DSS As DDReport1 = New DDReport1


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        'DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        'DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("Myr", "" & Trim(Txtyr.Text) & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"


        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim DSS As DDReport2 = New DDReport2


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        'DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        'DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("Myr", "" & Trim(Txtyr.Text) & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"


        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        'Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim DSS As CrystalReport6 = New CrystalReport6


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim DSS As DDReport2 = New DDReport2


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.SetParameterValue("Com", "" & com11 & "")
        'DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        'DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("Myr", "" & Trim(Txtyr.Text) & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrclAmt, Strcom, Stryr, Strmt, StrclAmt1, StrTyp As String

        Dim DeleteCmd As String = "DELETE from DDTemp"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False

        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Txtyr.Visible = False
        Button2.Visible = False
        Dim pay, pay1, pay2, pay3, pay4, pay5, pay6, pay7, pay8, pay9, pay10, pay11 As Double

        'Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

        yr1 = Trim(Txtyr.Text)
      
        ' ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr>='" & yr1 & "' and mt>='" & mt1 & "') and (yr<='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)
        ADA = New SqlDataAdapter("SELECT * FROM View13 order by com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View13")

        For Each Dtr1 In DS.Tables("View13").Rows
            Strcom = Dtr1("com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("RecAmt")
          

            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Recamt= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Recamt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else
                If Stryr = yr1 Then
                    Cmd.CommandText = ("INSERT INTO DDTemp (com,Yr,RecAmt,Payamt) VALUES ('" & Strcom & "','" & yr1 & "','" & StrclAmt & "','0')")
                    Cmd.ExecuteNonQuery()

                Else
                    ss = "INSERT INTO DDTemp (com,Yr,RecAmt) VALUES ('" & Strcom & "','" & Stryr & "','0')"
                    Cmd.CommandText = ("INSERT INTO DDTemp (com,Yr,RecAmt,Payamt) VALUES ('" & Strcom & "','" & yr1 & "','0','0')")
                    Cmd.ExecuteNonQuery()
                End If
            End If


            '
        Next
        pay = 0
        pay1 = 0
        pay2 = 0
        pay3 = 0
        pay4 = 0
        pay5 = 0
        pay6 = 0
        pay7 = 0
        pay8 = 0
        pay9 = 0
        pay10 = 0
        pay11 = 0
        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_amt,emp_yr,emp_mt FROM Hltmaster1 WHERE (Emp_yr<='" & yr1 & "' and Emp_mt<='" & mt1 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt", CON)
        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and (Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

            'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text & "') and ((Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr>='" & yr1 & "' and Emp_mt<='12')) and ((Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ",CON)

        ADA = New SqlDataAdapter("SELECT * FROM View12 where yr='" & yr1 & "' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View12")
        For Each Dtr1 In DS.Tables("View12").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            'StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Recamt= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Payamt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else

                
            End If
            '
        Next



        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Father' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay1= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next

        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Mother' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay2= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next


        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Father In Law' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay3= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next

        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Mother In Law' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay4= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Brother' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay5= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Sister' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay6= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Child' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay7= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Son' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay8= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Daughter' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay9= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Husband' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay10= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next
        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Wife' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay11= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next

        ADA = New SqlDataAdapter("SELECT * FROM View11 where yr='" & yr1 & "' and Emp_RelType='Employee' order by Emp_com,yr", CON)

        DS = New DataSet
        ADA.Fill(DS, "View11")
        For Each Dtr1 In DS.Tables("View11").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("yr")
            StrclAmt = Dtr1("Emp_DeathAmt")
            StrTyp = Dtr1("Emp_RelType")


            ADA = New SqlDataAdapter("SELECT * FROM DDTemp WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "DDTemp")
            Count = DS.Tables("DDTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If Stryr = yr1 Then
                    ss = "UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',pay1= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and Yr='" & Stryr & "'"
                    Cmd.CommandText = ("UPDATE DDTemp SET com='" & Strcom & "',yr= '" & Stryr & "',Pay12= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and Yr='" & yr1 & "'")
                    Cmd.ExecuteNonQuery()
                End If

            Else


            End If
            '
        Next

        Dim DSS As DDFReport = New DDFReport
        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")
        'DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        'DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("mtname", "" & mtn & "")
        'DSS.SetParameterValue("myr", "" & yr1 & "")
        'DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        'DSS.SetParameterValue("myr1", "" & yr2 & "")

        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

        'oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
        'Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/vnd.ms-excel"

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
    End Sub
End Class
