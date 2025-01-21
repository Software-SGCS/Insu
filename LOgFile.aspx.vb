Imports System.Data.OracleClient
Imports System.Data
Public Class LOgFile

    Inherits System.Web.UI.Page
    'Dim CON As OracleConnection
    Dim OBJ1 As New WORD
    Dim ADA As OracleDataAdapter
    Dim CMD As OracleCommand
    Dim DR As OracleDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim SS, SS1, CO, FID, FID1, V2, V1 As String
    Dim COUNT As Double
    Dim te_frddt, te_toddt, te_frddt1, te_toddt1 As Date
    Dim DD1, DD2 As String
    Dim DSS As CrystalReport1 = New CrystalReport1
    Dim te_flag As Boolean
    Dim I, J, L As Integer
    Protected WithEvents txtLOC As System.Web.UI.WebControls.TextBox
    Protected WithEvents Cal2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Cal1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TXTFDATE As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TXTTDATE As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Image1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Image2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
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
        'CON = New OracleConnection("data source=XPDSS;UID=POS;PWD=POS")
        'CON.Open()
        OBJ1.ConnectDBH()
        V1 = "http://192.168.12.133\POS\PHOTO\HOME.jpg"
        V2 = "http://192.168.12.133\POS\PHOTO\mail.gif"

        If IsDBNull(V1) = False Then
            Image1.Visible = True
            Image1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            Image2.Visible = True
            Image2.ImageUrl = V2
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            SS = (Server.MapPath("." & "\" & "logo" & ".jpg"))
            FID = "ADMIN"
            If TXTFDATE.Text <> "" And TXTTDATE.Text <> "" Then

                DD1 = Mid((TXTFDATE.Text), 4, 2) & "/" & Mid((TXTFDATE.Text), 1, 2) & "/" & Right((TXTFDATE.Text), 4)
                DD2 = Mid((TXTTDATE.Text), 4, 2) & "/" & Mid((TXTTDATE.Text), 1, 2) & "/" & Right((TXTTDATE.Text), 4)
                te_frddt = (DD1)
                te_toddt = (DD2)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")
            End If
            'SS = "SELECT ID AS USERCODE,TIME AS LOGIN TIME,LOGDATE AS LOGIN DATE from LOG WHERE "
            SS = "SELECT ID AS USERCODE,TIME AS LOGINTIME,LOGDATE from LOG WHERE "
            'SS = "SELECT * FROM LOG WHERE "

            If txtLOC.Text <> "" Then
                SS = SS & "ID = '" & txtLOC.Text & "' and "
            Else
                SS = SS
            End If

            If IsDate(DD1) And IsDate(DD2) Then
                SS = SS & "LOGDATE >= '" & Format(te_frddt, "dd/MMM/yyyy") & "' and "
                SS = SS & "LOGDATE <= '" & Format(te_toddt, "dd/MMM/yyyy") & "' AND "
            Else
                SS = SS
            End If

            SS = SS & "ID <> '" & FID & "' order by ID,LOGDATE,TIME"

            'SS = "SELECT NAM2,LTRIM(SUBSTR(NAM1,9,15)) AS NNNNNNNNN,NAM3,SUM(L1) AS SA,SUM(S1) AS ST, SUM(L2) AS SA,SUM(S2) AS ST, SUM(L3) AS SA,SUM(S3) AS ST, SUM(L4) AS SA,SUM(S4) AS ST, SUM(L5) AS SA,SUM(S5) AS ST, SUM(L6) AS SA,SUM(S6) AS ST, SUM(L7) AS SA,SUM(S7) AS ST, SUM(L8) AS SA,SUM(S8) AS ST, SUM(L9) AS SA,SUM(S9) AS ST, SUM(L10) AS SA,SUM(S10) AS ST, SUM(L11) AS SA,SUM(S11) AS ST, SUM(L12) AS SA,SUM(S12) AS ST FROM TMPFILA5 WHERE UNAME='ADMIN' GROUP BY ROLLUP (NAM2,NAM3,LTRIM(SUBSTR(NAM1,9,15))) "

            ADA = New OracleDataAdapter(SS, OBJ1.CONH)
            DS = New DataSet
            ADA.Fill(DS)
            DataGrid1.DataSource = DS
            DataGrid1.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub

    Private Sub Image1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image1.Click
        Response.Redirect("MainMenu.aspx")
    End Sub

    Private Sub Image2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image2.Click
        Response.Redirect("Email.aspx")
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Calendar1.Visible = True
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Calendar2.Visible = True
    'End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TXTTDATE.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TXTFDATE.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound
        'e.Item.Cells[1].Text = "Total Sales";
        '	e.Item.Cells[1].Attributes.Add("align", "left");
        '	e.Item.Cells[2].Attributes.Add("align", "right");
        '	e.Item.Cells[2].Text = myTotal.ToString("c");

        'If e.Item.Cells(1).Text = "0" Then e.Item.Cells(1).Text = ""
        'e.Item.Cells(1).Text.c()
        'e.Item.Cells(0).Text = myTotal.ToString("c");
        'DD1 = Mid((TXTFDATE.Text), 4, 2) & "/" & Mid((TXTFDATE.Text), 1, 2) & "/" & Right((TXTFDATE.Text), 4)
        'e.Item.Cells[2].Text = Convert.ToDouble(e.Item.Cells[2].Text).ToString("##,##0.00");

        If IsDate(e.Item.Cells(2).Text) Then
            e.Item.Cells(2).Text = Format(CDate(e.Item.Cells(2).Text), "dd/MMM/yyyy") '.ToString("dd/MMM/yyyy")

        End If
        'Dim Cells() As DataColumn

        'For Each Cells As DataRow In Cells
        'For Each Cell As DataColumn In Cells
        '    e.Item.Cells(1).Text = Format(e.Item.Cells(1).Text, "dd/MMM/yyyy")
        'Next

        'Dim i As System.Drawing.Image = _
        '    System.Drawing.Image.FromFile(Server.MapPath("." & "\" & "biglogo" & ".jpg"))

    End Sub

    Private Sub Cal1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Cal1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub Cal2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Cal2.Click
        Calendar2.Visible = True
    End Sub
End Class
