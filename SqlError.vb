Imports System.Data.Odbc

Public Class SqlError
    Inherits Databasic.SqlError

	Public Property Source As String
	Public Property SQLState As String

	Public Sub New(mySqlError As System.Data.Odbc.OdbcError)
		Me.Message = mySqlError.Message
		Me.Code = mySqlError.NativeError

		Me.Source = mySqlError.Source
		Me.SQLState = mySqlError.SQLState
	End Sub

End Class