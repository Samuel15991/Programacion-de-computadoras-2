Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcularToolStripMenuItem.Click


        

        If (control <= 8) Then
            If (txtcantidad.Text <> "") Then
                cantidad(control) = txtcantidad.Text


            Else
                MsgBox("No ingresó la cantidad de sillones")
                txtcantidad.Focus()
                Exit Sub
            End If
        End If


        If rbcuerina.Checked = False And rbcuero.Checked = False Then

            MsgBox("No seleccionó la tela")
            Exit Sub


        End If

        If (ComboBox1.SelectedIndex > -1) Then
            tamaño(control) = ComboBox1.Text
        Else
            MsgBox("No seleccionó el tamaño")
            ComboBox1.Focus()
            Exit Sub
        End If




        precio(control) = 0
        Select Case (ComboBox1.SelectedIndex)
            Case 0 : sofa()
            Case 1 : individual()
            Case 2 : doble()

        End Select

        If control = 8 Then
            MsgBox("Vectores llenos")

        End If

    End Sub

    Private Sub txtcantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked


    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub
End Class
