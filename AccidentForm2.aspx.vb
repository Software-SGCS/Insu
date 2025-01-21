Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Imports System.Web

Imports System.Web.UI

Imports System.Web.UI.WebControls

Imports System.Web.UI.HtmlControls

Imports System.Configuration

Public Class AccidentForm2
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim Dtr, Dtr1, dtr2 As DataRow
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
    Dim val1, val2, val3 As Double
    Dim ss, s1, s2, com As String
    Dim NAccno As Double
    Dim s3 As Date
    Dim pay1 As Integer
    Dim pay2 As String
    Dim pay3 As String
    Dim pay4 As String
    Dim pay5 As String
    Dim pay6 As String
    Dim idno As String
    Dim vehtemp As String
    Dim dt As Date
    Dim dtt As Date

    Dim typ As String
    Dim Count As Double
    Dim body As String

    Dim dt1, dt11 As String
    Dim dt2, dt21 As String
    Dim dt3, dt31 As String
    'Dim pos1 As String

    Public pos1 As String
    Dim Temp1, Temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9 As String
    Dim Teamt As Double

    Dim VehCom As String
    Public AccNo As Double
    Dim FNAME As String

    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents LbLMsg As System.Web.UI.WebControls.Label
    Protected WithEvents TxtAcidt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEstval12 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEstval11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtEstval2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEstval1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEstval3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImgBtn1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TxtVehClNo As System.Web.UI.WebControls.TextBox
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
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
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
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='AccidentForm2.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            Response.Redirect("InsuDept.aspx")
        End If
        If Not IsPostBack Then
            BtnApp.Enabled = True
            LstId.Enabled = True
            LstCom.Enabled = False
            Lsttyp.Enabled = False
            TxtAcidt.Enabled = True
            TxtEstval1.Enabled = True
            TxtAcidt.Text = " "
            Calendar1.Visible = False
            Dim TT As String
            pos1 = "N"
            'CMD = New SqlCommand("SELECT Veh_No,Veh_Com,Veh_Typ,Veh__Efdt,Veh_Exdt,Veh_val,Veh_paydt FROM VehMast", CON)
            CMD = New SqlCommand("SELECT Veh_no,Veh_com,Veh_typ FROM VehMast", CON)

            DR = CMD.ExecuteReader

            If Not IsPostBack Then

                While DR.Read

                    vehtemp = Space(20)
                    vehtemp = DR.GetValue(0) + vehtemp
                    vehtemp = Mid(vehtemp, 1, 20) + "-" + DR.GetValue(1)

                    'TT = DR.GetValue(0) + "-" + DR.GetValue(1)
                    LstId.Items.Add(vehtemp)
                    Lsttyp.Text = DR.GetValue(2)
                    VehCom = DR.GetValue(1)
                End While
            End If

            DR.Close()

            CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_no='" & VehCom & "'", CON)

            DR = CMD.ExecuteReader

            If Not IsPostBack Then
                While DR.Read
                    TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                    LstCom.Text = TT
                End While
            End If

            DR.Close()


            'TxtId.Enabled = False

            'TxtAcidt.Enabled = False
            ' Txtbpay.Enabled = False
            'TxtEstval1.Enabled = False


        End If
        Dim V1, V2, V3 As String
        If BtnAdd.Enabled = True Then
            'V1 = "http://sgcsser\Insu\Newpict\" & Trim(TxtId.Text) & "1.jpg"
        Else
            ' V1 = "http://sgcsser\Insu\Newpict\" & Trim(LstId.SelectedValue) & "1.jpg"
        End If
        If BtnAdd.Enabled = True Then
            ' V2 = "http://sgcsser\Insu\Newpict\" & Trim(TxtId.Text) & "2.jpg"
        Else
            ' V2 = "http://sgcsser\Insu\Newpict\" & Trim(LstId.SelectedValue) & "2.jpg"
        End If

        'V3 = "http://sgcsser\Insu\Newpict\"

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
        'TxtId.Enabled = True
        'TxtId.Visible = True

        LstId.Visible = True
        LstCom.Enabled = True
        Lsttyp.Enabled = True
        TxtAcidt.Enabled = True

        TxtEstval1.Enabled = True



        TxtAcidt.Text = ""

        TxtEstval1.Text = ""



        LstCom.Enabled = True

        BtnEdit.Enabled = False
        'TxtId.Text = ("")
        BtnApp.Enabled = True

        'TxtAcidt.Text = ("")
        'Txtbpay.Text = ("")
        'TxtEstval1.Text = ("")
        ' Lstcom.text = " "
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")



        BtnApp.Enabled = True
        BtnDel.Enabled = False
        'LstId.Visible = False

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        LstId.Enabled = True
        Lsttyp.Enabled = True
        BtnApp.Enabled = True
        'TxtAcidt.Enabled = True
        ' Txtbpay.Enabled = True
        'TxtEstval1.Enabled = True
        'TxtEstval1.Visible = True

        'Txtrcc.Enabled = True
        'Txtrcc.Visible = True
        'Txttr.Enabled = True
        'Txttr.Visible = True

        ' TxtId.Visible = False
        'TxtId.Enabled = False
        LstId.Visible = True
        LstId.Enabled = True
        BtnAdd.Enabled = False
        BtnApp.Enabled = True
        BtnDel.Enabled = True
        'TxtId.Visible = True

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
        'TxtAcidt.Text = ("")
        'Txtbpay.Text = ("")
        'TxtEstval1.Text = ("")
        '' Lstcom.text = " "
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")

    End Sub

    Private Sub LstId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstId.SelectedIndexChanged
        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        BtnApp.Enabled = True
        idno = Mid(Trim(LstId.SelectedValue), 1, (Len(Trim(LstId.SelectedValue)) - 4))
        s1 = TxtAcidt.Text
        s2 = LstId.SelectedValue



        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & idno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")

        Count = DS.Tables("VEHMAST").Rows.Count
        Dim dr1, dr2 As DataRow
        Dim pppp As String

        If Count <> 0 Then
            LbLMsg.Text = "                       "
            For Each dr1 In DS.Tables("VEHMAST").Rows

                ' Lstcom.text = dr1("Veh_Com")
                Lsttyp.Text = dr1("Veh_Typ")
                Dim SS As String
                SS = "SELECT Com_No,Com_nam From Company where Com_nO='" & dr1("Veh_COM") & "'"
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_nO='" & dr1("Veh_cOM") & "'", CON)

                DR3 = CMD.ExecuteReader

                Dim TT As String

                'If Not IsPostBack Then
                While DR3.Read
                    TT = DR3.GetValue(0) + " - " + DR3.GetValue(1)
                    LstCom.Text = TT
                End While
                'End If

                DR3.Close()
                'Lstcom.text = dr1("Veh_COM")

                Dim dt1, dt2, dt3 As String
                dt1 = Format(Day(Today), "00")
                dt2 = Format(Month(Today), "00")
                dt3 = Format(Year(Today), "0000")

                TxtAcidt.Text = dt1 + "/" + dt2 + "/" + dt3

                TxtEstval1.Text = Space(20)
                TxtEstval2.Text = Space(20)
                TxtEstval3.Text = Space(20)
            Next

        End If
        s3 = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)
        ADA = New SqlDataAdapter("SELECT * FROM VehClaim WHERE Veh_no = '" & idno & "' AND Veh_AccDt = '" & s3 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehClaim")

        Count = DS.Tables("VehClaim").Rows.Count
        TxtEstval1.Text = Space(20)
        TxtEstval2.Text = Space(20)
        TxtEstval3.Text = Space(20)

        If Count <> 0 Then

            For Each Dtr1 In DS.Tables("VehClaim").Rows
                val1 = Dtr1("Veh_InvVal1")
                val2 = Dtr1("Veh_InvVal2")
                val3 = Dtr1("Veh_InvVal3")
                TxtEstval1.Text = Right(Space(20) + Format(val1, "###,###.##"), 20)
                TxtEstval2.Text = Right(Space(20) + Format(val2, "###,###.##"), 20)
                TxtEstval3.Text = Right(Space(20) + Format(val3, "###,###.##"), 20)
                TxtVehClNo.Text = IIf((IsDBNull("Veh_ClNo")), " ", Dtr1("Veh_Clno"))

            Next
            BtnAdd.Enabled = False

        Else
            BtnAdd.Enabled = True
            com = Mid(LstCom.Text, 1, 3)
            dt3 = Mid(TxtAcidt.Text, 7, 4)

            ADA = New SqlDataAdapter("SELECT * FROM AccdentNo WHERE Acc_com = '" & com & "' AND Acc_Yr='" & dt3 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "AccdentNo")

            Count = DS.Tables("AccdentNo").Rows.Count
            If Count <> 0 Then
                For Each Dtr1 In DS.Tables("AccdentNo").Rows
                    AccNo = Dtr1("Acc_no")
                Next
            Else

                AccNo = 1
            End If

            TxtVehClNo.Text = com + "/" + dt3 + "/" + Format(AccNo, "0000")


        End If



    End Sub

    Private Sub LstCom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CON.Open()


        Dim COM As String
        Dim Count As Double
        Dim dr1 As DataRow
        'IDNO = Mid((LstId.SelectedValue), 1, 5)
        COM = Mid(Trim(LstCom.Text), 1, 3)
        '
        ' If BtnAdd.Enabled = False Then
        'IDNO = Mid(Trim(LstId.SelectedValue), 1, 5)
        'COM = Mid(Trim(Lstcom.text), 1, 3)

        'CMD = New SqlCommand("SELECT * FROM EMPMAST WHERE EMP_COM = '" & COM & "' AND EMP_NO = '" & IDNO & "'", CON)
        'RE = CMD.ExecuteReader

        'ADA = New SqlDataAdapter("SELECT * FROM EMPMAST WHERE EMP_COM = '" & COM & "' AND EMP_NO = '" & IDNO & "'", CON)
        'DS = New DataSet
        'ADA.Fill(DS, "EmpMast")

        'Count = DS.Tables("EmpMast").Rows.Count
        'If Count <> 0 Then
        '    For Each dr1 In DS.Tables("EmpMast").Rows


        'TxtNam.Text = dr1("Emp_Name")
        'TxtAcidt.Text = dr1("Emp_ToLv")
        'Txtbpay.Text = dr1("Emp_TaLv")
        'TxtEstval1.Text = dr1("Emp_CntNo")
        'Txtrcc.Text = dr1("Emp_email")
        'Txttr.Text = dr1("Emp_des")
        '    Next
        'Else
        'TxtNam.Text = ("")
        ' TxtAcidt.Text = ("")
        'Txtbpay.Text = ("")
        'TxtEstval1.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")

        'End If

        ' Else

        'IDNO = Mid(Trim(TxtId.Text), 1, 4)
        'COM = Mid(Trim(Lstcom.text), 1, 3)
        'TxtNam.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")
        'TxtEstval1.Text = ("")
        'Txtrcc.Text = ("")
        'Txttr.Text = ("")
        '  End If


        'End If
    End Sub

    Private Sub BtnApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApp.Click
        CON.Open()


        com = Mid(Trim(LstCom.Text), 1, 3)
        idno = Mid(Trim(LstId.SelectedValue), 1, (Len(Trim(LstId.SelectedValue)) - 4))
        idno = Trim(idno)
        dt3 = Mid(Trim(TxtAcidt.Text), 7, 4)

        s1 = TxtAcidt.Text
        s2 = LstId.SelectedValue

        s1 = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)

        CMD = New SqlCommand("SELECT * FROM vehtypmast", CON)
        DR = CMD.ExecuteReader
        DR.Close()

        CMD.Connection = CON


        NAccno = Val(Mid(TxtVehClNo.Text, 10, 4)) + 1
        If BtnAdd.Enabled = False Then
            '' SS = "UPDATE VEHCLAIM SET VEH_COM='" & com & "',VEH_TYP='" & Lsttyp.Text & "',VEH_AccDt=#" & s3 & "#,VEH_EstVal1='" & TxtEstval1.Text & "',VEH_EstVal2='" & TxtEstval2.Text & "',VEH_EstVal3='" & TxtEstval3.Text & "',VEH_No='" & idno & "' WHERE VEH_NO='" & idno & "'"

            CMD.CommandText = ("UPDATE VEHCLAIM SET VEH_COM='" & com & "',VEH_AccDt='" & DateValue(s1) & "',Veh_InvVal1='" & TxtEstval1.Text & "',Veh_InvVal2='" & TxtEstval2.Text & "',Veh_InvVal3='" & TxtEstval3.Text & "',Veh_ClNo='" & TxtVehClNo.Text & "',VEH_No='" & idno & "' WHERE VEH_NO='" & idno & "'")
            CMD.ExecuteNonQuery()
        Else
            CMD.CommandText = ("INSERT INTO VEHCLAIM (VEH_COM,VEH_AccDt,Veh_InvVal1,Veh_InvVal2,Veh_InvVal3,Veh_clNo,VEH_No) VALUES ('" & com & "','" & s1 & "','" & TxtEstval1.Text & "','" & TxtEstval2.Text & "','" & TxtEstval3.Text & "','" & TxtVehClNo.Text & "','" & idno & "')")
            CMD.ExecuteNonQuery()


            If Val(Mid(TxtVehClNo.Text, 10, 4)) = 1 Then
                CMD.CommandText = ("INSERT INTO AccdentNo (Acc_COM,Acc_Yr,Acc_No) VALUES ('" & com & "','" & dt3 & "'," & NAccno & ")")
            Else
                CMD.CommandText = ("UPDATE AccdentNo SET Acc_No=" & NAccno & " WHERE Acc_Com='" & com & "' and Acc_yr='" & dt3 & "'")
            End If
            CMD.ExecuteNonQuery()




        End If
        BtnApp.Enabled = False

        FNAME = Mid(Trim(TxtVehClNo.Text), 1, 3) + Mid(Trim(TxtVehClNo.Text), 5, 4) + Mid(Trim(TxtVehClNo.Text), 10, 4)


        body += "<table width='1000' border='0'>"
        body += "<tr>"
        body += "<td width='218' height='40'><form id='form3' name='form3' method='post' action=''>"
        body += "<label></label>"
        body += "<label></label>"
        body += "<label></label>"
        body += "<label>"
        body += "<input type='image' name='imageField3' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/imgs/logo.cnn.com.gif' />"
        body += "</label>"
        body += "</form>    </td>"
        body += "<td width='750'><form id='form2' name='form2' method='post' action=''>"
        body += "<label></label>"
        body += "<label></label>"
        body += "<label></label>"

        body += "<input type='image' name='imageField' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Menu/Banner.jpg' />"
        body += "</form>    </td>"
        body += "<td width='154'>&nbsp;</td>"
        body += "</tr>"
        body += "<tr>"
        body += "<td height='174'><form id='form4' name='form4' method='post' action=''>"
        body += "<label>"
        body += "<input type='image' name='imageField2' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Acc/" & FNAME & "P1.JPG' />"
        body += "</label>"
        body += "</form>    </td>"
        body += "<td><form id='form1' name='form1' method='post' action=''>"
        body += "<table width='500' height='126' border='0'>"
        body += "<tr>"
        body += "<td width='200' height='30'><label>Vehicle No :</label></td>"
        body += "<td width='169'>" & idno & "</td>"
        body += "<td width='200' height='30'><label>Claim No :</label></td>"
        body += "<td>" & TxtVehClNo.Text & "</td>"
        body += "<td>&nbsp;</td>"
        body += "</tr>"

        body += "<tr>"
        body += "<td width='200' height='30'><label>Company :</label></td>"
        body += "<td width='169'>" & com & "</td>"
        body += "<td width='200' height='30'><label>Accident Date :</label></td>"
        body += "<td>" & TxtAcidt.Text & "</td>"

        body += "<td width='187'>&nbsp;</td>"
        body += "</tr>"
        body += "<tr>"
        body += "<td width='200' height='25'><label>Estmate Value1 :</label></td>"
        body += "<td>" & TxtEstval1.Text & "</td>"
        body += "<td>&nbsp;</td>"
        body += "</tr>"
        body += "<tr>"
        body += "<td width='200' height='28'><label>Estmate Value2 :</label></td>"
        body += "<td>" & TxtEstval2.Text & "</td>"
        body += "<td>&nbsp;</td>"
        body += "</tr>"
        body += "<tr>"
        body += "<td width='200' height='28'><label>Estmate Value3 :</label></td>"
        body += "<td>" & TxtEstval3.Text & "</td>"
        body += "<td>&nbsp;</td>"
        body += "</tr>"


        body += "</table>"
        body += "<label></label>"
        body += "<label></label>"
        body += "</form>    </td>"
        body += "<td>&nbsp;</td>"
        body += "</tr>"
        body += " <tr><td align='left' colSpan='2'><table width='200' border='0'>"
        body += "<tr>"
        body += "<input type='image' name='imageField2' src='file://///sgcsser/C/Inetpub/wwwroot/Insu/Acc/" & FNAME & "P2.JPG' />"
        body += "</tr>"
        body += "</table>"
        body += "</td>"
        body += "<td align='left' colSpan='2'>&nbsp;</td>"
        body += "<td width='163' colSpan='3' align='left'>&nbsp;</td>"
        body += "<td></td>"
        body += "</tr>"
        body += "</table>"

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

        Dim emailMessage As MailMessage
        emailMessage = New MailMessage
        emailMessage.From = "insurance@dsisamson.com"
        ''emailMessage.To = "chamindas@dsisamson.com"
        emailMessage.To = "palithan@dsisamson.com"
        emailMessage.Subject = "Vehcle No :" + idno + " " + com + " " + " Acc Date :" + s1 + " For Your Attention" + " "

        emailMessage.Body = body

        emailMessage.BodyFormat = MailFormat.Html

        SmtpMail.SmtpServer = "mail.dsisamson.com"
        Try
            SmtpMail.Send(emailMessage)
            'labelStatus.Text = "Message sent!"
            'Button1.Enabled = False
        Catch ex As Exception
            'labelStatus.Text="Unable to send the e-mail message"
            ' labelStatus.Text = ex.ToString
        End Try



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

    Private Sub TxtEstval1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEstval1.TextChanged

        TxtEstval1.Text = Right(Space(20) + Format(Val(TxtEstval1.Text), "###,###.##"), 20)

    End Sub

    Private Sub Lsttyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '  If pos1 = "Y" Then



        Dim dtdiff As Integer


        typ = Trim(Lsttyp.Text)


        ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & typ & "'", CON)
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
                If Trim(TxtAcidt.Text) = "" Then

                Else
                    Tfdt = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)

                    dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                    Temp1 = Space(25)
                    Temp2 = Space(25)
                    temp3 = Space(25)
                    temp4 = Space(25)
                    temp5 = Space(25)
                    temp6 = Space(25)
                    temp7 = Space(25)
                    temp8 = Space(25)



                    Temp1 = Temp1 + Format((TxtEstval1.Text * Val(pay2) / 100), "###,###,###.##")
                    Temp1 = Right(Temp1, 25)


                    Temp2 = Temp2 + Format((TxtEstval1.Text * Val(pay3) / 100), "###,###,###.##")
                    Temp2 = Right(Temp2, 25)


                    temp3 = temp3 + Format((TxtEstval1.Text * Val(pay5) / 100), "###,###,###.##")
                    temp3 = Right(temp3, 25)



                    If dtdiff = 366 Then
                        dtdiff = dtdiff - 1
                    Else
                        If dtdiff = 364 Then
                            dtdiff = dtdiff + 1
                        End If

                    End If


                    temp4 = temp4 + Format(pay1, "###,###,###.##")
                    temp4 = Right(temp4, 25)


                    Dim Tpay As Double
                    'pay1 = pay1 / 365 * (dtdiff )
                    'Tpay = Round(((TxtEstval1.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                    Tpay = ((TxtEstval1.Text * Val(pay2) / 100) + (TxtEstval1.Text * Val(pay3) / 100) + (TxtEstval1.Text * Val(pay5) / 100) - pay1)




                    temp5 = temp5 + Format((Tpay), "###,###,###.##")
                    temp5 = Right(temp5, 25)



                    temp6 = Right(temp6, 25)


                    temp7 = Right(temp7, 25)


                    temp8 = temp8 + Format(Round(TxtEstval1.Text, 2), "###,###,###.##")
                    temp8 = Right(temp8, 25)
                    TxtEstval1.Text = temp8

                End If

            Next

        End If
        '  End If
    End Sub

    Private Sub Txtbpay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtAcidt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAcidt.TextChanged
        idno = Mid(Trim(LstId.SelectedValue), 1, (Len(Trim(LstId.SelectedValue)) - 4))
        idno = Trim(idno)
        s1 = TxtAcidt.Text
        s2 = LstId.SelectedValue

        s3 = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)
        ADA = New SqlDataAdapter("SELECT * FROM VehClaim WHERE Veh_no = '" & idno & "' AND Veh_AccDt = '" & s3 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehClaim")
        Dim val1, val2, val3 As Double
        Count = DS.Tables("VehClaim").Rows.Count
        TxtEstval1.Text = Space(20)
        TxtEstval2.Text = Space(20)
        TxtEstval3.Text = Space(20)

        If Count <> 0 Then

            For Each Dtr1 In DS.Tables("VehClaim").Rows
                val1 = Dtr1("Veh_InvVal1")
                val2 = Dtr1("Veh_InvVal2")
                val3 = Dtr1("Veh_InvVal3")
                TxtEstval1.Text = Right(Space(20) + Format(val1, "###,###.##"), 20)
                TxtEstval2.Text = Right(Space(20) + Format(val2, "###,###.##"), 20)
                TxtEstval3.Text = Right(Space(20) + Format(val3, "###,###.##"), 20)
                TxtVehClNo.Text = IIf((IsDBNull("Veh_ClNo")), " ", Dtr1("Veh_Clno"))
            Next
            BtnAdd.Enabled = False

        Else
            BtnAdd.Enabled = True
            com = Mid(LstCom.Text, 1, 3)
            dt3 = Mid(TxtAcidt.Text, 7, 4)

            ADA = New SqlDataAdapter("SELECT * FROM AccdentNo WHERE Acc_com = '" & com & "' AND Acc_Yr='" & dt3 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "AccdentNo")

            Count = DS.Tables("AccdentNo").Rows.Count
            If Count <> 0 Then
                For Each Dtr1 In DS.Tables("AccdentNo").Rows
                    AccNo = Dtr1("Acc_no")
                Next
            Else

                AccNo = 1
            End If

            TxtVehClNo.Text = com + "/" + dt3 + "/" + Format(AccNo, "0000")

        End If

    End Sub

    Private Sub TxtpayTdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dtdiff As Integer


        typ = Trim(Lsttyp.Text)


        ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & typ & "'", CON)
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
                If Trim(TxtEstval1.Text) = "" Then

                Else
                    Tfdt = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)

                    dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                    Temp1 = Space(25)
                    Temp2 = Space(25)
                    temp3 = Space(25)
                    temp4 = Space(25)
                    temp5 = Space(25)
                    temp6 = Space(25)
                    temp7 = Space(25)
                    temp8 = Space(25)



                    Temp1 = Temp1 + Format((TxtEstval1.Text * Val(pay2) / 100), "###,###,###.##")
                    Temp1 = Right(Temp1, 25)


                    Temp2 = Temp2 + Format((TxtEstval1.Text * Val(pay3) / 100), "###,###,###.##")
                    Temp2 = Right(Temp2, 25)


                    temp3 = temp3 + Format((TxtEstval1.Text * Val(pay5) / 100), "###,###,###.##")
                    temp3 = Right(temp3, 25)



                    If dtdiff = 366 Then
                        dtdiff = dtdiff - 1
                    Else
                        If dtdiff = 364 Then
                            dtdiff = dtdiff + 1
                        End If

                    End If




                    temp4 = temp4 + Format(pay1, "###,###,###.##")
                    temp4 = Right(temp4, 25)



                    Dim Tpay As Double
                    'pay1 = pay1 / 365 * (dtdiff )
                    'Tpay = Round(((TxtEstval1.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1
                    Tpay = ((TxtEstval1.Text * Val(pay2) / 100) + (TxtEstval1.Text * Val(pay3) / 100) + (TxtEstval1.Text * Val(pay5) / 100) - pay1)




                    temp5 = temp5 + Format((Tpay), "###,###,###.##")
                    temp5 = Right(temp5, 25)



                    temp6 = Right(temp6, 25)



                    temp7 = Right(temp7, 25)

                    temp8 = temp8 + Format(Round(TxtEstval1.Text, 2), "###,###,###.##")
                    temp8 = Right(temp8, 25)
                    TxtEstval1.Text = temp8


                End If

            Next

        End If
    End Sub

    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function



    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' idno = Trim(TxtId.Text)


        ADA = New SqlDataAdapter("SELECT * FROM VEHMAST WHERE VEH_NO = '" & idno & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VEHMAST")

        Count = DS.Tables("VEHMAST").Rows.Count
        Dim dr1, dr2 As DataRow
        Dim pppp As String

        If Count <> 0 Then

            LbLMsg.Text = "Record Already Exist !"

            For Each dr1 In DS.Tables("VEHMAST").Rows

                ' Lstcom.text = dr1("Veh_Com")
                Lsttyp.Text = dr1("Veh_Typ")

                Dim dt1, dt2, dt3 As String
                dt1 = Format(Day(CDate(dr1("Veh_Efdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Efdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Efdt")))

                TxtAcidt.Text = dt2 + "/" + dt1 + "/" + dt3

                dt1 = Format(Day(CDate(dr1("Veh_Exdt"))), "00")
                dt2 = Format(Month(CDate(dr1("Veh_Exdt"))), "00")
                dt3 = Year(CDate(dr1("Veh_Exdt")))


                Dim dtdiff As Integer

                typ = dr1("Veh_Typ")
                TxtEstval1.Text = dr1("Veh_Val")
                TxtEstval1.Enabled = False

                TxtAcidt.Enabled = False

                ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & typ & "'", CON)
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
                        If Trim(TxtEstval1.Text) = "" Then

                        Else
                            LbLMsg.Text = "                       "

                            Tfdt = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)

                            dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))

                            Temp1 = Space(25)
                            Temp2 = Space(25)
                            temp3 = Space(25)
                            temp4 = Space(25)
                            temp5 = Space(25)
                            temp6 = Space(25)
                            temp7 = Space(25)
                            temp8 = Space(25)



                            Temp1 = Temp1 + Format((TxtEstval1.Text * Val(pay2) / 100), "###,###,###.##")
                            Temp1 = Right(Temp1, 25)


                            Temp2 = Temp2 + Format((TxtEstval1.Text * Val(pay3) / 100), "###,###,###.##")
                            Temp2 = Right(Temp2, 25)


                            temp3 = temp3 + Format((TxtEstval1.Text * Val(pay5) / 100), "###,###,###.##")
                            temp3 = Right(temp3, 25)



                            If dtdiff = 366 Then
                                dtdiff = dtdiff - 1
                            Else
                                If dtdiff = 364 Then
                                    dtdiff = dtdiff + 1
                                End If

                            End If


                            temp4 = temp4 + Format(pay1, "###,###,###.##")
                            temp4 = Right(temp4, 25)



                            Dim Tpay As Double
                            'pay1 = pay1 / 365 * (dtdiff )
                            'Tpay = Round(((TxtEstval1.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                            Tpay = ((TxtEstval1.Text * Val(pay2) / 100) + (TxtEstval1.Text * Val(pay3) / 100) + (TxtEstval1.Text * Val(pay5) / 100) - pay1)




                            temp5 = temp5 + Format((Tpay), "###,###,###.##")
                            temp5 = Right(temp5, 25)



                            temp6 = Right(temp6, 25)


                            temp7 = Right(temp7, 25)


                            temp8 = temp8 + Format(Round(TxtEstval1.Text, 2), "###,###,###.##")
                            temp8 = Right(temp8, 25)
                            TxtEstval1.Text = temp8

                        End If

                    Next

                End If

                'Txtbpay.Text = dr1("Emp_TaLv")
                'TxtEstval1.Text = dr1("Emp_CntNo")
                'Txtrcc.Text = dr1("Emp_email")
                'Txttr.Text = dr1("Emp_des")
            Next

            Exit Sub

        Else

            TxtEstval1.Text = ""

            TxtAcidt.Text = ""


            TxtEstval1.Enabled = True

            TxtAcidt.Enabled = True

        End If

    End Sub

    Private Sub TxtPPre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dtdiff As Integer

        typ = Trim(Lsttyp.Text)
        pos1 = "Y"

        ADA = New SqlDataAdapter("SELECT * FROM VEHTYPMAST WHERE VEH_TYPE = '" & typ & "'", CON)
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

                Tfdt = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)

                dtdiff = DateDiff(DateInterval.Day, CDate(Tfdt), CDate(Ttdt))


                Temp1 = Space(25)
                Temp2 = Space(25)
                temp3 = Space(25)
                temp4 = Space(25)
                temp5 = Space(25)
                temp6 = Space(25)
                temp7 = Space(25)
                temp8 = Space(25)


                Temp1 = Temp1 + Format((TxtEstval1.Text * Val(pay2) / 100), "###,###,###.##")
                Temp1 = Right(Temp1, 25)

                Temp2 = Temp2 + Format((TxtEstval1.Text * Val(pay3) / 100), "###,###,###.##")
                Temp2 = Right(Temp2, 25)

                temp3 = temp3 + Format((TxtEstval1.Text * Val(pay5) / 100), "###,###,###.##")
                temp3 = Right(temp3, 25)

                If dtdiff = 366 Then
                    dtdiff = dtdiff - 1
                Else
                    If dtdiff = 364 Then
                        dtdiff = dtdiff + 1
                    End If

                End If


                temp4 = temp4 + Format(pay1, "###,###,###.##")
                temp4 = Right(temp4, 25)



                Dim Tpay As Double
                'pay1 = pay1 / 365 * (dtdiff )
                'Tpay = Round(((TxtEstval1.Text * Val(pay2) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay3) / 100) / 365) * (dtdiff ), 2) + Round(((TxtEstval1.Text * Val(pay5) / 100) / 365) * (dtdiff ), 2) - pay1

                Tpay = ((TxtEstval1.Text * Val(pay2) / 100) + (TxtEstval1.Text * Val(pay3) / 100) + (TxtEstval1.Text * Val(pay5) / 100) - pay1)




                temp5 = temp5 + Format((Tpay), "###,###,###.##")
                temp5 = Right(temp5, 25)


                temp6 = Right(temp6, 25)



                temp7 = Right(temp7, 25)


                temp8 = temp8 + Format(Round(TxtEstval1.Text, 2), "###,###,###.##")
                temp8 = Right(temp8, 25)
                TxtEstval1.Text = temp8

            Next

        End If
    End Sub


    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtn1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TxtAcidt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        idno = Mid(Trim(LstId.SelectedValue), 1, (Len(Trim(LstId.SelectedValue)) - 4))
        idno = Trim(idno)


        s1 = TxtAcidt.Text
        s2 = LstId.SelectedValue

        s3 = Mid(Trim(TxtAcidt.Text), 4, 2) + "/" + Mid(Trim(TxtAcidt.Text), 1, 2) + "/" + Mid(Trim(TxtAcidt.Text), 7, 4)
        Calendar1.Visible = False
        ADA = New SqlDataAdapter("SELECT * FROM VehClaim WHERE Veh_no = '" & idno & "' AND Veh_AccDt = '" & s3 & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "VehClaim")

        Count = DS.Tables("VehClaim").Rows.Count
        TxtEstval1.Text = Space(20)
        TxtEstval2.Text = Space(20)
        TxtEstval3.Text = Space(20)



        If Count <> 0 Then

            For Each Dtr1 In DS.Tables("VehClaim").Rows
                val1 = Dtr1("Veh_InvVal1")
                val2 = Dtr1("Veh_InvVal2")
                val3 = Dtr1("Veh_InvVal3")
                TxtEstval1.Text = Right(Space(20) + Format(val1, "###,###.##"), 20)
                TxtEstval2.Text = Right(Space(20) + Format(val2, "###,###.##"), 20)
                TxtEstval3.Text = Right(Space(20) + Format(val3, "###,###.##"), 20)
                TxtVehClNo.Text = IIf((IsDBNull("Veh_ClNo")), " ", Dtr1("Veh_Clno"))
            Next
            BtnAdd.Enabled = False

        Else
            BtnAdd.Enabled = True
            com = Mid(LstCom.Text, 1, 3)
            dt3 = Mid(TxtAcidt.Text, 7, 4)

            ADA = New SqlDataAdapter("SELECT * FROM AccdentNo WHERE Acc_com = '" & com & "' AND Acc_Yr='" & dt3 & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "AccdentNo")

            Count = DS.Tables("AccdentNo").Rows.Count
            If Count <> 0 Then
                For Each Dtr1 In DS.Tables("AccdentNo").Rows
                    AccNo = Dtr1("Acc_no")
                Next
            Else

                AccNo = 1
            End If

            TxtVehClNo.Text = com + "/" + dt3 + "/" + Format(AccNo, "0000")

        End If
    End Sub

    Private Sub TxtEstval2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEstval2.TextChanged
        TxtEstval2.Text = Right(Space(20) + Format(Val(TxtEstval2.Text), "###,###.##"), 20)
    End Sub

    Private Sub TxtEstval3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEstval3.TextChanged
        TxtEstval3.Text = Right(Space(20) + Format(Val(TxtEstval3.Text), "###,###.##"), 20)
    End Sub

    Private Sub ImgBtn1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtn1.Click
        Calendar1.Visible = True
    End Sub
End Class
