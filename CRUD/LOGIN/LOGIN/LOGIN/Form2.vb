'Libreria'
Imports System.Data.SqlClient
Public Class Form2
    'Declarar conexion'
    Dim con As New SqlConnection(My.Settings.conexion)
    'Declarar SqlCOmmand'
    Public cmd As SqlCommand
    'Realizar Funcion verificar'
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
    'Realizar Funcion/Sub mostrar'
    Public Sub mostrar()
        Try
            Dim da As New SqlDataAdapter("Select *From CRUD", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Realizar condificacion de buttons'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Realizar condificacion de buttons'
        Dim Editar = "Update CRUD Set Nombre='" + TextBox2.Text + "', Correo='" + TextBox3.Text + "', Pais='" + TextBox4.Text + "', OcupaCion='" + TextBox5.Text + "' WHERE ID='" + TextBox1.Text + "'"
        If Verificar(Editar) Then
        Else
            MsgBox("Error")
        End If
        mostrar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Realizar condificacion de buttons'
        Dim insertar = "Insert into CRUD values ('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
        If Verificar(insertar) Then
        Else
            MsgBox("Error")
        End If
        mostrar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Realizar condificacion de buttons'
        Dim borrar = "Delete from CRUD where ID='" + TextBox1.Text + "'"
        If Verificar(borrar) Then
        Else
            MsgBox("Error")
        End If
        mostrar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Realizar condificacion de buttons'
        mostrar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Realizar condificacion de buttons'
        Dim da As New SqlDataAdapter("Select *From CRUD where ID= '" + TextBox1.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class