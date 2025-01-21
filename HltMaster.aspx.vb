Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class HltMaster
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, dr1, dr2 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim SS As String

    Dim Count As Integer
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
    Protected WithEvents Txtdob As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCld As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtAct As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtOldepfno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
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
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HltMaster.aspx' and Form_level='" & Global.PwLevel & "'", CON)

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
            CMD = New SqlCommand("SELECT EpfNo FROM HthMaster", CON)
            DR = CMD.ExecuteReader
            If Not IsPostBack Then
                While DR.Read
                    LstEmpNo.Items.Add(Str(DR.GetValue(0)))
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
            'Image1.Visible = True
            'Image1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            ' Image2.Visible = True
            ' Image2.ImageUrl = V2
        End If
        If IsDBNull(V3) = False Then
            ' Image3.Visible = True
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
        ' CHESYS()

        Dim RTP2 As String
        Dim RNO2 As String
        Dim Des1 As String
        Dim Des2 As String

        Dim Count As Double


        Des1 = TxtNam.Text
        Des2 = TxtIdNo.Text

        If BtnaddItm.Enabled = True Then

            Trim(LstEmpNo.SelectedValue)
            RNO2 = Mid(LstCom.SelectedValue, 1, 3)


            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO HthMaster(Com,EpfNo,OldEpfNo,EmpAct,EmpIdno,Dob,EmployeeName,EmpCld) VALUES ('" & RNO2 & "'," & RTP2 & "," & Trim(TxtOldepfno.Text) & ",'" & Trim(TxtAct.Text) & "','" & Trim(TxtIdNo.Text) & "',#" & Mid(Trim(Txtdob.Text), 4, 2) + "/" + Mid(Trim(Txtdob.Text), 1, 2) + "/" + Mid(Trim(Txtdob.Text), 7, 4) & "#,'" & Trim(TxtNam.Text) & "'," & Trim(TxtCld.Text) & ")")
            CMD.ExecuteNonQuery()



        Else

            RTP2 = Trim(LstEmpNo.SelectedValue)
            RNO2 = Mid(LstCom.SelectedValue, 1, 3)

            SS = "UPDATE HthMaster SET EmployeeName='" & Trim(TxtNam.Text) & "',EmpIdno='" & TxtIdNo.Text & "',EmpCld=" & TxtCld.Text & ",OldEpfNo=" & Trim(TxtOldepfno.Text) & ",EmpAct='" & TxtAct.Text & "' WHERE EpfNo=" & RTP2 & " AND Com='" & RNO2 & "'"


            CMD.Connection = CON
            CMD.CommandText = ("UPDATE HthMaster SET EmployeeName='" & Trim(TxtNam.Text) & "',EmpIdno='" & TxtIdNo.Text & "',EmpCld=" & TxtCld.Text & ",OldEpfNo=" & Trim(TxtOldepfno.Text) & ",EmpAct='" & TxtAct.Text & "' WHERE EpfNo=" & RTP2 & " AND Com='" & RNO2 & "'")
            CMD.ExecuteNonQuery()


        End If


        'If CHKDUP = False Then

        '    CMD.Connection = CON
        '    CMD.CommandText = ("INSERT INTO HthMaster(Com,EpfNo,OldEpfNo,EmpAct,EmpIdno,Dob,EmployeeName,EmpCld) VALUES ('" & RNO2 & "'," & RTP2 & "," & Trim(TxtOldepfno.Text) & ",'" & Trim(TxtAct.Text) & "','" & Trim(TxtIdNo.Text) & "',#" & Mid(Trim(Txtdob.Text), 4, 2) + "/" + Mid(Trim(Txtdob.Text), 1, 2) + "/" + Mid(Trim(Txtdob.Text), 7, 4) & "#,'" & Trim(TxtNam.Text) & "'," & Trim(TxtCld.Text) & ")")
        '    CMD.ExecuteNonQuery()
        '    ' MsgBox("RECOED OK")
        'Else

        '    CMD.Connection = CON
        '    CMD.CommandText = ("UPDATE HthMaster SET EmployeeName='" & Trim(TxtNam.Text) & "',EmpIdno='" & TxtIdNo.Text & "',EmpCld='" & TxtCld.Text & "',OldEpfNo='" & Trim(TxtOldepfno.Text) & "',EmpAct='" & TxtAct.Text & "' WHERE EmfNo=" & RTP2 & " AND Com='" & RNO2 & "'")
        '    CMD.ExecuteNonQuery()
        'End If

        BTNADD.Enabled = False


        ''Catch ex As Exception

        ''End Try
        'CON.Close()
    End Sub
    Private Sub CHESYS()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        'Try
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
        'ss = "UPDATE HthMaster SET EmployeeName='" & Trim(TxtNam.Text) & "',EmpIdno='" & TxtIdNo.Text & "',EmpCld='" & TxtCld.Text & "',OldEpfNo='" & Trim(TxtOldepfno.Text) & "',EmpAct='" & TxtAct.Text & "' WHERE EmfNo=" & RTP2 & " AND Com='" & RNO2 & "'"
        ADA1 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EmfNo=" & RTP & " AND Com = '" & RNO & "'", CON)
        DS1 = New DataSet
        ADA1.Fill(DS)
        Count = DS1.Tables(0).Rows.Count
        If Count <> 0 Then
            CHKDUP = True
        Else
            CHKDUP = False
        End If
        ' Catch ex As Exception
        '     MsgBox(ex.ToString)
        ' End Try
        'CON.Close()
    End Sub
    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpNo.SelectedIndexChanged

        BTNADD.Enabled = True

        CON.Open()
        ' CMD = New SqlCommand("SELECT EpfNo,EmployeeName,EmpIdno,Dob,EmpCld FROM HthMaster where EpfNo='" & Trim(LstEmpNo.SelectedValue) & "' and Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "'", CON)
        CMD = New SqlCommand("SELECT EPFNO,EMPLOYEENAME,EmpIdno,Dob,EmpCld FROM HthMaster where Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "' order by epfno", CON)
        DR = CMD.ExecuteReader
        '  If Not IsPostBack Then
        ' LstEmpNo.Items.Clear()

        ' While DR.Read
        ' LstEmpNo.Items.Add(Str(DR.GetValue(0)))

        ' End While
        '  End If

        PAG = True
        ''CLEAR()
        DR.Close()



        '  If Not IsPostBack Then

        ADA = New SqlDataAdapter("SELECT EPFNO,EMPLOYEENAME,EmpIdno,Dob,EmpCld  FROM HthMaster where EpfNo=" & Trim(LstEmpNo.SelectedValue) & " and Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS)
        Count = DS.Tables(0).Rows.Count


        If Count <> 0 Then


            CMD = New SqlCommand("SELECT EPFNO,EMPLOYEENAME,EmpIdno,Dob,EmpCld,EmpAct,OldEpfNo  FROM HthMaster where EpfNo=" & Trim(LstEmpNo.SelectedValue) & " and Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "'", CON)
            DR = CMD.ExecuteReader

            While DR.Read
                TxtNam.Text = ("" & DR.GetValue(1))
                TxtIdNo.Text = ("" & DR.GetValue(2))


                Txtdob.Text = Format(CDate(("" & DR.GetValue(3))), "dd/MM/yyyy")

                TxtCld.Text = ("" & DR.GetValue(4))
                TxtAct.Text = ("" & DR.GetValue(5))
                TxtOldepfno.Text = ("" & DR.GetValue(6))

            End While
        End If


        DR.Close()
        '---------


        '-------
        ' Data1()
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

    Private Sub TxtCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCom.TextChanged
        BTNADD.Enabled = True
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
        BTNADD.Enabled = True

    End Sub

    Private Sub Image1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)


    End Sub

    Private Sub LstCom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom.SelectedIndexChanged

        BTNADD.Enabled = True
        CON.Open()
        ' CMD = New SqlCommand("SELECT EpfNo,EmployeeName,EmpIdno,Dob,EmpCld FROM HthMaster where EpfNo='" & Trim(LstEmpNo.SelectedValue) & "' and Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "'", CON)
        CMD = New SqlCommand("SELECT EPFNO,EMPLOYEENAME,EmpIdno,Dob,EmpCld FROM HthMaster where Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "' order by epfno", CON)
        DR = CMD.ExecuteReader
        '  If Not IsPostBack Then
        LstEmpNo.Items.Clear()

        While DR.Read
            LstEmpNo.Items.Add(Str(DR.GetValue(0)))

        End While
        '  End If

        PAG = True
        ''CLEAR()
        DR.Close()



        '  If Not IsPostBack Then

        ADA = New SqlDataAdapter("SELECT EPFNO,EMPLOYEENAME,EmpIdno,Dob,EmpCld  FROM HthMaster where EpfNo=" & Trim(LstEmpNo.SelectedValue) & " and Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS)
        Count = DS.Tables(0).Rows.Count


        If Count <> 0 Then


            CMD = New SqlCommand("SELECT EPFNO,EMPLOYEENAME,EmpIdno,Dob,EmpCld,EmpAct,OldEpfNo  FROM HthMaster where EpfNo=" & Trim(LstEmpNo.SelectedValue) & " and Com='" & Mid(Trim(LstCom.SelectedValue), 1, 3) & "'", CON)
            DR = CMD.ExecuteReader

            While DR.Read
                TxtNam.Text = ("" & DR.GetValue(1))
                TxtIdNo.Text = ("" & DR.GetValue(2))


                Txtdob.Text = Format(CDate(("" & DR.GetValue(3))), "dd/MM/yyyy")

                TxtCld.Text = ("" & DR.GetValue(4))
                TxtAct.Text = ("" & DR.GetValue(5))
                TxtOldepfno.Text = ("" & DR.GetValue(6))


            End While
        End If


        DR.Close()


    End Sub
End Class
