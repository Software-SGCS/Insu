Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class EntryEmployeeMaster
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim Sinvno As String
    Dim TempEmpno, TempCom As String
    Dim ss As String
    Dim Tno As String
    Dim Tno1 As String
    Dim Tno2 As String
    Dim count1, Count2 As Integer
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno, strEmpAdd, StrEmpDoA As String
    Dim Strcld, strOld, PFlag, psec As String
    Dim Empcom, EmpNo, RelNam, RelType, RelAge, Relidno, EntCode, EntDate, DeaFlag, Delfg As String

    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents LstEmpNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtRNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents LstReltyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents LstCom1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEmpNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtIdNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEmpAdd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtDoA As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRelAge As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRelId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfg As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtOldNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDob As System.Web.UI.WebControls.TextBox
    Protected WithEvents Rlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Lab6 As System.Web.UI.WebControls.Label
    Protected WithEvents TId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Btn1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected strCountry As String



#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init

        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        PFlag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        count1 = DS.Tables("UsdMaster").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                Count2 = drt2("User_lvl")
                psec = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If

        If Count2 = "1" Then
            PFlag = "Y"
        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EntryEmployeeMaster.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EntryEmployeeMaster.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EntryEmployeeMaster.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EntryEmployeeMaster.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If

                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                PFlag = "Y"
            End While

            DR.Close()
        End If

        If PFlag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else
            Response.Redirect("POSDispaly11.aspx")
        End If

        If Not IsPostBack Then
            If psec = "ALL" Then
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
            Else
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(psec) & "'", CON)
            End If

            DR = CMD.ExecuteReader

            LstCom1.Items.Clear()

            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCom1.Items.Add(TT)
            End While

            BindTheGrid()

            DR.Close()
        End If

        TempCom = Mid(Trim(LstEmpNo.SelectedValue), 9, 3)

        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        CMD = New SqlCommand("SELECT Emp_RelType From RelationType", CON)
        DR1 = CMD.ExecuteReader

        If Not IsPostBack Then
            While DR1.Read
                TT = DR1.GetValue(0)
                LstReltyp.Items.Add(TT)
            End While
        End If

        DR1.Close()
        BindTheGrid()

    End Sub
    Public Sub BindTheGrid()
        'Try
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        If CHKDUP = True Then
            TempEmpno = Mid(TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom1.SelectedValue, 1, 3)
        Else
            TempEmpno = Mid(TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom1.SelectedValue, 1, 3)
        End If

        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Rel_Nam,Rel_Type,Rel_Age,Rel_IdNo,Dea_Flag,CONVERT(VARCHAR(10),Ent_Date,103) AS  Ent_Date from EmpMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        'CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub BindTheGrid1()




        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, Format(Inv_pr,'#,###.00') as InvPr,format(Inv_Qty,'#,###') as InvQty, format(Inv_val,'#,###.00') as InvVal from InlTemp", CON)

        cmdCustomers.CommandType = CommandType.Text

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()
    End Sub




    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'Lstcom.Visible = False
        LstEmpNo.Enabled = False
        LstEmpNo.Visible = False
        TxtEmpNo.Visible = True
        CHKDUP = True
        TxtEmpNo.Text = " "

        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)
        DS = New DataSet
        ADA.Fill(DS, "InvoiceNo")


    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        LstEmpNo.Enabled = True
        LstEmpNo.Visible = True
        TxtEmpNo.Visible = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        CHKDUP = False
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If BtnEdit.Enabled = True Then
            Dim DeleteCmd1 As String = "DELETE from InlInv where Inv_no='" & LstEmpNo.SelectedValue & "'"
            Dim Cmd As New SqlCommand(DeleteCmd1, CON)
            Cmd.ExecuteNonQuery()

            DeleteCmd1 = "DELETE from InlInv where Inv_no='" & LstEmpNo.SelectedValue & "'"


            Cmd.Connection = CON
            Cmd.CommandText = ("UPDATE InhInv SET Inv_com='" & Mid(LstCom.Text, 1, 3) & "',Inv_dt='" & DateValue(Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4)) & "',Inv_pono= '" & TxtEmpNo.Text & "',Inv_Code= '" & Mid(LstEmpNo.SelectedValue, 1, 5) & "',Inv_vat= '" & Mid(LstEmpNo.SelectedValue, 1, 3) & "' WHERE Inv_no='" & LstEmpNo.SelectedValue & "'")
            Cmd.ExecuteNonQuery()

            Sinvno = LstEmpNo.SelectedValue
        Else

            Cmd.Connection = CON
            Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code,Inv_Vat) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom.Text, 1, 3) & "','" & DateValue(Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4)) & "','" & TxtEmpNo.Text & "','Select','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 5) & "','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 3) & "' )")
            'Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code) VALUES ('" & TxtInvNo.Text & "','" & Mid(Lstcom.text, 1, 3) & "','" & DateValue(Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4)) & "','" & TxtPoNo.Text & "','Select','" & "','" & Mid(Trim(LstCode.SelectedValue), 1, 5) & "' )")
            Cmd.ExecuteNonQuery()
            Sinvno = TxtEmpNo.Text

        End If

        Dim gridrow As DataGridItem
        Dim i As Integer
        Dim t1, t2, t3, t4, t5, t6, t7, t8 As String

        Dim SS As String
        Dim sEmps As String
        Dim dr As DataRow
        Dim SysRtp As Integer
        Dim SysRno As String
        Dim Sysdes1 As String
        Dim sysdes2 As String
        Dim Count As Double
        Dim CMD1 As SqlCommand

        Dim TT As String
        Dim tot1, tot2 As Double
        tot1 = 0
        tot2 = 0

        For Each gridrow In MyDataGrid.Items

            t1 = gridrow.Cells(2).Text()
            t2 = gridrow.Cells(3).Text()
            t3 = gridrow.Cells(4).Text()
            t4 = gridrow.Cells(5).Text()
            t5 = gridrow.Cells(6).Text()


            Dim T3n As Double


            If BtnEdit.Enabled = True Then
                Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val) VALUES ('" & LstEmpNo.SelectedValue & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "')")
            Else
                Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val) VALUES ('" & TxtEmpNo.Text & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "')")
            End If
            Cmd.ExecuteNonQuery()
            Dim T4INT As Double
            T4INT = Val(t4)

            Cmd.CommandText = ("UPDATE ITMMAST SET ITM_STK=ITM_STK+" & T4INT & " WHERE Itm_no='" & t1 & "'")
            Cmd.ExecuteNonQuery()
            tot1 = tot1 + t4
            tot2 = tot2 + t5
        Next
        Cmd.Connection = CON
        Cmd.CommandText = ("UPDATE InhInv SET Inv_TotQty=" & tot1 & ",Inv_TotVal=" & tot2 & " WHERE Inv_no='" & Sinvno & "'")
        Cmd.ExecuteNonQuery()

        Cmd.CommandText = ("UPDATE InvoiceNo SET Inv_No='" & Mid(Sinvno, 3, 9) & "'")
        Cmd.ExecuteNonQuery()


        Dim User1 As String
        Dim Pwd1 As String
        Dim Count1, Count2 As Double

        'User1 = TxtUser1.Text
        'Pwd1 = TxtPwd1.Text
        User1 = "22222"
        Pwd1 = "22222"
        ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_User = '" & User1 & "' AND AD_pwd = '" & Pwd1 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "ADMIN")
        Dim Femail, Temail, Ename As String
        Count = DS.Tables("ADMIN").Rows.Count
        If Count <> 0 Then


            For Each drt2 In DS.Tables("Admin").Rows
                Ename = drt2("Ad_Nam")
                Temail = drt2("Ad_email")

            Next
            Dim ss1 As String
            Dim ln As Integer

            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "trading@dsisamson.com"
            emailMessage.To = Temail

            emailMessage.Subject = "Invoice Details For Check "

            emailMessage.Body = "Inv No :" + Sinvno + " " + Mid(LstCom.Text, 1, 3) + " Total Qty " + Str(tot1) + " Total Value " + Str(tot2) + " http://sgcsser/Insu/InvCheck.aspx"


            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try
        End If
        BtnSave.Enabled = False
    End Sub

    Public Function BindTheCountry()
        Dim strConn As String = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        Dim MySQL As String = "Select Emp_No,Emp_name, Emp_des, " & _
        "Emp_talv, Emp_balv, Emp_tolv from EmpMast"
        Dim MyConn As New SqlConnection(strConn)
        Dim objDR As SqlDataReader
        Dim Cmd As New SqlCommand(MySQL, MyConn)
        MyConn.Open()
        objDR = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

        objConn = New SqlConnection
        objConn.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        objConn.Open()

        Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT Flag FROM Flag", objConn)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        Return cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Sub dtgCustomers_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        ' Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        'objConn = New SqlConnection
        'objConn.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        'objConn.Open()


        Dim cmdCustomers As SqlCommand
        Dim strid As String = CType(e.Item.FindControl("lblNo"), Label).Text
        Dim strfg As String = CType(e.Item.FindControl("ddlCountry"), DropDownList).SelectedItem.Value
        Dim strTpay As Double = Val(CType(e.Item.FindControl("lblTpay"), Label).Text)
        Dim strEfdt As String = CType(e.Item.FindControl("lblEfdt"), Label).Text
        Dim strExdt As String = CType(e.Item.FindControl("lblExdt"), Label).Text
        Dim strVal As String = CType(e.Item.FindControl("lblVal"), Label).Text
        Dim strCom As String = CType(e.Item.FindControl("lblCom"), Label).Text

        Dim Talv As Double
        Dim Balv As Double
        Dim dr1 As DataRow
        Dim strSql As String
        Dim Count1 As Integer

        Dim str_no As String
        Dim str_name As String
        Dim str_mail As String

        strSql = "UPDATE VehMast SET ALLOW2='" & strfg & "' WHERE ALLOW2='Select' and Veh_No='" & strid & "'"
        cmdCustomers = New SqlCommand(strSql, objConn)
        ' objConn.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        dtgCustomers.EditItemIndex = -1
        BindTheGrid1()
        dtgCustomers.Visible = True

        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", objConn)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count1 = DS.Tables("EmpMast").Rows.Count
        If Count1 <> 0 Then
            For Each dr1 In DS.Tables("EmpMast").Rows
                Talv = dr1("Emp_talv")
                Balv = dr1("Emp_balv")
                str_no = dr1("Emp_no")
                str_name = dr1("Emp_name")
                str_mail = dr1("Emp_email")
            Next
        End If

        'TxtNam.Text = dr1("Emp_Name")
        'TxtToLv.Text = dr1("Emp_ToLv")
        'TxtTaLv.Text = dr1("Emp_TaLv")
        'TxtCntNo.Text = dr1("Emp_CntNo")
        ' cmdCustomers.Connection = objConn
        Dim SS As String
        ' SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
        '''cmdCustomers = New SqlCommand(SS, objConn)
        '''objConn.Open()
        '''cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        If strfg = "Approved" Then
            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "121212"
            'TxtMail.Text
            emailMessage.To = str_mail
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Your Payment Notice is Ok"

            emailMessage.Body = "Vehcle No :" + strid + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://sgcsser/Insu/Crs.aspx"
            ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)
                'labelStatus.Text = "Message sent!"
                'Button1.Enabled = False
            Catch ex As Exception
                'labelStatus.Text="Unable to send the e-mail message"
                ' labelStatus.Text = ex.ToString
            End Try
        Else
            If strfg = "Not Approved" Then
                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "1212"
                'TxtMail.Text()
                emailMessage.To = str_mail
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Your Insu Approval is not Ok"

                emailMessage.Body = "Vehcle No :" + str_no + " " + str_name + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Not Ok"
                ' SS = "ID NO: " + TxtId.Text + " " + TxtNam.Text + "  For Your Approval " + "http://192.168.12.207/Insu/LeaveApproval.aspx"

                SmtpMail.SmtpServer = "mail.dsisamson.com"
                Try
                    SmtpMail.Send(emailMessage)

                Catch ex As Exception

                End Try


            End If



        End If

        BindTheGrid()


    End Sub
    Sub MyDataGrid_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(0).Text
        Dim strdes As String = e.Item.Cells(1).Text
        Dim strpr As String = e.Item.Cells(2).Text
        Dim StrQty As String = e.Item.Cells(3).Text
        Dim strval As String = e.Item.Cells(4).Text


        Dim StrSql As String


        StrSql = "UPDATE InlTemp SET Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"
        cmdCustomers = New SqlCommand(StrSql, CON)

        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
        MyDataGrid.Visible = True

    End Sub

    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim stritmNo As String = e.Item.Cells(0).Text
        Dim strdes As String = e.Item.Cells(1).Text
        Dim I As Double = e.Item.Cells(2).Text
        Dim StrQty As String = e.Item.Cells(3).Text
        Dim strval As String = e.Item.Cells(4).Text


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        'Try



        'I = CINT(e.Item.Cells(0).Text);

        ' I = Val(Trim(MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'I = MyDataGrid.DataKeys(e.Item.ItemIndex)
        ' TId.Text = I
        ' Catch ex As Exception
        'labelStatus.Text="Unable to send the e-mail message"
        '    ss = ex.ToString
        'End Try



        ADA = New SqlDataAdapter("SELECT * from EmpMaster1 Where id = " & I, CON)

        DS = New DataSet
        ADA.Fill(DS, "EmpMaster1")

        count1 = DS.Tables("EmpMaster1").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("EmpMaster1").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")
                Empcom = drt2("Emp_Com")
                EmpNo = drt2("Emp_No")
                RelNam = drt2("Rel_Nam")
                RelType = drt2("Rel_Type")
                RelAge = drt2("Rel_Age")
                Relidno = IIf(IsDBNull(drt2("Rel_Idno")), "", drt2("Rel_Idno"))
                ' EntCode = drt2("Ent_Code")
                ss = IIf(IsDBNull(drt2("Ent_Date")), Today(), drt2("Ent_Date"))
                EntDate = Format(CDate(ss), "MM/dd/yyyy")

                DeaFlag = IIf(IsDBNull(drt2("Dea_Flag")), "", drt2("Dea_Flag"))
                Delfg = IIf(IsDBNull(drt2("Del_Fg")), "", drt2("Del_Fg"))

            Next

        End If

        ' Dim DeleteCmd As String = "DELETE from EmpMaster1 Where id = @Id"
        ' Dim Cmd As New SqlCommand(DeleteCmd, CON)
        '
        Cmd.Connection = CON
        If Trim(DeaFlag) = "N" Then

            If (EntDate <> Format(CDate(Today()), "MM/dd/yyyy")) Then
                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "insurance@dsisamson.com"
                'TxtMail.Text
                emailMessage.To = "udanip@samsoncorporates.com,palithan@samsoncorporates.com,chamindas@samsoncorporates.com"
                'emailMessage.Attachments.Add("c:\RtnTxt.txt")
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Try to Delete last Entered record-DDF"

                emailMessage.Body += "Company:" + Trim(Empcom) + " EmpNo " + EmpNo + " Employee " + Trim(TxtEmpNam.Text) & vbCrLf
                emailMessage.Body += "Try to Delete last Entered record-DDF" & vbCrLf
                emailMessage.Body += "-------------------------------------" & vbCrLf
                emailMessage.Body += "Name:" + Trim(RelNam) + " Type: " + Trim(RelType) + " Age:" + Trim(RelAge) & vbCrLf
                emailMessage.Body += "User Code:" + Trim(L1.Text) + " Date: " + Format(DateValue(EntDate), "dd/MM/yyyy") & vbCrLf
                emailMessage.Body += "Death:" + DeaFlag & vbCrLf
                ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

                SmtpMail.SmtpServer = "mail.dsisamson.com"
                Try
                    SmtpMail.Send(emailMessage)
                    'labelStatus.Text = "Message sent!"
                    'Button1.Enabled = False
                Catch ex As Exception
                    'labelStatus.Text="Unable to send the e-mail message"
                    ' labelStatus.Text = ex.ToString
                End Try


            Else

                Dim DeleteCmd As String = "DELETE from EmpMaster1 Where id = " & I
                Dim Cmd As New SqlCommand(DeleteCmd, CON)

                'CMD.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))

                'Dim MyConn As New SqlConnection(CON)

                'CON.Open()
                Cmd.ExecuteNonQuery()

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "insurance@dsisamson.com"
                'TxtMail.Text
                emailMessage.To = "udanip@samsoncorporates.com,health@samsoncorporates.com,chamindas@samsoncorporates.com,palithan@samsoncorporates.com"
                'emailMessage.Attachments.Add("c:\RtnTxt.txt")
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Record Deleted -DDF"

                emailMessage.Body += "Company:" + Trim(Empcom) + " EmpNo " + EmpNo + " Employee " + Trim(TxtEmpNam.Text) & vbCrLf
                emailMessage.Body += "Folowing Record Deleted" & vbCrLf
                emailMessage.Body += "----------------------" & vbCrLf
                emailMessage.Body += "Name:" + Trim(RelNam) + " Type: " + Trim(RelType) + " Age:" + Trim(RelAge) & vbCrLf
                emailMessage.Body += "User Code:" + Trim(L1.Text) + " Date: " + Format(DateValue(EntDate), "dd/MM/yyyy") & vbCrLf
                emailMessage.Body += "Death:" + DeaFlag & vbCrLf
                ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

                ' SmtpMail.SmtpServer = "mail.dsisamson.com"
                Try
                    SmtpMail.Send(emailMessage)
                    'labelStatus.Text = "Message sent!"
                    'Button1.Enabled = False
                Catch ex As Exception
                    'labelStatus.Text="Unable to send the e-mail message"
                    ' labelStatus.Text = ex.ToString
                End Try

            End If
        Else
            If Trim(Delfg) = "Y" Then
                ' Dim DeleteCmd As String = "DELETE from EmpMaster1 Where id =" & I
                ' Dim Cmd As New SqlCommand(DeleteCmd, CON)

                'CMD.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))

                'Cmd.ExecuteNonQuery()

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "insurance@dsisamson.com"
                'TxtMail.Text
                emailMessage.To = "udanip@samsoncorporates.com,palithan@samsoncorporates.com,chamindas@samsoncorporates.com"
                'emailMessage.Attachments.Add("c:\RtnTxt.txt")
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "Try to Delete Death Record -DDF"

                emailMessage.Body += "Company:" + Trim(Empcom) + " EmpNo " + EmpNo + " Employee " + Trim(TxtEmpNam.Text) & vbCrLf
                emailMessage.Body += "Try to Delete Death Record -DDF" & vbCrLf
                emailMessage.Body += "-------------------------------" & vbCrLf
                emailMessage.Body += "Name:" + Trim(RelNam) + " Type: " + Trim(RelType) + " Age:" + Trim(RelAge) & vbCrLf
                emailMessage.Body += "User Code:" + Trim(L1.Text) + " Date: " + Format(DateValue(EntDate), "dd/MM/yyyy") & vbCrLf
                emailMessage.Body += "Death:" + DeaFlag & vbCrLf
                ' emailMessage.Body = "http://sgcsser/Insu/CrsCertificate.aspx"

                SmtpMail.SmtpServer = "mail.dsisamson.com"
                Try
                    SmtpMail.Send(emailMessage)
                    'labelStatus.Text = "Message sent!"
                    'Button1.Enabled = False
                Catch ex As Exception
                    'labelStatus.Text="Unable to send the e-mail message"
                    ' labelStatus.Text = ex.ToString
                End Try
            Else
                Lab6.Visible = True
                Rlist1.Visible = True
                Btn1.Visible = True
                Btn1.Enabled = True


            End If
        End If
        'CON.Close()

        'Lab6.Visible = False
        ' Rlist1.Visible = False
        ' Btn1.Visible = False
        'Btn1.Enabled = False


        BindTheGrid()






    End Sub

    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = e.Item.ItemIndex
        BindTheGrid()
    End Sub
    Sub MyDataGrid_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
    End Sub


    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNo.TextChanged
        LstCom1.Enabled = True
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtEmpAdd.Enabled = True
            TxtDoA.Enabled = True
            For Each drt2 In DS.Tables("EmpMaster").Rows
                StrEmpno = drt2("Emp_No")
                StrEmpCom = drt2("Emp_Com")
                StrEmpNam = drt2("Emp_Nam")
                strEmpIdno = IIf(IsDBNull(drt2("Emp_Idno")) = True, "Blank ", drt2("Emp_Idno"))
                strEmpAdd = IIf(IsDBNull(drt2("Emp_Add")) = True, "Blank ", drt2("Emp_Add"))
                ' StrEmpDoA = Format(CDate(drt2("Emp_DoA")), "dd/MM/yyyy")


                Try
                    StrEmpDoA = Format(CDate(drt2("Emp_DoA")), "dd/MM/yyyy")

                Catch err As Exception
                    StrEmpDoA = Format(CDate(Today()), "dd/MM/yyyy")
                End Try



                Try
                    If Trim(drt2("EmpAct")) = "N" Then
                        Label16.Text = Format(CDate(drt2("Act_Date")), "dd/MM/yyyy")
                    Else
                        Label16.Text = "             "
                    End If


                Catch err As Exception
                    Try
                        Label16.Text = "             "
                    Catch err1 As Exception
                        Label16.Text = "             "
                    End Try



                End Try


                TxtEmpNam.Text = StrEmpNam
                TxtIdNo.Text = strEmpIdno
                TxtEmpAdd.Text = strEmpAdd
                TxtDoA.Text = StrEmpDoA



                Try
                    TxtDob.Text = Format(CDate(drt2("Emp_Dob")), "dd/MM/yyyy")

                Catch err As Exception
                    TxtDob.Text = Format(CDate(Today()), "dd/MM/yyyy")
                End Try






                'TxtDob.Text = drt2("Emp_Dob")
                If TxtDob.Text = "01/12/2032" Then
                    TxtDob.Text = ""
                End If

                Try
                    TxtOldNo.Text = drt2("OldEpfNo")
                Catch err As Exception
                    TxtOldNo.Text = " "
                End Try



            Next
        Else
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtDoA.Enabled = True
            TxtEmpAdd.Enabled = True

            TxtEmpNam.Text = "Record Not Found "
            TxtIdNo.Text = " "
            TxtEmpAdd.Text = " "
            TxtDoA.Text = " "


        End If

        TxtRNam.Text = " "
        TxtRelId.Text = " "
        TxtRelAge.Text = " "
        Txtfg.Text = "N"



        BindTheGrid()

    End Sub

    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpNo.SelectedIndexChanged
        TxtRNam.Text = " "
        TxtRNam.Text = " "
        TxtRelId.Text = " "
        TxtRelAge.Text = " "
        Txtfg.Text = "N"

        BindTheGrid()
    End Sub

    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
    End Sub

    Private Sub BttIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttIns.Click
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpNam As String
        Dim SEmpRetype As String
        Dim SEmpAge As String
        Dim SEmpIdno As String
        Dim SEmpFlag As String



        'Dim SEmpChqNo As String
        'Dim SEmpFlag As String




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        SEmpno = Mid(TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(LstCom1.SelectedValue, 1, 3)
        SEmpNam = Trim(TxtRNam.Text)
        SEmpRetype = LstReltyp.SelectedValue
        SEmpAge = Trim(TxtRelAge.Text)
        SEmpIdno = Trim(TxtRelId.Text)
        'SEmpPayDt = TxtPdt.Text
        'SEmpChqNo = TxtChqNo.Text
        SEmpFlag = Trim(Txtfg.Text)

        If Trim(SEmpNam) = "" Then
            SEmpNam = "Nil"
            SEmpAge = "0"
            SEmpIdno = "Nil"
            SEmpRetype = "Nil"
        End If

        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then
            ss = "UPDATE EmpMaster SET Emp_No='" & TxtEmpNo.Text & "',Emp_Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "',OldEpfNo= '" & TxtOldNo.Text & "',Emp_Nam= '" & TxtEmpNam.Text & "',Emp_Idno= '" & TxtIdNo.Text & "',Emp_Add= '" & TxtEmpAdd.Text & "',Emp_DoB= '" & Mid(Trim(TxtDob.Text), 4, 2) + "/" + Mid(Trim(TxtDob.Text), 1, 2) + "/" + Mid(Trim(TxtDob.Text), 7, 4) & "',Emp_DoA= '" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "' WHERE Emp_No='" & TxtEmpNo.Text & "' and Emp_Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
            CMD.Connection = CON

            If Trim(TxtDob.Text) = "" Then

                CMD.CommandText = ("UPDATE EmpMaster SET Emp_No='" & TxtEmpNo.Text & "',Emp_Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "',OldEpfNo= '" & TxtOldNo.Text & "',Emp_Nam= '" & TxtEmpNam.Text & "',Emp_Idno= '" & TxtIdNo.Text & "',Emp_Add= '" & TxtEmpAdd.Text & "',Emp_DoB= '" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "',Emp_DoA= '" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "' WHERE Emp_No='" & TxtEmpNo.Text & "' and Emp_Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'")
            Else
                CMD.CommandText = ("UPDATE EmpMaster SET Emp_No='" & TxtEmpNo.Text & "',Emp_Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "',OldEpfNo= '" & TxtOldNo.Text & "',Emp_Nam= '" & TxtEmpNam.Text & "',Emp_Idno= '" & TxtIdNo.Text & "',Emp_Add= '" & TxtEmpAdd.Text & "',Emp_DoB= '" & Mid(Trim(TxtDob.Text), 4, 2) + "/" + Mid(Trim(TxtDob.Text), 1, 2) + "/" + Mid(Trim(TxtDob.Text), 7, 4) & "',Emp_DoA= '" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "' WHERE Emp_No='" & TxtEmpNo.Text & "' and Emp_Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'")
            End If
            CMD.ExecuteNonQuery()

        Else
            CMD.Connection = CON

            If Trim(TxtDob.Text) = "" Then
                CMD.CommandText = ("INSERT INTO EmpMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Idno,Emp_Add,Emp_Actv,Emp_DoA,OldEpfNo,EmpAct,EmpDel,Ent_code,Ent_Time,Ent_date) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom1.SelectedValue, 1, 3) & "','" & TxtEmpNam.Text & "','" & TxtIdNo.Text & "','" & TxtEmpAdd.Text & "','Y','" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "','" & Trim(TxtOldNo.Text) & "','Y','N','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
            Else
                CMD.CommandText = ("INSERT INTO EmpMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Idno,Emp_Add,Emp_Actv,Emp_DoA,Emp_Dob,OldEpfNo,EmpAct,EmpDel,Ent_code,Ent_Time,Ent_date) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom1.SelectedValue, 1, 3) & "','" & TxtEmpNam.Text & "','" & TxtIdNo.Text & "','" & TxtEmpAdd.Text & "','Y','" & Mid(Trim(TxtDoA.Text), 4, 2) + "/" + Mid(Trim(TxtDoA.Text), 1, 2) + "/" + Mid(Trim(TxtDoA.Text), 7, 4) & "','" & Mid(Trim(TxtDob.Text), 4, 2) + "/" + Mid(Trim(TxtDob.Text), 1, 2) + "/" + Mid(Trim(TxtDob.Text), 7, 4) & "','" & Trim(TxtOldNo.Text) & "','Y','N','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
            End If
            CMD.ExecuteNonQuery()
        End If

        ADA1 = New SqlDataAdapter("SELECT * FROM EmpMaster1 WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)

        'ADA1 = New SqlDataAdapter("SELECT * FROM EmpMaster1 WHERE Emp_No = '" & TxtEmpNo.Text & "'", CON)
        DS1 = New DataSet
        ss = "SELECT * FROM EmpMaster1 WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA1.Fill(DS1, "EMPMASTER1")

        Count2 = DS1.Tables("EmpMaster1").Rows.Count


        If Count2 <> 0 Then
            Count2 = Count2 + 1
        Else
            Count2 = 1
        End If
        ss = "INSERT INTO EmpMaster1(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_Age,Rel_idno,Dea_Flag) VALUES (" & Count2 & ",'" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "'," & SEmpAge & ",'" & SEmpIdno & "','" & SEmpFlag & "')"

        CMD.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        CMD.CommandText = ("INSERT INTO EmpMaster1(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_Age,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & Count2 & ",'" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "'," & SEmpAge & ",'" & SEmpIdno & "','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
        CMD.ExecuteNonQuery()


        Txtfg.Text = "N"
        TxtRelId.Text = " "
        TxtRNam.Text = " "

        BindTheGrid()



    End Sub

    Private Sub LstCom1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom1.SelectedIndexChanged

        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtEmpAdd.Enabled = True
            TxtDoA.Enabled = True
            For Each drt2 In DS.Tables("EmpMaster").Rows
                StrEmpno = drt2("Emp_No")
                StrEmpCom = drt2("Emp_Com")
                StrEmpNam = drt2("Emp_Nam")
                strEmpIdno = drt2("Emp_Idno")
                strEmpAdd = IIf(IsDBNull(drt2("Emp_Add")) = True, "Blank ", drt2("Emp_Add"))

                ' StrEmpDoA = IIf(IsDBNull(drt2("Emp_DoA")) = True, CDate(Today()), Format(CDate(drt2("Emp_DoA")), "dd/MM/yyyy"))



                Try
                    StrEmpDoA = Format(CDate(drt2("Emp_DoA")), "dd/MM/yyyy")

                Catch err As Exception
                    StrEmpDoA = Format(CDate(Today()), "dd/MM/yyyy")
                End Try



                TxtEmpNam.Text = StrEmpNam
                TxtIdNo.Text = strEmpIdno
                TxtEmpAdd.Text = strEmpAdd
                TxtDoA.Text = StrEmpDoA
            Next
        Else
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True
            TxtDoA.Enabled = True
            TxtEmpAdd.Enabled = True

            TxtEmpNam.Text = " "
            TxtIdNo.Text = " "
            TxtEmpAdd.Text = " "
            TxtDoA.Text = " "


        End If

        TxtRNam.Text = " "
        TxtRelId.Text = " "
        TxtRelAge.Text = " "
        Txtfg.Text = "N"

        BindTheGrid()





    End Sub

    Private Sub MyDataGrid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtEmpAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpAdd.TextChanged

    End Sub
End Class

