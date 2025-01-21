
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO

Public Class Upload3
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    'Dim OBJ1 As New WORD
    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD, cmd2 As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim KKK As String
    Dim txt, Nam, MTN, scode, FileName1, P2, venu, P11, SS, V1, V2, FD As String
    Dim FileName, HD, IDNAME As String
    Dim FileHandle As String
    Dim FileStream As String
    Dim Recordoffset As Long
    Dim Txvalue, tx1 As String
    Dim Intvalue, intvalue1, ITMTYP, SNO, PA, P As String
    Dim FilName As String
    Dim date1, Date2, date3, te_frddt As Date
    Dim ext1, stmt, stdy, sthh, stmm, stss, styr, enmt, endy, enhh, enss, enyr, enmm, dial1, tradate, traflag, dhh, dmm, dss, dest1, ccode, SaveCom, SaveEmpno As String
    Dim I, J, POS, L1, L2, P1, SIT As Integer
    Dim DDD, MMM, YYY, Seqno, Ssno, DD1, DD2, TXTFILE, seccode, tradate1, itmcode, dlyqty, secccode, itmdesc, Itmmarks, ItmTime As String
    Dim Cri As String
    Dim SCode1, Ssec, Ssecnam, Ssec1, SitmDesc As String
    Dim path1 As String
    Dim ComCode, EmpNo, EmpNam, EmpDob, EmpNic, EmpNoCld, EmpOldNo, EmPRNam, EmpTyp, EmpRDob, Ans1, Ans2, Ans3, Ans4 As String

    Dim COUNT, QT0, QT1, QT2, COUNT1 As Integer
    Dim STR, PATH As String
    Dim Fileno, Rowno As Double
    Dim GTOT, totqty, DBCOUNT, Tval, Tamt, ITMVAL As Double
    Dim intFileNameLength As Integer
    Dim strFileNamePath As String
    Dim strFileNameOnly As String
    Dim DT1, DT2 As String
    Dim GGTOT, LINVAL As Double
    Dim FNAME, Q, FID, FIDR, Seq, DDT As String
    Dim drt2, drt3, drt1, drt4, drt5 As DataRow
    Protected WithEvents fileUpload As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents MyDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents TxtSt As System.Web.UI.WebControls.TextBox
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label

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
        'CON = New SqlConnection("data source=XPDSS;UID=POS;PWD=POS")
        'CON.Open()
        'OBJ1.ConnectDBH()
        PA = Server.MapPath("IFS")
        Label6.Text = ""


        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        Global.PwFlag = "N"

        'If Global.PwLevel = "1" Then
        '    Global.PwFlag = "Y"

        'Else
        '    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='upload2.aspx' and Form_level='" & Global.PwLevel & "'", CON)

        '    DR = CMD.ExecuteReader
        '    While DR.Read
        '        Global.PwFlag = "Y"
        '    End While

        '    DR.Close()

        'End If


        'If Global.PwFlag = "Y" Then
        '    ' Response.AddHeader("Refresh", 1800)
        'Else
        '    Response.Redirect("InsuDept.aspx")
        'End If
        ' BindTheGrid()


        Response.AddHeader("Refresh", 1800)

        PA = Server.MapPath("IFS")
        Label6.Text = ""

        If Not IsPostBack Then
            V1 = "http://192.168.12.133\POS\PHOTO\HOME.jpg"
            V2 = "http://192.168.12.133\POS\PHOTO\mail.gif"
            If IsDBNull(V1) = False Then
                ' Image1.Visible = True
                'Image1.ImageUrl = V1
            End If
            If IsDBNull(V2) = False Then
                'Image2.Visible = True
                'Image2.ImageUrl = V2
            End If

            Button2.Enabled = True
            Button3.Enabled = False
            Response.AddHeader("Refresh", 1)

        End If
    End Sub

    Private Sub Image2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        RequiredFieldValidator1.Enabled = False
        Response.Redirect("Email.aspx")
    End Sub

    Private Sub Image1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        RequiredFieldValidator1.Enabled = False
        Response.Redirect("MainMenu.aspx")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        If fileUpload.PostedFile.FileName <> "" Then
            RequiredFieldValidator1.Enabled = True
            Label3.Text = ""
          
            If Not (fileUpload.PostedFile Is Nothing) Then
                FileName = fileUpload.PostedFile.FileName
                strFileNamePath = fileUpload.PostedFile.FileName
                intFileNameLength = InStr(1, StrReverse(strFileNamePath), "\")
                strFileNameOnly = Mid(strFileNamePath, (Len(strFileNamePath) - intFileNameLength) + 2)
                txt = strFileNameOnly
                IDNAME = UCase(strFileNameOnly)
                fileUpload.PostedFile.SaveAs(Server.MapPath(".") + "\Data\" & strFileNameOnly)
            End If

            Dim DeleteCmd As String = "DELETE from TempEmp "
            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            Cmd.ExecuteNonQuery()


            Label6.Text = txt
            SS = "p"

            Nam = Server.MapPath(".") + "\Data\"
            Nam = Nam + txt

            Dim WR As New StreamReader(Nam)

            'STR = WR.ReadLine
            'STR = WR.ReadLine
            STR = WR.ReadLine
            STR = WR.ReadLine

            Do While Not STR Is Nothing
                DDT = Trim(Mid(STR, 67, 14))
                MMM = Mid((DDT), 4, 2)
                MTN = "SSS"
                path1 = Trim("" & Nam & "")
                SCode1 = UCase(Mid(Trim("" & txt & ""), 1, 3))
                scode = SCode1

                DDD = Mid(DDT, 1, 2)

                YYY = Mid(DDT, 7, 4)
                traflag = "S"
                Q = DDD

                DD1 = MMM & "/" & DDD & "/" & YYY


                'ITMTYP = Trim(UCase(Mid(STR, 16, 16)))
                'QT1 = Trim(Mid(STR, 52, 20))
                ' QT1 = Val(QT1)
                ComCode = Trim(Mid(STR, 1, 16))
                EmpNo = Trim(Mid(STR, 17, 8))
                EmpNam = Trim(UCase(Mid(STR, 26, 42)))
                EmpDob = Trim(UCase(Mid(STR, 67, 14)))


                If Mid(EmpDob, 5, 1) = "/" Then
                    EmpDob = Mid(EmpDob, 6, 2) + "/" + Mid(EmpDob, 9, 2) + "/" + Mid(EmpDob, 1, 4)
                Else
                    EmpDob = Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 7, 4)
                End If

                If Trim(EmpDob) = "////" Then

                    EmpDob = "01/01/2000"
                End If


                EmpNic = Trim(UCase(Mid(STR, 86, 12)))
                If EmpNic = "" Then
                    EmpNic = "Nil"
                Else

                End If


                EmpNoCld = Trim(UCase(Mid(STR, 101, 12)))
                If EmpNoCld = "" Then
                    EmpNoCld = "0"
                Else

                End If

                EmpOldNo = Trim(UCase(Mid(STR, 121, 13)))
                If EmpOldNo = "" Then
                    EmpOldNo = "0"
                Else

                End If




                EmPRNam = Trim(UCase(Mid(STR, 138, 42)))


                If EmPRNam = "" Then
                    EmPRNam = "Nil"
                Else

                End If


                EmpTyp = Trim(UCase(Mid(STR, 179, 20)))
                If EmpTyp = "" Then
                    EmpTyp = "Nil"
                Else

                End If




                EmpRDob = Trim(UCase(Mid(STR, 200, 17)))


                If EmpRDob = "" Then
                    EmpRDob = "01/01/2000"
                Else
                    If Mid(EmpRDob, 5, 1) = "/" Then
                        EmpRDob = Mid(EmpRDob, 6, 2) + "/" + Mid(EmpRDob, 9, 2) + "/" + Mid(EmpRDob, 1, 4)
                    Else

                        EmpRDob = Mid(EmpRDob, 4, 2) + "/" + Mid(EmpRDob, 1, 2) + "/" + Mid(EmpRDob, 7, 4)

                    End If



                End If
                If Trim(EmpRDob) = "////" Then
                    EmpRDob = "01/01/2000"
                End If
                SS = "INSERT INTO TempEmp(Com_Code,Emp_No,Emp_Nam,Emp_Dob,Emp_Nic,Emp_Nocld,Emp_OldNo,Emp_Rnam,Emp_Rtyp,Emp_Rdob) VALUES ('" & ComCode & "','" & EmpNo & "','" & EmpNam & "','" & EmpDob & "','" & EmpNic & "','" & EmpNoCld & "','" & EmpOldNo & "'," & EmPRNam & "','" & EmpTyp & ",'" & EmpRDob & "')"
                ''  Format(Emp_Dod,'dd/MM/yyyy')


                Try

                    Cmd.Connection = CON
                    Cmd.CommandText = ("INSERT INTO TempEmp(Com_Code,Emp_No,Emp_Nam,Emp_Dob,Emp_Nic,Emp_Nocld,Emp_OldNo,Emp_Rnam,Emp_Rtyp,Emp_Rdob) VALUES ('" & ComCode & "','" & EmpNo & "','" & EmpNam & "','" & EmpDob & "','" & EmpNic & "','" & EmpNoCld & "','" & EmpOldNo & "','" & EmPRNam & "','" & EmpTyp & "','" & EmpRDob & "')")
                    Cmd.ExecuteNonQuery()

                    'labelStatus.Text = "Message sent!"
                    'Button1.Enabled = False
                Catch ex As Exception
                    TxtSt.Text += ComCode + " " + EmpNo + " " + Mid(EmpNam, 1, 20) + " " + Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 7, 4) + " " + Mid(EmpRDob, 4, 2) + "/" + Mid(EmpRDob, 1, 2) + "/" + Mid(EmpRDob, 7, 4) & vbCrLf
                    ' labelStatus.Text = ex.ToString
                End Try




                Recordoffset = Recordoffset + 1




                STR = WR.ReadLine




            Loop

            WR.Close()


            'CREATE TEXT FILE



        Else
            Label3.Text = "Please Select Text File Path"
        End If
        BindTheGrid()

        Button2.Enabled = False
        Button3.Enabled = True

        RequiredFieldValidator1.Enabled = False
        BindTheGrid()




    End Sub

    Public Sub BindTheGrid()
        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        SS = "SELECT ID,Com_Code,Emp_No,Emp_Nam,Convert(Varchar(10),Emp_Dob,103) AS Emp_Dob,Emp_Nic,Emp_Nocld,Emp_OldNo,Emp_RNam,Emp_Rtyp,Convert(Varchar(10),Emp_RDob,103) AS Emp_RDob FROM TempEmp order by Com_Code,Emp_no"
        ''Format(Emp_Dod,'dd/MM/yyyy')Format(Tra_date,,'dd/MM/yyyy')


        Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT ID,Com_Code,Emp_No,Emp_Nam,Convert(Varchar(10),Emp_Dob,103) AS Emp_Dob,Emp_Nic,Emp_Nocld,Emp_OldNo,Emp_RNam,Emp_Rtyp,Convert(Varchar(10),Emp_RDob,103) AS Emp_RDob FROM TempEmp order by Com_Code,Emp_no", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("SELECT * FROM TempEmp", CON)
     
        cmdCustomers.CommandType = CommandType.Text
        MyDataGrid.Enabled = True

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        CON.Close()

        'Catch ex As Exception

        'End Try

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
        ' Con.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
        MyDataGrid.Visible = True

    End Sub
    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from EmpMaster Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        CON.Open()
        Cmd.ExecuteNonQuery()
        CON.Close()
        BindTheGrid()
    End Sub
    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = e.Item.ItemIndex
        BindTheGrid()
    End Sub
    Sub MyDataGrid_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        MyDataGrid.EditItemIndex = -1
        BindTheGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Femail, Temail, Ename As String

        CON = New SqlConnection
        CON.ConnectionString = ("data source=(local);initial catalog=Insu; user id=sa;password=tstc123")
        CON.Open()

        RequiredFieldValidator1.Enabled = True



        ADA = New SqlDataAdapter("SELECT * FROM TempEmp Order by Com_Code,Emp_No", CON)
        DS = New DataSet
        ADA.Fill(DS, "TempEmp")

        COUNT = DS.Tables("TempEmp").Rows.Count


        If COUNT <> 0 Then

            For Each drt2 In DS.Tables("TempEmp").Rows
                ComCode = drt2("Com_code")
                ''  EmpNo = drt2("Emp_No")
                '    EmpNam = drt2("Emp_Nam")
                '    EmpDob = drt2("Emp_Dob")
                '    EmpNic = drt2("Emp_Nic")
                '    EmpNoCld = drt2("Emp_Nocld")
                '    EmpOldNo = drt2("Emp_OldNo")
                '    EmPRNam = drt2("Emp_RNam")
                '    EmpTyp = drt2("Emp_RTyp")
                '    EmpRDob = drt2("Emp_Rdob")

            Next

            'SS = Mid(tradate1, 4, 2) + "/" + Mid(tradate1, 1, 2) + "/" + Mid(tradate1, 7, 4)

            'ADA1 = New SqlDataAdapter("SELECT * FROM HthMaster where Com='" & Trim(ComCode) & "' and EpfNo='" & Trim(EmpNo) & "'", CON)
            'DS1 = New DataSet

            'ADA1.Fill(DS1, "HthMasterT")

            'COUNT1 = DS1.Tables("HthMasterT").Rows.Count

            'If COUNT1 <> 0 Then
            Dim DeleteCmd1 As String = "DELETE from HthMaster where Com='" & Trim(ComCode) & "'"
            Dim Cmd As New SqlCommand(DeleteCmd1, CON)
            Cmd.ExecuteNonQuery()

            Dim DeleteCmd2 As String = "DELETE from EmpMaster2 where Emp_Com='" & Trim(ComCode) & "'"
            Dim Cmd1 As New SqlCommand(DeleteCmd2, CON)
            Cmd1.ExecuteNonQuery()


            'Else

            'End If


            'Next
            Ans1 = "Y"
            Ans2 = "Y"

            Dim DeleteCmd3 As String = "select * from Sysmast"
            Dim Cmd2 As New SqlCommand(DeleteCmd3, CON)
            Cmd2.ExecuteNonQuery()



            For Each drt2 In DS.Tables("TempEmp").Rows

                ComCode = drt2("Com_code")
                EmpNo = drt2("Emp_No")
                EmpNam = drt2("Emp_Nam")
                EmpDob = Format(drt2("Emp_Dob"), "MM/dd/yyyy")
                EmpNic = drt2("Emp_Nic")
                EmpNoCld = drt2("Emp_Nocld")
                EmpOldNo = drt2("Emp_OldNo")
                EmPRNam = drt2("Emp_RNam")
                EmpTyp = drt2("Emp_RTyp")
                EmpRDob = Format(drt2("Emp_Rdob"), "MM/dd/yyyy")




                If Ans1 = "Y" Then
                    SaveCom = ComCode
                    SaveEmpno = EmpNo

                    Cmd2.Connection = CON
                    Cmd2.CommandText = ("INSERT INTO HthMaster(Com,EpfNo,EmployeeName,Dobirth,Nos,Date1,Dob,EmpIdNo,EmpCld,EmpAct,OldEpfNo,EmpAdd) VALUES ('" & Trim(ComCode) & "','" & Trim(EmpNo) & "','" & Trim(EmpNam) & "','" & Trim(Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 7, 4)) & "','1','" & Trim(Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 7, 4)) & "','" & Trim(Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 7, 4)) & "','" & Trim(EmpNic) & "','" & Trim(EmpNoCld) & "','Y','" & Trim(EmpOldNo) & "','Blank')")
                    Cmd2.ExecuteNonQuery()



                    Ans1 = "N"
                End If
                If SaveCom = ComCode And SaveEmpno = EmpNo Then

                    Ans1 = "N"
                Else

                    Ans1 = "Y"
                End If

                If Ans1 = "Y" Then
                    SaveCom = ComCode
                    SaveEmpno = EmpNo

                    Cmd2.Connection = CON
                    Cmd2.CommandText = ("INSERT INTO HthMaster(Com,EpfNo,EmployeeName,Dobirth,Nos,Date1,Dob,EmpIdNo,EmpCld,EmpAct,OldEpfNo,EmpAdd) VALUES ('" & Trim(ComCode) & "','" & Trim(EmpNo) & "','" & Trim(EmpNam) & "','" & Trim(Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 7, 4)) & "','1','" & Trim(Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 7, 4)) & "','" & Trim(Mid(EmpDob, 1, 2) + "/" + Mid(EmpDob, 4, 2) + "/" + Mid(EmpDob, 7, 4)) & "','" & Trim(EmpNic) & "','" & Trim(EmpNoCld) & "','Y','" & Trim(EmpOldNo) & "','Blank')")
                    Cmd2.ExecuteNonQuery()
                    Ans1 = "N"
                End If



            Next
            Ans1 = "Y"
            I = 1

            For Each drt2 In DS.Tables("TempEmp").Rows

                ComCode = drt2("Com_code")
                EmpNo = drt2("Emp_No")
                EmpNam = drt2("Emp_Nam")
                EmpDob = Format(drt2("Emp_Dob"), "MM/dd/yyyy")
                EmpNic = drt2("Emp_Nic")
                EmpNoCld = drt2("Emp_Nocld")
                EmpOldNo = drt2("Emp_OldNo")
                EmPRNam = drt2("Emp_RNam")
                EmpTyp = drt2("Emp_RTyp")
                EmpRDob = Format(drt2("Emp_Rdob"), "MM/dd/yyyy")


                J = (DateDiff(DateInterval.Day, CDate(EmpRDob), CDate(Today()))) / 365.25

                If Ans1 = "Y" Then
                    SaveCom = ComCode
                    SaveEmpno = EmpNo

                    Cmd2.Connection = CON
                    Cmd2.CommandText = ("INSERT INTO EmpMaster2(Emp_Com,Emp_No,Seq_No,Rel_Nam,Rel_Type,Rel_DoB,Rel_age,Rel_Idno,Dea_Flag) VALUES ('" & Trim(ComCode) & "','" & Trim(EmpNo) & "','" & I & "','" & Trim(EmPRNam) & "','" & Trim(EmpTyp) & "','" & Trim(Mid(EmpRDob, 1, 2) + "/" + Mid(EmpRDob, 4, 2) + "/" + Mid(EmpRDob, 7, 4)) & "','" & J & " ','blank','N')")
                    Cmd2.ExecuteNonQuery()


                    Ans1 = "N"
                End If
                If SaveCom = ComCode And SaveEmpno = EmpNo Then
                    I = I + 1
                    Ans1 = "N"

                    Cmd2.Connection = CON
                    Cmd2.CommandText = ("INSERT INTO EmpMaster2(Emp_Com,Emp_No,Seq_No,Rel_Nam,Rel_Type,Rel_DoB,Rel_age,Rel_Idno,Dea_Flag) VALUES ('" & Trim(ComCode) & "','" & Trim(EmpNo) & "','" & I & "','" & Trim(EmPRNam) & "','" & Trim(EmpTyp) & "','" & Trim(Mid(EmpRDob, 1, 2) + "/" + Mid(EmpRDob, 4, 2) + "/" + Mid(EmpRDob, 7, 4)) & "','" & J & " ','blank','N')")
                    Cmd2.ExecuteNonQuery()
                Else

                    Ans1 = "Y"
                End If

                If Ans1 = "Y" Then
                    SaveCom = ComCode
                    SaveEmpno = EmpNo
                    I = 1

                    Cmd2.Connection = CON
                    Cmd2.CommandText = ("INSERT INTO EmpMaster2(Emp_Com,Emp_No,Seq_No,Rel_Nam,Rel_Type,Rel_DoB,Rel_age,Rel_Idno,Dea_Flag) VALUES ('" & Trim(ComCode) & "','" & Trim(EmpNo) & "','" & I & "','" & Trim(EmPRNam) & "','" & Trim(EmpTyp) & "','" & Trim(Mid(EmpRDob, 1, 2) + "/" + Mid(EmpRDob, 4, 2) + "/" + Mid(EmpRDob, 7, 4)) & "','" & J & " ','blank','N')")
                    Cmd2.ExecuteNonQuery()



                    Ans1 = "N"
                End If



            Next





        Else


        End If






        Button2.Enabled = True

        Button3.Enabled = False
        RequiredFieldValidator1.Enabled = True
    End Sub

    Private Sub MyDataGrid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDataGrid.SelectedIndexChanged

    End Sub
End Class
