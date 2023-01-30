'Libreria'
Imports System.Data.SqlClient
Public Class Form1
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declarar form de Crud'
        Dim Form = Form2
        'Declarar sentencias con los tipos de roll'
        Dim a As String = "Update LOGIN1 Set Roll=Roll where Usuario='" + TextBox1.Text + "' and Contraseña='" + TextBox2.Text + "' and Roll='Administrador'"
        Dim b As String = "Update LOGIN1 Set Roll=Roll where Usuario='" + TextBox1.Text + "' and Contraseña='" + TextBox2.Text + "' and Roll='Secretaria'"
        Dim c As String = "Update LOGIN1 Set Roll=Roll where Usuario='" + TextBox1.Text + "' and Contraseña='" + TextBox2.Text + "' and Roll='Usuario'"
        'If de verificacion'
        If (Verificar(a)) Then
            Form2.Show()
            Me.Hide()
            MsgBox("Administrador")
        ElseIf (Verificar(b)) Then
            'Buttons de permiso'
            Form.Button1.Visible = False
            Form.Button3.Visible = False
            Form2.Show()
            MsgBox("Secretaria")
            Me.Hide()
        ElseIf (Verificar(c)) Then
            'Buttons de permiso'
            Form.Button1.Visible = False
            Form.Button3.Visible = False
            Form.Button4.Visible = False
            Form2.Show()
            MsgBox("usuario")
            Me.Hide()
        Else
            'Error Explicado'
            MessageBox.Show("Error, usuario o contraseña incorrectos")
        End If
    End Sub
End Class
