Imports System.Data.SqlClient
Public Class Class_e
    Dim con As New SqlConnection(My.Settings.conexion)
    Public cmd As SqlCommand
    Function Verificar(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        con.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
