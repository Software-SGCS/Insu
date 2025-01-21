Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Public Class PrettyCashAdd
    Inherits System.Web.UI.Page
    Dim CON, CON1 As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1, DS2 As DataSet
    Dim DV As DataView
    Dim sinvno As String
    Dim LOD, body As String
    Dim dt1 As Date
    Dim drt2, drt3, drt1 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim SS As String
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim q, r, s As String
    Dim p, t As Double
    Dim InvFlag2 As String
    Dim count1, count, count2, count3, i, j As Integer
    Dim depno As String
    Dim depname As String
    Dim S1(10) As String
    Dim epfno As String

    Protected WithEvents BtnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Protected WithEvents TxtInvNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents LstCode As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents LstFlag2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtPer As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents BtnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtLInvNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstTT As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Lstvat1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDatagrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Deplist As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents txtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BttEmpNo As System.Web.UI.WebControls.Button
    Protected WithEvents TxtEpfNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDepNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtDes As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents Label26 As System.Web.UI.WebControls.Label
    Protected WithEvents Label27 As System.Web.UI.WebControls.Label
    Protected WithEvents Label28 As System.Web.UI.WebControls.Label
    Protected WithEvents Label29 As System.Web.UI.WebControls.Label
    Protected WithEvents Label30 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtQ1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label31 As System.Web.UI.WebControls.Label
    Protected WithEvents Label32 As System.Web.UI.WebControls.Label
    Protected WithEvents BtnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents BttNext As System.Web.UI.WebControls.Button
    Protected WithEvents TxtQ6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQ11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtDepNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtCom As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtEmpNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Datagrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Q1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Q11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtAmt1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TQ1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ7 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ8 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ9 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ10 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TQ11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTQVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtTQVal1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQVal1 As System.Web.UI.WebControls.TextBox
    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtInvDt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Lstcom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstInvNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtPoNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label

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
        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()



        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else
            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='Outword.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then

        Else
            ' Response.Redirect("InsuDept.aspx")
        End If



        CMD = New SqlCommand("SELECT Emp_No,Emp_Nam,Emp_depno from EmpAdmin order by Emp_No", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                Lstcom.Items.Add(TT)
            End While
        End If




        DR.Close()
        CMD = New SqlCommand("SELECT Out_Vno From OutWord where id =(select max(id) from OutWord)", CON1)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0)
                LstInvNo.Items.Add(TT)
                TxtLInvNo.Text = DR.GetValue(0)
            End While
        End If
        DR.Close()


        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='04' order by Sys_rno", CON)


        DR = CMD.ExecuteReader


        If Not IsPostBack Then
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                Deplist.Items.Add(TT)
            End While
        End If
        DR.Close()






        If Not IsPostBack Then
            TxtInvDt.Text = Format(Today(), "dd/MM/yyyy")
            CON1 = New SqlConnection
            CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
            CON1.Open()

            CMD = New SqlCommand("SELECT sum(Out_Amt) as PayAmt from Outword where Out_flg='N'", CON1)

            DR = CMD.ExecuteReader
            While DR.Read



                Try
                    TT = DR.GetValue(0)
                Catch ex As Exception
                    TT = "0"
                End Try

            End While
            DR.Close()

            Dim Cmd1 As New SqlCommand("SELECT * FROM SignCash", CON1)
            Cmd1.ExecuteNonQuery()

            count = 0

            ADA = New SqlDataAdapter("SELECT * FROM SignCash where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

            DS = New DataSet
            ADA.Fill(DS, "SignCash")

            count = DS.Tables("SignCash").Rows.Count



            ADA = New SqlDataAdapter("SELECT  Imp_Com,Imp_Amt,Imp_Pay from Imprest", CON1)

            DS = New DataSet
            ADA.Fill(DS, "Imprest")

            count1 = DS.Tables("Imprest").Rows.Count

            count3 = 0
            ADA = New SqlDataAdapter("SELECT  * from CashBox where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

            DS1 = New DataSet
            ADA.Fill(DS1, "CashBox")

            count3 = DS1.Tables("CashBox").Rows.Count

            ADA = New SqlDataAdapter("SELECT  Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Qtyp,C_Date from CashInBox", CON1)

            DS1 = New DataSet
            ADA.Fill(DS1, "CashInBox")

            count2 = DS1.Tables("CashInBox").Rows.Count



            If count = 0 Then
                If count1 <> 0 Then

                    For Each drt2 In DS.Tables("Imprest").Rows
                        ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"


                        Cmd1.CommandText = ("INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                        Cmd1.ExecuteNonQuery()

                        '-----------

                        Cmd1.CommandText = ("INSERT INTO SignCashEnd(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                        Cmd1.ExecuteNonQuery()

                    Next





                End If

                If count2 <> 0 Then

                    For Each drt1 In DS1.Tables("CashInBox").Rows
                        ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"

                        If count3 = 0 Then
                            Cmd1.CommandText = ("INSERT INTO CashBox(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Pen_Amt,C_Date,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt1("Q1") & "'," & drt1("Q2") & "," & drt1("Q3") & "," & drt1("Q4") & "," & drt1("Q5") & "," & drt1("Q6") & "," & drt1("Q7") & "," & drt1("Q8") & "," & drt1("Q9") & "," & drt1("Q10") & "," & drt1("Q11") & "," & Val(TT) & ",'" & drt1("C_Date") & "','1')")
                            Cmd1.ExecuteNonQuery()
                        End If
                        '-----------
                    Next
                End If
            End If




            CON = New SqlConnection
            CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
            CON.Open()


            ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "'", CON)
            DS = New DataSet
            ADA.Fill(DS, "EmpAdmin")

            SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
            CMD = New SqlCommand("SELECT Emp_DepNo FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "'", CON)


            DR = CMD.ExecuteReader


            'If Not IsPostBack Then
            While DR.Read
                depno = DR.GetValue(0)
                'LstTyp.Items.Add(TT)
            End While
            'End If
            DR.Close()


            'count1 = DS.Tables("EmpAdmin").Rows.Count
            'If count1 <> 0 Then
            '    For Each DR1 In DS.Tables("EmpAdmin").Rows
            '        depno = DR1("Emp_dep")

            '    Next
            'End If

            TxtInvDt.Text = Format(Today(), "dd/MM/yyyy")




            CMD = New SqlCommand("SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'", CON)
            SS = "SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'"

            DR = CMD.ExecuteReader

            depname = "Other"
            'If Not IsPostBack Then
            While DR.Read
                depname = DR.GetValue(0)
                'LstTyp.Items.Add(TT)
            End While
            'End If
            DR.Close()


            Deplist.SelectedItem.Text = depno + " - " + depname

            BindTheGrid1()
            BindTheGrid2()
            BindTheGrid()
            BindTheGrid3()
        End If

    End Sub
    Public Sub BindTheGrid()
        'Dim objConn As con = New con(ConfigurationSettings.AppSettings("ConnectionString"))

        ' CON.Open()

        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()
        Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        epfno = Trim(S1(0))


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Imp_Com,REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Imp_Amt),1), '','') as Imp_Amt,REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Imp_Pay),1), '','') as Imp_Pay from Imprest", CON1)



        SS = "Select id,Com,Imp_Amt, Imp_Pay from Imprest"
        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        MyDatagrid1.DataSource = cmdCustomers.ExecuteReader()
        MyDatagrid1.DataBind()
        CON.Close()

    End Sub

    Public Sub BindTheGrid1()

        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()
        SS = "Select a.id as id,a.Out_Vno as Out_Vno ,b.Emp_no as Emp_no , b.Emp_Nam as Emp_Nam , b.Emp_Dep as Emp_Dep, b.Emp_Com as Emp_Com,a.Out_Amt as Out_Amt from OutWord a,Employee b where a.Out_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "' and a.Out_Eno=b.Emp_no"

        ' Dim cmdCustomers As SqlCommand = New SqlCommand("Select a.id as id,a.Out_Vno as Out_Vno ,b.Emp_no as Emp_no , b.Emp_Nam as Emp_Nam , b.Emp_Dep as Emp_Dep, b.Emp_Com as Emp_Com,a.Out_Amt as Out_Amt from OutWord a,Employee b where (a.Out_Eno=b.Emp_no) and a.Out_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,CONVERT(VARCHAR(10),Cash_Dt,103) As Cash_Dt,Ref,Cash_Time ,Q1 , Q2 , Q3, Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Amt),1), '','') as Amt from AddCash order by id", CON1)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid1.DataSource = cmdCustomers.ExecuteReader()
        Datagrid1.DataBind()
        CON1.Close()
    End Sub

    Public Sub BindTheGrid3()

        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()
        CMD = New SqlCommand("SELECT Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11 From CashInBox where Qtyp='1'", CON1)

        'CMD = New SqlCommand("SELECT Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11 From CashInBox", CON1)
        DR = CMD.ExecuteReader


        ' If Not IsPostBack Then
        While DR.Read
            'TT = DR.GetValue(0)
            Q1.Text = DR.GetValue(0)
            Q2.Text = DR.GetValue(1)
            Q3.Text = DR.GetValue(2)
            Q4.Text = DR.GetValue(3)
            Q5.Text = DR.GetValue(4)
            Q6.Text = DR.GetValue(5)
            Q7.Text = DR.GetValue(6)
            Q8.Text = DR.GetValue(7)
            Q9.Text = DR.GetValue(8)
            Q10.Text = DR.GetValue(9)
            Q11.Text = DR.GetValue(10)

            TxtQVal.Text = (Val(Q1.Text) * 5000) + (Val(Q2.Text) * 2000) + (Val(Q3.Text) * 1000) + (Val(Q4.Text) * 500) + (Val(Q5.Text) * 100) + (Val(Q6.Text) * 50) + (Val(Q7.Text) * 20) + (Val(Q8.Text) * 10) + (Val(Q9.Text) * 5) + (Val(Q10.Text) * 2) + (Val(Q11.Text) * 1)
            TxtQVal1.Text = TxtQVal.Text
            TxtQVal.Text = "      " + Format(Val(TxtQVal.Text), "###,###,###.00")
        End While
        'End If
        DR.Close()
    End Sub
    Public Sub BindTheGrid2()
        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()
        SS = "Select a.id as id,a.Out_Vno as Out_Vno ,b.Emp_no as Emp_no , b.Emp_Nam as Emp_Nam , b.Emp_Dep as Emp_Dep, b.Emp_Com as Emp_Com,a.Out_Amt as Out_Amt from OutWord a,Employee b where a.Out_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "' and a.Out_Eno=b.Emp_no"

        ' Dim cmdCustomers As SqlCommand = New SqlCommand("Select a.id as id,a.Out_Vno as Out_Vno ,b.Emp_no as Emp_no , b.Emp_Nam as Emp_Nam , b.Emp_Dep as Emp_Dep, b.Emp_Com as Emp_Com,a.Out_Amt as Out_Amt from OutWord a,Employee b where (a.Out_Eno=b.Emp_no) and a.Out_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select  id,Out_Vno ,Out_Eno as Emp_no, REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Out_Amt),1), '','') as Out_Amt, Convert(Varchar(10),Out_Date,103) as Out_Date from OutWord where Out_Flg='Y'", CON1)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid2.DataSource = cmdCustomers.ExecuteReader()
        Datagrid2.DataBind()
        CON1.Close()
        ''ss= REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,Out_Amt),2), '.00','') as Out_Amt
    End Sub


    Public Function BindTheCountry()
        Dim strConn As String = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
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

    Public Sub dtgCustomers_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
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
        dtgCustomers.EditItemIndex = -1
        BindTheGrid1()
        dtgCustomers.Visible = True

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

    Public Sub SetDropDownIndex(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ed As System.Web.UI.WebControls.DropDownList
        ed = sender
        ed.SelectedIndex = ed.Items.IndexOf(ed.Items.FindByText(strCountry))
    End Sub
    Private Sub LstTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DR.Close()
        Dim TT1, tt2 As String
        'TT1 = Mid(LstTyp.SelectedValue, 1, 2)
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and substring(sys_des2,1,2)='" & TT1 & "'", CON)


        DR = CMD.ExecuteReader


        ' LstBrnd.Items.Clear()
        While DR.Read
            TT = DR.GetValue(0) + " " + DR.GetValue(1)
            'LstBrnd.Items.Add(TT)
        End While


        DR.Close()

        ' CRI1 = Mid(LstTyp.SelectedValue, 1, 2)
        ' CRI2 = Mid(LstCntry.SelectedValue, 1, 2)
        ' CRI3 = Mid(LstBrnd.SelectedValue, 1, 2)

        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk,Itm_dis From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        DR = CMD.ExecuteReader
        ' LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2
            '  LstItmNo.Items.Add(TT)
        End While
        ' End If

        DR.Close()
        BindTheGrid()
        BindTheGrid2()
    End Sub

    Private Sub LstBrnd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'CRI1 = Mid(LstTyp.SelectedValue, 1, 2)
        'CRI2 = Mid(LstCntry.SelectedValue, 1, 2)
        'CRI3 = Mid(LstBrnd.SelectedValue, 1, 2)

        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        DR = CMD.ExecuteReader
        ' LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2
            '   LstItmNo.Items.Add(TT)
        End While
        ' End If

        DR.Close()

        BindTheGrid()
        BindTheGrid2()

    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        Dim Sitmno As String
        Dim Sdes As String
        Dim Spri As Double
        Dim SQty As Double
        Dim SVal As Double

        'Sitmno = Mid(LstItmNo.SelectedValue, 1, 8)
        'Sdes = Mid(LstItmNo.SelectedValue, 10, 50)
        'Spri = Val(Mid(LstItmNo.SelectedValue, 62, 20))
        'SQty = Val(TxtQty.Text)
        SVal = SQty * Spri


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()



        ' If BtnEdit.Enabled = True Then
        CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        ' Else
        '    CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & TxtInvNo.Text & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        'End If

        CMD.ExecuteNonQuery()
        BindTheGrid1()

    End Sub

    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'MyDataGrid.EditItemIndex = e.Item.ItemIndex
        BindTheGrid1()
    End Sub
    Sub MyDataGrid_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        'MyDataGrid.EditItemIndex = -1
        BindTheGrid1()
    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        ''Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        ' Dim DeleteCmd As String = "DELETE from Inltemp Where id = @Id"
        ' 'Dim MyConn As New SqlConnection(CON)
        ' Dim Cmd As New SqlCommand(DeleteCmd, CON)
        ' Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        ''CON.Open()
        'Cmd.ExecuteNonQuery()
        ''CON.Close()
        'BindTheGrid1()
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
        'MyDataGrid.EditItemIndex = -1
        BindTheGrid1()
        'MyDataGrid.Visible = True

    End Sub

    Private Sub LstInvNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstInvNo.SelectedIndexChanged

        Dim Dtr, Dtr1 As DataRow

        CMD = New SqlCommand("SELECT * FROM SYSMAST", CON)
        DR1 = CMD.ExecuteReader
        DR1.Close()
        Dim stridt, strpono, strcom, strcomnam, strvat As String
        Dim Intstk As Integer
        ADA = New SqlDataAdapter("SELECT * FROM INHINV WHERE INV_NO = '" & LstInvNo.SelectedValue & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INHINV")

        For Each Dtr1 In DS.Tables("INHINV").Rows
            stridt = Format(Dtr1("Inv_dt"), "dd/MM/yyyy")
            strpono = Dtr1("Inv_pono")
            strcom = Dtr1("Inv_Com")
            strvat = Dtr1("Inv_vat")
        Next
        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & strcom & "' and Emp_com='SGC'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")
        For Each Dtr1 In DS.Tables("COMPANY").Rows
            strcomnam = Dtr1("Emp_nam")
        Next


        TxtPoNo.Text = strpono
        TxtInvDt.Text = stridt
        Lstcom.SelectedValue = strcom + " - " + strcomnam
        LstVat.SelectedValue = strvat


        ADA = New SqlDataAdapter("SELECT * FROM INLINV WHERE INV_NO = '" & LstInvNo.SelectedValue & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "INLINV1")
        Dim Count As Integer
        Dim strinvno, strinvitmno, strinvdes As String
        Dim strinvqty, strinvpri, strinvval As Double
        Dim tempstk As Double

        Count = DS.Tables("INLINV1").Rows.Count
        If Count <> 0 Then
            For Each Dtr In DS.Tables("INLINV1").Rows

                strinvno = Dtr("Inv_no")
                strinvitmno = Dtr("Inv_itmno")
                strinvpri = Dtr("Inv_pri")
                strinvval = Dtr("Inv_val")
                strinvqty = Dtr("Inv_qty")

                ADA = New SqlDataAdapter("SELECT * FROM ITMMAST WHERE ITM_NO = '" & strinvitmno & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "ITMMAST")
                Count = DS.Tables("ITMMAST").Rows.Count
                For Each Dtr1 In DS.Tables("ITMMAST").Rows
                    strinvdes = Dtr1("Itm_des")
                    Intstk = Dtr1("Itm_Stk")
                Next
                tempstk = (Val(Intstk) - Val(strinvqty))
                CMD.CommandText = ("INSERT INTO Inltemp (Inv_no,Inv_ItmNo,Inv_Qty,Inv_pr,Inv_val,Inv_des) VALUES ('" & LstInvNo.SelectedValue & "','" & strinvitmno & "','" & strinvqty & "','" & strinvpri & "','" & strinvval & "','" & strinvdes & "')")
                CMD.ExecuteNonQuery()

                'CMD.CommandText = ("UPDATE ITMMAST SET ITM_STK=" & tempstk & " WHERE Itm_no='" & strinvitmno & "'")
                'CMD.ExecuteNonQuery()

            Next
            BindTheGrid1()
            BindTheGrid()
            BindTheGrid2()
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        '--
        Dim Cmd1 As New SqlCommand("SELECT * FROM SignCash", CON1)
        Cmd1.ExecuteNonQuery()

        count = 0

        ADA = New SqlDataAdapter("SELECT * FROM SignCash where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

        DS = New DataSet
        ADA.Fill(DS, "SignCash")

        count = DS.Tables("SignCash").Rows.Count



        ADA = New SqlDataAdapter("SELECT  Imp_Com,Imp_Amt,Imp_Pay from Imprest", CON1)

        DS = New DataSet
        ADA.Fill(DS, "Imprest")

        count1 = DS.Tables("Imprest").Rows.Count

        count3 = 0
        ADA = New SqlDataAdapter("SELECT  * from CashBox where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

        DS1 = New DataSet
        ADA.Fill(DS1, "CashBox")

        count3 = DS1.Tables("CashBox").Rows.Count

        ADA = New SqlDataAdapter("SELECT  Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Qtyp,C_Date from CashInBox", CON1)

        DS1 = New DataSet
        ADA.Fill(DS1, "CashInBox")

        count2 = DS1.Tables("CashInBox").Rows.Count



        If count = 0 Then
            If count1 <> 0 Then

                For Each drt2 In DS.Tables("Imprest").Rows
                    ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"


                    Cmd1.CommandText = ("INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                    Cmd1.ExecuteNonQuery()

                    '-----------

                    Cmd1.CommandText = ("INSERT INTO SignCashEnd(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                    Cmd1.ExecuteNonQuery()

                Next





            End If

            If count2 <> 0 Then

                For Each drt1 In DS1.Tables("CashInBox").Rows
                    ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"

                    If count3 = 0 Then
                        Cmd1.CommandText = ("INSERT INTO CashBox(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Pen_Amt,C_Date,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt1("Q1") & "'," & drt1("Q2") & "," & drt1("Q3") & "," & drt1("Q4") & "," & drt1("Q5") & "," & drt1("Q6") & "," & drt1("Q7") & "," & drt1("Q8") & "," & drt1("Q9") & "," & drt1("Q10") & "," & drt1("Q11") & "," & Val(TT) & ",'" & drt1("C_Date") & "','1')")
                        Cmd1.ExecuteNonQuery()
                    End If
                    '-----------
                Next
            End If
        End If

        '--

        TxtQ1.ReadOnly = False
        TxtQ2.ReadOnly = False

        TxtQ3.ReadOnly = False
        TxtQ4.ReadOnly = False
        TxtQ5.ReadOnly = False
        TxtQ6.ReadOnly = False
        TxtQ7.ReadOnly = False
        TxtQ8.ReadOnly = False
        TxtQ9.ReadOnly = False


        TxtQ10.ReadOnly = False
        TxtQ11.ReadOnly = False


        'Ok1.Enabled = False

        ''BindTheGrid()

        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()

        SS = "SELECT Out_Vno From OutWord where ID =(select max(ID) from OutWord"
        Cmd1 = New SqlCommand("SELECT Out_Vno From OutWord where ID =(select max(ID) from OutWord)", CON1)


        DR = Cmd1.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            TT = DR.GetValue(0)
            LstInvNo.Items.Add(TT)
            TxtLInvNo.Text = DR.GetValue(0)
        End While
        'End If
        DR.Close()




        TxtQ1.Text = 0
        TxtQ2.Text = 0
        TxtQ3.Text = 0
        TxtQ4.Text = 0
        TxtQ5.Text = 0
        TxtQ6.Text = 0
        TxtQ7.Text = 0
        TxtQ8.Text = 0

        TxtQ9.Text = 0
        TxtQ10.Text = 0
        TxtQ11.Text = 0

        TxtDes.Text = ""

        LstInvNo.Visible = False
        LstInvNo.Enabled = False
        ' TxtInvNo.Visible = True
        TxtInvNo.Enabled = True
        TxtInvNo.Text = ""
        txtEmpNo.Text = 0
        TxtPoNo.Text = ""
        TxtAmt.Text = ""
        TxtAmt1.Text = ""
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM VoucherNo", CON1)
        DS = New DataSet
        ADA.Fill(DS, "VoucherNo")
        Dim ct As Integer
        ct = DS.Tables("VoucherNo").Rows.Count
        If ct <> 0 Then


            For Each drt2 In DS.Tables("VoucherNo").Rows

                Dim q, r, s As String
                Dim p As Double
                's = drt2("Inv_no")

                s = TxtLInvNo.Text
                'p = Val(drt2("Inv_no")) + 1
                p = Val(TxtLInvNo.Text) + 1
                q = Format(p, "0000000")


                TxtInvNo.Text = "" + q
            Next

        End If




        'If BtnEdit.Enabled = True Then
        'Else

        sinvno = Trim(TxtInvNo.Text)

        Dim Cmd11 As New SqlCommand("UPDATE VoucherNo SET Out_Vno='" & Trim(TxtInvNo.Text) & "'", CON1)
        Cmd11.ExecuteNonQuery()
        ' End If
        '


        'Dim DeleteCmd As String = "DELETE from Inltemp "
        'Dim MyConn As New SqlConnection(CON)
        'Dim Cmd As New SqlCommand(DeleteCmd, CON)
        'Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        CMD.ExecuteNonQuery()
        'CON.Close()
        BindTheGrid1()
        BindTheGrid3()
        BindTheGrid2()
        BindTheGrid()

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LstInvNo.Visible = True
        LstInvNo.Enabled = True
        TxtInvNo.Visible = False
        TxtInvNo.Enabled = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = False
        'BtnEdit.Enabled = False

    End Sub
    Public Function AllTrim(ByVal GeVar As String) As String
        Dim i As Integer
        Dim e As Integer
        Dim NewStr As String = ""
        e = Len(GeVar)
        For i = 1 To e
            If Mid(GeVar, i, 1) <> "-" Then
                NewStr = NewStr + Mid(GeVar, i, 1)
            Else
                i = e
            End If
        Next i
        AllTrim = Trim(NewStr)
        ' MsgBox("alltrim = " & NewStr)
    End Function

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim SS As String

        Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        epfno = Trim(txtEmpNo.Text)
        SS = "SELECT * FROM OutWord where Out_Vno='" & Trim(TxtInvNo.Text) & "'"
        ADA = New SqlDataAdapter("SELECT * FROM OutWord where Out_Vno='" & Trim(TxtInvNo.Text) & "'", CON1)
        DS = New DataSet
        ADA.Fill(DS, "OutWord")
        Dim ct As Integer
        ct = DS.Tables("OutWord").Rows.Count

        TxtQ1.ReadOnly = True
        TxtQ2.ReadOnly = True

        TxtQ3.ReadOnly = True
        TxtQ4.ReadOnly = True
        TxtQ5.ReadOnly = True
        TxtQ6.ReadOnly = True
        TxtQ7.ReadOnly = True
        TxtQ8.ReadOnly = True
        TxtQ9.ReadOnly = True


        TxtQ10.ReadOnly = True
        TxtQ11.ReadOnly = True

      



        ADA = New SqlDataAdapter("SELECT * FROM CashInBox where Qtyp='1'", CON1)
        DS = New DataSet
        ADA.Fill(DS, "CashInBox")
        ' Dim ct As Integer
        ct = DS.Tables("CashInBox").Rows.Count
        Dim q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11 As Integer
       

        CMD.Connection = CON1
        CMD.CommandText = ("UPDATE CashInBox SET Q1=" & Val(TQ1.Text) & ",Q2=" & Val(TQ2.Text) & ",Q3=" & Val(TQ3.Text) & ",Q4=" & Val(TQ4.Text) & ",Q5=" & Val(TQ5.Text) & ",Q6=" & Val(TQ6.Text) & ",Q7=" & Val(TQ7.Text) & ",Q8=" & Val(TQ8.Text) & ",Q9=" & Val(TQ9.Text) & ",Q10=" & Val(TQ10.Text) & ",Q11=" & Val(TQ11.Text) & ",C_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "' where Qtyp='1'")
        CMD.ExecuteNonQuery()





        ADA = New SqlDataAdapter("SELECT  Vou_Date from CashBoxEnd where Typ='1' and Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

        DS1 = New DataSet
        ADA.Fill(DS1, "CashBoxEnd")

        count2 = DS1.Tables("CashBoxEnd").Rows.Count

        If count2 = 0 Then

            SS = "INSERT INTO CashBoxEnd(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & Val(TQ1.Text) & "'," & Val(TQ2.Text) & "," & Val(TQ3.Text) & "," & Val(TQ4.Text) & "," & Val(TQ5.Text) & "," & Val(TQ6.Text) & "," & Val(TQ7.Text) & "," & Val(TQ8.Text) & "," & Val(TQ9.Text) & "," & Val(TQ10.Text) & "," & Val(TQ11.Text) & ",'1')"
            CMD.CommandText = ("INSERT INTO CashBoxEnd(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & Val(TQ1.Text) & "'," & Val(TQ2.Text) & "," & Val(TQ3.Text) & "," & Val(TQ4.Text) & "," & Val(TQ5.Text) & "," & Val(TQ6.Text) & "," & Val(TQ7.Text) & "," & Val(TQ8.Text) & "," & Val(TQ9.Text) & "," & Val(TQ10.Text) & "," & Val(TQ11.Text) & ",'1')")
            CMD.ExecuteNonQuery()
        Else
            CMD.CommandText = ("UPDATE CashBoxEnd SET Q1=" & Val(TQ1.Text) & ",Q2=" & Val(TQ2.Text) & ",Q3=" & Val(TQ3.Text) & ",Q4=" & Val(TQ4.Text) & ",Q5=" & Val(TQ5.Text) & ",Q6=" & Val(TQ6.Text) & ",Q7=" & Val(TQ7.Text) & ",Q8=" & Val(TQ8.Text) & ",Q9=" & Val(TQ9.Text) & ",Q10=" & Val(TQ10.Text) & ",Q11=" & Val(TQ11.Text) & ",typ='1' where Typ='1' and Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'")

            CMD.ExecuteNonQuery()
        End If   '-----------


        ' CMD1.CommandText = ("INSERT INTO CashBoxEnd(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & q1 & "'," & q2 & "," & q3 & "," & q4 & "," & q5 & "," & q6 & "," & q7 & "," & q8 & "," & q9 & "," & q10 & "," & q11 & "," & "','1')")




        SS = System.DateTime.Now.ToString("HH:mm:ss")


        CMD.Connection = CON1
        CMD.CommandText = ("INSERT INTO AddCash(Cash_dt,Cash_Time,Ref,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Amt,Typ,Com) VALUES ('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & SS & "','" & TxtDes.Text & "','" & Trim(TxtQ1.Text) & "','" & Trim(TxtQ2.Text) & "','" & Trim(TxtQ3.Text) & "','" & Trim(TxtQ4.Text) & "','" & Trim(TxtQ5.Text) & "','" & Trim(TxtQ6.Text) & "','" & Trim(TxtQ7.Text) & "','" & Trim(TxtQ8.Text) & "','" & Trim(TxtQ9.Text) & "','" & Trim(TxtQ10.Text) & "','" & Trim(TxtQ11.Text) & "','" & Trim(TxtAmt1.Text) & "','1','CHG')")
        'Cmd.CommandText = ("INSERT INTO InhInv (Inv_no,Inv_com,Inv_dt,Inv_pono,Inv_Flag1,Inv_Code) VALUES ('" & TxtInvNo.Text & "','" & Mid(Lstcom.SelectedValue, 1, 3) & , & DateValue(Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4)) & "','" & TxtPoNo.Text & "','Select','" & "','" & Mid(Trim(LstCode.SelectedValue), 1, 5) & "' )")
        CMD.ExecuteNonQuery()

        BindTheGrid1()
        BindTheGrid()
        BindTheGrid2()
        BindTheGrid3()


        BtnSave.Enabled = False
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True

    End Sub


    Private Sub LstItmNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim V1, V2, V3 As String
        BindTheGrid()
        BindTheGrid2()
        If BtnAdd.Enabled = True Then
            '  V1 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "1.jpg"
        Else
            'V1 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "1.jpg"
        End If
        If BtnAdd.Enabled = True Then
            'V2 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "2.jpg"
        Else
            'V2 = "http://sgcsser\Insu\Itm\" & Mid(Trim(LstItmNo.SelectedValue), 1, 8) & "2.jpg"
        End If

        V3 = "http://sgcsser\Insu\Itm\"

        If IsDBNull(V1) = False Then
            '  Img1.Visible = True
            ' Img1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            ' Img2.Visible = True
            ' Img2.ImageUrl = V2
        End If
    End Sub

    Private Sub LstCntry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  DR.Close()
        Dim TT1, tt2 As String
        'TT1 = Mid(LstTyp.SelectedValue, 1, 2)

        CMD = New SqlCommand("SELECT sys_rno,sys_des1 From SysMast where sys_rtp='03' and substring(sys_des2,1,2)='" & TT1 & "'", CON)


        DR = CMD.ExecuteReader


        'LstBrnd.Items.Clear()
        While DR.Read
            TT = DR.GetValue(0) + " " + DR.GetValue(1)
            ' LstBrnd.Items.Add(TT)
        End While

        DR.Close()


        'CRI1 = Mid(LstTyp.SelectedValue, 1, 2)
        'CRI2 = Mid(LstCntry.SelectedValue, 1, 2)
        ' CRI3 = Mid(LstBrnd.SelectedValue, 1, 2)

        'CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk From ItmMast where mid(itm_no,1,2)='" & CRI1 & "' and mid(itm_no,3,2)='" & CRI2 & "' and mid(itm_no,4,2)='" & CRI3 & "'", CON)
        CMD = New SqlCommand("SELECT Itm_no,Itm_des,Cat_no,Cost_pr,Sale_pr,itm_stk,Itm_dis From ItmMast where substring(itm_no,1,2)='" & CRI1 & "'and substring(itm_no,3,2)='" & CRI2 & "' and substring(itm_no,5,2)='" & CRI3 & "'", CON)
        DR = CMD.ExecuteReader
        'LstItmNo.Items.Clear()

        ' If Not IsPostBack Then
        While DR.Read

            str1 = Space(50)
            str2 = Space(20)
            str1 = DR.GetValue(1) + str1
            str1 = Left(str1, 50)
            str2 = str2 + Str(DR.GetValue(4))
            str2 = Right(str2, 20)
            TT = DR.GetValue(0) + " " + str1 + " " + str2
            'LstItmNo.Items.Add(TT)
        End While
        ' End If
        'BtnAdd.Enabled = True
        'BtnEdit.Enabled = True
        DR.Close()
        BindTheGrid()
        BindTheGrid2()
    End Sub
    Private Sub LstVat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVat.SelectedIndexChanged
        If LstVat.SelectedValue = "No" Then
            LstFlag2.Visible = True
            Label11.Visible = True
            ' Label12.Visible = True

        Else
            LstFlag2.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            TxtPer.Text = 0
            TxtPer.Visible = False

        End If


    End Sub

    Private Sub LstFlag2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstFlag2.SelectedIndexChanged
        If LstFlag2.SelectedValue = "No" Then
            TxtPer.Visible = False
            TxtPer.Text = 0
            Label12.Visible = False
            Label11.Visible = True
        Else
            Label11.Visible = True
            Label12.Visible = True
            TxtPer.Visible = True
            TxtPer.Text = 6
        End If

    End Sub

    Private Overloads Sub ImgBt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        'Calendar1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' TxtInvDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        'Calendar1.Visible = False
        BindTheGrid()
    End Sub

    Private Sub MyDatagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDatagrid1.SelectedIndexChanged

    End Sub

    Private Sub Lstcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstcom.SelectedIndexChanged
        TxtQ1.ReadOnly = False
        TxtQ2.ReadOnly = False

        TxtQ3.ReadOnly = False
        TxtQ4.ReadOnly = False
        TxtQ5.ReadOnly = False
        TxtQ6.ReadOnly = False
        TxtQ7.ReadOnly = False
        TxtQ8.ReadOnly = False
        TxtQ9.ReadOnly = False


        TxtQ10.ReadOnly = False
        TxtQ11.ReadOnly = False






        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim DeleteCmd As String = "DELETE from Inltemp "
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        'Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        'BindTheGrid1()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        txtEmpNo.Text = AllTrim(Lstcom.SelectedValue)



        TxtEpfNo.Text = Trim(txtEmpNo.Text)



        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "' AND Emp_No='SGC'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")

        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
        Cmd = New SqlCommand("SELECT Emp_DepNo,Emp_Nam,Emp_No FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)


        DR = Cmd.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            TxtDepNo.Text = Trim(DR.GetValue(0))
            depno = DR.GetValue(0)
            Lstcom.SelectedItem.Text = (DR.GetValue(2) + " - " + DR.GetValue(1))
            TxtEmpNam.Text = DR.GetValue(1)
        End While
        'End If
        DR.Close()

        'Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        'epfno = Trim(S1(0))

        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")

        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
        Cmd = New SqlCommand("SELECT Emp_DepNo FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)


        DR = Cmd.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            depno = Trim(DR.GetValue(0))
            'LstTyp.Items.Add(TT)
        End While
        'End If
        DR.Close()


        'count1 = DS.Tables("EmpAdmin").Rows.Count
        'If count1 <> 0 Then
        '    For Each DR1 In DS.Tables("EmpAdmin").Rows
        '        depno = DR1("Emp_dep")

        '    Next
        'End If





        Cmd = New SqlCommand("SELECT Sys_des1,Sys_des2 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'", CON)
        SS = "SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'"

        DR = Cmd.ExecuteReader

        depname = "00 - Other"
        'If Not IsPostBack Then
        While DR.Read
            depname = DR.GetValue(0)
            TxtCom.Text = DR.GetValue(1)

            'LstTyp.Items.Add(TT)
        End While
        'End If



        Deplist.SelectedItem.Text = Trim(depno) + " - " + depname

        TxtDepNam.Text = depname
        TxtDepNo.Text = Trim(depno)

        DR.Close()

        BindTheGrid()
        BindTheGrid2()
        BindTheGrid1()
        BindTheGrid3()
    End Sub



    Private Sub BttEmpNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttEmpNo.Click

        TxtQ1.ReadOnly = False
        TxtQ2.ReadOnly = False

        TxtQ3.ReadOnly = False

        TxtQ4.ReadOnly = False
        TxtQ5.ReadOnly = False

        TxtQ6.ReadOnly = False
        TxtQ7.ReadOnly = False
        TxtQ8.ReadOnly = False
        TxtQ9.ReadOnly = False


        TxtQ10.ReadOnly = False
        TxtQ11.ReadOnly = False









        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        Dim DeleteCmd As String = "DELETE from Inltemp "
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        'Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        'BindTheGrid1()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        TxtEpfNo.Text = Trim(txtEmpNo.Text)
        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "' AND Emp_No='SGC'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")

        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
        Cmd = New SqlCommand("SELECT Emp_DepNo,Emp_Nam,Emp_No FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)


        DR = Cmd.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            TxtDepNo.Text = Trim(DR.GetValue(0))
            depno = DR.GetValue(0)
            Lstcom.SelectedItem.Text = (DR.GetValue(2) + " - " + DR.GetValue(1))
            TxtEmpNam.Text = DR.GetValue(1)
        End While
        'End If
        DR.Close()

        'Dim S1() As String = Split(Lstcom.SelectedValue, "-")
        'epfno = Trim(S1(0))

        ADA = New SqlDataAdapter("SELECT * FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "EmpAdmin")

        SS = "SELECT Emp_Dep FROM EmpAdmin WHERE Emp_No = '" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_com='SGC'"
        Cmd = New SqlCommand("SELECT Emp_DepNo FROM EmpAdmin WHERE Emp_No = '" & Trim(txtEmpNo.Text) & "'", CON)


        DR = Cmd.ExecuteReader


        'If Not IsPostBack Then
        While DR.Read
            depno = Trim(DR.GetValue(0))
            'LstTyp.Items.Add(TT)
        End While
        'End If
        DR.Close()


        'count1 = DS.Tables("EmpAdmin").Rows.Count
        'If count1 <> 0 Then
        '    For Each DR1 In DS.Tables("EmpAdmin").Rows
        '        depno = DR1("Emp_dep")

        '    Next
        'End If





        Cmd = New SqlCommand("SELECT Sys_des1,Sys_des2 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'", CON)
        SS = "SELECT Sys_des1 FROM sysmast WHERE Sys_Rtp = '04' and Sys_Rno='" & Trim(depno) & "'"

        DR = Cmd.ExecuteReader

        depname = "00 - Other"
        'If Not IsPostBack Then
        While DR.Read
            depname = DR.GetValue(0)
            TxtCom.Text = DR.GetValue(1)

            'LstTyp.Items.Add(TT)
        End While
        'End If



        Deplist.SelectedItem.Text = Trim(depno) + " - " + depname

        TxtDepNam.Text = depname
        TxtDepNo.Text = Trim(depno)

        DR.Close()

        BindTheGrid()
        BindTheGrid2()
        BindTheGrid1()
        BindTheGrid3()
    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

    End Sub

    Private Sub Deplist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deplist.SelectedIndexChanged
        TxtDepNo.Text = Trim(Deplist.SelectedValue)
        'TxtAmt1.Text = "        " + Format(Val(TxtAmt1.Text), "###,###,###.00")
    End Sub

    Private Sub TxtQ1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ1.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ2.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ3.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ4.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If



    End Sub

    Private Sub TxtQ5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ5.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ6.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ7.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ8.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If

    End Sub

    Private Sub TxtQ9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ9.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub TxtQ10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ10.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If

    End Sub

    Private Sub TxtQ11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQ11.TextChanged
        TxtAmt1.Text = (Val(TxtQ1.Text) * 5000) + (Val(TxtQ2.Text) * 2000) + (Val(TxtQ3.Text) * 1000) + (Val(TxtQ4.Text) * 500) + (Val(TxtQ5.Text) * 100) + (Val(TxtQ6.Text) * 50) + (Val(TxtQ7.Text) * 20) + (Val(TxtQ8.Text) * 10) + (Val(TxtQ9.Text) * 5) + (Val(TxtQ10.Text) * 2) + (Val(TxtQ11.Text) * 1)
        TxtAmt.Text = "         " + Format(Val(TxtAmt1.Text), "###,###,###.00")
        TQ1.Text = Val(TxtQ1.Text) + Val(Q1.Text)
        TQ2.Text = Val(TxtQ2.Text) + Val(Q2.Text)
        TQ3.Text = Val(TxtQ3.Text) + Val(Q3.Text)
        TQ4.Text = Val(TxtQ4.Text) + Val(Q4.Text)
        TQ5.Text = Val(TxtQ5.Text) + Val(Q5.Text)
        TQ6.Text = Val(TxtQ6.Text) + Val(Q6.Text)
        TQ7.Text = Val(TxtQ7.Text) + Val(Q7.Text)
        TQ8.Text = Val(TxtQ8.Text) + Val(Q8.Text)
        TQ9.Text = Val(TxtQ9.Text) + Val(Q9.Text)
        TQ10.Text = Val(TxtQ10.Text) + Val(Q10.Text)
        TQ11.Text = Val(TxtQ11.Text) + Val(Q11.Text)
        TxtTQVal1.Text = (Val(TQ1.Text) * 5000) + (Val(TQ2.Text) * 2000) + (Val(TQ3.Text) * 1000) + (Val(TQ4.Text) * 500) + (Val(TQ5.Text) * 100) + (Val(TQ6.Text) * 50) + (Val(TQ7.Text) * 20) + (Val(TQ8.Text) * 10) + (Val(TQ9.Text) * 5) + (Val(TQ10.Text) * 2) + (Val(TQ11.Text) * 1)
        TxtTQVal.Text = "         " + Format(Val(TxtTQVal1.Text), "###,###,###.00")
        i = Val(TxtTQVal1.Text)
        j = Val(TxtQVal1.Text)
        If Val(TxtTQVal1.Text) = Val(TxtQVal1.Text) Then

            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If

    End Sub


    Private Sub Ok1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnSave.Enabled = True
    End Sub


    Private Sub Q1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q1.TextChanged

    End Sub

    Private Sub TxtInvDt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInvDt.TextChanged
        Dim Cmd1 As New SqlCommand("SELECT * FROM SignCash", CON1)
        Cmd1.ExecuteNonQuery()

        count = 0

        ADA = New SqlDataAdapter("SELECT * FROM SignCash where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

        DS = New DataSet
        ADA.Fill(DS, "SignCash")

        count = DS.Tables("SignCash").Rows.Count



        ADA = New SqlDataAdapter("SELECT  Imp_Com,Imp_Amt,Imp_Pay from Imprest", CON1)

        DS = New DataSet
        ADA.Fill(DS, "Imprest")

        count1 = DS.Tables("Imprest").Rows.Count

        count3 = 0
        ADA = New SqlDataAdapter("SELECT  * from CashBox where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", CON1)

        DS1 = New DataSet
        ADA.Fill(DS1, "CashBox")

        count3 = DS1.Tables("CashBox").Rows.Count

        ADA = New SqlDataAdapter("SELECT  Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Qtyp,C_Date from CashInBox", CON1)

        DS1 = New DataSet
        ADA.Fill(DS1, "CashInBox")

        count2 = DS1.Tables("CashInBox").Rows.Count



        If count = 0 Then
            If count1 <> 0 Then

                For Each drt2 In DS.Tables("Imprest").Rows
                    ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"


                    Cmd1.CommandText = ("INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                    Cmd1.ExecuteNonQuery()

                    '-----------

                    Cmd1.CommandText = ("INSERT INTO SignCashEnd(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                    Cmd1.ExecuteNonQuery()

                Next





            End If

            If count2 <> 0 Then

                For Each drt1 In DS1.Tables("CashInBox").Rows
                    ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"

                    If count3 = 0 Then
                        Cmd1.CommandText = ("INSERT INTO CashBox(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Pen_Amt,C_Date,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt1("Q1") & "'," & drt1("Q2") & "," & drt1("Q3") & "," & drt1("Q4") & "," & drt1("Q5") & "," & drt1("Q6") & "," & drt1("Q7") & "," & drt1("Q8") & "," & drt1("Q9") & "," & drt1("Q10") & "," & drt1("Q11") & "," & Val(TT) & ",'" & drt1("C_Date") & "','1')")
                        Cmd1.ExecuteNonQuery()
                    End If
                    '-----------
                Next
            End If
        End If

    End Sub
End Class
