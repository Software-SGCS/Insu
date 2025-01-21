Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class HelthEntry
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
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

    Dim Count1, count2 As Integer
    Dim StrEmpCom, StrEmpDes, StrEmpNam, strcomnam, StrCom, StrNam, SEmpCno, SEmpDes, SEmpChqNo, Pflag, Psec As String
    Dim TotAmt1, TotAmt2 As Double

    Public StrEmpNo, StrOldEpfno As String

    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Txtappdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Lstcom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDes As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtInTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOutTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents ChqNo As System.Web.UI.WebControls.Label
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtBal1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtYr As System.Web.UI.WebControls.TextBox
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldEmpNo As System.Web.UI.WebControls.TextBox
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


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        
        pflag = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)




        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        Count1 = DS.Tables("UsdMaster").Rows.Count


        If Count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                count2 = drt2("User_lvl")
                Psec = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If

        '  If Not IsPostBack Then


        If count2 = "1" Then
            Pflag = "Y"

        Else

            If count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level2='1'", CON)

            Else
                If count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level3='1'", CON)

                Else
                    If count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level4='1'", CON)
                    Else
                        If count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If




                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Pflag = "Y"
            End While

            DR.Close()

        End If


        If Pflag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else

            Response.Redirect("POSDispaly11.aspx")
        End If

        'BtnUpdate.Enabled = True

        ' End If


        If Not IsPostBack Then


            If Psec = "ALL" Then
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
            Else
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(Psec) & "'", CON)
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



    End Sub
    Public Sub BindTheGrid()
        'Try
        CON.Close()
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

        ADA = New SqlDataAdapter("SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and (Emp_No='" & Trim(TxtTEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo.Text) & "') and Emp_Accyr='" & Trim(TxtYr.Text) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_No=" & Val(TempEmpno) & " and Emp_Accyr='" & Trim(TxtYr.Text) & "'"
        ADA.Fill(DS, "HltMaster1")

        Count1 = DS.Tables("HltMaster1").Rows.Count

        TotAmt1 = 0
        TotAmt2 = 0

        If Count1 <> 0 Then

            Lstcom.Enabled = True


            For Each drt2 In DS.Tables("HltMaster1").Rows

                If drt2("Emp_Typ") = "Indoor" Then
                    TotAmt1 = TotAmt1 + drt2("Emp_Amt")
                Else
                    TotAmt2 = TotAmt2 + drt2("Emp_Amt")
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
        TxtBal1.Text = Format((5500 - TotAmt2), "###,###,###.00")

        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_ChqNo,Emp_Cno,Emp_Typ,convert(decimal(8,2),Emp_Amt,2) AS Emp_Amt,convert(decimal(8,2),Emp_DecAmt,2) AS Emp_DecAmt, convert(varchar(10),Emp_PayDt,103) as Emp_Paydt from HltMaster1 where (Emp_No='" & Trim(TxtTEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo.Text) & "') and Emp_Com='" & Trim(TempCom) & "' and emp_accyr='" & Trim(TxtYr.Text) & "' ORDER BY ID", CON)
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
        Dim DeleteCmd As String = "DELETE from HltMaster1 Where id = @Id"
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


        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "') and (Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and EmpAct='Y') ", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' OR  OldEpfNo='" & TxtEmpNo.Text & "') and com='" & Mid(Lstcom.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthMaster")

        Count1 = DS.Tables("HthMaster").Rows.Count

        If Count1 <> 0 Then
            TxtNam.ReadOnly = True
            Lstcom.Enabled = True
            BttIns.Enabled = True

            For Each drt2 In DS.Tables("HthMaster").Rows
                StrEmpNo = drt2("EpfNo")
                StrEmpCom = drt2("Com")
                StrEmpNam = drt2("EMPLOYEENAME")
                StrOldEpfno = drt2("OldEpfNo")
                TxtNam.Text = StrEmpNam
                TxtTEmpNo.Text = drt2("EpfNo")
                TxtOldEmpNo.Text = drt2("OldEpfNo")

                ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE COM_NO = '" & StrEmpCom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "COMPANY")
                For Each drt3 In DS.Tables("COMPANY").Rows
                    StrNam = drt3("Com_Nam")
                Next
                Lstcom.SelectedValue = StrEmpCom + " - " + StrNam

            Next
        Else
            TxtNam.ReadOnly = True
            Lstcom.Enabled = True

            TxtNam.Text = "Record No Found "
            BttIns.Enabled = False
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
        Lstcom.Enabled = True

        If TxtEmpNo.Text = "" Then

        Else

            ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' or Oldepfno='" & Trim(TxtEmpNo.Text) & "') and Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "'", CON)
            DS = New DataSet
            ss = "SELECT * FROM HthMaster WHERE EpfNo = " & TxtEmpNo.Text & " and com='" & Mid(Lstcom.SelectedValue, 1, 3) & "'"
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
                    TxtNam.Text = StrEmpNam
                    TxtTEmpNo.Text = drt2("EpfNo")
                    TxtOldEmpNo.Text = drt2("OldEpfNo")

                    ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE COM_NO = '" & StrEmpCom & "'", CON)
                    DS = New DataSet
                    ADA.Fill(DS, "COMPANY")
                    For Each drt3 In DS.Tables("COMPANY").Rows
                        StrNam = drt3("Com_Nam")
                    Next
                    Lstcom.SelectedValue = StrEmpCom + " - " + StrNam

                Next
                TxtChqNo.Text = " "

            Else
                TxtNam.ReadOnly = True
                Lstcom.Enabled = True

                TxtNam.Text = "Record No Found "

            End If
        End If

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




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT Tre_Typ From TreType", CON)
        CMD.ExecuteNonQuery()


        SEmpno = Mid(TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(Lstcom.SelectedValue, 1, 3)

        SEmpAmt = TxtPay.Text
        SEmpTretyp = Lsttyp.SelectedValue
        SEmpAppDt = Txtappdt.Text
        SEmpDes = TxtDes.Text
        SEmpFlag = "Y"
        SEmpChqNo = TxtChqNo.Text
        SEmpCno = TxtCNo.Text

        CMD.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        CMD.CommandText = ("INSERT INTO HltMaster1(Emp_No,Emp_Com,Emp_Des,Emp_Typ,Emp_PayDt,Emp_Amt,Emp_chqNo,Emp_Cno,Emp_yr,Emp_mt,Emp_Accyr,Emp_Recdt,Emp_DecAmt,Emp_Decflg,Emp_Eflg1,Emp_Eflg2) VALUES ('" & Trim(TxtTEmpNo.Text) & "','" & SEmpcom & "','" & SEmpDes & "','" & SEmpTretyp & "','" & Mid(Trim(SEmpAppDt), 4, 2) + "/" + Mid(Trim(SEmpAppDt), 1, 2) + "/" + Mid(Trim(SEmpAppDt), 7, 4) & "'," & SEmpAmt & ",'" & SEmpChqNo & "','" & SEmpCno & "','" & Mid(Trim(SEmpAppDt), 7, 4) & "','" & Mid(Trim(SEmpAppDt), 4, 2) & "','" & Trim(TxtYr.Text) & "','09/01/2009'," & SEmpAmt & ",'No','No','Yes')")
        CMD.ExecuteNonQuery()


        BindTheGrid()



    End Sub

    Private Sub TxtYr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYr.TextChanged
        BindTheGrid()
    End Sub

    Private Sub Lsttyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsttyp.SelectedIndexChanged

    End Sub
End Class

