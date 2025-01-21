Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class HealthReport3
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
    Dim oStream As New MemoryStream
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
    Public PriFlg As String
    Dim fileList As ArrayList = New ArrayList
    Dim DSS1 As EmpRecValue1 = New EmpRecValue1
    'Dim oStream As New MemoryStream

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
    Protected WithEvents TxtFdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents btt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents aa As System.Web.UI.WebControls.Label
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TxtTdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents BTT2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents BB As System.Web.UI.WebControls.Label
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Button8 As System.Web.UI.WebControls.Button
    Protected WithEvents CrystalReportViewer2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtFlg As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button9 As System.Web.UI.WebControls.Button
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Button10 As System.Web.UI.WebControls.Button
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtAccYr As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
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
            TxtAccYr.Text = Trim(Year(Today()))



            PriFlg = "0"
            TxtFlg.Text = "1"
            ImageButton1.Visible = False
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

            TxtFdt.Text = Format(Today(), "dd/MM/yyyy")
            TxtTdt.Text = Format(Today(), "dd/MM/yyyy")

            Calendar1.Visible = False
            Calendar2.Visible = False
            'Data4()
        End If

        If Not IsPostBack Then
            With DropDownList1.Items
                .Add("Rich Text (RTF)")
                .Add("Portable Document (PDF)")
                .Add("MS Word (DOC)")
                .Add("MS Excel (XLS)")
            End With

            Label2.Visible = False
            Button9.Visible = True
            Button10.Visible = False
            DropDownList1.Visible = False
            ImageButton1.Visible = False
            ImageButton2.Visible = False

        End If

        CON.Close()



        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim DSS As EmpList1 = New EmpList1


        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        Button8.Visible = False


        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True

        Dim vehno1 As String




        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim DSS As EmpListActive = New EmpListActive
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        Button6.Visible = False
        'AAA.Visible = False
        Button7.Visible = False
        Button8.Visible = False

        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True

        Dim vehno1 As String

        'vehno1 = AAA.SelectedValue



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")



        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim DSS As RecClaims = New RecClaims
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = False
        BB.Visible = False
        Button8.Visible = False

        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False


        TxtFlg.Text = "6"
        ImageButton1.Visible = True
        ImageButton2.Visible = True
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        DSS.SetParameterValue("AccYr", "" & Trim(TxtAccYr.Text) & "")

        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()

        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim DSS As Submitclaims = New Submitclaims
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = False
        BB.Visible = False
        Button8.Visible = False
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        PriFlg = "1"
        TxtFlg.Text = "1"
        ImageButton1.Visible = True
        ImageButton2.Visible = True

        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DSS As PendingList = New PendingList
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button6.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = False
        BB.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False

        TxtFlg.Text = "5"
        ImageButton1.Visible = True
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()


    
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

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click


        If TxtFlg.Text = "1" Then
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            TxtFdt.Visible = False
            TxtTdt.Visible = False
            btt1.Visible = False
            BTT2.Visible = False
            aa.Visible = False
            BB.Visible = False
            Button8.Visible = False
            Label2.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            DropDownList1.Visible = False

            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            '  CrystalReportViewer2.Visible = True


            com11 = Mid(LstCom.SelectedValue, 1, 3)



            TxtFlg.Text = "0"
            ImageButton1.Visible = False


            Dim DSS As Submitclaims = New Submitclaims


            PriFlg = "1"
            ' TxtFlg.Text = "1"
            ImageButton1.Visible = True
            ImageButton2.Visible = True

            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            CrystalReportViewer2.Visible = True



            com11 = Mid(LstCom.SelectedValue, 1, 3)



            DSS.SetDatabaseLogon("sa", "tstc123")
            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            DSS.SetParameterValue("Com", "" & com11 & "")
            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
            Response.ContentType = "Application.pdf"
            Response.BinaryWrite(oStream.ToArray())
            'Response.StatusDescription = False

            Response.End()
        Else
            If TxtFlg.Text = "2" Then


                Dim DSS As BBB = New BBB
                Button1.Visible = False
                Button2.Visible = False
                Button3.Visible = False
                Button7.Visible = False
                Button4.Visible = False
                Button5.Visible = False
                LstCom.Visible = False
                TxtFdt.Visible = False
                TxtTdt.Visible = False
                btt1.Visible = False
                BTT2.Visible = False
                aa.Visible = False
                BB.Visible = False
                Button6.Visible = False
                Button8.Visible = False
                TxtFlg.Text = "2"
                ImageButton1.Visible = True
                Label2.Visible = False
                Button9.Visible = False
                Button10.Visible = False
                DropDownList1.Visible = False
                ImageButton2.Visible = True
                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                'Page.RegisterStartupScript("OpenWindow", strJS)


                CrystalReportViewer2.Visible = True



                com11 = Mid(LstCom.SelectedValue, 1, 3)



                DSS.SetDatabaseLogon("sa", "tstc123")
                'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                DSS.SetParameterValue("Com", "" & com11 & "")
                DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
                DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                Response.ContentType = "Application.pdf"
                Response.BinaryWrite(oStream.ToArray())
                'Response.StatusDescription = False

                Response.End()


                TxtFlg.Text = "0"
                ImageButton1.Visible = False




            Else
                If TxtFlg.Text = "3" Then
                    Dim DSS As CCC = New CCC
                    Button1.Visible = False
                    Button2.Visible = False
                    Button3.Visible = False

                    Button4.Visible = False
                    Button5.Visible = False
                    LstCom.Visible = False
                    TxtFdt.Visible = False
                    TxtTdt.Visible = False
                    btt1.Visible = False
                    BTT2.Visible = False
                    aa.Visible = False
                    BB.Visible = False
                    Button6.Visible = False
                    Button7.Visible = False
                    Button8.Visible = False
                    TxtFlg.Text = "3"
                    ImageButton1.Visible = True
                    Label2.Visible = False
                    Button9.Visible = False
                    Button10.Visible = False
                    DropDownList1.Visible = False
                    ImageButton2.Visible = True

                    'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                    'Page.RegisterStartupScript("OpenWindow", strJS)


                    CrystalReportViewer2.Visible = True



                    com11 = Mid(LstCom.SelectedValue, 1, 3)



                    DSS.SetDatabaseLogon("sa", "tstc123")
                    'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                    'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                    'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                    DSS.SetParameterValue("Com", "" & com11 & "")
                    DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                    'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
                    DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                    Response.ContentType = "Application.pdf"
                    Response.BinaryWrite(oStream.ToArray())
                    'Response.StatusDescription = False

                    Response.End()



                    TxtFlg.Text = "0"
                    ImageButton1.Visible = False
                Else
                    If TxtFlg.Text = "4" Then
                        Dim DSS As AAA = New AAA
                        Button1.Visible = False
                        Button2.Visible = False
                        Button3.Visible = False

                        Button4.Visible = False
                        Button5.Visible = False
                        LstCom.Visible = False
                        TxtFdt.Visible = False
                        TxtTdt.Visible = False
                        btt1.Visible = False
                        BTT2.Visible = False
                        aa.Visible = False
                        BB.Visible = False
                        Button6.Visible = False
                        Button7.Visible = False
                        Button8.Visible = False
                        TxtFlg.Text = "4"
                        ImageButton1.Visible = True
                        Label2.Visible = False
                        Button9.Visible = False
                        Button10.Visible = False
                        DropDownList1.Visible = False
                        ImageButton2.Visible = True
                        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                        'Page.RegisterStartupScript("OpenWindow", strJS)


                        CrystalReportViewer2.Visible = True



                        com11 = Mid(LstCom.SelectedValue, 1, 3)



                        DSS.SetDatabaseLogon("sa", "tstc123")
                        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                        DSS.SetParameterValue("Com", "" & com11 & "")
                        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
                        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                        Response.ContentType = "Application.pdf"
                        Response.BinaryWrite(oStream.ToArray())
                        'Response.StatusDescription = False

                        Response.End()


                        TxtFlg.Text = "0"
                        ImageButton1.Visible = False
                    Else
                        If TxtFlg.Text = "5" Then
                            Dim DSS As PendingList = New PendingList
                            Button1.Visible = False
                            Button2.Visible = False
                            Button3.Visible = False
                            Button6.Visible = False
                            Button4.Visible = False
                            Button5.Visible = False
                            LstCom.Visible = False
                            TxtFdt.Visible = False
                            TxtTdt.Visible = False
                            btt1.Visible = False
                            BTT2.Visible = False
                            aa.Visible = False
                            BB.Visible = False
                            Button7.Visible = False
                            Button8.Visible = False
                            Label2.Visible = False
                            Button9.Visible = False
                            Button10.Visible = False

                            TxtFlg.Text = "5"
                            ImageButton1.Visible = True
                            DropDownList1.Visible = False
                            ImageButton2.Visible = True
                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)


                            CrystalReportViewer2.Visible = True



                            com11 = Mid(LstCom.SelectedValue, 1, 3)



                            DSS.SetDatabaseLogon("sa", "tstc123")
                            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                            DSS.SetParameterValue("Com", "" & com11 & "")
                            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                            'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
                            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                            Response.ContentType = "Application.pdf"
                            Response.BinaryWrite(oStream.ToArray())
                            'Response.StatusDescription = False

                            Response.End()


                            TxtFlg.Text = "0"
                            ImageButton1.Visible = False
                        Else
                            If TxtFlg.Text = "6" Then

                                Dim DSS As RecClaims = New RecClaims
                                Button1.Visible = False
                                Button2.Visible = False
                                Button3.Visible = False
                                Button6.Visible = False
                                Button7.Visible = False
                                Button4.Visible = False
                                Button5.Visible = False
                                LstCom.Visible = False
                                TxtFdt.Visible = False
                                TxtTdt.Visible = False
                                btt1.Visible = False
                                BTT2.Visible = False
                                aa.Visible = False
                                BB.Visible = False
                                Button8.Visible = False

                                Label2.Visible = False
                                Button9.Visible = False
                                Button10.Visible = False
                                DropDownList1.Visible = False


                                TxtFlg.Text = "6"
                                ImageButton1.Visible = True
                                ImageButton2.Visible = True
                                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                'Page.RegisterStartupScript("OpenWindow", strJS)


                                CrystalReportViewer2.Visible = True



                                com11 = Mid(LstCom.SelectedValue, 1, 3)



                                DSS.SetDatabaseLogon("sa", "tstc123")
                                'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                                'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                                'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                                DSS.SetParameterValue("Com", "" & com11 & "")
                                DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
                                DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                                DSS.SetParameterValue("AccYr", "" & Trim(TxtAccYr.Text) & "")

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
                                Response.ContentType = "Application.pdf"
                                Response.BinaryWrite(oStream.ToArray())
                                'Response.StatusDescription = False

                                Response.End()

                                TxtFlg.Text = "0"
                                ImageButton1.Visible = False

                            End If
                        End If


                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BTT2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BTT2.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DSS As BBB = New BBB
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button7.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = False
        BB.Visible = False
        Button6.Visible = False
        Button8.Visible = False
        TxtFlg.Text = "2"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim DSS As CCC = New CCC
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = False
        BB.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        TxtFlg.Text = "3"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True

        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim DSS As AAA = New AAA
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = False
        TxtFdt.Visible = False
        TxtTdt.Visible = False
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = False
        BB.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        TxtFlg.Text = "4"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CrystalReportViewer2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub TxtFlg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFlg.TextChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click


        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        'Try
        ExportReport()
        'Catch ex As Exception
        'Response.Write(ex.Message)
        'Response.End()
        ' End Try


    End Sub


    Sub ExportReport()

        Try

            com11 = Mid(LstCom.SelectedValue, 1, 3)
            'OBJ1.ConnectDBH()
            CrystalReportViewer2.Visible = False
            DSS1.SetDatabaseLogon("sa", "tstc123")
            DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

            DSS1.SetParameterValue("Com", "" & com11 & "")
            DSS1.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
            DSS1.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

            CrystalReportViewer2.ReportSource = DSS1
            CrystalReportViewer2.DataBind()

        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try





        ' // using System.IO

        Select Case DropDownList1.SelectedItem.Text 'this contains the value of the selected export format.

            Case "Rich Text (RTF)"
                '--------------------------------------------------------------------
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)
                ' Response.AddHeader("content-disposition", "attachment;filename=FileName.rtf")
                Response.AddHeader("Content-Disposition", "attachment;filename=FileName.rtf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/rtf"
                'Response.ContentType = "application/vnd.text"


                '' Response.ContentType = "application/plain"

                '--------------------------------------------------------------------
                '--------------------------------------------------------------------
            Case "Portable Document (PDF)"
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.pdf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/pdf"
                '--------------------------------------------------------------------

                '--------------------------------------------------------------------
            Case "MS Word (DOC)"
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.doc")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/doc"
                '--------------------------------------------------------------------

                '--------------------------------------------------------------------
            Case "MS Excel (XLS)"

                Try
                    oStream = CType(DSS1.ExportToStream(CrystalDecisions.[Shared].ExportFormatType.Excel), System.IO.MemoryStream)

                Catch err As Exception

                    Response.Write(err.Message.ToString)
                End Try
                Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"

                Dim outstream As System.IO.MemoryStream
                Dim strFileName As String

                strFileName = "Report_" & Now.ToString("MM-dd-yy") & " " & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString & Now.Millisecond.ToString
                strFileName = strFileName & ".xls"

                outstream = CType(DSS1.ExportToStream(CrystalDecisions.[Shared].ExportFormatType.Excel), System.IO.MemoryStream)
                Response.ClearHeaders()
                Response.Buffer = False
                Response.ContentType = "application/vnd.ms-excel"
                Response.AddHeader("Content-Disposition", "attachment; filename=" & strFileName)
                Response.BinaryWrite(outstream.ToArray)
                Response.End()
        End Select 'export format
        Try
            Response.BinaryWrite(oStream.ToArray())
            Response.End()
        Catch err As Exception
            Response.Write("<BR>")
            Response.Write(err.Message.ToString)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label2.Visible = True
        Button9.Visible = False
        Button10.Visible = True
        DropDownList1.Visible = True

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button4.Visible = False
        Button5.Visible = False
        LstCom.Visible = True
        TxtFdt.Visible = True
        TxtTdt.Visible = True
        btt1.Visible = False
        BTT2.Visible = False
        aa.Visible = True
        BB.Visible = True
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        ImageButton2.Visible = False


    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click

        If TxtFlg.Text = "1" Then
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            LstCom.Visible = False
            TxtFdt.Visible = False
            TxtTdt.Visible = False
            btt1.Visible = False
            BTT2.Visible = False
            aa.Visible = False
            BB.Visible = False
            Button8.Visible = False
            Label2.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            DropDownList1.Visible = False

            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            '  CrystalReportViewer2.Visible = True


            Dim DSS As Submitclaims = New Submitclaims
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            '  CrystalReportViewer2.Visible = True


            com11 = Mid(LstCom.SelectedValue, 1, 3)

            Try

                com11 = Mid(LstCom.SelectedValue, 1, 3)
                'OBJ1.ConnectDBH()
                CrystalReportViewer2.Visible = False
                DSS.SetDatabaseLogon("sa", "tstc123")
                DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                DSS.SetParameterValue("Com", "" & com11 & "")
                DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                CrystalReportViewer2.ReportSource = DSS
                CrystalReportViewer2.DataBind()

            Catch ex As Exception
                Response.Write(ex.Message)
                Response.End()
            End Try


            TxtFlg.Text = "0"


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
            ImageButton2.Visible = False
            ImageButton1.Visible = False

        Else
            If TxtFlg.Text = "2" Then
                Button1.Visible = False
                Button2.Visible = False
                Button3.Visible = False
                Button6.Visible = False
                Button7.Visible = False
                Button4.Visible = False
                Button5.Visible = False
                LstCom.Visible = False
                TxtFdt.Visible = False
                TxtTdt.Visible = False
                btt1.Visible = False
                BTT2.Visible = False
                aa.Visible = False
                BB.Visible = False
                Button8.Visible = False
                Label2.Visible = False
                Button9.Visible = False
                Button10.Visible = False
                DropDownList1.Visible = False

                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                'Page.RegisterStartupScript("OpenWindow", strJS)


                '  CrystalReportViewer2.Visible = True


                Dim DSS1 As BBB = New BBB
                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                'Page.RegisterStartupScript("OpenWindow", strJS)


                '  CrystalReportViewer2.Visible = True


                com11 = Mid(LstCom.SelectedValue, 1, 3)

                Try

                    com11 = Mid(LstCom.SelectedValue, 1, 3)
                    'OBJ1.ConnectDBH()
                    CrystalReportViewer2.Visible = False
                    DSS1.SetDatabaseLogon("sa", "tstc123")
                    DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                    DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                    DSS1.SetParameterValue("Com", "" & com11 & "")
                    DSS1.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                    DSS1.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                    CrystalReportViewer2.ReportSource = DSS1
                    CrystalReportViewer2.DataBind()

                Catch ex As Exception
                    Response.Write(ex.Message)
                    Response.End()
                End Try


                TxtFlg.Text = "0"


                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
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
                ImageButton2.Visible = False
                ImageButton1.Visible = False


                '-------------
              
                '-------------














            Else

                If TxtFlg.Text = "3" Then
                    Button1.Visible = False
                    Button2.Visible = False
                    Button3.Visible = False
                    Button6.Visible = False
                    Button7.Visible = False
                    Button4.Visible = False
                    Button5.Visible = False
                    LstCom.Visible = False
                    TxtFdt.Visible = False
                    TxtTdt.Visible = False
                    btt1.Visible = False
                    BTT2.Visible = False
                    aa.Visible = False
                    BB.Visible = False
                    Button8.Visible = False
                    Label2.Visible = False
                    Button9.Visible = False
                    Button10.Visible = False
                    DropDownList1.Visible = False

                    'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                    'Page.RegisterStartupScript("OpenWindow", strJS)


                    '  CrystalReportViewer2.Visible = True


                    Dim DSS2 As CCC = New CCC
                    'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                    'Page.RegisterStartupScript("OpenWindow", strJS)


                    '  CrystalReportViewer2.Visible = True


                    com11 = Mid(LstCom.SelectedValue, 1, 3)

                    Try

                        com11 = Mid(LstCom.SelectedValue, 1, 3)
                        'OBJ1.ConnectDBH()
                        CrystalReportViewer2.Visible = False
                        DSS2.SetDatabaseLogon("sa", "tstc123")
                        DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                        DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                        DSS2.SetParameterValue("Com", "" & com11 & "")
                        DSS2.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        DSS2.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                        CrystalReportViewer2.ReportSource = DSS2
                        CrystalReportViewer2.DataBind()

                    Catch ex As Exception
                        Response.Write(ex.Message)
                        Response.End()
                    End Try


                    TxtFlg.Text = "0"


                    oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
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
                    ImageButton2.Visible = False
                    ImageButton1.Visible = False
                Else
                    If TxtFlg.Text = "4" Then
                        Button1.Visible = False
                        Button2.Visible = False
                        Button3.Visible = False
                        Button6.Visible = False
                        Button7.Visible = False
                        Button4.Visible = False
                        Button5.Visible = False
                        LstCom.Visible = False
                        TxtFdt.Visible = False
                        TxtTdt.Visible = False
                        btt1.Visible = False
                        BTT2.Visible = False
                        aa.Visible = False
                        BB.Visible = False
                        Button8.Visible = False
                        Label2.Visible = False
                        Button9.Visible = False
                        Button10.Visible = False
                        DropDownList1.Visible = False

                        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                        'Page.RegisterStartupScript("OpenWindow", strJS)


                        '  CrystalReportViewer2.Visible = True


                        com11 = Mid(LstCom.SelectedValue, 1, 3)

                        Dim DSS2 As AAA = New AAA
                        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                        'Page.RegisterStartupScript("OpenWindow", strJS)


                        '  CrystalReportViewer2.Visible = True


                        com11 = Mid(LstCom.SelectedValue, 1, 3)

                        Try

                            com11 = Mid(LstCom.SelectedValue, 1, 3)
                            'OBJ1.ConnectDBH()
                            CrystalReportViewer2.Visible = False
                            DSS2.SetDatabaseLogon("sa", "tstc123")
                            DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                            DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                            DSS2.SetParameterValue("Com", "" & com11 & "")
                            DSS2.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                            DSS2.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                            CrystalReportViewer2.ReportSource = DSS2
                            CrystalReportViewer2.DataBind()

                        Catch ex As Exception
                            Response.Write(ex.Message)
                            Response.End()
                        End Try


                        TxtFlg.Text = "0"


                        oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
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
                        ImageButton2.Visible = False
                        ImageButton1.Visible = False
                    Else
                        If TxtFlg.Text = "5" Then
                            Button1.Visible = False
                            Button2.Visible = False
                            Button3.Visible = False
                            Button6.Visible = False
                            Button7.Visible = False
                            Button4.Visible = False
                            Button5.Visible = False
                            LstCom.Visible = False
                            TxtFdt.Visible = False
                            TxtTdt.Visible = False
                            btt1.Visible = False
                            BTT2.Visible = False
                            aa.Visible = False
                            BB.Visible = False
                            Button8.Visible = False
                            Label2.Visible = False
                            Button9.Visible = False
                            Button10.Visible = False
                            DropDownList1.Visible = False

                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)


                            '  CrystalReportViewer2.Visible = True



                            Dim DSS2 As PendingList = New PendingList
                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)


                            '  CrystalReportViewer2.Visible = True


                            com11 = Mid(LstCom.SelectedValue, 1, 3)

                            Try

                                com11 = Mid(LstCom.SelectedValue, 1, 3)
                                'OBJ1.ConnectDBH()
                                CrystalReportViewer2.Visible = False
                                DSS2.SetDatabaseLogon("sa", "tstc123")
                                DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                                DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                                DSS2.SetParameterValue("Com", "" & com11 & "")
                                DSS2.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                DSS2.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                                CrystalReportViewer2.ReportSource = DSS2
                                CrystalReportViewer2.DataBind()

                            Catch ex As Exception
                                Response.Write(ex.Message)
                                Response.End()
                            End Try


                            TxtFlg.Text = "0"


                            oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
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
                            ImageButton2.Visible = False
                            ImageButton1.Visible = False
                        Else
                            If TxtFlg.Text = "6" Then
                                Button1.Visible = False
                                Button2.Visible = False
                                Button3.Visible = False
                                Button6.Visible = False
                                Button7.Visible = False
                                Button4.Visible = False
                                Button5.Visible = False
                                LstCom.Visible = False
                                TxtFdt.Visible = False
                                TxtTdt.Visible = False
                                btt1.Visible = False
                                BTT2.Visible = False
                                aa.Visible = False
                                BB.Visible = False
                                Button8.Visible = False
                                Label2.Visible = False
                                Button9.Visible = False
                                Button10.Visible = False
                                DropDownList1.Visible = False



                                Dim DSS As RecClaims = New RecClaims
                                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                'Page.RegisterStartupScript("OpenWindow", strJS)


                                '  CrystalReportViewer2.Visible = True


                                com11 = Mid(LstCom.SelectedValue, 1, 3)

                                Try

                                    com11 = Mid(LstCom.SelectedValue, 1, 3)
                                    'OBJ1.ConnectDBH()
                                    CrystalReportViewer2.Visible = False
                                    DSS.SetDatabaseLogon("sa", "tstc123")
                                    DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
                                    DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                                    DSS.SetParameterValue("Com", "" & com11 & "")
                                    DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                    DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
                                    DSS.SetParameterValue("AccYr", "" & Trim(TxtAccYr.Text) & "")

                                    CrystalReportViewer2.ReportSource = DSS
                                    CrystalReportViewer2.DataBind()

                                Catch ex As Exception
                                    Response.Write(ex.Message)
                                    Response.End()
                                End Try


                                TxtFlg.Text = "0"


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
                                ImageButton2.Visible = False
                                ImageButton1.Visible = False
                            End If
                        End If


                    End If
                End If
            End If
        End If
    End Sub
End Class
