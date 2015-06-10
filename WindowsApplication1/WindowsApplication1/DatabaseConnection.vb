Imports System.Configuration
Imports System.Data.SqlClient

Public Class DatabaseConnection



    Public Shared Function CreateSQLConnection() As SqlConnection

        Dim ConnectionString As String
        ConnectionString = ConfigurationManager.AppSettings("DBConnectionString")
        Return New SqlConnection(ConnectionString)

    End Function

    Public Shared Function ReturnConnectionString() As String
        Dim ConnectionString As String
        ConnectionString = ConfigurationManager.AppSettings("DBConnectionString")
        Return ConnectionString
    End Function


End Class
