Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click



        If (iniciar <= 6) Then
            id(iniciar) = Val(txtid.Text)
            tipoviaje(iniciar) = ComboBox1.Text

            dias(iniciar) = Val(txtnu.Text)
            personas(iniciar) = Val(txtpersonas.Text)


            pagofinal(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : tipo1()
                Case 1 : tipo2()
                Case 2 : tipo3()


            End Select



            iniciar = iniciar + 1
            limpiar_entradas()

        End If
        If (iniciar = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        I = 0
        Dim existe As Boolean = False
        While (I <= 6) And Not (existe)

            If (id(I) = Val(txtbuscar.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            txtid.Text = Str(id(I))
            txtnu.Text = Str(dias(I))
            txtpersonas.Text = Str(personas(I))
            ComboBox1.Text = tipoviaje(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(id(I)), tipoviaje(I), Str(dias(I)), Str(personas(I)), Str(cobrodia(I)), Str(pagofinal(I)))

            iniciar = I
        Else
            MsgBox("ID no encontrado")
            txtbuscar.Focus()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        id(iniciar) = Nothing
        dias(iniciar) = Nothing
        personas(iniciar) = Nothing
        tipoviaje(iniciar) = Nothing
        cobrodia(iniciar) = Nothing
        pagofinal(iniciar) = Nothing


        For I = iniciar To 5

            id(I) = id(I + 1)
            dias(I) = dias(I + 1)
            personas(I) = personas(I + 1)
            tipoviaje(I) = tipoviaje(I + 1)
            cobrodia(I) = cobrodia(I + 1)
            pagofinal(I) = pagofinal(I + 1)

        Next I
        MsgBox("El registro se eliminó con exito")

        id(iniciar) = Nothing
        dias(iniciar) = Nothing
        personas(iniciar) = Nothing
        tipoviaje(iniciar) = Nothing
        cobrodia(iniciar) = Nothing
        pagofinal(iniciar) = Nothing

        iniciar = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtnu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnu.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpersonas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpersonas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged

    End Sub

    Private Sub txtbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub
End Class
