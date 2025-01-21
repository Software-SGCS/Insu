Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail

Public Class PosEntrySupply
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3, drt1 As DataRow
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
    Dim StrComno, StrComEmail, StrComNam, StrComVat, StrComPer, StrComAdd, StrComTelno, StrComCrd As String

    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label

    Protected WithEvents Label9 As System.Web.UI.WebControls.Label

    Protected WithEvents lbtnEdit As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lbtnUpdate As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lbtnCancel As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lblDelete As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents BttIns1 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCrd As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtComNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtComPer As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtComAdd As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtComNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtemail As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtVat As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTelno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

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

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            If Global.PwLevel = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosEntrySupply.aspx' and Form_level2='1'", CON)

            Else
                If Global.PwLevel = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosEntrySupply.aspx' and Form_level3='1'", CON)

                Else
                    If Global.PwLevel = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosEntrySupply.aspx' and Form_level4='1'", CON)
                    Else
                        If Global.PwLevel = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosEntrySupply.aspx' and Form_level5='1'", CON)
                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If
                    End If
                End If

            End If




            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosEntrySupply.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        'If Global.PwFlag = "Y" Then
        '    Response.AddHeader("Refresh", 1800)
        'Else
        '    Response.Redirect("Dispaly12.aspx")
        'End If

        '  CMD = New SqlCommand("SELECT Emp_no,Emp_nam From Empmaster order by Emp_No", CON)

        'DR = CMD.ExecuteReader


        'If Not IsPostBack Then
        'While DR.Read
        'Tno = "000000"
        'Tno = Tno + DR.GetValue(0)
        'Tno = Right(Tno, 6)
        'Tno1 = Space(50)
        'Tno1 = DR.GetValue(1) + Tno1
        'Tno1 = Mid(Tno1, 1, 50)

        'TT = Tno + " - " + Tno1
        ''  LstEmpNo.Items.Add(TT)
        'End While
        'End If

        '  DR.Close()

        'TempCom = Mid(Trim(LstEmpNo.SelectedValue), 9, 3)







        BindTheGrid()


    End Sub
    Public Sub BindTheGrid()
        'Try
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Com_No,Com_Nam,Com_Add1,Com_Email From Supplier order by Com_no", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        MyDataGrid.Enabled = True

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub



    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'LstSec.Visible = False
        'LstEmpNo.Enabled = False
        'LstEmpNo.Visible = False
        'TxtEmpNo.Visible = True
        CHKDUP = True
        ' TxtEmpNo.Text = " "

        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)
        DS = New DataSet
        ADA.Fill(DS, "InvoiceNo")


    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        'LstEmpNo.Enabled = True
        ' LstEmpNo.Visible = True
        ' TxtEmpNo.Visible = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        CHKDUP = False
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If BtnEdit.Enabled = True Then
            ' Dim DeleteCmd1 As String = "DELETE from InlInv where Inv_no='" & LstEmpNo.SelectedValue & "'"
            'Dim Cmd As New SqlCommand(DeleteCmd1, CON)
            CMD.ExecuteNonQuery()

            ' DeleteCmd1 = "DELETE from InlInv where Inv_no='" & LstEmpNo.SelectedValue & "'"


            CMD.Connection = CON
            ' Cmd.CommandText = ("UPDATE InhInv SET Inv_com='" & Mid(LstSec.SelectedValue, 1, 3) & "',Inv_dt='" & DateValue(Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4)) & "',Inv_pono= '" & TxtEmpNo.Text & "',Inv_Code= '" & Mid(LstEmpNo.SelectedValue, 1, 5) & "',Inv_vat= '" & Mid(LstEmpNo.SelectedValue, 1, 3) & "' WHERE Inv_no='" & LstEmpNo.SelectedValue & "'")
            CMD.ExecuteNonQuery()

            'Sinvno = LstEmpNo.SelectedValue
        Else

            CMD.Connection = CON
            'Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code,Inv_Vat) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstSec.SelectedValue, 1, 3) & "','" & DateValue(Mid(Trim(TxtEmpNo.Text), 4, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 1, 2) + "/" + Mid(Trim(TxtEmpNo.Text), 7, 4)) & "','" & TxtEmpNo.Text & "','Select','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 5) & "','" & Mid(Trim(LstEmpNo.SelectedValue), 1, 3) & "' )")
            'Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code) VALUES ('" & TxtInvNo.Text & "','" & Mid(LstSec.Selectedvalue, 1, 3) & "','" & DateValue(Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4)) & "','" & TxtPoNo.Text & "','Select','" & "','" & Mid(Trim(LstCode.SelectedValue), 1, 5) & "' )")
            CMD.ExecuteNonQuery()
            'Sinvno = TxtEmpNo.Text

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
                ' Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val) VALUES ('" & LstEmpNo.SelectedValue & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "')")
            Else
                'Cmd.CommandText = ("INSERT INTO InlInv (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pri,Inv_val) VALUES ('" & TxtEmpNo.Text & "','" & t1 & "','" & t4 & "','" & t3 & "','" & t5 & "')")
            End If
            CMD.ExecuteNonQuery()
            Dim T4INT As Double
            T4INT = Val(t4)

            CMD.CommandText = ("UPDATE ITMMAST SET ITM_STK=ITM_STK+" & T4INT & " WHERE Itm_no='" & t1 & "'")
            CMD.ExecuteNonQuery()
            tot1 = tot1 + t4
            tot2 = tot2 + t5
        Next
        CMD.Connection = CON
        CMD.CommandText = ("UPDATE InhInv SET Inv_TotQty=" & tot1 & ",Inv_TotVal=" & tot2 & " WHERE Inv_no='" & Sinvno & "'")
        CMD.ExecuteNonQuery()

        CMD.CommandText = ("UPDATE InvoiceNo SET Inv_No='" & Mid(Sinvno, 3, 9) & "'")
        CMD.ExecuteNonQuery()


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

            'emailMessage.Body = "Inv No :" + Sinvno + " " + Mid(LstSec.SelectedValue, 1, 3) + " Total Qty " + Str(tot1) + " Total Value " + Str(tot2) + " http://Intranet/Insu/InvCheck.aspx"


            SmtpMail.SmtpServer = "203.115.0.79"
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

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT Flag FROM Flag", CON)

        cmdCustomers.CommandType = CommandType.Text
        'Con.Open()
        Return cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Sub dtgCustomers_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        ' Dim Con As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))
        'Con = New SqlConnection
        'Con.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Insu.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        'Con.Open()


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
        cmdCustomers = New SqlCommand(strSql, CON)
        ' Con.Open()
        cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        dtgCustomers.EditItemIndex = -1
        BindTheGrid()
        dtgCustomers.Visible = True

        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '22222'", CON)
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
        ' cmdCustomers.Connection = Con
        Dim SS As String
        ' SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
        '''cmdCustomers = New SqlCommand(SS, Con)
        '''Con.Open()
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

            emailMessage.Body = "Vehcle No :" + strid + " " + strCom + " " + " From :" + strEfdt + " to :" + strExdt + " Approval is Ok" + "      " + "http://Intranet/Insu/Crs.aspx"
            ' emailMessage.Body = "http://Intranet/Insu/CrsCertificate.aspx"

            SmtpMail.SmtpServer = "203.115.0.79"
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

                SmtpMail.SmtpServer = "203.115.0.79"
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
        ' Con.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
        MyDataGrid.Visible = True

    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from Supplier Where id = @Id"
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
    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LstEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        BindTheGrid()
    End Sub

    Private Sub LstSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
    End Sub

    Private Sub BttIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpNam As String
        Dim SEmpRetype As String
        Dim SEmpAge As String
        Dim SEmpIdno As String
        Dim SEmpFlag As String

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        'SEmpno = Mid(TxtEmpNo.Text, 1, 5)


        'ADA = New SqlDataAdapter("SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstSec.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        'ss = "SELECT * FROM EmpMaster WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstSec.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "EMPMASTER")

        count1 = DS.Tables("EmpMaster").Rows.Count

        If count1 <> 0 Then

            CMD.Connection = CON
            ' CMD.CommandText = ("UPDATE EmpMaster SET Emp_No='" & TxtEmpNo.Text & "',Emp_Com='" & Mid(LstSec.SelectedValue, 1, 3) & "',Emp_Nam= '" & TxtEmpNam.Text & "',Emp_Idno= '" & TxtIdNo.Text & "',Emp_Add= '" & TxtEmpAdd.Text & "',Emp_DoA= #" & Mid(Trim(TxtDoJ.Text), 4, 2) + "/" + Mid(Trim(TxtDoJ.Text), 1, 2) + "/" + Mid(Trim(TxtDoJ.Text), 7, 4) & "# WHERE Emp_No='" & TxtEmpNo.Text & "' and Emp_Com='" & Mid(LstSec.SelectedValue, 1, 3) & "'")
            CMD.ExecuteNonQuery()

        Else
            CMD.Connection = CON
            'CMD.CommandText = ("INSERT INTO EmpMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Idno,Emp_Add,Emp_Actv,Emp_DoA) VALUES ('" & TxtEmpNo.Text & "','" & Mid(LstSec.SelectedValue, 1, 3) & "','" & TxtEmpNam.Text & "','" & TxtIdNo.Text & "','" & TxtEmpAdd.Text & "','Y',#" & Mid(Trim(TxtDoJ.Text), 4, 2) + "/" + Mid(Trim(TxtDoJ.Text), 1, 2) + "/" + Mid(Trim(TxtDoJ.Text), 7, 4) & "#)")
            CMD.ExecuteNonQuery()
        End If

        'ADA1 = New SqlDataAdapter("SELECT * FROM EmpMaster1 WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstSec.SelectedValue, 1, 3) & "'", CON)


        DS1 = New DataSet
        'ss = "SELECT * FROM EmpMaster1 WHERE Emp_No = '" & TxtEmpNo.Text & "' and Emp_com='" & Mid(LstSec.SelectedValue, 1, 3) & "'"
        ADA1.Fill(DS1, "EMPMASTER1")

        Count2 = DS1.Tables("EmpMaster1").Rows.Count


        If Count2 <> 0 Then
            Count2 = Count2 + 1
        Else
            Count2 = 1
        End If
        ss = "INSERT INTO EmpMaster1(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_Age,Rel_idno,Dea_Flag) VALUES (" & Count2 & ",'" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "'," & SEmpAge & ",'" & SEmpIdno & "','" & SEmpFlag & "')"

        CMD.Connection = CON

        CMD.CommandText = ("INSERT INTO EmpMaster1(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_Age,Rel_idno,Dea_Flag) VALUES (" & Count2 & ",'" & SEmpno & "','" & SEmpcom & "','" & SEmpNam & "','" & SEmpRetype & "'," & SEmpAge & ",'" & SEmpIdno & "','" & SEmpFlag & "')")
        CMD.ExecuteNonQuery()

        BindTheGrid()

    End Sub

    '

    Private Sub BttIns1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttIns1.Click
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpNam As String
        Dim SEmpRetype As String
        Dim SEmpAge As String
        Dim SEmpIdno As String
        Dim SEmpFlag As String

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        SEmpno = Mid(TxtComNo.Text, 1, 8)

        ADA = New SqlDataAdapter("SELECT * FROM Supplier WHERE Com_No = '" & Trim(TxtComNo.Text) & "'", CON)
        DS = New DataSet
        'ss = "UPDATE Supplier SET Com_No='" & TxtComNo.Text & "'TxtEmpNam.Text & "',Emp_Id= '" & TxtIdNo.Text & "',Emp_Add= '" & TxtEmpAdd.Text & "',User_Code= '" & Global.PUserId & "',Emp_Sex= '" & Mid(LstSex.SelectedValue, 1, 6) & "',Emp_Flag1= '" & Trim(LstYesNo.SelectedValue) & "',Emp_DoJ= '" & Mid(Trim(TxtDoJ.Text), 4, 2) + "/" + Mid(Trim(TxtDoJ.Text), 1, 2) + "/" + Mid(Trim(TxtDoJ.Text), 7, 4) & "' WHERE Emp_No='" & TxtEmpNo.Text & "'"
        ADA.Fill(DS, "Supplier")

        count1 = DS.Tables("Supplier").Rows.Count
        If count1 <> 0 Then

            CMD.Connection = CON
            CMD.CommandText = ("UPDATE Supplier SET Com_No='" & Trim(TxtComNo.Text) & "',Com_Nam='" & Trim(TxtComNam.Text) & "',Com_Add1= '" & TxtComAdd.Text & "',Com_Per= '" & TxtComPer.Text & "',Com_Email= '" & Txtemail.Text & "',Com_Vat= '" & TxtVat.Text & "' WHERE Com_No='" & TxtComNo.Text & "'")
            CMD.ExecuteNonQuery()

        Else
            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO Supplier(Com_No,Com_Nam,Com_Add1,Com_Per,Com_Email,Com_Vat) VALUES ('" & Trim(TxtComNo.Text) & "','" & Trim(TxtComNam.Text) & "','" & TxtComAdd.Text & "','" & TxtComPer.Text & "','" & Txtemail.Text & "','" & TxtVat.Text & "')")
            CMD.ExecuteNonQuery()
        End If

        BindTheGrid()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'LstSec.Enabled = True
        BttIns1.Enabled = True

        ADA = New SqlDataAdapter("SELECT * FROM Supplier WHERE Com_No = '" & TxtComNo.Text & "'", CON)
        DS = New DataSet

        ADA.Fill(DS, "Supplier")

        count1 = DS.Tables("Supplier").Rows.Count

        If count1 <> 0 Then
            TxtComNam.Enabled = True
            'LstSec.Enabled = True
            'TxtIdNo.Enabled = True
            TxtComAdd.Enabled = True
            TxtComPer.Enabled = True
            Txtemail.Enabled = True
            TxtVat.Enabled = True
            TxtCrd.Enabled = True
            TxtTelno.Enabled = True

            ' BttIns.Enabled = True
            'LstSex.Enabled = True
            'LstYesNo.Enabled = True

            For Each drt2 In DS.Tables("Supplier").Rows
                StrComno = drt2("Com_No")
                StrComAdd = IIf(IsDBNull(drt2("Com_add1")) = True, "Blank ", drt2("Com_add1"))
                StrComNam = IIf(IsDBNull(drt2("Com_Nam")) = True, "Blank ", drt2("Com_Nam"))
                StrComPer = IIf(IsDBNull(drt2("Com_Per")) = True, "Blank ", drt2("Com_Per"))
                StrComEmail = IIf(IsDBNull(drt2("Com_Email")) = True, "Blank ", drt2("Com_Email"))
                StrComVat = IIf(IsDBNull(drt2("Com_Vat")) = True, "Blank ", drt2("Com_Vat"))
                '  StrComCrd = IIf(IsDBNull(drt2("Com_Crd")) = True, "Blank ", drt2("Com_Crd"))
                'StrComTelno = IIf(IsDBNull(drt2("Com_TelNo")) = True, "Blank ", drt2("Com_TelNo"))

                ' StrEmpDoJ = Format(CDate(drt2("Emp_DoA")), "dd/MM/yyyy")


                TxtComNo.Text = StrComno
                TxtComAdd.Text = StrComAdd
                TxtComNam.Text = StrComNam
                TxtComPer.Text = StrComPer
                Txtemail.Text = StrComEmail
                TxtVat.Text = StrComVat
                'TxtCrd.Text = StrComCrd
                'TxtTelno.Text = StrComTelno

                ' LstSex.SelectedValue = StrEmpsex


                'LstSec.SelectedValue = Trim(StrEmpSec) + " - " + Trim(StrSecDesc)
                'LstYesNo.SelectedValue = Trim(StrYesNo)
            Next


        Else
            'TxtComNo.Text = StrComno
            TxtComAdd.Text = " "
            TxtComNam.Text = " "
            TxtComPer.Text = " "
            Txtemail.Text = " "
            TxtVat.Text = " "
            TxtCrd.Text = " "
            TxtTelno.Text = " "


        End If

        BindTheGrid()


    End Sub


    Private Sub TxtComNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComNo.TextChanged
        BttIns1.Enabled = True

        ADA = New SqlDataAdapter("SELECT * FROM Supplier WHERE Com_No = '" & TxtComNo.Text & "'", CON)
        DS = New DataSet

        ADA.Fill(DS, "Supplier")

        count1 = DS.Tables("Supplier").Rows.Count

        If count1 <> 0 Then
            TxtComNam.Enabled = True
            'LstSec.Enabled = True
            'TxtIdNo.Enabled = True
            TxtComAdd.Enabled = True
            TxtComPer.Enabled = True
            Txtemail.Enabled = True
            TxtVat.Enabled = True
            TxtCrd.Enabled = True
            TxtTelno.Enabled = True

            ' BttIns.Enabled = True
            'LstSex.Enabled = True
            'LstYesNo.Enabled = True

            For Each drt2 In DS.Tables("Supplier").Rows
                StrComno = drt2("Com_No")
                StrComAdd = IIf(IsDBNull(drt2("Com_add1")) = True, "Blank ", drt2("Com_add1"))
                StrComNam = IIf(IsDBNull(drt2("Com_Nam")) = True, "Blank ", drt2("Com_Nam"))
                StrComPer = IIf(IsDBNull(drt2("Com_Per")) = True, "Blank ", drt2("Com_Per"))
                StrComEmail = IIf(IsDBNull(drt2("Com_Email")) = True, "Blank ", drt2("Com_Email"))
                StrComVat = IIf(IsDBNull(drt2("Com_Vat")) = True, "Blank ", drt2("Com_Vat"))
                '    StrComCrd = IIf(IsDBNull(drt2("Com_Crd")) = True, "Blank ", drt2("Com_Crd"))
                '   StrComTelno = IIf(IsDBNull(drt2("Com_TelNo")) = True, "Blank ", drt2("Com_TelNo"))

                ' StrEmpDoJ = Format(CDate(drt2("Emp_DoA")), "dd/MM/yyyy")


                TxtComNo.Text = StrComno
                TxtComAdd.Text = StrComAdd
                TxtComNam.Text = StrComNam
                TxtComPer.Text = StrComPer
                Txtemail.Text = StrComEmail
                TxtVat.Text = StrComVat
                '  TxtCrd.Text = StrComCrd
                ' TxtTelno.Text = StrComTelno

                ' LstSex.SelectedValue = StrEmpsex


                'LstSec.SelectedValue = Trim(StrEmpSec) + " - " + Trim(StrSecDesc)
                'LstYesNo.SelectedValue = Trim(StrYesNo)
            Next


        Else
            'TxtComNo.Text = StrComno
            TxtComAdd.Text = " "
            TxtComNam.Text = " "
            TxtComPer.Text = " "
            Txtemail.Text = " "
            TxtVat.Text = " "
            TxtCrd.Text = " "
            TxtTelno.Text = " "


        End If

        BindTheGrid()

    End Sub
End Class

