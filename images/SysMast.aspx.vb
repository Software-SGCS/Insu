Imports System.Data.OracleClient
Imports System.Data
Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim CON As OracleConnection
    Dim ADA As OracleDataAdapter
    Dim CMD As OracleCommand
    Dim DR As OracleDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As OracleCommand
    Dim RE As OracleDataReader
    Dim RE1 As OracleDataReader
    Dim SS As String
    Dim CH As Boolean
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents LstSysRno As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Txtdes2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtdes1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstSysRtp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Btnser As System.Web.UI.WebControls.Button
    Protected WithEvents BtnaddItm As System.Web.UI.WebControls.Button
    Protected WithEvents TxtRno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtrtp As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents MSG As System.Web.UI.WebControls.Label
    Dim PAG As Boolean

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Image2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Image1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents BTNADD As System.Web.UI.WebControls.Button

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

        CON = New OracleConnection("data source=XPDSS;UID=FLEET;PWD=FLEET")
        CON.Open()
        'If IsPostBack Then
        '    Txtrtp.Visible = False
        '    TxtRno.Visible = False
        '    Txtrtp.Enabled = False
        '    TxtRno.Enabled = False
        '    LstSysRtp.Enabled = False
        '    LstSysRno.Enabled = False
        'End If
        If Not IsPostBack Then
            CMD = New OracleCommand("SELECT DISTINCT SYS_RTP FROM SYSMAST", CON)
            DR = CMD.ExecuteReader
            LstSysRtp.DataSource = DR
            LstSysRtp.DataTextField = "SYS_RTP"
            LstSysRtp.DataBind()
        End If
        If Not IsPostBack Then
            CMD = New OracleCommand("SELECT DISTINCT SYS_RNO FROM SYSMAST", CON)
            DR = CMD.ExecuteReader
            LstSysRtp.DataSource = DR
            LstSysRtp.DataTextField = "SYS_RNO"
            LstSysRtp.DataBind()
        End If
        'If PAG = False Then
        '    CHKDUP = False
        '    CMD = New OracleCommand("SELECT DISTINCT SYS_RTP FROM SYSMAST", CON)
        '    DR = CMD.ExecuteReader
        '    If Not IsPostBack Then
        '        While DR.Read
        '            LstSysRtp.Items.Add(DR.GetValue(0))
        '        End While
        '    End If

        'End If


        'CMD = New OracleCommand("SELECT DISTINCT SYS_RNO FROM SYSMAST", CON)
        'DR = CMD.ExecuteReader
        'If Not IsPostBack Then
        '    While DR.Read
        '        LstSysRno.Items.Add(DR.GetValue(0))
        '    End While
        'End If

        Dim V1, V2, V3 As String
        V1 = "http://Time\Fleet\PHOTO\1.GIF"
        V2 = "http://Time\Fleet\PHOTO\2.GIF"
        V3 = "http://Time\Fleet\PHOTO\3.GIF"

        If IsDBNull(V1) = False Then
            Image1.Visible = True
            Image1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            Image2.Visible = True
            Image2.ImageUrl = V2
        End If
        If IsDBNull(V3) = False Then
            Image3.Visible = True
            Image3.ImageUrl = V3
        End If

        CON.Close()

    End Sub

    Private Sub BTNADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADD.Click
        CON.Open()
        MSG.Text = ""
        SS = ("SELECT * FROM TMP")
        CMD = New OracleCommand(SS, CON)
        DR = CMD.ExecuteReader
        Dim DD As String
        Dim DD1 As Date
        CHESYS()
        Dim RTP2 As String
        Dim RNO2 As String
        Dim Des1 As String
        Dim Des2 As String
        Dim Count As Double

        Des1 = Txtdes1.Text
        Des2 = Txtdes2.Text

        If BtnaddItm.Enabled = False Then
            RTP2 = LstSysRtp.SelectedValue
            RNO2 = LstSysRno.SelectedValue
        Else

            RTP2 = Txtrtp.Text
            RNO2 = TxtRno.Text
        End If


        If CHKDUP = False Then
            'CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO SYSMAST (SYS_RTP,SYS_RNO,SYS_DES1,SYS_DES2) VALUES (" & RTP2 & ",'" & RNO2 & "','" & Des1 & "','" & Des2 & "')")
            CMD.ExecuteNonQuery()
        Else
            CMD.CommandText = ("UPDATE SYSMAST SET SYS_DES1='" & Des1 & "',SYS_DES2='" & Des2 & "' WHERE SYS_RTP='" & RTP2 & "' AND SYS_RNO='" & RNO2 & "'")
            CMD.ExecuteNonQuery()
        End If
        Clean()
        CON.Close()
    End Sub
    Private Sub CHESYS()

        Try
            Dim RTP As String
            Dim RNO As String
            Dim Count As Double

            RTP = LstSysRtp.SelectedValue
            RNO = LstSysRno.SelectedValue

            If BtnaddItm.Enabled = False Then
                RTP = LstSysRtp.SelectedValue
                RNO = LstSysRno.SelectedValue
            Else

                RTP = Txtrtp.Text
                RNO = TxtRno.Text
            End If

            ADA = New OracleDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '" & RTP & "' AND SYS_RNO = '" & RNO & "'", CON)
            DS = New DataSet
            ADA.Fill(DS)
            Count = DS.Tables(0).Rows.Count
            If Count <> 0 Then
                CHKDUP = True

            Else
                CHKDUP = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub Btnser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnser.Click
        PAG = True
        Dim RTP As String
        Dim RNO As String
        BtnaddItm.Enabled = False
        Btnser.Visible = True
        RTP = LstSysRtp.SelectedValue
        RNO = LstSysRno.SelectedValue
        CON.Open()
        CHESYS()
        CH = True
        If CHKDUP = False Then
            Txtdes1.Text = ("")
            Txtdes2.Text = ("")
        Else
            ' 
            CMD = New OracleCommand("SELECT * FROM SYSMAST WHERE SYS_RTP = '" & RTP & "' AND SYS_RNO = '" & RNO & "'", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                Txtdes1.Text = ("" & RE.GetValue(2))
                Txtdes2.Text = ("" & RE.GetValue(3))
            End While
        End If
    End Sub



    Private Sub BtnaddItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnaddItm.Click
        Txtrtp.Visible = True
        TxtRno.Visible = True
        Txtrtp.Enabled = True
        TxtRno.Enabled = True
        LstSysRtp.Visible = False
        LstSysRno.Visible = False
        BtnEdit.Enabled = False
        Txtdes1.Text = ("")
        Txtdes2.Text = ("")
        Btnser.Visible = False
        CH = False

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Txtrtp.Visible = True
        TxtRno.Visible = True
        Txtrtp.Enabled = False
        TxtRno.Enabled = False
        LstSysRtp.Visible = True
        LstSysRno.Visible = True
        LstSysRtp.Enabled = True
        LstSysRno.Enabled = True
        BtnaddItm.Enabled = False
        Btnser.Visible = True
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("Index.aspx")
    End Sub


    Private Sub LstSysRtp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstSysRtp.SelectedIndexChanged
        CON.Open()
        If LstSysRtp.SelectedValue <> "" Then
            CMD = New OracleCommand("SELECT SYS_RTP,SYS_RNO FROM SYSMAST where SYS_RTP='" & LstSysRtp.SelectedValue & "'", CON)
            DR = CMD.ExecuteReader
            LstSysRno.DataSource = DR
            LstSysRno.DataTextField = "SYS_RNO"
            LstSysRno.DataBind()
        End If
        CON.Close()
    End Sub

    Private Sub Clean()
        If Not IsPostBack Then
            CMD = New OracleCommand("SELECT DISTINCT SYS_RTP FROM SYSMAST", CON)
            DR = CMD.ExecuteReader
            LstSysRtp.DataSource = DR
            LstSysRtp.DataTextField = "SYS_RTP"
            LstSysRtp.DataBind()
        End If
        If Not IsPostBack Then
            CMD = New OracleCommand("SELECT DISTINCT SYS_RNO FROM SYSMAST", CON)
            DR = CMD.ExecuteReader
            LstSysRtp.DataSource = DR
            LstSysRtp.DataTextField = "SYS_RNO"
            LstSysRtp.DataBind()
        End If
        Txtdes1.Text = ("")
        Txtdes2.Text = ("")
    End Sub


End Class
