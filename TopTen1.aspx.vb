Imports System.Data.OracleClient
Imports System.Data

Public Class TopTen1
    Inherits System.Web.UI.Page
    Dim OBJ1 As New WORD
    Dim ADA As OracleDataAdapter
    Dim CMD As OracleCommand
    Dim DR, DR1 As OracleDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD, V1, V2, V3, Cal As String
    Dim CHKDUP As Boolean
    Dim CMD1 As OracleCommand
    Dim SS, SS1, CO, FID, FID1, ITM, DNAME, OPTNAME As String
    Dim COUNT As Double
    Dim te_frddt, te_toddt, te_frddt1, te_toddt1, DAT1 As Date
    Dim DD1, DD2 As String
    'Dim DSS As BestSelling1 = New BestSelling1
    'Dim DSS1 As SlowSelling1 = New SlowSelling1
    Dim te_flag As Boolean
    Dim I, J, L, MM As Integer
    Dim TOT As Double
    Dim RE As OracleDataReader
    Dim FD1, FD2, FD3, TD1, TD2, TD3, MON1, MON2, MON3, MON As String
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Image1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Image2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents TXTTDATE As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TXTFDATE As System.Web.UI.WebControls.TextBox
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents txtFCat As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTLOC As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNOM As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFdate1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTdate1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFdate2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTdate2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar3 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar4 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar5 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar6 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents txtFdate3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFLOC As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar7 As System.Web.UI.WebControls.Calendar
    Protected WithEvents txtTdate3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTCAT As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar8 As System.Web.UI.WebControls.Calendar
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Cal3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Cal2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton4 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton5 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton6 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Cal4 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents Comparevalidator2 As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents Comparevalidator3 As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents Comparevalidator4 As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents Comparevalidator5 As System.Web.UI.WebControls.CompareValidator
    Protected WithEvents Comparevalidator6 As System.Web.UI.WebControls.CompareValidator


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
        'OBJ1.CONH = New OracleConnection("data source=XPDSS;UID=POS;PWD=POS")
        'CON.Open()
        OBJ1.ConnectDBH()

        V1 = "http://192.168.12.133\POS\PHOTO\HOME.jpg"
        V2 = "http://192.168.12.133\POS\PHOTO\mail.gif"

        If IsDBNull(V1) = False Then
            Image1.Visible = True
            Image1.ImageUrl = V1
        End If
        If IsDBNull(V2) = False Then
            Image2.Visible = True
            Image2.ImageUrl = V2
        End If

        OpenPopUp(Button1, "POPTop1.aspx")
        OpenPopUp(Button2, "POPTop2.aspx")
        OBJ1.CONH.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            OBJ1.CONH.Open()
            Dim WD As String

            SS = "SELECT * from login"
            CMD = New OracleCommand(SS, OBJ1.CONH)
            DR = CMD.ExecuteReader

            'DELETE FILE
            CMD.Connection = OBJ1.CONH
            SS = "DELETE FROM TMPFILA1 WHERE "
            SS = SS & "UNAME ='" & Global.UNAME & "'"
            CMD.CommandText = (SS)
            CMD.ExecuteNonQuery()

            SS = "DELETE FROM TMPFILA0 WHERE "
            SS = SS & "UNAME ='" & Global.UNAME & "'"
            CMD.CommandText = (SS)
            CMD.ExecuteNonQuery()
            'month 000----------------------
            DD1 = Mid((TXTFDATE.Text), 4, 2) & "/" & Mid((TXTFDATE.Text), 1, 2) & "/" & Right((TXTFDATE.Text), 4)
            DD2 = Mid((TXTTDATE.Text), 4, 2) & "/" & Mid((TXTTDATE.Text), 1, 2) & "/" & Right((TXTTDATE.Text), 4)
            MON = MonthName(Month(DD1))
            te_frddt = (DD1)
            te_toddt = (DD2)
            MON = Mid(MonthName(Month(DD1)), 1, 3)
            te_frddt = Format(te_frddt, "dd-MMM-yyyy")
            te_toddt = Format(te_toddt, "dd-MMM-yyyy")

            If RadioButton1.Checked = True Then
                'SS = "CREATE OR REPLACE VIEW MONTH01" & Global.UNAME & " AS"
                'SS = SS & " SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                'SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "') AND ROWNUM<=" & (txtNOM.Text) & ") GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"

                SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & UCase(txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & UCase(txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & UCase(Trim(txtFLOC.Text)) & "' And (MAINTRA.TRA_LOC) <= '" & UCase(Trim(txtTLOC.Text)) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                OPTNAME = RadioButton1.Text
            Else
                SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & UCase(txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & UCase(txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & UCase(Trim(txtFLOC.Text)) & "' And (MAINTRA.TRA_LOC) <= '" & UCase(Trim(txtTLOC.Text)) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0))  ORDER BY QTY0"
                OPTNAME = RadioButton2.Text
            End If

            ''AND ROWNUM<=" & (txtNOM.Text) & "
            'SS = "CREATE OR REPLACE VIEW MONTH001" & Global.UNAME & " AS"
            'SS = SS & " SELECT * FROM MONTH01" & Global.UNAME & " WHERE ROWNUM<=" & (txtNOM.Text) & ""

            CMD = New OracleCommand(SS, OBJ1.CONH)
            DR = CMD.ExecuteReader

            Dim co As Integer
            co = 0
            Do While DR.Read And co < Trim(txtNOM.Text)
                co = co + 1
                SS = ("select * from TMPFILA1 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                DS = New DataSet
                ADA.Fill(DS)
                COUNT = DS.Tables(0).Rows.Count
                If COUNT <> 0 Then 'EDIT
                    CMD.CommandText = ("UPDATE TMPFILA1 SET S0='" & co & "',L1='" & DR.GetValue(2) & "',L2='" & DR.GetValue(3) & "',L3='" & DR.GetValue(4) & "',L4='" & DR.GetValue(5) & "',L5='" & DR.GetValue(6) & "',L6='" & DR.GetValue(7) & "',L7='" & DR.GetValue(8) & "',L8='" & DR.GetValue(9) & "',L9='" & DR.GetValue(10) & "',L10='" & DR.GetValue(11) & "',L11='" & DR.GetValue(12) & "',L12='" & DR.GetValue(13) & "',L13='" & DR.GetValue(14) & "',L14='" & DR.GetValue(15) & "',TOTL='" & DR.GetValue(1) & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                    CMD.ExecuteNonQuery()
                Else 'ADD
                    CMD.CommandText = ("INSERT INTO TMPFILA1 (TRA_ITMTYP,S0,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11,L12,L13,L14,TOTL,UNAME) VALUES ('" & DR.GetValue(0) & "','" & co & "','" & DR.GetValue(2) & "','" & DR.GetValue(3) & "','" & DR.GetValue(4) & "','" & DR.GetValue(5) & "','" & DR.GetValue(6) & "','" & DR.GetValue(7) & "','" & DR.GetValue(8) & "','" & DR.GetValue(9) & "','" & DR.GetValue(10) & "','" & DR.GetValue(11) & "','" & DR.GetValue(12) & "','" & DR.GetValue(13) & "','" & DR.GetValue(14) & "','" & DR.GetValue(15) & "','" & DR.GetValue(1) & "','" & Global.UNAME & "')")
                    CMD.ExecuteNonQuery()
                End If

            Loop

            '***********TOT
            SS = "SELECT  Sum(MAINTRA.TRA_QTY) AS QTY0 FROM MAINTRA WHERE (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) AND ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') and ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "'))"
            CMD = New OracleCommand(SS, OBJ1.CONH)
            DR = CMD.ExecuteReader
            Do While DR.Read
                TOT = DR.GetValue(0)
            Loop
            '***********TOT

            'If IsDate(CDate(txtFdate1.Text)) And IsDate(CDate(txtTdate1.Text)) Then

            '*******************month   1 ***************
            DD1 = Mid((txtFdate1.Text), 4, 2) & "/" & Mid((txtFdate1.Text), 1, 2) & "/" & Right((txtFdate1.Text), 4)
            DD2 = Mid((txtTdate1.Text), 4, 2) & "/" & Mid((txtTdate1.Text), 1, 2) & "/" & Right((txtTdate1.Text), 4)
            If IsDate(DD1) And IsDate(DD2) Then
                te_frddt = (DD1)
                te_toddt = (DD2)
                MON1 = Mid(MonthName(Month(DD1)), 1, 3)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")

                If RadioButton1.Checked = True Then
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                Else
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0))  ORDER BY QTY0"
                End If
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                co = 1
                MM = 1
                Do While DR.Read And co <= Trim(txtNOM.Text)
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                    ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                    DS = New DataSet
                    ADA.Fill(DS)
                    COUNT = DS.Tables(0).Rows.Count
                    If COUNT <> 0 Then 'EDIT
                        '("UPDATE TMPFILA0 SET L1='" & DR.GetValue(2) & "',L2='" & DR.GetValue(3) & "',L3='" & DR.GetValue(4) & "',L4='" & DR.GetValue(5) & "',L5='" & DR.GetValue(6) & "',L6='" & DR.GetValue(7) & "',L7='" & DR.GetValue(8) & "',L8='" & DR.GetValue(9) & "',L9='" & DR.GetValue(10) & "',L10='" & DR.GetValue(11) & "',L11='" & DR.GetValue(12) & "',L12='" & DR.GetValue(13) & "',L13='" & DR.GetValue(14) & "',L14='" & DR.GetValue(15) & "',TOTL='" & DR.GetValue(1) & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.CommandText = ("UPDATE TMPFILA0 SET TOTL='" & DR.GetValue(1) & "' AND MON='" & MM & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' and MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Else 'ADD
                        '("INSERT INTO TMPFILA1 (TRA_ITMTYP,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11.L12,L13,L14,TOTL,UNAME) VALUES ('" & DR.GetValue(0) & "','" & DR.GetValue(2) & "','" & DR.GetValue(3) & "','" & DR.GetValue(4) & "','" & DR.GetValue(5) & "','" & DR.GetValue(6) & "','" & DR.GetValue(7) & "','" & DR.GetValue(8) & "','" & DR.GetValue(9) & "','" & DR.GetValue(10) & "','" & DR.GetValue(11) & "','" & DR.GetValue(12) & "','" & DR.GetValue(13) & "','" & DR.GetValue(14) & "','" & DR.GetValue(15) & "','" & DR.GetValue(1) & "','" & Global.UNAME & "')")
                        CMD.CommandText = ("INSERT INTO TMPFILA0 (TRA_ITMTYP,MON,TOTL,S1,UNAME) VALUES ('" & DR.GetValue(0) & "','" & MM & "','" & DR.GetValue(1) & "','" & co & "','" & Global.UNAME & "')")
                        CMD.ExecuteNonQuery()
                    End If
                    co = co + 1
                Loop
            End If

            '*******************month   2 ***************
            'If IsDate(txtFdate2.Text) And IsDate(txtTdate2.Text) Then
            DD1 = Mid((txtFdate2.Text), 4, 2) & "/" & Mid((txtFdate2.Text), 1, 2) & "/" & Right((txtFdate2.Text), 4)
            DD2 = Mid((txtTdate2.Text), 4, 2) & "/" & Mid((txtTdate2.Text), 1, 2) & "/" & Right((txtTdate2.Text), 4)
            If IsDate(DD1) And IsDate(DD2) Then
                te_frddt = (DD1)
                te_toddt = (DD2)
                MON2 = Mid(MonthName(Month(DD1)), 1, 3)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")

                If RadioButton1.Checked = True Then
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                Else
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0)) ORDER BY QTY0"
                End If
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                co = 1
                MM = 2
                Do While DR.Read And co <= Trim(txtNOM.Text)
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                    ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                    DS = New DataSet
                    ADA.Fill(DS)
                    COUNT = DS.Tables(0).Rows.Count
                    If COUNT <> 0 Then 'EDIT
                        CMD.CommandText = ("UPDATE TMPFILA0 SET TOTL='" & DR.GetValue(1) & "' AND MON='" & MM & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' and MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Else 'ADD
                        CMD.CommandText = ("INSERT INTO TMPFILA0 (TRA_ITMTYP,MON,TOTL,S1,UNAME) VALUES ('" & DR.GetValue(0) & "','" & MM & "','" & DR.GetValue(1) & "','" & co & "','" & Global.UNAME & "')")
                        CMD.ExecuteNonQuery()
                    End If
                    co = co + 1
                Loop
            End If
            '*******************month   3 ***************
            'If IsDate(txtFdate3.Text) And IsDate(txtTdate3.Text) Then
            DD1 = Mid((txtFdate3.Text), 4, 2) & "/" & Mid((txtFdate3.Text), 1, 2) & "/" & Right((txtFdate3.Text), 4)
            DD2 = Mid((txtTdate3.Text), 4, 2) & "/" & Mid((txtTdate3.Text), 1, 2) & "/" & Right((txtTdate3.Text), 4)
            If IsDate(DD1) And IsDate(DD2) Then
                te_frddt = (DD1)
                te_toddt = (DD2)
                MON3 = Mid(MonthName(Month(DD1)), 1, 3)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")

                If RadioButton1.Checked = True Then
                    'SS = "CREATE OR REPLACE VIEW MONTH02" & Global.UNAME & " AS"
                    'SS = SS & " SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                Else
                    'SS = "CREATE OR REPLACE VIEW MONTH02" & Global.UNAME & " AS"
                    'SS = SS & " SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0"
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0)) ORDER BY QTY0"
                End If
                'SS = "CREATE OR REPLACE VIEW MONTH002" & Global.UNAME & " AS"
                'SS = SS & " SELECT * FROM MONTH01" & Global.UNAME & " WHERE ROWNUM<=" & (txtNOM.Text) & ""
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                co = 1
                MM = 3
                Do While DR.Read And co <= Trim(txtNOM.Text)
                    'SS = ("select * from TMPFILA1 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                    ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                    DS = New DataSet
                    ADA.Fill(DS)
                    COUNT = DS.Tables(0).Rows.Count
                    If COUNT <> 0 Then 'EDIT
                        '("UPDATE TMPFILA0 SET L1='" & DR.GetValue(2) & "',L2='" & DR.GetValue(3) & "',L3='" & DR.GetValue(4) & "',L4='" & DR.GetValue(5) & "',L5='" & DR.GetValue(6) & "',L6='" & DR.GetValue(7) & "',L7='" & DR.GetValue(8) & "',L8='" & DR.GetValue(9) & "',L9='" & DR.GetValue(10) & "',L10='" & DR.GetValue(11) & "',L11='" & DR.GetValue(12) & "',L12='" & DR.GetValue(13) & "',L13='" & DR.GetValue(14) & "',L14='" & DR.GetValue(15) & "',TOTL='" & DR.GetValue(1) & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.CommandText = ("UPDATE TMPFILA0 SET TOTL='" & DR.GetValue(1) & "' AND MON='" & MM & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' and MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Else 'ADD
                        '("INSERT INTO TMPFILA1 (TRA_ITMTYP,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11.L12,L13,L14,TOTL,UNAME) VALUES ('" & DR.GetValue(0) & "','" & DR.GetValue(2) & "','" & DR.GetValue(3) & "','" & DR.GetValue(4) & "','" & DR.GetValue(5) & "','" & DR.GetValue(6) & "','" & DR.GetValue(7) & "','" & DR.GetValue(8) & "','" & DR.GetValue(9) & "','" & DR.GetValue(10) & "','" & DR.GetValue(11) & "','" & DR.GetValue(12) & "','" & DR.GetValue(13) & "','" & DR.GetValue(14) & "','" & DR.GetValue(15) & "','" & DR.GetValue(1) & "','" & Global.UNAME & "')")
                        CMD.CommandText = ("INSERT INTO TMPFILA0 (TRA_ITMTYP,MON,TOTL,S1,UNAME) VALUES ('" & DR.GetValue(0) & "','" & MM & "','" & DR.GetValue(1) & "','" & co & "','" & Global.UNAME & "')")
                        CMD.ExecuteNonQuery()
                    End If
                    co = co + 1
                Loop

            End If
            'RANK------------------
            Dim MMM As Integer
            Dim FID As String
            For MMM = 1 To 3
                SS = ("select * from TMPFILA1 where UNAME='" & Global.UNAME & "'")
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                Do While DR.Read
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MMM & "' AND UNAME='" & Global.UNAME & "'")
                    CMD = New OracleCommand(SS, OBJ1.CONH)
                    DR1 = CMD.ExecuteReader
                    Do While DR1.Read
                        FID = "S" & MMM
                        CMD.CommandText = ("UPDATE TMPFILA1 SET " & FID & "='" & DR1.GetValue(17) & "' WHERE TRA_ITMTYP='" & DR1.GetValue(0) & "' AND  UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Loop
                Loop
            Next
            MON = ("" & MON)
            MON1 = ("" & MON1)
            MON2 = ("" & MON2)
            MON3 = ("" & MON3)
            WD = OBJ1.amtwords(txtNOM.Text)

            'Report-----------------------
            Global.GTOT = TOT
            Global.OPT = OPTNAME
            Global.WED = WD
            Global.MON1 = MON
            Global.MON2 = MON1
            Global.MON3 = MON2
            Global.MON4 = MON3
            OpenPopUp(Button1, "POPTop1.aspx")

            'CrystalReportViewer1.Visible = True
            'If RadioButton1.Checked = True Then
            '    DSS.SetDatabaseLogon("POS", "POS")
            '    DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            '    DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            '    DSS.SetParameterValue("Uname", "" & Global.UNAME & "")
            '    DSS.SetParameterValue("GTOT", "" & TOT & "")
            '    DSS.SetParameterValue("OP", "" & OPTNAME & "")
            '    DSS.SetParameterValue("WD", "" & WD & "")
            '    DSS.SetParameterValue("M", "" & MON & "")
            '    DSS.SetParameterValue("M1", "" & MON1 & "")
            '    DSS.SetParameterValue("M2", "" & MON2 & "")
            '    DSS.SetParameterValue("M3", "" & MON3 & "")
            '    CrystalReportViewer1.ReportSource = DSS
            '    CrystalReportViewer1.DataBind()
            'End If


        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Calendar5.Visible = True
    'End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        txtFdate2.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        txtTdate2.Text = Format((Calendar2.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar2.Visible = False
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Calendar6.Visible = True
    'End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    Calendar3.Visible = True
    'End Sub

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    Calendar1.Visible = True
    'End Sub





    Private Sub Calendar3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar3.SelectionChanged

        txtFdate1.Text = Format((Calendar3.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar3.Visible = False

    End Sub

    Private Sub Calendar4_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar4.SelectionChanged
        txtTdate1.Text = Format((Calendar4.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar4.Visible = False
    End Sub

    Private Sub Calendar5_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar5.SelectionChanged

        TXTFDATE.Text = Format((Calendar5.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar5.Visible = False

    End Sub

    Private Sub Calendar6_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar6.SelectionChanged

        TXTTDATE.Text = Format((Calendar6.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar6.Visible = False

    End Sub



    Private Sub Calendar7_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar7.SelectionChanged
        txtFdate3.Text = Format((Calendar7.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar7.Visible = False
    End Sub



    Private Sub Calendar8_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar8.SelectionChanged
        txtTdate3.Text = Format((Calendar8.SelectedDate).ToString("dd/MM/yyyy"))
        Calendar8.Visible = False
    End Sub


    Private Sub Image2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image2.Click
        Response.Redirect("Email.aspx")
    End Sub

    Private Sub Image1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image1.Click
        Response.Redirect("MainMenu.aspx")
    End Sub

    Private Sub Cal2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Cal2.Click
        Calendar5.Visible = True
    End Sub

    Private Sub Cal3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Cal3.Click
        Calendar6.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            OBJ1.CONH.Open()
            Dim WD As String

            SS = "SELECT * from login"
            CMD = New OracleCommand(SS, OBJ1.CONH)
            DR = CMD.ExecuteReader

            'DELETE FILE
            CMD.Connection = OBJ1.CONH
            SS = "DELETE FROM TMPFILA1 WHERE "
            SS = SS & "UNAME ='" & Global.UNAME & "'"
            CMD.CommandText = (SS)
            CMD.ExecuteNonQuery()

            SS = "DELETE FROM TMPFILA0 WHERE "
            SS = SS & "UNAME ='" & Global.UNAME & "'"
            CMD.CommandText = (SS)
            CMD.ExecuteNonQuery()
            'month 000----------------------
            DD1 = Mid((TXTFDATE.Text), 4, 2) & "/" & Mid((TXTFDATE.Text), 1, 2) & "/" & Right((TXTFDATE.Text), 4)
            DD2 = Mid((TXTTDATE.Text), 4, 2) & "/" & Mid((TXTTDATE.Text), 1, 2) & "/" & Right((TXTTDATE.Text), 4)
            MON = MonthName(Month(DD1))
            te_frddt = (DD1)
            te_toddt = (DD2)
            MON = Mid(MonthName(Month(DD1)), 1, 3)
            te_frddt = Format(te_frddt, "dd-MMM-yyyy")
            te_toddt = Format(te_toddt, "dd-MMM-yyyy")

            If RadioButton1.Checked = True Then
                'SS = "CREATE OR REPLACE VIEW MONTH01" & Global.UNAME & " AS"
                'SS = SS & " SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                'SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "') AND ROWNUM<=" & (txtNOM.Text) & ") GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"

                SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & UCase(txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & UCase(txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & UCase(Trim(txtFLOC.Text)) & "' And (MAINTRA.TRA_LOC) <= '" & UCase(Trim(txtTLOC.Text)) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                OPTNAME = RadioButton1.Text
            Else
                SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & UCase(txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & UCase(txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & UCase(Trim(txtFLOC.Text)) & "' And (MAINTRA.TRA_LOC) <= '" & UCase(Trim(txtTLOC.Text)) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0))  ORDER BY QTY0"
                OPTNAME = RadioButton2.Text
            End If

            ''AND ROWNUM<=" & (txtNOM.Text) & "
            'SS = "CREATE OR REPLACE VIEW MONTH001" & Global.UNAME & " AS"
            'SS = SS & " SELECT * FROM MONTH01" & Global.UNAME & " WHERE ROWNUM<=" & (txtNOM.Text) & ""

            CMD = New OracleCommand(SS, OBJ1.CONH)
            DR = CMD.ExecuteReader

            Dim co As Integer
            co = 0
            Do While DR.Read And co < Trim(txtNOM.Text)
                co = co + 1
                SS = ("select * from TMPFILA1 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                DS = New DataSet
                ADA.Fill(DS)
                COUNT = DS.Tables(0).Rows.Count
                If COUNT <> 0 Then 'EDIT
                    CMD.CommandText = ("UPDATE TMPFILA1 SET S0='" & co & "',L1='" & DR.GetValue(2) & "',L2='" & DR.GetValue(3) & "',L3='" & DR.GetValue(4) & "',L4='" & DR.GetValue(5) & "',L5='" & DR.GetValue(6) & "',L6='" & DR.GetValue(7) & "',L7='" & DR.GetValue(8) & "',L8='" & DR.GetValue(9) & "',L9='" & DR.GetValue(10) & "',L10='" & DR.GetValue(11) & "',L11='" & DR.GetValue(12) & "',L12='" & DR.GetValue(13) & "',L13='" & DR.GetValue(14) & "',L14='" & DR.GetValue(15) & "',TOTL='" & DR.GetValue(1) & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                    CMD.ExecuteNonQuery()
                Else 'ADD
                    CMD.CommandText = ("INSERT INTO TMPFILA1 (TRA_ITMTYP,S0,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11,L12,L13,L14,TOTL,UNAME) VALUES ('" & DR.GetValue(0) & "','" & co & "','" & DR.GetValue(2) & "','" & DR.GetValue(3) & "','" & DR.GetValue(4) & "','" & DR.GetValue(5) & "','" & DR.GetValue(6) & "','" & DR.GetValue(7) & "','" & DR.GetValue(8) & "','" & DR.GetValue(9) & "','" & DR.GetValue(10) & "','" & DR.GetValue(11) & "','" & DR.GetValue(12) & "','" & DR.GetValue(13) & "','" & DR.GetValue(14) & "','" & DR.GetValue(15) & "','" & DR.GetValue(1) & "','" & Global.UNAME & "')")
                    CMD.ExecuteNonQuery()
                End If

            Loop

            '***********TOT
            SS = "SELECT  Sum(MAINTRA.TRA_QTY) AS QTY0 FROM MAINTRA WHERE (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) AND ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') and ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "'))"
            CMD = New OracleCommand(SS, OBJ1.CONH)
            DR = CMD.ExecuteReader
            Do While DR.Read
                TOT = DR.GetValue(0)
            Loop
            '***********TOT

            'If IsDate(CDate(txtFdate1.Text)) And IsDate(CDate(txtTdate1.Text)) Then

            '*******************month   1 ***************
            DD1 = Mid((txtFdate1.Text), 4, 2) & "/" & Mid((txtFdate1.Text), 1, 2) & "/" & Right((txtFdate1.Text), 4)
            DD2 = Mid((txtTdate1.Text), 4, 2) & "/" & Mid((txtTdate1.Text), 1, 2) & "/" & Right((txtTdate1.Text), 4)
            If IsDate(DD1) And IsDate(DD2) Then
                te_frddt = (DD1)
                te_toddt = (DD2)
                MON1 = Mid(MonthName(Month(DD1)), 1, 3)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")

                If RadioButton1.Checked = True Then
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                Else
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0))  ORDER BY QTY0"
                End If
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                co = 1
                MM = 1
                Do While DR.Read And co <= Trim(txtNOM.Text)
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                    ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                    DS = New DataSet
                    ADA.Fill(DS)
                    COUNT = DS.Tables(0).Rows.Count
                    If COUNT <> 0 Then 'EDIT
                        '("UPDATE TMPFILA0 SET L1='" & DR.GetValue(2) & "',L2='" & DR.GetValue(3) & "',L3='" & DR.GetValue(4) & "',L4='" & DR.GetValue(5) & "',L5='" & DR.GetValue(6) & "',L6='" & DR.GetValue(7) & "',L7='" & DR.GetValue(8) & "',L8='" & DR.GetValue(9) & "',L9='" & DR.GetValue(10) & "',L10='" & DR.GetValue(11) & "',L11='" & DR.GetValue(12) & "',L12='" & DR.GetValue(13) & "',L13='" & DR.GetValue(14) & "',L14='" & DR.GetValue(15) & "',TOTL='" & DR.GetValue(1) & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.CommandText = ("UPDATE TMPFILA0 SET TOTL='" & DR.GetValue(1) & "' AND MON='" & MM & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' and MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Else 'ADD
                        '("INSERT INTO TMPFILA1 (TRA_ITMTYP,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11.L12,L13,L14,TOTL,UNAME) VALUES ('" & DR.GetValue(0) & "','" & DR.GetValue(2) & "','" & DR.GetValue(3) & "','" & DR.GetValue(4) & "','" & DR.GetValue(5) & "','" & DR.GetValue(6) & "','" & DR.GetValue(7) & "','" & DR.GetValue(8) & "','" & DR.GetValue(9) & "','" & DR.GetValue(10) & "','" & DR.GetValue(11) & "','" & DR.GetValue(12) & "','" & DR.GetValue(13) & "','" & DR.GetValue(14) & "','" & DR.GetValue(15) & "','" & DR.GetValue(1) & "','" & Global.UNAME & "')")
                        CMD.CommandText = ("INSERT INTO TMPFILA0 (TRA_ITMTYP,MON,TOTL,S1,UNAME) VALUES ('" & DR.GetValue(0) & "','" & MM & "','" & DR.GetValue(1) & "','" & co & "','" & Global.UNAME & "')")
                        CMD.ExecuteNonQuery()
                    End If
                    co = co + 1
                Loop
            End If

            '*******************month   2 ***************
            'If IsDate(txtFdate2.Text) And IsDate(txtTdate2.Text) Then
            DD1 = Mid((txtFdate2.Text), 4, 2) & "/" & Mid((txtFdate2.Text), 1, 2) & "/" & Right((txtFdate2.Text), 4)
            DD2 = Mid((txtTdate2.Text), 4, 2) & "/" & Mid((txtTdate2.Text), 1, 2) & "/" & Right((txtTdate2.Text), 4)
            If IsDate(DD1) And IsDate(DD2) Then
                te_frddt = (DD1)
                te_toddt = (DD2)
                MON2 = Mid(MonthName(Month(DD1)), 1, 3)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")

                If RadioButton1.Checked = True Then
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                Else
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0)) ORDER BY QTY0"
                End If
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                co = 1
                MM = 2
                Do While DR.Read And co <= Trim(txtNOM.Text)
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                    ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                    DS = New DataSet
                    ADA.Fill(DS)
                    COUNT = DS.Tables(0).Rows.Count
                    If COUNT <> 0 Then 'EDIT
                        CMD.CommandText = ("UPDATE TMPFILA0 SET TOTL='" & DR.GetValue(1) & "' AND MON='" & MM & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' and MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Else 'ADD
                        CMD.CommandText = ("INSERT INTO TMPFILA0 (TRA_ITMTYP,MON,TOTL,S1,UNAME) VALUES ('" & DR.GetValue(0) & "','" & MM & "','" & DR.GetValue(1) & "','" & co & "','" & Global.UNAME & "')")
                        CMD.ExecuteNonQuery()
                    End If
                    co = co + 1
                Loop
            End If
            '*******************month   3 ***************
            'If IsDate(txtFdate3.Text) And IsDate(txtTdate3.Text) Then
            DD1 = Mid((txtFdate3.Text), 4, 2) & "/" & Mid((txtFdate3.Text), 1, 2) & "/" & Right((txtFdate3.Text), 4)
            DD2 = Mid((txtTdate3.Text), 4, 2) & "/" & Mid((txtTdate3.Text), 1, 2) & "/" & Right((txtTdate3.Text), 4)
            If IsDate(DD1) And IsDate(DD2) Then
                te_frddt = (DD1)
                te_toddt = (DD2)
                MON3 = Mid(MonthName(Month(DD1)), 1, 3)
                te_frddt = Format(te_frddt, "dd-MMM-yyyy")
                te_toddt = Format(te_toddt, "dd-MMM-yyyy")

                If RadioButton1.Checked = True Then
                    'SS = "CREATE OR REPLACE VIEW MONTH02" & Global.UNAME & " AS"
                    'SS = SS & " SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0 DESC"
                Else
                    'SS = "CREATE OR REPLACE VIEW MONTH02" & Global.UNAME & " AS"
                    'SS = SS & " SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP  ORDER BY QTY0"
                    SS = "SELECT MAINTRA.TRA_ITMTYP, Sum(MAINTRA.TRA_QTY) AS QTY0,Sum(MAINTRA.TRA_QTY1) AS QTY1,Sum(MAINTRA.TRA_QTY2) AS QTY2,Sum(MAINTRA.TRA_QTY3) AS QTY3,Sum(MAINTRA.TRA_QTY4) AS QTY4,Sum(MAINTRA.TRA_QTY5) AS QTY5,Sum(MAINTRA.TRA_QTY6) AS QTY6,Sum(MAINTRA.TRA_QTY7) AS QTY7,Sum(MAINTRA.TRA_QTY8) AS QTY8,Sum(MAINTRA.TRA_QTY9) AS QTY9,Sum(MAINTRA.TRA_QTY10) AS QTY10,Sum(MAINTRA.TRA_QTY11) AS QTY11,Sum(MAINTRA.TRA_QTY12) AS QTY12,Sum(MAINTRA.TRA_QTY13) AS QTY13,Sum(MAINTRA.TRA_QTY14) AS QTY14 From MAINTRA Where (((MAINTRA.TRA_DATE)>=('" & Format(te_frddt, "dd/MMM/yyyy") & "') And (MAINTRA.TRA_DATE)<=('" & Format(te_toddt, "dd/MMM/yyyy") & "')) And ((MAINTRA.TRA_CAT)>='" & (txtFCat.Text) & "' And (MAINTRA.TRA_CAT)<='" & (txtTCAT.Text) & "') And ((MAINTRA.TRA_LOC)>= '" & Trim(txtFLOC.Text) & "' And (MAINTRA.TRA_LOC) <= '" & Trim(txtTLOC.Text) & "')) GROUP BY MAINTRA.TRA_ITMTYP HAVING (((Sum(MAINTRA.TRA_QTY))<>0)) ORDER BY QTY0"
                End If
                'SS = "CREATE OR REPLACE VIEW MONTH002" & Global.UNAME & " AS"
                'SS = SS & " SELECT * FROM MONTH01" & Global.UNAME & " WHERE ROWNUM<=" & (txtNOM.Text) & ""
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                co = 1
                MM = 3
                Do While DR.Read And co <= Trim(txtNOM.Text)
                    'SS = ("select * from TMPFILA1 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                    ADA = New OracleDataAdapter(SS, OBJ1.CONH)
                    DS = New DataSet
                    ADA.Fill(DS)
                    COUNT = DS.Tables(0).Rows.Count
                    If COUNT <> 0 Then 'EDIT
                        '("UPDATE TMPFILA0 SET L1='" & DR.GetValue(2) & "',L2='" & DR.GetValue(3) & "',L3='" & DR.GetValue(4) & "',L4='" & DR.GetValue(5) & "',L5='" & DR.GetValue(6) & "',L6='" & DR.GetValue(7) & "',L7='" & DR.GetValue(8) & "',L8='" & DR.GetValue(9) & "',L9='" & DR.GetValue(10) & "',L10='" & DR.GetValue(11) & "',L11='" & DR.GetValue(12) & "',L12='" & DR.GetValue(13) & "',L13='" & DR.GetValue(14) & "',L14='" & DR.GetValue(15) & "',TOTL='" & DR.GetValue(1) & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.CommandText = ("UPDATE TMPFILA0 SET TOTL='" & DR.GetValue(1) & "' AND MON='" & MM & "' where TRA_ITMTYP='" & DR.GetValue(0) & "' and MON='" & MM & "' AND UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Else 'ADD
                        '("INSERT INTO TMPFILA1 (TRA_ITMTYP,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11.L12,L13,L14,TOTL,UNAME) VALUES ('" & DR.GetValue(0) & "','" & DR.GetValue(2) & "','" & DR.GetValue(3) & "','" & DR.GetValue(4) & "','" & DR.GetValue(5) & "','" & DR.GetValue(6) & "','" & DR.GetValue(7) & "','" & DR.GetValue(8) & "','" & DR.GetValue(9) & "','" & DR.GetValue(10) & "','" & DR.GetValue(11) & "','" & DR.GetValue(12) & "','" & DR.GetValue(13) & "','" & DR.GetValue(14) & "','" & DR.GetValue(15) & "','" & DR.GetValue(1) & "','" & Global.UNAME & "')")
                        CMD.CommandText = ("INSERT INTO TMPFILA0 (TRA_ITMTYP,MON,TOTL,S1,UNAME) VALUES ('" & DR.GetValue(0) & "','" & MM & "','" & DR.GetValue(1) & "','" & co & "','" & Global.UNAME & "')")
                        CMD.ExecuteNonQuery()
                    End If
                    co = co + 1
                Loop

            End If
            'RANK------------------
            Dim MMM As Integer
            Dim FID As String
            For MMM = 1 To 3
                SS = ("select * from TMPFILA1 where UNAME='" & Global.UNAME & "'")
                CMD = New OracleCommand(SS, OBJ1.CONH)
                DR = CMD.ExecuteReader
                Do While DR.Read
                    SS = ("select * from TMPFILA0 where TRA_ITMTYP='" & DR.GetValue(0) & "' AND MON='" & MMM & "' AND UNAME='" & Global.UNAME & "'")
                    CMD = New OracleCommand(SS, OBJ1.CONH)
                    DR1 = CMD.ExecuteReader
                    Do While DR1.Read
                        FID = "S" & MMM
                        CMD.CommandText = ("UPDATE TMPFILA1 SET " & FID & "='" & DR1.GetValue(17) & "' WHERE TRA_ITMTYP='" & DR1.GetValue(0) & "' AND  UNAME='" & Global.UNAME & "'")
                        CMD.ExecuteNonQuery()
                    Loop
                Loop
            Next
            MON = ("" & MON)
            MON1 = ("" & MON1)
            MON2 = ("" & MON2)
            MON3 = ("" & MON3)
            WD = OBJ1.amtwords(txtNOM.Text)

            'Report-----------------------
            Global.GTOT = TOT
            Global.OPT = OPTNAME
            Global.WED = WD
            Global.MON1 = MON
            Global.MON2 = MON1
            Global.MON3 = MON2
            Global.MON4 = MON3
            OpenPopUp(Button2, "POPTop2.aspx")

            'DSS1.SetDatabaseLogon("POS", "POS")
            'DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            'DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS1.SetParameterValue("Uname", "" & Global.UNAME & "")
            'DSS1.SetParameterValue("GTOT", "" & TOT & "")
            'DSS1.SetParameterValue("OP", "" & OPTNAME & "")
            'DSS1.SetParameterValue("WD", "" & WD & "")
            'DSS1.SetParameterValue("M", "" & MON & "")
            'DSS1.SetParameterValue("M1", "" & MON1 & "")
            'DSS1.SetParameterValue("M2", "" & MON2 & "")
            'DSS1.SetParameterValue("M3", "" & MON3 & "")
            'CrystalReportViewer1.ReportSource = DSS1
            'CrystalReportViewer1.DataBind()

        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub



    Private Sub Cal4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Cal4.Click
        Calendar3.Visible = True
    End Sub


    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Calendar4.Visible = True
    End Sub

    Private Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Calendar1.Visible = True
    End Sub


    Private Sub ImageButton5_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Calendar7.Visible = True
    End Sub

    Private Sub ImageButton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        Calendar2.Visible = True
    End Sub

    Private Sub ImageButton6_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton6.Click
        Calendar8.Visible = True
    End Sub

    Private Sub txtNOM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNOM.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Button1.Visible = True
            Button2.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Button2.Visible = True
            Button1.Visible = False
        End If
    End Sub
    Public Shared Sub OpenPopUp(ByVal opener As System.Web.UI.WebControls.WebControl, ByVal PagePath As String)
        Dim clientScript As String
        'Building the client script- window.open
        clientScript = "window.open('" & PagePath & "')"
        'regiter the script to the clientside click event of the 'opener' control
        opener.Attributes.Add("onClick", clientScript)
    End Sub
    Public Shared Sub OpenPopUp(ByVal opener As System.Web.UI.WebControls.WebControl, ByVal PagePath As String, ByVal windowName As String, ByVal width As Integer, ByVal height As Integer)
        Dim clientScript As String
        Dim windowAttribs As String

        'Building Client side window attributes with width and height.
        'Also the the window will be positioned to the middle of the screen
        windowAttribs = "width=" & width & "px," & _
                        "height=" & height & "px," & _
                        "left='+((screen.width -" & width & ") / 2)+'," & _
                        "top='+ (screen.height - " & height & ") / 2+'"

        'Building the client script- window.open, with additional parameters
        clientScript = "window.open('" & PagePath & "','" & windowName & "','" & windowAttribs & "');return false;"
        'regiter the script to the clientside click event of the 'opener' control
        opener.Attributes.Add("onClick", clientScript)
    End Sub


End Class
