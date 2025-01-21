Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class HelthEntryNew
    Inherits System.Web.UI.Page
    Dim CON, CON1 As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD, CMD1 As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt1, drt2, drt3 As DataRow
    Dim CHKDUP As Boolean

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

    Dim Count1, Count2 As Integer
    Dim StrEmpCom, StrEmpDes, StrEmpNam, strcomnam, StrCom, StrNam, SEmpCno, SEmpDes, SEmpChqNo, pflag, psec As String

    Public StrOldEpfno, StrEmpno As String
    Dim TotAmt1, TotAmt2, TotAmt11, TotAmt21, TotAmt3, TotAmt31 As Double


    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Txtappdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Lstcom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtDes As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtInTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOutTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtBal1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtYr As System.Web.UI.WebControls.TextBox
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldempno As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCrTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtOldempno1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldempno2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldempno3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldempno4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents TxtMsg As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEmpAct As System.Web.UI.WebControls.Label
    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
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


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=InsuMid; user id=sa;password=tstc123")
        CON1.Open()
       
        pflag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)




        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        Count1 = DS.Tables("UsdMaster").Rows.Count


        If Count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                Count2 = drt2("User_lvl")
                psec = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If

        ' If Not IsPostBack Then








        If Count2 = "1" Then
            pflag = "Y"

        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntryNew.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntryNew.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntryNew.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntryNew.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If




                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                pflag = "Y"
            End While

            DR.Close()

        End If


        If pflag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else

            Response.Redirect("POSDispaly11.aspx")
        End If

        'BtnUpdate.Enabled = True

        ' End If


        If Not IsPostBack Then

            Txtappdt.Text = Format(DateValue(Today()), "dd/MM/yyyy")

            If psec = "ALL" Then
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
            Else
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(psec) & "'", CON)
            End If

            DR = CMD.ExecuteReader


            Lstcom.Items.Clear()
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                Lstcom.Items.Add(TT)
            End While



            DR.Close()



            BindTheGrid()
        End If



        'If Global.PwFlag = "Y" Then

        'Else
        '    Response.Redirect("InsuDept.aspx")
        'End If




        TempCom = Mid(Trim(Lstcom.SelectedValue), 1, 3)
        TempEmpno = TxtEmpNo.Text


        If Not IsPostBack Then
            CON.Open()
            CMD = New SqlCommand("SELECT Tre_Typ From TreType", CON)

            DR = CMD.ExecuteReader

            TxtYr.Text = Year(Today())

            While DR.Read
                TT = DR.GetValue(0)
                Lsttyp.Items.Add(TT)
            End While


            DR.Close()
        End If





        'CMD = New SqlCommand("SELECT EPFNO,NAME,COM From HltMast where EPFNO='" & TempEmpno & "'", CON)


        'DR = CMD.ExecuteReader

        'LstReNAM.Items.Clear()
        ''If Not IsPostBack Then
        'While DR.Read
        '    TT = DR.GetValue(1)
        '    LstReNAM.Items.Add(TT)
        'End While
        ''End If

        'DR.Close()




    End Sub
    Public Sub BindTheGrid()
        'Try
        ' CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        If CHKDUP = True Then
            TempEmpno = Val(TxtEmpNo.Text)
            TempCom = Mid(Lstcom.SelectedValue, 1, 3)
        Else
            TempEmpno = Val(TxtEmpNo.Text)
            TempCom = Mid(Lstcom.SelectedValue, 1, 3)
        End If

        ADA = New SqlDataAdapter("SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and ((Emp_No='" & StrEmpno & "' or Emp_No='" & StrOldEpfno & "') or (Emp_No='" & Trim(TxtOldempno1.Text) & "' or Emp_No='" & Trim(TxtOldempno2.Text) & "') or (Emp_No='" & Trim(TxtOldempno3.Text) & "' or Emp_No='" & Trim(TxtOldempno4.Text) & "')) and Emp_Accyr='" & Trim(TxtYr.Text) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_No=" & Val(TempEmpno) & " and Emp_Accyr='" & Trim(TxtYr.Text) & "'"
        ADA.Fill(DS, "HltMaster1")

        Count1 = DS.Tables("HltMaster1").Rows.Count


        TotAmt1 = 0
        TotAmt2 = 0
        TotAmt11 = 0
        TotAmt21 = 0

        TotAmt3 = 0
        TotAmt31 = 0
        If Count1 <> 0 Then

            Lstcom.Enabled = True


            For Each drt2 In DS.Tables("HltMaster1").Rows


                If drt2("Emp_Typ") = "Indoor" Then
                    TotAmt1 = TotAmt1 + drt2("Emp_Amt")
                    TotAmt11 = TotAmt11 + drt2("Emp_DecAmt")


                Else
                    If drt2("Emp_Typ") = "Outdoor" Then

                        TotAmt2 = TotAmt2 + drt2("Emp_Amt")
                        TotAmt21 = TotAmt21 + drt2("Emp_DecAmt")
                    Else
                        TotAmt3 = TotAmt3 + drt2("Emp_Amt")
                        TotAmt31 = TotAmt31 + drt2("Emp_DecAmt")

                    End If
                End If

            Next
        Else
            'TxtEmpNam.Enabled = True
            'LstCom1.Enabled = True
            'TxtIdNo.Enabled = True


            'TxtEmpNam.Text = " "
            'TxtIdNo.Text = " "
        End If

        TxtInTot.Text = Format(TotAmt1, "###,###,###.00")
        TxtOutTot.Text = Format(TotAmt2, "###,###,###.00")
        TxtBal1.Text = Format((7500 - TotAmt2), "###,###,###.00")
        TxtCrTot.Text = Format(TotAmt3, "###,###,###.00")


        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_DecAmt,'#,###.00') as Emp_DecAmt,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_ChqNo,Emp_Cno,Emp_Typ,CONVERT(DECIMAL(8,2),Emp_DecAmt,2) AS Emp_DecAmt,CONVERT(DECIMAL(8,2),Emp_Amt,2) AS Emp_Amt, convert(varchar(10),Emp_PayDt,103) as Emp_Paydt,Raw_Rmk from HltMaster1 where (Emp_No='" & Trim(TxtTEmpNo.Text) & "' or Emp_No='" & Trim(TxtOldempno.Text) & "' or Emp_No='" & Trim(TxtOldempno1.Text) & "' or Emp_No='" & Trim(TxtOldempno2.Text) & "' or Emp_No='" & Trim(TxtOldempno3.Text) & "' or Emp_No='" & Trim(TxtOldempno4.Text) & "') and Emp_Com='" & Trim(TempCom) & "' and emp_accyr='" & Trim(TxtYr.Text) & "' ORDER BY ID ", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        CON.Close()

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

        TxtEmpNo.Visible = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        CHKDUP = False
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
        BindTheGrid()
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

        Dim p1 As String
        p1 = e.Item.Cells(3).Text

        Dim DeleteCmd As String = "DELETE from HltMaster1 Where id = @Id and EMP_AMT=0"
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

    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNo.TextChanged
        Lstcom.Enabled = True
        BttIns.Enabled = True
        TxtMsg.Visible = False
        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "' or Oldepfno1='" & Trim(TxtEmpNo.Text) & "' or Oldepfno2='" & Trim(TxtEmpNo.Text) & "' or Oldepfno3='" & Trim(TxtEmpNo.Text) & "' or Oldepfno4='" & Trim(TxtEmpNo.Text) & "') and (Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and EmpAct='Y')", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "') and com='" & Mid(Lstcom.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthMaster")

        Count1 = DS.Tables("HthMaster").Rows.Count

        If Count1 <> 0 Then
            TxtNam.ReadOnly = True
            Lstcom.Enabled = True
            BttIns.Enabled = True
            For Each drt2 In DS.Tables("HthMaster").Rows
                StrEmpno = drt2("EpfNo")
                StrEmpCom = drt2("Com")
                StrEmpNam = drt2("EMPLOYEENAME")
                StrOldEpfno = drt2("OldEpfNo")
                TxtNam.Text = StrEmpNam
                TxtTEmpNo.Text = drt2("EpfNo")
                TxtOldempno.Text = drt2("OldEpfNo")
                TxtOldempno1.Text = drt2("OldEpfNo1")
                TxtOldempno2.Text = drt2("OldEpfNo2")
                TxtOldempno3.Text = drt2("OldEpfNo3")
                TxtOldempno4.Text = drt2("OldEpfNo4")



                ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE COM_NO = '" & StrEmpCom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "COMPANY")
                For Each drt3 In DS.Tables("COMPANY").Rows
                    StrNam = drt3("Com_Nam")
                Next
                Lstcom.SelectedValue = StrEmpCom + " - " + StrNam

            Next
            '''''''''''''
            ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "' or Oldepfno1='" & Trim(TxtEmpNo.Text) & "' or Oldepfno2='" & Trim(TxtEmpNo.Text) & "' or Oldepfno3='" & Trim(TxtEmpNo.Text) & "' or Oldepfno4='" & Trim(TxtEmpNo.Text) & "') and (Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "')", CON1)
            'Else
            ' ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "' or Oldepfno1='" & Trim(TxtEmpNo.Text) & "' or Oldepfno2='" & Trim(TxtEmpNo.Text) & "' or Oldepfno3='" & Trim(TxtEmpNo.Text) & "' or Oldepfno4='" & Trim(TxtEmpNo.Text) & "') and (Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and EmpAct='Y')", CON)
            'End If
            DS = New DataSet
            ss = "SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "') and com='" & Mid(Lstcom.SelectedValue, 1, 3) & "'"
            ADA.Fill(DS, "HthMaster")

            Count1 = DS.Tables("HthMaster").Rows.Count

            If Count1 <> 0 Then
                TxtNam.ReadOnly = True
                Lstcom.Enabled = True
                For Each drt2 In DS.Tables("HthMaster").Rows
                    StrEmpno = drt2("EpfNo")
                    StrEmpCom = drt2("Com")
                    StrEmpNam = drt2("EMPLOYEENAME")
                    StrOldEpfno = drt2("OldEpfNo")

                    TxtEmpAct.Text = drt2("EmpAct")

                    ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE COM_NO = '" & StrEmpCom & "'", CON1)
                    DS = New DataSet
                    ADA.Fill(DS, "COMPANY")
                    For Each drt3 In DS.Tables("COMPANY").Rows
                        StrNam = drt3("Com_Nam")
                    Next
                    ''Lstcom.SelectedValue = StrEmpCom + " - " + StrNam

                Next



                If TxtEmpAct.Text = "Y" Then

                    TxtMsg.Visible = True
                    TxtMsg.Text = "Duplicate Records ....!"
                    BttIns.Enabled = False

                    ''''''''''''''
                    Dim emailMessage As MailMessage
                    emailMessage = New MailMessage
                    emailMessage.From = "insurance@dsisamson.com"
                    'TxtMail.Text
                    emailMessage.To = "chamindas@samsoncorporates.com;udanip@samsoncorporates.com"
                    emailMessage.Bcc = "palithan@samsoncorporates.com;insurance1@samsoncorporates.com;health@samsoncorporates.com"
                    'emailMessage.Cc = str_mail
                    'emailMessage.Bcc = em1
                    emailMessage.Subject = "Duplicate Records Health Normal/Executive"

                    emailMessage.Body += "Emplyee No    :" + StrEmpno & vbCrLf
                    emailMessage.Body += "Employee Name :" + StrEmpNam & vbCrLf
                    emailMessage.Body += "Company       :" + StrEmpCom & vbCrLf
                    emailMessage.Body += "Status Active :" + Trim(TxtEmpAct.Text) & vbCrLf
                    emailMessage.Body += "" & vbCrLf
                    emailMessage.Body += "" & vbCrLf
                    emailMessage.Body += "" & vbCrLf
                    emailMessage.Body += "" & vbCrLf
                    emailMessage.Body += "User Code     :" & Trim(L1.Text) & vbCrLf
                    emailMessage.Body += "" & vbCrLf
                    emailMessage.Body += "" & vbCrLf

                    emailMessage.Body += "From SGCS Insurance Dept" & vbCrLf
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


                    '''''''''''''''


                End If

            End If
            '''''''''''

        Else
            TxtNam.ReadOnly = True
            Lstcom.Enabled = True
            BttIns.Enabled = False
            TxtNam.Text = "Record No Found "

        End If


        BindTheGrid()

    End Sub


    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' TxtRNam.Text = " "
        TxtPay.Text = " "
        'TxtChqNo.Text = " "
        'TxtDoD.Text = " "
        TxtInTot.Text = " "
        TxtOutTot.Text = " "
        BindTheGrid()
    End Sub

    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstcom.SelectedIndexChanged
        'CON.Open()


        'If Global.PSec = "ALL" Then
        'CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
        'Else
        ' CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(Global.PSec) & "'", CON)
        ' End If

        'DR = CMD.ExecuteReader


        'Lstcom.Items.Clear()
        ' While DR.Read
        'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
        'Lstcom.Items.Add(TT)
        'End While



        ' DR.Close()

        Txtappdt.Text = Format(DateValue(Today()), "dd/MM/yyyy")

        BindTheGrid()
    End Sub

    Private Sub BttIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttIns.Click
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpFlag As String
        Dim SEmpTretyp As String
        Dim SEmpAmt As Double
        Dim SEmpAppDt As String
        Dim SEmpNam As String

        ' CON = New SqlConnection
        ' CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        ' CON.Open()

        SEmpno = Mid(TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(Lstcom.SelectedValue, 1, 3)

        SEmpAmt = TxtPay.Text
        SEmpTretyp = Lsttyp.SelectedValue
        SEmpAppDt = Txtappdt.Text
        SEmpDes = TxtDes.Text
        SEmpFlag = "Y"
        SEmpChqNo = TxtChqNo.Text
        SEmpCno = TxtCNo.Text


        Dim Cmd As New SqlCommand("SELECT * FROM COMPANY", CON)

        'CON.Open()
        Cmd.ExecuteNonQuery()

        Cmd.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        Cmd.CommandText = ("INSERT INTO HltMaster1(Emp_No,Emp_Com,Emp_Des,Emp_Typ,Emp_PayDt,Emp_DecAmt,Emp_Amt,Emp_chqNo,Emp_Cno,Emp_yr,Emp_mt,Emp_Accyr,Emp_DecFlg,Emp_Eflg1,Emp_Eflg2,User_Code,User_Time,User_date) VALUES ('" & Trim(TxtTEmpNo.Text) & "','" & SEmpcom & "','" & SEmpDes & "','" & SEmpTretyp & "','" & Mid(Trim(SEmpAppDt), 4, 2) + "/" + Mid(Trim(SEmpAppDt), 1, 2) + "/" + Mid(Trim(SEmpAppDt), 7, 4) & "'," & SEmpAmt & ",0,' ',' ','" & Mid(Trim(SEmpAppDt), 7, 4) & "','" & Mid(Trim(SEmpAppDt), 4, 2) & "','" & Trim(TxtYr.Text) & "','Yes','Yes','Yes','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
        Cmd.ExecuteNonQuery()
        BindTheGrid()
    End Sub

    Private Sub TxtYr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYr.TextChanged
        BindTheGrid()
    End Sub

    Private Sub TxtNam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtTEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTEmpNo.TextChanged

    End Sub
End Class

