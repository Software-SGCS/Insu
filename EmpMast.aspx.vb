
Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class EmpMast
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
    Public ppp, ppp1 As String
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    Dim val1 As Double
    Dim drt2, drt3 As DataRow
    Dim dt As Date
    Dim dtt As Date
    Dim TEXT1, TEXT2, TEXT3 As String

    Dim dt1, dt11 As String
    Dim dt2, dt21 As String
    Dim dt3, dt31 As String
    'Dim pos1 As String
    Public pos1 As String
    Dim Temp1, Temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9 As String
    Dim Teamt As Double
    Dim Typ As String
    Dim Count As Integer
    Dim Tfdt, Ttdt As String
    Dim dtdiff As Integer
    Dim SS As String

    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Txtrcc As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txttr As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtval As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtbpay As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtpayfdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtPPre As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTpay As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents LbLMsg As System.Web.UI.WebControls.Label
    Protected WithEvents Img1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Img2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Lbldys As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtDed As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTotChqPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPer As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label26 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtpayTdt As System.Web.UI.WebControls.TextBox
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
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
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

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim PFlag, pSEC As String
        Dim COUNT1, COUNT2 As Integer

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
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EmpMast.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EmpMast.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EmpMast.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='EmpMast.aspx' and Form_level5='1'", CON)

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
            BtnApp.Enabled = False


            LstId.Enabled = False
            LstCom.Enabled = True



            Lsttyp.Enabled = False
            Txtpayfdt.Enabled = False
            TxtpayTdt.Enabled = False
            Txtval.Enabled = False
            Txtbpay.Enabled = True
            Txtrcc.Enabled = False
            Txttr.Enabled = True
            TxtPPre.Enabled = True
            TxtTpay.Enabled = False

            Txtpayfdt.Text = Format(Today, "dd/MM/yyyy")

            TxtpayTdt.Text = Format(Today, "dd/MM/yyyy")

            Txtval.Text = 0
            Txtbpay.Text = 0
            Txtrcc.Text = 0
            Txttr.Text = 0
            TxtPPre.Text = 0
            TxtTpay.Text = 0


            TxtPer.Text = "02.00"
            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT Veh_no FROM VehMast where veh_no<>'' AND Allow2='Approved' AND SOLD='N' ", CON)

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

            'Txtpayfdt.Enabled = False
            ' Txtbpay.Enabled =TRUE
            'Txtval.Enabled = False


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
            'Img1.Visible = True
            'Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            'Img2.Visible = True
            'Img2.ImageUrl = V2
        End If



        CON.Close()




    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        TxtId.Enabled = True
        TxtId.Visible = True

        LstId.Visible = False
        LstCom.Enabled = True
        Lsttyp.Enabled = True
        Txtpayfdt.Enabled = True
        TxtpayTdt.Enabled = True
        Txtval.Enabled = True
        Txtbpay.Enabled = True
        Txtrcc.Enabled = True
        Txttr.Enabled = True
        TxtPPre.Enabled = True
        TxtTpay.Enabled = True

        Txtpayfdt.Text = Format(Today, "dd/MM/yyyy")

        TxtpayTdt.Text = Format(Today, "dd/MM/yyyy")

        Txtval.Text = 0
        Txtbpay.Text = 0
        Txtrcc.Text = 0
        Txttr.Text = 0
        TxtPPre.Text = 0
        TxtTpay.Text = 0

        LstCom.Enabled = True

        BtnEdit.Enabled = False
        TxtId.Text = ("")
        BtnApp.Enabled = True

        'Txtpayfdt.Text = ("")
        'Txtbpay.Text = ("")
        'Txtval.Text = ("")
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
        BtnApp.Enabled = True
        'Txtpayfdt.Enabled = True
        Txtbpay.Enabled = True
        'Txtval.Enabled = True
        'Txtval.Visible = True

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
        BtnAdd.Enabled = False
    End Sub

    Private Sub BtnCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCle.Click

        If Not IsPostBack Then



            'BtnAdd.Enabled = True
            'BtnApp.Enabled = True
            'BtnDel.Enabled = True

            'BtnAdd.Visible = True
            'BtnEdit.Enabled = True
            'BtnEdit.Visible = True


        End If

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

                TxtPer.Text = Round(dr1("veh_ded") * 100 / dr1("veh_tpay"), 0)
                Dim p1 As Double

                p1 = Round(dr1("veh_ded") * 100 / dr1("veh_tpay"), 0)

                TxtPer.Text = Format(Round(TxtPer.Text, 2), "###.##")

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
                dt1 = Format(Day(CDate(dr1("Veh_Efdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Efdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Efdt")))

                Txtpayfdt.Text = dt1 + "/" + dt2 + "/" + dt3

                dt1 = Format(Day(CDate(dr1("Veh_Exdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Exdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Exdt")))

                TxtpayTdt.Text = dt1 + "/" + dt2 + "/" + dt3

                Typ = dr1("Veh_Typ")
                Txtval.Text = dr1("Veh_Val")
                Txtbpay.Text = dr1("Veh_bpay")


                Txtval.Enabled = True
                TxtpayTdt.Enabled = True
                Txtpayfdt.Enabled = True

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


                        If Trim(Txtval.Text) = "" Then

                        Else
                            Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                            Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                            dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                            Temp1 = Space(25)
                            Temp2 = Space(25)
                            temp3 = Space(25)
                            temp4 = Space(25)
                            temp5 = Space(25)
                            temp6 = Space(25)
                            temp7 = Space(25)
                            temp8 = Space(25)


                            val1 = (Txtval.Text * Val(pay2) / 100)
                            'If val1 < 1000 Then
                            ' val1 = 1000
                            'Else

                            'End If

                            Temp1 = Temp1 + Format((Txtval.Text * Val(pay2) / 100), "###,###,###.##")

                            Temp1 = Right(Temp1, 25)
                            Txtbpay.Text = Temp1

                            Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                            Temp2 = Right(Temp2, 25)
                            Txtrcc.Text = Temp2

                            temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                            temp3 = Right(temp3, 25)
                            Txttr.Text = temp3

                            TxtPPre.Text = Format(pay1, "###,###,###.##")
                            If dtdiff = 366 Then
                                dtdiff = dtdiff - 1
                            Else
                                If dtdiff = 364 Then
                                    dtdiff = dtdiff + 1
                                End If

                            End If
                            Lbldys.Text = dtdiff

                            temp4 = temp4 + Format(pay1, "###,###,###.##")
                            temp4 = Right(temp4, 25)
                            TxtPPre.Text = temp4


                            Dim Tpay As Double
                            'pay1 = pay1 / 365 * (dtdiff )
                            'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                            ' Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100) - pay1)

                            Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))


                            temp5 = temp5 + Format((Tpay), "###,###,###.##")
                            temp5 = Right(temp5, 25)
                            TxtTpay.Text = temp5

                            temp6 = temp6 + Format(((TxtTpay.Text) - (TxtPPre.Text)) * Val(TxtPer.Text) / 100, "###,###,###.##")
                            temp6 = Right(temp6, 25)
                            TxtDed.Text = temp6




                            If Trim(TxtDed.Text) = "" Then
                                temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                            Else
                                temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round((TxtPPre.Text), 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                            End If
                            If Trim(TxtDed.Text) = "" Then
                                TxtDed.Text = "0"
                            End If


                            temp7 = Right(temp7, 25)
                            TxtTotChqPay.Text = temp7

                            temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                            temp8 = Right(temp8, 25)
                            Txtval.Text = temp8



                        End If

                    Next

                End If

                'Txtbpay.Text = dr1("Emp_TaLv")
                'Txtval.Text = dr1("Emp_CntNo")
                'Txtrcc.Text = dr1("Emp_email")
                'Txttr.Text = dr1("Emp_des")
            Next

            Exit Sub

        Else
            LbLMsg.Text = "Record Not Found !"



            Txtpayfdt.Text = Format(Today, "dd/MM/yyyy")

            TxtpayTdt.Text = Format(Today, "dd/MM/yyyy")

            Txtval.Text = 0
            Txtbpay.Text = 0
            Txtrcc.Text = 0
            Txttr.Text = 0
            TxtPPre.Text = 0
            TxtTpay.Text = 0

            Txtval.Enabled = False
            TxtpayTdt.Enabled = False
            Txtpayfdt.Enabled = False


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
        'Txtpayfdt.Text = dr1("Emp_ToLv")
        'Txtbpay.Text = dr1("Emp_TaLv")
        'Txtval.Text = dr1("Emp_CntNo")
        'Txtrcc.Text = dr1("Emp_email")
        'Txttr.Text = dr1("Emp_des")
        '    Next
        'Else
        'TxtNam.Text = ("")
        ' Txtpayfdt.Text = ("")
        'Txtbpay.Text = ("")
        'Txtval.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")

        'End If

        ' Else

        'IDNO = Mid(Trim(TxtId.Text), 1, 4)
        'COM = Mid(Trim(LstCom.SelectedValue), 1, 3)
        'TxtNam.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")
        'Txtval.Text = ("")
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
        Dim P1, P2, P3, P4, P5, P6, P7, P8, P9 As Double

        IDNO = LstId.SelectedValue
        COM = Mid(Trim(LstCom.SelectedValue), 1, 3)

        CMD = New SqlCommand("SELECT * FROM vehtypmast", CON)
        DR = CMD.ExecuteReader
        DR.Close()

        If BtnAdd.Enabled = False Then
            TEXT1 = Txtpayfdt.Text
            TEXT2 = TxtpayTdt.Text
            TEXT2 = ppp1

            dtt = DateAdd(DateInterval.Day, -1, CDate(Mid(Txtpayfdt.Text, 4, 2) + "/" + Mid((Txtpayfdt.Text), 1, 2) + "/" + Mid((Txtpayfdt.Text), 7, 4)))
            dt11 = Format(Day(dtt), "00")
            dt21 = Format(Month(dtt), "00")
            dt31 = Year(dtt)

            ppp = dt1 + "/" + dt2 + "/" + dt3
            ppp1 = dt11 + "/" + dt21 + "/" + dt31

            TEXT2 = ppp1

            ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & IDNO & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "VEHMAST")
            IDNO = LstId.SelectedValue
            COM = Mid(LstCom.SelectedValue, 1, 3)
            typ = Lsttyp.SelectedValue
            Count = DS.Tables("VEHMAST").Rows.Count
            If Count <> 0 Then

                'TxtNam.Text = dr1("Emp_Name")
                'Txtpayfdt.Text = dr1("Emp_ToLv")
                'Txtbpay.Text = dr1("Emp_TaLv")
                'Txtval.Text = dr1("Emp_CntNo")
                CMD.Connection = CON
                Dim SS As String
                P2 = FormatNumber((TxtPPre.Text), "0000000.00")

                P3 = FormatNumber((Txtrcc.Text), "0000000.00")
                P4 = FormatNumber((Txtbpay.Text), "0000000.00")
                P5 = FormatNumber((Txttr.Text), "0000000.00")
                P6 = FormatNumber((TxtTpay.Text), "0000000.00")
                P7 = FormatNumber((Txtval.Text), "0000000.00")
                P8 = FormatNumber((TxtTotChqPay.Text), "0000000.00")
                P9 = FormatNumber((TxtDed.Text), "0000000.00")

                SS = "UPDATE VEHMAST SET VEH_COM='" & COM & "',VEH_TYP='" & typ & "',VEH_EFDT='" & Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4) & "',VEH_PayDT='" & Mid(Trim(ppp1), 4, 2) + "/" + Mid(Trim(ppp1), 1, 2) + "/" + Mid(Trim(ppp1), 7, 4) & "',VEH_VAL='" & Txtval.Text & "',Veh_TotChqPay='" & TxtTotChqPay.Text & "',VEH_DED='" & TxtDed.Text & "',VEH_rcc='" & Txtrcc.Text & "',VEH_Ppre='" & TxtPPre.Text & "',VEH_bpay='" & Txtbpay.Text & "',VEH_tr='" & Txttr.Text & "',VEH_Tpay='" & TxtTpay.Text & "',VEH_EXDT='" & Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4) & "' WHERE VEH_NO='" & IDNO & "'"
                ss = "UPDATE VEHMAST SET VEH_COM='" & COM & "',VEH_TYP='" & typ & "',VEH_EFDT='" & Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4) & "',VEH_PayDT='" & Mid(Trim(ppp1), 4, 2) + "/" + Mid(Trim(ppp1), 1, 2) + "/" + Mid(Trim(ppp1), 7, 4) & "',VEH_VAL=" & P7 & ",Veh_TotChqPay=" & P8 & ",VEH_DED=" & P9 & ",VEH_rcc=" & P3 & ",VEH_Ppre=" & P2 & ",VEH_bpay=" & P4 & ",VEH_tr=" & P5 & ",VEH_Tpay=" & P6 & ",VEH_EXDT='" & Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4) & "' WHERE VEH_NO='" & IDNO & "'"
                CMD.CommandText = (SS)
                CMD.ExecuteNonQuery()
            End If


        Else
            IDNO = TxtId.Text
            COM = Mid(LstCom.SelectedValue, 1, 3)
            typ = Lsttyp.SelectedValue
            CMD.Connection = CON
            Dim SS As String
            'SS = "INSERT INTO VEHMAST (VEH_NO,ALLOW2,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_PAYDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL,Veh_TotChqPay) VALUES ('" & IDNO & "','Select','" & COM & "','" & typ & "',#" & Txtpayfdt.Text & "#,#" & TxtpayTdt.Text & "#,#" & Txtpayfdt.Text & "#," & P1 & "," & P2 & "," & P3 & "," & P4 & "," & P5 & "," & P6 & "," & P7 & "," & P8 & ")"

            If IsNumeric(TxtDed.Text) = False Then
                P1 = 0
            Else
                P1 = FormatNumber((TxtDed.Text), "0000000.00")
            End If

            P2 = FormatNumber((TxtPPre.Text), "0000000.00")
            P3 = FormatNumber((Txtrcc.Text), "0000000.00")
            P4 = FormatNumber((Txtbpay.Text), "0000000.00")
            P5 = FormatNumber((Txttr.Text), "0000000.00")
            P6 = FormatNumber((TxtTpay.Text), "0000000.00")
            P7 = FormatNumber((Txtval.Text), "0000000.00")
            P8 = FormatNumber((TxtTotChqPay.Text), "0000000.00")

            TEXT1 = Txtpayfdt.Text
            TEXT2 = TxtpayTdt.Text
            TEXT2 = ppp1

            dtt = DateAdd(DateInterval.Day, -1, CDate(Mid(Txtpayfdt.Text, 4, 2) + "/" + Mid((Txtpayfdt.Text), 1, 2) + "/" + Mid((Txtpayfdt.Text), 7, 4)))
            dt11 = Format(Day(dtt), "00")
            dt21 = Format(Month(dtt), "00")
            dt31 = Year(dtt)

            ppp = dt1 + "/" + dt2 + "/" + dt3
            ppp1 = dt11 + "/" + dt21 + "/" + dt31

            TEXT2 = ppp1

            SS = "INSERT INTO VEHMAST (VEH_NO,ALLOW2,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_PAYDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL,Veh_TotChqPay) VALUES ('" & IDNO & "','Select','" & COM & "','" & typ & "','" & Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4) & "','" & Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4) & "','" & Mid(Trim(ppp1), 4, 2) + "/" + Mid(Trim(ppp1), 1, 2) + "/" + Mid(Trim(ppp1), 7, 4) & "'," & P1 & "," & P2 & "," & P3 & "," & P4 & "," & P5 & "," & P6 & "," & P7 & "," & P8 & ")"

            CMD.CommandText = ("INSERT INTO VEHMAST (VEH_NO,ALLOW2,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_PAYDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL,Veh_TotChqPay,sOLD) VALUES ('" & IDNO & "','Select','" & COM & "','" & typ & "','" & Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4) & "','" & Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4) & "','" & Mid(Trim(ppp1), 4, 2) + "/" + Mid(Trim(ppp1), 1, 2) + "/" + Mid(Trim(ppp1), 7, 4) & "'," & P1 & "," & P2 & "," & P3 & "," & P4 & "," & P5 & "," & P6 & "," & P7 & "," & P8 & ",'N')")
            CMD.ExecuteNonQuery()

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
            'If Count <> 0 Then

            ' For Each dr1 In DS.Tables("Admin").Rows
            ' Ename = dr1("Ad_Nam")
            ' Temail = dr1("Ad_email")

            '   Next
            Dim ss1 As String
            Dim ln As Integer

            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "shakilaw@samsoncorporates.com"
            emailMessage.To = "udanip@samsoncorporates.com"
            ''emailMessage.To = "palithan@samsoncorporates.com"
            emailMessage.Subject = "For Your Approval for Payment Notice "

            emailMessage.Body = "Vehcle No :" + IDNO + " " + COM + " " + typ + "  " + "http://192.168.12.165/Insu/PayApprovalNew.aspx"

            SmtpMail.SmtpServer = "mail.dsisamson.com"
            Try
                SmtpMail.Send(emailMessage)

            Catch ex As Exception

            End Try

            'End If
        End If
        BtnApp.Enabled = False
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
        LstId.Enabled = False
        TxtId.Enabled = False
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

    Private Sub Txtval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtval.TextChanged


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



                Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                Temp1 = Space(25)
                Temp2 = Space(25)
                temp3 = Space(25)
                temp4 = Space(25)
                temp5 = Space(25)
                temp6 = Space(25)
                temp7 = Space(25)
                temp8 = Space(25)


                val1 = (Txtval.Text * Val(pay2) / 100)
                'If val1 < 1000 Then
                ' val1 = 1000
                'Else

                'End If

                Temp1 = Temp1 + Format((Txtval.Text * Val(pay2) / 100), "###,###,###.##")

                Temp1 = Right(Temp1, 25)
                Txtbpay.Text = Temp1

                Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                Temp2 = Right(Temp2, 25)
                Txtrcc.Text = Temp2

                temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                temp3 = Right(temp3, 25)
                Txttr.Text = temp3

                TxtPPre.Text = Format(pay1, "###,###,###.##")
                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If

                End If
                Lbldys.Text = dtdiff

                temp4 = temp4 + Format(pay1, "###,###,###.##")
                temp4 = Right(temp4, 25)
                TxtPPre.Text = temp4


                Dim Tpay As Double
                'pay1 = pay1 / 365 * (dtdiff )
                'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                ' Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100) - pay1)


                Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))

                temp5 = temp5 + Format((Tpay), "###,###,###.##")
                temp5 = Right(temp5, 25)
                TxtTpay.Text = temp5

                temp6 = temp6 + Format((TxtTpay.Text) * Val(TxtPer.Text) / 100, "###,###,###.##")
                temp6 = Right(temp6, 25)
                TxtDed.Text = temp6


                If Trim(TxtDed.Text) = "" Then
                    temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                Else
                    temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                End If
                If Trim(TxtDed.Text) = "" Then
                    TxtDed.Text = "0"
                End If





                temp7 = Right(temp7, 25)
                TxtTotChqPay.Text = temp7

                temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                temp8 = Right(temp8, 25)
                Txtval.Text = temp8


            Next

        End If

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
                If Trim(Txtpayfdt.Text) = "" Or Trim(TxtpayTdt.Text) = "" Then

                Else

                    If Txtval.Text = " " Or Val(Txtval.Text) = 0 Then
                    Else
                        Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                        Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                        dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                        Temp1 = Space(25)
                        Temp2 = Space(25)
                        temp3 = Space(25)
                        temp4 = Space(25)
                        temp5 = Space(25)
                        temp6 = Space(25)
                        temp7 = Space(25)
                        temp8 = Space(25)


                        val1 = (Txtval.Text * Val(pay2) / 100)
                        If val1 < 1000 Then
                            val1 = 1000
                        Else

                        End If
                        Temp1 = Temp1 + Format((val1), "###,###,###.##")

                        Temp1 = Right(Temp1, 25)
                        Txtbpay.Text = Temp1

                        Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                        Temp2 = Right(Temp2, 25)
                        Txtrcc.Text = Temp2

                        temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                        temp3 = Right(temp3, 25)
                        Txttr.Text = temp3

                        TxtPPre.Text = Format(pay1, "###,###,###.##")
                        If dtdiff = 366 Then
                            dtdiff = dtdiff - 1
                        Else
                            If dtdiff = 364 Then
                                dtdiff = dtdiff + 1
                            End If

                        End If
                        Lbldys.Text = dtdiff

                        temp4 = temp4 + Format(pay1, "###,###,###.##")
                        temp4 = Right(temp4, 25)
                        TxtPPre.Text = temp4


                        Dim Tpay As Double
                        'pay1 = pay1 / 365 * (dtdiff )
                        'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                        Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100) - pay1)




                        temp5 = temp5 + Format((Tpay), "###,###,###.##")
                        temp5 = Right(temp5, 25)
                        TxtTpay.Text = temp5

                        temp6 = temp6 + Format((TxtTpay.Text) * Val(TxtPer.Text) / 100, "###,###,###.##")
                        temp6 = Right(temp6, 25)
                        TxtDed.Text = temp6


                        If Trim(TxtDed.Text) = "" Then
                            temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                        Else
                            temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                        End If
                        If Trim(TxtDed.Text) = "" Then
                            TxtDed.Text = "0"
                        End If




                        temp7 = Right(temp7, 25)
                        TxtTotChqPay.Text = temp7

                        temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                        temp8 = Right(temp8, 25)
                        Txtval.Text = temp8

                    End If

                End If

            Next

        End If
        '  End If
    End Sub

    Private Sub Txtbpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbpay.TextChanged


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



                Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                Temp1 = Space(25)
                Temp2 = Space(25)
                temp3 = Space(25)
                temp4 = Space(25)
                temp5 = Space(25)
                temp6 = Space(25)
                temp7 = Space(25)
                temp8 = Space(25)


                'val1 = (Txtval.Text * Val(pay2) / 100)
                'If val1 < 1000 Then
                'val1 = 1000
                'Else

                'End If
                val1 = Txtbpay.Text
                Temp1 = Temp1 + Format((val1), "###,###,###.##")

                Temp1 = Right(Temp1, 25)
                Txtbpay.Text = Temp1

                Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                Temp2 = Right(Temp2, 25)
                Txtrcc.Text = Temp2

                temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                temp3 = Right(temp3, 25)
                Txttr.Text = temp3

                TxtPPre.Text = Format(pay1, "###,###,###.##")
                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If

                End If
                Lbldys.Text = dtdiff

                temp4 = temp4 + Format(pay1, "###,###,###.##")
                temp4 = Right(temp4, 25)
                TxtPPre.Text = temp4


                Dim Tpay As Double
                'pay1 = pay1 / 365 * (dtdiff )
                'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))




                temp5 = temp5 + Format((Tpay), "###,###,###.##")
                temp5 = Right(temp5, 25)
                TxtTpay.Text = temp5

                temp6 = temp6 + Format(((TxtTpay.Text) - (TxtPPre.Text)) * Val(TxtPer.Text) / 100, "###,###,###.##")
                temp6 = Right(temp6, 25)
                TxtDed.Text = temp6


                If Trim(TxtDed.Text) = "" Then
                    temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                Else
                    temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round((TxtPPre.Text), 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                End If
                If Trim(TxtDed.Text) = "" Then
                    TxtDed.Text = "0"
                End If



                temp7 = Right(temp7, 25)
                TxtTotChqPay.Text = temp7

                temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                temp8 = Right(temp8, 25)
                Txtval.Text = temp8


            Next

        End If
    End Sub

    Private Sub Txtpayfdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpayfdt.TextChanged


        ' If IsPostBack Then

        TxtpayTdt.Text = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(Txtpayfdt.Text, 4, 2) + "/" + Mid((Txtpayfdt.Text), 1, 2) + "/" + Mid((Txtpayfdt.Text), 7, 4))))
        dt = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(Txtpayfdt.Text, 4, 2) + "/" + Mid((Txtpayfdt.Text), 1, 2) + "/" + Mid((Txtpayfdt.Text), 7, 4))))
        '--
        SS = Format(dt, "MM/dd/yyyy")
        '---
        dt = DateAdd(DateInterval.Day, -2, CDate(SS))
        'If Val(Mid(Txtpayfdt.Text, 4, 2)) < 10 Then
        '    If Val(Mid(Txtpayfdt.Text, 1, 2)) < 10 Then
        '        dt = DateAdd(DateInterval.Day, -2, CDate(Mid(dt, 1, 1) + "/" + Mid((dt), 3, 2) + "/" + Mid((dt), 5, 4)))
        '    Else
        '        dt = DateAdd(DateInterval.Day, -2, CDate(Mid(dt, 1, 1) + "/" + Mid((dt), 3, 2) + "/" + Mid((dt), 6, 4)))
        '    End If


        'Else
        '    If Val(Mid(Txtpayfdt.Text, 1, 2)) < 10 Then
        '        dt = DateAdd(DateInterval.Day, -2, CDate(Mid(dt, 1, 2) + "/" + Mid((dt), 4, 1) + "/" + Mid((dt), 6, 4)))
        '    Else
        '        dt = DateAdd(DateInterval.Day, -2, CDate(Mid(dt, 1, 2) + "/" + Mid((dt), 4, 2) + "/" + Mid((dt), 7, 4)))
        '    End If


        'End If
        dt1 = Format(Day(dt), "00")
        dt2 = Format(Month(dt), "00")
        dt3 = Format(Year(dt), "0000")

        dtt = DateAdd(DateInterval.Day, -1, CDate(Mid(Txtpayfdt.Text, 4, 2) + "/" + Mid((Txtpayfdt.Text), 1, 2) + "/" + Mid((Txtpayfdt.Text), 7, 4)))
        dt11 = Format(Day(dtt), "00")
        dt21 = Format(Month(dtt), "00")
        dt31 = Format(Year(dtt), "0000")

        ppp = dt1 + "/" + dt2 + "/" + dt3
        ppp1 = dt11 + "/" + dt21 + "/" + dt31


        TxtpayTdt.Text = ppp

        'End If
    End Sub

    Private Sub TxtpayTdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtpayTdt.TextChanged

        If IsPostBack Then
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


                    If Trim(Txtval.Text) = "" Then

                    Else
                        Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                        Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                        dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                        Temp1 = Space(25)
                        Temp2 = Space(25)
                        temp3 = Space(25)
                        temp4 = Space(25)
                        temp5 = Space(25)
                        temp6 = Space(25)
                        temp7 = Space(25)
                        temp8 = Space(25)



                        val1 = (Txtval.Text * Val(pay2) / 100)
                        If val1 < 1000 Then
                            val1 = 1000
                        Else
                            val1 = (Txtval.Text * Val(pay2) / 100)
                        End If
                        Temp1 = Temp1 + Format((val1), "###,###,###.##")

                        Temp1 = Right(Temp1, 25)
                        Txtbpay.Text = Temp1

                        Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                        Temp2 = Right(Temp2, 25)
                        Txtrcc.Text = Temp2

                        temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                        temp3 = Right(temp3, 25)
                        Txttr.Text = temp3

                        TxtPPre.Text = Format(pay1, "###,###,###.##")
                        If dtdiff = 366 Then
                            dtdiff = dtdiff - 1
                        Else
                            If dtdiff = 364 Then
                                dtdiff = dtdiff + 1
                            End If

                        End If
                        Lbldys.Text = dtdiff

                        temp4 = temp4 + Format(pay1, "###,###,###.##")
                        temp4 = Right(temp4, 25)
                        TxtPPre.Text = temp4


                        Dim Tpay As Double
                        'pay1 = pay1 / 365 * (dtdiff )
                        'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                        Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))




                        temp5 = temp5 + Format((Tpay), "###,###,###.##")
                        temp5 = Right(temp5, 25)
                        TxtTpay.Text = temp5

                        temp6 = temp6 + Format(((TxtTpay.Text) - (TxtPPre.Text)) * Val(TxtPer.Text) / 100, "###,###,###.##")
                        temp6 = Right(temp6, 25)
                        TxtDed.Text = temp6


                        If Trim(TxtDed.Text) = "" Then
                            temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                        Else
                            temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round((TxtPPre.Text), 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                        End If
                        If Trim(TxtDed.Text) = "" Then
                            TxtDed.Text = "0"
                        End If



                        temp7 = Right(temp7, 25)
                        TxtTotChqPay.Text = temp7

                        temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                        temp8 = Right(temp8, 25)
                        Txtval.Text = temp8
                    End If

                Next

            End If
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

                Txtpayfdt.Text = dt2 + "/" + dt1 + "/" + dt3

                dt1 = Format(Day(CDate(dr1("Veh_Exdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Exdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Exdt")))

                TxtpayTdt.Text = dt2 + "/" + dt1 + "/" + dt3
                Dim dtdiff As Integer

                Typ = dr1("Veh_Typ")
                Txtval.Text = dr1("Veh_Val")
                Txtval.Enabled = False
                TxtpayTdt.Enabled = False
                Txtpayfdt.Enabled = False

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

                        If Txtpayfdt.Text = " " Or TxtpayTdt.Text = " " Then

                        Else
                            If Val(Txtval.Text) = 0 Or Txtval.Text = " " Then

                            Else



                                LbLMsg.Text = "                       "

                                SS = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                                SS = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                                SS = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                                Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                                Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)

                                If Tfdt = " " Then

                                Else


                                    dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                                    Temp1 = Space(25)
                                    Temp2 = Space(25)
                                    temp3 = Space(25)
                                    temp4 = Space(25)
                                    temp5 = Space(25)
                                    temp6 = Space(25)
                                    temp7 = Space(25)
                                    temp8 = Space(25)



                                    val1 = (Txtval.Text * Val(pay2) / 100)
                                    If val1 < 1000 Then
                                        val1 = 1000
                                    Else
                                        val1 = Txtbpay.Text
                                    End If
                                    Temp1 = Temp1 + Format((val1), "###,###,###.##")

                                    Temp1 = Right(Temp1, 25)
                                    Txtbpay.Text = Temp1

                                    Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                                    Temp2 = Right(Temp2, 25)
                                    Txtrcc.Text = Temp2

                                    temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                                    temp3 = Right(temp3, 25)
                                    Txttr.Text = temp3

                                    TxtPPre.Text = Format(pay1, "###,###,###.##")
                                    If dtdiff = 366 Then
                                        dtdiff = dtdiff - 1
                                    Else
                                        If dtdiff = 364 Then
                                            dtdiff = dtdiff + 1
                                        End If

                                    End If
                                    Lbldys.Text = dtdiff

                                    temp4 = temp4 + Format(pay1, "###,###,###.##")
                                    temp4 = Right(temp4, 25)
                                    TxtPPre.Text = temp4


                                    Dim Tpay As Double
                                    'pay1 = pay1 / 365 * (dtdiff )
                                    'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                                    Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100) - pay1)




                                    temp5 = temp5 + Format((Tpay), "###,###,###.##")
                                    temp5 = Right(temp5, 25)
                                    TxtTpay.Text = temp5

                                    temp6 = temp6 + Format((TxtTpay.Text) * Val(TxtPer.Text) / 100, "###,###,###.##")
                                    temp6 = Right(temp6, 25)
                                    TxtDed.Text = temp6


                                    If Trim(TxtDed.Text) = "" Then
                                        temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                                    Else
                                        temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                                    End If
                                    If Trim(TxtDed.Text) = "" Then
                                        TxtDed.Text = "0"
                                    End If



                                    temp7 = Right(temp7, 25)
                                    TxtTotChqPay.Text = temp7

                                    temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                                    temp8 = Right(temp8, 25)
                                    Txtval.Text = temp8

                                End If
                            End If
                        End If

                    Next

                End If

                'Txtbpay.Text = dr1("Emp_TaLv")
                'Txtval.Text = dr1("Emp_CntNo")
                'Txtrcc.Text = dr1("Emp_email")
                'Txttr.Text = dr1("Emp_des")
            Next

            Exit Sub

        Else
            Txtbpay.Text = 0
            Txtrcc.Text = 0
            Txttr.Text = 0
            TxtPPre.Text = 0

            Txtval.Text = 0

            Txtpayfdt.Text = Format(Today, "dd/MM/yyyy")

            TxtpayTdt.Text = Format(Today, "dd/MM/yyyy")


            TxtTpay.Text = ""
            Txtval.Enabled = True
            TxtpayTdt.Enabled = True
            Txtpayfdt.Enabled = True
            TxtPPre.Enabled = True

        End If

    End Sub

    Private Sub TxtPPre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPPre.TextChanged
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

                Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                Temp1 = Space(25)
                Temp2 = Space(25)
                temp3 = Space(25)
                temp4 = Space(25)
                temp5 = Space(25)
                temp6 = Space(25)
                temp7 = Space(25)
                temp8 = Space(25)


                val1 = (Txtval.Text * Val(pay2) / 100)
                If val1 < 1000 Then
                    val1 = 1000
                Else
                    val1 = Txtbpay.Text
                End If
                Temp1 = Temp1 + Format((val1), "###,###,###.##")

                Temp1 = Right(Temp1, 25)
                Txtbpay.Text = Temp1

                Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                Temp2 = Right(Temp2, 25)
                Txtrcc.Text = Temp2

                temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                temp3 = Right(temp3, 25)
                Txttr.Text = temp3

                TxtPPre.Text = Format(TxtPPre.Text, "###,###,###.##")


                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If

                End If
                Lbldys.Text = dtdiff

                temp4 = temp4 + Format(pay1, "###,###,###.##")
                temp4 = Right(temp4, 25)
                TxtPPre.Text = temp4


                Dim Tpay As Double
                'pay1 = pay1 / 365 * (dtdiff )
                'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))




                temp5 = temp5 + Format((Tpay), "###,###,###.##")
                temp5 = Right(temp5, 25)
                TxtTpay.Text = temp5

                temp6 = temp6 + Format(((TxtTpay.Text) - (TxtPPre.Text)) * Val(TxtPer.Text) / 100, "###,###,###.##")
                temp6 = Right(temp6, 25)
                TxtDed.Text = temp6


                If Trim(TxtDed.Text) = "" Then
                    temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                Else
                    temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round((TxtPPre.Text), 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                End If
                If Trim(TxtDed.Text) = "" Then
                    TxtDed.Text = "0"
                End If



                temp7 = Right(temp7, 25)
                TxtTotChqPay.Text = temp7

                temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                temp8 = Right(temp8, 25)
                Txtval.Text = temp8
            Next

        End If
    End Sub


    Private Sub TxtDed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDed.TextChanged


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
                pay2 = Txtbpay.Text
                pay3 = dr1("Veh_Rcc")
                pay4 = dr1("Veh_Rcc")
                pay5 = dr1("Veh_Tr")
                pay6 = dr1("Veh_vat")



                Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                Temp1 = Space(25)
                Temp2 = Space(25)
                temp3 = Space(25)
                temp4 = Space(25)
                temp5 = Space(25)
                temp6 = Space(25)
                temp7 = Space(25)
                temp8 = Space(25)

                val1 = (Txtval.Text * Val(pay2) / 100)
                'If val1 < 1000 Then
                'val1 = 1000
                'Else
                'val1 = Txtbpay.Text
                ' End If
                val1 = Txtbpay.Text
                Temp1 = Temp1 + Format((val1), "###,###,###.##")
                Temp1 = Right(Temp1, 25)
                Txtbpay.Text = Temp1

                Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                Temp2 = Right(Temp2, 25)
                Txtrcc.Text = Temp2

                temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                temp3 = Right(temp3, 25)
                Txttr.Text = temp3


                TxtPPre.Text = Format(pay1, "###,###,###.##")
                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If

                End If
                Lbldys.Text = dtdiff

                temp4 = temp4 + Format(pay1, "###,###,###.##")
                temp4 = Right(temp4, 25)
                TxtPPre.Text = temp4

                Dim Tpay As Double
                'pay1 = pay1 / 365 * (dtdiff )
                'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))




                temp5 = temp5 + Format((Tpay), "###,###,###.##")
                temp5 = Right(temp5, 25)
                TxtTpay.Text = temp5

                temp6 = temp6 + Format(((TxtTpay.Text) - (TxtPPre.Text)) * Val(TxtPer.Text) / 100, "###,###,###.##")
                temp6 = Right(temp6, 25)
                TxtDed.Text = temp6


                If Trim(TxtDed.Text) = "" Then
                    temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                Else
                    temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round((TxtPPre.Text), 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                End If
                If Trim(TxtDed.Text) = "" Then
                    TxtDed.Text = "0"
                End If



                temp7 = Right(temp7, 25)
                TxtTotChqPay.Text = temp7

                temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                temp8 = Right(temp8, 25)
                Txtval.Text = temp8


            Next

        End If



    End Sub

    Private Sub Txtrcc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtrcc.TextChanged

    End Sub

    Private Sub TxtPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPer.TextChanged
        '  If pos1 = "Y" Then



        'Dim dtdiff As Integer


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
                If Trim(Txtpayfdt.Text) = "" Or Trim(TxtpayTdt.Text) = "" Then

                Else

                    If Txtval.Text = " " Or Val(Txtval.Text) = 0 Then

                    Else

                        Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                        Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                        dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                        Temp1 = Space(25)
                        Temp2 = Space(25)
                        temp3 = Space(25)
                        temp4 = Space(25)
                        temp5 = Space(25)
                        temp6 = Space(25)
                        temp7 = Space(25)
                        temp8 = Space(25)



                        Temp1 = Temp1 + Format((Txtval.Text * Val(pay2) / 100), "###,###,###.##")
                        Temp1 = Right(Temp1, 25)
                        Txtbpay.Text = Temp1

                        Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                        Temp2 = Right(Temp2, 25)
                        Txtrcc.Text = Temp2

                        temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                        temp3 = Right(temp3, 25)
                        Txttr.Text = temp3

                        TxtPPre.Text = Format(pay1, "###,###,###.##")
                        If dtdiff = 366 Then
                            dtdiff = dtdiff - 1
                        Else
                            If dtdiff = 364 Then
                                dtdiff = dtdiff + 1
                            End If

                        End If
                        Lbldys.Text = dtdiff

                        temp4 = temp4 + Format(pay1, "###,###,###.##")
                        temp4 = Right(temp4, 25)
                        TxtPPre.Text = temp4


                        Dim Tpay As Double
                        'pay1 = pay1 / 365 * (dtdiff )
                        'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                        Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100))




                        temp5 = temp5 + Format((Tpay), "###,###,###.##")
                        temp5 = Right(temp5, 25)
                        TxtTpay.Text = temp5

                        temp6 = temp6 + Format(((TxtTpay.Text) - (TxtPPre.Text)) * Val(TxtPer.Text) / 100, "###,###,###.##")
                        temp6 = Right(temp6, 25)
                        TxtDed.Text = temp6


                        If Trim(TxtDed.Text) = "" Then
                            temp7 = temp7 + Format((Round(TxtTpay.Text, 2)) / 365 * (dtdiff), "###,###,###.##")
                        Else
                            temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round((TxtPPre.Text), 2) - Round(TxtDed.Text, 2))) / 365 * (dtdiff), "###,###,###.##")
                        End If
                        If Trim(TxtDed.Text) = "" Then
                            TxtDed.Text = "0"
                        End If



                        temp7 = Right(temp7, 25)
                        TxtTotChqPay.Text = temp7

                        temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                        temp8 = Right(temp8, 25)
                        Txtval.Text = temp8
                    End If
                End If

            Next

        End If
        '  End If
    End Sub

    Private Sub Txttr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txttr.TextChanged
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
                pay2 = Txtbpay.Text
                pay3 = dr1("Veh_Rcc")
                pay4 = dr1("Veh_Rcc")
                pay5 = dr1("Veh_Tr")
                pay6 = dr1("Veh_vat")



                Tfdt = Mid(Trim(Txtpayfdt.Text), 4, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 1, 2) + "/" + Mid(Trim(Txtpayfdt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtpayTdt.Text), 4, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 1, 2) + "/" + Mid(Trim(TxtpayTdt.Text), 7, 4)
                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                Temp1 = Space(25)
                Temp2 = Space(25)
                temp3 = Space(25)
                temp4 = Space(25)
                temp5 = Space(25)
                temp6 = Space(25)
                temp7 = Space(25)
                temp8 = Space(25)

                val1 = (Txtval.Text * Val(pay2) / 100)
                'If val1 < 1000 Then
                'val1 = 1000
                'Else
                'val1 = Txtbpay.Text
                ' End If
                val1 = Txtbpay.Text
                Temp1 = Temp1 + Format((val1), "###,###,###.##")
                Temp1 = Right(Temp1, 25)
                Txtbpay.Text = Temp1

                Temp2 = Temp2 + Format((Txtval.Text * Val(pay3) / 100), "###,###,###.##")
                Temp2 = Right(Temp2, 25)
                Txtrcc.Text = Temp2

                temp3 = temp3 + Format((Txtval.Text * Val(pay5) / 100), "###,###,###.##")
                temp3 = Right(temp3, 25)
                ' Txttr.Text = temp3
                temp3 = Val(Txttr.Text)

                pay5 = Val(Txttr.Text)
                TxtPPre.Text = Format(pay1, "###,###,###.##")
                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If

                End If
                Lbldys.Text = dtdiff

                temp4 = temp4 + Format(pay1, "###,###,###.##")
                temp4 = Right(temp4, 25)
                TxtPPre.Text = temp4


                Dim Tpay As Double
                'pay1 = pay1 / 365 * (dtdiff )
                'Tpay = Round(((Txtval.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((Txtval.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                Tpay = ((val1) + (Txtval.Text * Val(pay3) / 100) + (Txtval.Text * Val(pay5) / 100) - pay1)




                temp5 = temp5 + Format((Tpay), "###,###,###.##")
                temp5 = Right(temp5, 25)
                TxtTpay.Text = temp5

                'temp6 = temp6 + Format((TxtTpay.Text) * 2 / 100, "###,###,###.##")
                'temp6 = Right(temp6, 25)
                'TxtDed.Text = temp6

                If IsNumeric(TxtDed.Text) = False Then
                    temp7 = temp7 + Format((Round(TxtTpay.Text, 2) / 365 * (dtdiff)), "###,###,###.##")
                    temp7 = Right(temp7, 25)
                    TxtTotChqPay.Text = temp7
                Else
                    temp7 = temp7 + Format(((Round(TxtTpay.Text, 2) - Round(TxtDed.Text, 2)) / 365 * (dtdiff)), "###,###,###.##")
                    temp7 = Right(temp7, 25)
                    TxtTotChqPay.Text = temp7
                End If


                temp8 = temp8 + Format(Round(Txtval.Text, 2), "###,###,###.##")
                temp8 = Right(temp8, 25)
                Txtval.Text = temp8



            Next

        End If

    End Sub

   
End Class
