Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class DeathDonation21
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
    Dim count1, count2 As Integer
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno, PFlag, psec, FG As String


    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents LstEmpNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtRNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDoD As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents LstReltyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEmpNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstCom1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtIdNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtSeqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtReltyp As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstRnam As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
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
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

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
        TxtPdt.Text = Format(Today(), "dd/MM/yyyy")

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
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DeathDonation21.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DeathDonation21.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DeathDonation21.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='DeathDonation21.aspx' and Form_level5='1'", CON)

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

        'BtnUpdate.Enabled = True




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

        'If Global.PwFlag = "Y" Then

        'Else
        '    Response.Redirect("InsuDept.aspx")
        'End If

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        'If Not IsPostBack Then
        '    CMD1 = New SqlCommand("SELECT Emp_no,Emp_nam,Emp_com From Empmaster order by Emp_Com,Emp_No", CON)

        '    DR1 = CMD1.ExecuteReader


        '    If Not IsPostBack Then
        '    While DR1.Read
        '        Tno = "00000"
        '        Tno = Tno + DR1.GetValue(0)
        '        Tno = Right(Tno, 5)
        '        Tno1 = Space(30)
        '        Tno1 = DR1.GetValue(1) + Tno1
        '        Tno1 = Mid(Tno1, 1, 30)
        '        Tno2 = Mid(DR1.GetValue(2), 1, 3)
        '        TT = Tno + " - " + Tno2 + " - " + Tno1
        '        LstEmpNo.Items.Add(TT)
        '    End While

        '    DR1.Close()
        'End If



        TempCom = Mid(Trim(LstEmpNo.SelectedValue), 9, 3)


        If Not IsPostBack Then
            CMD1 = New SqlCommand("SELECT Emp_RelType From RelationType", CON)


            DR1 = CMD1.ExecuteReader



            While DR1.Read
                TT = DR1.GetValue(0)
                LstReltyp.Items.Add(TT)
            End While
            DR1.Close()

        End If



        ' BindTheGrid()


    End Sub
    Public Sub BindTheGrid()
        'Try
        'CON.Close()
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

        ss = "Select Id,Emp_Nam,Emp_RelType,Convert(Varchar(10),Emp_Dod,103) as EmpDod,Emp_DeathAmt as EmpDeathamt, convert(varchar(10),Emp_PayDt,103) as EmpPaydt,Emp_chqno from RelationMaster where emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Convert(Varchar(10),Emp_Dob,103) as Emp_Dob,Convert(Varchar(10),Emp_InsDt,103) as Emp_Insdt from RelationMaster where emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        ' CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub BindTheGrid1()




        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Inv_Itmno,Inv_Des, Inv_pr as InvPr,Inv_Qty as InvQty, Inv_val as InvVal from InlTemp", CON)

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
            Cmd.CommandText = ("UPDATE InhInv SET Inv_com='" & Mid(LstCom.Text, 1, 3) & "',Inv_dt='" & Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4) & "',Inv_pono= '" & TxtEmpNo.Text & "',Inv_Code= '" & Mid(LstEmpNo.SelectedValue, 1, 5) & "',Inv_vat= '" & Mid(LstEmpNo.SelectedValue, 1, 3) & "' WHERE Inv_no='" & LstEmpNo.SelectedValue & "'")
            Cmd.ExecuteNonQuery()

            Sinvno = LstEmpNo.SelectedValue
        Else

            Cmd.Connection = CON
            Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code,Inv_Vat) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom.Text, 1, 3) & "','" & Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4) & "','" & TxtEmpNo.Text & "','Select','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 5) & "','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 3) & "' )")
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
        objConn.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
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
                    'labelStatus.Text = "Message sent!"
                    'Button1.Enabled = False
                Catch ex As Exception
                    'labelStatus.Text="Unable to send the e-mail message"
                    ' labelStatus.Text = ex.ToString
                End Try


            End If



        End If

        BindTheGrid()


    End Sub
    Sub MyDataGrid_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)

        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text


        Dim StrSql As String


        StrSql = "UPDATE InlTemp SET Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"
        cmdCustomers = New SqlCommand(StrSql, CON)
        ' objConn.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid1()
        MyDataGrid.Visible = True

    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from RelationMaster Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        CON.Close()
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



    Private Sub MyDataGrid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDataGrid.SelectedIndexChanged

    End Sub

    Private Sub TxtInvNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCle.Click

    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

    End Sub

    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNo.TextChanged

        LstCom1.Enabled = True


        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then
            TxtEmpNam.Enabled = False
            LstCom1.Enabled = True
            TxtIdNo.Enabled = False

            For Each drt2 In DS.Tables("EmpMaster").Rows
                StrEmpno = drt2("Emp_No")
                StrEmpCom = drt2("Emp_Com")
                StrEmpNam = drt2("Emp_Nam")
                ' strEmpIdno = drt2("Emp_Idno")
                TxtEmpNam.Text = StrEmpNam
                TxtIdNo.Text = strEmpIdno

            Next
            DR.Close()

            CMD = New SqlCommand("SELECT Seq_No,Rel_Nam,Rel_Type From EmpMaster1 where Emp_No='" & Trim(StrEmpno) & "' and Emp_Com='" & Trim(StrEmpCom) & "' ORDER BY Seq_No", CON)

            DR = CMD.ExecuteReader

            LstRnam.Items.Clear()
            FG = "N"
            TT = "0" + " - " + StrEmpNam + " - " + "Employee"
            LstRnam.Items.Add(TT)
            TxtRNam.Text = StrEmpNam
            TxtReltyp.Text = "Employee"

            While DR.Read
                TT = Str(DR.GetValue(0)) + " - " + Trim(DR.GetValue(1)) + " - " + Trim(DR.GetValue(2))
                LstRnam.Items.Add(TT)
                FG = "Y"
            End While
            DR.Close()




            If FG = "Y" Then
                TxtSeqNo.Text = Mid(LstRnam.SelectedItem.Value, 1, 2)
            Else
                TxtSeqNo.Text = "0"
            End If
            CMD = New SqlCommand("SELECT Seq_No,Rel_Nam,Rel_Type From EmpMaster1 where Emp_No='" & Trim(StrEmpno) & "' and Emp_Com='" & Trim(StrEmpCom) & "' AND Seq_No=" & Trim(TxtSeqNo.Text) & " ORDER BY Seq_No", CON)
            ss = "SELECT Seq_No,Rel_Nam,Rel_Type From EmpMaster1 where Emp_No='" & Trim(StrEmpno) & "' and Emp_Com='" & Trim(StrEmpCom) & "' AND Seq_No=" & Trim(TxtSeqNo.Text) & " ORDER BY Seq_No"
            DR = CMD.ExecuteReader

            ' LstRNam.Items.Clear()

            While DR.Read
                TT = Str(DR.GetValue(0)) + " - " + Trim(DR.GetValue(1)) + " - " + Trim(DR.GetValue(2))
                TxtRNam.Text = Trim(DR.GetValue(1))
                TxtReltyp.Text = Trim(DR.GetValue(2))
            End While


            DR.Close()




        Else
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True

            TxtEmpNam.Text = ""
            TxtIdNo.Text = ""
        End If
        'TxtRNam.Text = ""
        TxtPay.Text = ""
        TxtChqNo.Text = ""
        TxtDoD.Text = ""
        TxtPdt.Text = ""

        BindTheGrid()

    End Sub

    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpNo.SelectedIndexChanged
        TxtRNam.Text = ""
        TxtPay.Text = ""
        TxtChqNo.Text = ""
        TxtDoD.Text = ""
        TxtPdt.Text = ""
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
        Dim SEmpDod As String
        Dim SEmpDeathAmt As Double
        Dim SEmpPayDt As String
        Dim SEmpChqNo As String
        Dim SEmpFlag As String




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        SEmpno = Mid(TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(LstCom1.SelectedValue, 1, 3)
        SEmpNam = Trim(TxtRNam.Text)
        SEmpRetype = TxtReltyp.Text
        SEmpDod = Trim(TxtDoD.Text)
        SEmpDeathAmt = Val(TxtPay.Text)
        SEmpPayDt = Trim(TxtPdt.Text)
        SEmpChqNo = Trim(TxtChqNo.Text)
        SEmpFlag = "Y"



        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then

        Else
            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO EmpMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Idno) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom1.SelectedValue, 1, 3) & "','" & TxtEmpNam.Text & "','" & TxtIdNo.Text & "')")
            CMD.ExecuteNonQuery()
        End If





        CMD.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        ss = "INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Reltype,Emp_Dob,Emp_DeathAmt,Emp_PayDt,Emp_Chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "','" & Mid(SEmpDod, 4, 2) + "/" + Mid(SEmpDod, 1, 2) + "/" + Mid(SEmpDod, 7, 4) & "'," & SEmpDeathAmt & ",'" & Mid(SEmpPayDt, 4, 2) + "/" + Mid(SEmpPayDt, 1, 2) + "/" + Mid(SEmpPayDt, 7, 4) & "','" & SEmpChqNo & "','" & SEmpFlag & "')"


        CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Reltype,Emp_Dob,Emp_InsDt,Emp_Insfg,Emp_DeathFlag,Emp_Recfg,Cer_flag) VALUES ('" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "','" & Mid(SEmpDod, 4, 2) + "/" + Mid(SEmpDod, 1, 2) + "/" + Mid(SEmpDod, 7, 4) & "','" & Mid(SEmpPayDt, 4, 2) + "/" + Mid(SEmpPayDt, 1, 2) + "/" + Mid(SEmpPayDt, 7, 4) & "','Y','" & SEmpFlag & "','N','N')")
        CMD.ExecuteNonQuery()

        If Trim(TxtReltyp.Text) = "Employee" Then
            ' ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
            'ADA.Fill(DS, "EMPMASTER")

            'count1 = DS.Tables("EmpMaster").Rows.Count
            '
            ' If count1 <> 0 Then
            'CMD.Connection = CON
            'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")

            'ss = "update EmpMaster2 set Dea_flag='Y' where Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "' and Emp_No = '" & TxtEmpNo.Text & "' and Seq_No=" & Trim(TxtSeqNo.Text)

            'CMD.CommandText = ("update EmpMaster set EmpDel='Y' where Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "' and Emp_No = '" & TxtEmpNo.Text & "'")
            'CMD.ExecuteNonQuery()



            ' Else
            '  CMD.Connection = CON
            ' CMD.CommandText = ("INSERT INTO EmpMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Idno) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstCom1.SelectedValue, 1, 3) & "','" & TxtEmpNam.Text & "','" & TxtIdNo.Text & "')")
            ' CMD.ExecuteNonQuery()
            'End If


        Else
            'CMD.Connection = CON
            'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")

            ss = "update EmpMaster2 set Dea_flag='Y' where Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "' and Emp_No = '" & TxtEmpNo.Text & "' and Seq_No=" & Trim(TxtSeqNo.Text)

            CMD.CommandText = ("update EmpMaster1 set Dea_flag='Y' where Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "' and Emp_No = '" & TxtEmpNo.Text & "' and Seq_No=" & Trim(TxtSeqNo.Text))
            CMD.ExecuteNonQuery()

        End If

        CMD.CommandText = ("Select * from company")
        CMD.ExecuteNonQuery()




        Dim emailMessage As MailMessage
        emailMessage = New MailMessage
        Dim SCNam, StEmail As String


        ADA = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & SEmpcom & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "Company")

        count2 = DS.Tables("Company").Rows.Count
        For Each drt3 In DS.Tables("Company").Rows

            SCNam = drt3("Com_Nam")
            StEmail = drt3("Com_TEmail")
        Next


        emailMessage.Body = "Intimation of Deaths " & vbCrLf
        emailMessage.Body += " " & vbCrLf
        emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf
        emailMessage.Body += "Company         :" + "" + SCNam & vbCrLf
        emailMessage.Body += " " & vbCrLf
        emailMessage.Body += "Emp No          :" + "" + SEmpno + " Employee Name :" + "" + TxtEmpNam.Text & vbCrLf
        emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf
        emailMessage.Body += " " & vbCrLf
        emailMessage.Body += "Deceased Name   :" + "" + SEmpNam & vbCrLf
        emailMessage.Body += " " & vbCrLf
        emailMessage.Body += "RelationShip    :" + "" + SEmpRetype & vbCrLf
        emailMessage.Body += " " & vbCrLf
        emailMessage.Body += "Date of Death   :" + "" + SEmpDod & vbCrLf
        emailMessage.Body += " " & vbCrLf
        emailMessage.Body += "Date of Confirm :" + "" + SEmpPayDt & vbCrLf
        emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf
        emailMessage.Body += "Created By:" + Trim(L1.Text) & vbCrLf
        emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf
        emailMessage.From = "insurance@dsisamson.com"


        emailMessage.Subject = "Intimation of Deaths " + SEmpcom + " " + SEmpPayDt

        emailMessage.To = "suranjie@samsoncorporates.com,palithan@samsoncorporates.com,chamindas@samsoncorporates.com"
        SmtpMail.SmtpServer = "mail.dsisamson.com"
        Try
            SmtpMail.Send(emailMessage)
            'labelStatus.Text = "Message sent!"
            'Button1.Enabled = False
        Catch ex As Exception
            'labelStatus.Text="Unable to send the e-mail message"
            ' labelStatus.Text = ex.ToString
        End Try

        BindTheGrid()




    End Sub

    Private Sub LstCom1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom1.SelectedIndexChanged
        ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then
            TxtEmpNam.Enabled = False
            LstCom1.Enabled = True
            TxtIdNo.Enabled = False

            For Each drt2 In DS.Tables("EmpMaster").Rows
                StrEmpno = drt2("Emp_No")
                StrEmpCom = drt2("Emp_Com")
                StrEmpNam = drt2("Emp_Nam")
                strEmpIdno = drt2("Emp_Idno")
                TxtEmpNam.Text = StrEmpNam
                TxtIdNo.Text = strEmpIdno

            Next
        Else
            TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            TxtIdNo.Enabled = True


            TxtEmpNam.Text = ""
            TxtIdNo.Text = ""
        End If
        TxtRNam.Text = ""
        TxtPay.Text = ""
        TxtChqNo.Text = ""
        TxtDoD.Text = ""
        TxtPdt.Text = ""

        BindTheGrid()





    End Sub


    Private Sub TxtEmpNam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNam.TextChanged

    End Sub


    Private Sub LstRNam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstRnam.SelectedIndexChanged



        TxtSeqNo.Text = Mid(LstRnam.SelectedItem.Value, 1, 2)
        ss = Mid(LstRnam.SelectedItem.Value, 1, 2)

        CMD = New SqlCommand("SELECT Seq_No,Rel_Nam,Rel_Type From EmpMaster1 where Emp_No='" & Trim(TxtEmpNo.Text) & "' and Emp_Com='" & Mid(Trim(LstCom1.SelectedValue), 1, 3) & "' AND Seq_No=" & Trim(TxtSeqNo.Text) & " ORDER BY Seq_No", CON)

        ss = "SELECT Seq_No,Rel_Nam,Rel_Type From EmpMaster1 where Emp_No='" & Trim(TxtEmpNo.Text) & "' and Emp_Com='" & Mid(Trim(LstCom1.SelectedValue), 1, 3) & "' AND Seq_No=" & Trim(TxtSeqNo.Text) & " ORDER BY Seq_No"
        'CMD = New SqlCommand("SELECT Seq_No,Rel_Nam,Rel_Type From EmpMaster1 where Emp_No='" & Trim(TxtEmpNo.Text) & "' and Emp_Com='" & Trim(StrEmpCom) & "'", CON)
        DR = CMD.ExecuteReader

        ' LstRNam.Items.Clear()
        TxtRNam.Text = Mid(LstRnam.SelectedItem.Value, 4, 30)
        TxtReltyp.Text = "Employee"
        While DR.Read
            TT = Str(DR.GetValue(0)) + " - " + Trim(DR.GetValue(1)) + " - " + Trim(DR.GetValue(2))
            TxtRNam.Text = Trim(DR.GetValue(1))
            TxtReltyp.Text = Trim(DR.GetValue(2))
        End While




    End Sub
End Class

