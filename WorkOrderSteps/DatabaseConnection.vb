Imports System.Data.SqlClient

Public Class DatabaseConnection
 
    Public Shared Function CreateSQLConnection() As SqlConnection

        Dim ConnectionString As String
        ConnectionString = "Data Source=INBATCHDEV;Initial Catalog=BatchDB;User ID=wwAdmin;Password=wwAdmin"
        Return New SqlConnection(ConnectionString)

    End Function

    Public Shared Function CreateSQLDependency(myCmd As SqlCommand) As SqlDependency
        Dim ConnectionString As String
        ConnectionString = "Data Source=INBATCHDEV;Initial Catalog=BatchDB;User ID=wwAdmin;Password=wwAdmin"
        Return New SqlDependency(myCmd)

    End Function

    Public Shared Function ReturnConnectionString() As String
        Dim ConnectionString As String
        ConnectionString = "Data Source=INBATCHDEV;Initial Catalog=BatchDB;User ID=wwAdmin;Password=wwAdmin"
        Return ConnectionString
    End Function


End Class
