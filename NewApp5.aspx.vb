Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class NewApp5
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


    Dim TT As String
    Protected WithEvents LstFlag2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents LstFulTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVehTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents LstItmNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtSumIns As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstTT As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents LstBTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents LstETyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstPtyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstYtyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents LstBdtp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstMdTyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents LstFtyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CheckBox2 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CheckBox3 As System.Web.UI.WebControls.CheckBox


    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init


    End Sub


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        'L1.Text = USER11

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        pflag = "N"

        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")


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


        If Not IsPostBack Then
            CMD = New SqlCommand("SELECT DISTINCT Veh_Typ From VehQ1 ", CON)
            DR = CMD.ExecuteReader
            LstVehTyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstVehTyp.Items.Add(TT)
            End While
            DR.Close()


            CMD = New SqlCommand("SELECT DISTINCT Veh_Brd From VehQ1 where Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "'", CON)

            DR = CMD.ExecuteReader
            LstBdtp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstBdtp.Items.Add(TT)
            End While
            DR.Close()


            ss = "SELECT DISTINCT Veh_mdl From VehQ1 where Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'"





            CMD = New SqlCommand("SELECT DISTINCT Veh_mdl From VehQ1 where Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

            DR = CMD.ExecuteReader
            LstMdTyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstMdTyp.Items.Add(TT)
            End While
            DR.Close()





            CMD = New SqlCommand("SELECT DISTINCT Veh_Etp  From VehQ1 where Veh_Ftp='" & Trim(LstFulTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

            DR = CMD.ExecuteReader
            LstETyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstETyp.Items.Add(TT)
            End While
            DR.Close()

            CMD = New SqlCommand("SELECT DISTINCT Veh_Ftp  From VehQ1 where Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

            DR = CMD.ExecuteReader
            LstFulTyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstFulTyp.Items.Add(TT)
            End While
            DR.Close()

            CMD = New SqlCommand("SELECT DISTINCT Veh_Etp  From VehQ1 where Veh_Ftp='" & Trim(LstFulTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

            DR = CMD.ExecuteReader
            LstETyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstETyp.Items.Add(TT)
            End While
            DR.Close()




        End If

        If Not IsPostBack Then

            CMD = New SqlCommand("SELECT DISTINCT Veh_RgTyp From VehQ2 ", CON)

            DR = CMD.ExecuteReader
            LstYtyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstYtyp.Items.Add(TT)
            End While
            DR.Close()

        End If

        If Not IsPostBack Then

            CMD = New SqlCommand("SELECT DISTINCT Veh_Ftyp From VehQ3 ", CON)

            DR = CMD.ExecuteReader
            LstPtyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstPtyp.Items.Add(TT)
            End While
            DR.Close()
        End If

        If Not IsPostBack Then

            CMD = New SqlCommand("SELECT DISTINCT Veh_BTyp From VehQ4 order by Veh_BTyp", CON)

            DR = CMD.ExecuteReader
            LstBTyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstBTyp.Items.Add(TT)
            End While
            DR.Close()

        End If

        If Not IsPostBack Then

            CMD = New SqlCommand("SELECT DISTINCT Veh_Typ From VehQ6 order by Veh_Typ", CON)

            DR = CMD.ExecuteReader
            LstFtyp.Items.Clear()
            While DR.Read
                'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                TT = DR.GetValue(0)
                LstFtyp.Items.Add(TT)
            End While
            DR.Close()

        End If
    End Sub
    Public Sub BindTheGrid()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))

        ' CON.Open()


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Vwh_des as Veh_des,Veh_Rate1,Veh_Rate2, Veh_Rate3,Veh_Rate4,Veh_Rate5,Veh_Rate6 from VehQ5", CON)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()

    End Sub
    Private Sub LstVehTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVehTyp.SelectedIndexChanged
        LstFulTyp.Enabled = True
        LstBTyp.Enabled = True
        LstBdtp.Enabled = True
        LstFulTyp.Enabled = True
        LstETyp.Enabled = True
        LstPtyp.Enabled = True
        LstYtyp.Enabled = True

        'If Not IsPostBack Then

        CMD = New SqlCommand("SELECT DISTINCT Veh_Brd From VehQ1 where Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "'", CON)

        DR = CMD.ExecuteReader
        LstBdtp.Items.Clear()
        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            TT = DR.GetValue(0)
            LstBdtp.Items.Add(TT)
        End While
        DR.Close()


        'End If

    End Sub

    Private Sub LstBdtp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBdtp.SelectedIndexChanged
        LstFulTyp.Enabled = True
        LstBTyp.Enabled = True
        LstBdtp.Enabled = True
        LstFulTyp.Enabled = True
        LstETyp.Enabled = True
        LstPtyp.Enabled = True
        LstYtyp.Enabled = True

        'If Not IsPostBack Then

        CMD = New SqlCommand("SELECT DISTINCT Veh_mdl From VehQ1 where Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

        DR = CMD.ExecuteReader
        LstMdTyp.Items.Clear()
        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            TT = DR.GetValue(0)
            LstMdTyp.Items.Add(TT)
        End While
        DR.Close()
    End Sub

    Private Sub InitializeComponent()

    End Sub

    Private Sub LstMdTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstMdTyp.SelectedIndexChanged

        LstFulTyp.Enabled = True
        LstBTyp.Enabled = True
        LstBdtp.Enabled = True
        LstFulTyp.Enabled = True
        LstETyp.Enabled = True
        LstPtyp.Enabled = True
        LstYtyp.Enabled = True

        'If Not IsPostBack Then

        CMD = New SqlCommand("SELECT DISTINCT Veh_Ftp  From VehQ1 where Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

        DR = CMD.ExecuteReader
        LstFulTyp.Items.Clear()
        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            TT = DR.GetValue(0)
            LstFulTyp.Items.Add(TT)
        End While
        DR.Close()

        CMD = New SqlCommand("SELECT DISTINCT Veh_Etp  From VehQ1 where Veh_Ftp='" & Trim(LstFulTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

        DR = CMD.ExecuteReader
        LstETyp.Items.Clear()
        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            TT = DR.GetValue(0)
            LstETyp.Items.Add(TT)
        End While
        DR.Close()

    End Sub

    Private Sub LstFulTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFulTyp.SelectedIndexChanged
        LstFulTyp.Enabled = True
        LstBTyp.Enabled = True
        LstBdtp.Enabled = True
        LstFulTyp.Enabled = True
        LstETyp.Enabled = True
        LstPtyp.Enabled = True
        LstYtyp.Enabled = True

        'If Not IsPostBack Then

        CMD = New SqlCommand("SELECT DISTINCT Veh_Etp  From VehQ1 where Veh_Ftp='" & Trim(LstFulTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

        DR = CMD.ExecuteReader
        LstETyp.Items.Clear()
        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            TT = DR.GetValue(0)
            LstETyp.Items.Add(TT)
        End While
        DR.Close()

    End Sub

    Private Sub TxtSumIns_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSumIns.TextChanged
        Dim rat1, rat2, rat3, rat4, rat5, rat6 As Double
        Dim pay1, pay2, pay3, pay4, pay5, pay6 As Double
        Dim pay11, pay22, pay33, pay44, pay55, pay66 As Double
        Dim pay111, pay222, pay333, pay444, pay555, pay666 As Double

        CMD = New SqlCommand("SELECT  Veh_Rat1, Veh_Rat2, Veh_Rat3, Veh_Rat4, Veh_Rat5, Veh_Rat6 FROM VehQ1 where Veh_Etp='" & Trim(LstETyp.SelectedValue) & "' AND Veh_Ftp='" & Trim(LstFulTyp.SelectedValue) & "' AND Veh_mdl='" & Trim(LstMdTyp.SelectedValue) & "' AND Veh_Typ='" & Trim(LstVehTyp.SelectedValue) & "' and Veh_Brd='" & Trim(LstBdtp.SelectedValue) & "'", CON)

        DR = CMD.ExecuteReader

        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            rat1 = DR.GetValue(0)
            rat2 = DR.GetValue(1)
            rat3 = DR.GetValue(2)
            rat4 = DR.GetValue(3)
            rat5 = DR.GetValue(4)
            rat6 = DR.GetValue(5)

        End While
        DR.Close()

        pay1 = Round(Val(TxtSumIns.Text) * rat1 / 100, 2)
        pay2 = Round(Val(TxtSumIns.Text) * rat2 / 100, 2)
        pay3 = Round(Val(TxtSumIns.Text) * rat3 / 100, 2)
        pay4 = Round(Val(TxtSumIns.Text) * rat4 / 100, 2)
        pay5 = Round(Val(TxtSumIns.Text) * rat5 / 100, 2)
        pay6 = Round(Val(TxtSumIns.Text) * rat6 / 100, 2)



        pay11 = Round(Val(TxtSumIns.Text) * 0.2 / 100, 2)
        pay22 = Round(Val(TxtSumIns.Text) * 0.2 / 100, 2)
        pay33 = Round(Val(TxtSumIns.Text) * 0.2 / 100, 2)
        pay44 = Round(Val(TxtSumIns.Text) * 0.2 / 100, 2)
        pay55 = Round(Val(TxtSumIns.Text) * 0.2 / 100, 2)
        pay66 = Round(Val(TxtSumIns.Text) * 0.2 / 100, 2)


        pay111 = Round(Val(TxtSumIns.Text) * 0.05 / 100, 2)
        pay222 = Round(Val(TxtSumIns.Text) * 0.05 / 100, 2)
        pay333 = Round(Val(TxtSumIns.Text) * 0.05 / 100, 2)
        pay444 = Round(Val(TxtSumIns.Text) * 0.05 / 100, 2)
        pay555 = Round(Val(TxtSumIns.Text) * 0.05 / 100, 2)
        pay666 = Round(Val(TxtSumIns.Text) * 0.05 / 100, 2)




        Dim DeleteCmd As String = "DELETE from VehQ5"
        Dim Cmd1 As New SqlCommand(DeleteCmd, CON)
        Cmd1.ExecuteNonQuery()
        Cmd1 = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = Cmd1.ExecuteReader
        DR1.Close()



        CMD.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        ss = "INSERT INTO VehQ5(Vwh_des,Veh_Rate1,Veh_Rate2,Veh_Rate3,Veh_Rate4,Veh_Rate5,Veh_Rate6) VALUES ('Srcc ..','" & pay1 & "','" & pay2 & "','" & pay3 & "','" & pay4 & "','" & pay5 & "','" & pay6 & "')"

        CMD.CommandText = ("INSERT INTO VehQ5(Vwh_des,Veh_Rate1,Veh_Rate2,Veh_Rate3,Veh_Rate4,Veh_Rate5,Veh_Rate6) VALUES ('Basic ..'," & pay1 & "," & pay2 & "," & pay3 & "," & pay4 & "," & pay5 & "," & pay6 & ")")
        CMD.ExecuteNonQuery()

        CMD.CommandText = ("INSERT INTO VehQ5(Vwh_des,Veh_Rate1,Veh_Rate2,Veh_Rate3,Veh_Rate4,Veh_Rate5,Veh_Rate6) VALUES ('SRCC ..'," & pay11 & "," & pay22 & "," & pay33 & "," & pay44 & "," & pay55 & "," & pay66 & ")")
        CMD.ExecuteNonQuery()


        CMD.CommandText = ("INSERT INTO VehQ5(Vwh_des,Veh_Rate1,Veh_Rate2,Veh_Rate3,Veh_Rate4,Veh_Rate5,Veh_Rate6) VALUES ('TC ..'," & pay111 & "," & pay222 & "," & pay333 & "," & pay444 & "," & pay555 & "," & pay666 & ")")
        CMD.ExecuteNonQuery()


        BindTheGrid()





    End Sub

    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function



    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
