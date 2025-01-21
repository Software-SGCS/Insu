Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail

Imports System.Drawing
Imports System.Text


Imports System.IO


Public Class PettyCashReq

    Inherits System.Web.UI.Page
    Dim CON, con1 As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2 As SqlDataReader
    Dim DS, DS1, DS2 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Private theTotal As Double = 0
    Private theTotal1 As Double = 0
    Dim drt2, drt3, drt1, drt4, drt5 As DataRow
    Dim Sempno, Sdate, SempNam, Sin, Sout, Swk, Ssec, SOT, Shr, ss1, Syr, Smt, incomplete, SOT1, SOT2 As String
    Dim SWK1 As Single
    Dim ss, ss2, des1, des2, des3, des4 As String

    Dim TotsDate, Totssec, TotWkhrs, TotOthrs, PFLAG, PSEC As String

    Dim count1, COUNT2, rowCount, count As Integer
    Dim gridSelections As StringBuilder = New StringBuilder  'Loop through each DataGridItem, and determine which CheckBox controls
    'have been selected.
    Dim DemoGridItem As DataGridItem
    Dim oStream As New MemoryStream
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Dim PAG As Boolean
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents BtnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents LstCh11 As System.Web.UI.WebControls.DropDownList
    'Protected WithEvents LstCh111 As multiColDD_List.DropDowns.DropDowns
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtMt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtYr As System.Web.UI.WebControls.TextBox

    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton

    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents ButSub As System.Web.UI.WebControls.Button
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel8 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel9 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel10 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel11 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtCno As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtChqNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Panel12 As System.Web.UI.WebControls.Panel
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents ImpAmt As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents PayAmt As System.Web.UI.WebControls.Label
    Protected WithEvents BalImp As System.Web.UI.WebControls.Label
    Protected WithEvents TxtInvDt As System.Web.UI.WebControls.TextBox
    Dim TT As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstCat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Company As System.Web.UI.WebControls.Label

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
        Dim USER11, uid As String
        USER11 = Request.QueryString("UID")

        L1.Text = USER11


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        CON1 = New SqlConnection
        CON1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
        CON1.Open()
        pflag = "N"


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




        If Not IsPostBack Then
            PFLAG = "N"

            If COUNT2 = "1" Then
                PFLAG = "Y"

            Else

                If COUNT2 = "2" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry3.aspx' and Form_level2='1'", CON)

                Else
                    If COUNT2 = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry3.aspx' and Form_level3='1'", CON)

                    Else
                        If COUNT2 = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry3.aspx' and Form_level4='1'", CON)
                        Else
                            If COUNT2 = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry3.aspx' and Form_level5='1'", CON)

                            Else
                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & COUNT2 & "'", CON)

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
                Response.AddHeader("Refresh", 1800)
                'Response.Redirect("POSDispaly11.aspx")
            End If

            'BtnUpdate.Enabled = True

        End If


        If Not IsPostBack Then
            con1 = New SqlConnection
            con1.ConnectionString = ("data source=(local);initial catalog=PrettyCash; user id=sa;password=tstc123")
            con1.Open()

            CMD = New SqlCommand("SELECT sum(Out_Amt) as PayAmt from Outword where Out_flg='N'", con1)

            DR = CMD.ExecuteReader
            While DR.Read
                Try
                    TT = DR.GetValue(0)
                Catch ex As Exception
                    TT = "0"
                End Try
            End While
            DR.Close()


            Dim Cmd1 As New SqlCommand("SELECT * FROM SignCash", con1)
            Cmd1.ExecuteNonQuery()

            TxtInvDt.Text = Format(Today(), "dd/MM/yyyy")


            Count = 0
            '-----------

            'TxtBillDt.Text = ""
            'TxtIndentNo.Text = ""
            'TxtMasDes.Text = ""
            ADA = New SqlDataAdapter("SELECT * FROM SignCash where Vou_Date='" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "'", con1)

            DS = New DataSet
            ADA.Fill(DS, "SignCash")

            Count = DS.Tables("SignCash").Rows.Count



            ADA = New SqlDataAdapter("SELECT  Imp_Com,Imp_Amt,Imp_Pay from Imprest", con1)

            DS = New DataSet
            ADA.Fill(DS, "Imprest")

            count1 = DS.Tables("Imprest").Rows.Count



            ADA = New SqlDataAdapter("SELECT  Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Qtyp from CashInBox", con1)

            ds1 = New DataSet
            ADA.Fill(ds1, "CashInBox")

            COUNT2 = ds1.Tables("CashInBox").Rows.Count



            If Count = 0 Then
                If count1 <> 0 Then

                    For Each drt2 In DS.Tables("Imprest").Rows
                        ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"


                        Cmd1.CommandText = ("INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Pay_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt2("Imp_Com") & "'," & drt2("Imp_Amt") & "," & drt2("Imp_Pay") & ",'1')")

                        Cmd1.ExecuteNonQuery()


                        '-----------

                    Next

                End If

                If COUNT2 <> 0 Then



                    For Each drt1 In ds1.Tables("CashInBox").Rows
                        ' SS = "INSERT INTO SignCash(Vou_Date,Com,Imp_Amt,Imp_Pay,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & DR.GetValue(0) & "'," & Val(DR.GetValue(1)) & "," & Val(DR.GetValue(2)) & ",'1')"


                        Cmd1.CommandText = ("INSERT INTO CashBox(Vou_Date,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Pen_Amt,Typ)VALUES('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & drt1("Q1") & "'," & drt1("Q2") & "," & drt1("Q3") & "," & drt1("Q4") & "," & drt1("Q5") & "," & drt1("Q6") & "," & drt1("Q7") & "," & drt1("Q8") & "," & drt1("Q9") & "," & drt1("Q10") & "," & drt1("Q11") & "," & Val(TT) & ",'1')")

                        Cmd1.ExecuteNonQuery()


                        '-----------

                    Next

                End If

            End If
            CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)


            DR = CMD.ExecuteReader
            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCat.Items.Add(TT)
            End While
            DR.Close()
            Data4()
        End If

        CON.Close()

        'Put user code to initialize the page here
    End Sub

    Private Sub Data4()

        CMD = New SqlCommand("SELECT Imp_Com,Imp_Pay,Imp_Amt From Imprest where Imp_Com='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "'", con1)


        DR = CMD.ExecuteReader
        While DR.Read
            'TT = DR.GetValue(0) + " - " + DR.GetValue(1)
            ImpAmt.Text = "      " + Format(DR.GetValue(2), "###,###,###.00")
            PayAmt.Text = "      " + Format(DR.GetValue(1), "###,###,###.00")
            BalImp.Text = "      " + Format((DR.GetValue(2) - DR.GetValue(1)), "###,###,###.00")

        End While
        DR.Close()





        'CON = New SqlConnection
        'CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        'con1.Open()

        ss = "SELECT Raw_ItmCode,Raw_des,Raw_Qtytyp,Raw_opStk FROM RawMaster WHERE raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "'"
        ' Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT RawMaster.Raw_ItmCode as Raw_ItmCode ,RawMaster.Raw_des as Raw_des,ItmMaster.Itm_Pri as Itm_pri,RawMaster.Raw_opStk as Raw_opStk,convert(decimal(7),RawMaster.Raw_Soh,0)  as Raw_Soh,RawMaster.Raw_PhStock as Raw_PhStock,Raw_rec,Raw_rtn,Raw_dmg FROM RawMaster,ItmMaster WHERE RawMaster.Raw_ItmCode=ItmMaster.Itm_code and  RawMaster.raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "' Order by RawMaster.Raw_ItmCode", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select EmpMaster.EmpAct as Raw_ItmCode,EmpMaster.Emp_No as Raw_Rec,EmpMaster.Emp_No as Raw_des ,EmpMaster.Emp_Nam as Itm_pri,EmpMaster.OldEpfNo as Raw_opStk,EmpMaster.EmpAct as  Raw_PhStock,EmpMaster.EmpDel as Raw_Soh from EmpMaster where EmpMaster.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and EmpDel='N' ORDER BY convert(decimal(5),EmpMaster.Emp_No,0)", CON)

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select A.Id as Id,CONVERT(VARCHAR(10),A.In_Date,103) as In_date,A.In_Vno as In_Vno, REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,A.In_PayAmt),1), '','') as  In_PayAmt,A.In_Eno as In_Eno,B.Emp_Nam as Emp_Nam,B.Emp_Com as Emp_Com,B.Emp_Dep as Emp_Dep from InWord A,Employee B where A.In_Eno=B.Emp_no and A.In_Com='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "' and In_flg1='Y' order by A.Id,A.In_date", con1)
        cmdCustomers.CommandType = CommandType.Text
        DataGrid1.Enabled = True
        DataGrid1.DataSource = cmdCustomers.ExecuteReader()
        DataGrid1.DataBind()
        DataGrid1.Visible = True
        CON.Close()


        '-------
    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
        Dim Tdate As String
        Dim TSchNo As String
        Dim TSchin As String
        Dim TSchout As String
        Dim TSchnam As String
        Dim soh As String
        Dim pstk As String
        Dim t1, t2, t3, t4, t5 As String

        If e.Item.ItemType.ToString = "Item" Or e.Item.ItemType.ToString = "AlternatingItem" Then


            ' Tdate = e.Item.Cells(0).Text
            TSchNo = Trim(e.Item.Cells(0).Text)
            TSchnam = Trim(e.Item.Cells(1).Text)
            TSchin = Trim(e.Item.Cells(2).Text)
            TSchout = Trim(e.Item.Cells(3).Text)
            soh = Trim(e.Item.Cells(4).Text)
            pstk = Trim(e.Item.Cells(5).Text)
            t1 = Trim(e.Item.Cells(6).Text)
            t2 = Trim(e.Item.Cells(7).Text)
            t3 = Trim(e.Item.Cells(8).Text)

            Dim chkExp1 As Label = e.Item.FindControl("Raw_ItmCode")
            chkExp1.Text = TSchNo
            Dim chkExp2 As Label = e.Item.FindControl("Raw_des")
            chkExp2.Text = TSchnam
            Dim chkExp3 As Label = e.Item.FindControl("Itm_Pri")
            chkExp3.Text = TSchin
            Dim chkExp4 As Label = e.Item.FindControl("Raw_OpStk")
            chkExp4.Text = TSchout
            Dim chkExp5 As TextBox = e.Item.FindControl("Raw_Soh")
            chkExp5.Text = soh
            Dim chkExp6 As TextBox = e.Item.FindControl("Raw_PhStock")
            chkExp6.Text = t1
            Dim chkExp7 As TextBox = e.Item.FindControl("Raw_Rec")
            chkExp6.Text = pstk




            CalculateTotal(e.Item.Cells(3).Text)
            CalculateTotalval(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(3).Text))

            CalculateTotal1(e.Item.Cells(4).Text)
            CalculateTotalval1(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(4).Text))

            CalculateTotal2(e.Item.Cells(5).Text)
            CalculateTotalval(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(5).Text))

        ElseIf (e.Item.ItemType = ListItemType.Footer) Then

            '''TxtQty1.Text = theTotal
            '''TxtQty2.Text = theTotal1
            '''TxtQty3.Text = theTotal2

            '''TxtVal1.Text = theTotalVal

            '''TxtVal2.Text = theTotalVal1
            ''' TxtVal3.Text = theTotalVal2

        End If

    End Sub

    Private Sub CalculateTotal(ByVal theQuantity As String)
        ' theTotal += Double.Parse(theQuantity)
    End Sub
    Private Sub CalculateTotal1(ByVal theQuantity1 As String)
        ' theTotal1 += Double.Parse(theQuantity1)
    End Sub
    Private Sub CalculateTotal2(ByVal theQuantity As String)
        ' theTotal2 += Double.Parse(theQuantity)
    End Sub

    Private Sub CalculateTotalval(ByVal theQuantityVal As String)
        ' theTotalVal += Double.Parse(theQuantityVal)
    End Sub
    Private Sub CalculateTotalval1(ByVal theQuantityVal1 As String)
        ' theTotalVal1 += Double.Parse(theQuantityVal1)
    End Sub

    Private Sub CalculateTotalval2(ByVal theQuantityVal2 As String)
        ' theTotalVal2 += Double.Parse(theQuantityVal2)
    End Sub

    Private Sub LstCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCat.SelectedIndexChanged
        ButSub.Enabled = True
        Data4()
    End Sub
  
    Private Sub ButSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSub.Click
        CMD = New SqlCommand("SELECT * FROM InWord", con1)
        DR2 = CMD.ExecuteReader
        DR2.Close()


        'ok1.Enabled = False
        For Each DemoGridItem In DataGrid1.Items
            Dim myCheckbox As CheckBox = CType(DemoGridItem.Cells(7).Controls(1), CheckBox)
            If myCheckbox.Checked = True Then
                rowCount += 1
                'LblMsg.Text = "The checkbox for {0} was selected<br>"
                If rowCount = 1 Then
                    des1 = Trim(DemoGridItem.Cells(0).Text)
                    des2 = Trim(DemoGridItem.Cells(1).Text)
                    'TxtHScd.Text += Trim(DemoGridItem.Cells(3).Text)
                Else
                    des1 = Trim(DemoGridItem.Cells(0).Text)
                    des2 = Trim(DemoGridItem.Cells(1).Text)
                    'TxtHScd.Text += "," + Trim(DemoGridItem.Cells(3).Text)
                End If
                ss = System.DateTime.Now.ToString("MM/dd/yyyy")
                CMD.Connection = con1
                CMD.CommandText = ("UPDATE InWord SET In_Flg1='N',In_RqDate='" & ss & "' where In_Vno='" & des2 & "'")
                CMD.ExecuteNonQuery()

                'tot1 = tot1 + Val(Trim(DemoGridItem.Cells(5).Text))
            End If
        Next

        Data4()

        ss = System.DateTime.Now.ToString("MM/dd/yyyy")
        ButSub.Enabled = False

        Dim DSS As PettyCash1 = New PettyCash1
        ' Dim DSS As ExpWharfRep2 = New ExpWharfRep2

        CrystalReportViewer1.Visible = True

        Dim vehno1 As String '

        DSS.SetDatabaseLogon("sa", "tstc123")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait

        DSS.SetParameterValue("com", "" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "")
        'DSS.SetParameterValue("dt1", "" & ss & "")

        ''ss = Mid(Trim(ss), 4, 2) + "/" + Mid(Trim(ss), 1, 2) + "/" + Mid(Trim(ss), 7, 4)
        DSS.SetParameterValue("dt1", "" & ss & "")



        CrystalReportViewer1.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = True
        CrystalReportViewer1.HasZoomFactorList = True
        CrystalReportViewer1.HasPageNavigationButtons = True
        CrystalReportViewer1.HasDrillUpButton = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.DataBind()


        '--------------

        oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
        Response.AddHeader("content-disposition", "attachment;filename=AAA.pdf")
        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/pdf"

        Response.BinaryWrite(oStream.ToArray())
        Response.End()



    End Sub
End Class
