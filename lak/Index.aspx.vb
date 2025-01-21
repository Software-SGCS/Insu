Imports System.Data.OracleClient
Imports System.Data
Public Class Index
    Inherits System.Web.UI.Page
    Dim OBJ1 As New WORD
    Dim ADA As OracleDataAdapter
    Dim DS As DataSet
    Dim DV As DataView
    Dim RE, RE1, RE2, RE9 As OracleDataReader
    Dim DR As OracleDataReader
    Dim fsoObject    'File System Object
    Dim tsObject    'Text Stream Object
    Dim filObject   'File Object
    Dim lngVisitorNumber   'Holds the visitor number
    Dim intWriteDigitLoopCount  'Loop counter to display the graphical hit count
    Dim SS, COUNT
    Dim intDisplayDigitsLoopCount
    Dim intActiveUserNumber
    Dim CMD, CMD1, CMD2, CMD9 As New OracleCommand
    Dim UNAME, CK

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtpwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Btnlog As System.Web.UI.WebControls.Button

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
        Try
            OBJ1.ConnectDB()
            OBJ1.ConnectHEART()

        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub

    Private Sub Btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlog.Click
        Try
           
            Dim COUNT As Integer
            Dim PW, ID, UID As String
            If txtID.Text <> "" And txtpwd.Text <> "" Then

                UID = UCase(Trim(txtID.Text))
                ADA = New OracleDataAdapter("select * from LOGIN where NAME='" & UID & "'", OBJ1.CON)
                DS = New DataSet
                ADA.Fill(DS)
                COUNT = DS.Tables(0).Rows.Count
                If COUNT = 1 Then
                    CMD = New OracleCommand("select * from LOGIN where NAME='" & UCase(Trim(txtID.Text)) & "'", OBJ1.CON)
                    RE = CMD.ExecuteReader
                    While RE.Read
                        If UCase(Trim(txtpwd.Text)) = UCase(RE.GetValue(1)) Then
                            Global.UNAME = RE.GetValue(0)
                            Global.EPFNO = Trim(RE.Item("EPF_NO"))
                            Session("USER") = RE.GetValue(0)
                            Global.customerId = RE.Item("STATUS")
                            Session("TIME") = TimeOfDay
                            Session("LOGDATE") = Date.Now


                            CMD1 = New OracleCommand("SELECT * FROM USER_RIGHT WHERE USER_ID = '" & UCase(Trim(txtID.Text)) & "'", OBJ1.CON)
                            RE1 = CMD1.ExecuteReader
                            While RE1.Read
                                If IsDBNull(RE1.Item("USER_ADD")) Then Global.Righ_add = "" Else Global.Righ_add = RE1.Item("USER_ADD")
                                If IsDBNull(RE1.Item("USER_DET")) Then Global.Righ_det = "" Else Global.Righ_det = RE1.Item("USER_DET")
                                If IsDBNull(RE1.Item("USER_REF")) Then Global.Righ_ref = "" Else Global.Righ_ref = RE1.Item("USER_REF")
                                If IsDBNull(RE1.Item("USER_APP")) Then Global.Righ_app = "" Else Global.Righ_app = RE1.Item("USER_APP")


                                If Trim(UCase(RE1.Item("USER_DEP"))) = "NO" Then
                                    CMD9 = New OracleCommand("SELECT DEPARTMENT as AA from EMPLOYEE WHERE EPF_NO='" & Global.EPFNO & "'", OBJ1.CONHT)
                                    RE9 = CMD9.ExecuteReader
                                    While RE9.Read
                                        Global.Right_dep = RE9.Item("AA")
                                    End While
                                Else
                                    Global.Right_dep = ""
                                End If

                            End While

                           
                            Response.Redirect("Home.aspx")
                        Else
                                Response.Redirect("Index.ASPX")
                                Dispose()
                        End If
                    End While
                Else
                    Response.Write("<" & "script>alert('Invalid user id or password');<" & "/script>")
                    Response.Redirect("Index.ASPX")
                    Response.Write("IN")
                End If
            Else
                Response.Write("<" & "script>alert('Unable to blank user id or password');<" & "/script>")
                Response.Redirect("Index.ASPX")
            End If
            'OBJ1.CONH.Close()
        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub
End Class
