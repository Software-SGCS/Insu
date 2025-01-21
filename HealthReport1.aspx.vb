
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class HealthReport1
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2 As SqlDataReader
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
    Dim com11 As String
    Dim drt2, drt3, drt1, drt4, drt5 As DataRow
    Dim Typ, PSEC, PFLAG, TT As String
    Dim Count, COUNT2, COUNT1 As Integer
    Dim oStream As New MemoryStream
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents LstCom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtPage As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Button8 As System.Web.UI.WebControls.Button
    Protected WithEvents CrystalReportViewer2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button



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
        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        pflag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)




        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        count1 = DS.Tables("UsdMaster").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                Count2 = drt2("User_lvl")
                psec = drt2("User_sec")


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
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport1.aspx' and Form_level2='1'", CON)

                Else
                    If COUNT2 = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport1.aspx' and Form_level3='1'", CON)

                    Else
                        If COUNT2 = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport1.aspx' and Form_level4='1'", CON)
                        Else
                            If COUNT2 = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport1.aspx' and Form_level5='1'", CON)

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

            'BtnUpdate.Enabled = True

        End If


        If Not IsPostBack Then


            If PSEC = "ALL" Then
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
            Else
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(PSEC) & "'", CON)
            End If

            DR = CMD.ExecuteReader



            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCom.Items.Add(TT)
            End While



            DR.Close()

            ImageButton1.Visible = False

            'Data4()

            TxtPage.Text = "0"

        End If

        CON.Close()



        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim DSS As EmpList1 = New EmpList1


        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True

        Dim vehno1 As String




        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtPage.Text = "7"

        Dim DSS As BBBh = New BBBh
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        'AAA.Visible = False
        com11 = Mid(LstCom.SelectedValue, 1, 3)
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True

        Dim vehno1 As String

        'vehno1 = AAA.SelectedValue

        ImageButton1.Visible = True

        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("Com", "" & com11 & "")


        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TxtPage.Text = "3"

        Dim DSS As BBBh1 = New BBBh1
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        'AAA.Visible = False
        com11 = Mid(LstCom.SelectedValue, 1, 3)
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True

        Dim vehno1 As String

        'vehno1 = AAA.SelectedValue

        ImageButton1.Visible = True

        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("Com", "" & com11 & "")


        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim DSS As EmpListActive1 = New EmpListActive1
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        'AAA.Visible = False
        ImageButton1.Visible = True
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        TxtPage.Text = "1"
        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")

        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TxtPage.Text = "2"
        Dim DSS As EmpListDeActive1 = New EmpListDeActive1


        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False

        LstCom.Visible = False
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True


        com11 = Mid(LstCom.SelectedValue, 1, 3)


        ImageButton1.Visible = True


        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DSS As BBB = New BBB


        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False

        LstCom.Visible = False
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True


        com11 = Mid(LstCom.SelectedValue, 1, 3)





        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        'com11 = Mid(LstCom.SelectedValue, 1, 3)

        'Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
        'Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim myExportFile As String
        'Dim myReport As New EmpListActive1


        'myExportFile = Server.MapPath(".") & "/Data/EmpListActive1.PDF"
        'myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        'myDiskFileDestinationOptions.DiskFileName = myExportFile
        'myExportOptions = myReport.ExportOptions
        'With myExportOptions
        '    .DestinationOptions = myDiskFileDestinationOptions
        '    .ExportDestinationType = .ExportDestinationType.DiskFile
        '    .ExportFormatType = .ExportFormatType.PortableDocFormat

        'End With
        'myReport.SetDatabaseLogon("sa", "tstc123")
        'myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait


        'myReport.SetParameterValue("Com", "" & com11 & "")


        'myReport.Export()
        'myReport.Close()
        'Response.Clear()
        'Response.Buffer = True
        'Response.ContentType = "application/pdf"

        'Response.Redirect("Data/EmpListActive1.PDF")



       
        If TxtPage.Text = "1" Then

            Dim DSS As EmpListActive1 = New EmpListActive1
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False

            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            ImageButton1.Visible = True
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True



            com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("Com", "" & com11 & "")

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
            Dim DSS As BBBh1 = New BBBh1
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


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
        If TxtPage.Text = "2" Then
            Dim DSS As EmpListDeActive1 = New EmpListDeActive1


            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False

            LstCom.Visible = False
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer2.Visible = True


            com11 = Mid(LstCom.SelectedValue, 1, 3)

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("Com", "" & com11 & "")

            ' CrystalReportViewer2.SeparatePages = True

            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False

            CrystalReportViewer2.DataBind()
            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()

        End If

        If TxtPage.Text = "5" Then
            'TxtPage.Text = "5"

            Dim DSS As BBBh3 = New BBBh3
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            Button7.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue

            ImageButton1.Visible = True

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            'DSS.SetParameterValue("Com", "" & com11 & "")


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
        If TxtPage.Text = "7" Then
            Dim DSS As BBBh = New BBBh
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


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

        If TxtPage.Text = "8" Then
            Dim DSS As BBBP = New BBBP
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


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

    End Sub

    Private Sub LstCom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom.SelectedIndexChanged

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        '----

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        Button7.Visible = False
        'ImageButton1.Visible = True

        If TxtPage.Text = "1" Then

            Dim DSS As EmpListActive1 = New EmpListActive1
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            '  CrystalReportViewer2.Visible = True


            com11 = Mid(LstCom.SelectedValue, 1, 3)



            CrystalReportViewer1.Visible = True

            com11 = Mid(LstCom.SelectedValue, 1, 3)

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("Com", "" & com11 & "")

            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.DataBind()




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
            'ImageButton2.Visible = False
        'ImageButton1.Visible = False
        End If

        If TxtPage.Text = "3" Then
            Dim DSS As BBBh = New BBBh
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()
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

        If TxtPage.Text = "4" Then
            Dim DSS As EmpListDeActive1 = New EmpListDeActive1


            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False

            LstCom.Visible = False
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer2.Visible = True


            com11 = Mid(LstCom.SelectedValue, 1, 3)





            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("Com", "" & com11 & "")


            ' CrystalReportViewer2.SeparatePages = True

            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False

            CrystalReportViewer2.DataBind()
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
            Dim DSS As BBBh3 = New BBBh3
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer1.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue

            ImageButton1.Visible = True

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            'DSS.SetParameterValue("Com", "" & com11 & "")


            CrystalReportViewer1.ReportSource = DSS

            CrystalReportViewer1.HasRefreshButton = False
            CrystalReportViewer1.HasZoomFactorList = False
            CrystalReportViewer1.HasPageNavigationButtons = False
            CrystalReportViewer1.HasDrillUpButton = False

            CrystalReportViewer1.DataBind()
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
            Dim DSS As BBBP = New BBBP
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer2.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue

            ImageButton1.Visible = True

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False

            CrystalReportViewer2.DataBind()
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
        If TxtPage.Text = "7" Then
            Dim DSS As BBBh = New BBBh
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer2.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue

            ImageButton1.Visible = True

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False

            CrystalReportViewer2.DataBind()
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







        If TxtPage.Text = "8" Then
            Dim DSS As BBBP = New BBBP
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            'AAA.Visible = False
            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'Dim strReport As String = ""
            'strReport = "POPTop1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer2.Visible = True

            Dim vehno1 As String

            'vehno1 = AAA.SelectedValue

            ImageButton1.Visible = True

            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("Com", "" & com11 & "")


            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False

            CrystalReportViewer2.DataBind()
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





    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TxtPage.Text = "5"

        Dim DSS As BBBh3 = New BBBh3
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button7.Visible = False

        LstCom.Visible = False
        'AAA.Visible = False
        com11 = Mid(LstCom.SelectedValue, 1, 3)
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer1.Visible = True

        Dim vehno1 As String

        'vehno1 = AAA.SelectedValue

        ImageButton1.Visible = True

        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        'DSS.SetParameterValue("Com", "" & com11 & "")


        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False

        CrystalReportViewer1.DataBind()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TxtPage.Text = "8"

        Dim DSS As BBBP = New BBBP
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        'AAA.Visible = False
        com11 = Mid(LstCom.SelectedValue, 1, 3)
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True

        Dim vehno1 As String

        'vehno1 = AAA.SelectedValue

        ImageButton1.Visible = True

        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("Com", "" & com11 & "")


        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub
End Class
