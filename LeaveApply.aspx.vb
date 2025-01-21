Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class LeaveApply
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Protected WithEvents TxtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Dim PAG As Boolean
    Public com As String
    Public Com1 As String
    Protected WithEvents TxtCom1 As System.Web.UI.WebControls.TextBox
    Public email1 As String




#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnApp As System.Web.UI.WebControls.Button
    Protected WithEvents Pan1 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtUser As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtToLv As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTaLv As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtBl As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtApDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents LstLvTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtfdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRes As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstSub As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label26 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNoLv As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label27 As System.Web.UI.WebControls.Label
    Protected WithEvents Label28 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label29 As System.Web.UI.WebControls.Label

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
        CON.ConnectionString = ("Jet Sql:Global Partial Bulk Ops=2;Jet Sql:Registry Path=;Jet Sql:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Leave\Data\Leave.mdb;Mode=Share Deny None;Jet Sql:Engine Type=5;Provider=Microsoft.Jet.Sql.4.0;Jet Sql:System database=;Jet Sql:SFP=False;persist security info=False;Extended Properties=;Jet Sql:Compact Without Replica Repair=False;Jet Sql:Encrypt Database=False;Jet Sql:Create System Database=False;Jet Sql:Don't Copy Locale on Compact=False;User ID=Admin;Jet Sql:Global Bulk Transactions=1")
        CON.Open()


        If Not IsPostBack Then
            Dim TT As String

            CMD = New SqlCommand("SELECT Emp_lvtyp,Emp_LvDes FROM LeaveType", CON)
            DR = CMD.ExecuteReader
            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(0) + "-" + DR.GetValue(1)
                    LstLvTyp.Items.Add(TT)
                End While
            End If
            DR.Close()


            CMD = New SqlCommand("SELECT Emp_No,Emp_name From Empmast order by emp_name", CON)
            DR = CMD.ExecuteReader


            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(0) + "-" + DR.GetValue(1)
                    LstSub.Items.Add(TT)
                End While
            End If

            DR.Close()

            TxtId.Enabled = False
            TxtNam.Enabled = False
            TxtCom.Enabled = False
            TxtToLv.Enabled = False
            TxtTaLv.Enabled = False
            TxtBl.Enabled = False
            TxtApDt.Enabled = False
            LstLvTyp.Enabled = False
            Txtfdt.Enabled = False
            TxtTdt.Enabled = False
            TxtNoLv.Enabled = False
            TxtRes.Enabled = False
            LstSub.Enabled = False
            BtnEdit.Enabled = False
            BtnCle.Enabled = False
            BtnDel.Enabled = False
            BtnApp.Enabled = False


            TxtId.Visible = False
            TxtNam.Visible = False
            TxtCom.Visible = False
            TxtToLv.Visible = False
            TxtTaLv.Visible = False
            TxtBl.Visible = False
            TxtApDt.Visible = False
            LstLvTyp.Visible = False
            Txtfdt.Visible = False
            TxtTdt.Visible = False
            TxtNoLv.Visible = False
            TxtRes.Visible = False
            LstSub.Visible = False
            BtnEdit.Visible = False
            BtnCle.Visible = False
            BtnDel.Visible = False
            BtnApp.Visible = False


        End If






        CON.Close()





    End Sub

    Private Sub TxtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim User1 As String
        Dim Pwd1 As String
        Dim Count, Count1, Count2 As Double
        Dim dr1, dr2, dr3 As DataRow
        User1 = TxtUser.Text
        Pwd1 = TxtPwd.Text



        'CMD = New SqlCommand("SELECT * FROM EMPMAST WHERE EMP_COM = '" & COM & "' AND EMP_NO = '" & IDNO & "'", CON)
        'RE = CMD.ExecuteReader

        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_User = '" & User1 & "' AND EMP_pwd = '" & pwd1 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count = DS.Tables("EmpMast").Rows.Count
        If Count <> 0 Then
            TxtId.Enabled = True
            TxtNam.Enabled = True
            TxtCom.Enabled = True
            TxtToLv.Enabled = True
            TxtTaLv.Enabled = True
            TxtBl.Enabled = True
            TxtApDt.Enabled = True

            TxtId.ReadOnly = True
            TxtNam.ReadOnly = True
            TxtCom.ReadOnly = True
            TxtToLv.ReadOnly = True
            TxtTaLv.ReadOnly = True
            TxtBl.ReadOnly = True
            TxtApDt.ReadOnly = True
            'TxtApDt.Text 

            LstLvTyp.Enabled = True
            Txtfdt.Enabled = True
            TxtTdt.Enabled = True
            TxtNoLv.Enabled = True
            TxtRes.Enabled = True
            LstSub.Enabled = True
            BtnEdit.Enabled = True
            BtnCle.Enabled = True
            BtnDel.Enabled = False
            BtnApp.Enabled = True

            TxtId.Visible = True
            TxtNam.Visible = True
            TxtCom.Visible = True
            TxtToLv.Visible = True
            TxtTaLv.Visible = True
            TxtBl.Visible = True
            TxtApDt.Visible = True
            LstLvTyp.Visible = True
            Txtfdt.Visible = True
            TxtTdt.Visible = True
            TxtNoLv.Visible = True
            TxtRes.Visible = True
            LstSub.Visible = True
            BtnEdit.Visible = True
            BtnCle.Visible = True
            BtnDel.Visible = True
            BtnApp.Visible = True

            For Each dr1 In DS.Tables("EmpMast").Rows
                TxtId.Text = dr1("Emp_No")
                TxtNam.Text = dr1("Emp_Name")
                TxtToLv.Text = dr1("Emp_ToLv")
                TxtTaLv.Text = dr1("Emp_TaLv")
                TxtBl.Text = (dr1("Emp_ToLv") - dr1("Emp_TaLv"))
                TxtCom1.Text = dr1("Emp_com")
                com = dr1("Emp_com")
                email1 = dr1("Emp_email")
                ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE EMP_COM = '" & com & "'", CON)
                DS1 = New DataSet
                ADA.Fill(DS1, "COMPANY")

                Count1 = DS1.Tables("COMPANY").Rows.Count
                If Count1 <> 0 Then
                    For Each dr2 In DS1.Tables("COMPANY").Rows

                        TxtCom.Text = dr2("Emp_nam")
                    Next

                Else
                    TxtCom.Text = "Record Not Found !"

                End If

            Next


            ADA = New SqlDataAdapter("SELECT * FROM CurDatefile Where flag='Y'", CON)
            ds2 = New DataSet
            ADA.Fill(ds2, "CurDatefile")

            Count2 = ds2.Tables("CurDatefile").Rows.Count
            If Count2 <> 0 Then
                For Each dr3 In ds2.Tables("CurDatefile").Rows
                    If dr3("flag") = "Y" Then
                        'TxtApDt.Text = dr3("CurDate")
                        'Txtfdt.Text = dr3("CurDate")
                        'TxtTdt.Text = dr3("CurDate")
                    End If
                    TxtApDt.Text = Format(CDate(Date.Today), "dd/MM/yyyy")

                    Txtfdt.Text = Format(CDate(Date.Today), "dd/MM/yyyy")
                    TxtTdt.Text = Format(CDate(Date.Today), "dd/MM/yyyy")
                Next

            Else
                TxtApDt.Text = "Record Not Found !"

            End If

        Else

            TxtId.Enabled = False
            TxtNam.Enabled = False
            TxtCom.Enabled = False
            TxtToLv.Enabled = False
            TxtTaLv.Enabled = False
            TxtBl.Enabled = False
            TxtApDt.Enabled = False
            LstLvTyp.Enabled = False
            Txtfdt.Enabled = False
            TxtTdt.Enabled = False
            TxtNoLv.Enabled = False
            TxtRes.Enabled = False
            LstSub.Enabled = False
            BtnEdit.Enabled = False
            BtnCle.Enabled = False
            BtnDel.Enabled = False
            BtnApp.Enabled = False


            TxtId.Visible = False
            TxtNam.Visible = False
            TxtCom.Visible = False
            TxtToLv.Visible = False
            TxtTaLv.Visible = False
            TxtBl.Visible = False
            TxtApDt.Visible = False
            LstLvTyp.Visible = False
            Txtfdt.Visible = False
            TxtTdt.Visible = False
            TxtNoLv.Visible = False
            TxtRes.Visible = False
            LstSub.Visible = False
            BtnEdit.Visible = False
            BtnCle.Visible = False
            BtnDel.Visible = False
            BtnApp.Visible = False

        End If

    End Sub

    Private Sub BtnCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCle.Click

    End Sub

    Private Sub BtnApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApp.Click
        CON.Open()
        Dim CMD As SqlCommand
        Dim Count As Double
        Dim dr1 As DataRow
        Dim SS As String
        Dim DESG As String


        SS = "SELECT * FROM EMPMAST WHERE EMP_no = '" & TxtId.Text & "' AND EMP_com = '" & TxtCom1.Text & "'"

        ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_no = '" & TxtId.Text & "' AND EMP_com = '" & TxtCom1.Text & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpMast")

        Count = DS.Tables("EmpMast").Rows.Count
        If Count <> 0 Then

            For Each dr1 In DS.Tables("EmpMast").Rows
                email1 = dr1("Emp_email")
                Com1 = dr1("Emp_com")
                DESG = dr1("Emp_des")
            Next


        End If

        CMD = New SqlCommand("SELECT * FROM EMPMAST", CON)
        DR = CMD.ExecuteReader
        DR.Close()




        SS = "SELECT * FROM TRNMAST WHERE TRN_NO = '" & TxtId.Text & "' AND TRN_COM = '" & com & "' AND TRN_APDT = #" & TxtApDt.Text & "#"

        '  CMD = New SqlCommand("SELECT * FROM TRNMAST WHERE TRN_NO = '" & TxtId.Text & "' AND TRN_COM = '" & com & "' AND TRN_APDT = '" & TxtApDt.Text & "'", CON)


        ADA = New SqlDataAdapter("SELECT * FROM TRNMAST WHERE TRN_NO = '" & TxtId.Text & "' AND TRN_COM = '" & Com1 & " ' AND TRN_APDT = '" & TxtApDt.Text & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "TrnMast")
        Dim Trnfg As String

        Count = DS.Tables("TrnMast").Rows.Count
        If Count <> 0 Then

            For Each dr1 In DS.Tables("TrnMast").Rows
                Trnfg = dr1("Trn_Fg")
            Next

            If Trnfg = "Select" Then
                CMD.Connection = CON
                'Dim SS As String
                SS = "UPDATE TRNMAST SET Trn_LvTyp='" & Mid(LstLvTyp.SelectedValue, 1, 4) & "',Trn_fdt='" & Txtfdt.Text & "',Trn_Tdt='" & TxtTdt.Text & "',Trn_Res='" & TxtRes.Text & "',Trn_sub='" & Mid(LstSub.SelectedValue, 1, 5) & "',Trn_Nolv='" & TxtNoLv.Text & "' WHERE TRN_NO = '" & TxtId.Text & "' AND TRN_COM = '" & Com1 & " ' AND TRN_APDT = '" & TxtApDt.Text & "'"


                CMD.CommandText = (SS)
                CMD.ExecuteNonQuery()

            Else




            End If
        Else
            CMD.Connection = CON
            'CMD.CommandText = ("INSERT INTO TrnMast (Trn_NO,Trn_Com,Trn_Apdt,Trn_LvTyp,Trn_Fdt,Trn_Tdt,Trn_NoLv,Trn_fg,Trn_Res,Trn_Sub) VALUES ('" & TxtId.Text & "','" & Com1 & "','" & Format(CDate(TxtApDt.Text), "dd/MM/yyyy") & "','" & Mid(LstLvTyp.SelectedValue, 1, 4) & "','" & Format(CDate(Txtfdt.Text), "dd/MM/yyyy") & "','" & Format(CDate(TxtTdt.Text), "dd/MM/yyyy") & "','" & TxtNoLv.Text & "','Select','" & TxtRes.Text & "','" & Mid(LstSub.SelectedValue, 1, 5) & "')")
            CMD.CommandText = ("INSERT INTO TrnMast (Trn_NO,Trn_Com,Trn_Apdt,Trn_LvTyp,Trn_Fdt,Trn_Tdt,Trn_NoLv,Trn_fg,Trn_Res,Trn_Sub) VALUES ('" & TxtId.Text & "','" & Com1 & "','" & TxtApDt.Text & "','" & Mid(LstLvTyp.SelectedValue, 1, 4) & "','" & Txtfdt.Text & "','" & TxtTdt.Text & "','" & TxtNoLv.Text & "','Select','" & TxtRes.Text & "','" & Mid(LstSub.SelectedValue, 1, 5) & "')")
            CMD.ExecuteNonQuery()

            'RequiredFieldValidator1.Enabled = True
            'RegularExpressionValidator1.Enabled = True
            'RequiredFieldValidator2.Enabled = True

            Dim Count1, Count2 As Double
            Dim dr2, dr3 As DataRow
            Dim em1, em2, em3 As String
            ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_Com = '" & Com1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "ADMIN")

            Count1 = DS.Tables("ADMIN").Rows.Count
            If Count1 <> 0 Then

                For Each dr1 In DS.Tables("Admin").Rows
                    em1 = dr1("Ad_email")
                Next

            Else

            End If


            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = email1
            emailMessage.To = em1
            emailMessage.Cc = em1
            emailMessage.Bcc = em1
            emailMessage.Subject = "For Leave Approval"

            emailMessage.Body = "ID NO: " + TxtId.Text + " " + TxtNam.Text + " " + DESG + " " + TxtCom.Text + " Leave From :" + Txtfdt.Text + " to :" + TxtTdt.Text + " No of Leave :" + TxtNoLv.Text + "  For Your Approval " + "http://sgcsser/Leave/LeaveApproval.aspx"
            ' SS = "ID NO: " + TxtId.Text + " " + TxtNam.Text + "  For Your Approval " + "http://192.168.12.207/Leave/LeaveApproval.aspx"

            SmtpMail.SmtpServer = "mail.dsisamson.com"

            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try

        End If

    End Sub
End Class
