Imports System.Data.Odbc

Public Class SqlError
    Inherits Databasic.SqlError

	Public Property Source As String
	Public Property SQLState As String

	Public Sub New(odbcSqlError As System.Data.Odbc.OdbcError)
		Me.Message = odbcSqlError.Message
		Me.Code = odbcSqlError.NativeError

		Me.Source = odbcSqlError.Source
		Me.SQLState = odbcSqlError.SQLState
	End Sub

End Class