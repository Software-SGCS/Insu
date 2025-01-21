Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail


Public Class Entry2
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
    Dim Count As Integer
    Dim drt2, drt3 As DataRow
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents LbLMsg As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtRecDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCerNo As System.Web.UI.WebControls.TextBox
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

                COUNT2 = drt2("User_lvl")
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
                PFLAG = "Y"
            End While

            DR.Close()

        End If


        If PFLAG = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else

            Response.Redirect("POSDispaly11.aspx")
        End If

        BtnApp.Enabled = True
        BtnDel.Visible = False

        If Not IsPostBack Then
            LstId.Enabled = False
            LstCom.Enabled = True
            Lsttyp.Enabled = False
            TxtChqNo.Enabled = False
            TxtRecDt.Enabled = False
            TxtCerNo.Enabled = False


            TxtChqNo.Text = " "
            TxtRecDt.Text = " "
            TxtCerNo.Text = " "



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

            'TxtChqNo.Enabled = False
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
            '  Img1.Visible = True
            'Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            'Img2.Visible = True
            'Img2.ImageUrl = V2
        End If







        CON.Close()

        LstId.Enabled = True
        Lsttyp.Enabled = True
        'TxtChqNo.Enabled = True
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
        TxtChqNo.Enabled = True
        TxtRecDt.Enabled = True
        TxtCerNo.Enabled = True


        TxtChqNo.Text = ""
        TxtRecDt.Text = ""
        TxtCerNo.Text = ""



        LstCom.Enabled = True

        BtnEdit.Enabled = False
        TxtId.Text = ("")

        'TxtChqNo.Text = ("")
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
        'TxtChqNo.Enabled = True
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
        'TxtChqNo.Text = ("")
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
        BtnApp.Enabled = True

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

                Dim dtdiff As Integer

                Typ = dr1("Veh_Typ")
                TxtChqNo.Text = IIf(IsDBNull(dr1("Veh_ChqNo")), " ", dr1("Veh_ChqNo"))

                '  SS = dr1("Veh_recdt")
                ' SS = Format(CDate(Today()), "dd/MM/yyyy")
                'SS = Format(CDate(dr1("Veh_recdt")), "dd/MM/yyyy")
                Try
                    dt1 = Format(CDate(dr1("Veh_recdt")), "dd/MM/yyyy")
                Catch ex As Exception
                    dt1 = Format(CDate(Today()), "dd/MM/yyyy")
                End Try


                'dt1 = Format(Day(CDate(IIf(IsDBNull(dr1("Veh_recdt")), "00", dr1("Veh_recdt")))), "00")
                ' dt2 = Format(Month(CDate(IIf(IsDBNull(dr1("Veh_recdt")), "00", dr1("Veh_recdt")))), "00")
                'dt3 = Year(CDate(IIf(IsDBNull(dr1("Veh_recdt")), "1900", dr1("Veh_recdt"))))

                'TxtRecDt.Text = dt1 + "/" + dt2 + "/" + dt3
                TxtRecDt.Text = Trim(dt1)

                'TxtRecDt.Text = IIf(IsDBNull(dr1("Veh_recdt")), " ", dr1("Veh_recdt"))


                TxtCerNo.Text = IIf(IsDBNull(dr1("Veh_CertifyNo")), " ", dr1("Veh_CertifyNo"))

                TxtChqNo.Enabled = True
                TxtRecDt.Enabled = True
                TxtCerNo.Enabled = True

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
                            ' Tfdt = Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                            ' Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
                            ' dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))



                            Dim Tpay As Double
                            'pay1 = pay1 / 365 * (dtdiff - 1)
                            'Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1



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
            LbLMsg.Text = "Record Not Found !"





            TxtCerNo.Text = ""

            TxtChqNo.Text = ""
            TxtRecDt.Text = ""


            TxtCerNo.Enabled = False
            TxtRecDt.Enabled = False
            TxtChqNo.Enabled = False


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




        CMD = New SqlCommand("SELECT Veh_no FROM VehMast where veh_no<>'' and veh_com='" & Trim(COM) & "'", CON)

        DR = CMD.ExecuteReader
        LstId.Items.Clear()

        'If Not IsPostBack Then


        While DR.Read
            'TT = DR.GetValue(0)
            LstId.Items.Add(DR.GetValue(0))
        End While
        'End If
        DR.Close()

        IDNO = Trim(LstId.SelectedValue)


        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & IDNO & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")

        Count = DS.Tables("VEHMAST").Rows.Count
        Dim dr2 As DataRow
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

                TxtChqNo.Text = dt1 + "/" + dt2 + "/" + dt3

                dt1 = Format(Day(CDate(dr1("Veh_Exdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Exdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Exdt")))

                TxtRecDt.Text = dt1 + "/" + dt2 + "/" + dt3
                Dim dtdiff As Integer

                Typ = dr1("Veh_Typ")
                TxtCerNo.Text = dr1("Veh_Val")
                TxtCerNo.Enabled = True
                TxtRecDt.Enabled = True
                TxtChqNo.Enabled = True

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

                            Tfdt = Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                            Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
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

            TxtChqNo.Text = ""
            TxtRecDt.Text = ""

            'TxtTpay.Text = ""
            TxtCerNo.Enabled = True
            TxtRecDt.Enabled = True
            TxtChqNo.Enabled = True
            'TxtPPre.Enabled = True

        End If



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



        If BtnAdd.Enabled = False Then

            ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & IDNO & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "VEHMAST")
            IDNO = LstId.SelectedValue
            COM = Mid(LstCom.SelectedValue, 1, 3)
            typ = Lsttyp.SelectedValue
            Count = DS.Tables("VEHMAST").Rows.Count
            If Count <> 0 Then

                'TxtNam.Text = dr1("Emp_Name")
                'TxtChqNo.Text = dr1("Emp_ToLv")
                'Txtbpay.Text = dr1("Emp_TaLv")
                'TxtCerNo.Text = dr1("Emp_CntNo")
                CMD.Connection = CON
                Dim SS As String
                SS = "UPDATE EMPMAST SET EMP_NAME='" & TxtChqNo.Text & "',EMP_TOLV='" & TxtChqNo.Text & "',EMP_TALV='" & TxtChqNo.Text & "',EMP_CNTNO='" & TxtCerNo.Text & "' WHERE EMP_NO=" & IDNO & " AND EMP_COM='" & COM & "'"


                CMD.CommandText = ("UPDATE VEHMAST SET VEH_CertifyNo='" & TxtCerNo.Text & "',VEH_Chqno='" & TxtChqNo.Text & "',Allow1='Select',VEH_RecDt='" & Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4) & "' WHERE VEH_NO='" & IDNO & "'")
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
                    emailMessage.From = "health@samsoncorporates.com"
                    emailMessage.To = "shakilaw@samsoncorporates.com"
                    'emailMessage.Attachments.Add("c:\RtnTxt.txt")
                    'emailMessage.Cc = str_mail
                    'emailMessage.Bcc = em1
                    emailMessage.Subject = "For Your Approval "

                    emailMessage.Body = "Vehcle No :" + IDNO + " " + COM + " " + typ + "  " + "http://192.168.12.181/Insu/InsuApproval.aspx"
                    ' emailMessage.Body = "http://192.168.12.181/Insu/CrsCertificate.aspx"

                    SmtpMail.SmtpServer = "192.168.40.3"
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

        Else
            ''IDNO = TxtId.Text
            ''COM = Mid(LstCom.SelectedValue, 1, 3)
            ''typ = Lsttyp.SelectedValue
            ''CMD.Connection = CON
            ''Dim SS As String
            ''SS = "INSERT INTO VEHMAST (VEH_NO,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL) VALUES ('" & IDNO & "','" & COM & "','" & typ & "',#" & TxtChqNo.Text & "#,#" & TxtRecDt.Text & "#," & TxtChqNo.Text & "," & TxtChqNo.Text & "," & TxtChqNo.Text & "," & TxtChqNo.Text & "," & TxtChqNo.Text & "," & TxtChqNo.Text & "," & TxtCerNo.Text & ")"
            ''Dim P1, P2, P3, P4, P5, P6, P7 As Double
            '''''P1 = FormatNumber((TxtDed.Text), "0000000.00")
            '''''P2 = FormatNumber((TxtPPre.Text), "0000000.00")
            '''''P3 = FormatNumber((Txtrcc.Text), "0000000.00")
            '''''P4 = FormatNumber((Txtbpay.Text), "0000000.00")
            '''''P5 = FormatNumber((Txttr.Text), "0000000.00")
            '''''P6 = FormatNumber((TxtTpay.Text), "0000000.00")

            ''CMD.CommandText = ("INSERT INTO VEHMAST (VEH_NO,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_PAYDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL) VALUES ('" & IDNO & "','" & COM & "','" & typ & "',#" & TxtChqNo.Text & "#,#" & TxtRecDt.Text & "#,#" & TxtChqNo.Text & "#," & P1 & "," & P2 & "," & P3 & "," & P4 & "," & P5 & "," & P6 & "," & TxtCerNo.Text & ")")
            ''CMD.ExecuteNonQuery()
        End If

        BtnApp.Enabled = False
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

                Tfdt = Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))




                Dim Tpay As Double
                pay1 = pay1 / 365 * (dtdiff - 1)
                Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1




            Next

        End If

    End Sub

    Private Sub Lsttyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsttyp.SelectedIndexChanged

        '  If pos1 = "Y" Then



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
                If Trim(TxtChqNo.Text) = "" Or Trim(TxtRecDt.Text) = "" Then

                Else
                    Tfdt = Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                    Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
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

            'TxtRecDt.Text = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtChqNo.Text, 4, 2) + "/" + Mid((TxtChqNo.Text), 1, 2) + "/" + Mid((TxtChqNo.Text), 7, 4))))
            dt = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtChqNo.Text, 4, 2) + "/" + Mid((TxtChqNo.Text), 1, 2) + "/" + Mid((TxtChqNo.Text), 7, 4))))

            dt1 = Format(Day(dt), "00")
            dt2 = Format(Month(dt), "00")
            dt3 = Year(dt)


            ppp = dt1 + "/" + dt2 + "/" + dt3

            TxtRecDt.Text = ppp

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
                    Tfdt = Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                    Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
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

                TxtChqNo.Text = dt1 + "/" + dt2 + "/" + dt3

                dt1 = Format(Day(CDate(dr1("Veh_Exdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Exdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Exdt")))

                TxtRecDt.Text = dt1 + "/" + dt2 + "/" + dt3
                Dim dtdiff As Integer

                Typ = dr1("Veh_Typ")
                TxtCerNo.Text = dr1("Veh_Val")
                TxtCerNo.Enabled = False
                TxtRecDt.Enabled = False
                TxtChqNo.Enabled = False

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

                            Tfdt = Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                            Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
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

            TxtChqNo.Text = ""
            TxtRecDt.Text = ""

            'TxtTpay.Text = ""
            TxtCerNo.Enabled = True
            TxtRecDt.Enabled = True
            TxtChqNo.Enabled = True
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

                Tfdt = Mid(Trim(TxtChqNo.Text), 1, 2) + "/" + Mid(Trim(TxtChqNo.Text), 4, 2) + "/" + Mid(Trim(TxtChqNo.Text), 7, 4)
                Ttdt = Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
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


End Class
