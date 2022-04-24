Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click





        If (iniciar <= 6) Then
            placa(iniciar) = Val(txtplaca.Text)
            tipoauto(iniciar) = ComboBox1.Text

            kinicial(iniciar) = Val(txtki.Text)
            kfinal(iniciar) = Val(txtkf.Text)


            pagofinal(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : tipo1()
                Case 1 : tipo2()
                Case 3 : tipo3()
                Case 4 : tipo4()

            End Select



            iniciar = iniciar + 1
            limpiar_entradas()

        End If
        If (iniciar = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub txtplaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplaca.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtki_TextChanged(sender As Object, e As EventArgs) Handles txtki.TextChanged

    End Sub

    Private Sub txtki_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtki.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtkf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkf.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        I = 0
        Dim existe As Boolean = False
        While (I <= 6) And Not (existe)

            If (placa(I) = Val(txtbusqueda.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            txtplaca.Text = Str(placa(I))
            ComboBox1.Text = tipoauto(I)
            txtki.Text = Str(kinicial(I))
            txtkf.Text = Str(kfinal(I))
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(placa(I)), tipoauto(I), Str(cobrobase(I)), Str(kinicial(I)), Str(kfinal(I)), Str(pagofinal(I)))

            iniciar = I
        Else
            MsgBox("Placa no encontrada")
            txtbusqueda.Focus()
        End If









    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click



        placa(iniciar) = Val(txtplaca.Text)
        tipoauto(iniciar) = ComboBox1.Text

        kinicial(iniciar) = Val(txtki.Text)
        kfinal(iniciar) = Val(txtkf.Text)




        MsgBox("Registro actualizado correctamente en los vectores")

        iniciar = 7
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        placa(iniciar) = Nothing
        tipoauto(iniciar) = Nothing
        kinicial(iniciar) = Nothing
        kfinal(iniciar) = Nothing
        cobrobase(iniciar) = Nothing
        pagofinal(iniciar) = Nothing


        For I = iniciar To 5

            placa(I) = placa(I + 1)
            tipoauto(I) = tipoauto(I + 1)
            kinicial(I) = kinicial(I + 1)
            kfinal(I) = kfinal(I + 1)
            cobrobase(I) = cobrobase(I + 1)
            pagofinal(I) = pagofinal(I + 1)

        Next I
        MsgBox("Registro Eliminado exitosamente")

        placa(iniciar) = Nothing
        tipoauto(iniciar) = Nothing
        kinicial(iniciar) = Nothing
        kfinal(iniciar) = Nothing
        cobrobase(iniciar) = Nothing
        pagofinal(iniciar) = Nothing

        iniciar = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub
End Class
