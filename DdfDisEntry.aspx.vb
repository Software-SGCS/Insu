Imports System.Data.SqlClient
Imports System.Data

Public Class DdfDisEntry
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Private theTotal As Double = 0
    Private theTotal1 As Double = 0
    Private theTotal2 As Double = 0
    Private theTotalVal As Double = 0
    Private theTotalVal1 As Double = 0
    Private theTotalVal2 As Double = 0
    Dim drt2, drt3, drt1, drt4, drt5 As DataRow
    Dim Sempno, Sdate, SempNam, Sin, Sout, Swk, Ssec, SOT, Shr, ss1, Syr, Smt, incomplete, SOT1, SOT2 As String
    Dim SWK1 As Single
    Dim ss, ss2, Msg1, fg1 As String

    Dim TotsDate, Totssec, TotWkhrs, TotOthrsm, pflag, psec As String

    Dim count1, Count2 As Integer


    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
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
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtMt As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtYr As System.Web.UI.WebControls.TextBox
    Protected WithEvents LstCat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtQty3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQty2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtQty1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtVal1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtVal2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtVal3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents LstDist As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TxtMsg1 As System.Web.UI.WebControls.TextBox
    Dim TT As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

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
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosPhEntry.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosPhEntry.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosPhEntry.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosPhEntry.aspx' and Form_level5='1'", CON)

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

        BtnUpdate.Enabled = True

        If Not IsPostBack Then
            CMD = New SqlCommand("SELECT Com_No,Com_nam From Company ", CON)


            DR = CMD.ExecuteReader



            While DR.Read
                TT = DR.GetValue(0) + " - " + DR.GetValue(1)
                LstCat.Items.Add(TT)
            End While

            DR.Close()

            CMD = New SqlCommand("SELECT Dis_Code,Dis_Name From District ", CON)


            DR1 = CMD.ExecuteReader



            While DR1.Read
                TT = DR1.GetValue(0) + " - " + DR1.GetValue(1)
                LstDist.Items.Add(TT)
            End While



            DR1.Close()

            Data4()
        End If





        '  Data4()
        '  End If




        CON.Close()
    End Sub



    Private Sub Data4()


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        ss = "Select convert(varchar(10),RelationMaster.Emp_InsDt,103) as Raw_ItmCode,RelationMaster.Emp_No as Raw_des ,RelationMaster.Emp_Nnam as Itm_pri,EmpMaster.Emp_Nam as Raw_opStk,RelationMaster.Emp_ChqNo as EmpChqNo,RelationMaster.Emp_Paydt as EmpCno,RelationMaster.Emp_DeathAmt as Raw_Soh from RelationMaster ,EmpMaster where RelationMaster.Emp_No=EmpMaster.Emp_No and (RelationMaster.Emp_InsFg='Y' AND RelationMaster.Cer_Flag='Y')"
        'Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT RawMaster.Raw_ItmCode as Raw_ItmCode ,RawMaster.Raw_des as Raw_des,ItmMaster.Itm_Pri as Itm_pri,RawMaster.Raw_opStk as Raw_opStk,convert(decimal(7),RawMaster.Raw_Soh,0)  as Raw_Soh,RawMaster.Raw_PhStock as Raw_PhStock FROM RawMaster,ItmMaster WHERE RawMaster.Raw_ItmCode=ItmMaster.Itm_code and  RawMaster.raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "' Order by RawMaster.Raw_ItmCode", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select convert(varchar(10),HltMaster1.Emp_PayDt,103) as Emp_Paydt,HltMaster1.Emp_No as Emp_No ,HthMaster.EmployeeName as Emp_Nam,HltMaster1.Emp_DecAmt as Emp_DecAmt,HltMaster1.Emp_Amt as Emp_Amt from HltMaster1 ,HthMaster where HltMaster1.Emp_No=HthMaster.Epfno and HltMaster1.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and HltMaster1.Emp_DecFlg='Yes'", CON)
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select convert(varchar(10),RelationMaster.Emp_InsDt,103) as Raw_ItmCode,RelationMaster.Emp_No as Raw_des ,EmpMaster.Emp_Nam as Itm_pri,RelationMaster.Emp_Nam as Raw_opStk,RelationMaster.Emp_ChqNo as EmpChqNo,RelationMaster.Emp_Paydt as EmpCno,RelationMaster.Emp_DeathAmt as Raw_Soh,RelationMaster.Id as EmpId from RelationMaster ,EmpMaster where (RelationMaster.Emp_No=EmpMaster.Emp_No AND RelationMaster.Emp_COM=EmpMaster.Emp_COM)  and (RelationMaster.Emp_InsFg='Y' AND RelationMaster.Cer_Flag='N') And RelationMaster.Emp_cOM='" & Mid(Trim(LstCat.SelectedValue), 1, 3) & "'", CON)
        cmdCustomers.CommandType = CommandType.Text
        DataGrid1.Enabled = True
        DataGrid1.DataSource = cmdCustomers.ExecuteReader()
        DataGrid1.DataBind()
        DataGrid1.Visible = True
        CON.Close()


        '-------
    End Sub



    Private Sub LstMth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnUpdate.Enabled = True
        Data4()
    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound
        Dim Tdate As String
        Dim TSchNo As String
        Dim TSchin As String
        Dim TSchout As String
        Dim TSchnam As String
        Dim soh As String
        Dim pstk As String

        Dim t1, t2, t3, t4, t5, t6, t7, t8, t9 As String

        If e.Item.ItemType.ToString = "Item" Or e.Item.ItemType.ToString = "AlternatingItem" Then


            ' Tdate = e.Item.Cells(0).Text
            t1 = Trim(e.Item.Cells(0).Text)
            t2 = Trim(e.Item.Cells(1).Text)
            t3 = Trim(e.Item.Cells(2).Text)
            t4 = Trim(e.Item.Cells(3).Text)
            t5 = Trim(e.Item.Cells(7).Text)
            t6 = Trim(e.Item.Cells(8).Text)
            t7 = Trim(e.Item.Cells(5).Text)
            t8 = Trim(e.Item.Cells(9).Text)


            Dim chkExp1 As Label = e.Item.FindControl("Raw_ItmCode")
            chkExp1.Text = t1
            Dim chkExp2 As Label = e.Item.FindControl("Raw_des")
            chkExp2.Text = t2
            Dim chkExp3 As Label = e.Item.FindControl("Itm_Pri")
            chkExp3.Text = t3
            Dim chkExp4 As Label = e.Item.FindControl("Raw_OpStk")
            chkExp4.Text = t4




            ''CalculateTotal(e.Item.Cells(3).Text)
            ''CalculateTotalval(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(3).Text))

            ''CalculateTotal1(e.Item.Cells(4).Text)
            ''CalculateTotalval1(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(4).Text))

            ''CalculateTotal2(e.Item.Cells(5).Text)
            '' CalculateTotalval(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(5).Text))

        ElseIf (e.Item.ItemType = ListItemType.Footer) Then

            '' TxtQty1.Text = theTotal
            '' TxtQty2.Text = theTotal1
            '' TxtQty3.Text = theTotal2

            '' TxtVal1.Text = theTotalVal

            '' TxtVal2.Text = theTotalVal1
            '' TxtVal3.Text = theTotalVal2

        End If

    End Sub

    Private Sub CalculateTotal(ByVal theQuantity As String)
        ' theTotal += Double.Parse(theQuantity)
    End Sub
    Private Sub CalculateTotal1(ByVal theQuantity1 As String)
        ' theTotal1 += Double.Parse(theQuantity1)
    End Sub
    Private Sub CalculateTotal2(ByVal theQuantity As String)
        'theTotal2 += Double.Parse(theQuantity)
    End Sub

    Private Sub CalculateTotalval(ByVal theQuantityVal As String)
        'theTotalVal += Double.Parse(theQuantityVal)
    End Sub
    Private Sub CalculateTotalval1(ByVal theQuantityVal1 As String)
        ' theTotalVal1 += Double.Parse(theQuantityVal1)
    End Sub

    Private Sub CalculateTotalval2(ByVal theQuantityVal2 As String)
        ' theTotalVal2 += Double.Parse(theQuantityVal2)
    End Sub


    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
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
        CMD = New SqlCommand("SELECT * FROM HltMaster1", CON)
        DR2 = CMD.ExecuteReader
        DR2.Close()



        'CMD.CommandText = ("Delete from Maintra WHERE Tra_Year='" & TxtYear.Text & "' AND Tra_Mth='" & Mid(LstMth.SelectedValue, 1, 2) & "' AND mid(Tra_Rno,1,4) ='" & TT & "'")
        '' CMD.ExecuteNonQuery()
        Msg1 = ""
        TxtMsg1.Text = ""
        For Each gridrow In DataGrid1.Items
            fg1 = "N"

            t1 = CType(gridrow.FindControl("Raw_ItmCode"), Label).Text
            t2 = CType(gridrow.FindControl("Raw_des"), Label).Text

            t3 = CType(gridrow.FindControl("Itm_pri"), Label).Text 'gridrow.FindControl("Tra_Rno").Text
            t4 = CType(gridrow.FindControl("Raw_OpStk"), Label).Text
            t6 = CType(gridrow.FindControl("empCno"), TextBox).Text
            t7 = CType(gridrow.FindControl("empChqno"), TextBox).Text

            If Trim(t6) = "" Then
                t6 = "*"
            End If
            If Trim(t7) = "" Then
                t7 = "*"
            End If
            ADA = New SqlDataAdapter("SELECT * FROM RelationMaster WHERE Dis_Code='" & Trim(t7) & "' and Cer_No='" & Trim(t6) & "'", CON)
            DS = New DataSet

            ADA.Fill(DS, "RelationMaster")

            count1 = DS.Tables("RelationMaster").Rows.Count
            ' Swk = ((Val(Mid(t4, 1, 2)) * 60 * 60 + Val(Mid(t4, 4, 2)) * 60 + Val(Mid(t4, 7, 2))) - (Val(Mid(t3, 1, 2)) * 60 * 60 + Val(Mid(t3, 4, 2)) * 60 + Val(Mid(t3, 7, 2)))) / 3600
            If count1 = 0 Then

                If Trim(t6) = "*" Or Trim(t7) = "*" Then


                Else


                    CMD.Connection = CON
                    SS = "UPDATE RelationMaster SET Emp_DeathAmt=" & Trim(t8) & ",Emp_Chqno='" & Trim(t7) & "',Emp_PayDt='" & Mid(Trim(t6), 4, 2) + "/" + Mid(Trim(t6), 1, 2) + "/" + Mid(Trim(t6), 7, 4) & "',Emp_InsFg='N' where Emp_No=" & Val(Trim(t2)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and Emp_InsFg='Y'"
                    CMD.CommandText = ("UPDATE RelationMaster SET Dis_Code='" & Trim(t7) & "',Cer_No='" & Trim(t6) & "',cer_flag='Y' where Emp_No='" & Trim(t2) & "' and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and Emp_Nam='" & Trim(t4) & "' and Emp_InsFg='Y'")
                    CMD.ExecuteNonQuery()
                    fg1 = "Y"
                End If
            Else


                For Each dr In DS.Tables("RelationMaster").Rows
                    Msg1 = Msg1 + "Duplcate Death Certificate No :" + Trim(dr("Cer_No")) + " EPF #:" + Trim(dr("Emp_No")) + " " + Trim(dr("Emp_Nam")) + " Company:" + Trim(dr("Emp_Com"))
                    fg1 = "N"
                Next

            End If

            'CON.Close()


        Next

        CON.Close()
        Data4()
        If Trim(Msg1) = "" Then
            TxtMsg1.Visible = False
            'TxtMsg1.Text = Msg1
        Else
            TxtMsg1.Visible = True
            TxtMsg1.Text = Msg1

        End If


        BtnUpdate.Enabled = False

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged
        '<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DataEntry1.aspx.vb" Inherits="Fleet.DataEntry1"%>
        '<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
        '<HTML>


        '  <asp:BoundColumn Visible="False" DataField="Tra_Rno" HeaderText="Rec No"></asp:BoundColumn>
        '<asp:BoundColumn Visible="False" DataField="Tra_Des1" HeaderText="Description"></asp:BoundColumn>
        '<asp:BoundColumn Visible="False" DataField="Tra_Crd" HeaderText="Credit1"></asp:BoundColumn>
        '<asp:BoundColumn Visible="False" DataField="Tra_Dbt" HeaderText="Debit1"></asp:BoundColumn>

    End Sub

    Private Sub LstMth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data4()
    End Sub





    Private Sub LstMth1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnUpdate.Enabled = True
        Data4()
    End Sub

    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function

    Private Sub Txtdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data4()
    End Sub

    Private Sub LstGrd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Data4()
    End Sub

    Private Sub ImgBt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)

        Data4()

    End Sub


    Private Sub LstCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCat.SelectedIndexChanged
        Data4()
    End Sub

    Private Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim strReport As String = ""
        strReport = "PopView14.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
    End Sub
End Class
