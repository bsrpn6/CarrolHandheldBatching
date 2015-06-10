Imports System.Configuration
Imports System.Data.SqlClient

Public Class DatabaseConnection
 
    Public Shared Function CreateSQLConnection() As SqlConnection
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("BatchDB")
        Dim ConnectionString As String

        ConnectionString = settings.ConnectionString
        Return New SqlConnection(ConnectionString)

    End Function

    Public Shared Function CreateSQLDependency(myCmd As SqlCommand) As SqlDependency
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("BatchDB")
        Dim ConnectionString As String

        ConnectionString = settings.ConnectionString
        Return New SqlDependency(myCmd)

    End Function

    Public Shared Function ReturnConnectionString() As String
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("BatchDB")
        Dim ConnectionString As String

        ConnectionString = settings.ConnectionString
        Return ConnectionString
    End Function

    Public Shared Function BatchAssignToUnit(ByVal BatchUnit As String, ByVal OverrideLevel As Integer, Optional ByVal BatchID As Integer = Nothing)
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand

        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "scnBatchAssignToUnit"
        myCmd.CommandType = CommandType.StoredProcedure

        '' @BatchID int,
        '' @BatchUnit varchar(16),
        '' @OverrideLevel int,
        '' @ErrorMsg varchar(40) OUTPUT


        myCmd.Parameters.AddWithValue("BatchID", If(BatchID = Nothing, DBNull.Value, BatchID))
        myCmd.Parameters.AddWithValue("BatchUnit", BatchUnit)
        myCmd.Parameters.AddWithValue("OverrideLevel", OverrideLevel)

        Dim ErrorMsg As SqlParameter = myCmd.Parameters.Add("ErrorMsg", SqlDbType.VarChar)
        ErrorMsg.Direction = ParameterDirection.Output
        ErrorMsg.Size = 40

        Dim ReturnValue As SqlParameter = myCmd.Parameters.Add("ReturnVal", SqlDbType.Int)
        ReturnValue.Direction = ParameterDirection.ReturnValue

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteReader()
        'myReader = myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
            Return -1

        ElseIf ReturnValue.Value = 0 And OverrideLevel = 0 Then
            If MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString, "Continue?", MessageBoxButtons.YesNo) Then
                DatabaseConnection.BatchAssignToUnit(BatchUnit, 1, BatchID)

                Return 1
            End If
        ElseIf ReturnValue.Value > 0
            Return ReturnValue.Value
        End If

        myConn.Close()

        Return Nothing

    End Function

    Public Shared Function BatchUpdateStep(ByVal BatchID As Integer, ByVal BatchStepID As Integer, ByVal StepStatus As String, ByVal OverrideLevel As Integer, Optional ByVal ParamActual As Double = Nothing, Optional ByVal LotNumber As String = Nothing)

        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "scnBatchUpdateStep"
        myCmd.CommandType = CommandType.StoredProcedure

        '' @BatchID int,
        '' @BatchStepID int,
        '' @StepStatus char(4),
        '' @ParamActual real,
        '' @LotNumber varchar(16),
        '' @OverrideLevel int,
        '' @ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("BatchID", BatchID)
        myCmd.Parameters.AddWithValue("BatchStepID", BatchStepID)
        myCmd.Parameters.AddWithValue("StepStatus", StepStatus)
        myCmd.Parameters.AddWithValue("ParamActual", If(ParamActual = Nothing, DBNull.Value, ParamActual))
        myCmd.Parameters.AddWithValue("LotNumber", If(LotNumber = Nothing, DBNull.Value, LotNumber))
        myCmd.Parameters.AddWithValue("OverrideLevel", OverrideLevel)

        Dim ErrorMsg As SqlParameter = myCmd.Parameters.Add("ErrorMsg", SqlDbType.VarChar)
        ErrorMsg.Direction = ParameterDirection.Output
        ErrorMsg.Size = 40

        Dim ReturnValue As SqlParameter = myCmd.Parameters.Add("ReturnVal", SqlDbType.Int)
        ReturnValue.Direction = ParameterDirection.ReturnValue

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteReader()
        'myReader = myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
        End If

        myConn.Close()

        Return ReturnValue.Value

    End Function

    Public Shared Function BatchUpdateStatus(ByVal BatchID As Integer, ByVal BatchStatus As String, ByVal OverrideLevel As Integer)
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "scnBatchUpdateStatus"
        myCmd.CommandType = CommandType.StoredProcedure

        ''  @BatchID int,
        ''  @BatchStatus char(4),
        ''  @OverrideLevel int,
        ''  @ErrorMsg varchar(40) OUTPUT


        myCmd.Parameters.AddWithValue("BatchID", BatchID)
        myCmd.Parameters.AddWithValue("BatchStatus", BatchStatus)
        myCmd.Parameters.AddWithValue("OverrideLevel", OverrideLevel)

        Dim ErrorMsg As SqlParameter = myCmd.Parameters.Add("ErrorMsg", SqlDbType.VarChar)
        ErrorMsg.Direction = ParameterDirection.Output
        ErrorMsg.Size = 40

        Dim ReturnValue As SqlParameter = myCmd.Parameters.Add("ReturnVal", SqlDbType.Int)
        ReturnValue.Direction = ParameterDirection.ReturnValue

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteReader()
        'myReader = myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

    Public Shared Function BatchUpdateBOM(ByVal BatchID As Integer, ByVal BOMItemID As Integer, ByVal BOMQtyStaged As Double, ByVal LotNumber As String, ByVal OverrideLevel As Integer)
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        'Create a Connection object.
        myConn = DatabaseConnection.CreateSQLConnection()

        'Create a Command object.
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "scnBatchUpdateBOM"
        myCmd.CommandType = CommandType.StoredProcedure

        '' @BatchID int,
        '' @BOMItemID int,
        '' @BOMQtyStaged real,
        '' @LotNumber varchar(16),
        '' @OverrideLevel int,
        '' @ErrorMsg varchar(40) OUTPUT

        myCmd.Parameters.AddWithValue("BatchID", BatchID)
        myCmd.Parameters.AddWithValue("BOMItemID", BOMItemID)
        myCmd.Parameters.AddWithValue("BOMQtyStaged", BOMQtyStaged)
        myCmd.Parameters.AddWithValue("LotNumber", LotNumber)
        myCmd.Parameters.AddWithValue("OverrideLevel", OverrideLevel)

        Dim ErrorMsg As SqlParameter = myCmd.Parameters.Add("ErrorMsg", SqlDbType.VarChar)
        ErrorMsg.Direction = ParameterDirection.Output
        ErrorMsg.Size = 40

        Dim ReturnValue As SqlParameter = myCmd.Parameters.Add("ReturnVal", SqlDbType.Int)
        ReturnValue.Direction = ParameterDirection.ReturnValue

        'Open the connection.
        myConn.Open()

        myCmd.ExecuteReader()
        'myReader = myCmd.ExecuteReader()

        If ReturnValue.Value < 0 Then
            MessageBox.Show("Error # (" & ReturnValue.Value.ToString & "): " & ErrorMsg.Value.ToString)
        End If

        myConn.Close()

        Return ReturnValue.Value
    End Function

End Class
