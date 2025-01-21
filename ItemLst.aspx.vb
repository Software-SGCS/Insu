Imports System.Data.Sqlclient
Imports System.Data

Public Class ItemLst
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD, cat1 As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim Dtr, Dtr1 As DataRow
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    'Dim pos1 As String
    Public pos1 As String
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1 As String
    Dim Intstk As Integer
    Dim Typ As String
    Protected WithEvents LstId1 As System.Web.UI.WebControls.DropDownList
    Dim Count As Integer
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList
    Protected WithEvents CRYSTALREPORTVIEWER2 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

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
        CRYSTALREPORTVIEWER2.Visible = False
        CrystalReportViewer1.Visible = False

        If Not IsPostBack Then
            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT SYS_Rno,Sys_des1 FROM SYSMAST WHERE SYS_RTP = '01'", CON)

            DR1 = CMD.ExecuteReader

            If Not IsPostBack Then


                While DR1.Read
                    TT = DR1.GetValue(0) + "-" + DR1.GetValue(1)
                    LstId1.Items.Add(TT)
                End While
            End If
            DR1.Close()



        End If

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
        LstId.Visible = False

        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & LstId.SelectedValue & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Dtr1("Inv_dt")
            InvPono1 = Dtr1("Inv_pono")
            ' InvFlag11 = Dtr1("Inv_Flag1")

            ADA = New SqlDataAdapter("SELECT * FROM InlInv WHERE Inv_no = '" & Invno1 & "'", CON)
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




        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()
        ' Label1.Visible = False
        'Button1.Visible = False
        'LstId.Visible = False


        Dim DSS As CryItem = New CryItem
        CrystalReportViewer1.Visible = True

        cat1 = Mid(LstId1.SelectedValue, 1, 2)

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.Paper11x17
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
        DSS.SetParameterValue("Cat", "" & Trim(cat1) & "")


        CrystalReportViewer1.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = False
        CrystalReportViewer1.HasZoomFactorList = False
        CrystalReportViewer1.HasPageNavigationButtons = False
        CrystalReportViewer1.HasDrillUpButton = False
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.DataBind()

        DSS.Refresh()
    End Sub
End Class
