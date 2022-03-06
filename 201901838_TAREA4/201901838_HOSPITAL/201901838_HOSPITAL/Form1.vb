Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcularToolStripMenuItem.Click


        If (iniciar <= 5) Then
            If (txtnombre.Text <> "") And (txtnit.Text <> "") And (txtdias.Text <> "") And (txthonorarios.Text <> "") Then
                Nombre(iniciar) = txtnombre.Text
                Nit(iniciar) = txtnit.Text
                Dias(iniciar) = txtdias.Text
                Honorarios(iniciar) = txthonorarios.Text

            Else
                MsgBox("No ingresó los datos")
                txtnombre.Focus()
                Exit Sub
            End If
            If (ComboBox1.SelectedIndex > -1) Then
                Habitacion(iniciar) = ComboBox1.Text
            Else
                MsgBox("No seleccionó habitacion")
                ComboBox1.Focus()
                Exit Sub
            End If



            parcial(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : privado()
                Case 1 : semiprivado()
                Case 2 : noprivado()

            End Select


            If rbefectivo.Checked Or rbdebito.Checked Or rbcheque.Checked Then
                descuento(iniciar) = descuento_recargo()
                total(iniciar) = totalfinal()
                resultados()
                iniciar = iniciar + 1
            Else
                recargo(iniciar) = descuento_recargo()
                total(iniciar) = totalfinal()
                resultados()
                iniciar = iniciar + 1
            End If



            
        End If
            If iniciar = 6 Then
                MsgBox("Vectores llenos")
                limpiar_entradas()
            End If
    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarToolStripMenuItem.Click
        Call limpiar_entradas()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Call limpiar_vectores()

    End Sub
End Class