Imports System.Data.OleDb
Imports System.Data

Public Class CrsTaxInvoice
    Inherits System.Web.UI.Page
    Dim CON As OleDbConnection

    Dim ADA As OleDbDataAdapter
    Dim CMD As OleDbCommand
    Dim DR, DR1 As OleDbDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As OleDbCommand
    Dim RE As OleDbDataReader
    Dim RE1 As OleDbDataReader
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
    Dim Typ As String
    Dim AAA As String
    Dim InvVat As String
    Dim InvNo11 As String


    Dim Count As Integer
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents CrystalReportViewer2 As CrystalDecisions.Web.CrystalReportViewer





#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList
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
        CON = New OleDbConnection
        CON.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
        CON.Open()


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New OleDbCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='CrsTaxInvoice.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            Response.Redirect("InsuDept.aspx")
        End If


        If Not IsPostBack Then
            Dim TT As String
            pos1 = "N"
            'CMD = New OleDbCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New OleDbCommand("SELECT Inv_no,Inv_com FROM InhInv where inv_flag2='Approved' order by Inv_no", CON)

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

        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New OleDbCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New OleDbCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        LstId.Visible = False
        Button4.Visible = False
        Button3.Visible = False

        InvNo11 = Mid(Trim(LstId.SelectedValue), 1, 7)
        ADA = New OleDbDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Dtr1("Inv_dt")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            ' InvFlag11 = Dtr1("Inv_Flag1")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")

            InvTt1 = Dtr1("Inv_TT")

            ADA = New OleDbDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New OleDbDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
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
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111',#01/01/2006#,'111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "44444" Then


            If InvVat = "Yes" Then


                Dim DSS As CryTaxInv = New CryTaxInv

                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                DSS.SetDatabaseLogon("", "")
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

                    Dim DSS As CryInv = New CryInv

                    CrystalReportViewer2.Visible = True

                    Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                    Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                Dim DSS As CryTaxInv1 = New CryTaxInv1
                CrystalReportViewer2.Visible = True

                Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                DSS.SetDatabaseLogon("", "")
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

                    Dim DSS As CryInv1 = New CryInv1

                    CrystalReportViewer2.Visible = True

                    Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                    Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'crReportDocument.SetDatabaseLogon("USER", "PASSWORD", "SQL-SERVER", "DATABASE")
        'crReportDocument.PrintToPrinter(1, False, 0, 0)
        Try
            Button2.Visible = False
            LstId.Visible = False


            Dim DeleteCmd As String = "DELETE from TempInv "
            Dim Cmd As New OleDbCommand(DeleteCmd, CON)
            Cmd.ExecuteNonQuery()
            Cmd = New OleDbCommand("SELECT * FROM SYSMAST", CON)
            DR1 = Cmd.ExecuteReader
            DR1.Close()


            ADA = New OleDbDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & LstId.SelectedValue & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "INHINV1")

            For Each Dtr1 In DS.Tables("INHINV1").Rows
                Invno1 = Dtr1("Inv_No")
                InvCom1 = Dtr1("Inv_Com")
                Invdt1 = Dtr1("Inv_dt")
                InvPono1 = Dtr1("Inv_pono")
                ' InvFlag11 = Dtr1("Inv_Flag1")
                InvVat = Dtr1("Inv_Vat")
                ADA = New OleDbDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "InlInv1")

                For Each Dtr In DS.Tables("InlInv1").Rows
                    InvItmNo1 = Dtr("Inv_ItmNo")
                    InvQty1 = Dtr("Inv_Qty")
                    InvVal1 = Dtr("Inv_val")
                    InvPri1 = Dtr("Inv_Pri")

                    Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "')")
                    Cmd.ExecuteNonQuery()

                Next

            Next

            Dim DSS As CryTaxInv = New CryTaxInv
            CrystalReportViewer2.Visible = True

            Invno1 = LstId.SelectedValue

            DSS.SetDatabaseLogon("", "")
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
        Dim Cmd As New OleDbCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New OleDbCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        LstId.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        InvNo11 = Mid(Trim(LstId.SelectedValue), 1, 7)
        ADA = New OleDbDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Dtr1("Inv_dt")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")
            InvTt1 = Dtr1("Inv_TT")

            ADA = New OleDbDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New OleDbDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
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
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111',#01/01/2006#,'111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next

        If AAA = "44444" Then

            If InvVat = "Yes" Then

                Dim DSS As CryTaxInvA = New CryTaxInvA

                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                DSS.SetDatabaseLogon("", "")
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

                    Dim DSS As CryInvA = New CryInvA

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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
                Dim DSS As CryTaxInv1A = New CryTaxInv1A
                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                DSS.SetDatabaseLogon("", "")
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

                    Dim DSS As CryInv1A = New CryInv1A

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New OleDbCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New OleDbCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Button1.Visible = False
        LstId.Visible = False
        Button4.Visible = False
        Button3.Visible = False


        Dim AAA As String
        InvNo11 = Mid(Trim(LstId.SelectedValue), 1, 7)
        ADA = New OleDbDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & InvNo11 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Dtr1("Inv_dt")
            InvPono1 = Dtr1("Inv_pono")
            AAA = Dtr1("Inv_Code")
            InvVat = Dtr1("Inv_Vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")

            InvTt1 = Dtr1("Inv_TT")

            ADA = New OleDbDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")

            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_Dis")


                ADA = New OleDbDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
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
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & InvTt1 & "','" & Invdis1 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111',#01/01/2006#,'111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "44444" Then

            If InvVat = "Yes" Then

                Dim DSS As CryTaxInvB = New CryTaxInvB

                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                DSS.SetDatabaseLogon("", "")
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

                    Dim DSS As CryInvB = New CryInvB

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                Dim DSS As CryTaxInv1B = New CryTaxInv1B
                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                DSS.SetDatabaseLogon("", "")
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

                    Dim DSS As CryInv1B = New CryInv1B

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

                    DSS.SetDatabaseLogon("", "")
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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)
                    DSS.SetDatabaseLogon("", "")
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



    End Sub

    Private Sub LstId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstId.SelectedIndexChanged

    End Sub
End Class
