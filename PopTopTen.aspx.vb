Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Public Class PopTopTen

    Inherits System.Web.UI.Page
    'Dim OBJ1 As New WORD
    Dim ADA As SqlDataAdapter
    Dim CMD, CMDD As SqlCommand
    Dim DR, DR1 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim LOD, V1, V2, V3, Cal As String
    Dim CHKDUP As Boolean
    'Dim DSS As BestSelling1 = New BestSelling1
    Dim DSS As A = New A
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Literal1 As System.Web.UI.WebControls.Literal
    Protected CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Dim fileList As ArrayList = New ArrayList





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

        Literal1.Text = "<title>" & "Global.txtPATH" & "</title>"


       
        Try
            'OBJ1.ConnectDBH()
            CrystalReportViewer1.Visible = True
            DSS.SetDatabaseLogon("sa", "tstc123")
            DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.SetParameterValue("Uname", "" & Global.UNAME & "")
            'DSS.SetParameterValue("GTOT", "" & Global.GTOT & "")
            'DSS.SetParameterValue("OP", "" & Global.OPT & "")
            'DSS.SetParameterValue("WD", "" & Global.WED & "")
            ' DSS.SetParameterValue("M", "" & Global.MON1 & "")
            
            'DSS.SetParameterValue("M4", "" & Global.txtPATH & "")
           
            CrystalReportViewer1.ReportSource = DSS
            CrystalReportViewer1.DataBind()

            If Not IsPostBack Then
                With DropDownList1.Items
                    .Add("Rich Text (RTF)")
                    .Add("Portable Document (PDF)")
                    .Add("MS Word (DOC)")
                    .Add("MS Excel (XLS)")
                End With
            End If
        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub



    Sub ExportReport()

        Dim oStream As New MemoryStream ' // using System.IO

        Select Case DropDownList1.SelectedItem.Text 'this contains the value of the selected export format.

            Case "Rich Text (RTF)"
                '--------------------------------------------------------------------
                oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.rtf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/rtf"
                '--------------------------------------------------------------------
                '--------------------------------------------------------------------
            Case "Portable Document (PDF)"
                oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.pdf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/pdf"
                '--------------------------------------------------------------------

                '--------------------------------------------------------------------
            Case "MS Word (DOC)"
                oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows)
                Response.AddHeader("content-disposition", "attachment;filename=FileName.doc")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/doc"
                '--------------------------------------------------------------------

                '--------------------------------------------------------------------
            Case "MS Excel (XLS)"
                oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel)
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ExportReport()
        Catch ex As Exception
            Response.Write(ex.Message)
            Response.End()
        End Try
    End Sub
End Class
