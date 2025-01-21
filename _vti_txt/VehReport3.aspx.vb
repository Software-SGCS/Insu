Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO

Public Class VehReport3
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
    Dim ss, ss1 As String

    'Dim pos1 As String
    Public pos1 As String
    Dim VehNo1, VehCom1, vehrefamt1, vehbalamt1, vehsold1, Vehtyp1, Vehefdt1, Vehexdt1, Vehval1, Vehbpay1, Vehded1, Vehppre1, Vehrcc1, Vehtr1, Vehtpay, VehAllow1, VehTot1, Vehslddt1 As String
    Dim Intstk As Integer
    Dim Typ As String
    Dim AAA As String
    Dim InvVat As String
    Dim VehCom11 As String

    Dim dt1 As Date
    Dim dt2 As Date
    Dim oStream As New MemoryStream
    'Public ss As String
    Dim date1, date2, date3, date4 As Date

    Dim Count As Integer
    Dim dd1, dd2, dd3, dd4, fdate1, fdate2, fdate3, fdate4 As String
    Dim dt As Date
    Dim dtt As Date
    Dim TEXT1, TEXT2, TEXT3, ppp, ppp1 As String

    Dim dt11 As String
    Dim dt21 As String
    Dim dt3, dt31 As String
    Dim t1, t2, t3, t11, t22, t33 As String
    Dim drt2 As DataRow
    'Dim oStream As New MemoryStream
    Protected WithEvents CompanyCode As System.Web.UI.WebControls.Label
    Protected WithEvents LstCom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ImgBtn3 As System.Web.UI.WebControls.Button
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtFDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents ImgBtn1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImgBtn2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Butt1 As System.Web.UI.WebControls.Button
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents CRYSTALREPORTVIEWER2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents L1 As System.Web.UI.WebControls.Label





#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

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
        Dim PFlag, pSEC As String
        Dim COUNT1, COUNT2 As Integer

        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        ' CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()


        PFlag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        COUNT1 = DS.Tables("UsdMaster").Rows.Count


        If COUNT1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                COUNT2 = drt2("User_lvl")
                pSEC = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If





        If COUNT2 = "1" Then
            PFlag = "Y"

        Else

            If COUNT2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level2='1'", CON)

            Else
                If COUNT2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level3='1'", CON)

                Else
                    If COUNT2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level4='1'", CON)
                    Else
                        If COUNT2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PayApprovalnewM.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If

                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                PFlag = "Y"
            End While

            DR.Close()

        End If


        If PFlag = "Y" Then
            ' Response.AddHeader("Refresh", 1800)
        Else

            ' Response.Redirect("POSDispaly11.aspx")
        End If


        If Not IsPostBack Then
            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT Com_No,Com_Nam FROM Company", CON)

            DR = CMD.ExecuteReader

            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(0) + "-" + DR.GetValue(1)
                    LstCom.Items.Add(TT)
                End While
            End If
            DR.Close()



        End If

    End Sub
    Private Sub ImgBtn1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtn1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub ImgBtn2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtn2.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtFDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TxtTdt.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False

    End Sub

    Private Sub ImgBtn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBtn3.Click
        Dim DeleteCmd As String = "DELETE from VehmastTemp "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)


        dd1 = Mid(TxtFDt.Text, 4, 2) + "/" + Mid(TxtFDt.Text, 1, 2) + "/" + Mid(TxtFDt.Text, 7, 4)
        dd2 = Mid(TxtTdt.Text, 4, 2) + "/" + Mid(TxtTdt.Text, 1, 2) + "/" + Mid(TxtTdt.Text, 7, 4)

        date1 = dd1
        date2 = dd2

        fdate1 = Format(date1, "MM/dd/yyyy")
        ss1 = "Approved"
        fdate2 = Format(date2, "MM/dd/yyyy")
        fdate3 = Format(date3, "dd/MM/yyyy")
        fdate4 = Format(date4, "dd/MM/yyyy")



        ss = "Select Veh_No,Veh_Com, Veh_Typ,Format(Veh_EfDt,'dd/MM/yyyy') as Veh_EfDt, Format(Veh_Exdt,'dd/MM/yyyy') as Veh_Exdt, Veh_tpay ,Veh_val,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where (((VehMast.Veh_paydt)>=#" & fdate1 & "# And (VehMast.Veh_paydt)<=#" & fdate2 & "#) and ((VehMast.allow1)='" & ss1 & "')) order by id"

        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Label12.Visible = False
        LstCom.Visible = False
        ImgBtn3.Visible = False
        ImgBtn3.Visible = False
        TxtFDt.Visible = False
        TxtTdt.Visible = False
        'Calendar1.Visible = False
        Calendar2.Visible = False
        CompanyCode.Visible = False
        ImgBtn1.Visible = False
        ImgBtn2.Visible = False
        Butt1.Visible = False


        Dim AAA As String
        VehCom11 = Mid(Trim(LstCom.SelectedValue), 1, 3)

        ss = "SELECT * FROM VehMast WHERE ((((VehMast.Veh_Efdt)>=#" & fdate1 & "# And (VehMast.Veh_Exdt)<=#" & fdate2 & "#) and ((VehMast.allow2)='" & ss1 & "')) and (((VehMast.Veh_Com) = '" & VehCom11 & "') and ((VehMast.Sold) = 'N'))) or ((((VehMast.Veh_Efdt)>='" & fdate3 & "' And (VehMast.Veh_Exdt)<='" & fdate4 & "') and ((VehMast.allow2)='" & ss1 & "')) and (((VehMast.Veh_Com) = '" & VehCom11 & "') and ((VehMast.Sold) = 'Y')))" & " order by Id"

        ADA = New SqlDataAdapter("SELECT * FROM VehMast WHERE ((((VehMast.Veh_Efdt)>='" & fdate1 & "' And (VehMast.Veh_Exdt)<='" & fdate2 & "') and ((VehMast.allow2)='" & ss1 & "')) and (((VehMast.Veh_Com) = '" & VehCom11 & "') and ((VehMast.Sold) = 'N')))" & " order by Id", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehMast1")

        For Each Dtr1 In DS.Tables("VehMast1").Rows
            VehNo1 = Dtr1("Veh_No")
            VehCom1 = Dtr1("Veh_Com")
            Vehval1 = Dtr1("Veh_val")
            Vehbpay1 = Dtr1("Veh_bpay")
            Vehrcc1 = Dtr1("Veh_rcc")
            Vehtr1 = Dtr1("Veh_tr")
            VehTot1 = Dtr1("Veh_totChqPay")
            Vehded1 = Dtr1("Veh_Ded")
            Vehppre1 = IIf(IsDBNull(Dtr1("Veh_CertifyNo")), " ", Dtr1("Veh_CertifyNo"))
            Vehtyp1 = Dtr1("Veh_typ")
            vehrefamt1 = IIf(IsDBNull(Dtr1("Veh_refamt")), 0, Dtr1("Veh_refamt"))
            vehbalamt1 = IIf(IsDBNull(Dtr1("Veh_balamt")), 0, Dtr1("Veh_balamt"))
            vehsold1 = Dtr1("Sold")






            ''ss = "INSERT INTO VehmastTemp(VEh_no,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_TotChqPay) VALUES ('" & VehNo1 & "','" & VehCom1 & "','" & Vehval1 & "','" & Vehbpay1 & "','" & Vehded1 & "','" & Vehppre1 & "','" & Vehrcc1 & "','" & Vehtr1 & "','" & VehTot1 & "')"
            ss = "INSERT INTO VehmastTemp(Veh_no,Veh_Typ,Veh_com,Veh_val,Veh_bpay,Veh_ded,Veh_CertifyNo,Veh_rcc,Veh_tr,Veh_BalAmt,Veh_RefAmt,Sold,Veh_TotChqPay) VALUES ('" & VehNo1 & "','" & Vehtyp1 & "','" & VehCom1 & "','" & Vehval1 & "','" & Vehbpay1 & "','" & Vehded1 & "','" & Vehppre1 & "','" & Vehrcc1 & "','" & Vehtr1 & "','" & vehbalamt1 & "','" & vehrefamt1 & "','" & vehsold1 & "','" & VehTot1 & "')"
            ''ss = "INSERT INTO VehmastTemp (VEh_no,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_TotChqPay) VALUES ('" & VehNo1 & "','" & VehCom1 & "'," & Vehval1 & "," & Vehbpay1 & "," & Vehded1 & "," & Vehppre1 & "," & Vehrcc1 & "," & Vehtr1 & "," & VehTot1 & ")"


            Cmd.CommandText = (ss)
            ' 'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
            ' 'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
            Cmd.ExecuteNonQuery()

        Next
        Cmd.CommandText = ("INSERT INTO VehmastTemp(VEh_no,Veh_typ,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_TotChqPay) VALUES ('111','111','111','111','111','111','111','111','111','111')")
        Cmd.ExecuteNonQuery()


        Dim DSS As VehRep11 = New VehRep11

        CrystalReportViewer2.Visible = True

        '  Invno1 = Mid(Trim(LstCom.SelectedValue), 1, 7)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.SetParameterValue("fdt", "" & Trim(TxtFDt.Text) & "")
        DSS.SetParameterValue("tdt", "" & Trim(TxtTdt.Text) & "")

        CrystalReportViewer2.SeparatePages = True

        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False
        CrystalReportViewer2.RefreshReport()
        CrystalReportViewer2.DataBind()


        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=ABC.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()



    End Sub


    Private Sub TxtFDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFDt.TextChanged
        'TxtTdt.Text = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtFDt.Text, 4, 2) + "/" + Mid((TxtFDt.Text), 1, 2) + "/" + Mid((TxtFDt.Text), 7, 4))))

        'dt = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtFDt.Text, 4, 2) + "/" + Mid((TxtFDt.Text), 1, 2) + "/" + Mid((TxtFDt.Text), 7, 4))))
        'dtt = DateAdd(DateInterval.Day, 0, DateAdd(DateInterval.Year, -1, CDate(Mid(TxtFDt.Text, 4, 2) + "/" + Mid((TxtFDt.Text), 1, 2) + "/" + Mid((TxtFDt.Text), 7, 4))))

        'ppp = Mid(Format(dtt, "dd/MM/yyyy"), 1, 2) + "/" + Mid(Format(dtt, "dd/MM/yyyy"), 4, 2) + "/" + Mid(Format(dtt, "dd/MM/yyyy"), 7, 4)

        'TxtTdt.Text = Mid(Format(dt, "dd/MM/yyyy"), 1, 2) + "/" + Mid(Format(dt, "dd/MM/yyyy"), 4, 2) + "/" + Mid(Format(dt, "dd/MM/yyyy"), 7, 4)
        'ppp = Mid(Format(dt, "dd/MM/yyyy"), 1, 2) + "/" + Mid(Format(dt, "dd/MM/yyyy"), 4, 2) + "/" + Mid(Format(dt, "dd/MM/yyyy"), 7, 4)

        'dt = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtTdt.Text, 4, 2) + "/" + Mid((TxtTdt.Text), 1, 2) + "/" + Mid((TxtTdt.Text), 7, 4))))
        'dtt = DateAdd(DateInterval.Day, 0, DateAdd(DateInterval.Year, -1, CDate(Mid(TxtTdt.Text, 4, 2) + "/" + Mid((TxtTdt.Text), 1, 2) + "/" + Mid((TxtTdt.Text), 7, 4))))



        'ppp = Mid(Format(dtt, "dd/MM/yyyy"), 1, 2) + "/" + Mid(Format(dtt, "dd/MM/yyyy"), 4, 2) + "/" + Mid(Format(dtt, "dd/MM/yyyy"), 7, 4)

    End Sub


    Private Sub Butt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  If Not IsPostBack Then
        Dim DeleteCmd As String = "DELETE from VehmastTemp "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)



        date1 = dd1
        date2 = dd2

        fdate1 = Format(date1, "MM/dd/yyyy")
        ss1 = "Approved"
        fdate2 = Format(date2, "MM/dd/yyyy")
        ss = "Select Veh_No,Veh_Com, Veh_Typ,Format(Veh_EfDt,'dd/MM/yyyy') as Veh_EfDt, Format(Veh_Exdt,'dd/MM/yyyy') as Veh_Exdt, Veh_tpay ,Veh_val,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where (((VehMast.Veh_paydt)>=#" & fdate1 & "# And (VehMast.Veh_paydt)<=#" & fdate2 & "#) and ((VehMast.allow1)='" & ss1 & "')) order by id"

        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Label12.Visible = False
        LstCom.Visible = False
        ImgBtn3.Visible = False
        ImgBtn3.Visible = False
        TxtFDt.Visible = False
        TxtTdt.Visible = False
        ' Calendar1.Visible = False
        Calendar2.Visible = False
        CompanyCode.Visible = False
        ImgBtn1.Visible = False
        ImgBtn2.Visible = False
        Butt1.Visible = False

        Dim AAA As String
        VehCom11 = Mid(Trim(LstCom.SelectedValue), 1, 3)
        ADA = New SqlDataAdapter("SELECT * FROM VehMast WHERE (((VehMast.Veh_Efdt)>='" & fdate1 & "' And (VehMast.Veh_Exdt)<='" & fdate2 & "') and ((VehMast.allow2)='" & ss1 & "')) and ((VehMast.Veh_Com) = '" & VehCom11 & "') and ((VehMast.sold) = 'Y')" & " order by Id", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehMast1")

        For Each Dtr1 In DS.Tables("VehMast1").Rows
            VehNo1 = Dtr1("Veh_No")
            VehCom1 = Dtr1("Veh_Com")
            Vehval1 = Dtr1("Veh_val")
            Vehbpay1 = Dtr1("Veh_bpay")
            Vehrcc1 = Dtr1("Veh_rcc")
            Vehtr1 = Dtr1("Veh_tr")
            VehTot1 = Dtr1("Veh_totChqPay")
            Vehded1 = Dtr1("Veh_Ded")
            Vehppre1 = Dtr1("Veh_Ppre")
            Vehtyp1 = Dtr1("Veh_typ")
            vehrefamt1 = IIf(IsDBNull(Dtr1("Veh_refamt")), 0, Dtr1("Veh_refamt"))
            vehbalamt1 = IIf(IsDBNull(Dtr1("Veh_balamt")), 0, Dtr1("Veh_balamt"))
            vehsold1 = Dtr1("Sold")
            Vehefdt1 = Dtr1("Veh_EfDt")
            Vehexdt1 = Dtr1("Veh_Exdt")
            Vehslddt1 = IIf(IsDBNull(Dtr1("Veh_slddt")), "", Dtr1("Veh_slddt"))

            ''ss = "INSERT INTO VehmastTemp(VEh_no,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_TotChqPay) VALUES ('" & VehNo1 & "','" & VehCom1 & "','" & Vehval1 & "','" & Vehbpay1 & "','" & Vehded1 & "','" & Vehppre1 & "','" & Vehrcc1 & "','" & Vehtr1 & "','" & VehTot1 & "')"



            ss = "INSERT INTO VehmastTemp(Veh_no,Veh_Typ,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_BalAmt,Veh_RefAmt,Sold,Veh_EfDt,Veh_Exdt,Veh_slddt,Veh_TotChqPay) VALUES ('" & VehNo1 & "','" & Vehtyp1 & "','" & VehCom1 & "','" & Vehval1 & "','" & Vehbpay1 & "','" & Vehded1 & "','" & Vehppre1 & "','" & Vehrcc1 & "','" & Vehtr1 & "','" & vehbalamt1 & "','" & vehrefamt1 & "','" & vehsold1 & "','" & Vehefdt1 & "','" & Vehexdt1 & "','" & Vehslddt1 & "','" & VehTot1 & "')"
            ''ss = "INSERT INTO VehmastTemp (VEh_no,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_TotChqPay) VALUES ('" & VehNo1 & "','" & VehCom1 & "'," & Vehval1 & "," & Vehbpay1 & "," & Vehded1 & "," & Vehppre1 & "," & Vehrcc1 & "," & Vehtr1 & "," & VehTot1 & ")"

            Cmd.CommandText = (ss)
            ' 'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
            ' 'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
            Cmd.ExecuteNonQuery()

        Next
        Cmd.CommandText = ("INSERT INTO VehmastTemp(VEh_no,Veh_typ,Veh_com,Veh_val,Veh_bpay,Veh_ded,veh_ppre,Veh_rcc,Veh_tr,Veh_TotChqPay) VALUES ('111','111','111','111','111','111','111','111','111','111')")
        Cmd.ExecuteNonQuery()


        Dim DSS As VehRep3 = New VehRep3

        CrystalReportViewer2.Visible = True

        '  Invno1 = Mid(Trim(LstCom.SelectedValue), 1, 7)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

        CrystalReportViewer2.SeparatePages = True

        CrystalReportViewer2.ReportSource = DSS

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False
        CrystalReportViewer2.RefreshReport()
        CrystalReportViewer2.DataBind()

        DSS.Refresh()

        ' End If
    End Sub

    Private Sub Butt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butt1.Click
        'Dim DeleteCmd As String = "DELETE from VehmastTemp "
        'Dim Cmd As New SqlCommand(DeleteCmd, CON)


        dd1 = Mid(TxtFDt.Text, 4, 2) + "/" + Mid(TxtFDt.Text, 1, 2) + "/" + Mid(TxtFDt.Text, 7, 4)
        dd2 = Mid(TxtTdt.Text, 4, 2) + "/" + Mid(TxtTdt.Text, 1, 2) + "/" + Mid(TxtTdt.Text, 7, 4)
        date1 = dd1
        date2 = dd2

        ' fdate1 = Format(date1, "MM/dd/yyyy")

        'ss1 = "Approved"
        'fdate2 = Format(date2, "MM/dd/yyyy")
        ' ss = "Select Veh_No,Veh_Com, Veh_Typ,Format(Veh_EfDt,'dd/MM/yyyy') as Veh_EfDt, Format(Veh_Exdt,'dd/MM/yyyy') as Veh_Exdt, Veh_tpay ,Veh_val,ALLOW2,Veh_bpay,Veh_rcc,Veh_tr from VehMast where (((VehMast.Veh_paydt)>='" & fdate1 & "' And (VehMast.Veh_paydt)<='" & fdate2 & "') and ((VehMast.allow1)='" & ss1 & "'))"

        CMD.ExecuteNonQuery()
        CMD = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = CMD.ExecuteReader
        DR1.Close()
        Label1.Visible = False
        Label12.Visible = False
        LstCom.Visible = False
        ImgBtn3.Visible = False
        ImgBtn3.Visible = False
        TxtFDt.Visible = False
        TxtTdt.Visible = False
        'Calendar1.Visible = False
        Calendar2.Visible = False
        CompanyCode.Visible = False
        ImgBtn1.Visible = False
        ImgBtn2.Visible = False
        Butt1.Visible = False




        Dim DSS1 As VehClaim1 = New VehClaim1

        CrystalReportViewer2.Visible = True

        '  Invno1 = Mid(Trim(LstCom.SelectedValue), 1, 7)
        ss = Mid(Trim(LstCom.SelectedItem.Text), 1, 3)
        'DSS.SetDatabaseLogon("sa", "tstc123")
        ss = Trim(TxtFDt.Text)
        ss = Trim(TxtTdt.Text)
        fdate1 = Format(date1, "MM/dd/yyyy")

        'ss1 = "Approved"
        fdate2 = Format(date2, "MM/dd/yyyy")

        DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS1.SetParameterValue("com11", "" & Mid(Trim(LstCom.SelectedItem.Text), 1, 3) & "")
        DSS1.SetParameterValue("dt1", "" & fdate1 & "")
        DSS1.SetParameterValue("dt2", "" & fdate2 & "")

        CrystalReportViewer2.ReportSource = DSS1

        CrystalReportViewer2.HasRefreshButton = False
        CrystalReportViewer2.HasZoomFactorList = False
        CrystalReportViewer2.HasPageNavigationButtons = False
        CrystalReportViewer2.HasDrillUpButton = False
        CrystalReportViewer2.RefreshReport()
        CrystalReportViewer2.DataBind()

        oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=ABC.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()
   

    End Sub

    Private Sub TxtTdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTdt.TextChanged

    End Sub
End Class
