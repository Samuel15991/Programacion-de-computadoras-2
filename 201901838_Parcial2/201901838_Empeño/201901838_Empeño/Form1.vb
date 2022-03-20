Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcularToolStripMenuItem.Click


       


        ComboBox1.Items.Add("Corto plazo")
        ComboBox1.Items.Add("Largo plazo")



        If (indice <= 6) Then
            empeño(indice, 0) = ListBox1.Items.Add(txtnombre.Text)
            empeño(indice, 1) = ListBox2.Items.Add(txtcui.text)
            empeño(indice, 2) = ListBox3.Items.Add(txtcosto.text)
            empeño(indice, 3) = ListBox4.Items.Add(ComboBox1.Text)


        End If



        Select Case ComboBox1.SelectedIndex
            Case 0 : cortoplazo()
            Case 1 : largoplazo()

        End Select



        indice = indice + 1

        If (indice = 6) Then
            MsgBox("La matriz está llena")
        End If








        




    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub
End Class
