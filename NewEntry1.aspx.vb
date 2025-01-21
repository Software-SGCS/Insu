Imports System.Data.SqlClient
Imports System.Data

Imports System.Web.Mail


Public Class NewEntry1

    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
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
    Dim ss, ss2, StrEmpno, StrEmpCom, StrEmpNam, StrOldEpfno, StrNam As String

    Dim TotsDate, Totssec, TotWkhrs, TotOthrs, PFLAG, PSEC, TempEmpno, TempCom, SEmpCno, SEmpDes, SEmpChqNo, OLD1, OLD2, OLD3, OLD4 As String

    Dim count1, COUNT2 As Integer
    Dim TotAmt1, TotAmt2, TotAmt3, TotAmt4 As Double
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
    Protected WithEvents Datagrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents TxtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtNam As System.Web.UI.WebControls.TextBox
    Protected WithEvents Lsttyp As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtPay As System.Web.UI.WebControls.TextBox
    Protected WithEvents Txtappdt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtTEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtYr1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtBal1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOutTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtInTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtPeTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtChqAmt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Txtbal As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldEmpNo1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldEmpNo2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldEmpNo3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtOldEmpNo4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtmsg As System.Web.UI.WebControls.Label
    Protected WithEvents TxtBal11 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtCrTot As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Dim TT As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents LstCat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Company As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid

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
        Dim field1 As String = CType(Session.Item("field1"), String)


        L1.Text = field1

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


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
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level2='1'", CON)

                Else
                    If COUNT2 = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level3='1'", CON)

                    Else
                        If COUNT2 = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level4='1'", CON)
                        Else
                            If COUNT2 = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry1.aspx' and Form_level5='1'", CON)

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

                Response.Redirect("POSDispaly11.aspx")
            End If

            'BtnUpdate.Enabled = True

        End If


        If Not IsPostBack Then

            TxtChqAmt.Text = "0"
            TxtCno.Text = ""
            ButSub.Enabled = False
            If PSEC = "ALL" Then
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)
            Else
                CMD = New SqlCommand("SELECT Com_No,Com_nam From Company where Com_No='" & Trim(PSEC) & "'", CON)
            End If

            DR = CMD.ExecuteReader



            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCat.Items.Add(TT)
            End While



            DR.Close()



            Data4()

            TxtYr1.Text = Year(Today())
            Txtappdt.Text = Format(Today(), "dd/MM/yyyy")


        End If


        If Not IsPostBack Then
            CON.Open()
            CMD = New SqlCommand("SELECT Tre_Typ From TreType", CON)

            DR = CMD.ExecuteReader

            ' TxtYr.Text = Year(Today())

            While DR.Read
                TT = DR.GetValue(0)
                Lsttyp.Items.Add(TT)
            End While


            DR.Close()
        End If

        CON.Close()

        'Put user code to initialize the page here
    End Sub

    Private Sub Data4()



        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        ss = "SELECT Raw_ItmCode,Raw_des,Raw_Qtytyp,Raw_opStk FROM RawMaster WHERE raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "'"
        ' Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT RawMaster.Raw_ItmCode as Raw_ItmCode ,RawMaster.Raw_des as Raw_des,ItmMaster.Itm_Pri as Itm_pri,RawMaster.Raw_opStk as Raw_opStk,convert(decimal(7),RawMaster.Raw_Soh,0)  as Raw_Soh,RawMaster.Raw_PhStock as Raw_PhStock,Raw_rec,Raw_rtn,Raw_dmg FROM RawMaster,ItmMaster WHERE RawMaster.Raw_ItmCode=ItmMaster.Itm_code and  RawMaster.raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "' Order by RawMaster.Raw_ItmCode", CON)

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select convert(varchar(10),HltMaster1.Emp_PayDt,103) as Raw_ItmCode,HltMaster1.ID as Raw_des ,HltMaster1.Emp_Typ as Itm_pri,convert(decimal(8,2),HltMaster1.Emp_DecAmt,2) as Raw_opStk,HltMaster1.Emp_ChqNo as Raw_Soh,HltMaster1.Emp_CNo as Raw_PhStock,convert(decimal(8,2),HltMaster1.Emp_Amt,2) as Raw_rec ,HltMaster1.Raw_Rmk as Raw_Rtn from HltMaster1 ,HthMaster where ((HltMaster1.Emp_No=HthMaster.Epfno or HltMaster1.Emp_No=HthMaster.OldEpfno) or (HltMaster1.Emp_No=HthMaster.OldEpfno1 or HltMaster1.Emp_No=HthMaster.OldEpfno2) or (HltMaster1.Emp_No=HthMaster.OldEpfno3 or HltMaster1.Emp_No=HthMaster.OldEpfno4)) AND (HltMaster1.Emp_Com=HthMaster.Com) and (HltMaster1.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and HltMaster1.Emp_DecFlg='Yes') and (HltMaster1.Emp_No='" & Trim(TxtTEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo2.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo4.Text) & "') and Emp_Accyr='" & Trim(TxtYr1.Text) & "' ORDER BY HltMaster1.iD", CON)
        ss = "Select convert(varchar(10),HltMaster1.Emp_PayDt,103) as Raw_ItmCode,HltMaster1.id as Raw_des ,HthMaster.EmployeeName as Itm_pri,convert(decimal(8,2),HltMaster1.Emp_DecAmt,2) as Raw_opStk,HltMaster1.Emp_ChqNo as Raw_Soh,HltMaster1.Emp_CNo as Raw_PhStock,convert(decimal(8,2),HltMaster1.Emp_Amt,2) as Raw_rec ,HltMaster1.Raw_Rmk as Raw_Rtn from HltMaster1 ,HthMaster where (HltMaster1.Emp_No=HthMaster.Epfno or HltMaster1.Emp_No=HthMaster.OldEpfno or HltMaster1.Emp_No=HthMaster.OldEpfno1 or HltMaster1.Emp_No=HthMaster.OldEpfno2 or HltMaster1.Emp_No=HthMaster.OldEpfno3 or HltMaster1.Emp_No=HthMaster.OldEpfno4) AND (HltMaster1.Emp_Com=HthMaster.Com) and (HltMaster1.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and HltMaster1.Emp_DecFlg='Yes') and (HltMaster1.Emp_No='" & Trim(TxtTEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo2.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' or HltMaster1.Emp_No='" & Trim(TxtOldEmpNo4.Text) & "') and Emp_Accyr='" & Trim(TxtYr1.Text) & "' ORDER BY HltMaster1.iD"
        cmdCustomers.CommandType = CommandType.Text
        DataGrid1.Enabled = True
        DataGrid1.DataSource = cmdCustomers.ExecuteReader()
        DataGrid1.DataBind()
        DataGrid1.Visible = True
        CON.Close()


        '-------
    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound
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
        TxtChqNo.Text = ""
        TxtChqAmt.Text = "0"
        TxtCno.Text = ""
        ButSub.Enabled = False
        TxtEmpNo.Enabled = False
        txtmsg.Visible = False
        Data4()
        BindTheGrid1()
        Txtbal.Text = 0
    End Sub

    Private Sub ButSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSub.Click
        Dim gridrow As DataGridItem
        Dim i, J As Double
        Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 As String
        Dim SS As String
        Dim sEmps As String
        Dim dr As DataRow
        Dim SysRtp As Integer
        Dim SysRno As String
        Dim Sysdes1 As String
        Dim sysdes2 As String
        Dim Count As Double
        Dim CMD1 As SqlCommand

        Dim TT As String
        CON.Open()

        Dim field1 As String = CType(Session.Item("field1"), String)

        ' TT = Mid(LstCh4.SelectedValue, 1, 4)
        'TT = Trim(TT)
        CMD = New SqlCommand("SELECT * FROM HthMaster", CON)
        DR2 = CMD.ExecuteReader
        DR2.Close()


        t8 = Format(CDate(Today()), "MM/dd/yyyy")

        txtmsg.Visible = False
        'CMD.CommandText = ("Delete from Maintra WHERE Tra_Year='" & TxtYear.Text & "' AND Tra_Mth='" & Mid(LstMth.SelectedValue, 1, 2) & "' AND mid(Tra_Rno,1,4) ='" & TT & "'")
        '' CMD.ExecuteNonQuery()

        For Each gridrow In DataGrid1.Items
            t1 = CType(gridrow.FindControl("Raw_ItmCode"), Label).Text
            t2 = CType(gridrow.FindControl("Raw_des"), Label).Text

            t3 = CType(gridrow.FindControl("Itm_pri"), Label).Text 'gridrow.FindControl("Tra_Rno").Text
            t4 = CType(gridrow.FindControl("Raw_OpStk"), Label).Text
            t5 = CType(gridrow.FindControl("Raw_Soh"), TextBox).Text
            t6 = CType(gridrow.FindControl("Raw_Phstock"), TextBox).Text
            t7 = CType(gridrow.FindControl("Raw_Rec"), TextBox).Text
            t9 = CType(gridrow.FindControl("Raw_Rtn"), TextBox).Text


            ADA = New SqlDataAdapter("SELECT * FROM HltMaster1 WHERE ID=" & Trim(t2), CON)
            DS = New DataSet

            ADA.Fill(DS, "HltMaster1")

            count1 = DS.Tables("HltMaster1").Rows.Count
            ' Swk = ((Val(Mid(t4, 1, 2)) * 60 * 60 + Val(Mid(t4, 4, 2)) * 60 + Val(Mid(t4, 7, 2))) - (Val(Mid(t3, 1, 2)) * 60 * 60 + Val(Mid(t3, 4, 2)) * 60 + Val(Mid(t3, 7, 2)))) / 3600
            If count1 <> 0 Then
                t1 = Mid(Trim(t1), 4, 2) + "/" + Mid(Trim(t1), 1, 2) + "/" + Mid(Trim(t1), 7, 4)

                If Val(t7) <> 0 Then
                    If Trim(t3) = "Indoor" Then


                        i = Val(TxtBal1.Text)
                        i = Val(TxtInTot.Text)
                        J = Val(t7)

                        If (J > (55000 - i)) Then
                            txtmsg.Visible = True
                            txtmsg.Text = "Indoor Limit Over ! pls check !"
                            ButSub.Enabled = True
                        Else




                            CMD.Connection = CON
                            'CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t7 & "',Emp_Decflg='No',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & ",Emp_cno='" & Trim(TxtCno.Text) & "',Emp_RecDt='" & Trim(t8) & "' where Emp_paydt='" & Trim(t1) & "' and Emp_DecAmt=" & Val(Trim(t4)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t2)) & " and Emp_Decflg='Yes' and Id=" & Trim(t2))
                            CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t7 & "',Emp_Decflg='No',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & ",Sbmt_Code='" & Trim(field1) & "',Sbmt_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Sbmt_Time='" & FormatDateTime(TimeOfDay) & "',Emp_cno='" & Trim(TxtCno.Text) & "',Emp_RecDt='" & Trim(t8) & "' where ID=" & Trim(t2))
                            CMD.ExecuteNonQuery()
                            TxtInTot.Text = Val(TxtInTot.Text) + Val(t7)
                            Txtbal.Text = Val(Txtbal.Text) - Val(t7)
                            ''SS = "INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & COUNT2 & ",'" & Trim(Sempno) & "','" & SEmpcom & "','Nil','Nil','" & Format(DateValue(Today()), "MM/dd/yyyy") & "','Nil','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
                            ButSub.Enabled = False
                        End If



                    Else

                        If Trim(t3) = "Critical" Then


                            i = Val(TxtBal1.Text)
                            i = Val(TxtInTot.Text)
                            J = Val(t7)

                            If (J > (400000)) Then
                                txtmsg.Visible = True
                                txtmsg.Text = "Criticle Limit Over ! pls check !"
                                ButSub.Enabled = True
                            Else




                                CMD.Connection = CON
                                'CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t7 & "',Emp_Decflg='No',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & ",Emp_cno='" & Trim(TxtCno.Text) & "',Emp_RecDt='" & Trim(t8) & "' where Emp_paydt='" & Trim(t1) & "' and Emp_DecAmt=" & Val(Trim(t4)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t2)) & " and Emp_Decflg='Yes' and Id=" & Trim(t2))
                                CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t7 & "',Emp_Decflg='No',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & ",Sbmt_Code='" & Trim(field1) & "',Sbmt_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Sbmt_Time='" & FormatDateTime(TimeOfDay) & "',Emp_cno='" & Trim(TxtCno.Text) & "',Emp_RecDt='" & Trim(t8) & "' where ID=" & Trim(t2))
                                CMD.ExecuteNonQuery()
                                TxtInTot.Text = Val(TxtInTot.Text) + Val(t7)
                                Txtbal.Text = Val(Txtbal.Text) - Val(t7)
                                ''SS = "INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & COUNT2 & ",'" & Trim(Sempno) & "','" & SEmpcom & "','Nil','Nil','" & Format(DateValue(Today()), "MM/dd/yyyy") & "','Nil','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
                                ButSub.Enabled = False
                            End If


                        Else








                            i = Val(TxtBal1.Text)
                            i = Val(TxtBal11.Text)
                            J = Val(t7)

                            If (J > i) Then
                                txtmsg.Visible = True
                                txtmsg.Text = "Outdoor Limit Over ! pls check !"
                                ButSub.Enabled = True
                            Else




                                CMD.Connection = CON
                                'CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t7 & "',Emp_Decflg='No',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & ",Emp_cno='" & Trim(TxtCno.Text) & "',Emp_RecDt='" & Trim(t8) & "' where Emp_paydt='" & Trim(t1) & "' and Emp_DecAmt=" & Val(Trim(t4)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t2)) & " and Emp_Decflg='Yes' and Id=" & Trim(t2))
                                CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t7 & "',Emp_Decflg='No',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & ",Sbmt_Code='" & Trim(field1) & "',Sbmt_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Sbmt_Time='" & FormatDateTime(TimeOfDay) & "',Emp_cno='" & Trim(TxtCno.Text) & "',Emp_RecDt='" & Trim(t8) & "' where ID=" & Trim(t2))
                                CMD.ExecuteNonQuery()
                                Txtbal.Text = Val(Txtbal.Text) - Val(t7)
                                ''SS = "INSERT INTO EmpMaster2(Seq_no,Emp_No,Emp_Com,Rel_Nam,Rel_Type,Rel_DOB,Rel_idno,Dea_Flag,Ent_code,Ent_time,Ent_date) VALUES (" & COUNT2 & ",'" & Trim(Sempno) & "','" & SEmpcom & "','Nil','Nil','" & Format(DateValue(Today()), "MM/dd/yyyy") & "','Nil','" & SEmpFlag & "','" & Trim(L1.Text) & "','" & FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") & "')")
                                ButSub.Enabled = False
                            End If
                        End If
                End If
                End If
                If Trim(t9) <> "" Then
                    CMD.Connection = CON
                    'CMD.CommandText = ("UPDATE HltMaster1 SET Raw_Rmk='" & Trim(t9) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & " where Emp_paydt='" & Trim(t1) & "' and Emp_DecAmt=" & Val(Trim(t4)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t2)) & " and Emp_Decflg='Yes' and Id=" & Trim(t2))
                    CMD.CommandText = ("UPDATE HltMaster1 SET Raw_Rmk='" & Trim(t9) & "',Emp_cno='" & Trim(TxtCno.Text) & "',Emp_chqNo='" & Trim(TxtChqNo.Text) & "',Sbmt_code='" & Trim(field1) & "',Sbmt_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Sbmt_Time='" & FormatDateTime(TimeOfDay) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & " where ID=" & Trim(t2))

                    CMD.ExecuteNonQuery()
                    ButSub.Enabled = False
                End If



            End If


            'CON.Close()


        Next

        CON.Close()
        Data4()
        BindTheGrid1()

    End Sub

    Private Sub TxtChqNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtChqNo.TextChanged
        TxtChqAmt.Text = "0"
        TxtCno.Text = ""
        ButSub.Enabled = False
        Txtbal.Text = 0
    End Sub

    Private Sub TxtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpNo.TextChanged
        LstCat.Enabled = True
        txtmsg.Visible = False
        ButSub.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' OR  OldEpfNo='" & TxtEmpNo.Text & "' OR  OldEpfNo1='" & TxtEmpNo.Text & "' OR  OldEpfNo2='" & TxtEmpNo.Text & "' OR  OldEpfNo3='" & TxtEmpNo.Text & "' OR  OldEpfNo4='" & TxtEmpNo.Text & "') and com='" & Mid(LstCat.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' OR  OldEpfNo='" & TxtEmpNo.Text & "') and com='" & Mid(LstCat.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthMaster")

        count1 = DS.Tables("HthMaster").Rows.Count

        If count1 <> 0 Then
            TxtNam.ReadOnly = True
            LstCat.Enabled = True
            Button2.Enabled = True
            TxtPay.Enabled = True



            For Each drt2 In DS.Tables("HthMaster").Rows
                StrEmpno = drt2("EpfNo")
                StrEmpCom = drt2("Com")
                StrEmpNam = drt2("EMPLOYEENAME")
                StrOldEpfno = drt2("OldEpfNo")
                TxtNam.Text = StrEmpNam
                TxtTEmpNo.Text = drt2("EpfNo")
                TxtOldEmpNo.Text = drt2("OldEpfNo")
                TxtOldEmpNo1.Text = drt2("OldEpfNo1")
                TxtOldEmpNo2.Text = drt2("OldEpfNo2")
                TxtOldEmpNo3.Text = drt2("OldEpfNo3")
                TxtOldEmpNo4.Text = drt2("OldEpfNo4")


                If Trim(TxtTEmpNo.Text) = Trim(TxtOldEmpNo.Text) Then
                    ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE OldEpfNo='" & Trim(TxtOldEmpNo.Text) & "' and EpfNo<> '" & Trim(TxtOldEmpNo.Text) & " ' and com='" & Mid(LstCat.SelectedValue, 1, 3) & "'", CON)
                    DS1 = New DataSet
                    ss = "SELECT * FROM HthMaster WHERE OldEpfNo='" & Trim(TxtOldEmpNo.Text) & "' and com='" & Mid(LstCat.SelectedValue, 1, 3) & "'"
                    ADA.Fill(DS1, "HthMaster")

                    COUNT2 = DS1.Tables("HthMaster").Rows.Count
                    For Each drt3 In DS1.Tables("HthMaster").Rows

                        TxtOldEmpNo.Text = drt3("EpfNo")
                        StrOldEpfno = drt3("EpfNo")

                    Next


                Else


                End If



                ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE COM_NO = '" & StrEmpCom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "COMPANY")
                For Each drt3 In DS.Tables("COMPANY").Rows
                    StrNam = drt3("Com_Nam")
                Next
                LstCat.SelectedValue = StrEmpCom + " - " + StrNam

            Next
        Else
            TxtNam.ReadOnly = True
            LstCat.Enabled = True

            TxtNam.Text = "Record No Found "

            Button2.Enabled = False
            TxtPay.Enabled = False



        End If


        BindTheGrid1()
        Data4()

    End Sub

    Public Sub BindTheGrid1()
        'Try
        CON.Close()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        If CHKDUP = True Then
            TempEmpno = Val(TxtEmpNo.Text)
            TempCom = Mid(LstCat.SelectedValue, 1, 3)
        Else
            TempEmpno = Val(TxtEmpNo.Text)
            TempCom = Mid(LstCat.SelectedValue, 1, 3)
        End If

        ADA = New SqlDataAdapter("SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(LstCat.SelectedValue, 1, 3) & "' and ((Emp_No='" & Trim(TxtTEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo.Text) & "') Or (Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo2.Text) & "') Or (Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo4.Text) & "')) and Emp_Accyr='" & Trim(TxtYr1.Text) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(LstCat.SelectedValue, 1, 3) & "' and (Emp_No='" & Trim(TxtTEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo2.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo4.Text) & "') and Emp_Accyr='" & Trim(TxtYr1.Text) & "'"
        ADA.Fill(DS, "HltMaster1")

        count1 = DS.Tables("HltMaster1").Rows.Count

        TotAmt1 = 0
        TotAmt2 = 0
        TotAmt3 = 0
        TotAmt4 = 0
        If count1 <> 0 Then

            LstCat.Enabled = True


            For Each drt2 In DS.Tables("HltMaster1").Rows

                If drt2("Emp_Typ") = "Indoor" Then
                    TotAmt1 = TotAmt1 + drt2("Emp_Amt")
                Else
                    If drt2("Emp_Typ") = "Outdoor" Then
                        TotAmt2 = TotAmt2 + drt2("Emp_Amt")
                    Else


                        TotAmt4 = TotAmt4 + drt2("Emp_Amt")
                    End If
                End If

                If drt2("Emp_Amt") = 0 Then
                    TotAmt3 = TotAmt3 + drt2("Emp_DecAmt")
                End If
            Next
        Else
            'TxtEmpNam.Enabled = True
            'LstCom1.Enabled = True
            'TxtIdNo.Enabled = True


            'TxtEmpNam.Text = " "
            'TxtIdNo.Text = " "
        End If

        TxtInTot.Text = Format(TotAmt1, "###,###,###.00")
        TxtOutTot.Text = Format(TotAmt2, "###,###,###.00")
        TxtCrTot.Text = Format(TotAmt4, "###,###,###.00")
        TxtBal1.Text = Format((7500 - TotAmt2), "###,###,###.00")
        TxtBal11.Text = 7500 - TotAmt2
        TxtPeTot.Text = Format(TotAmt3, "###,###,###.00")
        ss = "Select Id,Emp_ChqNo,Emp_Typ,format(Emp_Amt,'#,###.00') as Emp_Amt, Format(Emp_PayDt,'dd/MM/yyyy') as Emp_Paydt from HltMaster1 where Emp_No='" & Trim(TempEmpno) & "' and Emp_Com='" & Trim(TempCom) & "'"""

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_ChqNo,Emp_Cno,Emp_Typ,convert(decimal(8,2),Emp_Amt,2) AS Emp_Amt,convert(decimal(8,2),Emp_DecAmt,2) AS Emp_DecAmt, convert(varchar(10),Emp_RecDt,103) as Emp_Paydt,convert(varchar(10),Emp_PayDt,103) as Emp_Recdt from HltMaster1 where (Emp_No='" & Trim(TxtTEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo1.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo2.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo3.Text) & "' Or Emp_No='" & Trim(TxtOldEmpNo4.Text) & "') and Emp_Com='" & Trim(TempCom) & "' and emp_accyr='" & Trim(TxtYr1.Text) & "' ORDER BY ID", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        Datagrid2.DataSource = cmdCustomers.ExecuteReader()
        Datagrid2.DataBind()

        Datagrid2.Visible = True
        CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Sub DataGrid2_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)

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
        Datagrid2.EditItemIndex = -1
        BindTheGrid1()
        Datagrid2.Visible = True

    End Sub
    Sub DataGrid2_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        ' -----------------------
        'Dim DeleteCmd As String = "DELETE from HltMaster1 Where id = @Id"

        'Dim Cmd As New SqlCommand(DeleteCmd, CON)
        'Cmd.Parameters.Add(New SqlParameter("@ID", Datagrid2.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        'Cmd.ExecuteNonQuery()
        'CON.Close()
        'BindTheGrid1()
        ' ------------------------

        Dim cmdCustomers As SqlCommand

        Dim stritmNo1 As String = e.Item.Cells(1).Text
        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text
        Dim strval1 As String = e.Item.Cells(7).Text
        ' Dim strval2 As String = e.Item.Cells(9).Text
        'Dim strval3 As String = e.Item.Cells(10).Text
        'Dim strval4 As String = e.Item.Cells(11).Text
        'Dim strval5 As String = e.Item.Cells(12).Text
        'Dim strval6 As String = e.Item.Cells(13).Text
        ' Dim strval7 As String = e.Item.Cells(14).Text



        Dim StrSql As String


        StrSql = "UPDATE InlTemp SET stritmNo1,stritmNo,strdes,strpr,StrQty,strval,Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"

        Txtappdt.Text = Format(Today(), "dd/MM/yyyy")
        ss = Trim(Txtappdt.Text)
        ss = Trim(strval)


        ss = strval1 = 0 Or (Trim(Txtappdt.Text)) = Trim(strval)
        If strval1 = 0 Or (Trim(Txtappdt.Text)) = Trim(strval) Or Trim(L1.Text) = "ADMIN" Then

            Dim DeleteCmd As String = "DELETE from HltMaster1 Where id = @Id"

            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            Cmd.Parameters.Add(New SqlParameter("@ID", Datagrid2.DataKeys(CInt(e.Item.ItemIndex))))
            CON.Open()
            Cmd.ExecuteNonQuery()
            CON.Close()
            BindTheGrid1()

            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "insurance@dsisamson.com"
            'TxtMail.Text
            emailMessage.To = "chamindas@samsoncorporates.com,udanip@samsoncorporates.com,palithan@samsoncorporates.com"
            'emailMessage.To = "palithan@samsoncorporates.com"
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Record Delete -Health Recieved Payment"

            emailMessage.Body += "Company  : " + Trim(LstCat.SelectedValue) & vbCrLf
            emailMessage.Body += "EmpNo    : " + TxtEmpNo.Text + " Employee : " + Trim(TxtNam.Text) & vbCrLf
            emailMessage.Body += "User Code: " + Trim(L1.Text) + " Date : " + strval & vbCrLf
            emailMessage.Body += "Payment Amount :" + Trim(Trim(strval1)) & vbCrLf
            emailMessage.Body += "Submit Amount  :" + Trim(Trim(StrQty)) & vbCrLf

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

            Dim emailMessage As MailMessage
            emailMessage = New MailMessage
            emailMessage.From = "insurance@dsisamson.com"
            'TxtMail.Text
            emailMessage.To = "chamindas@samsoncorporates.com,udanip@samsoncorporates.com,palithan@samsoncorporates.com"
            'emailMessage.To = "palithan@samsoncorporates.com"
            'emailMessage.Attachments.Add("c:\RtnTxt.txt")
            'emailMessage.Cc = str_mail
            'emailMessage.Bcc = em1
            emailMessage.Subject = "Try to Record Delete -Health Recieved Payment"

            emailMessage.Body += "Company  : " + Trim(LstCat.SelectedValue) & vbCrLf
            emailMessage.Body += "EmpNo    : " + TxtEmpNo.Text + " Employee : " + Trim(TxtNam.Text) & vbCrLf
            emailMessage.Body += "User Code: " + Trim(L1.Text) + " Date : " + strval & vbCrLf
            emailMessage.Body += "Payment Amount :" + Trim(Trim(strval1)) & vbCrLf
            emailMessage.Body += "Submit Amount  :" + Trim(Trim(StrQty)) & vbCrLf

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



        End If

    End Sub
    Sub DataGrid2_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        Datagrid2.EditItemIndex = e.Item.ItemIndex
        BindTheGrid1()
    End Sub
    Sub DataGrid2_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        Datagrid2.EditItemIndex = -1
        BindTheGrid1()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SEmpno As String
        Dim SEmpcom As String
        Dim SEmpFlag As String
        Dim SEmpTretyp As String
        Dim SEmpAmt As Double
        Dim SEmpAppDt As String
        Dim SEmpNam As String

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT Tre_Typ From TreType", CON)
        CMD.ExecuteNonQuery()

        SEmpno = Mid(TxtEmpNo.Text, 1, 5)
        SEmpcom = Mid(LstCat.SelectedValue, 1, 3)

        SEmpAmt = TxtPay.Text
        SEmpTretyp = Lsttyp.SelectedValue
        SEmpAppDt = Txtappdt.Text
        SEmpDes = " "
        SEmpFlag = "Y"
        SEmpChqNo = TxtChqNo.Text
        SEmpCno = TxtCno.Text

        CMD.Connection = CON
        'CMD.CommandText = ("INSERT INTO RelationMaster(Emp_No,Emp_Com,Emp_Nam,Emp_Retype,Emp_dod,Emp_DeathAmt,Emp_PayDt,Emp_chqno,Emp_DeathFlag) VALUES ('" & SEmpno & "','" & SEmpcom & "'," & SEmpNam & "," & SEmpRetype & "," & SEmpDod & "," & SEmpDeathAmt & "," & SEmpPayDt & "," & SEmpChqNo & "," & SEmpFlag & ")")
        CMD.CommandText = ("INSERT INTO HltMaster1(Emp_No,Emp_Com,Emp_Des,Emp_Typ,Emp_PayDt,Emp_Amt,Emp_chqNo,Emp_Cno,Emp_yr,Emp_mt,Emp_Accyr,Emp_Recdt,Emp_DecAmt,Emp_Decflg,Emp_Eflg1,Emp_Eflg2) VALUES ('" & Trim(TxtTEmpNo.Text) & "','" & SEmpcom & "','" & SEmpDes & "','" & SEmpTretyp & "','09/01/2009'," & SEmpAmt & ",'" & SEmpChqNo & "','" & SEmpCno & "','" & Mid(Trim(SEmpAppDt), 7, 4) & "','" & Mid(Trim(SEmpAppDt), 4, 2) & "','" & Trim(TxtYr1.Text) & "','" & Mid(Trim(SEmpAppDt), 4, 2) + "/" + Mid(Trim(SEmpAppDt), 1, 2) + "/" + Mid(Trim(SEmpAppDt), 7, 4) & "'," & SEmpAmt & ",'No','No','Yes')")
        CMD.ExecuteNonQuery()


        BindTheGrid1()



    End Sub

    Private Sub Lsttyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsttyp.SelectedIndexChanged

    End Sub

    Private Sub Txtappdt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtappdt.TextChanged

    End Sub

    Private Sub TxtYr1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYr1.TextChanged
        LstCat.Enabled = True

        ButSub.Enabled = True
        ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE ((EpfNo = '" & Trim(TxtEmpNo.Text) & "' OR  OldEpfNo='" & Trim(TxtEmpNo.Text) & "') OR  (OldEpfNo1='" & Trim(TxtEmpNo.Text) & "' OR  OldEpfNo2='" & Trim(TxtEmpNo.Text) & "') OR  (OldEpfNo3='" & Trim(TxtEmpNo.Text) & "' OR  OldEpfNo4='" & Trim(TxtEmpNo.Text) & "')) and com='" & Mid(LstCat.SelectedValue, 1, 3) & "'", CON)
        DS = New DataSet
        ss = "SELECT * FROM HthMaster WHERE (EpfNo = '" & TxtEmpNo.Text & "' OR  OldEpfNo='" & TxtEmpNo.Text & "') and com='" & Mid(LstCat.SelectedValue, 1, 3) & "'"
        ADA.Fill(DS, "HthMaster")

        count1 = DS.Tables("HthMaster").Rows.Count

        If count1 <> 0 Then
            TxtNam.ReadOnly = True
            LstCat.Enabled = True
            Button2.Enabled = True
            TxtPay.Enabled = True



            For Each drt2 In DS.Tables("HthMaster").Rows
                StrEmpno = drt2("EpfNo")
                StrEmpCom = drt2("Com")
                StrEmpNam = drt2("EMPLOYEENAME")
                StrOldEpfno = drt2("OldEpfNo")
                TxtNam.Text = StrEmpNam
                TxtTEmpNo.Text = drt2("EpfNo")
                TxtOldEmpNo.Text = drt2("OldEpfNo")
                TxtOldEmpNo1.Text = drt2("OldEpfNo1")
                TxtOldEmpNo2.Text = drt2("OldEpfNo2")
                TxtOldEmpNo3.Text = drt2("OldEpfNo3")
                TxtOldEmpNo4.Text = drt2("OldEpfNo4")

                ADA = New SqlDataAdapter("SELECT * FROM COMPANY WHERE COM_NO = '" & StrEmpCom & "'", CON)
                DS = New DataSet
                ADA.Fill(DS, "COMPANY")
                For Each drt3 In DS.Tables("COMPANY").Rows
                    StrNam = drt3("Com_Nam")
                Next
                LstCat.SelectedValue = StrEmpCom + " - " + StrNam

            Next
        Else
            TxtNam.ReadOnly = True
            LstCat.Enabled = True

            TxtNam.Text = "Record No Found "

            Button2.Enabled = False
            TxtPay.Enabled = False



        End If


        BindTheGrid1()
        Data4()

    End Sub

    Private Sub TxtChqAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtChqAmt.TextChanged
        ButSub.Enabled = True
        TxtEmpNo.Enabled = True
        Txtbal.Text = TxtChqAmt.Text
    End Sub

    Private Sub TxtCno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCno.TextChanged

    End Sub

    Private Sub TxtPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPay.TextChanged

    End Sub

    Private Sub Txtbal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbal.TextChanged

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim gridrow As DataGridItem
        Dim i, J As Double
        Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 As String
        Dim SS As String
        Dim sEmps As String
        Dim dr As DataRow
        Dim SysRtp As Integer
        Dim SysRno As String
        Dim Sysdes1 As String
        Dim sysdes2 As String
        Dim Count As Double
        Dim CMD1 As SqlCommand

        Dim TT As String
        CON.Open()

        Dim field1 As String = CType(Session.Item("field1"), String)

        ' TT = Mid(LstCh4.SelectedValue, 1, 4)
        'TT = Trim(TT)
        CMD = New SqlCommand("SELECT * FROM HthMaster", CON)
        DR2 = CMD.ExecuteReader
        DR2.Close()


        t8 = Format(CDate(Today()), "MM/dd/yyyy")

        txtmsg.Visible = False
       

        CMD.Connection = CON
        'CMD.CommandText = ("UPDATE HltMaster1 SET Raw_Rmk='" & Trim(t9) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & " where Emp_paydt='" & Trim(t1) & "' and Emp_DecAmt=" & Val(Trim(t4)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t2)) & " and Emp_Decflg='Yes' and Id=" & Trim(t2))
        CMD.CommandText = ("UPDATE HltMaster1 SET Ver_User1dt='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Ver_User1Time='" & FormatDateTime(TimeOfDay) & "',Ver_User1='" & Trim(L1.Text) & "' where Emp_no='" & Trim(TxtEmpNo.Text) & "' and Emp_com='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "' and Emp_Accyr='" & Trim(TxtYr1.Text) & "'")
        SS = "UPDATE HltMaster1 SET Ver_User2dt='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Ver_User2Time='" & FormatDateTime(TimeOfDay) & "',Ver_User1='" & Trim(L1.Text) & "' where Emp_no='" & Trim(TxtEmpNo.Text) & "' and Emp_com='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "' and Emp_Accyr='" & Trim(TxtYr1.Text) & "'"

        CMD.ExecuteNonQuery()



       
        Button5.Enabled = False
        CON.Close()
        Data4()
        BindTheGrid1()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim gridrow As DataGridItem
        Dim i, J As Double
        Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 As String
        Dim SS As String
        Dim sEmps As String
        Dim dr As DataRow
        Dim SysRtp As Integer
        Dim SysRno As String
        Dim Sysdes1 As String
        Dim sysdes2 As String
        Dim Count As Double
        Dim CMD1 As SqlCommand

        Dim TT As String
        CON.Open()

        Dim field1 As String = CType(Session.Item("field1"), String)

        ' TT = Mid(LstCh4.SelectedValue, 1, 4)
        'TT = Trim(TT)
        CMD = New SqlCommand("SELECT * FROM HthMaster", CON)
        DR2 = CMD.ExecuteReader
        DR2.Close()


        t8 = Format(CDate(Today()), "MM/dd/yyyy")

        txtmsg.Visible = False


        CMD.Connection = CON
        'CMD.CommandText = ("UPDATE HltMaster1 SET Raw_Rmk='" & Trim(t9) & "',Tot_ChqAmt=" & Trim(TxtChqAmt.Text) & " where Emp_paydt='" & Trim(t1) & "' and Emp_DecAmt=" & Val(Trim(t4)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t2)) & " and Emp_Decflg='Yes' and Id=" & Trim(t2))
        CMD.CommandText = ("UPDATE HltMaster1 SET Ver_User2dt='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Ver_User2Time='" & FormatDateTime(TimeOfDay) & "',Ver_User2='" & Trim(L1.Text) & "' where Emp_no='" & Trim(TxtEmpNo.Text) & "' and Emp_com='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "' and Emp_Accyr='" & Trim(TxtYr1.Text) & "'")
        SS = "UPDATE HltMaster1 SET Ver_User1dt='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Ver_User1Time='" & FormatDateTime(TimeOfDay) & "',Ver_User1='" & Trim(L1.Text) & "' where Emp_no='" & Trim(TxtEmpNo.Text) & "' and Emp_com='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "' and Emp_Accyr='" & Trim(TxtYr1.Text) & "'"

        CMD.ExecuteNonQuery()




        Button5.Enabled = False
        CON.Close()
        Data4()
        BindTheGrid1()


    End Sub
End Class
