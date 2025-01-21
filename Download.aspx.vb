Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.IO
Public Class Download
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
    Dim ComCode, EmpNo, EmpNam, EmpDob, EmpNic, EmpNoCld, EmpOldNo, EmPRNam, EmpTyp, EmpRDob, Ans1, Ans2, Ans3, Ans4, COM11, D1, D2 As String

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
    Dim fileList As ArrayList = New ArrayList
    Dim DSS1 As EmpRecValue = New EmpRecValue
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents txtMyFile As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblStatus As System.Web.UI.WebControls.Label
    Protected WithEvents fileUpload As System.Web.UI.HtmlControls.HtmlInputFile

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

        If Not IsPostBack Then
            With DropDownList1.Items
                .Add("Rich Text (RTF)")
                .Add("Portable Document (PDF)")
                .Add("MS Word (DOC)")
                .Add("MS Excel (XLS)")
            End With
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try
            ExportReport()
        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try




    End Sub

    Sub ExportReport()


        Try
            D1 = "10/01/2009"
            D2 = "10/31/2009"
            COM11 = "DSI"
            'OBJ1.ConnectDBH()
            CrystalReportViewer1.Visible = True
            DSS1.SetDatabaseLogon("sa", "tstc123")
            DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

            DSS1.SetParameterValue("Com", "" & COM11 & "")
            DSS1.SetParameterValue("dt1", "" & D1 & "")

            DSS1.SetParameterValue("dt2", "" & D2 & "")




            CrystalReportViewer1.ReportSource = DSS1
            CrystalReportViewer1.DataBind()

        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try





        Dim oStream As New MemoryStream ' // using System.IO

        Select Case DropDownList1.SelectedItem.Text 'this contains the value of the selected export format.

            Case "Rich Text (RTF)"
                '--------------------------------------------------------------------
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)
                ' Response.AddHeader("content-disposition", "attachment;filename=FileName.rtf")
                Response.AddHeader("Content-Disposition", "attachment;filename=FileName.rtf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/rtf"
                'Response.ContentType = "application/vnd.text"


                '' Response.ContentType = "application/plain"

                '--------------------------------------------------------------------
                '--------------------------------------------------------------------
            Case "Portable Document (PDF)"
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.pdf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/pdf"
                '--------------------------------------------------------------------

                '--------------------------------------------------------------------
            Case "MS Word (DOC)"
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.doc")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/doc"
                '--------------------------------------------------------------------

                '--------------------------------------------------------------------
            Case "MS Excel (XLS)"
                oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.xls")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                'Response.ContentType = "application/vnd.text"
                '--------------------------------------------------------------------
        End Select 'export format
        Try
            Response.BinaryWrite(oStream.ToArray())
            Response.End()
        Catch err As Exception
            Response.Write("<BR>")
            Response.Write(err.Message.ToString)
        End Try
    End Sub


    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged


    End Sub
End Class
