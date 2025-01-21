Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Configuration



Public Class NewApp4
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS, ds1 As DataSet
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
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1, Invtt1 As String
    Dim Intstk As Integer
    Dim Typ, BODY As String
    Dim AAA As String
    Dim InvVat As String
    Dim InvNo11 As String
    Dim customerId As String

    Dim Count As Integer
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents Image3 As System.Web.UI.WebControls.Image
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Image5 As System.Web.UI.WebControls.Image
    Protected WithEvents Image6 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtInvNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Image7 As System.Web.UI.WebControls.Image
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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        If Not IsPostBack Then
            InvNo11 = HttpContext.Current.Request.QueryString("Type").ToString()
            'customerId = Val(InvNo11)
            'InvNo11 = "T-00507"
            TxtInvNo.Text = InvNo11
            '-------------------
            Dim DeleteCmd As String = "DELETE from TempInv "
            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            Cmd.ExecuteNonQuery()
            Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
            DR1 = Cmd.ExecuteReader
            DR1.Close()
            ' Label1.Visible = False
            'Button1.Visible = False
            'LstId.Visible = False
            'Button4.Visible = False
            'Button3.Visible = False

            'InvNo11 = Mid(Trim(LstId.SelectedValue), 1, 7)
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
                Invtt1 = Dtr1("Inv_tt")
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
                    Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_tt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & Invtt1 & "','" & Invdis1 & "')")
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

                        Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                        Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                            Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                            Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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
                            Dim DSS As CryTaxInvSpe1 = New CryTaxInvSpe1

                            CrystalReportViewer2.Visible = True

                            Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                            Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                                Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                                Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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
                            Dim DSS As CryTaxInvSpe2 = New CryTaxInvSpe2

                            CrystalReportViewer2.Visible = True

                            Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                            Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                                Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                                Invno1 = Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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
        End If



        '--------------------



        If Not IsPostBack Then
            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            Cmd = New SqlCommand("SELECT Inv_no,Inv_com FROM InhInv where inv_flag2='Approved'", CON)

            DR = Cmd.ExecuteReader

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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim strfg As String

        Dim cmdCustomers As SqlCommand
        Dim strInvNo As String
        Dim dr1, dr2 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String
        Dim StrInvcom, Strdt, strtotval, strtotqty, StrInvCode As String

        ADA = New SqlDataAdapter("SELECT * FROM InhInv WHERE Inv_No='" & TxtInvNo.Text & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "InhInv")

        Count1 = DS.Tables("InhInv").Rows.Count
        If Count1 <> 0 Then
            For Each dr1 In DS.Tables("InhInv").Rows
                strInvNo = dr1("Inv_no")
                StrInvcom = dr1("Inv_Com")
                Strdt = Format(dr1("Inv_dt"), "MM/dd/yyyy")
                strtotval = dr1("Inv_totval")
                strtotqty = dr1("Inv_totQty")
                StrInvCode = dr1("Inv_Code")
            Next
        End If

        strfg = "Approved"
        strSql = "UPDATE InhInv SET Inv_Flag1='" & strfg & "',Inv_Flag2= 'Select'" & " WHERE Inv_Flag1='Select' and Inv_No='" & strInvNo & "'"
        cmdCustomers = New SqlCommand(strSql, CON)
        ' objConn.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        ADA1 = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '33333'", CON)
        ds1 = New DataSet
        ADA1.Fill(ds1, "EmpMast")

        Count1 = ds1.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each dr2 In ds1.Tables("EmpMast").Rows
                str_no = dr2("Emp_no")
                str_name = dr2("Emp_name")
                str_mail = dr2("Emp_email")
            Next
        End If

        BODY += "<table width='1000' border='0'>"
        BODY += "<tr>"
        BODY += "<td width='218' height='40'><form id='form3' name='form3' method='post' action=''>"
        BODY += "<label></label>"
        BODY += "<label></label>"
        BODY += "<label></label>"
        BODY += "<label>"
        BODY += "<input type='image' name='imageField3' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/imgs/logo.cnn.com.gif' />"
        BODY += "</label>"
        BODY += "</form>    </td>"
        BODY += "<td width='750'><form id='form2' name='form2' method='post' action=''>"
        BODY += "<label></label>"
        BODY += "<label></label>"
        BODY += "<label></label>"
        BODY += "<input type='image' name='imageField' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/BANNER.jpg' />"
        BODY += "</form>    </td>"
        BODY += "<td width='154'>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "<tr>"
        BODY += "<td height='174'><form id='form4' name='form4' method='post' action=''>"
        BODY += "<label>"
        BODY += "<input type='image' name='imageField2' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/Audit.gif' />"
        BODY += "</label>"
        BODY += "</form>    </td>"
        BODY += "<td><form id='form1' name='form1' method='post' action=''>"
        BODY += "<table width='525' height='126' border='0'>"
        BODY += "<tr>"
        BODY += "<td height='33'><label>Invoice No</label></td>"
        BODY += "<td>" & strInvNo & "</td>"
        BODY += "<td>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "<tr>"
        BODY += "<td width='155' height='30'><label>Company</label></td>"
        BODY += "<td width='169'>" & StrInvcom & "</td>"
        BODY += "<td width='187'>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "<tr>"
        BODY += "<td height='25'><label>Total Value</label></td>"
        BODY += "<td>" & strtotval & "</td>"
        BODY += "<td>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "<tr>"
        BODY += "<td height='28'><label>Total Qty </label></td>"
        BODY += "<td>" & strtotqty & "</td>"
        BODY += "<td>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "<tr>"
        BODY += "<td height='28'><label>Invoice Date </label></td>"
        BODY += "<td>" & Strdt & "</td>"
        BODY += "<td>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "<tr>"
        BODY += "<td height='28'><label>Created By </label></td>"
        BODY += "<td>" & StrInvCode & "</td>"
        BODY += "<td>&nbsp;</td>"
        BODY += "</tr>"
        BODY += "</table>"
        BODY += "<label></label>"
        BODY += "<label></label>"
        BODY += "</form>    </td>"
        BODY += "<td>&nbsp;</td>"
        BODY += "</tr>"
        BODY += " <tr><td align='left' colSpan='2'><table width='200' border='0'>"
        BODY += "<tr>"
        BODY += "<td><form method='post' action=http://sgcsser/Insu/NewApp2.aspx?TYPE=" & TxtInvNo.Text & " name='frm1'><input name='sbb1' type='image' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/approve.jpg' width='100' height='30'> </form></td>"
        BODY += "<td><form method='post' action=http://sgcsser/Insu/InvApproval.aspx name='frm1'><input name='sbb1' type='image' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu\ApproveAll.jpg' width='100' height='30'> </form></td>"
        BODY += "</tr>"
        BODY += "</table>"
        BODY += "</td>"
        BODY += "<td align='left' colSpan='2'>&nbsp;</td>"
        BODY += "<td width='163' colSpan='3' align='left'>&nbsp;</td>"
        BODY += "<td></td>"
        BODY += "</tr>"
        BODY += "</table>"

        'TxtNam.Text = dr1("Emp_Name")
        'TxtToLv.Text = dr1("Emp_ToLv")
        'TxtTaLv.Text = dr1("Emp_TaLv")
        'TxtCntNo.Text = dr1("Emp_CntNo")
        ' cmdCustomers.Connection = objConn
        Dim SS As String
        ' SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
        '''cmdCustomers = New SqlCommand(SS, objConn)
        '''objConn.Open()
        '''cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)








        Dim emailMessage As MailMessage
        emailMessage = New MailMessage
        emailMessage.From = "insurance@dsisamson.com"
        emailMessage.To = "chamindas@dsisamson.com"
        ''emailMessage.To = "palithan@samsoncorporates.com"
        emailMessage.Subject = "Inv No :" + strInvNo + " " + StrInvcom + " " + " Inv Date :" + Strdt + " For Your Approval" + " "

        emailMessage.Body = BODY

        emailMessage.BodyFormat = MailFormat.Html

        SmtpMail.SmtpServer = "mail.dsisamson.com"
        Try
            SmtpMail.Send(emailMessage)
            'labelStatus.Text = "Message sent!"
            'Button1.Enabled = False
        Catch ex As Exception
            'labelStatus.Text="Unable to send the e-mail message"
            ' labelStatus.Text = ex.ToString
        End Try






    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'crReportDocument.SetDatabaseLogon("USER", "PASSWORD", "SQL-SERVER", "DATABASE")
        'crReportDocument.PrintToPrinter(1, False, 0, 0)
        Try
            Button2.Visible = False
            LstId.Visible = False


            Dim DeleteCmd As String = "DELETE from TempInv "
            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            Cmd.ExecuteNonQuery()
            Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
            DR1 = Cmd.ExecuteReader
            DR1.Close()


            ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & LstId.SelectedValue & "'", CON)
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

                    Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "')")
                    Cmd.ExecuteNonQuery()

                Next

            Next

            Dim DSS As CryTaxInv = New CryTaxInv
            CrystalReportViewer2.Visible = True

            Invno1 = LstId.SelectedValue

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
        LstId.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        InvNo11 = Mid(Trim(LstId.SelectedValue), 1, 7)
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

            ' InvFlag11 = Dtr1("Inv_Flag1")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InlInv1")
            For Each Dtr In DS.Tables("InlInv1").Rows
                InvItmNo1 = Dtr("Inv_ItmNo")
                InvQty1 = Dtr("Inv_Qty")
                InvVal1 = Dtr("Inv_val")
                InvPri1 = Dtr("Inv_Pri")
                Invdis1 = Dtr("Inv_dis")

                ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '01' AND SYS_RNO='" & Mid(InvItmNo1, 1, 2) & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "SYSMAST1")

                Dim InvCat As String
                For Each dtr2 In DS.Tables("SYSMAST1").Rows

                    InvCat = dtr2("Sys_des1")

                Next
                Dim invqty11 As String

                invqty11 = Format(Val(InvQty1), "000")
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "55555" Then

            If InvVat = "Yes" Then

                Dim DSS As CryTaxInvA = New CryTaxInvA

                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                    Dim DSS As CryInvA = New CryInvA

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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
                    Dim DSS As CryTaxInv1A = New CryTaxInv1A
                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                        Dim DSS As CryInv1A = New CryInv1A

                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                        Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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
                    Dim DSS As CryTaxInv2A = New CryTaxInv2A
                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                        Dim DSS As CryInv2A = New CryInv2A

                        CrystalReportViewer2.Visible = True

                        Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                        Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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
        LstId.Visible = False
        Button4.Visible = False
        Button3.Visible = False


        Dim AAA As String
        InvNo11 = Mid(Trim(LstId.SelectedValue), 1, 7)
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

            ' InvFlag11 = Dtr1("Inv_Flag1")

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
                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "','" & Mid(Invdt1, 1, 2) + "/" + Mid(Invdt1, 4, 2) + "/" + Mid(Invdt1, 7, 4) & "','" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111','01/01/2006','111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()

        Next


        If AAA = "44444" Then

            If InvVat = "Yes" Then

                Dim DSS As CryTaxInvB = New CryTaxInvB

                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                    Dim DSS As CryInvB = New CryInvB

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                Dim DSS As CryTaxInv1B = New CryTaxInv1B
                CrystalReportViewer2.Visible = True

                Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                    Dim DSS As CryInv1B = New CryInv1B

                    CrystalReportViewer2.Visible = True

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)

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

                    Invno1 = Mid(Trim(LstId.SelectedValue), 1, 7)
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



    End Sub
End Class
