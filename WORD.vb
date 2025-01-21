Imports System.Data.OracleClient
Imports System.Data

Public Class WORD
    Public CON As New OracleConnection
    Dim ADA As OracleDataAdapter
    Dim CMD As OracleCommand
    Dim DR, DR1, DR5, DR2 As OracleDataReader

    Public Sub ConnectDB()

        CON = New OracleConnection("data source=XPDSS;UID=FLEET;PWD=FLEET")
        CON.Open()

    End Sub
End Class
