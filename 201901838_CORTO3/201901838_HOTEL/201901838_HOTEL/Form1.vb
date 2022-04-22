Public Class Form1


    Private Sub CálculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoToolStripMenuItem.Click
        If (iniciar <= 6) Then
            Nit(iniciar) = Val(txtnit.Text)
            Nombre(iniciar) = txtnombre.Text
            dias(iniciar) = Val(txtdias.Text)

            habitacion(iniciar) = ComboBox1.Text
            pago(iniciar) = ComboBox2.Text



            parcial(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : sencilla()
                Case 1 : doble()
                Case 2 : cabaña()

            End Select
            impuesto(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : efectivo()
                Case 1 : credito()
                Case 2 : debito()
                Case 3 : transferencia()
                Case 4 : deposito()


            End Select


            iniciar = iniciar + 1

        End If
        If (iniciar = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0


        While (I <= 6) And Not (existe)
            'en el siguiente If se hace la pregunta que si el dato a buscar está en el vector de búsqueda (Carnet)
            'observe que en la caja de texto 9 es donde está el carnet a buscar
            If (Nit(I) = Val(txtnit.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro se encontró exitosamente")

            txtnit.Text = Str(Nit(I))
            txtnombre.Text = Nombre(I)
            txtdias.Text = Str(dias(I))
            ComboBox1.Text = habitacion(I)
            ComboBox1.Text = pago(I)


            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add((Nombre(I)), Nit(I), Str(dias(I)), (habitacion(I)), (pago(I)), Str(impuesto(I)), Str(parcial(I)), Str(total(I)))

            iniciar = I
        Else
            MsgBox("NIT no encontrado")
            txtbuscar.Focus()




        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Nombre(iniciar) = Nothing
        Nit(iniciar) = Nothing
        dias(iniciar) = Nothing
        habitacion(iniciar) = Nothing
        pago(iniciar) = Nothing
        impuesto(iniciar) = Nothing
        parcial(iniciar) = Nothing
        total(iniciar) = Nothing


        For I = iniciar To 3

            Nombre(I) = Nombre(I + 1)
            Nit(I) = Nit(I + 1)
            dias(I) = dias(I + 1)
            habitacion(I) = habitacion(I + 1)
            pago(I) = pago(I + 1)
            impuesto(I) = impuesto(I + 1)
            parcial(I) = parcial(I + 1)
            total(I) = total(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")


        Nombre(iniciar) = Nothing
        Nit(iniciar) = Nothing
        dias(iniciar) = Nothing
        habitacion(iniciar) = Nothing
        pago(iniciar) = Nothing
        impuesto(iniciar) = Nothing
        parcial(iniciar) = Nothing
        total(iniciar) = Nothing

        iniciar = I

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class
