Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Data.OleDb

Public Class SgcsVeh

    Inherits System.Web.UI.Page
    Dim V, V1, V2, V3, V4, V5, V6 As String
    Dim M As Integer
    Dim _refreshState, _isRefresh As Boolean
    Dim Body As String

    Dim COUNT, COUNT1, COUNT2 As Integer

    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim Conn As OleDbConnection
    Dim ADADB, ADADB1 As OleDbDataAdapter
    Dim CMDDB As OleDbCommand
    Dim DRDB, DR1DB, dr2DB, dr3DB As OleDbDataReader
    Dim REDB As OleDbDataReader
    Dim ADA, ADA1, ADA2 As SqlDataAdapter
    Dim CMD, CMD1, CMD2, CMD3 As SqlCommand
    'Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2, DS3 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim dr1, dr2, DR3, DR4 As DataRow
    Dim RE As SqlDataReader
    Dim RE1, RE2, RE3 As SqlDataReader
    Public ss As String
    Public PVehno As String
    '  Dim dr1, dr2, DR3, DR4 As DataRow
    Dim pppp As String
    Dim Todt As String
    Dim Empno, EmpCom, EmpAmt, EmpPayDt, EmpTyp, EmpDecAmt, EmpChqNo, EmpCno As String
    Dim ans1, ans2 As String
    Dim totamt As Double
    Dim sCOM, sEPFNO, SCNam, STEmail, SChqNo As String
    Dim sp1, sp2, sp3, sp4, sp6 As String

    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents TEXTAREA1 As System.Web.UI.HtmlControls.HtmlTextArea
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton7 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton9 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton11 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton12 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton13 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton14 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton16 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents LinkButton17 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton15 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Btt1 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel10 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel11 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel12 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel13 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel14 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel

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

        If Not IsPostBack Then
            M = 1
        End If

        Global.PwFlag = "N"
    End Sub

    Private Sub TEXTAREA1_ServerChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.TextChanged
        Global.PUserId = TxtId.Text
        ss = TxtId.Text
        ss = Global.PUserId
        Dim uid As String
        uid = TxtId.Text
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")

        CON.Open()
        'Response.Redirect("ABC.aspx?UID=" & TxtId.Text & "")
        'ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_USER = '" & Global.PUserId & "'", CON)
        'DS = New DataSet
        'ADA.Fill(DS, "ADMIN")

        'COUNT = DS.Tables("ADMIN").Rows.Count


        'If COUNT <> 0 Then
        'For Each dr1 In DS.Tables("ADMIN").Rows

        ' Global.PNam = dr1("AD_NAM")
        ' Global.Ppwd = dr1("AD_PWD")
        ' Global.PEmail = dr1("AD_NAM")
        ' Global.PwLevel = dr1("AD_Level")
        ' TxtNam.Text = Global.PNam

        ' Next
        '  End If

        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & Global.PUserId & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        COUNT = DS.Tables("UsdMaster").Rows.Count


        If COUNT <> 0 Then

            For Each dr1 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")

                Global.PNam = dr1("User_name")
                Global.Ppwd = dr1("User_pwd")
                'Global.PEmail = dr1("AD_NAM")
                Global.PwLevel = dr1("User_lvl")
                TxtNam.Text = Global.PNam
                Global.PSec = dr1("User_sec")
                Global.LOGTIME = Date.Today
                Global.Ldate = dr1("User_Ldate")
                Global.Ltime = dr1("User_Time")

            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If
    End Sub

    Private Sub Btt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt1.Click



        Global.PUserId = TxtId.Text
        ss = TxtId.Text
        ss = Global.PUserId
        ' CON.Open()
        'PUserId1 = TxtId.Text

        If TxtPwd.Text = Global.Ppwd Then
            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()

            Global.PwFlag = "Y"

            Dim Cmd As New SqlCommand
            Cmd.Connection = CON

            ss = "UPDATE UsdMaster SET User_Ldate='" & Format(DateValue(Today()), "dd/MM/yyyy") & "',User_Time='" & FormatDateTime(TimeOfDay) & "' WHERE User_id='" & Global.PUserId & "'"
            Cmd.CommandText = ("UPDATE UsdMaster SET User_Ldate='" & Format(DateValue(Today()), "dd/MM/yyyy") & "',User_Time='" & FormatDateTime(TimeOfDay) & "' WHERE User_Code='" & Global.PUserId & "'")
            Cmd.ExecuteNonQuery()



            Dim ss2 As String = Format(Today(), ("MM/dd/yyyy"))
            Dim ss1 As String = Mid(ss, 4, 2) + "/" + Mid(ss, 1, 2) + "/" + Mid(ss, 7, 4)

            ADA = New SqlDataAdapter("SELECT * FROM RepFlag WHERE Rep_Date='" & Trim(ss2) & "'", CON)
            'ADA = New SqlDataAdapter("SELECT * FROM RepFlag ", CON)
            DS1 = New DataSet
            ADA.Fill(DS1, "RepFlag")

            COUNT = DS1.Tables("RepFlag").Rows.Count


      
                Response.Redirect("sgcsvEH1.aspx?UID=" & TxtId.Text & "")



        End If




    End Sub
End Class
