Imports System.Data.Sqlclient
Imports System.Data
Public Class EmpAdminMaster
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
    Dim PAG As Boolean

    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents LstCatNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstItmNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtDepNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents TxtContact As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BTNADD As System.Web.UI.WebControls.Button
    Protected WithEvents TxtCat As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnRefres As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents BtnaddItm As System.Web.UI.WebControls.Button
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Btnser As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label

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

        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='CodeMaster.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            '' Response.Redirect("InsuDept.aspx")
        End If


        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()
        Dim SS1 As String = "SELECT Itm_no,Itm_des FROM ItmMast where substring(Itm_no,1,2)='" & Mid(LstCatNo.SelectedValue, 1, 2) & "' order by Itm_no"
        LstItmNo.Items.Clear()
        CMD = New SqlCommand("SELECT Emp_No,Emp_Nam FROM EmpAdmin where Emp_DepNo='" & Mid(LstCatNo.SelectedValue, 1, 2) & "' order by Emp_No", CON)
        DR = CMD.ExecuteReader
        If Not IsPostBack Then
            While DR.Read
                LstItmNo.Items.Add(DR.GetValue(0) + "-" + DR.GetValue(1))
            End While
        End If

        BindTheGrid1()


        'CMD = New SqlCommand("SELECT Emp_No,Emp_Nam FROM EmpAdmin order by Emp_No", CON)
        ' DR = CMD.ExecuteReader
        'If Not IsPostBack Then
        'While DR.Read
        'LstItmNo.Items.Add(DR.GetValue(0) + "-" + DR.GetValue(1))
        'End While
        'End If
        If Not IsPostBack Then
            TxtEmpNo.Visible = False
            TxtEmpNo.Visible = False
            TxtEmpNo.Enabled = False
            TxtEmpNo.Enabled = False
            'LstCatNo.Enabled = False
            'LstCatNo.Enabled = False
        End If

        If PAG = False Then
            CHKDUP = False

            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()


            'CMD = New SqlCommand("SELECT Itm_no FROM ItmMast", CON)
            'DR = CMD.ExecuteReader
            'If Not IsPostBack Then
            '    While DR.Read
            '        LstItmNo.Items.Add(DR.GetValue(0))
            '    End While
            'End If

        End If
        DR.Close()

        CMD = New SqlCommand("SELECT Sys_Rno,Sys_Des1 FROM SysMast where Sys_Rtp='04' order by Sys_Rno", CON)
        DR = CMD.ExecuteReader
        If Not IsPostBack Then
            While DR.Read
                LstCatNo.Items.Add(DR.GetValue(0) + "-" + DR.GetValue(1))
            End While
        End If

        CON.Close()
        Dim V1, V2, V3 As String
        If BTNADD.Enabled = True Then
            V1 = "http://sgcsser\Insu\Itm\" & Trim(LstItmNo.SelectedValue) & "1.jpg"
        Else
            V1 = "http://sgcsser\Insu\Itm\" & Trim(LstItmNo.SelectedValue) & "1.jpg"
        End If
        If BTNADD.Enabled = True Then
            V2 = "http://sgcsser\Insu\Itm\" & Trim(LstItmNo.SelectedValue) & "2.jpg"
        Else
            V2 = "http://sgcsser\Insu\Itm\" & Trim(LstItmNo.SelectedValue) & "2.jpg"
        End If

        V3 = "http://sgcsser\Insu\Itm\"

        If IsDBNull(V1) = False Then
            '    Img1.Visible = True
            '   Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            ' Img2.Visible = True
            'Img2.ImageUrl = V2
        End If

        BindTheGrid1()


    End Sub

    Private Sub BTNADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADD.Click
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        ''Try
        Dim DD As String
        Dim DD1 As Date
        CHESYS()

        Dim RTP2 As String
        Dim Rno2 As String
        Dim qty As Double
        Dim Spri As Double
        Dim Cpri As Double
        Dim Nam As String
        Dim Eml As String
        Dim cntct As String

        Nam = TxtNam.Text
        Eml = TxtEmail.Text
        cntct = TxtContact.Text
        'qty = TxtQty.Text
        'Dis = TxtDis.Text
        If BtnaddItm.Enabled = False Then
            RTP2 = Mid(LstItmNo.SelectedValue, 1, 4)
            Rno2 = TxtCat.Text
        Else

            RTP2 = Trim(TxtEmpNo.Text)
            Rno2 = TxtCat.Text
        End If


        If BtnaddItm.Enabled = True Then

            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO EmpAdmin(Emp_No,Emp_DepNo,Emp_Nam,Emp_Email,Emp_Contact) VALUES ('" & RTP2 & "','" & Rno2 & "','" & Nam & "','" & Eml & "','" & cntct & "')")

            CMD.ExecuteNonQuery()

        Else

            CMD.Connection = CON
            CMD.CommandText = ("UPDATE EmpAdmin SET Emp_Nam='" & Nam & "',Cat_no='" & Rno2 & "',Emp_Email='" & Eml & "',Emp_Contact='" & cntct & "' WHERE Emp_No='" & RTP2 & "'")
            CMD.ExecuteNonQuery()
        End If

        BTNADD.Enabled = False
        BindTheGrid1()


    End Sub
    Private Sub CHESYS()
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()

        Try
            Dim RTP As String
            Dim RNO As String
            Dim Count As Double

            RTP = Mid(LstItmNo.SelectedValue, 1, 4)
            RNO = LstCatNo.SelectedValue

            If BtnaddItm.Enabled = False Then
                RTP = Mid(LstItmNo.SelectedValue, 1, 4)
                RNO = Mid(LstCatNo.SelectedValue, 1, 2)
            Else

                RTP = TxtEmpNo.Text
                RNO = Mid(LstCatNo.SelectedValue, 1, 2)
            End If

            ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No='" & RTP & "' and Emp_Depno='" & RNO & "'", CON)
            'WHERE SYS_RTP = " & RTP & " AND SYS_RNO = '" & RNO & "'", CON)
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

    Private Sub Btnser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnser.Click
        ' PAG = True
        ''CLEAR()
        Dim RTP As String

        Dim RNO As String

        RTP = Mid(LstItmNo.SelectedValue, 1, 4)
        RNO = Mid(LstCatNo.SelectedValue, 1, 2)

        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        CHESYS()

        If CHKDUP = False Then
            TxtEmail.Text = ("")
            TxtContact.Text = ("")
            TxtNam.Text = ("")
            'TxtQty.Text = ("")
            'TxtDis.Text = ("")
            '  MsgBox("UNABLE TO FIND RECORD")
        Else
            CMD = New SqlCommand("SELECT Emp_Email,Emp_Contact,Emp_Nam FROM EmpAdmin WHERE Emp_No = '" & RTP & "' and Emp_Depno='" & RNO & "'", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                TxtEmail.Text = ("" & RE.GetValue(1))
                TxtContact.Text = ("" & RE.GetValue(2))
                TxtNam.Text = ("" & RE.GetValue(0))
                ' TxtQty.Text = ("" & RE.GetValue(3))
                'LstCatNo.SelectedValue = ("" & RE.GetValue(4))
                ' TxtDis.Text = ("" & RE.GetValue(5))
            End While
        End If
    End Sub



    Private Sub BtnaddItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnaddItm.Click
        TxtEmail.Visible = True
        TxtContact.Visible = True
        TxtNam.Enabled = True
        'TxtSPri.Enabled = True
        ' LstCatNo.Enabled = True
        'LstCatNo.Visible = True
        BtnEdit.Enabled = False
        TxtEmail.Text = ("")
        TxtContact.Text = ("")
        TxtNam.Text = ("")
        'TxtQty.Text = ("")
        'TxtDis.Text = ("")
        LstItmNo.Visible = False
        TxtEmpNo.Visible = True
        TxtEmpNo.Enabled = True
        LstItmNo.Enabled = False
        Btnser.Visible = False
        BTNADD.Enabled = True

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        'TxtDes.Visible = False
        'TxtSpri.Visible = False
        'TxtDes.Enabled = False
        'TxtSpri.Enabled = False
        'LstCatNo.Visible = True
        'LstCatNo.Enabled = True
        LstItmNo.Enabled = True
        LstItmNo.Visible = True
        BtnaddItm.Enabled = False
        Btnser.Visible = True
        BtnDel.Visible = True
        BTNADD.Enabled = True

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()

        Try
            Dim RTP As String
            Dim RNO As String
            Dim Count As Double

            RTP = LstCatNo.SelectedValue
            RNO = LstCatNo.SelectedValue

            If BtnaddItm.Enabled = False Then
                RTP = LstCatNo.SelectedValue
                RNO = Mid(LstCatNo.SelectedValue, 1, 2)
            Else

                RTP = TxtNam.Text
                RNO = Mid(LstCatNo.SelectedValue, 1, 2)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LstDepCom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()
        Dim RTP As String
        Dim RNO As String
        Dim Count As Double

        RTP = LstCatNo.SelectedValue
        RNO = Mid(LstCatNo.SelectedValue, 1, 2)

        If BtnaddItm.Enabled = False Then
            RTP = LstCatNo.SelectedValue
            RNO = Mid(LstCatNo.SelectedValue, 1, 2)
        Else

            RTP = TxtNam.Text
            RNO = Mid(LstCatNo.SelectedValue, 1, 2)
        End If



        DR.Close()

        CMD = New SqlCommand("SELECT Sys_Rno,Sys_Des1 FROM SysMast where Sys_Rtp='04' order by Sys_Rno", CON)
        DR = CMD.ExecuteReader

        If Not IsPostBack Then
            While DR.Read
                LstCatNo.Items.Add(DR.GetValue(0) + "-" + DR.GetValue(1))
            End While
        End If

        CON.Close()


    End Sub

    Private Sub LstDepNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim RTP As String

        Dim RNO As String

        RTP = LstCatNo.SelectedValue
        RNO = Mid(LstCatNo.SelectedValue, 1, 2)

        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        CHESYS()

        If CHKDUP = False Then
            'TxtSPri.Text = ("")
            'TxtSPri.Text = ("")
            '  MsgBox("UNABLE TO FIND RECORD")
        Else
            CMD = New SqlCommand("SELECT Sys_Rno,Sys_Des1 FROM SysMast where Sys_Rtp='04' order by Sys_Rno", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                ' TxtDes.Text = ("" & RE.GetValue(2))
                'TxtSPri.Text = ("" & RE.GetValue(3))
            End While
        End If
    End Sub



    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
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


        'Des1 = TxtDes.Text
        ' Des2 = TxtSPri.Text

        If BtnaddItm.Enabled = False Then
            RTP2 = Trim(Mid(LstItmNo.SelectedValue, 1, 4))
            RNO2 = Mid(LstCatNo.SelectedValue, 1, 2)
        Else

            RTP2 = TxtEmpNo.Text
            RNO2 = Mid(LstCatNo.SelectedValue, 1, 2)
        End If

        CMD.Connection = CON
        CMD.CommandText = ("DELETE FROM EmpAdmin WHERE Emp_No='" & RTP2 & "' and Emp_DepNo='" & RNO2 & "'")
        CMD.ExecuteNonQuery()
        BindTheGrid1()

    End Sub

    Private Sub BtnRefres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefres.Click
        TxtNam.Visible = True
        TxtEmail.Visible = True
        TxtNam.Enabled = True
        TxtEmail.Enabled = True
        'LstCatNo.Visible = True
        LstCatNo.Enabled = True
        BtnEdit.Enabled = True
        TxtNam.Text = ("")
        TxtContact.Text = ("")
        'TxtDis.Text = ("")
        LstItmNo.Visible = True
        LstItmNo.Visible = True

        BtnaddItm.Enabled = True
        BtnEdit.Enabled = True
        BTNADD.Enabled = True
        Btnser.Visible = False
        BtnDel.Visible = False
    End Sub

    Private Sub TxtItmNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' PAG = True
        ''CLEAR()
        Dim RTP As String

        Dim RNO As String

        RTP = Mid(LstItmNo.SelectedValue, 1, 4)
        RNO = Mid(LstCatNo.SelectedValue, 1, 2)
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        CHESYS()

        If CHKDUP = False Then
            TxtNam.Text = ("")
            TxtEmail.Text = ("")
            TxtContact.Text = ("")
            'TxtQty.Text = ("")
            'TxtDis.Text = ("")
            '  MsgBox("UNABLE TO FIND RECORD")
        Else
            CMD = New SqlCommand("SELECT Emp_Nam,Emp_Email,Emp_Contact FROM EmpAdmin WHERE Emp_No = '" & RTP & "' and Emp_DepNo='" & RNO & "'", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                TxtNam.Text = ("" & RE.GetValue(1))
                TxtEmail.Text = ("" & RE.GetValue(2))
                TxtContact.Text = ("" & RE.GetValue(0))
                ' TxtQty.Text = ("" & RE.GetValue(3))
                'LstCatNo.SelectedValue = ("" & RE.GetValue(4))
                ' TxtDis.Text = ("" & RE.GetValue(5))
            End While
        End If
    End Sub

    Private Sub LstCatNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCatNo.SelectedIndexChanged
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim SS1 As String = "SELECT Itm_no,Itm_des FROM ItmMast where substring(Itm_no,1,2)='" & Mid(LstCatNo.SelectedValue, 1, 2) & "' order by Itm_no"
        LstItmNo.Items.Clear()
        CMD = New SqlCommand("SELECT Emp_No,Emp_Nam FROM EmpAdmin where Emp_DepNo='" & Mid(LstCatNo.SelectedValue, 1, 2) & "' order by Emp_No", CON)

        TxtCat.Text = Trim(Mid(LstCatNo.SelectedValue, 1, 2))
        DR = CMD.ExecuteReader
        '    If Not IsPostBack Then
        While DR.Read
            LstItmNo.Items.Add(DR.GetValue(0) + "-" + DR.GetValue(1))
        End While
        ' End If

        BindTheGrid1()
    End Sub

    Private Sub LstItmNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstItmNo.SelectedIndexChanged
        ''CLEAR()
        Dim RTP As String

        Dim RNO As String

        RTP = Mid(LstItmNo.SelectedValue, 1, 4)
        RNO = Mid(LstCatNo.SelectedValue, 1, 2)

        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        CHESYS()

        If CHKDUP = False Then
            TxtNam.Text = ("")
            TxtEmail.Text = ("")
            TxtContact.Text = ("")
            'TxtQty.Text = ("")
            'TxtDis.Text = ("")
            '  MsgBox("UNABLE TO FIND RECORD")
        Else
            CMD = New SqlCommand("SELECT Emp_Nam,Emp_Email,Emm_Contact FROM EmpAdmin WHERE Emp_no = '" & RTP & "' and Emp_Depno='" & RNO & "'", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                TxtNam.Text = ("" & RE.GetValue(1))
                TxtEmail.Text = ("" & RE.GetValue(2))
                TxtContact.Text = ("" & RE.GetValue(0))
                'TxtQty.Text = ("" & RE.GetValue(3))
                'LstCatNo.SelectedValue = ("" & RE.GetValue(4))
                'TxtDis.Text = ("" & RE.GetValue(5))
            End While
        End If
    End Sub

    Public Sub BindTheGrid1()
        'CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        '''ss = "Select convert(varchar(10),HltMaster1.Emp_PayDt,103) as Raw_ItmCode,HltMaster1.id as Raw_des ,HthMaster.EmployeeName as Itm_pri,convert(decimal(8,2),HltMaster1.Emp_DecAmt,2) as Raw_opStk,HltMaster1.Emp_ChqNo as Raw_Soh,HltMaster1.Emp_CNo as Raw_PhStock,convert(decimal(8,2),HltMaster1.Emp_Amt,2) as Raw_rec ,HltMaster1.Raw_Rmk as Raw_Rtn from HltMaster1 ,HthMaster where (HltMaster1.Emp_No=HthMaster.Epfno or HltMaster1.Emp_No=HthMaster.OldEpfno or HltMaster1.Emp_No=HthMaster.OldEpfno1 or HltMaster1.Emp_No=HthMaster.OldEpfno2 or HltMaster1.Emp_No=HthMaster.OldEpfno3 or HltMaster1.Emp_No=HthMaster.OldEpfno4) AND (HltMaster1.Emp_Com=HthMaster.Com) and (HltMaster1.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and HltMaster1.Emp_DecFlg='Yes') and (HltMaster1.Emp_No='" & Trim(TxtTEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo2.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo4.Text) & "') and Emp_Accyr='" & Trim(TxtYr1.Text) & "' ORDER BY HltMaster1.iD"

        ''Dim ss1 As String = "Select id,Itm_No as ItmNo,Itm_des as ItmDes, Format(Sale_pr,'#,###.00') as SPri,Format(Cost_pr,'#,###.00') as CPri format(Itm_stk,'#,###') as stk, Cat_no as CatNo from ItmMast where substring(Itm_no,1,2)='" & Mid(Trim(LstCatNo.SelectedValue), 1, 2) & "'"
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Emp_No as EmpNo,Emp_Nam as EmpNam, Emp_Email as EmpEmail,Emp_Contact as EmpContact from EmpAdmin where Emp_DepNo='" & Mid(Trim(LstCatNo.SelectedValue), 1, 2) & "'", CON)
        cmdCustomers.CommandType = CommandType.Text
        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()
    End Sub

    Sub MyDataGrid_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)


    End Sub

    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"



    End Sub
    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"



    End Sub
    Sub MyDataGrid_Cancel(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"



    End Sub



    'MyDataGrid_Cancel' 
End Class
