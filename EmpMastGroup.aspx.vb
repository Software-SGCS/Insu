Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class EmpMastGroup
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, dr1, dr2 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Btnser As System.Web.UI.WebControls.Button
    Protected WithEvents BtnaddItm As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtIdNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEmpno As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstCom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstEmpNo As System.Web.UI.WebControls.DropDownList
    Dim PAG As Boolean

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
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

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='WebForm3.aspx' and Form_level='" & Global.PwLevel & "'", CON)

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
            TxtEmpno.Visible = False
            TxtCom.Visible = False
            TxtEmpno.Enabled = False
            TxtCom.Enabled = False
            LstEmpNo.Enabled = False
            LstCom.Enabled = False
        End If

        If PAG = False Then
            CHKDUP = False
            'Try

            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()

            'SELECT MADE
            CMD = New SqlCommand("SELECT Emp_No FROM EmpMaster", CON)
            DR = CMD.ExecuteReader
            If Not IsPostBack Then
                While DR.Read
                    LstEmpNo.Items.Add(DR.GetValue(0))
                End While
            End If

        End If

        'LSTVehMak.Items.Clear()
        CMD = New SqlCommand("SELECT  Com_No,Com_Nam FROM Company'", CON)
        DR.Close()
        DR = CMD.ExecuteReader
        If Not IsPostBack Then
            While DR.Read
                LstCom.Items.Add(DR.GetValue(0) + "-" + DR.GetValue(1))
            End While
        End If

        Dim V1, V2, V3 As String
        V1 = "http://sgcsser\insu\PHOTO\1.GIF"
        V2 = "http://sgcsser\insu\PHOTO\2.GIF"
        V3 = "http://sgcsser\insu\PHOTO\3.GIF"

        If IsDBNull(V1) = False Then
            ' Image1.Visible = True
            'Image1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            ' Image2.Visible = True
            'Image2.ImageUrl = V2
        End If
        If IsDBNull(V3) = False Then
            'Image3.Visible = True
            ' Image3.ImageUrl = V3
        End If


        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        CON.Close()
        'CLEAR()
    End Sub

    Private Sub BTNADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADD.Click
        'BtnEdit.Enabled = True
        'BtnEdit.Visible = True
        'BtnaddItm.Enabled = False
        'BtnaddItm.Visible = True

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        ''Try
        Dim DD As String
        Dim DD1 As Date
        CHESYS()

        Dim RTP2 As String
        Dim RNO2 As String
        Dim Des1 As String
        Dim Des2 As String

        Dim Count As Double


        Des1 = TxtNam.Text
        Des2 = TxtIdNo.Text

        If BtnaddItm.Enabled = False Then
            RTP2 = LstEmpNo.SelectedValue
            RNO2 = Mid(LstCom.SelectedValue, 1, 3)
        Else

            RTP2 = TxtEmpno.Text
            RNO2 = Mid(LstCom.SelectedValue, 1, 3)
        End If


        If CHKDUP = False Then

            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO EmpMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Idno) VALUES ('" & RTP2 & "','" & RNO2 & "','" & TxtNam.Text & "','" & TxtIdNo.Text & "')")
            CMD.ExecuteNonQuery()
            ' MsgBox("RECOED OK")
        Else

            CMD.Connection = CON
            CMD.CommandText = ("UPDATE EmpMaster SET Emp_Nam='" & TxtNam.Text & "',Emp_Idno='" & TxtIdNo.Text & "' WHERE Emp_No='" & RTP2 & "' AND Emp_Com='" & RNO2 & "'")
            CMD.ExecuteNonQuery()
        End If

        ''Catch ex As Exception

        ''End Try
        'CON.Close()
    End Sub
    Private Sub CHESYS()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Try
            Dim RTP As String
            Dim RNO As String
            Dim Count As Double

            RTP = LstEmpNo.SelectedValue
            RNO = LstCom.SelectedValue

            If BtnaddItm.Enabled = False Then
                RTP = LstEmpNo.SelectedValue
                RNO = Mid(LstCom.SelectedValue, 1, 3)
            Else

                RTP = TxtEmpno.Text
                RNO = Mid(LstCom.SelectedValue, 1, 3)

            End If

            ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & RTP & "' AND Emp_Com = '" & RNO & "'", CON)
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
        'CON.Close()
    End Sub
    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data1()
    End Sub

    Private Sub Textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnser.Click
        PAG = True
        ''CLEAR()
        TxtEmpno.Visible = True
        TxtCom.Visible = True
        TxtEmpno.Enabled = True
        TxtCom.Enabled = True


        Dim RTP As String
        Dim RNO As String

        RTP = LstEmpNo.SelectedValue
        RNO = LstCom.SelectedValue

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        CHESYS()

        If CHKDUP = False Then
            TxtIdNo.Text = ("")
            TxtIdNo.Text = ("")
            '  MsgBox("UNABLE TO FIND RECORD")
        Else
            CMD = New SqlCommand("SELECT Sys_des1,Sys_des2 FROM SYSMAST WHERE SYS_RTP = '" & RTP & "' AND SYS_RNO = '" & RNO & "'", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                TxtNam.Text = ("" & RE.GetValue(0))
                TxtIdNo.Text = ("" & RE.GetValue(1))
            End While
        End If
    End Sub

    Private Sub Image2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)

    End Sub

    Private Sub BtnaddItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnaddItm.Click
        TxtEmpno.Visible = True
        TxtCom.Visible = False
        TxtEmpno.Enabled = True
        TxtCom.Enabled = False
        LstEmpNo.Visible = False
        LstCom.Visible = True
        LstCom.Enabled = True
        BtnEdit.Enabled = False
        TxtNam.Text = ("")
        TxtIdNo.Text = ("")

        Btnser.Visible = False

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TxtEmpno.Visible = False
        TxtCom.Visible = False
        TxtEmpno.Enabled = False
        TxtCom.Enabled = False
        LstEmpNo.Visible = True
        LstCom.Visible = True
        LstEmpNo.Enabled = True
        LstCom.Enabled = True
        BtnaddItm.Enabled = False
        Btnser.Visible = True
        BtnaddItm.Enabled = False

    End Sub

    Private Sub TxtCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Try
            Dim RTP As String
            Dim RNO As String
            Dim Count As Double

            RTP = LstEmpNo.SelectedValue
            RNO = LstCom.SelectedValue

            If BtnaddItm.Enabled = False Then
                RTP = LstEmpNo.SelectedValue
                RNO = LstCom.SelectedValue
            Else

                RTP = TxtEmpno.Text
                RNO = TxtCom.Text
            End If

            ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '" & RTP & "' AND SYS_RNO = '" & RNO & "'", CON)
            DS = New DataSet
            ADA.Fill(DS)
            Count = DS.Tables(0).Rows.Count
            If Count <> 0 Then
                MsgBox("DFDFDF")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BtnEdit.Enabled = True
        BtnEdit.Visible = True
        BtnaddItm.Enabled = True
        BtnaddItm.Visible = True
        BtnaddItm.Enabled = True
        BtnaddItm.Visible = True
    End Sub

    Private Sub Data1()
        CON.Open()
        Dim TT, TT1 As String

        TT = Mid(LstEmpNo.SelectedValue, 1, 2)
        TT = Trim(TT)
        CMD = New SqlCommand("SELECT * FROM SYSMAST", CON)
        dr2 = CMD.ExecuteReader
        dr2.Close()


        'DR.Close()
        CMD = New SqlCommand("SELECT SYS_RNO,SYS_DES1 FROM SYSMAST WHERE SYS_RTP='" & TT & "'", CON)
        DR = CMD.ExecuteReader
        LstCom.Items.Clear()
        While DR.Read
            TT1 = DR.GetValue(0) + "-" + DR.GetValue(1)
            LstCom.Items.Add(DR.GetValue(0))
        End While


        CON.Close()
    End Sub

    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data1()
    End Sub

    Private Sub Image1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)


    End Sub
End Class
