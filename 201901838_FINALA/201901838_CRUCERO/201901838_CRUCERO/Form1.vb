Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click
        If (iniciar <= 5) Then
            nit(iniciar) = Val(txtnit.Text)
            nombre(iniciar) = txtcliente.Text
            cabina(iniciar) = ComboBox1.Text

            numero(iniciar) = Val(txtnumero.Text)


            pagofinal(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : cab1()
                Case 1 : cab2()
                Case 2 : cab3()


            End Select
            iniciar = iniciar + 1
            limpiar_entradas()


        End If
        If (iniciar = 6) Then
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        I = 0
        Dim existe As Boolean = False
        While (I <= 5) And Not (existe)

            If (nit(I) = Val(txtbusqueda.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Registro encontrado satisfactoriamente")

            txtnit.Text = Str(nit(I))
            txtcliente.Text = (nombre(I))
            txtnumero.Text = Str(numero(I))
            ComboBox1.Text = cabina(I)
            rbclase1.Text = clase(I)
            rbclase2.Text = clase(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(nit(I)), nombre(I), Str(numero(I)), clase(I), cabina(I), Str(precio(I)), Str(pagofinal(I)))

            iniciar = I
        Else
            MsgBox("NIT no encontrado")
            txtbusqueda.Focus()

        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub
End Class
