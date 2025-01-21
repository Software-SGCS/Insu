Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class Email1
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim Dtr, Dtr1, dtr2 As DataRow
    Dim Invno1, InvCom1, Invdt1, InvFlag11, InvPono1, InvItmNo1, InvQty1, InvVal1, InvPri1, Invvat1, Invdis1, Invflag31, invper1 As String

    Dim dt1 As Date
    Dim dt2 As Date
    Dim ss, ss1 As String
    'Public ss As String
    Dim date1 As Date
    Dim date2 As Date
    Dim dd1, dd2, fdate1, fdate2 As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ImgBttn As System.Web.UI.WebControls.ImageButton

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
    End Sub

    Private Sub ImgBttn_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBttn.Click
        Dim cmdCustomers As SqlCommand
        Dim strid As String = "00001" 'TxtInvNo.Text'
        Dim DeleteCmd As String = "DELETE from TempInv "
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.ExecuteNonQuery()
        Cmd = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd.ExecuteReader
        DR1.Close()


        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & strid & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV1")

        For Each Dtr1 In DS.Tables("INHINV1").Rows
            Invno1 = Dtr1("Inv_No")
            InvCom1 = Dtr1("Inv_Com")
            Invdt1 = Dtr1("Inv_dt")
            InvPono1 = Dtr1("Inv_pono")
            ' InvFlag11 = Dtr1("Inv_Flag1")


            Invvat1 = Dtr1("Inv_vat")
            Invflag31 = Dtr1("Inv_flag3")
            invper1 = Dtr1("Inv_per")

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

                Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt,Inv_flag3,Inv_per,Inv_dis) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "','" & Invflag31 & "','" & invper1 & "','" & Invdis1 & "')")
                'Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri,Inv_cat,Inv_qtyt) VALUES ('" & Invno1 & "','" & InvCom1 & "',#" & Invdt1 & "#,'" & InvFlag11 & "','" & InvPono1 & "','" & InvItmNo1 & "','" & InvQty1 & "','" & InvVal1 & "','" & InvPri1 & "','" & InvCat & "','" & invqty11 & "')")
                Cmd.ExecuteNonQuery()

            Next
            Cmd.CommandText = ("INSERT INTO TempInv (Inv_no,Inv_Com,Inv_dt,Inv_flag1,Inv_pono,Inv_ItmNo,Inv_Qty,Inv_val,Inv_pri) VALUES ('111','111',#01/01/2006#,'111','111','111','111','111','111')")
            Cmd.ExecuteNonQuery()
        Next

        If Invvat1 = "No" Then
            If Invflag31 = "Yes" Then
                Dim strReport As String = ""
                strReport = "PopView5.aspx"
                Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=700,left=100,top=300,scrollbars=yes,status=no');<" & "/script>"
                Page.RegisterStartupScript("OpenWindow", strJS)



            Else
                Dim strReport As String = ""
                strReport = "PopView2.aspx"
                Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=700,left=100,top=300,scrollbars=yes,status=no');<" & "/script>"
                Page.RegisterStartupScript("OpenWindow", strJS)
            End If




        Else

            Dim strReport As String = ""
            strReport = "PopView1.aspx"
            'Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=520,width=700,left=100,top=50,scrollbars=yes,status=no');<" & "/script>"

            Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=900,width=750,left=10,top=10,scrollbars=yes,status=no');<" & "/script>"
            Page.RegisterStartupScript("OpenWindow", strJS)
        End If

    End Sub
End Class
