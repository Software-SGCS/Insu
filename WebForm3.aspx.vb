Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Public Class WebForm3
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
    Protected WithEvents LstSysRno As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Txtdes2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtdes1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstSysRtp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Btnser As System.Web.UI.WebControls.Button
    Protected WithEvents BtnaddItm As System.Web.UI.WebControls.Button
    Protected WithEvents TxtRno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtrtp As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
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
            ' Response.Redirect("InsuDept.aspx")
        End If




        If IsPostBack Then
            Txtrtp.Visible = False
            TxtRno.Visible = False
            Txtrtp.Enabled = False
            TxtRno.Enabled = False
            LstSysRtp.Enabled = False
            LstSysRno.Enabled = False
        End If

        If PAG = False Then
            CHKDUP = False
            'Try

            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()

            'SELECT MADE
            CMD = New SqlCommand("SELECT DISTINCT SYS_RTP FROM SYSMAST", CON)
            DR = CMD.ExecuteReader
            If Not IsPostBack Then
                While DR.Read
                    LstSysRtp.Items.Add(DR.GetValue(0))
                End While
            End If

        End If

        'LSTVehMak.Items.Clear()
        CMD = New SqlCommand("SELECT  SYS_RNO FROM SYSMAST WHERE SYS_RTP='01'", CON)
        DR.Close()
        DR = CMD.ExecuteReader
        If Not IsPostBack Then
            While DR.Read
                LstSysRno.Items.Add(DR.GetValue(0))
            End While
        End If

        Dim V1, V2, V3 As String
        V1 = "http://sgcsser\insu\PHOTO\1.GIF"
        V2 = "http://sgcsser\insu\PHOTO\2.GIF"
        V3 = "http://sgcsser\insu\PHOTO\3.GIF"

        If IsDBNull(V1) = False Then
            'Image1.Visible = True
            ' Image1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            'Image2.Visible = True
            'Image2.ImageUrl = V2
        End If
        If IsDBNull(V3) = False Then
            'Image3.Visible = True
            'Image3.ImageUrl = V3
        End If


        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        CON.Close()
        'CLEAR()
        BindTheGrid1()
    End Sub

    Private Sub BTNADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADD.Click
        'BtnEdit.Enabled = True
        'BtnEdit.Visible = True
        'BtnaddItm.Enabled = False
        'BtnaddItm.Visible = True

        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'CON.Open()
        ''Try
        Dim DD As String
        Dim DD1 As Date
        



        CHESYS()

        Dim RTP2 As String
        Dim RNO2 As String
        Dim Des1 As String
        Dim Des2 As String

        Dim Count As Double
        CMD = New SqlCommand("SELECT * FROM vehtypmast", CON)
        DR = CMD.ExecuteReader
        DR.Close()

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

            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO SYSMAST (SYS_RTP,SYS_RNO,SYS_DES1,SYS_DES2) VALUES ('" & RTP2 & "','" & RNO2 & "','" & Des1 & "','" & Des2 & "')")
            CMD.ExecuteNonQuery()
            ' MsgBox("RECOED OK")
        Else

            CMD.Connection = CON
            CMD.CommandText = ("UPDATE SYSMAST SET SYS_DES1='" & Des1 & "',SYS_DES2='" & Des2 & "' WHERE SYS_RTP='" & RTP2 & "' AND SYS_RNO='" & RNO2 & "'")
            CMD.ExecuteNonQuery()
        End If
        BindTheGrid1()
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

            RTP = LstSysRtp.SelectedValue
            RNO = LstSysRno.SelectedValue

            If BtnaddItm.Enabled = False Then
                RTP = LstSysRtp.SelectedValue
                RNO = LstSysRno.SelectedValue
            Else

                RTP = Txtrtp.Text
                RNO = TxtRno.Text
            End If

            ADA = New SqlDataAdapter("SELECT * FROM SYSMAST WHERE SYS_RTP = '" & RTP & "' AND SYS_RNO = '" & RNO & "'", CON)
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
    Private Sub LstSysRtp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstSysRtp.SelectedIndexChanged
        Data1()
    End Sub

    Private Sub Textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnser.Click
        PAG = True
        ''CLEAR()
        Txtrtp.Visible = True
        TxtRno.Visible = True
        Txtrtp.Enabled = True
        TxtRno.Enabled = True


        Dim RTP As String
        Dim RNO As String

        RTP = LstSysRtp.SelectedValue
        RNO = LstSysRno.SelectedValue

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        CHESYS()

        If CHKDUP = False Then
            Txtdes2.Text = ("")
            Txtdes2.Text = ("")
            '  MsgBox("UNABLE TO FIND RECORD")
        Else
            CMD = New SqlCommand("SELECT Sys_des1,Sys_des2 FROM SYSMAST WHERE SYS_RTP = '" & RTP & "' AND SYS_RNO = '" & RNO & "'", CON)
            RE = CMD.ExecuteReader
            While RE.Read
                Txtdes1.Text = ("" & RE.GetValue(0))
                Txtdes2.Text = ("" & RE.GetValue(1))
            End While
        End If
    End Sub

    Private Sub Image2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)

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

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Txtrtp.Visible = False
        TxtRno.Visible = False
        Txtrtp.Enabled = False
        TxtRno.Enabled = False
        LstSysRtp.Visible = True
        LstSysRno.Visible = True
        LstSysRtp.Enabled = True
        LstSysRno.Enabled = True
        BtnaddItm.Enabled = False
        Btnser.Visible = True
        BtnaddItm.Enabled = False

    End Sub

    Private Sub TxtRno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRno.TextChanged
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
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

        TT = Mid(LstSysRtp.SelectedValue, 1, 2)
        TT = Trim(TT)
        CMD = New SqlCommand("SELECT * FROM SYSMAST", CON)
        dr2 = CMD.ExecuteReader
        dr2.Close()


        'DR.Close()
        CMD = New SqlCommand("SELECT SYS_RNO,SYS_DES1 FROM SYSMAST WHERE SYS_RTP='" & TT & "'", CON)
        DR = CMD.ExecuteReader
        LstSysRno.Items.Clear()
        While DR.Read
            TT1 = DR.GetValue(0) + "-" + DR.GetValue(1)
            LstSysRno.Items.Add(DR.GetValue(0))
        End While


        BindTheGrid1()




        CON.Close()
    End Sub

    Private Sub Txtrtp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtrtp.TextChanged
        Data1()
    End Sub

    Private Sub Image1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)


    End Sub
    Public Sub BindTheGrid1()
        'CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        '''ss = "Select convert(varchar(10),HltMaster1.Emp_PayDt,103) as Raw_ItmCode,HltMaster1.id as Raw_des ,HthMaster.EmployeeName as Itm_pri,convert(decimal(8,2),HltMaster1.Emp_DecAmt,2) as Raw_opStk,HltMaster1.Emp_ChqNo as Raw_Soh,HltMaster1.Emp_CNo as Raw_PhStock,convert(decimal(8,2),HltMaster1.Emp_Amt,2) as Raw_rec ,HltMaster1.Raw_Rmk as Raw_Rtn from HltMaster1 ,HthMaster where (HltMaster1.Emp_No=HthMaster.Epfno or HltMaster1.Emp_No=HthMaster.OldEpfno or HltMaster1.Emp_No=HthMaster.OldEpfno1 or HltMaster1.Emp_No=HthMaster.OldEpfno2 or HltMaster1.Emp_No=HthMaster.OldEpfno3 or HltMaster1.Emp_No=HthMaster.OldEpfno4) AND (HltMaster1.Emp_Com=HthMaster.Com) and (HltMaster1.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and HltMaster1.Emp_DecFlg='Yes') and (HltMaster1.Emp_No='" & Trim(TxtTEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo2.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo4.Text) & "') and Emp_Accyr='" & Trim(TxtYr1.Text) & "' ORDER BY HltMaster1.iD"

        ''Dim ss1 As String = "Select id,Itm_No as ItmNo,Itm_des as ItmDes, Format(Sale_pr,'#,###.00') as SPri,Format(Cost_pr,'#,###.00') as CPri format(Itm_stk,'#,###') as stk, Cat_no as CatNo from ItmMast where substring(Itm_no,1,2)='" & Mid(Trim(LstCatNo.SelectedValue), 1, 2) & "'"
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Sys_Rno,Sys_Rtp, Sys_Des1,Sys_Des2 from SysMast where Sys_Rtp='" & Trim(LstSysRtp.SelectedValue) & "'", CON)
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

End Class
