
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class HealthReport2
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
    Dim com11 As String
    Dim ss As String
    Dim oStream As New MemoryStream
    Dim Typ As String
    Dim Count As Integer
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents LstCom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents LstMt As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lb1 As System.Web.UI.WebControls.Label
    Protected WithEvents Lb2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtYr As System.Web.UI.WebControls.TextBox
    Protected WithEvents CRYSTALREPORTVIEWER2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtYr1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents LstMt1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtAccYr As System.Web.UI.WebControls.TextBox
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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        If Not IsPostBack Then
            Global.PwFlag = "N"

            If Global.PwLevel = "1" Then
                Global.PwFlag = "Y"

            Else

                If Global.PwLevel = "2" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport2.aspx' and Form_level2='1'", CON)

                Else
                    If Global.PwLevel = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport2.aspx' and Form_level3='1'", CON)

                    Else
                        If Global.PwLevel = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport2.aspx' and Form_level4='1'", CON)
                        Else
                            If Global.PwLevel = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HealthReport21.aspx' and Form_level5='1'", CON)

                            Else
                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                            End If




                        End If
                    End If

                End If
                'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                DR = CMD.ExecuteReader
                While DR.Read
                    Global.PwFlag = "Y"
                End While

                DR.Close()

                TxtAccYr.Text = Trim(Year(Today()))
            End If


            '  If Global.PwFlag = "Y" Then
            Response.AddHeader("Refresh", 1800)
            'Else

            ' Response.Redirect("POSDispaly11.aspx")
            'End If

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
                LstCom.Items.Add(DR.GetValue(0) + " - " + DR.GetValue(1))
            End While
        End If

        DR.Close()

        CMD = New SqlCommand("SELECT mt,mtn From MonthName", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then



            While DR.Read
                TxtYr.Text = Year(Today())
                TxtYr1.Text = Year(Today())
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstMt.Items.Add(DR.GetValue(0) + " - " + DR.GetValue(1))
                LstMt1.Items.Add(DR.GetValue(0) + " - " + DR.GetValue(1))
            End While
        End If

        DR.Close()


        'End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim DSS As HltReport2 = New HltReport2


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

        Dim vehno1 As String




        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim DSS As claims = New claims

        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrclAmt, Strcom, Stryr, Strmt, StrclAmt1, StrTyp As String

        Dim DeleteCmd As String = "DELETE from HthTemp"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        LstMt.Visible = False
        TxtYr.Visible = False
        Button2.Visible = False
        lb1.Visible = False
        Lb2.Visible = False
        'Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        LstMt1.Visible = False
        TxtYr1.Visible = False
        Label4.Visible = False
        TxtAccYr.Visible = False

        yr1 = Trim(TxtYr.Text)
        mt1 = Mid(LstMt.SelectedValue, 1, 2)
        mtn = Mid(LstMt.SelectedValue, 6, 3)
        mtn1 = Mid(LstMt1.SelectedValue, 6, 3)
        yr2 = Trim(TxtYr1.Text)
        mt2 = Mid(LstMt1.SelectedValue, 1, 2)



        ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr='" & Trim(TxtAccYr.Text) & "' and mt>='01' and mt<='11') order by com,yr,mt", CON)


        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr='" & yr1 & "' and substring(mth,1,3)='" & mtn & "') order by com,yr,mt", CON)
        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr='" & yr1 & "') order by com,yr,mt", CON)
        DS = New DataSet
        ADA.Fill(DS, "HthRecPayment")

        For Each Dtr1 In DS.Tables("HthRecPayment").Rows
            Strcom = Dtr1("com")
            Stryr = Dtr1("yr")
            Strmt = Dtr1("mt")
            StrclAmt = Dtr1("RecAmt")

            ADA = New SqlDataAdapter("SELECT * FROM HthTemp WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "HthTemp")
            Count = DS.Tables("HthTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                ss = "UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'"

                Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt=clamt+" & StrclAmt & " WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
            Else

                ss = "INSERT INTO HthTemp (com,mt,yr,clamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')"
                Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,clamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")

            End If

            Cmd.ExecuteNonQuery()
        Next

        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_amt,emp_yr,emp_mt FROM Hltmaster1 WHERE (Emp_yr<='" & yr1 & "' and Emp_mt<='" & mt1 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt", CON)
        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and (Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

        If Val(yr1) <> Val(yr2) Then
            'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text & "') and ((Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr>='" & yr1 & "' and Emp_mt<='12')) and ((Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ",CON)

            ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and ((Emp_yr='" & yr1 & "' and Emp_mt>='" & mt1 & "' and Emp_mt<='12') OR (Emp_yr='" & yr2 & "' and Emp_mt<='" & mt2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

        Else
            ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr=" & Trim(TxtAccYr.Text) & ") and (Emp_yr>=" & yr1 & " and Emp_mt>=" & mt1 & ") and (Emp_yr<=" & yr2 & " and Emp_mt<=" & mt2 & ") group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)
        End If



        DS = New DataSet
        ADA.Fill(DS, "Hltmaster1")
        For Each Dtr1 In DS.Tables("Hltmaster1").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("Emp_yr")
            Strmt = Dtr1("Emp_mt")
            StrclAmt = Dtr1("Emp_Amt")
            StrTyp = Dtr1("Emp_Typ")
            ADA = New SqlDataAdapter("SELECT * FROM HthTemp WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "HthTemp")
            Count = DS.Tables("HthTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If StrTyp = "Indoor" Then
                    Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt1= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                Else
                    If StrTyp = "Outdoor" Then
                        Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',fdamt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                    Else
                        Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',CrAmt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                    End If

                End If


            Else


                If StrTyp = "Indoor" Then
                    Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,clamt1) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                Else
                    If StrTyp = "Outdoor" Then
                        Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,fdamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                    Else
                        Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,Cramt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                    End If


                End If
            End If

            Cmd.ExecuteNonQuery()


        Next

        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("myr", "" & yr1 & "")
        DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        DSS.SetParameterValue("myr1", "" & yr2 & "")
        DSS.SetParameterValue("Accyr", "" & Trim(TxtAccYr.Text) & "")
        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim DSS As EmpListDeActive = New EmpListDeActive


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


        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
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

        'Dim strReport As String = ""
        'strReport = "POPTop1.aspx"
        'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=800,left=0,top=0,scrollbars=yes,status=no');<" & "/script>"
        'Page.RegisterStartupScript("OpenWindow", strJS)


        CRYSTALREPORTVIEWER2.Visible = True



        com11 = Mid(LstCom.SelectedValue, 1, 3)



        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")

        'DSS.SetParameterValue("Vehno", "" & vehno1 & "")

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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


        CRYSTALREPORTVIEWER2.Visible = True


        com11 = Mid(LstCom.SelectedValue, 1, 3)





        DSS.SetDatabaseLogon("sa", "tstc123")
        'DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("Com", "" & com11 & "")


        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim DSS As claims = New claims

        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrclAmt, Strcom, Stryr, Strmt, StrclAmt1, StrTyp As String

        Dim DeleteCmd As String = "DELETE from HthTemp"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        LstMt.Visible = False
        TxtYr.Visible = False
        Button2.Visible = False
        lb1.Visible = False
        Lb2.Visible = False
        'Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        LstMt1.Visible = False
        TxtYr1.Visible = False
        Label4.Visible = False
        TxtAccYr.Visible = False

        yr1 = Trim(TxtYr.Text)
        mt1 = Mid(LstMt.SelectedValue, 1, 2)
        mtn = Mid(LstMt.SelectedValue, 6, 3)
        mtn1 = Mid(LstMt1.SelectedValue, 6, 3)
        yr2 = Trim(TxtYr1.Text)
        mt2 = Mid(LstMt1.SelectedValue, 1, 2)



        ' ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr>='" & yr1 & "' and mt>='" & mt1 & "') and (yr<='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)
        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr>='" & yr1 & "' and substring(mth,1,3)='" & mtn & "') order by com,yr,mt", CON)
        ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr='" & Trim(TxtAccYr.Text) & "' and mt>='01' and mt<='11') order by com,yr,mt", CON)
        DS = New DataSet
        ADA.Fill(DS, "HthRecPayment")

        For Each Dtr1 In DS.Tables("HthRecPayment").Rows
            Strcom = Dtr1("com")
            Stryr = Dtr1("yr")
            Strmt = Dtr1("mt")
            StrclAmt = Dtr1("RecAmt")

            ADA = New SqlDataAdapter("SELECT * FROM HthTemp WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "HthTemp")
            Count = DS.Tables("HthTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                ss = "UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'"

                Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt=clamt+" & StrclAmt & " WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
            Else

                ss = "INSERT INTO HthTemp (com,mt,yr,clamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')"
                Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,clamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")

            End If

            Cmd.ExecuteNonQuery()
        Next

        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_amt,emp_yr,emp_mt FROM Hltmaster1 WHERE (Emp_yr<='" & yr1 & "' and Emp_mt<='" & mt1 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt", CON)
        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and (Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

        If Val(yr1) <> Val(yr2) Then
            'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text & "') and ((Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr>='" & yr1 & "' and Emp_mt<='12')) and ((Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ",CON)

            ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and ((Emp_yr='" & yr1 & "' and Emp_mt>='" & mt1 & "' and Emp_mt<='12') OR (Emp_yr='" & yr2 & "' and Emp_mt<='" & mt2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

        Else
            ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr=" & Trim(TxtAccYr.Text) & ") and (Emp_yr>=" & yr1 & " and Emp_mt>=" & mt1 & ") and (Emp_yr<=" & yr2 & " and Emp_mt<=" & mt2 & ") group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)
        End If



        DS = New DataSet
        ADA.Fill(DS, "Hltmaster1")
        For Each Dtr1 In DS.Tables("Hltmaster1").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("Emp_yr")
            Strmt = Dtr1("Emp_mt")
            StrclAmt = Dtr1("Emp_Amt")
            StrTyp = Dtr1("Emp_Typ")
            ADA = New SqlDataAdapter("SELECT * FROM HthTemp WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "HthTemp")
            Count = DS.Tables("HthTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If StrTyp = "Indoor" Then
                    Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt1= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                Else
                    If StrTyp = "Outdoor" Then
                        Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',fdamt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                    Else
                        Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',CrAmt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                    End If

                End If


            Else


                If StrTyp = "Indoor" Then
                    Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,clamt1) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                Else
                    If StrTyp = "Outdoor" Then
                        Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,fdamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                    Else
                        Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,Cramt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                    End If


                End If
            End If

            Cmd.ExecuteNonQuery()


        Next

        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("myr", "" & yr1 & "")
        DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        DSS.SetParameterValue("myr1", "" & yr2 & "")
        DSS.SetParameterValue("Accyr", "" & Trim(TxtAccYr.Text) & "")
        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
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
        'Response.End()
        Try
            Response.BinaryWrite(oStream.ToArray())
            Response.End()
        Catch err As Exception
            Response.Write("<BR>")
            Response.Write(err.Message.ToString)
        End Try
    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Dim DSS As claims = New claims

        Dim yr1, mt1, mtn, yr2, mt2, mtn1 As String
        Dim StrclAmt, Strcom, Stryr, Strmt, StrclAmt1, StrTyp As String

        Dim DeleteCmd As String = "DELETE from HthTemp"
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        '  Label1.Visible = False
        Button1.Visible = False
        LstCom.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        LstMt.Visible = False
        TxtYr.Visible = False
        Button2.Visible = False
        lb1.Visible = False
        Lb2.Visible = False
        'Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        LstMt1.Visible = False
        TxtYr1.Visible = False
        Label4.Visible = False
        TxtAccYr.Visible = False

        yr1 = Trim(TxtYr.Text)
        mt1 = Mid(LstMt.SelectedValue, 1, 2)
        mtn = Mid(LstMt.SelectedValue, 6, 3)
        mtn1 = Mid(LstMt1.SelectedValue, 6, 3)
        yr2 = Trim(TxtYr1.Text)
        mt2 = Mid(LstMt1.SelectedValue, 1, 2)



        ' ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr>='" & yr1 & "' and mt>='" & mt1 & "') and (yr<='" & yr2 & "' and mt<='" & mt2 & "') order by com,yr,mt", CON)
        'ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr>='" & yr1 & "' and substring(mth,1,3)='" & mtn & "') order by com,yr,mt", CON)
        ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE (yr='" & Trim(TxtAccYr.Text) & "' and mt>='01' and mt<='11') order by com,yr,mt", CON)
        DS = New DataSet
        ADA.Fill(DS, "HthRecPayment")

        For Each Dtr1 In DS.Tables("HthRecPayment").Rows
            Strcom = Dtr1("com")
            Stryr = Dtr1("yr")
            Strmt = Dtr1("mt")
            StrclAmt = Dtr1("RecAmt")

            ADA = New SqlDataAdapter("SELECT * FROM HthTemp WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "HthTemp")
            Count = DS.Tables("HthTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                ss = "UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt= '" & StrclAmt & "' WHERE (com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'"

                Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt=clamt+" & StrclAmt & " WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
            Else

                ss = "INSERT INTO HthTemp (com,mt,yr,clamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')"
                Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,clamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")

            End If

            Cmd.ExecuteNonQuery()
        Next

        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_amt,emp_yr,emp_mt FROM Hltmaster1 WHERE (Emp_yr<='" & yr1 & "' and Emp_mt<='" & mt1 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt", CON)
        'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and (Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

        If Val(yr1) <> Val(yr2) Then
            'ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text & "') and ((Emp_yr>='" & yr1 & "' and Emp_mt>='" & mt1 & "') and (Emp_yr>='" & yr1 & "' and Emp_mt<='12')) and ((Emp_yr<='" & yr2 & "' and Emp_mt<='" & mt2 & "') and (Emp_yr>='" & yr2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ",CON)

            ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr='" & Trim(TxtAccYr.Text) & "') and ((Emp_yr='" & yr1 & "' and Emp_mt>='" & mt1 & "' and Emp_mt<='12') OR (Emp_yr='" & yr2 & "' and Emp_mt<='" & mt2 & "' and Emp_mt>='01')) group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)

        Else
            ADA = New SqlDataAdapter("SELECT Emp_Com,Sum(Emp_Amt) as Emp_Amt,Emp_yr,Emp_mt,Emp_Typ FROM Summery WHERE (Emp_Accyr=" & Trim(TxtAccYr.Text) & ") and (Emp_yr>=" & yr1 & " and Emp_mt>=" & mt1 & ") and (Emp_yr<=" & yr2 & " and Emp_mt<=" & mt2 & ") group by emp_com,Emp_yr,Emp_mt,Emp_Typ", CON)
        End If



        DS = New DataSet
        ADA.Fill(DS, "Hltmaster1")
        For Each Dtr1 In DS.Tables("Hltmaster1").Rows
            Strcom = Dtr1("Emp_com")
            Stryr = Dtr1("Emp_yr")
            Strmt = Dtr1("Emp_mt")
            StrclAmt = Dtr1("Emp_Amt")
            StrTyp = Dtr1("Emp_Typ")
            ADA = New SqlDataAdapter("SELECT * FROM HthTemp WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "HthTemp")
            Count = DS.Tables("HthTemp").Rows.Count
            Cmd.Connection = CON
            If Count <> 0 Then
                If StrTyp = "Indoor" Then
                    Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',clamt1= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                Else
                    If StrTyp = "Outdoor" Then
                        Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',fdamt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                    Else
                        Cmd.CommandText = ("UPDATE HthTemp SET com='" & Strcom & "',mt='" & Strmt & "',yr= '" & Stryr & "',CrAmt= '" & StrclAmt & "' WHERE com = '" & Strcom & "' and yr='" & Stryr & "' and mt='" & Strmt & "'")
                    End If

                End If


            Else


                If StrTyp = "Indoor" Then
                    Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,clamt1) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                Else
                    If StrTyp = "Outdoor" Then
                        Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,fdamt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                    Else
                        Cmd.CommandText = ("INSERT INTO HthTemp (com,mt,yr,Cramt) VALUES ('" & Strcom & "','" & Strmt & "','" & Stryr & "','" & StrclAmt & "')")
                    End If


                End If
            End If

            Cmd.ExecuteNonQuery()


        Next

        CRYSTALREPORTVIEWER2.Visible = True

        Dim vehno1 As String


        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("mtname", "" & mtn & "")
        DSS.SetParameterValue("myr", "" & yr1 & "")
        DSS.SetParameterValue("mtname1", "" & mtn1 & "")
        DSS.SetParameterValue("myr1", "" & yr2 & "")
        DSS.SetParameterValue("Accyr", "" & Trim(TxtAccYr.Text) & "")
        ' CrystalReportViewer2.SeparatePages = True

        CRYSTALREPORTVIEWER2.ReportSource = DSS

        CRYSTALREPORTVIEWER2.HasRefreshButton = False
        CRYSTALREPORTVIEWER2.HasZoomFactorList = False
        CRYSTALREPORTVIEWER2.HasPageNavigationButtons = False
        CRYSTALREPORTVIEWER2.HasDrillUpButton = False

        CRYSTALREPORTVIEWER2.DataBind()
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

        Try
            Response.BinaryWrite(oStream.ToArray())
            Response.End()
        Catch err As Exception
            Response.Write("<BR>")
            Response.Write(err.Message.ToString)
        End Try

    End Sub
End Class
