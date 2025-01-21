Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class HealthReport4
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

    Dim Dtr, Dtr1, dtr2 As DataRow
    Dim com11 As String
    Dim drt2, drt3, drt1, drt4, drt5 As DataRow
    Dim Typ, PSEC, PFLAG, TT, ss, ss1, ss2, ss3 As String
    Dim Count, COUNT2, COUNT1, TOT1, TOT2, TOT3, TOT4, TOT5, TOT6, TOT7 As Integer
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
    Protected WithEvents Button11 As System.Web.UI.WebControls.Button
    Protected WithEvents Imagebutton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Button12 As System.Web.UI.WebControls.Button
    Protected WithEvents QWQW As System.Web.UI.WebControls.Label
    Protected WithEvents Button13 As System.Web.UI.WebControls.Button
    Protected WithEvents Button14 As System.Web.UI.WebControls.Button
    Protected WithEvents Button15 As System.Web.UI.WebControls.Button
    Protected WithEvents Imagebutton4 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar3 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Imgbtt5 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtRdt As System.Web.UI.WebControls.TextBox
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
            Button9.Visible = False
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


            Dim DSS As DDDnew = New DDDnew


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
            'DSS.SetParameterValue("Com", "" & com11 & "")
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


                Dim DSS As BBBnew = New BBBnew
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
                'DSS.SetParameterValue("Com", "" & com11 & "")
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
                    Dim DSS As CCCnew = New CCCnew
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
                    'DSS.SetParameterValue("Com", "" & com11 & "")
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
                        Dim DSS As AAAnew = New AAAnew
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
                        ' DSS.SetParameterValue("Com", "" & com11 & "")
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
                            Dim DSS As Summery1 = New Summery1
                            Button1.Visible = False
                            Button2.Visible = False
                            Button3.Visible = False
                            Button11.Visible = False
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
                            TxtFlg.Text = "5"
                            ImageButton1.Visible = True
                            Label2.Visible = False
                            Button9.Visible = False
                            Button10.Visible = False
                            DropDownList1.Visible = False
                            ImageButton2.Visible = True
                            Button12.Visible = False
                            Button13.Visible = False
                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)


                            Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
                            Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrOldepfno As String
                            CON.Open()
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
                            LstCom.Visible = False
                            Button4.Visible = False
                            Button3.Visible = False
                            Button5.Visible = False

                            Button2.Visible = False

                            'Label1.Visible = False
                            Label2.Visible = False

                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)

                            CrystalReportViewer2.Visible = True



                            com11 = Mid(LstCom.SelectedValue, 1, 3)



                            DSS.SetDatabaseLogon("sa", "tstc123")
                            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                            ' DSS.SetParameterValue("Com", "" & com11 & "")
                            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                            DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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

                                Dim DSS As Summery4 = New Summery4
                                Button1.Visible = False
                                Button2.Visible = False
                                Button3.Visible = False
                                Button11.Visible = False
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
                                TxtFlg.Text = "6"
                                ImageButton1.Visible = True
                                Label2.Visible = False
                                Button9.Visible = False
                                Button10.Visible = False
                                DropDownList1.Visible = False
                                ImageButton2.Visible = True
                                Button12.Visible = False
                                Button13.Visible = False
                                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                'Page.RegisterStartupScript("OpenWindow", strJS)


                                CrystalReportViewer2.Visible = True
                                com11 = Mid(LstCom.SelectedValue, 1, 3)

                                DSS.SetDatabaseLogon("sa", "tstc123")
                                DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                                DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                                If TxtFlg.Text = "7" Then

                                    Dim DSS As Summery5 = New Summery5
                                    Button1.Visible = False
                                    Button2.Visible = False
                                    Button3.Visible = False
                                    Button11.Visible = False
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
                                    TxtFlg.Text = "6"
                                    ImageButton1.Visible = True
                                    Label2.Visible = False
                                    Button9.Visible = False
                                    Button10.Visible = False
                                    DropDownList1.Visible = False
                                    ImageButton2.Visible = True
                                    Button12.Visible = False
                                    Button13.Visible = False
                                    'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                    'Page.RegisterStartupScript("OpenWindow", strJS)


                                    CrystalReportViewer2.Visible = True
                                    com11 = Mid(LstCom.SelectedValue, 1, 3)

                                    DSS.SetDatabaseLogon("sa", "tstc123")
                                    DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                    DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                                    DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                                    If TxtFlg.Text = "8" Then

                                        Dim DSS As Summery6 = New Summery6
                                        Button1.Visible = False
                                        Button2.Visible = False
                                        Button3.Visible = False
                                        Button11.Visible = False
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
                                        TxtFlg.Text = "6"
                                        ImageButton1.Visible = True
                                        Label2.Visible = False
                                        Button9.Visible = False
                                        Button10.Visible = False
                                        DropDownList1.Visible = False
                                        ImageButton2.Visible = True
                                        Button12.Visible = False
                                        Button13.Visible = False
                                        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                        'Page.RegisterStartupScript("OpenWindow", strJS)


                                        CrystalReportViewer2.Visible = True
                                        com11 = Mid(LstCom.SelectedValue, 1, 3)

                                        DSS.SetDatabaseLogon("sa", "tstc123")
                                        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                                        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
            End If
        End If
    End Sub

    Private Sub BTT2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BTT2.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DSS As BBBnew = New BBBnew
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
        Button11.Visible = False
        TxtFlg.Text = "2"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        Button12.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)
        Button12.Visible = False

        CrystalReportViewer2.Visible = True
        Button15.Visible = False


        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")
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
        Dim DSS As CCCnew = New CCCnew
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
        Button11.Visible = False
        TxtFlg.Text = "3"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        Button12.Visible = False
        Button12.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False

        CrystalReportViewer2.Visible = True

        Button15.Visible = False

        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Com", "" & com11 & "")
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
        Dim DSS As AAAnew = New AAAnew
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
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
        Button12.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)

        Button12.Visible = False
        CrystalReportViewer2.Visible = True
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False

        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")
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
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                'Response.ContentType = "application/vnd.text"
                '--------------------------------------------------------------------
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
            Button13.Visible = False
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
            'Page.RegisterStartupScript("OpenWindow", strJS)


            '  CrystalReportViewer2.Visible = True


            Dim DSS As DDDnew = New DDDnew
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
                ' DSS.SetParameterValue("Com", "" & com11 & "")
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


                Dim DSS1 As BBBnew = New BBBnew
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
                    'DSS1.SetParameterValue("Com", "" & com11 & "")
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


                    Dim DSS2 As CCCnew = New CCCnew
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
                        ' DSS2.SetParameterValue("Com", "" & com11 & "")
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

                        Dim DSS2 As AAAnew = New AAAnew
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
                            ' DSS2.SetParameterValue("Com", "" & com11 & "")
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
                            Dim DSS As Summery1 = New Summery1
                            Button1.Visible = False
                            Button2.Visible = False
                            Button3.Visible = False
                            Button11.Visible = False
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
                            TxtFlg.Text = "5"
                            ImageButton1.Visible = True
                            Label2.Visible = False
                            Button9.Visible = False
                            Button10.Visible = False
                            DropDownList1.Visible = False
                            ImageButton2.Visible = True
                            Button12.Visible = False
                            Button13.Visible = False
                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)


                            Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
                            Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrOldepfno As String
                            CON.Open()
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
                            LstCom.Visible = False
                            Button4.Visible = False
                            Button3.Visible = False
                            Button5.Visible = False

                            Button2.Visible = False

                            'Label1.Visible = False
                            Label2.Visible = False

                            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                            'Page.RegisterStartupScript("OpenWindow", strJS)

                            CrystalReportViewer2.Visible = True



                            com11 = Mid(LstCom.SelectedValue, 1, 3)



                            DSS.SetDatabaseLogon("sa", "tstc123")
                            'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                            ' DSS.SetParameterValue("Com", "" & com11 & "")
                            DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                            DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                            DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                            ImageButton2.Visible = False
                            ImageButton1.Visible = False



                            TxtFlg.Text = "0"
                            ImageButton1.Visible = False
                        Else
                            If TxtFlg.Text = "6" Then

                                Dim DSS As Summery4 = New Summery4
                                Button1.Visible = False
                                Button2.Visible = False
                                Button3.Visible = False
                                Button11.Visible = False
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
                                TxtFlg.Text = "6"
                                ImageButton1.Visible = True
                                Label2.Visible = False
                                Button9.Visible = False
                                Button10.Visible = False
                                DropDownList1.Visible = False
                                ImageButton2.Visible = True
                                Button12.Visible = False
                                Button13.Visible = False
                                'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                'Page.RegisterStartupScript("OpenWindow", strJS)


                                CrystalReportViewer2.Visible = True
                                com11 = Mid(LstCom.SelectedValue, 1, 3)

                                DSS.SetDatabaseLogon("sa", "tstc123")
                                DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                                DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                                ImageButton2.Visible = False
                                ImageButton1.Visible = False


                                TxtFlg.Text = "0"
                                ImageButton1.Visible = False
                            Else
                                If TxtFlg.Text = "7" Then

                                    Dim DSS As Summery5 = New Summery5
                                    Button1.Visible = False
                                    Button2.Visible = False
                                    Button3.Visible = False
                                    Button11.Visible = False
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
                                    TxtFlg.Text = "6"
                                    ImageButton1.Visible = True
                                    Label2.Visible = False
                                    Button9.Visible = False
                                    Button10.Visible = False
                                    DropDownList1.Visible = False
                                    ImageButton2.Visible = True
                                    Button12.Visible = False
                                    Button13.Visible = False
                                    'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                    'Page.RegisterStartupScript("OpenWindow", strJS)


                                    CrystalReportViewer2.Visible = True
                                    com11 = Mid(LstCom.SelectedValue, 1, 3)

                                    DSS.SetDatabaseLogon("sa", "tstc123")
                                    DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                    DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                                    DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                                    ImageButton2.Visible = False
                                    ImageButton1.Visible = False

                                    TxtFlg.Text = "0"
                                    ImageButton1.Visible = False
                                Else
                                    If TxtFlg.Text = "8" Then

                                        Dim DSS As Summery6 = New Summery6
                                        Button1.Visible = False
                                        Button2.Visible = False
                                        Button3.Visible = False
                                        Button11.Visible = False
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
                                        TxtFlg.Text = "6"
                                        ImageButton1.Visible = True
                                        Label2.Visible = False
                                        Button9.Visible = False
                                        Button10.Visible = False
                                        DropDownList1.Visible = False
                                        ImageButton2.Visible = True
                                        Button12.Visible = False
                                        Button13.Visible = False
                                        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
                                        'Page.RegisterStartupScript("OpenWindow", strJS)


                                        CrystalReportViewer2.Visible = True
                                        com11 = Mid(LstCom.SelectedValue, 1, 3)

                                        DSS.SetDatabaseLogon("sa", "tstc123")
                                        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                                        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
                                        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
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
                                        ImageButton2.Visible = False
                                        ImageButton1.Visible = False


                                        TxtFlg.Text = "0"
                                        ImageButton1.Visible = False

                                    End If


                                End If
                            End If
                        End If
                    End If


                End If
            End If
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim DSS As DDDnew = New DDDnew
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
        Button11.Visible = False
        TxtFlg.Text = "1"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)
        Button12.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        CrystalReportViewer2.Visible = True
        Button13.Visible = False
        Button15.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")
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

    Private Sub Imagebutton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click
        'Dim DSS As claims = New claims
        Dim EmailMessage1 As MailMessage
        EmailMessage1 = New MailMessage
        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrOldepfno, StrEmpAct, StrEmpIdno As String
        CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS1"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Dim DeleteCmd1 As String = "DELETE from MAS2"
        Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        Cmd1.ExecuteNonQuery()

        Dim DeleteCmd3 As String = "DELETE from MAS3"
        Dim Cmd2 As New SqlCommand(DeleteCmd1, CON)
        Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False

        Button13.Visible = False

        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM HthMaster order by com,epfno", CON)

        DS = New DataSet
        ADA.Fill(DS, "HthMaster")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0
        Strcom = "AAA"

        For Each Dtr1 In DS.Tables("HthMaster").Rows
            'Strcom = Dtr1("com")
            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("com"))
                TT = Trim(Dtr1("EPFnO"))
            End If

            If Strcom = Dtr1("com") Then

                StrEpfno = Dtr1("epfno")
                StrEname = Dtr1("EmployeeName")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = Dtr1("EmpIdNo")
                StrOldepfno = Dtr1("OldEpfNo")

                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
                ''''''

                '''''''''
                If DateValue(StrEdate) < Trim(ss) And Trim(StrEmpAct) = "Y" Then

                    TOT1 = TOT1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        If Trim(StrEpfno) = Trim(StrOldepfno) Or Trim(StrOldepfno) = "0" Then

                            TOT2 = TOT2 + 1
                            Try
                                Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                                TT = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                                Cmd.ExecuteNonQuery()
                            Catch ex As Exception

                            End Try
                            '
                        Else
                            TOT1 = TOT1 + 1

                        End If
                        '


                    End If
                End If

                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    '   If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    TOT3 = TOT3 + 1
                    Try
                        '
                        Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                        TT = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()

                    Catch ex As Exception

                    End Try
                    '

                End If


            Else

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage

                emailMessage.From = "insurance@dsisamson.com"
                EmailMessage1.From = "insurance@dsisamson.com"
                emailMessage.Subject = Strcom + "Health Fund - New Employee  From " + TxtFdt.Text + " to " + TxtTdt.Text
                EmailMessage1.Subject = "Health Fund - New Employee  From " + TxtFdt.Text + " to " + TxtTdt.Text
                ADA = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & Strcom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "Company")

                COUNT2 = DS.Tables("Company").Rows.Count
                Dim SCNam, StEmail As String
                If COUNT2 <> 0 Then
                    For Each dtr2 In DS.Tables("Company").Rows

                        SCNam = dtr2("Com_Nam")
                        StEmail = Trim(dtr2("Com_TEmail"))
                    Next


                    emailMessage.To = Trim(dtr2("Com_TEmail"))

                    ' emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += "No of Previous Employees:" + "" + Str(TOT1 + TOT3) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "New Employee :" & vbCrLf
                    emailMessage.Body += "Epf No  Name                   Date      " & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    ADA = New SqlDataAdapter("Select com,epfno,empnam,empidno,ent_date from Mas1 where Com='" & Strcom & "'", CON)
                    DS = New DataSet
                    ADA.Fill(DS, "Mas1")

                    COUNT2 = DS.Tables("Mas1").Rows.Count
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
                    emailMessage.Body += "No of New Employees:" + "" + Str(TOT2) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf


                    emailMessage.Body += "Left Employee :" & vbCrLf
                    emailMessage.Body += "Epf No  Name                   Left Date      " & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    ADA = New SqlDataAdapter("Select com,epfno,empnam,empidno,ent_date from Mas2 where Com='" & Strcom & "'", CON)
                    DS = New DataSet
                    ADA.Fill(DS, "Mas1")

                    COUNT2 = DS.Tables("Mas1").Rows.Count
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
                    emailMessage.Body += "No of Left Employees :" + "" + Str(TOT3) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    emailMessage.Body += "No of Total Employees:" + "" + Str(TOT1 + TOT2) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    EmailMessage1.Body += emailMessage.Body & vbCrLf


                    emailMessage.Body += "Created By:" + Trim(L1.Text) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    ' emailMessage.To = "palithan@samsoncorporates.com,chamindas@samsoncorporates.com,shakilaw@samsoncorporates.com"
                    'emailMessage.To = "palithan@samsoncorporates.com"
                    emailMessage.To = Trim(StEmail)


                    SmtpMail.SmtpServer = "mail.dsisamson.com"
                    Try
                        SmtpMail.Send(emailMessage)

                    Catch ex As Exception

                    End Try

                End If




                Try
                    Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')")
                    TT = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')"
                    Cmd.ExecuteNonQuery()


                Catch ex As Exception

                End Try

                Strcom = Dtr1("com")
                Count = 0
                TOT1 = 0
                TOT2 = 0
                TOT3 = 0

                StrEpfno = Dtr1("epfno")
                StrEname = Dtr1("EmployeeName")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = Dtr1("EmpIdNo")
                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
                ''''''
                StrOldepfno = Dtr1("OldEpfNo")
                '''''''''
                If DateValue(StrEdate) < Trim(ss) And Trim(StrEmpAct) = "Y" Then

                    TOT1 = TOT1 + 1

                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                        If Trim(StrEpfno) = Trim(StrOldepfno) Or Trim(StrOldepfno) = "0" Then

                            TOT2 = TOT2 + 1
                            Try
                                Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                                TT = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                                Cmd.ExecuteNonQuery()
                            Catch ex As Exception

                            End Try
                            '
                        Else
                            TOT1 = TOT1 + 1

                        End If
                        '


                    End If
                End If

                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    '   If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    TOT3 = TOT3 + 1
                    Try
                        '
                        Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                        TT = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try
                    '


                End If
            End If

        Next

        Try
            Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')")
            TT = "INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')"
            Cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        '

        EmailMessage1.To = "palithan@samsoncorporates.com,shakilaw@samsoncorporates.com,chamindas@samsoncorporates.com"


        SmtpMail.SmtpServer = "mail.dsisamson.com"
        Try
            SmtpMail.Send(EmailMessage1)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim DSS As Summery1 = New Summery1
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
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
        TxtFlg.Text = "5"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        Button12.Visible = False
        Button13.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False

        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrOldepfno As String
        CON.Open()
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
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False



        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE COM<>'' order by com,epfno", CON)

        DS = New DataSet
        ADA.Fill(DS, "HthMaster")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0
        Strcom = "AAA"
        Dim ANS As String
        ANS = "Y"
        TOT4 = 0
        TOT5 = 0
        TOT6 = 0

        For Each Dtr1 In DS.Tables("HthMaster").Rows
            'Strcom = Dtr1("com")
            If ANS = "Y" Then
                Strcom = Trim(Dtr1("com"))
                TT = Trim(Dtr1("EPFnO"))
                ANS = "N"
            End If

            If Strcom = Dtr1("com") Then

                StrEpfno = Dtr1("epfno")
                StrEname = Dtr1("EmployeeName")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = Dtr1("EmpIdNo")
                StrOldepfno = Dtr1("OldEpfNo")


                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
                '''''''
                If DateValue(StrEdate) <= Trim(ss1) Then

                    If Trim(StrEmpAct) = "Y" Then
                        TOT4 = TOT4 + 1
                    Else
                        If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                            TOT3 = TOT3 + 1
                        End If
                    End If
                End If
                If DateValue(StrEdate) > Trim(ss1) Then

                    If Trim(StrEmpAct) = "Y" Then
                        '  TOT4 = TOT4 + 1
                    Else
                        If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                            TOT7 = TOT7 + 1
                        End If
                    End If
                End If

                If DateValue(StrEdate) < Trim(ss) Then
                    If Trim(StrEmpAct) = "Y" Then
                        TOT1 = TOT1 + 1
                    Else
                        If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                            TOT6 = TOT6 + 1
                        End If
                    End If

                End If

                If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                    If Trim(StrEpfno) = Trim(StrOldepfno) Or Trim(StrOldepfno) = "0" Then

                        TOT2 = TOT2 + 1
                        Try
                            Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                            TT = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                            Cmd.ExecuteNonQuery()
                        Catch ex As Exception

                        End Try
                        '
                    Else
                        TOT5 = TOT5 + 1

                    End If
                End If
                ' End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    '   If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    ' TOT3 = TOT3 + 1
                    Try
                        '
                        Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                        TT = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()

                    Catch ex As Exception

                    End Try
                    '

                End If
                'End If




            Else

                Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,TOT4,TOT5,TOT6,TOT7,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & "," & TOT4 & "," & TOT5 & "," & TOT6 & "," & TOT7 & ",'" & Trim(L1.Text) & "')")
                TT = "INSERT INTO Mas3 (com,tot1,tot2,tot3,TOT4,TOT5,TOT6,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & "," & TOT4 & "," & TOT5 & ")"
                Cmd.ExecuteNonQuery()

                Strcom = Dtr1("com")
                Count = 0
                TOT1 = 0
                TOT2 = 0
                TOT3 = 0
                TOT4 = 0
                TOT5 = 0
                TOT6 = 0
                TOT7 = 0
                StrEpfno = Dtr1("epfno")
                StrEname = Dtr1("EmployeeName")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = Dtr1("EmpIdNo")
                StrOldepfno = Dtr1("OldEpfNo")


                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
                ''''''

                '''''''''
                If DateValue(StrEdate) <= Trim(ss1) Then

                    If Trim(StrEmpAct) = "Y" Then
                        TOT4 = TOT4 + 1
                    Else
                        If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                            TOT3 = TOT3 + 1
                        End If
                    End If
                End If
                If DateValue(StrEdate) > Trim(ss1) Then

                    If Trim(StrEmpAct) = "Y" Then
                        '  TOT4 = TOT4 + 1
                    Else
                        If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                            TOT7 = TOT7 + 1
                        End If
                    End If
                End If

                If DateValue(StrEdate) < Trim(ss) Then
                    If Trim(StrEmpAct) = "Y" Then
                        TOT1 = TOT1 + 1
                    Else
                        If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then
                            TOT6 = TOT6 + 1
                        End If
                    End If

                End If

                If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) And Trim(StrEmpAct) = "Y" Then

                    If Trim(StrEpfno) = Trim(StrOldepfno) Or Trim(StrOldepfno) = "0" Then

                        TOT2 = TOT2 + 1
                        Try
                            Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                            TT = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                            Cmd.ExecuteNonQuery()
                        Catch ex As Exception

                        End Try
                        '
                    Else
                        TOT5 = TOT5 + 1

                    End If
                End If
                ' End If
                If Trim(StrEmpAct) = "N" And DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    '   If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                    ' TOT3 = TOT3 + 1
                    Try
                        '
                        Cmd.CommandText = ("INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "')")
                        TT = "INSERT INTO Mas2 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrAdate & "','" & Trim(L1.Text) & "')"
                        Cmd.ExecuteNonQuery()

                    Catch ex As Exception

                    End Try
                    '

                End If


            End If

        Next
        'Try
        Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,TOT4,TOT5,TOT6,TOT7,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & "," & TOT4 & "," & TOT5 & "," & TOT6 & "," & TOT7 & ",'" & Trim(L1.Text) & "')")
        TT = "INSERT INTO Mas3 (com,tot1,tot2,tot3,TOT4,TOT5,TOT6,TOT7,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')"
        Cmd.ExecuteNonQuery()

        CrystalReportViewer2.Visible = True

        com11 = Mid(LstCom.SelectedValue, 1, 3)

        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        ' DSS.SetParameterValue("Com", "" & com11 & "")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim DSS As Summery4 = New Summery4
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
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
        TxtFlg.Text = "6"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrOldepfno As String
        CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS4"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        'Dim DeleteCmd1 As String = "DELETE from MAS2"
        'Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        'Cmd1.ExecuteNonQuery()

        'Dim DeleteCmd3 As String = "DELETE from MAS3"
        'Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
        'Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False


        ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
        ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EmpAct='Y' and ENT_DATE <='" & ss1 & "') or (EmpAct='N' and act_datE>='" & ss & "' and act_datE<='" & ss1 & "')  order by com,epfno", CON)

        'ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EmpAct='Y' order by com,epfno", CON)

        DS = New DataSet
        ADA.Fill(DS, "HthMaster")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0
        Strcom = "AAA"



        For Each Dtr1 In DS.Tables("HthMaster").Rows
            'Strcom = Dtr1("com")

            ' If Strcom = Dtr1("com") Then
            Strcom = Trim(Dtr1("com"))
            StrEpfno = Dtr1("epfno")
            StrEname = Dtr1("EmployeeName")
            ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
            'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
            StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
            ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
            StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
            StrEmpAct = Dtr1("EmpAct")
            StrEmpIdno = Dtr1("EmpIdNo")
            StrOldepfno = Dtr1("OldEpfNo")


            ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
            ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
            ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
            ''''''

            ADA = New SqlDataAdapter("SELECT *  FROM Hltmaster1 where (Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' and  Emp_RecDt >='" & ss & "' And Emp_RecDt <='" & ss1 & "'", CON)

            DS = New DataSet
            ADA.Fill(DS)
            Count = DS.Tables(0).Rows.Count

            '''''''''

            If Count = 0 Then
                'Try
                'Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')")
                If Trim(Strcom) <> "" Then
                    If Trim(StrEmpAct) = "Y" Then
                        TOT1 = TOT1 + 1
                    Else
                        TOT2 = TOT2 + 1
                    End If



                    TT = "INSERT INTO Mas4 (Com,EmpNo,EmpNam,UserCode,Act) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & Trim(L1.Text) & "','" & Trim(StrEmpAct) & "')"
                    Cmd.CommandText = (TT)
                    Cmd.ExecuteNonQuery()

                End If
                ' Catch ex As Exception

                ' End Try
            End If


            ' End If
        Next


        Strcom = Dtr1("com")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0


        StrEpfno = Dtr1("epfno")
        StrEname = Dtr1("EmployeeName")
        ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
        'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
        StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
        ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
        StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
        StrEmpAct = Dtr1("EmpAct")
        StrEmpIdno = Dtr1("EmpIdNo")
        StrOldepfno = Dtr1("OldEpfNo")


        ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
        ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
        ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
        ''''''
        ADA = New SqlDataAdapter("SELECT *  FROM Hltmaster1 where (Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' and  Emp_RecDt >='" & ss & "' And Emp_RecDt <='" & ss1 & "'", CON)
        ss = "SELECT *  FROM Hltmaster1 where Emp_no=" & Trim(StrEpfno) & " and Emp_Com='" & Trim(Strcom) & "' and  Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'"
        DS = New DataSet
        ADA.Fill(DS)
        Count = DS.Tables(0).Rows.Count

        '''''''''

        If Count = 0 Then
            If Trim(Strcom) <> "" Then
                If Trim(StrEmpAct) = "Y" Then
                    TOT1 = TOT1 + 1
                Else
                    TOT2 = TOT2 + 1
                End If



                TT = "INSERT INTO Mas4 (Com,EmpNo,EmpNam,UserCode,Act) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & Trim(L1.Text) & "','" & Trim(StrEmpAct) & "')"
                Cmd.CommandText = (TT)
                Cmd.ExecuteNonQuery()

            End If
        End If


        CrystalReportViewer2.Visible = True
        com11 = Mid(LstCom.SelectedValue, 1, 3)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim DSS As Summery5 = New Summery5
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
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
        TxtFlg.Text = "7"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrOldepfno As String
        CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS4"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        'Dim DeleteCmd1 As String = "DELETE from MAS2"
        'Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        'Cmd1.ExecuteNonQuery()

        'Dim DeleteCmd3 As String = "DELETE from MAS3"
        'Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
        'Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False


        ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
        ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EmpAct='Y' and ENT_DATE <='" & ss1 & "') or (EmpAct='N' and act_datE>='" & ss & "' and act_datE<='" & ss1 & "')  order by com,epfno", CON)
        'ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EmpAct='Y' order by com,epfno", CON)

        DS = New DataSet
        ADA.Fill(DS, "HthMaster")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0
        Strcom = "AAA"



        For Each Dtr1 In DS.Tables("HthMaster").Rows
            'Strcom = Dtr1("com")
            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("com"))
                TT = Trim(Dtr1("EPFnO"))
            End If

            ' If Strcom = Dtr1("com") Then
            Strcom = Trim(Dtr1("com"))
            StrEpfno = Dtr1("epfno")
            StrEname = Dtr1("EmployeeName")
            ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
            'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
            StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
            ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
            StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
            StrEmpAct = Dtr1("EmpAct")
            StrEmpIdno = Dtr1("EmpIdNo")
            StrOldepfno = Dtr1("OldEpfNo")


            ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
            ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
            ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
            ''''''

            ADA = New SqlDataAdapter("SELECT *  FROM Hltmaster1 where (Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' AND Emp_Typ='Outdoor' and Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'", CON)
            ' ss = "SELECT *  FROM Hltmaster1 where Emp_no=" & Trim(StrEpfno) & " and Emp_Com='" & Trim(Strcom) & "' & Emp_Typ='Outdoor' and " & Trim(Strcom) and  Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'"
            DS = New DataSet
            ADA.Fill(DS)
            Count = DS.Tables(0).Rows.Count

            '''''''''

            If Count = 0 Then
                'Try
                'Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')")
                If Trim(Strcom) <> "" Then
                    If Trim(StrEmpAct) = "Y" Then
                        TOT1 = TOT1 + 1
                    Else
                        TOT2 = TOT2 + 1
                    End If



                    TT = "INSERT INTO Mas4 (Com,EmpNo,EmpNam,UserCode,Act) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & Trim(L1.Text) & "','" & Trim(StrEmpAct) & "')"
                    Cmd.CommandText = (TT)
                    Cmd.ExecuteNonQuery()

                End If
                ' Catch ex As Exception

                ' End Try
            End If


            ' End If
        Next


        Strcom = Dtr1("com")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0


        StrEpfno = Dtr1("epfno")
        StrEname = Dtr1("EmployeeName")
        ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
        'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
        StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
        ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
        StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
        StrEmpAct = Dtr1("EmpAct")
        StrEmpIdno = Dtr1("EmpIdNo")
        StrOldepfno = Dtr1("OldEpfNo")


        ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
        ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
        ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
        ''''''
        ADA = New SqlDataAdapter("SELECT *  FROM Hltmaster1 where (Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' AND Emp_Typ='Outdoor' and Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'", CON)
        ss = "SELECT *  FROM Hltmaster1 where E(Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' and  Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'"
        DS = New DataSet
        ADA.Fill(DS)
        Count = DS.Tables(0).Rows.Count

        '''''''''

        If Count = 0 Then
            If Trim(Strcom) <> "" Then
                If Trim(StrEmpAct) = "Y" Then
                    TOT1 = TOT1 + 1
                Else
                    TOT2 = TOT2 + 1
                End If



                TT = "INSERT INTO Mas4 (Com,EmpNo,EmpNam,UserCode,Act) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & Trim(L1.Text) & "','" & Trim(StrEmpAct) & "')"
                Cmd.CommandText = (TT)
                Cmd.ExecuteNonQuery()

            End If
        End If


        CrystalReportViewer2.Visible = True
        com11 = Mid(LstCom.SelectedValue, 1, 3)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim DSS As Summery6 = New Summery6
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
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
        TxtFlg.Text = "8"
        ImageButton1.Visible = True
        Label2.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        DropDownList1.Visible = False
        ImageButton2.Visible = True
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrEmpAct, StrEmpIdno, StrOldepfno As String
        CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS4"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        'Dim DeleteCmd1 As String = "DELETE from MAS2"
        'Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        'Cmd1.ExecuteNonQuery()

        'Dim DeleteCmd3 As String = "DELETE from MAS3"
        'Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
        'Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False


        ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
        ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EmpAct='Y' and ENT_DATE <='" & ss1 & "') or (EmpAct='N' and act_datE>='" & ss & "' and act_datE<='" & ss1 & "')  order by com,epfno", CON)

        'ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EmpAct='Y' order by com,epfno", CON)

        DS = New DataSet
        ADA.Fill(DS, "HthMaster")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0
        Strcom = "AAA"



        For Each Dtr1 In DS.Tables("HthMaster").Rows
            'Strcom = Dtr1("com")
            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("com"))
                TT = Trim(Dtr1("EPFnO"))
            End If

            ' If Strcom = Dtr1("com") Then
            Strcom = Trim(Dtr1("com"))
            StrEpfno = Dtr1("epfno")
            StrEname = Dtr1("EmployeeName")
            ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
            'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
            StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
            ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
            StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
            StrEmpAct = Dtr1("EmpAct")
            StrEmpIdno = Dtr1("EmpIdNo")
            StrOldepfno = Dtr1("OldEpfNo")


            ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
            ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
            ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
            ''''''

            ADA = New SqlDataAdapter("SELECT *  FROM Hltmaster1 where (Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' AND Emp_Typ='Indoor' and Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'", CON)
            ss = "SELECT *  FROM Hltmaster1 where Emp_no=" & Trim(StrEpfno) & " and Emp_Com='" & Trim(Strcom) & "' & Emp_Typ='Intdoor' and Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'"
            DS = New DataSet
            ADA.Fill(DS)
            Count = DS.Tables(0).Rows.Count

            '''''''''

            If Count = 0 Then
                'Try
                'Cmd.CommandText = ("INSERT INTO Mas3 (com,tot1,tot2,tot3,UserCode) VALUES ('" & Strcom & "'," & TOT1 & "," & TOT2 & "," & TOT3 & ",'" & Trim(L1.Text) & "')")
                If Trim(Strcom) <> "" Then
                    If Trim(StrEmpAct) = "Y" Then
                        TOT1 = TOT1 + 1
                    Else
                        TOT2 = TOT2 + 1
                    End If



                    TT = "INSERT INTO Mas4 (Com,EmpNo,EmpNam,UserCode,Act) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & Trim(L1.Text) & "','" & Trim(StrEmpAct) & "')"
                    Cmd.CommandText = (TT)
                    Cmd.ExecuteNonQuery()

                End If
                ' Catch ex As Exception

                ' End Try
            End If


            ' End If
        Next


        Strcom = Dtr1("com")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0


        StrEpfno = Dtr1("epfno")
        StrEname = Dtr1("EmployeeName")
        ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
        'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
        StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
        ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
        StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
        StrEmpAct = Dtr1("EmpAct")
        StrEmpIdno = Dtr1("EmpIdNo")
        StrOldepfno = Dtr1("OldEpfNo")


        ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
        ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
        ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
        ''''''
        ADA = New SqlDataAdapter("SELECT *  FROM Hltmaster1 where (Emp_no=" & Trim(StrEpfno) & " Or Emp_no=" & StrOldepfno & ") and Emp_Com='" & Trim(Strcom) & "' AND Emp_Typ='Indoor' and Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'", CON)
        ss = "SELECT *  FROM Hltmaster1 where Emp_no=" & Trim(StrEpfno) & " and Emp_Com='" & Trim(Strcom) & "' and  Emp_RecDt >='" & DateValue(ss) & "' And Emp_RecDt <='" & ss1 & "'"
        DS = New DataSet
        ADA.Fill(DS)
        Count = DS.Tables(0).Rows.Count

        '''''''''

        If Count = 0 Then
            If Trim(Strcom) <> "" Then
                If Trim(StrEmpAct) = "Y" Then
                    TOT1 = TOT1 + 1
                Else
                    TOT2 = TOT2 + 1
                End If



                TT = "INSERT INTO Mas4 (Com,EmpNo,EmpNam,UserCode,Act) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & Trim(L1.Text) & "','" & Trim(StrEmpAct) & "')"
                Cmd.CommandText = (TT)
                Cmd.ExecuteNonQuery()

            End If
        End If


        CrystalReportViewer2.Visible = True
        com11 = Mid(LstCom.SelectedValue, 1, 3)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
        DSS.SetParameterValue("Ucode", "" & Trim(L1.Text) & "")
        DSS.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")
        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False

        CrystalReportViewer2.DataBind()
    End Sub

    Private Sub Imagebutton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton4.Click
        'Dim DSS As claims = New claims
        Dim EmailMessage1 As MailMessage
        EmailMessage1 = New MailMessage
        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrEpfno, Strcom, StrEname, StrEdate, StrAdate, StrOldepfno, StrEmpAct, StrEmpIdno As String
        CON.Open()
        Dim DeleteCmd As String = "DELETE from MAS1"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Dim DeleteCmd1 As String = "DELETE from MAS2"
        Dim Cmd1 As New SqlCommand(DeleteCmd1, CON)
        Cmd1.ExecuteNonQuery()

        Dim DeleteCmd3 As String = "DELETE from MAS3"
        Dim Cmd2 As New SqlCommand(DeleteCmd1, CON)
        Cmd2.ExecuteNonQuery()

        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False

        Button2.Visible = False

        'Label1.Visible = False
        Label2.Visible = False

        Button13.Visible = False

        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr ='" & yr1 & "' and mt>='" & mt1 & "') and (yr='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)

        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (COM='DSI' OR COM='DSS') order by com,epfno ", CON)

        DS = New DataSet
        ADA.Fill(DS, "HthMaster")
        Count = 0
        TOT1 = 0
        TOT2 = 0
        TOT3 = 0
        TOT4 = 0
        TOT5 = 0
        TOT6 = 0
        TOT7 = 0

        Strcom = "AAA"

        For Each Dtr1 In DS.Tables("HthMaster").Rows
            'Strcom = Dtr1("com")
            If Strcom = "AAA" Then
                Strcom = Trim(Dtr1("com"))
                TT = Trim(Dtr1("EPFnO"))
            End If

            If Strcom = Dtr1("com") Then

                StrEpfno = Dtr1("epfno")
                StrEname = Dtr1("EmployeeName")
                ss = IIf(IsDBNull(Dtr1("Ent_Date")), "01/01/1980", Dtr1("Ent_Date"))
                'StrEdate = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
                StrEdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                ss = IIf(IsDBNull(Dtr1("Act_Date")), "01/01/1980", Dtr1("Act_Date"))
                StrAdate = Format(CDate(Trim(ss)), "MM/dd/yyyy")
                StrEmpAct = Dtr1("EmpAct")
                StrEmpIdno = Dtr1("EmpIdNo")
                StrOldepfno = Dtr1("OldEpfNo")

                ''MID(TRIM(TxtFdt.Text),4,2)+"/"+MID(TRIM(TxtFdt.Text),1,2)+"/"+MID(TRIM(TxtFdt.Text),7,4)  
                ss = Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4)
                ss1 = Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4)
                ''''''
                ss2 = Mid(Trim(TxtRdt.Text), 4, 2) + "/" + Mid(Trim(TxtRdt.Text), 1, 2) + "/" + Mid(Trim(TxtRdt.Text), 7, 4)
                '''''''''
                If DateValue(StrEdate) < Trim(ss2) Then
                    TOT1 = TOT1 + 1
                Else
                    If DateValue(StrEdate) >= DateValue(ss) And DateValue(StrEdate) <= DateValue(ss1) Then

                        If Trim(StrEmpAct) = "Y" Then
                            If Trim(StrEpfno) = Trim(StrOldepfno) Or Trim(StrOldepfno) = "0" Then

                                TOT3 = TOT3 + 1
                                ' Try
                                'Cmd.CommandText = ("INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,UserCode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')")
                                ' TT = "INSERT INTO Mas1 (com,epfno,empnam,empidno,ent_date,Usercode) VALUES ('" & Strcom & "','" & StrEpfno & "','" & StrEname & "','" & StrEmpIdno & "','" & StrEdate & "','" & Trim(L1.Text) & "')"
                                'Cmd.ExecuteNonQuery()
                                'Catch ex As Exception

                                'End Try
                                '
                            Else

                                TOT5 = TOT5 + 1
                                '  End If
                            End If
                            '
                        Else
                            'If DateValue(StrAdate) >= Trim(ss) And DateValue(StrAdate) <= Trim(ss1) Then
                            If Trim(StrEmpAct) = "N" Then

                                If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                                    ADA = New SqlDataAdapter("Select * from HltMaster1 where Emp_Com='" & Strcom & "' and (Emp_No='" & Trim(StrEpfno) & "' or Emp_No='" & Trim(StrOldepfno) & "')", CON)
                                    DS = New DataSet
                                    ADA.Fill(DS, "HltMaster1")

                                    COUNT2 = DS.Tables("HltMaster1").Rows.Count

                                    If COUNT2 <> 0 Then
                                        TOT4 = TOT4 + 1
                                        TOT7 = TOT7 + 1

                                    Else
                                        TOT7 = TOT7 + 1
                                    End If

                                End If
                            End If

                        End If

                    Else
                        If DateValue(StrEdate) < DateValue(ss) Then
                            If Trim(StrEmpAct) = "N" Then
                                If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                                    ADA = New SqlDataAdapter("Select * from HltMaster1 where Emp_Com='" & Strcom & "' and (Emp_No='" & Trim(StrEpfno) & "' or Emp_No='" & Trim(StrOldepfno) & "')", CON)
                                    DS = New DataSet
                                    ADA.Fill(DS, "HltMaster1")

                                    COUNT2 = DS.Tables("HltMaster1").Rows.Count

                                    If COUNT2 <> 0 Then
                                        TOT4 = TOT4 + 1
                                        TOT7 = TOT7 + 1

                                    Else
                                        TOT7 = TOT7 + 1
                                    End If

                                End If

                            End If
                        Else

                            If Trim(StrEmpAct) = "N" Then
                                If DateValue(StrAdate) >= DateValue(ss) And DateValue(StrAdate) <= DateValue(ss1) Then

                                    ADA = New SqlDataAdapter("Select * from HltMaster1 where Emp_Com='" & Strcom & "' and (Emp_No='" & Trim(StrEpfno) & "' or Emp_No='" & Trim(StrOldepfno) & "')", CON)
                                    DS = New DataSet
                                    ADA.Fill(DS, "HltMaster1")

                                    COUNT2 = DS.Tables("HltMaster1").Rows.Count

                                    If COUNT2 <> 0 Then
                                        TOT4 = TOT4 + 1
                                        TOT7 = TOT7 + 1

                                    Else
                                        TOT7 = TOT7 + 1
                                    End If

                                End If

                            End If

                        End If


                    End If
                    'If DateValue(StrEdate) < DateValue(ss) And DateValue(StrEdate) >= DateValue(ss2) Then
                    '    If Trim(StrEmpAct) = "Y" Then
                    '        TOT5 = TOT5 + 1
                    '    Else

                    '    End If

                End If



            Else

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage

                emailMessage.From = "insurance@dsisamson.com"
                EmailMessage1.From = "insurance@dsisamson.com"
                emailMessage.Subject = Strcom + " Health Fund - Payment Notice   From " + TxtFdt.Text + " to " + TxtTdt.Text
                EmailMessage1.Subject = "Health Fund - Payment Notice  From " + TxtFdt.Text + " to " + TxtTdt.Text
                ADA = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & Strcom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "Company")

                COUNT2 = DS.Tables("Company").Rows.Count
                Dim SCNam, StEmail As String
                If COUNT2 <> 0 Then
                    For Each dtr2 In DS.Tables("Company").Rows

                        SCNam = dtr2("Com_Nam")
                        StEmail = Trim(dtr2("Com_TEmail"))
                    Next


                    emailMessage.To = Trim(dtr2("Com_TEmail"))

                    ' emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    ss = Space(10) + Format((TOT1 + TOT6 + TOT5) * 350, "#,###,###.00")
                    ss = Right(ss, 15)
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += "Total No Employees:                        " + "            " + Str((TOT1 + TOT6 + TOT5)) & vbCrLf
                    emailMessage.Body += "Total No Employees: PAYMENT               :" + "Rs." + ss & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf


                    emailMessage.Body += "Total Epf No Changers                     :" + "            " + Str(TOT5) & vbCrLf
                    'emailMessage.Body += "AAA :" + "" + Str(TOT6) & vbCrLf

                    'emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    'emailMessage.Body += " " & vbCrLf

                    'emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    'emailMessage.Body += "BBB:    " + "" + Str(TOT5) & vbCrLf
                    'emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf

                    ss = Val(Mid(Trim(TxtFdt.Text), 4, 2))

                    If ss <= 3 Then
                        ss1 = "100"

                    Else
                        If ss <= 6 Then
                            ss1 = "75"
                        Else
                            If ss <= 9 Then
                                ss1 = "50"
                            Else
                                ss1 = "25"
                            End If
                        End If
                    End If

                    emailMessage.Body += "Current Month No of new Inclusions        :" + "            " + Str(TOT3) & vbCrLf
                    ss = Space(10) + Format(TOT3 * 350 * 12 * Val(ss1) / 100, "#,###,###.00")
                    ss = Right(ss, 15)


                    emailMessage.Body += "Current Month No of new Inclusions PAYMENT:" + "Rs." + ss & vbCrLf

                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "Left No of Employees                      :" + "            " + Str(TOT7) & vbCrLf

                    ' emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    'emailMessage.Body += " " & vbCrLf
                    'emailMessage.Body += "Left No of claims Employees 1:" + "" + Str(TOT2) & vbCrLf

                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    emailMessage.Body += "No of claims Employees                    :" + "            " + Str(TOT4) & vbCrLf
                    ss = Space(10) + Format(TOT4 * 350 * 12 * Val(ss1) / 100, "#,###,###.00")
                    ss = Right(ss, 15)



                    emailMessage.Body += "No of claims Employees  PAYMENT           :" + "Rs." + ss & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += " " & vbCrLf

                    ss = Space(10) + Format((((TOT1 + TOT6 + TOT5) * 350) - (TOT4 * 350 * 12 * Val(ss1) / 100)), "#,###,###.00")
                    ss = Right(ss, 15)


                    emailMessage.Body += "Actual Premium to be Paid                 :" + "Rs." + ss & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    emailMessage.Body += " " & vbCrLf
                    emailMessage.Body += "Created By:" + Trim(L1.Text) & vbCrLf
                    emailMessage.Body += "----------------------------------------------------------------------" & vbCrLf
                    ' emailMessage.To = "palithan@samsoncorporates.com,chamindas@samsoncorporates.com"
                    '  emailMessage.To = "udanip@samsoncorporates.com,palithan@samsoncorporates.com"
                    'emailMessage.To = Trim(StEmail)
                    emailMessage.To = "palithan@samsoncorporates.com"

                    SmtpMail.SmtpServer = "mail.dsisamson.com"
                    Try
                        SmtpMail.Send(emailMessage)

                    Catch ex As Exception

                    End Try

                End If

                Strcom = Trim(Dtr1("com"))

                Count = 0
                TOT1 = 0
                TOT2 = 0
                TOT3 = 0
                TOT4 = 0
                TOT5 = 0
                TOT6 = 0
                TOT7 = 0


            End If

        Next

    End Sub

    Private Sub Imgbtt5_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imgbtt5.Click
        Calendar3.Visible = True
    End Sub

    Private Sub Calendar3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar3.SelectionChanged
        TxtRdt.Text = Format((Calendar3.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar3.Visible = False
    End Sub
End Class
