Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
'Imports System.Configuration
'Imports System.Data
'Imports System.Data.SqlClient
Imports CrystalDecisions.ReportSource
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
'Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Net
Imports System.Drawing.Printing
'Imports System.Web.Mail

Public Class SgcsSHE1

    Inherits System.Web.UI.Page
    Dim V, V1, V2, V3, V4, V5, V6 As String
    Dim M As Integer
    Dim _refreshState, _isRefresh As Boolean
    Dim Body As String

    Dim COUNT, COUNT1, COUNT2 As Integer

    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim Conn As OleDbConnection
    Dim ADADB, ADADB1 As OleDbDataAdapter
    Dim CMDDB As OleDbCommand
    Dim DRDB, DR1DB, dr2DB, dr3DB As OleDbDataReader
    Dim REDB As OleDbDataReader
    Dim ADA, ADA1, ADA2 As SqlDataAdapter
    Dim CMD, CMD1, CMD2, CMD3 As SqlCommand
    'Dim DR, DR1, dr2, dr3 As SqlDataReader
    Dim DS, DS1, ds2, DS3 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim dr1, dr2, DR3, DR4 As DataRow
    Dim RE As SqlDataReader
    Dim RE1, RE2, RE3 As SqlDataReader
    Public ss As String
    Public PVehno As String
    '  Dim dr1, dr2, DR3, DR4 As DataRow
    Dim pppp As String
    Dim Todt As String
    Dim Empno, EmpCom, EmpAmt, EmpPayDt, EmpTyp, EmpDecAmt, EmpChqNo, EmpCno As String
    Dim ans1, ans2 As String
    Dim totamt As Double
    Dim sCOM, sEPFNO, SCNam, STEmail, SChqNo, FNAME As String
    Dim sp1, sp2, sp3, sp4, sp6 As String
    Dim f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11 As String

    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents TEXTAREA1 As System.Web.UI.HtmlControls.HtmlTextArea
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton7 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton9 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton11 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton12 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton13 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton14 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents LinkButton16 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents LinkButton17 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents LinkButton15 As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Btt1 As System.Web.UI.WebControls.Button
    Protected WithEvents TxtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

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

        If Not IsPostBack Then
            M = 1
        End If

        Global.PwFlag = "N"
    End Sub

    Private Sub TEXTAREA1_ServerChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.TextChanged
        Global.PUserId = TxtId.Text
        ss = TxtId.Text
        ss = Global.PUserId
        Dim uid As String
        uid = TxtId.Text
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")

        CON.Open()
        'Response.Redirect("ABC.aspx?UID=" & TxtId.Text & "")
        'ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_USER = '" & Global.PUserId & "'", CON)
        'DS = New DataSet
        'ADA.Fill(DS, "ADMIN")

        'COUNT = DS.Tables("ADMIN").Rows.Count


        'If COUNT <> 0 Then
        'For Each dr1 In DS.Tables("ADMIN").Rows

        ' Global.PNam = dr1("AD_NAM")
        ' Global.Ppwd = dr1("AD_PWD")
        ' Global.PEmail = dr1("AD_NAM")
        ' Global.PwLevel = dr1("AD_Level")
        ' TxtNam.Text = Global.PNam

        ' Next
        '  End If

        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & Global.PUserId & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        COUNT = DS.Tables("UsdMaster").Rows.Count


        If COUNT <> 0 Then

            For Each dr1 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")

                Global.PNam = dr1("User_name")
                Global.Ppwd = dr1("User_pwd")
                'Global.PEmail = dr1("AD_NAM")
                Global.PwLevel = dr1("User_lvl")
                TxtNam.Text = Global.PNam
                Global.PSec = dr1("User_sec")
                Global.LOGTIME = Date.Today
                Global.Ldate = dr1("User_Ldate")
                Global.Ltime = dr1("User_Time")

            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If
    End Sub

    Private Sub Btt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt1.Click

        Global.PUserId = TxtId.Text
        ss = TxtId.Text
        ss = Global.PUserId
        ' CON.Open()
        'PUserId1 = TxtId.Text

        If TxtPwd.Text = Global.Ppwd Then
            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()

            Global.PwFlag = "Y"

            Dim Cmd As New SqlCommand
            Cmd.Connection = CON

            ss = "UPDATE UsdMaster SET User_Ldate='" & Format(DateValue(Today()), "dd/MM/yyyy") & "',User_Time='" & FormatDateTime(TimeOfDay) & "' WHERE User_id='" & Global.PUserId & "'"
            Cmd.CommandText = ("UPDATE UsdMaster SET User_Ldate='" & Format(DateValue(Today()), "dd/MM/yyyy") & "',User_Time='" & FormatDateTime(TimeOfDay) & "' WHERE User_Code='" & Global.PUserId & "'")
            Cmd.ExecuteNonQuery()

            Dim ss2 As String = Format(Today(), ("MM/dd/yyyy"))
            Dim ss1 As String = Mid(ss, 4, 2) + "/" + Mid(ss, 1, 2) + "/" + Mid(ss, 7, 4)

            ADA = New SqlDataAdapter("SELECT * FROM RepFlag WHERE Rep_Date='" & Trim(ss2) & "'", CON)
            'ADA = New SqlDataAdapter("SELECT * FROM RepFlag ", CON)
            DS1 = New DataSet
            ADA.Fill(DS1, "RepFlag")

            COUNT = DS1.Tables("RepFlag").Rows.Count


            If COUNT <> 0 Then
                'Response.Redirect("Dispaly1.aspx")

                'Response.Redirect("Dispaly1.aspx?UID=" & TxtId.Text & "")

                '---------

                '----
                Response.Redirect("sgcsSHE1.aspx?UID=" & TxtId.Text & "")
            Else
                ' -------           -------------
                Conn = New OleDbConnection
                Conn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Data.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
                Conn.Open()

                '------------------------

                'Conn = New OleDbConnection
                'Conn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Data.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
                'Conn.Open()

                ADADB = New OleDbDataAdapter("Select * from data where mid(trim(f2),1,2)='20' ORDER BY F2", Conn)

                ' ADADB = New OleDbDataAdapter("Select * from data", Conn)
                DS = New DataSet
                ADADB.Fill(DS, "data")
                COUNT = DS.Tables("data").Rows.Count

                '-----------------------

                Todt = Format(Today, "MM/dd/yyyy")

                '--------------

                Dim Vehno, Vehcom, Vehtype, vehexdt, Sflg1, Sflg2, Tfdt, Ttdt As String
                Dim dtdiff As Integer

                Sflg1 = "Yes"
                Sflg2 = "No"
                Todt = Format(Today, "MM/dd/yyyy")
                Dim emailMessage1 As MailMessage


                emailMessage1 = New MailMessage

                If COUNT <> 0 Then
                    ' emailMessage = New MailMessage


                    emailMessage1.From = "insurance@dsisamson.com"

                    'emailMessage1.From = "insurance@dsisamson.com"
                    emailMessage1.To = "chamindas@samsoncorporates.com,udanip@samsoncorporates.com,insurance@samsoncorporates.com"

                    emailMessage1.Subject = "SIB Insurance to be Expired-Next Days" + " "
                    emailMessage1.Body += "  DATE     INSURER      TYPE OF POLICY             POLICY NO                      SUM INSURED        SERVICE NAME       No of Days" & vbCrLf
                    emailMessage1.Body += "----------------------------------------------------------------------------------------------------------------------------------" & vbCrLf
                    COUNT1 = 0

                    For Each dr1 In DS.Tables("data").Rows

                        Try
                            If IsDBNull(Trim(dr1("F2"))) Then
                                f2 = Space(10)
                            Else
                                f2 = Mid(Trim(dr1("F2")) + Space(30), 1, 10)
                            End If

                            'SmtpMail.Send(emailMessage)
                            'labelStatus.Text = "Message sent!"
                            'Button1.Enabled = False
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f2 = Space(10)
                        End Try

                        Try
                            If IsDBNull(Trim(dr1("F4"))) Then
                                f4 = "   "
                            Else
                                f4 = Mid(Trim(dr1("F4")) + Space(30), 1, 3)
                            End If

                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f4 = "   "
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("F5"))) Then
                                f5 = Space(35)
                            Else
                                f5 = Mid(Trim(dr1("F5")) + Space(35), 1, 35)
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f5 = Space(35)
                        End Try
                        'f6 = Mid(Trim(dr1("F6")) + Space(10), 1, 15)

                        Try

                            If IsDBNull(Trim(dr1("F6"))) Then
                                f6 = Space(21)
                            Else
                                f6 = Mid(Trim(dr1("F6")) + Space(25), 1, 21)

                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f6 = Space(21)
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("F7"))) Then
                                f7 = Space(15)
                            Else
                                f7 = Mid(Trim(dr1("F7")) + Space(20), 1, 20)

                                sp1 = Space(25)
                                sp1 = sp1 + Format(Val(Trim(dr1("F7"))), "###,###,###,###.00")
                                sp1 = Right(sp1, 15)
                                f7 = sp1



                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f7 = Space(15)
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("F8"))) Then
                                f8 = Space(12)
                            Else
                                f8 = Mid(Trim(dr1("F8")) + Space(15), 1, 15)

                                sp1 = Space(25)
                                sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                sp1 = Right(sp1, 12)
                                f8 = sp1



                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f8 = Space(12)
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("F11"))) Then
                                f9 = Space(3)
                            Else

                                f9 = Trim(dr1("F11"))

                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f9 = Space(3)
                        End Try
                        Try
                            f10 = Space(20)
                            If IsDBNull(Trim(dr1("F23"))) Then
                                f10 = Space(25)
                            Else

                                f10 = Mid((dr1("F23") + Space(25)), 1, 20)

                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f10 = Space(20)
                        End Try

                        vehexdt = Trim(dr1("F2"))
                        Tfdt = Mid(Todt, 1, 2) + "/" + Mid(Todt, 4, 2) + "/" + Mid(Todt, 7, 4)
                        ' Ttdt = Format(Trim(dr2("Veh_ExDt")), "MM/dd/yyyy")

                        COUNT2 = Val(Mid(Trim(dr1("F2")), 1, 4)) + 1

                        Ttdt = Mid(Trim(dr1("F2")), 6, 2) + "/" + Mid(Trim(dr1("F2")), 9, 2) + "/" + Str(COUNT2)
                        Try
                            dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))
                        Catch ex As Exception
                            dtdiff = 30
                        End Try


                        Ttdt = Mid(Trim(dr1("F2")), 9, 2) + "/" + Mid(Trim(dr1("F2")), 6, 2) + "/" + Mid(Trim(dr1("F2")), 1, 4)
                        If dtdiff <= 30 And f9 = "YES" Then
                            COUNT1 = COUNT1 + 1
                            sp1 = "000" + Trim(Str(dtdiff))
                            sp1 = Right(sp1, 4)
                            emailMessage1.Body += "" & f2 & " " & f4 & " " & f5 & " " & f6 & " " & f7 & " " & f8 & " " & f10 & " " & sp1 & vbCrLf
                            Sflg2 = "Yes"
                        End If

                    Next

                    If Sflg2 = "Yes" Then
                        SmtpMail.SmtpServer = "mail.dsisamson.com"
                        Try
                            If COUNT1 <> 0 Then
                                SmtpMail.Send(emailMessage1)

                            End If
                        Catch ex As Exception

                        End Try

                    End If
                End If
                '----------
                ADADB1 = New OleDbDataAdapter("Select * from DATA1 WHERE (((DATA1.F2)<>'' And (DATA1.F2)<>'COMPANY'))", Conn)

                ' ADADB = New OleDbDataAdapter("Select * from data", Conn)
                DS = New DataSet
                ADADB1.Fill(DS, "data1")
                COUNT = DS.Tables("data1").Rows.Count
                '-----------------------
                Todt = Format(Today, "MM/dd/yyyy")
                Dim tot As Double

                tot = 0
                Dim emailMessage As MailMessage


                If (CDate(Todt)).DayOfWeek = 1 Then
                    '--------------
                    ' Dim f1, f2, f3, f4, f5, f6, f7, f8, f9 As String
                    'Dim Vehno, Vehcom, Vehtype, vehexdt, Sflg1, Sflg2, Tfdt, Ttdt As String
                    ' Dim dtdiff As Integer

                    Sflg1 = "Yes"
                    Sflg2 = "No"
                    Todt = Format(Today, "MM/dd/yyyy")


                    emailMessage = New MailMessage

                    If COUNT <> 0 Then
                        ' emailMessage = New MailMessage


                        emailMessage.From = "imports@samsoncorporates.com"

                        'emailMessage.From = "insurance@dsisamson.com"

                        emailMessage.To = "chithralg@samsoncorporates.com,nilushig@samsoncorporates.com,palithan@samsoncorporates.com,imports@samsoncorporates.com"
                        ' emailMessage.To = "palithan@samsoncorporates.com"
                        emailMessage.Subject = "Reminder-Refund Container Deposit List" & vbCrLf
                        emailMessage.Body += "COMPANY SHIPPING LINE                INDENT NOS             RECP NO    CN NOS        AMOUNT    FCL DATE No of Days" & vbCrLf
                        emailMessage.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf
                        COUNT1 = 0

                        For Each dr1 In DS.Tables("data1").Rows

                            Try
                                If IsDBNull(Trim(dr1("F1"))) Then
                                    f1 = Space(4)
                                Else
                                    f1 = Mid(Trim(dr1("F1")) + Space(30), 1, 4)
                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f1 = Space(4)
                            End Try



                            Try
                                If IsDBNull(Trim(dr1("F2"))) Then
                                    f2 = Space(5)
                                Else
                                    f2 = Mid(Trim(dr1("F2")) + Space(30), 1, 5)
                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f2 = Space(5)
                            End Try

                            Try
                                If IsDBNull(Trim(dr1("F3"))) Then
                                    f3 = Space(30)
                                Else
                                    f3 = Mid(Trim(dr1("F3")) + Space(30), 1, 30)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f3 = Space(30)
                            End Try




                            Try
                                If IsDBNull(Trim(dr1("F4"))) Then
                                    f4 = Space(21)
                                Else
                                    f4 = Mid(Trim(dr1("F4")) + Space(30), 1, 21)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f4 = Space(21)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("F5"))) Then
                                    f5 = Space(10)
                                Else
                                    f5 = Mid(Trim(dr1("F5")) + Space(35), 1, 10)
                                End If
                            Catch ex As Exception

                                f5 = Space(10)
                            End Try




                            Try

                                If IsDBNull(Trim(dr1("F6"))) Then
                                    f6 = Space(6)
                                Else
                                    f6 = Mid(Trim(dr1("F6")) + Space(35), 1, 6)
                                End If
                            Catch ex As Exception

                                f6 = Space(6)
                            End Try


                            Try

                                If IsDBNull(Trim(dr1("F7"))) Then
                                    f7 = Space(15)
                                Else
                                    f7 = Mid(Trim(dr1("F7")) + Space(25), 1, 15)

                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f7 = Space(15)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("F8"))) Then
                                    f8 = Space(20)
                                Else
                                    f8 = Mid(Trim(dr1("F8")) + Space(20), 1, 15)

                                    sp1 = Space(10)
                                    sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                    sp1 = Right(sp1, 10)
                                    f8 = sp1



                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f8 = Space(15)
                            End Try


                            Try
                                If IsDBNull(Trim(dr1("F12"))) Then
                                    vehexdt = Space(10)
                                Else

                                    vehexdt = Format(CDate(Trim(dr1("F12"))), "MM/dd/yyyy")
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                vehexdt = Space(10)
                            End Try
                            Try
                                If IsDBNull(Trim(dr1("F13"))) Then
                                    ss = Space(10)
                                Else

                                    ss = Mid(Trim(dr1("F13")) + Space(25), 1, 15)
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                ss = Space(10)
                            End Try

                            Tfdt = Mid(Todt, 1, 2) + "/" + Mid(Todt, 4, 2) + "/" + Mid(Todt, 7, 4)
                            ' Ttdt = Format(Trim(dr2("Veh_ExDt")), "MM/dd/yyyy")

                            COUNT2 = Val(Mid(vehexdt, 1, 4))

                            Ttdt = Mid(vehexdt, 1, 2) + "/" + Mid(vehexdt, 4, 2) + "/" + Mid(vehexdt, 7, 4)


                            Try
                                dtdiff = DateDiff(DateInterval.Day, CDate(Ttdt), CDate(Tfdt))
                            Catch ex As Exception
                                dtdiff = 0
                            End Try



                            Ttdt = Mid(Trim(dr1("F2")), 4, 2) + "/" + Mid(Trim(dr1("F2")), 1, 2) + "/" + Mid(Trim(dr1("F2")), 1, 4)
                            If dtdiff >= 0 And Trim(ss) = "" Then

                                If IsDBNull(dr1("F8")) = True Then


                                Else
                                    tot = tot + Val(Trim(dr1("F8")))
                                    COUNT1 = COUNT1 + 1
                                End If
                                sp1 = "000" + Trim(Str(dtdiff))
                                sp1 = Right(sp1, 4)
                                emailMessage.Body += "" & f2 & " " & f3 & "  " & f4 & " " & f5 & " " & f7 & " " & f8 & " " & vehexdt & " " & sp1 & vbCrLf
                                Sflg2 = ss
                            End If

                        Next

                        emailMessage.Body += "------------------------------------------------------------------------------------------------------------------------" & vbCrLf
                        emailMessage.Body += "T O T A L  AMOUNT  :  " + Format(tot, "###,###,###,###.00") & vbCrLf
                        emailMessage.Body += "------------------------------------------------------------------------------------------------------------------------" & vbCrLf

                        'If Sflg2 = "Yes" Then

                        SmtpMail.SmtpServer = "mail.dsisamson.com"
                        Try
                            If COUNT1 <> 0 Then
                                SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                        End Try

                        ' End If
                    End If
                End If
                '--------------------------
                Todt = Format(Today, "MM/dd/yyyy")
                If (CDate(Todt)).DayOfWeek = 1 Then
                    ADADB1 = New OleDbDataAdapter("Select * from DATA1 WHERE DATA1.F2='DSI'", Conn)

                    ' ADADB = New OleDbDataAdapter("Select * from data", Conn)
                    DS = New DataSet
                    ADADB1.Fill(DS, "data3")
                    COUNT = DS.Tables("data3").Rows.Count
                    '-----------------------


                    '--------------
                    ' Dim f1, f2, f3, f4, f5, f6, f7, f8, f9 As String
                    'Dim Vehno, Vehcom, Vehtype, vehexdt, Sflg1, Sflg2, Tfdt, Ttdt As String
                    ' Dim dtdiff As Integer

                    Sflg1 = "Yes"
                    Sflg2 = "No"
                    Todt = Format(Today, "MM/dd/yyyy")

                    Dim emailMessage3 As MailMessage

                    emailMessage3 = New MailMessage
                    tot = 0
                    If COUNT <> 0 Then
                        ' emailMessage = New MailMessage


                        emailMessage3.From = "imports@samsoncorporates.com"

                        'emailMessage.From = "insurance@dsisamson.com"

                        emailMessage3.To = "jayaniw@dsifootwear.com,nilushig@samsoncorporates.com,acc4@dsifootwear.com,thanujem@dsifootwear.com"
                        'emailMessage3.To = "palithan@samsoncorporates.com"
                        emailMessage3.Subject = "Reminder-Refund Container Deposit List" & vbCrLf
                        emailMessage3.Body += "COMPANY SHIPPING LINE                INDENT NOS             RECP NO    CN NOS        AMOUNT    FCL DATE No of Days" & vbCrLf
                        emailMessage3.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf
                        COUNT1 = 0
                        tot = 0
                        For Each dr1 In DS.Tables("data3").Rows

                            Try
                                If IsDBNull(Trim(dr1("F1"))) Then
                                    f1 = Space(4)
                                Else
                                    f1 = Mid(Trim(dr1("F1")) + Space(30), 1, 4)
                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f1 = Space(4)
                            End Try



                            Try
                                If IsDBNull(Trim(dr1("F2"))) Then
                                    f2 = Space(5)
                                Else
                                    f2 = Mid(Trim(dr1("F2")) + Space(30), 1, 5)
                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f2 = Space(5)
                            End Try

                            Try
                                If IsDBNull(Trim(dr1("F3"))) Then
                                    f3 = Space(30)
                                Else
                                    f3 = Mid(Trim(dr1("F3")) + Space(30), 1, 30)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f3 = Space(30)
                            End Try




                            Try
                                If IsDBNull(Trim(dr1("F4"))) Then
                                    f4 = Space(21)
                                Else
                                    f4 = Mid(Trim(dr1("F4")) + Space(30), 1, 21)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f4 = Space(21)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("F5"))) Then
                                    f5 = Space(10)
                                Else
                                    f5 = Mid(Trim(dr1("F5")) + Space(35), 1, 10)
                                End If
                            Catch ex As Exception

                                f5 = Space(10)
                            End Try




                            Try

                                If IsDBNull(Trim(dr1("F6"))) Then
                                    f6 = Space(6)
                                Else
                                    f6 = Mid(Trim(dr1("F6")) + Space(35), 1, 6)
                                End If
                            Catch ex As Exception

                                f6 = Space(6)
                            End Try


                            Try

                                If IsDBNull(Trim(dr1("F7"))) Then
                                    f7 = Space(15)
                                Else
                                    f7 = Mid(Trim(dr1("F7")) + Space(25), 1, 15)

                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f7 = Space(15)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("F8"))) Then
                                    f8 = Space(20)
                                Else
                                    f8 = Mid(Trim(dr1("F8")) + Space(20), 1, 15)

                                    sp1 = Space(10)
                                    sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                    sp1 = Right(sp1, 10)
                                    f8 = sp1



                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f8 = Space(15)
                            End Try


                            Try
                                If IsDBNull(Trim(dr1("F12"))) Then
                                    vehexdt = Space(10)
                                Else

                                    vehexdt = Format(CDate(Trim(dr1("F12"))), "MM/dd/yyyy")
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                vehexdt = Space(10)
                            End Try
                            Try
                                If IsDBNull(Trim(dr1("F13"))) Then
                                    ss = Space(10)
                                Else

                                    ss = Mid(Trim(dr1("F13")) + Space(25), 1, 15)
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                ss = Space(10)
                            End Try

                            Tfdt = Mid(Todt, 1, 2) + "/" + Mid(Todt, 4, 2) + "/" + Mid(Todt, 7, 4)
                            ' Ttdt = Format(Trim(dr2("Veh_ExDt")), "MM/dd/yyyy")

                            COUNT2 = Val(Mid(vehexdt, 1, 4))

                            Ttdt = Mid(vehexdt, 1, 2) + "/" + Mid(vehexdt, 4, 2) + "/" + Mid(vehexdt, 7, 4)


                            Try
                                dtdiff = DateDiff(DateInterval.Day, CDate(Ttdt), CDate(Tfdt))
                            Catch ex As Exception
                                dtdiff = 0
                            End Try



                            Ttdt = Mid(Trim(dr1("F2")), 4, 2) + "/" + Mid(Trim(dr1("F2")), 1, 2) + "/" + Mid(Trim(dr1("F2")), 1, 4)
                            If dtdiff >= 0 And Trim(ss) = "" Then

                                If IsDBNull(dr1("F8")) = True Then


                                Else
                                    tot = tot + Val(Trim(dr1("F8")))
                                    COUNT1 = COUNT1 + 1
                                End If
                                sp1 = "000" + Trim(Str(dtdiff))
                                sp1 = Right(sp1, 4)
                                emailMessage3.Body += "" & f2 & " " & f3 & "  " & f4 & " " & f5 & " " & f7 & " " & f8 & " " & vehexdt & " " & sp1 & vbCrLf
                                Sflg2 = ss
                            End If

                        Next

                        emailMessage3.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf
                        emailMessage3.Body += "T O T A L  AMOUNT  :  " + Format(tot, "###,###,###,###.00") & vbCrLf
                        emailMessage3.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf

                        'If Sflg2 = "Yes" Then

                        SmtpMail.SmtpServer = "mail.dsisamson.com"
                        Try
                            If COUNT1 <> 0 Then
                                SmtpMail.Send(emailMessage3)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                        End Try

                        ' End If
                    End If


                    '-----------
                    ADADB1 = New OleDbDataAdapter("Select * from DATA1 WHERE DATA1.F2='SCOM'", Conn)

                    ' ADADB = New OleDbDataAdapter("Select * from data", Conn)
                    DS = New DataSet
                    ADADB1.Fill(DS, "data4")
                    COUNT = DS.Tables("data4").Rows.Count
                    '-----------------------


                    '--------------
                    ' Dim f1, f2, f3, f4, f5, f6, f7, f8, f9 As String
                    'Dim Vehno, Vehcom, Vehtype, vehexdt, Sflg1, Sflg2, Tfdt, Ttdt As String
                    ' Dim dtdiff As Integer

                    Sflg1 = "Yes"
                    Sflg2 = "No"
                    Todt = Format(Today, "MM/dd/yyyy")

                    Dim emailMessage4 As MailMessage

                    emailMessage4 = New MailMessage
                    tot = 0
                    If COUNT <> 0 Then
                        ' emailMessage = New MailMessage


                        emailMessage4.From = "imports@samsoncorporates.com"

                        'emailMessage.From = "insurance@dsisamson.com"

                        emailMessage4.To = "samanm@samsoncompounds.com,nilushig@samsoncorporates.com,accounts7@samsoncompounds.com"
                        ' emailMessage4.To = "palithan@samsoncorporates.com"
                        emailMessage4.Subject = "Reminder-Refund Container Deposit List" & vbCrLf
                        emailMessage4.Body += "COMPANY SHIPPING LINE                INDENT NOS             RECP NO    CN NOS        AMOUNT    FCL DATE No of Days" & vbCrLf
                        emailMessage4.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf
                        COUNT1 = 0
                        tot = 0
                        For Each dr1 In DS.Tables("data4").Rows

                            Try
                                If IsDBNull(Trim(dr1("F1"))) Then
                                    f1 = Space(4)
                                Else
                                    f1 = Mid(Trim(dr1("F1")) + Space(30), 1, 4)
                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f1 = Space(4)
                            End Try



                            Try
                                If IsDBNull(Trim(dr1("F2"))) Then
                                    f2 = Space(5)
                                Else
                                    f2 = Mid(Trim(dr1("F2")) + Space(30), 1, 5)
                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f2 = Space(5)
                            End Try

                            Try
                                If IsDBNull(Trim(dr1("F3"))) Then
                                    f3 = Space(30)
                                Else
                                    f3 = Mid(Trim(dr1("F3")) + Space(30), 1, 30)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f3 = Space(30)
                            End Try




                            Try
                                If IsDBNull(Trim(dr1("F4"))) Then
                                    f4 = Space(21)
                                Else
                                    f4 = Mid(Trim(dr1("F4")) + Space(30), 1, 21)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f4 = Space(21)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("F5"))) Then
                                    f5 = Space(10)
                                Else
                                    f5 = Mid(Trim(dr1("F5")) + Space(35), 1, 10)
                                End If
                            Catch ex As Exception

                                f5 = Space(10)
                            End Try




                            Try

                                If IsDBNull(Trim(dr1("F6"))) Then
                                    f6 = Space(6)
                                Else
                                    f6 = Mid(Trim(dr1("F6")) + Space(35), 1, 6)
                                End If
                            Catch ex As Exception

                                f6 = Space(6)
                            End Try


                            Try

                                If IsDBNull(Trim(dr1("F7"))) Then
                                    f7 = Space(15)
                                Else
                                    f7 = Mid(Trim(dr1("F7")) + Space(25), 1, 15)

                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f7 = Space(15)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("F8"))) Then
                                    f8 = Space(20)
                                Else
                                    f8 = Mid(Trim(dr1("F8")) + Space(20), 1, 15)

                                    sp1 = Space(10)
                                    sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                    sp1 = Right(sp1, 10)
                                    f8 = sp1



                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f8 = Space(15)
                            End Try


                            Try
                                If IsDBNull(Trim(dr1("F12"))) Then
                                    vehexdt = Space(10)
                                Else

                                    vehexdt = Format(CDate(Trim(dr1("F12"))), "MM/dd/yyyy")
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                vehexdt = Space(10)
                            End Try
                            Try
                                If IsDBNull(Trim(dr1("F13"))) Then
                                    ss = Space(10)
                                Else

                                    ss = Mid(Trim(dr1("F13")) + Space(25), 1, 15)
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                ss = Space(10)
                            End Try

                            Tfdt = Mid(Todt, 1, 2) + "/" + Mid(Todt, 4, 2) + "/" + Mid(Todt, 7, 4)
                            ' Ttdt = Format(Trim(dr2("Veh_ExDt")), "MM/dd/yyyy")

                            COUNT2 = Val(Mid(vehexdt, 1, 4))

                            Ttdt = Mid(vehexdt, 1, 2) + "/" + Mid(vehexdt, 4, 2) + "/" + Mid(vehexdt, 7, 4)


                            Try
                                dtdiff = DateDiff(DateInterval.Day, CDate(Ttdt), CDate(Tfdt))
                            Catch ex As Exception
                                dtdiff = 0
                            End Try



                            Ttdt = Mid(Trim(dr1("F2")), 4, 2) + "/" + Mid(Trim(dr1("F2")), 1, 2) + "/" + Mid(Trim(dr1("F2")), 1, 4)
                            If dtdiff >= 0 And Trim(ss) = "" Then

                                If IsDBNull(dr1("F8")) = True Then


                                Else
                                    tot = tot + Val(Trim(dr1("F8")))
                                    COUNT1 = COUNT1 + 1
                                End If
                                sp1 = "000" + Trim(Str(dtdiff))
                                sp1 = Right(sp1, 4)
                                emailMessage4.Body += "" & f2 & " " & f3 & "  " & f4 & " " & f5 & " " & f7 & " " & f8 & " " & vehexdt & " " & sp1 & vbCrLf
                                Sflg2 = ss
                            End If

                        Next

                        emailMessage4.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf
                        emailMessage4.Body += "T O T A L  AMOUNT  :  " + Format(tot, "###,###,###,###.00") & vbCrLf
                        emailMessage4.Body += "------------------------------------------------------------------------------------------------------------------" & vbCrLf

                        'If Sflg2 = "Yes" Then

                        SmtpMail.SmtpServer = "mail.dsisamson.com"
                        Try
                            If COUNT1 <> 0 Then
                                SmtpMail.Send(emailMessage4)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                        End Try

                        ' End If
                    End If

                End If
                '-----------





                '---------------------






                Conn.Close()
                '----------
                Conn = New OleDbConnection
                Conn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Data.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
                Conn.Open()
                '------------------------

                ADA = New SqlDataAdapter("Select *  from Vehmast order by veh_com", CON)
                DS = New DataSet
                ADA.Fill(DS, "VehMast")

                COUNT = DS.Tables("VehMast").Rows.Count
                ' ADADB = New OleDbDataAdapter("Select * from data", Conn)

                '-----------------------

                Todt = Format(Today, "MM/dd/yyyy")

                '--------------
                ' Dim f1, f2, f3, f4, f5, f6, f7, f8, f9, f10 As String
                ' Dim Vehno, Vehcom, Vehtype, vehexdt, Sflg1, Sflg2, Tfdt, Ttdt As String
                '  Dim dtdiff As Integer

                Sflg1 = "Yes"
                Sflg2 = "No"
                Todt = Format(Today, "MM/dd/yyyy")
                Dim emailMessage2 As MailMessage


                emailMessage2 = New MailMessage

                If COUNT <> 0 Then
                    ' emailMessage = New MailMessage


                    emailMessage2.From = "insurance@dsisamson.com"

                    'emailMessage1.From = "insurance@dsisamson.com"
                    emailMessage2.To = "chamindas@samsoncorporates.com,udanip@samsoncorporates.com,health@samsoncorporates.com,palithan@samsoncorporates.com"

                    emailMessage2.Subject = "Vehcle Insurance to be Expired-Next Days" + " "
                    emailMessage2.Body += "VEHICLE NO  COMPANY  VEHICLE TYPE          VALUE        PREMIUM     EXPIRE DATE   NO OF DAYS" & vbCrLf
                    emailMessage2.Body += "--------------------------------------------------------------------------------------------" & vbCrLf
                    COUNT1 = 0

                    For Each dr1 In DS.Tables("VehMast").Rows

                        Try
                            If IsDBNull(Trim(dr1("Veh_No"))) Then
                                f2 = Space(10)
                            Else
                                f2 = Mid(Trim(dr1("Veh_No")) + Space(30), 1, 15)
                            End If

                            'SmtpMail.Send(emailMessage)
                            'labelStatus.Text = "Message sent!"
                            'Button1.Enabled = False
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f2 = Space(15)
                        End Try

                        Try
                            If IsDBNull(Trim(dr1("Veh_com"))) Then
                                f4 = "   "
                            Else
                                f4 = Mid(Trim(dr1("Veh_com")) + Space(30), 1, 3)
                            End If

                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f4 = "   "
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("Veh_Typ"))) Then
                                f5 = Space(35)
                            Else
                                f5 = Mid(Trim(dr1("Veh_Typ")) + Space(35), 1, 15)
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f5 = Space(15)
                        End Try
                        'f6 = Mid(Trim(dr1("F6")) + Space(10), 1, 15)

                        Try

                            If IsDBNull(Trim(dr1("Veh_Efdt"))) Then
                                f6 = Space(21)
                            Else
                                f6 = Mid(Trim(dr1("Veh_Efdt")) + Space(25), 1, 12)

                                Ttdt = Format(CDate(Trim(dr1("Veh_Efdt"))), "MM/dd/yyyy")

                                f6 = Mid(Ttdt, 4, 2) + "/" + Mid(Ttdt, 1, 2) + "/" + Mid(Ttdt, 7, 4)

                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f6 = Space(12)
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("Veh_Exdt"))) Then
                                f7 = Space(15)
                            Else
                                f7 = Mid(Trim(dr1("Veh_Exdt")) + Space(20), 1, 12)

                                ' sp1 = Space(25)
                                'sp1 = sp1 + Format(Val(Trim(dr1("F7"))), "###,###,###,###.00")
                                'sp1 = Right(sp1, 15)
                                'f7 = sp1

                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f7 = Space(12)
                        End Try

                        Try

                            If IsDBNull(Trim(dr1("Sold"))) Then
                                f8 = Space(12)
                            Else
                                f8 = Mid(Trim(dr1("Sold")) + Space(15), 1, 1)

                                ' sp1 = Space(25)
                                'sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                'sp1 = Right(sp1, 12)
                                ' f8 = sp1
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f8 = Space(1)
                        End Try


                        vehexdt = f7
                        Tfdt = Mid(Todt, 1, 2) + "/" + Mid(Todt, 4, 2) + "/" + Mid(Todt, 7, 4)

                        Ttdt = Format(CDate(Trim(dr1("Veh_Exdt"))), "MM/dd/yyyy")

                        f9 = Mid(Ttdt, 4, 2) + "/" + Mid(Ttdt, 1, 2) + "/" + Mid(Ttdt, 7, 4)

                        'COUNT2 = Val(Mid(Trim(dr1("F2")), 1, 4)) + 1

                        'Ttdt = Mid(Trim(dr1("F2")), 6, 2) + "/" + Mid(Trim(dr1("F2")), 9, 2) + "/" + Str(COUNT2)
                        Ttdt = Trim(f7)

                        Try
                            dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))
                        Catch ex As Exception
                            dtdiff = 30
                        End Try
                        sp1 = "......" + Trim(Str(dtdiff))
                        sp1 = Right(sp1, 4)

                        ' Ttdt = Mid(Trim(dr1("F2")), 9, 2) + "/" + Mid(Trim(dr1("F2")), 6, 2) + "/" + Mid(Trim(dr1("F2")), 1, 4)

                        Try

                            If IsDBNull(Trim(dr1("Veh_Val"))) Then
                                f10 = Space(20)
                            Else
                                'f10 = "*****" + Trim(dr1("Veh_Val"))

                                f10 = Space(20)
                                ' Format(Val(EmpAmt), "###,###.00")
                                f10 = f10 + Format(Val(Trim(dr1("Veh_Val"))), "###,###,###.00")
                                f10 = Right(f10, 14)


                                ' sp1 = Space(25)
                                'sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                'sp1 = Right(sp1, 12)
                                ' f8 = sp1
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f10 = Right(f10, 14)
                            'f10 = Mid(f10, 1, 15)

                        End Try
                        f10 = Right(f10, 14)


                        Try

                            If IsDBNull(Trim(dr1("Veh_Tpay"))) Then
                                f11 = Space(15)
                            Else
                                f11 = "       " + Trim(dr1("Veh_Tpay"))


                                f11 = Space(15)
                                ' Format(Val(EmpAmt), "###,###.00")
                                f11 = f11 + Format(Val(Trim(dr1("Veh_Tpay"))), "###,###,###.00")
                                f11 = Right(f11, 15)
                                ' sp1 = Space(25)
                                'sp1 = sp1 + Format(Val(Trim(dr1("F8"))), "###,###,###,###.00")
                                'sp1 = Right(sp1, 12)
                                ' f8 = sp1
                            End If
                        Catch ex As Exception
                            'labelStatus.Text="Unable to send the e-mail message"
                            ' labelStatus.Text = ex.ToString
                            f11 = Right(Trim(f11), 15)
                        End Try

                        f11 = Right(f11, 15)

                        If dtdiff <= 30 And f8 = "N" Then
                            COUNT1 = COUNT1 + 1
                            sp1 = Space(5)

                            sp1 = sp1 + Format(Val(Trim(Str(dtdiff))), "#####")

                            sp1 = Right(Trim(sp1), 5)
                            emailMessage2.Body += "" & f2 & " " & f4 & "  " & f5 & " " & f10 & "" & f11 & "   " & f9 & "    " & sp1 & " " & vbCrLf
                            Sflg2 = "Yes"
                        End If


                    Next

                    If Sflg2 = "Yes" Then
                        SmtpMail.SmtpServer = "mail.dsisamson.com"
                        Try
                            If COUNT1 <> 0 Then
                                SmtpMail.Send(emailMessage2)

                            End If
                        Catch ex As Exception

                        End Try

                    End If
                End If


                '-----------------

                Dim Cmd1 As New SqlCommand
                Cmd1.Connection = CON
                Cmd1.CommandText = ("INSERT INTO repflag (Rep_Flag,Rep_EFlg1,Rep_Eflg2,Rep_date) VALUES ('Yes','Yes','Yes','" & ss2 & "')")
                Cmd1.ExecuteNonQuery()


                '----------
                Conn = New OleDbConnection
                Conn.ConnectionString = ("Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Data Source=c:\inetpub\wwwroot\Insu\Data\Data.mdb;Mode=Share Deny None;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1")
                Conn.Open()


                Dim MM1, DD1, YY1 As String
                Dim MM2 As Integer
                If Mid(Todt, 4, 2) = "01" Then


                    Todt = Format(Today, "MM/dd/yyyy")
                    If Mid(Todt, 1, 2) = "01" Then
                        MM1 = "12"
                        YY1 = Val(Mid(Todt, 7, 4)) - 1

                    Else
                        MM2 = Val(Mid(Todt, 1, 2)) - 1
                        MM1 = Val(Mid(Todt, 1, 2)) - 1
                        If Len(MM1) = 1 Then
                            MM1 = "0" + Trim(Str(MM2))
                        Else

                        End If
                        YY1 = Val(Mid(Todt, 7, 4))
                    End If
                    Dim Dss As VehClaim2 = New VehClaim2
                    Dim DiskOpts As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
                    ' Dss.SetDatabaseLogon("sa", "tstc123")
                    'Dss.SetParameterValue("Com", "" & com11 & "")
                    'Dss.SetParameterValue("fm", "" & TEmail & "")
                    'Dss.SetParameterValue("tm", "" & FEmail & "")
                    Dss.ExportOptions.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile
                    Dss.ExportOptions.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat
                    DiskOpts.DiskFileName = Server.MapPath("Data/" & "SeeAttached.pdf")
                    Dss.ExportOptions.DestinationOptions = DiskOpts
                    Dss.Export()



                    ADADB1 = New OleDbDataAdapter("Select * from Query6 WHERE (Query6.YY)='" & YY1 & "' And (Query6.MM)='" & MM1 & "'", Conn)

                    ' ADADB = New OleDbDataAdapter("Select * from data", Conn)
                    DS = New DataSet
                    ADADB1.Fill(DS, "Query6")
                    COUNT = DS.Tables("Query6").Rows.Count
                    Dim emailMessage3 As MailMessage


                    emailMessage3 = New MailMessage

                    If COUNT <> 0 Then
                        ' emailMessage = New MailMessage


                        emailMessage.From = "insurance@dsisamson.com"

                        'emailMessage3.To = "palithan@samsoncorporates.com"
                        emailMessage3.To = "chamindas@samsoncorporates.com,udanip@samsoncorporates.com,palithan@samsoncorporates.com,health@samsoncorporates.com"

                        emailMessage3.Subject = "Vehicle Accident Claims Payment Last Month " + YY1 + "/" + MM1
                        emailMessage3.Body += "Date    Company Description           Cheque No      Received      Payment" & vbCrLf
                        emailMessage3.Body += "--------------------------------------------------------------------------" & vbCrLf
                        COUNT1 = 0

                        For Each dr1 In DS.Tables("Query6").Rows

                            Try
                                If IsDBNull(Trim(dr1("Date"))) Then
                                    f2 = Space(10)
                                Else
                                    f2 = Mid(Trim(dr1("Date")) + Space(30), 1, 10)
                                    f2 = Mid(Trim(f2), 9, 2) + "/" + Mid(Trim(f2), 6, 2) + "/" + Mid(Trim(f2), 1, 4)

                                End If

                                'SmtpMail.Send(emailMessage)
                                'labelStatus.Text = "Message sent!"
                                'Button1.Enabled = False
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f2 = Space(10)
                            End Try

                            Try
                                If IsDBNull(Trim(dr1("com"))) Then
                                    f4 = "   "
                                Else
                                    f4 = Mid(Trim(dr1("com")) + Space(30), 1, 3)
                                End If

                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f4 = "   "
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("Company"))) Then
                                    f5 = Space(35)
                                Else
                                    f5 = Mid(Trim(dr1("Company")) + Space(35), 1, 25)
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f5 = Space(15)
                            End Try
                            'f6 = Mid(Trim(dr1("F6")) + Space(10), 1, 15)

                            Try

                                If IsDBNull(Trim(dr1("ChqNo"))) Then
                                    f6 = Space(7)
                                Else
                                    f6 = Mid(Trim(dr1("ChqNo")) + Space(25), 1, 7)

                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f6 = Space(7)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("Received"))) Then
                                    f7 = Space(15)
                                Else
                                    f7 = Mid(Trim(dr1("Received")) + Space(20), 1, 12)

                                    sp1 = Space(25)
                                    sp1 = sp1 + Format(Val(Trim(dr1("Received"))), "###,###.00")
                                    sp1 = Right(sp1, 12)
                                    f7 = sp1

                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f7 = Space(12)
                            End Try

                            Try

                                If IsDBNull(Trim(dr1("Payment"))) Then
                                    f8 = Space(12)
                                Else
                                    f8 = Mid(Trim(dr1("Payment")) + Space(15), 1, 1)

                                    sp2 = Space(25)
                                    sp2 = sp2 + Format(Val(Trim(dr1("Payment"))), "###,###.00")
                                    sp2 = Right(sp2, 12)
                                    f8 = sp2
                                End If
                            Catch ex As Exception
                                'labelStatus.Text="Unable to send the e-mail message"
                                ' labelStatus.Text = ex.ToString
                                f8 = Space(12)
                            End Try

                            emailMessage3.Body += "" & f2 & " " & f4 & " " & f5 & " " & f6 & " " & f7 & " " & f8 & " " & vbCrLf



                        Next
                        emailMessage3.Body += " " & vbCrLf
                        emailMessage3.Body += " " & vbCrLf
                        emailMessage3.Body += " " & vbCrLf
                        emailMessage3.Body += "For Details:Please refer the attachment" & vbCrLf

                        FNAME = Server.MapPath("Data/" & "SeeAttached.pdf")
                        emailMessage3.Attachments.Add(New MailAttachment(FNAME))
                        SmtpMail.SmtpServer = "mail.dsisamson.com"
                        Try
                            ' If COUNT <> 0 Then
                            SmtpMail.Send(emailMessage3)

                            'End If
                        Catch ex As Exception

                        End Try


                    End If






                End If
                '---------



                Dim strfg As String

                Dim cmdCustomers As SqlCommand
                Dim strInvNo As String

                Dim strSql As String
                '  Dim Count1 As Integer
                Dim strnos As String
                Dim str_no As String
                Dim str_name As String
                Dim str_mail As String
                Dim StrInvcom, Strdt, strtotval, strtotqty, StrInvCode As String

                Todt = Format(Today, "dd/MM/yyyy")

                ADA = New SqlDataAdapter("Select HltMaster1.Emp_No as Emp_No ,HthMaster.EmployeeName as EmployeeName,HltMaster1.Emp_Com as Emp_Com,HltMaster1.Emp_Amt as Emp_Amt,convert(varchar(10),HltMaster1.Emp_Paydt,103) as Emp_Paydt,HltMaster1.Emp_Typ as Emp_Typ,HltMaster1.Emp_DecAmt as Emp_DecAmt ,HltMaster1.Emp_ChqNo as Emp_ChqNo,HltMaster1.Emp_CNo from HltMaster1 ,HthMaster where (HltMaster1.Emp_No=HthMaster.Epfno AND HltMaster1.Emp_Com=HthMaster.Com) and  HltMaster1.Emp_DecFlg='Yes' and HltMaster1.Emp_Eflg1='Yes' Order by HltMaster1.Emp_Com", CON)
                DS = New DataSet
                ADA.Fill(DS, "HltMaster11")

                COUNT1 = DS.Tables("HltMaster11").Rows.Count
                ' Dim emailMessage As MailMessage

                emailMessage = New MailMessage

                emailMessage.From = "insurance@dsisamson.com"

                emailMessage.To = "lakmal@samsonsportswear.com,chamindas@dsisamson.com"
                emailMessage.Subject = "SHE Processing Claims " + Todt


                emailMessage.Body += "SHE Processing Claims " & vbCrLf
                emailMessage.Body += " " & vbCrLf

                If COUNT1 <> 0 Then

                    ans1 = "Yes"

                    For Each dr2 In DS.Tables("HltMaster11").Rows

                        If ans1 = "Yes" Then
                            sCOM = dr2("Emp_com")
                            ans1 = "No"

                            ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                            DS1 = New DataSet
                            ADA1.Fill(DS1, "Company")

                            COUNT2 = DS1.Tables("Company").Rows.Count
                            For Each DR3 In DS1.Tables("Company").Rows

                                SCNam = DR3("Com_Nam")

                            Next

                            emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                            emailMessage.Body += "Submit Date  Epf No       Name                    Submit Amount" & vbCrLf
                            emailMessage.Body += "---------------------------------------------------------------" & vbCrLf

                            EmpCom = dr2("Emp_com")
                            Empno = dr2("Emp_no")

                            ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                            DS3 = New DataSet
                            ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                            ADA2.Fill(DS3, "HthMaster")

                            COUNT2 = DS3.Tables("HthMaster").Rows.Count

                            If COUNT2 <> 0 Then

                                For Each DR3 In DS3.Tables("HthMaster").Rows
                                    SCNam = DR3("EMPLOYEENAME")

                                Next
                            End If

                            EmpAmt = dr2("Emp_DecAmt")
                            EmpPayDt = dr2("Emp_PayDt")
                            sp1 = Space(20)
                            sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                            sp1 = Right(sp1, 8)

                            sp2 = Space(6)
                            sp2 = sp2 + Format(Val(Empno), "#####")
                            sp2 = Right(sp2, 5)

                            sp3 = Space(30)
                            sp3 = SCNam + sp3
                            sp3 = Left(sp3, 34)
                            emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp1 + " " & vbCrLf

                            sCOM = EmpCom

                        Else

                            If sCOM = dr2("Emp_com") Then
                                EmpCom = dr2("Emp_com")
                                Empno = dr2("Emp_no")

                                ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = '" & Empno & "' and Com='" & EmpCom & "'", CON)
                                DS3 = New DataSet
                                ss = "SELECT * FROM HthMaster WHERE EpfNo = '" & Empno & "' and com='" & EmpCom & "'"
                                ADA2.Fill(DS3, "HthMaster")

                                COUNT2 = DS3.Tables("HthMaster").Rows.Count

                                If COUNT2 <> 0 Then

                                    For Each DR3 In DS3.Tables("HthMaster").Rows
                                        SCNam = DR3("EMPLOYEENAME")

                                    Next
                                End If

                                EmpAmt = dr2("Emp_DecAmt")
                                EmpPayDt = dr2("Emp_PayDt")
                                sp1 = Space(20)
                                sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                                sp1 = Right(sp1, 8)

                                sp2 = Space(6)
                                sp2 = sp2 + Format(Val(Empno), "#####")
                                sp2 = Right(sp2, 5)

                                sp3 = Space(30)
                                sp3 = SCNam + sp3
                                sp3 = Left(sp3, 34)
                                emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp1 + " " & vbCrLf

                                sCOM = EmpCom
                            Else


                                emailMessage.Body += " " & vbCrLf

                                sCOM = dr2("Emp_com")

                                ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                                DS1 = New DataSet
                                ADA1.Fill(DS1, "Company")

                                COUNT2 = DS1.Tables("Company").Rows.Count
                                For Each DR3 In DS1.Tables("Company").Rows

                                    SCNam = DR3("Com_Nam")

                                Next

                                emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                                emailMessage.Body += "Submit Date  Epf No       Name                    Submit Amount" & vbCrLf
                                emailMessage.Body += "---------------------------------------------------------------" & vbCrLf


                                EmpCom = dr2("Emp_com")

                                Empno = dr2("Emp_no")

                                EmpAmt = dr2("Emp_DecAmt")
                                EmpPayDt = dr2("Emp_PayDt")

                                ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                                DS3 = New DataSet
                                ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                                ADA2.Fill(DS3, "HthMaster")

                                COUNT2 = DS3.Tables("HthMaster").Rows.Count

                                If COUNT2 <> 0 Then

                                    For Each DR3 In DS3.Tables("HthMaster").Rows
                                        SCNam = DR3("EMPLOYEENAME")

                                    Next
                                End If

                                EmpAmt = dr2("Emp_DecAmt")
                                EmpPayDt = dr2("Emp_PayDt")

                                sp1 = Space(20)
                                sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                                sp1 = Right(sp1, 8)

                                sp2 = Space(6)
                                sp2 = sp2 + Format(Val(Empno), "#####")
                                sp2 = Right(sp2, 5)

                                sp3 = Space(30)
                                sp3 = SCNam + sp3
                                sp3 = Left(sp3, 34)
                                emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp1 + " " & vbCrLf


                                sCOM = EmpCom
                            End If

                        End If


                    Next

                    SmtpMail.SmtpServer = "mail.dsisamson.com"
                    Try
                        SmtpMail.Send(emailMessage)
                        'labelStatus.Text = "Message sent!"
                        'Button1.Enabled = False
                    Catch ex As Exception
                        'labelStatus.Text="Unable to send the e-mail message"
                        ' labelStatus.Text = ex.ToString
                    End Try

                    '---------------------------------------------------------------------------------------------------'
                    Cmd1.Connection = CON
                    'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
                    Cmd1.CommandText = "UPDATE HltMaster1 SET Emp_Eflg1='No' Where Emp_DecFlg='Yes' and Emp_EFlg1='Yes'"
                    Cmd1.ExecuteNonQuery()
                    '---------------------------------------------------------------------------------------------------'

                End If

                ADA = New SqlDataAdapter("Select HltMaster1.Emp_No as Emp_No ,HthMaster.EmployeeName as EmployeeName,HltMaster1.Emp_Com as Emp_Com,HltMaster1.Emp_Amt as Emp_Amt,convert(varchar(10),HltMaster1.Emp_Recdt,103) as Emp_Recdt,HltMaster1.Emp_Typ as Emp_Typ,HltMaster1.Emp_DecAmt as Emp_DecAmt ,HltMaster1.Emp_ChqNo as Emp_ChqNo,HltMaster1.Emp_CNo from HltMaster1 ,HthMaster where (HltMaster1.Emp_No=HthMaster.Epfno AND HltMaster1.Emp_Com=HthMaster.Com) and  HltMaster1.Emp_DecFlg='No' and HltMaster1.Emp_Eflg2='Yes' Order by HltMaster1.Emp_Com,HltMaster1.Emp_No,HltMaster1.Emp_Chqno", CON)
                DS = New DataSet
                ADA.Fill(DS, "HltMaster11")

                COUNT1 = DS.Tables("HltMaster11").Rows.Count

                ' Dim emailMessage As MailMessage
                emailMessage = New MailMessage

                emailMessage.From = "insurance@dsisamson.com"


                totamt = 0
                If COUNT1 <> 0 Then


                    ans1 = "Yes"
                    ans2 = "111"
                    For Each dr2 In DS.Tables("HltMaster11").Rows

                        If ans1 = "Yes" Then
                            sCOM = dr2("Emp_com")
                            ans1 = "No"
                            ans2 = "No"
                            ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                            DS1 = New DataSet
                            ADA1.Fill(DS1, "Company")
                            totamt = 0
                            COUNT2 = DS1.Tables("Company").Rows.Count
                            For Each DR3 In DS1.Tables("Company").Rows

                                SCNam = DR3("Com_Nam")
                                STEmail = DR3("Com_TEmail")
                            Next

                            EmpChqNo = dr2("Emp_ChqNo")

                            emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                            emailMessage.Body += " " & vbCrLf

                            emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                            emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf


                            emailMessage.Body += "Recieved Date  Epf No       Name                  Submit Amount    Claim Amount" & vbCrLf
                            emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf

                            EmpCom = dr2("Emp_com")

                            Empno = dr2("Emp_no")

                            EmpAmt = dr2("Emp_DecAmt")
                            EmpPayDt = dr2("Emp_RecDt")
                            SChqNo = EmpChqNo
                            ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                            DS3 = New DataSet
                            ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                            ADA2.Fill(DS3, "HthMaster")

                            COUNT2 = DS3.Tables("HthMaster").Rows.Count

                            If COUNT2 <> 0 Then

                                For Each DR3 In DS3.Tables("HthMaster").Rows
                                    SCNam = DR3("EMPLOYEENAME")
                                Next
                            End If

                            EmpAmt = dr2("Emp_DecAmt")
                            EmpPayDt = dr2("Emp_RecDt")

                            sp1 = Space(20)
                            sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                            sp1 = Right(sp1, 8)

                            sp2 = Space(6)
                            sp2 = sp2 + Format(Val(Empno), "#####")
                            sp2 = Right(sp2, 5)

                            sp3 = Space(30)
                            sp3 = SCNam + sp3
                            sp3 = Left(sp3, 34)
                            sp4 = Space(20)
                            sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                            sp4 = Right(sp4, 8)



                            emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf
                            sCOM = EmpCom
                            ans2 = "No"

                            totamt = totamt + Val(EmpAmt)
                        Else



                            If sCOM = dr2("Emp_com") Then


                                If SChqNo <> dr2("Emp_ChqNo") Then
                                    ' sp1 = Space(20)
                                    ' sp1 = sp1 + Format(Totamt, "###,###.00")
                                    ' sp1 = Right(sp1, 8)
                                    ' emailMessage.Body += "Total Amount                               :" + "" + sp1 & vbCrLf

                                    ' totamt = 0
                                    ' SChqNo = dr2("Emp_ChqNo")
                                    ' emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf

                                Else



                                    totamt = totamt + Val(dr2("Emp_Amt"))

                                End If

                                EmpCom = dr2("Emp_com")
                                Empno = dr2("Emp_no")
                                ans2 = "Yes"
                                ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = '" & Empno & "' and Com='" & EmpCom & "'", CON)
                                DS3 = New DataSet
                                ss = "SELECT * FROM HthMaster WHERE EpfNo = '" & Empno & "' and com='" & EmpCom & "'"
                                ADA2.Fill(DS3, "HthMaster")

                                COUNT2 = DS3.Tables("HthMaster").Rows.Count

                                If COUNT2 <> 0 Then

                                    For Each DR3 In DS3.Tables("HthMaster").Rows
                                        SCNam = DR3("EMPLOYEENAME")

                                    Next
                                End If
                                EmpDecAmt = dr2("Emp_DecAmt")
                                EmpAmt = dr2("Emp_Amt")
                                EmpPayDt = dr2("Emp_RecDt")
                                sp1 = Space(20)
                                sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                                sp1 = Right(sp1, 8)

                                sp2 = Space(6)
                                sp2 = sp2 + Format(Val(Empno), "#####")
                                sp2 = Right(sp2, 5)

                                sp3 = Space(30)
                                sp3 = SCNam + sp3
                                sp3 = Left(sp3, 34)

                                sp4 = Space(20)
                                sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                                sp4 = Right(sp4, 8)



                                emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf

                                sCOM = EmpCom

                            Else


                                If ans2 = "No" Then
                                    ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                                    DS1 = New DataSet
                                    ADA1.Fill(DS1, "Company")

                                    COUNT2 = DS1.Tables("Company").Rows.Count
                                    For Each DR3 In DS1.Tables("Company").Rows

                                        SCNam = DR3("Com_Nam")
                                        STEmail = DR3("Com_TEmail")
                                    Next

                                    EmpChqNo = dr2("Emp_ChqNo")
                                    totamt = 0
                                    emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                                    emailMessage.Body += " " & vbCrLf

                                    emailMessage.Body += "Company :" + "" + SCNam & vbCrLf

                                    emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf


                                    emailMessage.Body += "Submit Date  Epf No       Name                    Submit Amount    Claim Amount" & vbCrLf
                                    emailMessage.Body += "-------------------------------------------------------------------------------" & vbCrLf

                                    EmpCom = dr2("Emp_com")

                                    Empno = dr2("Emp_no")

                                    EmpAmt = dr2("Emp_DecAmt")
                                    EmpPayDt = dr2("Emp_RecDt")

                                    ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and Com='" & EmpCom & "'", CON)
                                    DS3 = New DataSet
                                    ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                                    ADA2.Fill(DS3, "HthMaster")

                                    COUNT2 = DS3.Tables("HthMaster").Rows.Count

                                    If COUNT2 <> 0 Then

                                        For Each DR3 In DS3.Tables("HthMaster").Rows
                                            SCNam = DR3("EMPLOYEENAME")

                                        Next
                                    End If

                                    EmpAmt = dr2("Emp_DecAmt")
                                    EmpPayDt = dr2("Emp_RecDt")

                                    sp1 = Space(20)
                                    sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                                    sp1 = Right(sp1, 8)

                                    sp2 = Space(6)
                                    sp2 = sp2 + Format(Val(Empno), "#####")
                                    sp2 = Right(sp2, 5)

                                    sp3 = Space(30)
                                    sp3 = SCNam + sp3
                                    sp3 = Left(sp3, 34)
                                    sp4 = Space(20)
                                    sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                                    sp4 = Right(sp4, 8)



                                    emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf
                                    sCOM = EmpCom
                                    ans2 = "Yes"
                                    totamt = totamt + Val(EmpAmt)
                                End If

                                emailMessage.To = Trim(STEmail)
                                emailMessage.Subject = "SHE Claims Recieved " + Todt


                                SmtpMail.SmtpServer = "mail.dsisamson.com"
                                'SmtpMail.SmtpServer = "mail.dsisamson.com"

                                Try
                                    SmtpMail.Send(emailMessage)
                                    'labelStatus.Text = "Message sent!"
                                    'Button1.Enabled = False
                                Catch ex As Exception
                                    'labelStatus.Text="Unable to send the e-mail message"
                                    ' labelStatus.Text = ex.ToString
                                End Try





                                emailMessage.Body += " " & vbCrLf

                                sCOM = dr2("Emp_com")

                                ADA1 = New SqlDataAdapter("Select Com_No ,Com_Nam,Com_Temail,Com_Eout from Company where Com_no='" & sCOM & "'", CON)
                                DS1 = New DataSet
                                ADA1.Fill(DS1, "Company")

                                COUNT2 = DS1.Tables("Company").Rows.Count
                                For Each DR3 In DS1.Tables("Company").Rows

                                    SCNam = DR3("Com_Nam")
                                    STEmail = DR3("Com_TEmail")
                                Next

                                EmpChqNo = dr2("Emp_ChqNo")
                                emailMessage.Body = "SHE Claims Recieved " & vbCrLf
                                emailMessage.Body += " " & vbCrLf
                                emailMessage.Body += "Company :" + "" + SCNam & vbCrLf
                                emailMessage.Body += "Cheque No :" + "" + EmpChqNo & vbCrLf

                                totamt = 0
                                emailMessage.Body += "Submit Date  Epf No       Name                    Submit Amount  Claim Amount" & vbCrLf
                                emailMessage.Body += "-----------------------------------------------------------------------------" & vbCrLf



                                EmpCom = dr2("Emp_com")

                                Empno = dr2("Emp_no")

                                EmpAmt = dr2("Emp_DecAmt")
                                EmpPayDt = dr2("Emp_RecDt")

                                ADA2 = New SqlDataAdapter("SELECT * FROM HthMaster WHERE EpfNo = '" & Empno & "' and Com='" & EmpCom & "'", CON)
                                DS3 = New DataSet
                                ss = "SELECT * FROM HthMaster WHERE EpfNo = " & Empno & " and com='" & EmpCom & "'"
                                ADA2.Fill(DS3, "HthMaster")

                                COUNT2 = DS3.Tables("HthMaster").Rows.Count

                                If COUNT2 <> 0 Then

                                    For Each DR3 In DS3.Tables("HthMaster").Rows
                                        SCNam = DR3("EMPLOYEENAME")

                                    Next
                                End If

                                EmpAmt = dr2("Emp_DecAmt")
                                EmpPayDt = dr2("Emp_RecDt")

                                sp1 = Space(20)
                                sp1 = sp1 + Format(Val(EmpAmt), "###,###.00")
                                sp1 = Right(sp1, 8)

                                sp2 = Space(6)
                                sp2 = sp2 + Format(Val(Empno), "#####")
                                sp2 = Right(sp2, 5)

                                sp3 = Space(30)
                                sp3 = SCNam + sp3
                                sp3 = Left(sp3, 34)
                                sp4 = Space(20)
                                sp4 = sp4 + Format(Val(EmpDecAmt), "###,###.00")
                                sp4 = Right(sp4, 8)



                                emailMessage.Body += EmpPayDt + " " + sp2 + "   " + sp3 + "  " + sp4 + "    " + sp1 + " " & vbCrLf
                                sCOM = EmpCom
                                totamt = totamt + Val(EmpAmt)

                            End If

                        End If

                    Next




                    '---------------------------------------------------------------------------------------------------'
                    Cmd1.Connection = CON
                    'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
                    Cmd1.CommandText = "UPDATE HltMaster1 SET Emp_Eflg2='No' Where Emp_DecFlg='No' and Emp_EFlg2='Yes'"
                    Cmd1.ExecuteNonQuery()
                    '---------------------------------------------------------------------------------------------------'


                    Response.Redirect("sgcsSHE1.aspx?UID=" & TxtId.Text & "")

                    'Response.Redirect("Dispaly1.aspx")




                End If



            End If



        End If






    End Sub
End Class

