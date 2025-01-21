Imports System.Data.SqlClient
Imports System.Data


Public Class NewEntry2New

    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2 As SqlDataReader
    Dim DS As DataSet
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
    Dim ss, ss2 As String

    Dim TotsDate, Totssec, TotWkhrs, TotOthrs, PFLAG, PSEC As String

    Dim count1, COUNT2 As Integer


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

        L1.Text = USER11


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()


        PFLAG = "N"


        ADA = New SqlDataAdapter("SELECT * FROM UsdMaster WHERE User_code = '" & USER11 & "'", CON)




        DS = New DataSet
        ADA.Fill(DS, "UsdMaster")

        count1 = DS.Tables("UsdMaster").Rows.Count


        If count1 <> 0 Then


            For Each drt2 In DS.Tables("UsdMaster").Rows
                ' LstCom.SelectedValue = dr1("Veh_Com")


                COUNT2 = drt2("User_lvl")
                PSEC = drt2("User_sec")


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
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry2.aspx' and Form_level2='1'", CON)

                Else
                    If COUNT2 = "3" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry2.aspx' and Form_level3='1'", CON)

                    Else
                        If COUNT2 = "4" Then
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry2.aspx' and Form_level4='1'", CON)
                        Else
                            If COUNT2 = "5" Then

                                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='NewEntry2.aspx' and Form_level5='1'", CON)

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

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select HthMaster.Epfno as Raw_ItmCode,HthMaster.Epfno as Raw_SOH,HthMaster.Epfno as Raw_des ,HthMaster.EmployeeName as Itm_pri,HthMaster.OldEpfNo as Raw_opStk,HthMaster.Epfno as  Raw_PhStock,HthMaster.Epfno as Raw_rec from HthMaster where HthMaster.Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' AND HthMaster.EmpAct='Y' ORDER BY STR(HthMaster.Epfno)", CON)


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
        ButSub.Enabled = True
        Data4()
    End Sub

    Private Sub ButSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSub.Click
        Dim gridrow As DataGridItem
        Dim i As Integer
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



        ' TT = Mid(LstCh4.SelectedValue, 1, 4)
        'TT = Trim(TT)
        CMD = New SqlCommand("SELECT * FROM HthMaster", CON)
        DR2 = CMD.ExecuteReader
        DR2.Close()


        t8 = Format(CDate(Today()), "MM/dd/yyyy")


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


            If Trim(t1) <> Trim(t6) Then
                ' ADA = New SqlDataAdapter("SELECT * FROM HthMaster WHERE where EpfNo='" & Trim(t2) & "' and Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "'", CON)
                ' DS = New DataSet

                'ADA.Fill(DS, "HthMaster")

                ' count1 = DS.Tables("HthMaster").Rows.Count
                ' Swk = ((Val(Mid(t4, 1, 2)) * 60 * 60 + Val(Mid(t4, 4, 2)) * 60 + Val(Mid(t4, 7, 2))) - (Val(Mid(t3, 1, 2)) * 60 * 60 + Val(Mid(t3, 4, 2)) * 60 + Val(Mid(t3, 7, 2)))) / 3600
                ' If count1 <> 0 Then
                ' t1 = Mid(Trim(t1), 4, 2) + "/" + Mid(Trim(t1), 1, 2) + "/" + Mid(Trim(t1), 7, 4)

                CMD.Connection = CON
                '''FormatDateTime(TimeOfDay) & "','" & Format(DateValue(Today()), "MM/dd/yyyy") &
                SS = "UPDATE HthMaster SET EmpAct='" & t6 & "',Act_Code='" & Trim(L1.Text) & "',Act_time='" & FormatDateTime(TimeOfDay) & "',Act_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "',Act_Act='" & Trim(t6) & "' where EpfNo='" & Trim(t2) & "' and Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "'"
                CMD.CommandText = ("UPDATE HthMaster SET Epfno='" & Trim(t6) & "',OldEpfno='" & Trim(t1) & "', Ent_Code='" & Trim(L1.Text) & "',Ent_time='" & FormatDateTime(TimeOfDay) & "',Ent_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "' where EpfNo='" & Trim(t1) & "' and Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "'")
                CMD.ExecuteNonQuery()

                'End If

                CMD.Connection = CON
                
                CMD.CommandText = ("UPDATE eMPMaster2 SET Emp_No='" & Trim(t6) & "', Ent_Code='" & Trim(L1.Text) & "',Ent_time='" & FormatDateTime(TimeOfDay) & "',Ent_Date='" & Format(DateValue(Today()), "MM/dd/yyyy") & "' where Emp_No='" & Trim(t1) & "' and Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "'")
                CMD.ExecuteNonQuery()



            End If


            'CON.Close()


        Next

        CON.Close()
        Data4()

        ButSub.Enabled = False
    End Sub
End Class
