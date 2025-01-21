Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.Sqlclient
Imports System.Data
Imports System.Web.Mail
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
'Imports System.Configuration
'Imports System.Data
'Imports System.Data.SqlClient
Imports CrystalDecisions.ReportSource
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
'Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Net
Imports System.Drawing.Printing



Public Class Dmail
    Inherits System.Web.UI.Page

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
        Dim emailMessage3 As MailMessage
        Dim FNAME As String

        '----------
        'Dim Dsst3 As newvwhreport = New newvwhreport
        'Dim DiskOptst4 As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dsst3.SetDatabaseLogon("sa", "tstc123")
        ''DssDsst3SetParameterValue("Com", "" & com11 & "")
        ''Dss.SetParameterValue("fm", "" & TEmail & "")
        ''Dss.SetParameterValue("tm", "" & FEmail & "")
        'Dsst3.ExportOptions.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile
        'Dsst3.ExportOptions.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat
        'DiskOptst4.DiskFileName = Server.MapPath("Data/" & "VehicleDSI.pdf")
        'Dsst3.ExportOptions.DestinationOptions = DiskOptst4
        'Dsst3.Export()
        'FNAME = Server.MapPath("Data/" & "VehicleDSI.pdf")
        'emailMessage3.Attachments.Add(New MailAttachment(FNAME))


        '-------


        emailMessage3 = New MailMessage

        emailMessage3.From = "insurance@dsisamson.com"

        'emailMessage1.From = "insurance@dsisamson.com"
        emailMessage3.To = "chamindas@samsoncorporates.com,udanip@samsoncorporates.com,health1@samsoncorporates.com,palithan@samsoncorporates.com"
        'emailMessage2.To = "palithan@samsoncorporates.com"
        emailMessage3.Subject = "Vehcle Insurance to be Expired-Next Days" + " "
        Dim Dss As newvwhreport = New newvwhreport
        Dim DiskOpts As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        Dss.SetDatabaseLogon("sa", "tstc123")
        ' Dss.SetDatabaseLogon("sa", "tstc123")
        'Dss.SetParameterValue("Com", "" & com11 & "")
        'Dss.SetParameterValue("fm", "" & TEmail & "")
        'Dss.SetParameterValue("tm", "" & FEmail & "")
        Dss.ExportOptions.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile
        Dss.ExportOptions.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat
        DiskOpts.DiskFileName = Server.MapPath("Data/" & "SeeAttached.pdf")
        Dss.ExportOptions.DestinationOptions = DiskOpts
        Dss.Export()

        emailMessage3.Body += "For Details:Please refer the attachment" & vbCrLf

        FNAME = Server.MapPath("Data/" & "SeeAttached.pdf")
        emailMessage3.Attachments.Add(New MailAttachment(FNAME))
        SmtpMail.SmtpServer = "mail.dsisamson.com"
        Try
            ' If COUNT <> 0 Then
            SmtpMail.Send(emailMessage3)

            'emailMessage3.Body = finalHtml
            'emailMessage3.IsBodyHtml = True

            'End If
        Catch ex As Exception

        End Try







    End Sub

End Class
