Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail


Public Class EntryVehSold
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Public Tfdt, Ttdt As String
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    'Dim pos1 As String
    Public pos1 As String

    Dim Typ As String
    Dim Count, dtdiff, dtdiff1 As Integer
    Dim SS As String
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents LbLMsg As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm

    Protected WithEvents TxtCerNo As System.Web.UI.WebControls.TextBox

    Protected WithEvents TxtSldDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRefAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTotAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtfdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtdays As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtbalAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTotAmt1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Dim PAG As Boolean

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnCle As System.Web.UI.WebControls.Button
    Protected WithEvents BtnApp As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtId As System.Web.UI.WebControls.TextBox
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents LstCom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstId As System.Web.UI.WebControls.DropDownList
    Protected WithEvents BtnDel As System.Web.UI.WebControls.Button

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
        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11
        Dim PFLAG, Psec As String
        Dim COUNT1, COUNT2, COUNT3 As Integer
        Dim drt2, drt3 As DataRow


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        PFLAG = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)




        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        COUNT1 = DS.Tables("UsdMaster").Rows.Count


        If COUNT1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows

                COUNT2 = drt2("User_lvl")
                Psec = drt2("User_sec")


            Next
        Else
            ' Response.Redirect("InsuDept.aspx ?UID=TxtId.Text

        End If

        '  If Not IsPostBack Then


        If COUNT2 = "1" Then
            PFLAG = "Y"

        Else

            If COUNT2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level2='1'", CON)

            Else
                If COUNT2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level3='1'", CON)

                Else
                    If COUNT2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='HelthEntry.aspx' and Form_level4='1'", CON)
                    Else
                        If COUNT2 = "5" Then

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
                PFLAG = "Y"
            End While

            DR.Close()

        End If


        If PFLAG = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else

            Response.Redirect("POSDispaly11.aspx")
        End If


        If Not IsPostBack Then
            LstId.Enabled = False
            LstCom.Enabled = True
            Lsttyp.Enabled = False
            ' TxtRefAmt.Enabled = False
            TxtSldDt.Enabled = False
            ' TxtCerNo.Enabled = False


            TxtRefAmt.Text = " "
            TxtSldDt.Text = " "
            'TxtCerNo.Text = " "



            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT Veh_no FROM VehMast where veh_no<>'' ", CON)

            DR = CMD.ExecuteReader

            If Not IsPostBack Then


                While DR.Read
                    TT = DR.GetValue(0)
                    LstId.Items.Add(TT)
                End While
            End If
            DR.Close()


            CMD = New SqlCommand("SELECT Com_No,Com_nam From Company", CON)


            DR = CMD.ExecuteReader


            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                    LstCom.Items.Add(TT)
                End While
            End If

            DR.Close()


            CMD = New SqlCommand("SELECT * from VehTypMast", CON)

            DR = CMD.ExecuteReader
            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(2)
                    Lsttyp.Items.Add(TT)
                End While
            End If




            DR.Close()
            TxtId.Enabled = False

            'TxtRefAmt.Enabled = False
            ' Txtbpay.Enabled = False
            'TxtCerNo.Enabled = False


        End If
        Dim V1, V2, V3 As String
        If BtnAdd.Enabled = True Then
            V1 = "http://192.168.12.181\Insu\Newpict\" & Trim(TxtId.Text) & "1.jpg"
        Else
            V1 = "http://192.168.12.181\Insu\Newpict\" & Trim(LstId.SelectedValue) & "1.jpg"
        End If
        If BtnAdd.Enabled = True Then
            V2 = "http://192.168.12.181\Insu\Newpict\" & Trim(TxtId.Text) & "2.jpg"
        Else
            V2 = "http://192.168.12.181\Insu\Newpict\" & Trim(LstId.SelectedValue) & "2.jpg"
        End If

        V3 = "http://192.168.12.181\Insu\Newpict\"

        If IsDBNull(V1) = False Then
            '   Img1.Visible = True
            ' Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            'Img2.Visible = True
            'Img2.ImageUrl = V2
        End If







        CON.Close()

        LstId.Enabled = True
        Lsttyp.Enabled = True
        'TxtRefAmt.Enabled = True
        ' Txtbpay.Enabled = True
        'TxtCerNo.Enabled = True
        'TxtCerNo.Visible = True

        'Txtrcc.Enabled = True
        'Txtrcc.Visible = True
        'Txttr.Enabled = True
        'Txttr.Visible = True

        TxtId.Visible = False
        TxtId.Enabled = False
        LstId.Visible = True
        LstId.Enabled = True
        BtnAdd.Enabled = False
        BtnApp.Enabled = True
        BtnDel.Enabled = True
        TxtId.Visible = True


    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        TxtId.Enabled = True
        TxtId.Visible = True

        LstId.Visible = False
        LstCom.Enabled = True
        Lsttyp.Enabled = True
        TxtRefAmt.Enabled = True
        TxtSldDt.Enabled = True
        TxtCerNo.Enabled = True


        TxtRefAmt.Text = ""
        TxtSldDt.Text = ""
        TxtCerNo.Text = ""



        LstCom.Enabled = True

        BtnEdit.Enabled = False
        TxtId.Text = ("")

        'TxtRefAmt.Text = ("")
        'Txtbpay.Text = ("")
        'TxtCerNo.Text = ("")
        ' LstCom.SelectedValue = " "
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")



        BtnApp.Enabled = True
        BtnDel.Enabled = False
        LstId.Visible = False

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        LstId.Enabled = True
        Lsttyp.Enabled = True
        'TxtRefAmt.Enabled = True
        ' Txtbpay.Enabled = True
        'TxtCerNo.Enabled = True
        'TxtCerNo.Visible = True

        'Txtrcc.Enabled = True
        'Txtrcc.Visible = True
        'Txttr.Enabled = True
        'Txttr.Visible = True

        TxtId.Visible = False
        TxtId.Enabled = False
        LstId.Visible = True
        LstId.Enabled = True
        BtnAdd.Enabled = False
        BtnApp.Enabled = True
        BtnDel.Enabled = True
        TxtId.Visible = True

    End Sub

    Private Sub BtnCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCle.Click
        'TxtId.Visible = True
        'TxtId.Enabled = True
        'LstId.Visible = True
        'LstId.Enabled = True
        BtnAdd.Enabled = True
        BtnApp.Enabled = True
        BtnDel.Enabled = True
        'TxtId.Visible = True
        BtnEdit.Enabled = True
        BtnEdit.Visible = True

        'TxtId.Text = ("")
        'TxtRefAmt.Text = ("")
        'Txtbpay.Text = ("")
        'TxtCerNo.Text = ("")
        '' LstCom.SelectedValue = " "
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")

    End Sub

    Private Sub LstId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstId.SelectedIndexChanged
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        idno = Trim(LstId.SelectedValue)


        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & idno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")

        Count = DS.Tables("VEHMAST").Rows.Count
        Dim dr1, dr2 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            LbLMsg.Text = "                       "


            For Each dr1 In DS.Tables("VEHMAST").Rows

                ' LstCom.SelectedValue = dr1("Veh_Com")
                Lsttyp.SelectedValue = dr1("Veh_Typ")
                TxtTotAmt.Text = Right(Space(20) + Format(dr1("Veh_TotChqPay"), "###,###.00"), 20)
                TxtTotAmt1.Text = dr1("Veh_TotChqPay")

                Tfdt = Format(dr1("Veh_EfDt"), "MM/dd/yyyy")

                'Tfdt = Format(Val(Mid(dr1("Veh_EfDt"), 1, 2)), "00") + "/" + Format(Val(Mid(dr1("Veh_EfDt"), 4, 2)), "00") + "/" + Format(Val(Mid(dr1("Veh_EfDt"), 7, 4)), "0000")
                Ttdt = Format(dr1("Veh_ExDt"), "MM/dd/yyyy")
                'Ttdt = Mid(dr1("Veh_ExDt"), 1, 2) + "/" + Mid(dr1("Veh_ExDt"), 4, 2) + "/" + Mid(dr1("Veh_ExDt"), 7, 4)

                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                Txtfdt.Text = Format(dr1("Veh_EfDt"), "dd/MM/yyyy")
                TxtTdt.Text = Format(dr1("Veh_ExDt"), "dd/MM/yyyy")


                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If
                End If

                Txtdays.Text = dtdiff

                Dim SS As String
                SS = "SELECT Com_No,Com_nam From Company where Com_nO='" & dr1("Veh_COM") & "'"
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_nO='" & dr1("Veh_cOM") & "'", CON)

                DR3 = CMD.ExecuteReader

                Dim TT As String

                'If Not IsPostBack Then
                While DR3.Read
                    TT = DR3.GetValue(0) + " - " + DR3.GetValue(1)
                    LstCom.SelectedValue = TT
                End While
                'End If

                DR3.Close()
                'LstCom.SelectedValue = dr1("Veh_COM")

                Dim dt1, dt2, dt3 As String

                Typ = dr1("Veh_Typ")
                TxtRefAmt.Text = " "

                If IsDBNull(dr1("Veh_slddt")) Then
                    dt1 = Format(Day(Today()), "00")
                    dt2 = Format(Month(Today()), "00")
                    dt3 = Format(Year(Today()), "0000")
                Else
                    dt1 = Format(Day(CDate(IIf(IsDBNull(dr1("Veh_slddt")), " ", dr1("Veh_slddt")))), "00")
                    dt2 = Format(Month(CDate(IIf(IsDBNull(dr1("Veh_slddt")), " ", dr1("Veh_slddt")))), "00")
                    dt3 = Year(CDate(IIf(IsDBNull(dr1("Veh_slddt")), " ", dr1("Veh_slddt"))))
                End If


                TxtSldDt.Text = dt1 + "/" + dt2 + "/" + dt3
                SS = Mid(TxtSldDt.Text, 1, 2) + "/" + Mid(TxtSldDt.Text, 4, 2) + "/" + Mid(TxtSldDt.Text, 7, 4)

                Ttdt = Mid(TxtSldDt.Text, 4, 2) + "/" + Mid(TxtSldDt.Text, 1, 2) + "/" + Mid(TxtSldDt.Text, 7, 4)
                'Ttdt = Format(CDate(SS), "dd/MM/yyyy")

                dtdiff1 = DateDiff(DateInterval.Day, CDate(Mid(Txtfdt.Text, 4, 2) + "/" + Mid(Txtfdt.Text, 1, 2) + "/" + Mid(Txtfdt.Text, 7, 4)), CDate(Ttdt))
                TxtRefAmt.Text = Right(Space(20) + Format(((dr1("Veh_TotChqPay")) - (dr1("Veh_TotChqPay") / dtdiff * dtdiff1)), "######.00"), 20)
                TxtbalAmt.Text = Right(Space(20) + Format((dr1("Veh_TotChqPay") / dtdiff * dtdiff1), "######.00"), 20)
                TxtNo.Text = dtdiff1
                'TxtSldDt.Text = IIf(IsDBNull(dr1("Veh_recdt")), " ", dr1("Veh_recdt"))


                'TxtCerNo.Text = IIf(IsDBNull(dr1("Veh_CertifyNo")), " ", dr1("Veh_CertifyNo"))

                ' TxtRefAmt.Enabled = True
                TxtSldDt.Enabled = True


                'Txtbpay.Text = dr1("Emp_TaLv")
                'TxtCerNo.Text = dr1("Emp_CntNo")
                'Txtrcc.Text = dr1("Emp_email")
                'Txttr.Text = dr1("Emp_des")
            Next

            Exit Sub

        Else
            LbLMsg.Text = "Record Not Found !"





            TxtCerNo.Text = ""

            TxtRefAmt.Text = ""
            TxtSldDt.Text = ""


            TxtCerNo.Enabled = False
            TxtSldDt.Enabled = False
            TxtRefAmt.Enabled = False


        End If




    End Sub

    Private Sub LstCom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCom.SelectedIndexChanged
        CON.Open()

        Dim IDNO As String
        Dim COM As String
        Dim Count As Double
        Dim dr1 As DataRow
        IDNO = Mid((LstId.SelectedValue), 1, 5)
        COM = Mid(Trim(LstCom.SelectedValue), 1, 3)

        ' If BtnAdd.Enabled = False Then
        'IDNO = Mid(Trim(LstId.SelectedValue), 1, 5)
        'COM = Mid(Trim(LstCom.SelectedValue), 1, 3)

        'CMD = New SqlCommand("SELECT * FROM EMPMAST WHERE EMP_COM = '" & COM & "' AND EMP_NO = '" & IDNO & "'", CON)
        'RE = CMD.ExecuteReader

        'ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_COM = '" & COM & "' AND EMP_NO = '" & IDNO & "'", CON)
        'DS = New DataSet
        'ADA.Fill(DS, "EmpMast")

        'Count = DS.Tables("EmpMast").Rows.Count
        'If Count <> 0 Then
        '    For Each dr1 In DS.Tables("EmpMast").Rows


        'TxtNam.Text = dr1("Emp_Name")
        'TxtRefAmt.Text = dr1("Emp_ToLv")
        'Txtbpay.Text = dr1("Emp_TaLv")
        'TxtCerNo.Text = dr1("Emp_CntNo")
        'Txtrcc.Text = dr1("Emp_email")
        'Txttr.Text = dr1("Emp_des")
        '    Next
        'Else
        'TxtNam.Text = ("")
        ' TxtRefAmt.Text = ("")
        'Txtbpay.Text = ("")
        'TxtCerNo.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")

        'End If

        ' Else

        'IDNO = Mid(Trim(TxtId.Text), 1, 4)
        'COM = Mid(Trim(LstCom.SelectedValue), 1, 3)
        'TxtNam.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")
        'TxtCerNo.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")
        '  End If


        'End If
    End Sub

    Private Sub BtnApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApp.Click
        CON.Open()
        Dim CMD As SqlCommand
        Dim IDNO As String
        Dim COM As String
        Dim typ As String
        Dim Count As Double
        Dim dr1 As DataRow
        IDNO = LstId.SelectedValue
        COM = Mid(Trim(LstCom.SelectedValue), 1, 3)


        CMD = New SqlCommand("SELECT * FROM vehtypmast", CON)
        DR = CMD.ExecuteReader
        DR.Close()




        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & IDNO & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")
        IDNO = LstId.SelectedValue
        COM = Mid(LstCom.SelectedValue, 1, 3)
        typ = Lsttyp.SelectedValue
        Count = DS.Tables("VEHMAST").Rows.Count
        If Count <> 0 Then

            'TxtNam.Text = dr1("Emp_Name")
            'TxtRefAmt.Text = dr1("Emp_ToLv")
            'Txtbpay.Text = dr1("Emp_TaLv")
            'TxtCerNo.Text = dr1("Emp_CntNo")
            CMD.Connection = CON
            ' SS = "UPDATE VEHMAST SET VEH_refAmt='" & TxtRefAmt.Text & "',VEH_BalAmt='" & TxtbalAmt.Text & "',Sold='Y',VEH_SldDt='" & Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4) & "' WHERE VEH_NO='" & IDNO & "'"
            ' SS = "UPDATE VEHMAST SET VEH_refAmt=" & Format(TxtRefAmt.Text, 9999999.99) & ",VEH_BalAmt=" & Format(TxtbalAmt.Text, 999999.99) & ",Sold='Y',VEH_SldDt='" & Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4) & "' WHERE VEH_NO='" & IDNO & "'"

            CMD.CommandText = ("UPDATE VEHMAST SET VEH_refAmt=" & Val(TxtRefAmt.Text) & ",VEH_BalAmt=" & Val(TxtbalAmt.Text) & ",Sold='Y',VEH_SldDt='" & Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4) & "' WHERE VEH_NO='" & IDNO & "'")
            CMD.ExecuteNonQuery()

            '------------------

            Dim User1 As String
            Dim Pwd1 As String
            Dim Count1, Count2 As Double
            Dim dr2, dr3 As DataRow
            'User1 = TxtUser1.Text
            'Pwd1 = TxtPwd1.Text
            User1 = "11111"
            Pwd1 = "11111"
            ADA = New SqlDataAdapter("SELECT * FROM ADMIN WHERE AD_User = '" & User1 & "' AND AD_pwd = '" & Pwd1 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "ADMIN")
            Dim Femail, Temail, Ename As String
            Count = DS.Tables("ADMIN").Rows.Count
            If Count <> 0 Then


                For Each dr1 In DS.Tables("Admin").Rows
                    Ename = dr1("Ad_Nam")
                    Temail = dr1("Ad_email")

                Next
                Dim ss1 As String
                Dim ln As Integer

                'TxtNam.Text = dr1("Emp_Name")
                'TxtToLv.Text = dr1("Emp_ToLv")
                'TxtTaLv.Text = dr1("Emp_TaLv")
                'TxtCntNo.Text = dr1("Emp_CntNo")
                ' cmdCustomers.Connection = objConn

                ' SS = ("UPDATE EMPMAST SET EMP_Talv='" & (Talv + strNolv) & "',EMP_BALV='" & (Balv - strNolv) & "' WHERE EMP_NO='" & strid & "'")
                '''cmdCustomers = New SqlCommand(SS, objConn)
                '''objConn.Open()
                '''cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)

                Dim emailMessage As MailMessage
                emailMessage = New MailMessage
                emailMessage.From = "insurance@dsisamson.com"
                'emailMessage.To = Temail
                emailMessage.To = "udanip@samsoncorporates.com"

                'emailMessage.Attachments.Add("c:\RtnTxt.txt")
                'emailMessage.Cc = str_mail
                'emailMessage.Bcc = em1
                emailMessage.Subject = "For Your Approval "

                emailMessage.Body = "Vehcle No :" + IDNO + " " + COM + " " + typ + "  " + "http://192.168.12.181/Insu/InsuApproval.aspx"
                ' emailMessage.Body = "http://192.168.12.181/Insu/CrsCertificate.aspx"

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

            '---------------  
        End If



        'End If
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        CON.Open()
        Dim CMD As SqlCommand
        Dim IDNO As String
        Dim COM As String
        Dim Count As Double
        Dim dr1 As DataRow

        IDNO = Trim(LstId.SelectedValue)



        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & IDNO & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")

        Count = DS.Tables("VEHMAST").Rows.Count
        Dim dr2 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            CMD = New SqlCommand("SELECT * FROM vehtypmast", CON)
            DR = CMD.ExecuteReader
            DR.Close()


            CMD.Connection = CON
            CMD.CommandText = ("DELETE FROM VEHMAST WHERE VEH_NO = '" & IDNO & "'")
            CMD.ExecuteNonQuery()
        End If
    End Sub

    Private Sub TxtCerNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lsttyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsttyp.SelectedIndexChanged

        '  If pos1 = "Y" Then






        Typ = Trim(Lsttyp.SelectedValue)


        ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & Typ & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHTYPMAST")

        Count = DS.Tables("VEHTYPMAST").Rows.Count
        Dim dr1 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            For Each dr1 In DS.Tables("VEHTYPMAST").Rows


                pay1 = dr1("Veh_tp_tppd")
                pay2 = dr1("Veh_B_ Primum")
                pay3 = dr1("Veh_Rcc")
                pay4 = dr1("Veh_Rcc")
                pay5 = dr1("Veh_Tr")
                pay6 = dr1("Veh_vat")

                Dim Tfdt, Ttdt As String
                If Trim(TxtRefAmt.Text) = "" Or Trim(TxtSldDt.Text) = "" Then

                Else
                    Tfdt = Mid(Trim(TxtRefAmt.Text), 4, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 1, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 7, 4)
                    Ttdt = Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4)
                    dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                    '''Txtbpay.Text = Format(Round(TxtCerNo.Text * Val(pay2) / 100, 2), "#,###,###.##")
                    '''Txtrcc.Text = Format(Round(TxtCerNo.Text * Val(pay3) / 100, 2), "#,###,###.##")
                    '''Txttr.Text = Format(Round(TxtCerNo.Text * Val(pay5) / 100, 2), "#,###,###.##")
                    '''TxtPPre.Text = Format(pay1, "###,###.##")
                    '''Lbldys.Text = dtdiff - 1

                    Dim Tpay As Double
                    pay1 = pay1 / 365 * (dtdiff - 1)
                    Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1


                    '''TxtTpay.Text = Format(Round(Tpay, 2), "###,###,##")
                    '''TxtDed.Text = Format((TxtTpay.Text - TxtPPre.Text) * 2 / 100, "###,###.##")

                End If

            Next

        End If
        '  End If
    End Sub

    Private Sub Txtbpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtChqNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If IsPostBack Then

            Dim ppp As String
            Dim dt As Date
            Dim dt1 As String
            Dim dt2 As String
            Dim dt3 As String

            'TxtSldDt.Text = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtRefAmt.Text, 4, 2) + "/" + Mid((TxtRefAmt.Text), 1, 2) + "/" + Mid((TxtRefAmt.Text), 7, 4))))
            dt = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtRefAmt.Text, 4, 2) + "/" + Mid((TxtRefAmt.Text), 1, 2) + "/" + Mid((TxtRefAmt.Text), 7, 4))))

            dt1 = Format(Day(dt), "00")
            dt2 = Format(Month(dt), "00")
            dt3 = Year(dt)


            ppp = dt1 + "/" + dt2 + "/" + dt3

            TxtSldDt.Text = ppp

        End If
    End Sub

    Private Sub TxtRecDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dtdiff As Integer


        Typ = Trim(Lsttyp.SelectedValue)


        ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & Typ & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHTYPMAST")

        Count = DS.Tables("VEHTYPMAST").Rows.Count
        Dim dr1 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            For Each dr1 In DS.Tables("VEHTYPMAST").Rows


                pay1 = dr1("Veh_tp_tppd")
                pay2 = dr1("Veh_B_ Primum")
                pay3 = dr1("Veh_Rcc")
                pay4 = dr1("Veh_Rcc")
                pay5 = dr1("Veh_Tr")
                pay6 = dr1("Veh_vat")

                Dim Tfdt, Ttdt As String
                If Trim(TxtCerNo.Text) = "" Then

                Else
                    Tfdt = Mid(Trim(TxtRefAmt.Text), 4, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 1, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 7, 4)
                    Ttdt = Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4)
                    dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                    '''Txtbpay.Text = Format(Round(TxtCerNo.Text * Val(pay2) / 100, 2), "#,###,###.##")
                    '''Txtrcc.Text = Format(Round(TxtCerNo.Text * Val(pay3) / 100, 2), "#,###,###.##")
                    '''Txttr.Text = Format(Round(TxtCerNo.Text * Val(pay5) / 100, 2), "#,###,###.##")
                    '''TxtPPre.Text = Format(pay1, "###,###.##")
                    '''Lbldys.Text = dtdiff - 1

                    Dim Tpay As Double
                    pay1 = pay1 / 365 * (dtdiff - 1)
                    Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1

                    '''TxtTpay.Text = Format(Round(Tpay, 2), "###,###,##")
                    '''TxtDed.Text = Format((TxtTpay.Text - TxtPPre.Text) * 2 / 100, "###,###.##")
                End If

            Next

        End If
    End Sub

    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function



    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.TextChanged
        idno = Trim(TxtId.Text)


        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & idno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")

        Count = DS.Tables("VEHMAST").Rows.Count
        Dim dr1, dr2 As DataRow
        Dim pppp As String

        If Count <> 0 Then

            LbLMsg.Text = "Record Already Exist !"

            For Each dr1 In DS.Tables("VEHMAST").Rows

                ' LstCom.SelectedValue = dr1("Veh_Com")
                Lsttyp.SelectedValue = dr1("Veh_Typ")

                Dim dt1, dt2, dt3 As String
                dt1 = Format(Day(CDate(dr1("Veh_Efdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Efdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Efdt")))

                TxtRefAmt.Text = dt2 + "/" + dt1 + "/" + dt3

                dt1 = Format(Day(CDate(dr1("Veh_Exdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Exdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Exdt")))

                TxtSldDt.Text = dt2 + "/" + dt1 + "/" + dt3
                Dim dtdiff As Integer

                Typ = dr1("Veh_Typ")
                TxtCerNo.Text = dr1("Veh_Val")
                TxtCerNo.Enabled = False
                TxtSldDt.Enabled = False
                TxtRefAmt.Enabled = False

                ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & Typ & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "VEHTYPMAST")

                Count = DS.Tables("VEHTYPMAST").Rows.Count

                If Count <> 0 Then
                    For Each dr2 In DS.Tables("VEHTYPMAST").Rows

                        pay1 = dr2("Veh_tp_tppd")
                        pay2 = dr2("Veh_B_ Primum")
                        pay3 = dr2("Veh_Rcc")
                        pay4 = dr2("Veh_Rcc")
                        pay5 = dr2("Veh_Tr")
                        pay6 = dr2("Veh_vat")

                        Dim Tfdt, Ttdt As String
                        If Trim(TxtCerNo.Text) = "" Then

                        Else
                            LbLMsg.Text = "                       "

                            Tfdt = Mid(Trim(TxtRefAmt.Text), 4, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 1, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 7, 4)
                            Ttdt = Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4)
                            dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                            '''Txtbpay.Text = Format(Round(TxtCerNo.Text * Val(pay2) / 100, 2), "#,###,###.##")
                            '''Txtrcc.Text = Format(Round(TxtCerNo.Text * Val(pay3) / 100, 2), "#,###,###.##")
                            '''Txttr.Text = Format(Round(TxtCerNo.Text * Val(pay5) / 100, 2), "#,###,###.##")
                            '''TxtPPre.Text = Format(pay1, "###,###.##")
                            '''Lbldys.Text = dtdiff - 1

                            Dim Tpay As Double
                            pay1 = pay1 / 365 * (dtdiff - 1)
                            Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1


                            '''TxtTpay.Text = Format(Round(Tpay, 2), "###,###,##")
                            '''TxtDed.Text = Format((TxtTpay.Text - TxtPPre.Text) * 2 / 100, "###,###.##")
                        End If

                    Next

                End If

                'Txtbpay.Text = dr1("Emp_TaLv")
                'TxtCerNo.Text = dr1("Emp_CntNo")
                'Txtrcc.Text = dr1("Emp_email")
                'Txttr.Text = dr1("Emp_des")
            Next

            Exit Sub

        Else
            '''Txtbpay.Text = ""
            '''Txtrcc.Text = ""
            '''Txttr.Text = ""
            '''TxtPPre.Text = ""

            TxtCerNo.Text = ""

            TxtRefAmt.Text = ""
            TxtSldDt.Text = ""

            'TxtTpay.Text = ""
            TxtCerNo.Enabled = True
            TxtSldDt.Enabled = True
            TxtRefAmt.Enabled = True
            'TxtPPre.Enabled = True

        End If

    End Sub

    Private Sub TxtPPre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dtdiff As Integer

        Typ = Trim(Lsttyp.SelectedValue)
        pos1 = "Y"

        ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & Typ & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHTYPMAST")

        Count = DS.Tables("VEHTYPMAST").Rows.Count
        Dim dr1 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            For Each dr1 In DS.Tables("VEHTYPMAST").Rows


                pay1 = dr1("Veh_tp_tppd")
                pay2 = dr1("Veh_B_ Primum")
                pay3 = dr1("Veh_Rcc")
                pay4 = dr1("Veh_Rcc")
                pay5 = dr1("Veh_Tr")
                pay6 = dr1("Veh_vat")

                Dim Tfdt, Ttdt As String

                Tfdt = Mid(Trim(TxtRefAmt.Text), 4, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 1, 2) + "/" + Mid(Trim(TxtRefAmt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtSldDt.Text), 4, 2) + "/" + Mid(Trim(TxtSldDt.Text), 1, 2) + "/" + Mid(Trim(TxtSldDt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                '''Txtbpay.Text = Format(Round(TxtCerNo.Text * Val(pay2) / 100, 2), "#,###,###.##")
                '''Txtrcc.Text = Format(Round(TxtCerNo.Text * Val(pay3) / 100, 2), "#,###,###.##")
                '''Txttr.Text = Format(Round(TxtCerNo.Text * Val(pay5) / 100, 2), "#,###,###.##")
                '''TxtPPre.Text = Format(pay1, "###,###.##")
                '''Lbldys.Text = dtdiff - 1

                Dim Tpay As Double
                pay1 = pay1 / 365 * (dtdiff - 1)
                Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1

                '''TxtTpay.Text = Format(Round(Tpay, 2), "###,###,##")
                '''TxtDed.Text = Format((TxtTpay.Text - TxtPPre.Text) * 2 / 100, "###,###.##")
            Next

        End If
    End Sub


    Private Sub TxtSldDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSldDt.TextChanged

        Ttdt = (Mid(TxtSldDt.Text, 4, 2) + "/" + Mid(TxtSldDt.Text, 1, 2) + "/" + Mid(TxtSldDt.Text, 7, 4))

        dtdiff1 = DateDiff(DateInterval.Day, CDate(Mid(Txtfdt.Text, 4, 2) + "/" + Mid(Txtfdt.Text, 1, 2) + "/" + Mid(Txtfdt.Text, 7, 4)), CDate(Ttdt))
        TxtRefAmt.Text = Format(Val(TxtTotAmt1.Text) / Val(Txtdays.Text) * dtdiff1, "######.00")
        TxtNo.Text = dtdiff1

        SS = Format((Val(TxtTotAmt1.Text) - (Val(TxtTotAmt1.Text) / Val(Txtdays.Text) * dtdiff1)), "######.00")
        SS = Format((Val(TxtTotAmt1.Text) / Val(Txtdays.Text) * dtdiff1), "######.00")
        TxtRefAmt.Text = Right(Space(20) + Format((Val(TxtTotAmt1.Text) - (Val(TxtTotAmt1.Text) / Val(Txtdays.Text) * dtdiff1)), "######.00"), 20)

        TxtbalAmt.Text = Right(Space(20) + Format((Val(TxtTotAmt1.Text) / Val(Txtdays.Text) * dtdiff1), "######.00"), 20)



        'TxtSldDt.Text = IIf(IsDBNull(dr1("Veh_recdt")), " ", dr1("Veh_recdt"))
    End Sub

    Private Sub TxtRefAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRefAmt.TextChanged

    End Sub
End Class
