Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail


Public Class Inwordpayment
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
    Dim TT As String

    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    Dim invcom As String
    Dim invpono As String
    Dim invgrno As String
    Public CrdLmt As Integer
    'Dim pos1 As String
    Public pos1 As String

    Dim Typ As String
    Dim Count As Integer

    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents LbLMsg As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents TxtRecDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCerNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtVAL As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents ImgBtt1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Txtpono As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtBilDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPaydt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCrdLmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtGrnNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtchqdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Imagebutton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar3 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='Inwordpayment.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            'Response.Redirect("InsuDept.aspx")
        End If
        If Not IsPostBack Then
            LstId.Enabled = False
            LstCom.Enabled = True
            Lsttyp.Enabled = False
            TxtBilDt.Enabled = False
            TxtRecDt.Enabled = False
            'TxtCerNo.Enabled = False


            TxtBilDt.Text = " "
            TxtRecDt.Text = " "
            'TxtCerNo.Text = " "

            TxtRecDt.Text = Format(Date.Today, ("dd/MM/yyyy"))
            TxtBilDt.Text = Format(Date.Today, ("dd/MM/yyyy"))


            Dim TT, TT1 As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT Inv_no,Inv_Totval FROM InhPur where Inv_no<>'' order by Inv_no ", CON)

            DR = CMD.ExecuteReader

            If Not IsPostBack Then


                While DR.Read
                    TT = DR.GetValue(0)


                    LstId.Items.Add(TT)
                    Lsttyp.Items.Add(TT1)
                End While
            End If
            DR.Close()


            CMD = New SqlCommand("SELECT Com_No,Com_nam From Supplier", CON)


            DR = CMD.ExecuteReader


            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                    LstCom.Items.Add(TT)

                End While
            End If

            DR.Close()


            TxtId.Enabled = False

            'TxtBilDt.Enabled = False
            ' Txtbpay.Enabled =TRUE
            'TxtCerNo.Enabled = False


        End If
        Dim V1, V2, V3 As String
        If BtnAdd.Enabled = True Then
            V1 = "http://sgcsser\Insu\Newpict\" & Trim(TxtId.Text) & "1.jpg"
        Else
            V1 = "http://sgcsser\Insu\Newpict\" & Trim(LstId.SelectedValue) & "1.jpg"
        End If
        If BtnAdd.Enabled = True Then
            V2 = "http://sgcsser\Insu\Newpict\" & Trim(TxtId.Text) & "2.jpg"
        Else
            V2 = "http://sgcsser\Insu\Newpict\" & Trim(LstId.SelectedValue) & "2.jpg"
        End If

        V3 = "http://sgcsser\Insu\Newpict\"

        If IsDBNull(V1) = False Then
            'Img1.Visible = True
            ' Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            'Img2.Visible = True
            'Img2.ImageUrl = V2
        End If







        CON.Close()
        LstCom.Enabled = False
        LstId.Enabled = True
        Lsttyp.Enabled = True
        'Txtpono.Enabled = False
        '  Txtbpay.Enabled = True
        'TxtCerNo.Enabled = True
        'TxtCerNo.Visible = True

        'Txtrcc.Enabled = True
        'Txtrcc.Visible = True
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
        TxtBilDt.Enabled = True
        TxtRecDt.Enabled = True
        TxtCerNo.Enabled = True


        TxtBilDt.Text = ""
        TxtRecDt.Text = ""
        TxtCerNo.Text = ""



        LstCom.Enabled = True

        BtnEdit.Enabled = False
        TxtId.Text = ("")

        'TxtBilDt.Text = ("")
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
        'TxtBilDt.Enabled = True
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
        'TxtBilDt.Text = ("")
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

        idno = LstId.SelectedValue


        ADA = New SqlDataAdapter("SELECT * FROM InhPur WHERE inv_no = '" & idno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "InhPur")

        Count = DS.Tables("InhPur").Rows.Count
        Dim dr1, dr2 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            LbLMsg.Text = "                       "


            For Each dr1 In DS.Tables("InhPur").Rows

                ' LstCom.SelectedValue = dr1("Veh_Com")

                invcom = dr1("inv_com")
                invpono = IIf(IsDBNull(dr1("inv_pono")), " ", dr1("inv_pono"))
                invgrno = IIf(IsDBNull(dr1("inv_GrnNo")), " ", dr1("inv_GrnNo"))

                TxtGrnNo.Text = invgrno


                TxtRecDt.Text = IIf(IsDBNull(dr1("Inv_recdt")), " ", dr1("Inv_recdt"))
                TxtBilDt.Text = IIf(IsDBNull(dr1("Inv_bildt")), " ", dr1("Inv_bildt"))
                TxtPaydt.Text = IIf(IsDBNull(dr1("Inv_pdt")), " ", dr1("Inv_pdt"))
                Txtchqdt.Text = IIf(IsDBNull(dr1("Inv_chqdt")), " ", dr1("Inv_chqdt"))
                TxtChqNo.Text = IIf(IsDBNull(dr1("Inv_chqno")), " ", dr1("Inv_chqno"))

                If Txtchqdt.Text = " " Then
                    Txtchqdt.Text = Format(Date.Today, ("dd/MM/yyyy"))

                Else
                    Txtchqdt.Text = Format(DateValue(Txtchqdt.Text), ("dd/MM/yyyy"))
                End If


                If TxtRecDt.Text = " " Then
                    TxtRecDt.Text = Format(Date.Today, ("dd/MM/yyyy"))

                Else
                    TxtRecDt.Text = Format(DateValue(TxtRecDt.Text), ("dd/MM/yyyy"))
                End If
                If TxtBilDt.Text = " " Then
                    TxtBilDt.Text = Format(Date.Today, ("dd/MM/yyyy"))
                Else
                    TxtBilDt.Text = Format(DateValue(TxtBilDt.Text), ("dd/MM/yyyy"))
                End If

                If TxtPaydt.Text = " " Then

                Else
                    TxtPaydt.Text = Format(DateValue(TxtPaydt.Text), ("dd/MM/yyyy"))
                End If

                ADA = New SqlDataAdapter("SELECT * FROM InlPur WHERE inv_no = '" & idno & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "InlPur")

                Count = DS.Tables("InlPur").Rows.Count
                Dim totdis As Double
                totdis = 0

                If Count <> 0 Then
                    LbLMsg.Text = "                       "


                    For Each dr2 In DS.Tables("InlPur").Rows
                        'totdis = totdis + Val(dr2("Inv_qty")) * Val(dr2("Inv_pri")) * Val(dr2("Inv_dis") / 100)

                    Next
                End If

                TxtVAL.Text = Round(dr1("Inv_Totval"), 2)

                'TxtDis.Text = Round(totdis, 2)





                'If dr1("Inv_vat") = "Yes" Then
                'Txtvat.Text = Round((dr1("Inv_Totval") - totdis) * 15 / 100, 2) + Round(((dr1("Inv_Totval") - totdis) * 15 / 100 + (dr1("Inv_Totval") - totdis)) * 1 / 100, 2)
                'Else
                ' Txtvat.Text = Round((dr1("Inv_Totval") - totdis) * 1 / 100, 2)

                'End If

                'TxtNetAmt.Text = Round(((dr1("Inv_Totval") + Txtvat.Text) - TxtDis.Text), 2)

                Dim TEXT1, TEXT2, TEXT3, TEXT4 As String
                TEXT1 = Space(25)
                TEXT2 = Space(25)
                TEXT3 = Space(25)
                TEXT4 = Space(25)
                'TEXT1 = TEXT1 + TxtDis.Text
                TEXT1 = Right(TEXT1, 25)
                'TEXT2 = TEXT2 + Txtvat.Text
                TEXT2 = Right(TEXT2, 25)

                'TEXT3 = TEXT3 + TxtNetAmt.Text
                TEXT3 = Right(TEXT3, 25)
                'TxtNetAmt.Text = TEXT2

                ' TxtDed.Text = TEXT1
                TEXT4 = TEXT4 + TxtVAL.Text
                TEXT4 = Right(TEXT4, 25)

                'TxtNetAmt.Text = TEXT3
                Txtpono.Text = invpono

                TxtVAL.Text = TEXT4


                CMD = New SqlCommand("SELECT Com_No,Com_nam,Com_CrdLmt From Supplier where Com_No='" & invcom & "'", CON)
                'CMD = New SqlCommand("SELECT Com_No,Com_nam From Supplier", CON)

                DR3 = CMD.ExecuteReader



                While DR3.Read
                    TT = DR3.GetValue(0) + " - " + DR3.GetValue(1)
                    LstCom.SelectedValue = TT
                    CrdLmt = DR3.GetValue(2)
                    TxtCrdLmt.Text = DR3.GetValue(2)

                End While


                DR3.Close()

                'TxtPaydt.Text = Format((DateValue(TxtRecDt.Text) + CrdLmt), "dd/MM/yyyy")

                If TxtGrnNo.Text = " " Then
                    TxtPaydt.Text = DateAdd(DateInterval.Day, CrdLmt, CDate(Mid(TxtRecDt.Text, 1, 2) + "/" + Mid(TxtRecDt.Text, 4, 2) + "/" + Mid(TxtRecDt.Text, 7, 4)))

                    TxtPaydt.Text = Format(DateValue(TxtPaydt.Text), ("dd/MM/yyyy"))



                Else



                End If

                'LstCom.SelectedValue = dr1("Veh_COM")



                Dim dt1, dt2, dt3 As String

                Dim dtdiff As Integer

                Typ = dr1("Inv_TotVal")
                ' TxtBilDt.Text = IIf(IsDBNull(dr1("Inv_chqNo")), " ", dr1("Inv_ChqNo"))

                'TxtRmks.Text = IIf(IsDBNull(dr1("Inv_rmks")), " ", dr1("Inv_rmks"))

                Dim Invpaydt As String
                Invpaydt = CDate(dr1("Inv_Paydt"))
                If IsDBNull(Invpaydt) = True Then
                    TxtRecDt.Text = "  /  /    "

                Else

                    dt1 = Format(Day(CDate(IIf(IsDBNull(dr1("Inv_Paydt")), " ", dr1("Inv_Paydt")))), "00")
                    dt2 = Format(Month(CDate(IIf(IsDBNull(dr1("Inv_Paydt")), " ", dr1("Inv_Paydt")))), "00")
                    dt3 = Year(CDate(IIf(IsDBNull(dr1("Inv_Paydt")), " ", dr1("Inv_Paydt"))))

                    ' TxtRecDt.Text = dt1 + "/" + dt2 + "/" + dt3

                    'If TxtBilDt.Text = " " Then
                    ' TxtRecDt.Text = Format(Date.Today, ("dd/MM/yyyy"))

                    'End If


                End If


                'TxtRecDt.Text = IIf(IsDBNull(dr1("Veh_recdt")), " ", dr1("Veh_recdt"))


                'TxtCerNo.Text = IIf(IsDBNull(dr1("Veh_CertifyNo")), " ", dr1("Veh_CertifyNo"))

                TxtBilDt.Enabled = True
                TxtRecDt.Enabled = True
                'TxtCerNo.Enabled = True

                'ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & Typ & "'", CON)
                'DS = New DataSet
                'ADA.Fill(DS, "VEHTYPMAST")

                'Count = DS.Tables("VEHTYPMAST").Rows.Count

                'If Count <> 0 Then
                'For Each dr2 In DS.Tables("VEHTYPMAST").Rows

                'pay'1 = dr2("Veh_tp_tppd")
                'pay2 = dr2("Veh_B_ Primum")
                'pay3 = dr2("Veh_Rcc")
                'pay4 = dr2("Veh_Rcc")
                'pay5 = dr2("Veh_Tr")
                'pay6 = dr2("Veh_vat")

                'Dim Tfdt, Ttdt As String
                'If Trim(TxtCerNo.Text) = "" Then

                'Else
                '    ' Tfdt = Mid(Trim(TxtBilDt.Text), 4, 2) + "/" + Mid(Trim(TxtBilDt.Text), 1, 2) + "/" + Mid(Trim(TxtBilDt.Text), 7, 4)
                '    ' Ttdt = Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
                '    ' dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))



                '    Dim Tpay As Double
                '    'pay1 = pay1 / 365 * (dtdiff - 1)
                '    'Tpay = Round(((TxtCerNo.Text * Val(pay2) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay3) / 100) / 365) * (dtdiff - 1), 2) + Round(((TxtCerNo.Text * Val(pay5) / 100) / 365) * (dtdiff - 1), 2) - pay1



                'End If

            Next

            'End If

            '        'Txtbpay.Text = dr1("Emp_TaLv")
            ''        'TxtCerNo.Text = dr1("Emp_CntNo")
            '        'Txtrcc.Text = dr1("Emp_email")
            '        'Txttr.Text = dr1("Emp_des")
            '    Next

            '    Exit Sub

        Else
            LbLMsg.Text = "Record Not Found !"





            'TxtCerNo.Text = ""

            TxtBilDt.Text = ""
            TxtRecDt.Text = ""


            'TxtCerNo.Enabled = False
            'TxtRecDt.Enabled = False
            'xtChqNo.Enabled = False


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
        'TxtBilDt.Text = dr1("Emp_ToLv")
        'Txtbpay.Text = dr1("Emp_TaLv")
        'TxtCerNo.Text = dr1("Emp_CntNo")
        'Txtrcc.Text = dr1("Emp_email")
        'Txttr.Text = dr1("Emp_des")
        '    Next
        'Else
        'TxtNam.Text = ("")
        ' TxtBilDt.Text = ("")
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



        If BtnAdd.Enabled = False Then

            ADA = New SqlDataAdapter("SELECT * FROM InhPur WHERE INV_NO = '" & IDNO & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "InhPur")
            IDNO = LstId.SelectedValue
            COM = Mid(LstCom.SelectedValue, 1, 3)
            typ = Lsttyp.SelectedValue
            Count = DS.Tables("InhPur").Rows.Count
            If Count <> 0 Then

                'TxtNam.Text = dr1("Emp_Name")
                'TxtBilDt.Text = dr1("Emp_ToLv")
                'Txtbpay.Text = dr1("Emp_TaLv")
                'TxtCerNo.Text = dr1("Emp_CntNo")
                CMD.Connection = CON
                Dim SS As String
                SS = "UPDATE InhPur SET Inv_chqno='" & TxtChqNo.Text & "',Inv_chqDt='" & DateValue(Mid(Trim(Txtchqdt.Text), 4, 2) + "/" + Mid(Trim(Txtchqdt.Text), 1, 2) + "/" + Mid(Trim(Txtchqdt.Text), 7, 4)) & "' WHERE Inv_NO='" & IDNO & "'"


                CMD.CommandText = (SS)
                CMD.ExecuteNonQuery()

                '------------------






                '---------------  
            End If

        Else
            ''IDNO = TxtId.Text
            ''COM = Mid(LstCom.SelectedValue, 1, 3)
            ''typ = Lsttyp.SelectedValue
            ''CMD.Connection = CON
            ''Dim SS As String
            ''SS = "INSERT INTO VEHMAST (VEH_NO,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL) VALUES ('" & IDNO & "','" & COM & "','" & typ & "',#" & TxtBilDt.Text & "#,#" & TxtRecDt.Text & "#," & TxtBilDt.Text & "," & TxtBilDt.Text & "," & TxtBilDt.Text & "," & TxtBilDt.Text & "," & TxtBilDt.Text & "," & TxtBilDt.Text & "," & TxtCerNo.Text & ")"
            ''Dim P1, P2, P3, P4, P5, P6, P7 As Double
            '''''P1 = FormatNumber((TxtDed.Text), "0000000.00")
            '''''P2 = FormatNumber((TxtPPre.Text), "0000000.00")
            '''''P3 = FormatNumber((Txtrcc.Text), "0000000.00")
            '''''P4 = FormatNumber((Txtbpay.Text), "0000000.00")
            '''''P5 = FormatNumber((Txttr.Text), "0000000.00")
            '''''P6 = FormatNumber((TxtTpay.Text), "0000000.00")

            ''CMD.CommandText = ("INSERT INTO VEHMAST (VEH_NO,VEH_COM,VEH_TYP,VEH_EFDT,VEH_EXDT,VEH_PAYDT,VEH_DED,VEH_PPRE,VEH_RCC,VEH_BPAY,VEH_TR,VEH_TPAY,VEH_VAL) VALUES ('" & IDNO & "','" & COM & "','" & typ & "',#" & TxtBilDt.Text & "#,#" & TxtRecDt.Text & "#,#" & TxtBilDt.Text & "#," & P1 & "," & P2 & "," & P3 & "," & P4 & "," & P5 & "," & P6 & "," & TxtCerNo.Text & ")")
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

                Tfdt = Mid(Trim(TxtBilDt.Text), 1, 2) + "/" + Mid(Trim(TxtBilDt.Text), 4, 2) + "/" + Mid(Trim(TxtBilDt.Text), 7, 4)
                Ttdt = Mid(Trim(TxtRecDt.Text), 1, 2) + "/" + Mid(Trim(TxtRecDt.Text), 4, 2) + "/" + Mid(Trim(TxtRecDt.Text), 7, 4)
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
                If Trim(TxtBilDt.Text) = "" Or Trim(TxtRecDt.Text) = "" Then

                Else
                    Tfdt = Mid(Trim(TxtBilDt.Text), 1, 2) + "/" + Mid(Trim(TxtBilDt.Text), 4, 2) + "/" + Mid(Trim(TxtBilDt.Text), 7, 4)
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

                End If

            Next

        End If
        '  End If
    End Sub

    Private Sub Txtbpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtBilDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If IsPostBack Then

            Dim ppp As String
            Dim dt As Date
            Dim dt1 As String
            Dim dt2 As String
            Dim dt3 As String

            'TxtRecDt.Text = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtBilDt.Text, 4, 2) + "/" + Mid((TxtBilDt.Text), 1, 2) + "/" + Mid((TxtBilDt.Text), 7, 4))))
            dt = DateAdd(DateInterval.Day, 1, DateAdd(DateInterval.Year, 1, CDate(Mid(TxtRecDt.Text, 1, 2) + "/" + Mid((TxtRecDt.Text), 4, 2) + "/" + Mid((TxtRecDt.Text), 7, 4))))

            dt1 = Format(Day(dt), "00")
            dt2 = Format(Month(dt), "00")
            dt3 = Year(dt)


            ppp = dt1 + "/" + dt2 + "/" + dt3

            TxtRecDt.Text = ppp

        End If
    End Sub

    Private Sub TxtRecDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRecDt.TextChanged

        If TxtGrnNo.Text = " " Then

        Else

            TxtPaydt.Text = DateAdd(DateInterval.Day, Val(TxtCrdLmt.Text), CDate(Mid(TxtRecDt.Text, 4, 2) + "/" + Mid(TxtRecDt.Text, 1, 2) + "/" + Mid(TxtRecDt.Text, 7, 4)))

            TxtPaydt.Text = Format(DateValue(TxtPaydt.Text), ("dd/MM/yyyy"))
            TxtBilDt.Text = TxtRecDt.Text
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

                Tfdt = Mid(Trim(TxtBilDt.Text), 1, 2) + "/" + Mid(Trim(TxtBilDt.Text), 4, 2) + "/" + Mid(Trim(TxtBilDt.Text), 7, 4)
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


    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtRecDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False
        TxtPaydt.Text = DateAdd(DateInterval.Day, Val(TxtCrdLmt.Text), CDate(Mid(TxtRecDt.Text, 4, 2) + "/" + Mid(TxtRecDt.Text, 1, 2) + "/" + Mid(TxtRecDt.Text, 7, 4)))

        TxtPaydt.Text = Format(DateValue(TxtPaydt.Text), ("dd/MM/yyyy"))

        TxtBilDt.Text = TxtRecDt.Text

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub ImgBtt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim strReport As String = ""
        strReport = "Newapp4.aspx?Type=" & LstId.SelectedValue
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
    End Sub

    Private Sub Imagebutton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton2.Click
        Calendar2.Visible = True
    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TxtBilDt.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False

    End Sub

    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function




    Private Sub Textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Imagebutton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click
        Calendar3.Visible = True
    End Sub

    Private Sub Calendar3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar3.SelectionChanged
        Txtchqdt.Text = Format((Calendar3.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar3.Visible = False

    End Sub
End Class

