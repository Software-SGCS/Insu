Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Imports System.Web

Imports System.Web.UI

Imports System.Web.UI.WebControls

Imports System.Web.UI.HtmlControls

Imports System.Configuration

Public Class NewApp3
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
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1, InvTt1 As String
    Dim Intstk As Integer
    Dim Typ As String
    Dim AAA As String
    Dim InvVat As String
    Dim InvNo11 As String


    Dim Count As Integer
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Button8 As System.Web.UI.WebControls.Button
    Protected WithEvents CrystalReportViewer2 As CrystalDecisions.Web.CrystalReportViewer





#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
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
        'Put user code to initialize the page here
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        InvNo11 = HttpContext.Current.Request.QueryString("Type").ToString()
        TxtId.Text = InvNo11
        Panel2.Visible = True
        Panel1.Visible = True
        Panel3.Visible = True
        Panel4.Visible = True



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False



        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            ' InvFlag11 = Dtr1("Inv_Flag1")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")
            Invvat1 = Dtr1("Inv_flg")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then


            If InvVat = "Yes" Then
                If Invvat1 = "Yes" Then
                    Dim DSS As CryTaxInvSpe = New CryTaxInvSpe

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                Else




                    Dim DSS As CryTaxInv = New CryTaxInv

                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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
            Else

                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv = New CryInv

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else



                        Dim DSS As CryTaxInvVat = New CryTaxInvVat

                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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

                End If

            Else
            If AAA = "66666" Then

                If InvVat = "Yes" Then
                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe = New CryTaxInvSpe

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                    Else

                        Dim DSS As CryTaxInv1 = New CryTaxInv1
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                Else

                        If Invflag31 = "Yes" Then

                            Dim DSS As CryInv1 = New CryInv1

                            CrystalReportViewer2.Visible = True

                            '  Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                        Else

                            Dim DSS As CryTaxInvVat1 = New CryTaxInvVat1
                            CrystalReportViewer2.Visible = True

                            ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                    End If
                Else
                If InvVat = "Yes" Then

                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe = New CryTaxInvSpe

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                    Else

                        Dim DSS As CryTaxInv2 = New CryTaxInv2
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                Else

                        If Invflag31 = "Yes" Then

                            Dim DSS As CryInv2 = New CryInv2

                            CrystalReportViewer2.Visible = True

                            '  Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                        Else

                            Dim DSS As CryTaxInvVat2 = New CryTaxInvVat2
                            CrystalReportViewer2.Visible = True

                            ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                    End If


                End If


        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'crReportDocument.SetDatabaseLogon("USER", "PASSWORD", "SQL-SERVER", "DATABASE")
        'crReportDocument.PrintToPrinter(1, False, 0, 0)
        Try
            Button2.Visible = False
            'LstId.Visible = False


            Dim DeleteCmd As String = "DELETE from TempInv "
            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            Cmd.ExecuteNonQuery()
            Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
            DR1 = Cmd.ExecuteReader
            DR1.Close()


            ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & TxtId.Text & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "INHINV1")

            For Each Dtr1 In DS.Tables("INHINV1").Rows
                Invno1 = Dtr1("Inv_No")
                InvCom1 = Dtr1("Inv_Com")
                Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
                InvPono1 = Dtr1("Inv_pono")
                ' InvFlag11 = Dtr1("Inv_Flag1")
                InvVat = Dtr1("Inv_Vat")
                ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "InlInv1")

                For Each Dtr In DS.Tables("InlInv1").Rows
                    InvItmNo1 = Dtr("Inv_ItmNo")
                    InvQty1 = Dtr("Inv_Qty")
                    InvVal1 = Dtr("Inv_val")
                    InvPri1 = Dtr("Inv_Pri")

                    Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Invdt1 & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "')")
                    Cmd.ExecuteNonQuery()

                Next

            Next

            Dim DSS As CryTaxInv = New CryTaxInv
            CrystalReportViewer2.Visible = True

            'Invno1 = txtid.text

            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            'DSS.SetParameterValue("Invno", "" & Trim(Invno1) & "")
            DSS.Refresh()

            CrystalReportViewer2.SeparatePages = True

            CrystalReportViewer2.ReportSource = DSS

            CrystalReportViewer2.HasRefreshButton = False
            CrystalReportViewer2.HasZoomFactorList = False
            CrystalReportViewer2.HasPageNavigationButtons = False
            CrystalReportViewer2.HasDrillUpButton = False

            CrystalReportViewer2.DataBind()



            ' DSS.SetDatabaseLogon("POS", "POS")
            'DSS.PrintOptions.PrinterName = "\\192.168.12.192\HP"
            'DSS.PrintToPrinter(1, False, 0, 0)

            'Report.PrintOptions.PrinterName = "\\LMO-BDC\TS_PRINTER"
            'Report.PrintToPrinter(1, True, 1, 1)
        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False


        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")
            Invvat1 = Dtr1("Inv_flg")
            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then

            If InvVat = "Yes" Then
                If Invvat1 = "Yes" Then
                    Dim DSS As CryTaxInvSpeA = New CryTaxInvSpeA

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                Else




                    Dim DSS As CryTaxInvA = New CryTaxInvA

                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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
            Else
                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInvA = New CryInvA

                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else



                        Dim DSS As CryTaxInvVatA = New CryTaxInvVatA

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                End If

            Else

            If AAA = "66666" Then


                If InvVat = "Yes" Then
                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe1A = New CryTaxInvSpe1A

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                    Else


                        Dim DSS As CryTaxInv1A = New CryTaxInv1A
                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                Else
                        If Invflag31 = "Yes" Then

                            Dim DSS As CryInv1A = New CryInv1A

                            CrystalReportViewer2.Visible = True

                            Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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


                        Else


                            Dim DSS As CryTaxInvVat1A = New CryTaxInvVat1A
                            CrystalReportViewer2.Visible = True

                            Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                    End If
                Else
                If InvVat = "Yes" Then

                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe2A = New CryTaxInvSpe2A

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                    Else


                        Dim DSS As CryTaxInv2A = New CryTaxInv2A
                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                Else
                        If Invflag31 = "Yes" Then

                            Dim DSS As CryInv2A = New CryInv2A

                            CrystalReportViewer2.Visible = True

                            Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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


                        Else


                            Dim DSS As CryTaxInvVat2A = New CryTaxInvVat2A
                            CrystalReportViewer2.Visible = True

                            Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                    End If

                End If


        End If



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False




        Dim AAA As String
        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")
            Invvat1 = Dtr1("Inv_flg")
            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then

            If InvVat = "Yes" Then
                If Invvat1 = "Yes" Then
                    Dim DSS As CryTaxInvSpeB = New CryTaxInvSpeB

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                Else

                    Dim DSS As CryTaxInvB = New CryTaxInvB

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(txtid.text), 1, 7)

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
            Else
                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInvB = New CryInvB

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else


                        Dim DSS As CryTaxInvVatB = New CryTaxInvVatB

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(txtid.text), 1, 7)

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

                End If

            Else

            If AAA = "66666" Then
                If InvVat = "Yes" Then
                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe1B = New CryTaxInvSpe1B

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                    Else

                        Dim DSS As CryTaxInv1B = New CryTaxInv1B
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                Else
                        If Invflag31 = "Yes" Then

                            Dim DSS As CryInv1B = New CryInv1B

                            CrystalReportViewer2.Visible = True

                            ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                        Else


                            Dim DSS As CryTaxInvVat1B = New CryTaxInvVat1B
                            CrystalReportViewer2.Visible = True

                            'Invno1 = Mid(Trim(txtid.text), 1, 7)
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
                    End If
                Else
                If InvVat = "Yes" Then
                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe2B = New CryTaxInvSpe2B

                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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



                    Else

                        Dim DSS As CryTaxInv2B = New CryTaxInv2B
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                Else
                        If Invflag31 = "Yes" Then

                            Dim DSS As CryInv2B = New CryInv2B

                            CrystalReportViewer2.Visible = True

                            ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                        Else


                            Dim DSS As CryTaxInvVat2B = New CryTaxInvVat2B
                            CrystalReportViewer2.Visible = True

                            'Invno1 = Mid(Trim(txtid.text), 1, 7)
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
                    End If


                End If

        End If



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False


        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False



        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            ' InvFlag11 = Dtr1("Inv_Flag1")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then


            If InvVat = "Yes" Then


                Dim DSS As CryTaxInvD = New CryTaxInvD

                CrystalReportViewer2.Visible = True

                ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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

            Else

                If Invflag31 = "Yes" Then

                    Dim DSS As CryInvD = New CryInvD

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                Else



                    Dim DSS As CryTaxInvVatD = New CryTaxInvVatD

                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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

            End If

        Else
            If AAA = "66666" Then

                If InvVat = "Yes" Then

                    Dim DSS As CryTaxInv1D = New CryTaxInv1D
                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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

                Else

                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv1D = New CryInv1D

                        CrystalReportViewer2.Visible = True

                        '  Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else

                        Dim DSS As CryTaxInvVat1D = New CryTaxInvVat1D
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                End If
            Else
                If InvVat = "Yes" Then

                    Dim DSS As CryTaxInv2D = New CryTaxInv2D
                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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

                Else

                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv2D = New CryInv2D

                        CrystalReportViewer2.Visible = True

                        '  Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else

                        Dim DSS As CryTaxInvVat2D = New CryTaxInvVat2D
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                End If


            End If


        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False


        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then

            If InvVat = "Yes" Then

                Dim DSS As CryTaxInvDA = New CryTaxInvDA

                CrystalReportViewer2.Visible = True

                ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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

            Else
                If Invflag31 = "Yes" Then

                    Dim DSS As CryInvDA = New CryInvDA

                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                Else



                    Dim DSS As CryTaxInvVatDA = New CryTaxInvVatDA

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(txtid.text), 1, 7)

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


            End If

        Else

            If AAA = "66666" Then


                If InvVat = "Yes" Then
                    Dim DSS As CryTaxInv1DA = New CryTaxInv1DA
                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                Else
                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv1DA = New CryInv1DA

                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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


                    Else


                        Dim DSS As CryTaxInvVat1DA = New CryTaxInvVat1DA
                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                End If
            Else
                If InvVat = "Yes" Then
                    Dim DSS As CryTaxInv2DA = New CryTaxInv2DA
                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                Else
                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv2DA = New CryInv2DA

                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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


                    Else


                        Dim DSS As CryTaxInvVat2DA = New CryTaxInvVat2DA
                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(TxtId.Text), 1, 7)

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
                End If

            End If


        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False




        Dim AAA As String
        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then

            If InvVat = "Yes" Then

                Dim DSS As CryTaxInvDB = New CryTaxInvDB

                CrystalReportViewer2.Visible = True

                'Invno1 = Mid(Trim(txtid.text), 1, 7)

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

            Else
                If Invflag31 = "Yes" Then

                    Dim DSS As CryInvDB = New CryInvDB

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                Else


                    Dim DSS As CryTaxInvVatDB = New CryTaxInvVatDB

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(txtid.text), 1, 7)

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

            End If

        Else

            If AAA = "66666" Then
                If InvVat = "Yes" Then

                    Dim DSS As CryTaxInv1DB = New CryTaxInv1DB
                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                Else
                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv1DB = New CryInv1DB

                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else


                        Dim DSS As CryTaxInvVat1DB = New CryTaxInvVat1DB
                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(txtid.text), 1, 7)
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
                End If
            Else
                If InvVat = "Yes" Then

                    Dim DSS As CryTaxInv2DB = New CryTaxInv2DB
                    CrystalReportViewer2.Visible = True

                    ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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
                Else
                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv2DB = New CryInv2DB

                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Mid(Trim(txtid.text), 1, 7)

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


                    Else


                        Dim DSS As CryTaxInvVat2DB = New CryTaxInvVat2DB
                        CrystalReportViewer2.Visible = True

                        'Invno1 = Mid(Trim(txtid.text), 1, 7)
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
                End If


            End If

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False



        'InvNo11 = Mid(Trim(txtid.text), 1, 7)
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Format(Dtr1("Inv_dt"), "MM/dd/yyyy")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            ' InvFlag11 = Dtr1("Inv_Flag1")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")
            Invvat1 = Dtr1("Inv_flg")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")

                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then


            If InvVat = "Yes" Then
                If Invvat1 = "Yes" Then
                    Dim DSS As CryTaxInvSpe = New CryTaxInvSpe

                    CrystalReportViewer2.Visible = True

                    'Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                    Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                    Dim myExportFile As String
                    Dim myReport As New CryTaxInvSpe


                    'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                    'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                    myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                    myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                    myDiskFileDestinationOptions.DiskFileName = myExportFile
                    myExportOptions = myReport.ExportOptions
                    With myExportOptions
                        .DestinationOptions = myDiskFileDestinationOptions
                        .ExportDestinationType = .ExportDestinationType.DiskFile
                        .ExportFormatType = .ExportFormatType.PortableDocFormat
                    End With
                    myReport.SetDatabaseLogon("sa", "tstc123")

                    myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                    'myReport.SetParameterValue("Com", "" & com11 & "")
                    'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                    'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                    myReport.Export()
                    myReport.Close()

                    Response.Redirect("Data/Submit.PDF")
                    'TxtFlg.Text = "0"
                    'ImageButton1.Visible = False



                Else




                    Dim DSS As CryTaxInv = New CryTaxInv

                    Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                    Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                    Dim myExportFile As String
                    Dim myReport As New CryTaxInv


                    'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                    'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                    myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                    myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                    myDiskFileDestinationOptions.DiskFileName = myExportFile
                    myExportOptions = myReport.ExportOptions
                    With myExportOptions
                        .DestinationOptions = myDiskFileDestinationOptions
                        .ExportDestinationType = .ExportDestinationType.DiskFile
                        .ExportFormatType = .ExportFormatType.PortableDocFormat
                    End With
                    myReport.SetDatabaseLogon("sa", "tstc123")

                    myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                    'myReport.SetParameterValue("Com", "" & com11 & "")
                    'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                    'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                    myReport.Export()
                    myReport.Close()

                    Response.Redirect("Data/Submit.PDF")
                    'TxtFlg.Text = "0"
                    'ImageButton1.Visible = False
                End If
            Else

                If Invflag31 = "Yes" Then

                    Dim DSS As CryInv = New CryInv
                    Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                    Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                    Dim myExportFile As String
                    Dim myReport As New CryInv


                    'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                    'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                    myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                    myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                    myDiskFileDestinationOptions.DiskFileName = myExportFile
                    myExportOptions = myReport.ExportOptions
                    With myExportOptions
                        .DestinationOptions = myDiskFileDestinationOptions
                        .ExportDestinationType = .ExportDestinationType.DiskFile
                        .ExportFormatType = .ExportFormatType.PortableDocFormat
                    End With
                    myReport.SetDatabaseLogon("sa", "tstc123")

                    myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                    'myReport.SetParameterValue("Com", "" & com11 & "")
                    'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                    'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                    myReport.Export()
                    myReport.Close()

                    Response.Redirect("Data/Submit.PDF")


                Else



                    Dim DSS As CryTaxInvVat = New CryTaxInvVat
                    Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                    Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                    Dim myExportFile As String
                    Dim myReport As New CryTaxInvVat


                    'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                    'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                    myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                    myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                    myDiskFileDestinationOptions.DiskFileName = myExportFile
                    myExportOptions = myReport.ExportOptions
                    With myExportOptions
                        .DestinationOptions = myDiskFileDestinationOptions
                        .ExportDestinationType = .ExportDestinationType.DiskFile
                        .ExportFormatType = .ExportFormatType.PortableDocFormat
                    End With
                    myReport.SetDatabaseLogon("sa", "tstc123")

                    myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                    'myReport.SetParameterValue("Com", "" & com11 & "")
                    'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                    'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                    myReport.Export()
                    myReport.Close()

                    Response.Redirect("Data/Submit.PDF")




                End If

            End If

        Else
            If AAA = "66666" Then

                If InvVat = "Yes" Then
                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe = New CryTaxInvSpe

                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryTaxInvSpe


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")





                    Else

                        Dim DSS As CryTaxInv1 = New CryTaxInv1
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryTaxInv1


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")
                    End If
                Else

                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv1 = New CryInv1

                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryInv1


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")

                    Else

                        Dim DSS As CryTaxInvVat1 = New CryTaxInvVat1
                        CrystalReportViewer2.Visible = True

                        ' Invno1 = Invno1 = Mid(Trim(txtid.text), 1, 7)

                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryTaxInvVat1


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")

                    End If
                End If
            Else
                If InvVat = "Yes" Then

                    If Invvat1 = "Yes" Then
                        Dim DSS As CryTaxInvSpe = New CryTaxInvSpe
                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryTaxInvSpe


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")


                    Else

                        Dim DSS As CryTaxInv2 = New CryTaxInv2
                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryTaxInv2


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")

                    End If
                Else

                    If Invflag31 = "Yes" Then

                        Dim DSS As CryInv2 = New CryInv2

                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryInv2


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")



                    Else

                        Dim DSS As CryTaxInvVat2 = New CryTaxInvVat2

                        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
                        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                        Dim myExportFile As String
                        Dim myReport As New CryTaxInvVat2


                        'tradate = HttpContext.Current.Request.QueryString("Type").ToString()
                        'DT1 = HttpContext.Current.Request.QueryString("Type").ToString()

                        myExportFile = Server.MapPath(".") & "/Data/Submit.PDF"
                        myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                        myDiskFileDestinationOptions.DiskFileName = myExportFile
                        myExportOptions = myReport.ExportOptions
                        With myExportOptions
                            .DestinationOptions = myDiskFileDestinationOptions
                            .ExportDestinationType = .ExportDestinationType.DiskFile
                            .ExportFormatType = .ExportFormatType.PortableDocFormat
                        End With
                        myReport.SetDatabaseLogon("sa", "tstc123")

                        myReport.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

                        'myReport.SetParameterValue("Com", "" & com11 & "")
                        'myReport.SetParameterValue("dt1", "" & Mid(Trim(TxtFdt.Text), 4, 2) + "/" + Mid(Trim(TxtFdt.Text), 1, 2) + "/" + Mid(Trim(TxtFdt.Text), 7, 4) & "")
                        'myReport.SetParameterValue("dt2", "" & Mid(Trim(TxtTdt.Text), 4, 2) + "/" + Mid(Trim(TxtTdt.Text), 1, 2) + "/" + Mid(Trim(TxtTdt.Text), 7, 4) & "")

                        myReport.Export()
                        myReport.Close()

                        Response.Redirect("Data/Submit.PDF")

                    End If
                End If


            End If


        End If


    End Sub
End Class
