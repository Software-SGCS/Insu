Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class HthEntry
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2, ss1 As String
    Dim Sinvno As String
    Dim TempEmpno, TempCom As String
    Dim ss As String
    Dim Tno As String
    Dim Tno1 As String
    Dim Tno2 As String
    Dim count1 As Integer
    Dim StrEmpno, StrEmpCom, StrEmpNam, strEmpIdno As String
    Dim TotAmt As Double

    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents BttIns As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents LstCom1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTotAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents ImgBt As System.Web.UI.WebControls.ImageButton
    Protected WithEvents TxtMth As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtYr As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init

        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Global.PwFlag = "N"

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        If Not IsPostBack Then
            Global.PwFlag = "N"

            If Global.PwLevel = "1" Then
                Global.PwFlag = "Y"

            Else

                If Global.PwLevel = "2" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level2='1'", CON)

                Else
                    If Global.PwLevel = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level3='1'", CON)

                    Else
                        If Global.PwLevel = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level4='1'", CON)
                        Else
                            If Global.PwLevel = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level5='1'", CON)

                            Else
                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                            End If




                        End If
                    End If

                End If
                'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                DR = CMD.ExecuteReader
                While DR.Read
                    Global.PwFlag = "Y"
                End While

                DR.Close()

            End If


            If Global.PwFlag = "Y" Then
                Response.AddHeader("Refresh", 1800)
            Else

                Response.Redirect("POSDispaly11.aspx")
            End If


            'If Global.PwFlag = "Y" Then

            'Else
            '    Response.Redirect("InsuDept.aspx")
            'End If


        End If

        'TempCom = Mid(Trim(LstEmpNo.SelectedValue), 9, 3)


        'CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & TempCom & "'", CON)
        CMD = New SqlCommand("SELECT Com_No,Com_nam From Company", CON)

        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCom1.Items.Add(TT)
            End While

            TxtPdt.Text = Format(Today(), "dd/MM/yyyy")

            ss = Mid(TxtPdt.Text, 1, 2) + "/" + Mid(TxtPdt.Text, 4, 2) + "/" + Mid(TxtPdt.Text, 7, 4)

            ss1 = Mid(TxtPdt.Text, 4, 2) + "/" + Mid(TxtPdt.Text, 1, 2) + "/" + Mid(TxtPdt.Text, 7, 4)
            If Month(CDate(ss1)) = 1 Then
                TxtYr.Text = Year(CDate(ss1)) - 1
                TxtMth.Text = MonthName(12)
            Else
                TxtYr.Text = Year(CDate(ss1))
                TxtMth.Text = MonthName(Month(CDate(ss1)) - 1)
            End If

        End If
        DR.Close()


        BindTheGrid()


    End Sub
    Public Sub BindTheGrid()
        'Try
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        If CHKDUP = True Then
            'TempEmpno = Mid('TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom1.SelectedValue, 1, 3)

        Else
            'TempEmpno = Mid('TxtEmpNo.Text, 1, 5)
            TempCom = Mid(LstCom1.SelectedValue, 1, 3)

        End If

        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,convert(varchar(10),Recdate,103) as RecDate,ChqNo,RecAmt,Mth,Yr from HthRecPayment where Com='" & Trim(TempCom) & "' AND Yr='" & Trim(TxtYr.Text) & "' order by YR,convert(varchar(10),Recdate,103)", CON)

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

    Public Sub MyDataGrid_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
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
        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
        MyDataGrid.Visible = True

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
        BindTheGrid()
        MyDataGrid.Visible = True

    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from HthRecPayment Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        CON.Open()
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
        Dim SMth As String
        Dim Mth As String




        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        ' SEmpno = Mid('TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(LstCom1.SelectedValue, 1, 3)
        '
        SEmpDeathAmt = Val(TxtPay.Text)
        SEmpPayDt = Mid(Trim(TxtPdt.Text), 4, 2) + "/" + Mid(Trim(TxtPdt.Text), 1, 2) + "/" + Mid(Trim(TxtPdt.Text), 7, 4)
        SEmpChqNo = TxtChqNo.Text
        SEmpFlag = "Y"
        SMth = TxtMth.Text
        Mth = Mid(TxtPdt.Text, 4, 2)



        ss = "INSERT INTO DeathRecPayment(Com,ChqNo,RecDate,mth,Yr,RecAmt) VALUES ('" & SEmpcom & "','" & SEmpChqNo & "',#" & SEmpPayDt & "#,'" & TxtMth.Text & "','" & TxtYr.Text & "'," & SEmpDeathAmt & ")"
        CMD.Connection = CON

        'CMD.CommandText = ("INSERT INTO DeathRecPayment(Com,ChqNo,RecDate,RecAmt,mth,Yr) VALUES ('" & SEmpcom & "','" & SEmpChqNo & "',#" & SEmpPayDt & "#," & SEmpDeathAmt & ",'" & TxtMth.Text & "','" & TxtYr.Text & "')")
        CMD.CommandText = ("INSERT INTO HthRecPayment(Com,ChqNo,RecDate,RecAmt,Mth,Yr,mt) VALUES ('" & SEmpcom & "','" & SEmpChqNo & "','" & SEmpPayDt & "'," & SEmpDeathAmt & ",'" & SMth & "','" & TxtYr.Text & "','" & Mth & "')")
        CMD.ExecuteNonQuery()

        ADA = New SqlDataAdapter("SELECT * FROM HthRecPayment WHERE Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "' AND Yr='" & Trim(TxtYr.Text) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthRecPayment WHERE Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthRecPayment")

        count1 = DS.Tables("HthRecPayment").Rows.Count

        TotAmt = 0
        If count1 <> 0 Then

            LstCom1.Enabled = True


            For Each drt2 In DS.Tables("HthRecPayment").Rows

                TotAmt = TotAmt + drt2("RecAmt")


            Next
        Else
            'TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            'TxtIdNo.Enabled = True


            'TxtEmpNam.Text = " "
            'TxtIdNo.Text = " "
        End If

        TxtTotAmt.Text = Format(TotAmt, "###,###,###.00")

        BindTheGrid()



    End Sub

    Private Sub LstCom1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom1.SelectedIndexChanged
        ADA = New SqlDataAdapter("SELECT * FROM DeathRecPayment WHERE Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthRecPayment WHERE Com='" & Mid(LstCom1.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthRecPayment")

        count1 = DS.Tables("HthRecPayment").Rows.Count

        TotAmt = 0
        If count1 <> 0 Then

            LstCom1.Enabled = True


            For Each drt2 In DS.Tables("HthRecPayment").Rows

                TotAmt = TotAmt + drt2("RecAmt")


            Next
        Else
            'TxtEmpNam.Enabled = True
            LstCom1.Enabled = True
            'TxtIdNo.Enabled = True


            'TxtEmpNam.Text = " "
            'TxtIdNo.Text = " "
        End If

        TxtTotAmt.Text = Format(TotAmt, "###,###,###.00")


        ' TxtRNam.Text = " "
        TxtPay.Text = " "
        TxtChqNo.Text = " "
        ' TxtDoD.Text = " "
        'TxtPdt.Text = " "

        BindTheGrid()

        ' TxtPdt.Text = Format(Today(), "dd/MM/yyyy")

        ss = Mid(TxtPdt.Text, 4, 2) + "/" + Mid(TxtPdt.Text, 1, 2) + "/" + Mid(TxtPdt.Text, 7, 4)

        ' ss = Mid(TxtPdt.Text, 1, 2) + "/" + Mid(TxtPdt.Text, 4, 2) + "/" + Mid(TxtPdt.Text, 7, 4)

        If Month(CDate(ss)) = 1 Then
            TxtYr.Text = Year(CDate(ss)) - 1
            TxtMth.Text = MonthName(12)
        Else
            TxtYr.Text = Year(CDate(ss))
            TxtMth.Text = MonthName(Month(CDate(ss)) - 1)
        End If


    End Sub
    Private Sub ImgBt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBt.Click
        ' Cal1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtPdt.Text = Format((Cal1.SelectedDate).ToString("dd/MM/yyyy"))
        'Cal1.Visible = False
    End Sub

    Private Sub TxtPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPay.TextChanged

    End Sub

    Private Sub TxtPdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPdt.TextChanged
        ' TxtPdt.Text = Format(Today(), "dd/MM/yyyy")

        'ss = Mid(TxtPdt.Text, 1, 2) + "/" + Mid(TxtPdt.Text, 4, 2) + "/" + Mid(TxtPdt.Text, 7, 4)

        'TxtPdt.Text = Format(Today(), "dd/MM/yyyy")

        ss = Mid(TxtPdt.Text, 4, 2) + "/" + Mid(TxtPdt.Text, 1, 2) + "/" + Mid(TxtPdt.Text, 7, 4)


        If Month(CDate(ss)) = 1 Then
            TxtYr.Text = Year(CDate(ss)) - 1
            TxtMth.Text = MonthName(12)
        Else
            TxtYr.Text = Year(CDate(ss))
            TxtMth.Text = MonthName(Month(CDate(ss)) - 1)
        End If
        'TxtYr.Text = IIf(Month(Today()) = 1, (Year(Today()) - 1), Year(Today()))



    End Sub

    Private Sub TxtYr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYr.TextChanged
        BindTheGrid()
    End Sub

    Private Sub TxtTotAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotAmt.TextChanged

    End Sub
End Class

