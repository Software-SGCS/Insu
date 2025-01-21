Imports System.Web
Imports System.Web.SessionState

Public Class Global
    Inherits System.Web.HttpApplication
    Public Shared PVehno As String
    Public Shared Tagno As Integer
    Public Shared FrmName As String
    Public Shared RptNo As String
    Public Shared SysName As String
    Public Shared PUserId As String
    Public Shared Ppwd As String
    Public Shared PNam As String
    Public Shared PEmail As String
    Public Shared PwFlag As String
    Public Shared PwFlag1 As String
    Public Shared PInvno As String
    Public Shared PwLevel As String
    Public Shared Fmname As String
    Public Shared pcat As String

    Public Shared PSec As String
    Public Shared LOGTIME As String

    Public Shared Ldate As String
    Public Shared Ltime As String
    
    'Public PVehno As String
    'Public Tagno As Integer
    'Public FrmName As String
    'Public RptNo As String
    'Public SysName As String
    'Public PUserId As String
    'Public Ppwd As String
    'Public PNam As String
    'Public PEmail As String
    'Public PwFlag As String
    'Public PwFlag1 As String
    'Public PInvno As String
    'Public PwLevel As String
    'Public Fmname As String
    'Public pcat As String

    'Public PSec As String
    'Public LOGTIME As String

    'Public Ldate As String
    'Public Ltime As String



   

    


#Region " Component Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class
