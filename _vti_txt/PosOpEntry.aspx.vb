Imports System.Data.SqlClient
Imports System.Data

Public Class PosOpEntry
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

    Dim TotsDate, Totssec, TotWkhrs, TotOthrs As String

    Dim count1 As Integer


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
    Protected WithEvents LstCat As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TxtQty As System.Web.UI.WebControls.TextBox
    Protected WithEvents TxtVal As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
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
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        Global.PwFlag = "N"

        If Global.PwLevel = "1" Then
            Global.PwFlag = "Y"

        Else

            If Global.PwLevel = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level2='1'", CON)

            Else
                If Global.PwLevel = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level3='1'", CON)

                Else
                    If Global.PwLevel = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level4='1'", CON)
                    Else
                        If Global.PwLevel = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level5='1'", CON)

                        Else
                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If




                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                Global.PwFlag = "Y"
            End While

            DR.Close()

        End If


        If Global.PwFlag = "Y" Then
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



            Data4()
        End If

        CON.Close()
    End Sub



    Private Sub Data4()
        'CON.Open()

        'Dim TT, TT1 As String
        'CMD = New SqlCommand("SELECT * FROM MonthName", CON)
        'DR2 = CMD.ExecuteReader
        'DR2.Close()

        'Dim AA As String

        'Dim SS As String
        'Dim sEmps As String
        'Dim dr As DataRow
        'Dim SysRtp As Integer
        'Dim SysRno As String
        'Dim Sysdes1 As String
        'Dim sysdes2 As String
        'Dim Count As Double
        'Dim CMD1 As SqlCommand

        ''CMD.CommandText = ("DELETE FROM TraTemp")
        '' CMD.ExecuteNonQuery()


        'AA = Mid(LstMth.SelectedValue, 1, 2)
        'SS = "SELECT Format(Tra_date,'dd/MM/yyyy') as Tradate,Tra_EmpNo,Tra_Intime,Tra_outtime FROM Dlytran WHERE year(Tra_date)='" & TxtYear.Text & "' AND month(Tra_date)='" & Mid(LstMth.SelectedValue, 1, 2) & "'"
        'ADA = New SqlDataAdapter("SELECT Tra_date,Tra_EmpNo,Emp_Nam,Tra_Intime,Tra_outtime FROM Dlytran,EmpMaster WHERE EmpMaster.Emp_No=dlyTran.Tra_EmpNo and Tra_yr='" & TxtYear.Text & "' AND Tra_mt='" & Mid(LstMth.SelectedValue, 1, 2) & "' and Tra_flag='Y' Order by Tra_date,Tra_EmpNo", CON)

        'DS = New DataSet
        ''ADA = New SqlDataAdapter("SELECT TRA_RNO,TRA_DES1,TRA_CRD,TRA_DBT FROM TRATEMP", CON)
        'ADA.Fill(DS, "Dlytran")
        'DataGrid1.DataSource = DS.Tables("Dlytran")
        'DataGrid1.DataBind()

        'CON.Close()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()
        ' Global.PCAT = Mid(LstCat.SelectedValue, 1, 2)
        ss = "SELECT Raw_ItmCode,Raw_des,Raw_Qtytyp,Raw_opStk FROM RawMaster WHERE raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "'"
        'Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT RawMaster.Raw_ItmCode as Raw_ItmCode,RawMaster.Raw_des as Raw_des,convert(decimal(9,2),ItmMaster.Itm_Pri,2) as StkSpr,Raw_opStk FROM RawMaster,ItmMaster WHERE ItmMaster.Itm_code=RawMaster.Raw_ItmCode and  RawMaster.raw_cat='" & Mid(LstCat.SelectedValue, 1, 2) & "' order by RawMaster.Raw_ItmCode", CON)
        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)
        Dim cmdCustomers As SqlCommand = New SqlCommand("Select convert(varchar(10),HltMaster1.Emp_PayDt,103) as Emp_Paydt,HltMaster1.Emp_No as Emp_No ,HthMaster.EmployeeName as Emp_Nam,convert(decimal(9,2),HltMaster1.Emp_DecAmt,2) as Emp_DecAmt,HltMaster1.Emp_Amt as Emp_Amt from HltMaster1 ,HthMaster where HltMaster1.Emp_No=HthMaster.Epfno and HltMaster1.Emp_Com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and HltMaster1.Emp_DecFlg='Yes'", CON)

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

    Private Sub DataGrid1_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs)
        Dim Tdate As String
        Dim TSchNo As String
        Dim TSchin As String
        Dim TSchout As String
        Dim TSchnam As String


        If e.Item.ItemType.ToString = "Item" Or e.Item.ItemType.ToString = "AlternatingItem" Then


            ' Tdate = e.Item.Cells(0).Text
            TSchNo = Trim(e.Item.Cells(0).Text)
            TSchnam = Trim(e.Item.Cells(1).Text)
            TSchin = Trim(e.Item.Cells(3).Text)
            TSchout = Trim(e.Item.Cells(4).Text)


            ' Dim chkExp1 As Label = e.Item.FindControl("Emp_Paydt")
            ' chkExp1.Text = TSchNo
            'Dim chkExp2 As Label = e.Item.FindControl("Emp_No")
            'chkExp2.Text = TSchnam
            'Dim chkExp3 As Label = e.Item.FindControl("Emp_DecAmt")
            'chkExp3.Text = TSchin
            'Dim chkExp4 As TextBox = e.Item.FindControl("Emp_Amt")
            ' chkExp4.Text = TSchout

            CalculateTotal(e.Item.Cells(4).Text)
            'CalculateTotal1(Val(e.Item.Cells(2).Text) * Val(e.Item.Cells(3).Text))
        ElseIf (e.Item.ItemType = ListItemType.Footer) Then

            Dim txtCRD As TextBox = e.Item.FindControl("TXTtotcrd")
            Dim txtDbt As TextBox = e.Item.FindControl("TXTtotDbt")
            TxtQty.Text = theTotal
            TxtVal.Text = Format(theTotal, "##,###,###.##")


        End If

    End Sub

    Private Sub CalculateTotal(ByVal theQuantity As String)
        theTotal += Double.Parse(theQuantity)
    End Sub
    Private Sub CalculateTotal1(ByVal theQuantity1 As String)
        theTotal1 += Double.Parse(theQuantity1)
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
        CMD = New SqlCommand("SELECT * FROM HthMaster", CON)
        DR2 = CMD.ExecuteReader
        DR2.Close()



        'CMD.CommandText = ("Delete from Maintra WHERE Tra_Year='" & TxtYear.Text & "' AND Tra_Mth='" & Mid(LstMth.SelectedValue, 1, 2) & "' AND mid(Tra_Rno,1,4) ='" & TT & "'")
        '' CMD.ExecuteNonQuery()

        For Each gridrow In DataGrid1.Items
            t1 = CType(gridrow.FindControl("Emp_No"), Label).Text
            t2 = CType(gridrow.FindControl("Emp_DecAmt"), Label).Text

            ''t3 = CType(gridrow.FindControl("StkSpr"), Label).Text 'gridrow.FindControl("Tra_Rno").Text
            t4 = CType(gridrow.FindControl("Emp_Amt"), TextBox).Text


            ADA = New SqlDataAdapter("SELECT * FROM HltMaster1 WHERE Emp_No=" & Val(Trim(t1)), CON)
            DS = New DataSet

            ADA.Fill(DS, "HltMaster1")

            count1 = DS.Tables("HltMaster1").Rows.Count
            ' Swk = ((Val(Mid(t4, 1, 2)) * 60 * 60 + Val(Mid(t4, 4, 2)) * 60 + Val(Mid(t4, 7, 2))) - (Val(Mid(t3, 1, 2)) * 60 * 60 + Val(Mid(t3, 4, 2)) * 60 + Val(Mid(t3, 7, 2)))) / 3600
            If count1 <> 0 Then
                CMD.Connection = CON
                CMD.CommandText = ("UPDATE HltMaster1 SET Emp_Amt='" & t4 & "',Emp_Decflg='No'  where Emp_DecAmt=" & Val(Trim(t2)) & " and Emp_com='" & Trim(Mid(LstCat.SelectedValue, 1, 3)) & "' and  Emp_No=" & Val(Trim(t1)) & " and Emp_Decflg='Yes'")
                CMD.ExecuteNonQuery()
            End If


            'CON.Close()


        Next

        CON.Close()
        Data4()

        BtnUpdate.Enabled = False

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        strReport = "PopView11.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strReport As String = ""
        strReport = "PopView12.aspx"
        Dim strJS As String = "<script>window.open('" & strReport & "','WindowName','height=750,width=800,left=0,top=10,scrollbars=yes,status=no');<" & "/script>"
        Page.RegisterStartupScript("OpenWindow", strJS)
    End Sub

    Private Sub TxtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQty.TextChanged

    End Sub
End Class
