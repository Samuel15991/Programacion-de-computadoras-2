Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If (iniciar <= 11) Then
            etapa(iniciar) = Val(txtetapa.Text)

            equipo(iniciar) = ComboBox1.Text

            km(iniciar) = Val(txtkm.Text)
            tiempo(iniciar) = Val(txtminutos.Text)
            nacionalidad(iniciar) = ComboBox2.Text


            penalidad(iniciar) = 0
            Select Case (ComboBox1.SelectedIndex)
                Case 0 : sky()
                Case 1 : movistar()
                Case 3 : prociclyng()
                Case 4 : proteam()

            End Select



            iniciar = iniciar + 1
            limpiar_entradas()

        End If
        If (iniciar = 12) Then
            MsgBox("vectores llenos")
        End If
    End Sub






    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        etapa(iniciar) = Val(txtetapa.Text)
        equipo(iniciar) = ComboBox1.Text
        km(iniciar) = Val(txtkm.Text)
        tiempo(iniciar) = Val(txtminutos.Text)
        nacionalidad(iniciar) = ComboBox2.Text

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()


    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        I = 0
        Dim existe As Boolean = False
        While (I <= 11) And Not (existe)

            If (etapa(I) = Val(txtbusqueda.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Etapa encontrada exitosamente")

            txtetapa.Text = Str(etapa(I))
            ComboBox1.Text = equipo(I)
            txtkm.Text = Str(km(I))
            txtminutos.Text = Str(tiempo(I))
            ComboBox2.Text = nacionalidad(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(etapa(I)), equipo(I), Str(km(I)), Str(tiempo(I)), (nacionalidad(I)), Str(penalidad(I)))

            iniciar = I
        Else
            MsgBox("Etapa no encontrada")
            txtbusqueda.Focus()
        End If
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click




        'METODO QUE SE UTILIZA PARA REALIZAZR EL ORDENAMIENTO DE BURBUJA DE LOS VECTORES, TOMANDO COMO BASE EL VECTOR DE LA FACTURA
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As Integer
        Dim temp5 As String
        Dim temp6 As Double


        For i = 0 To 10
            For j = i + 1 To 11

                If (etapa(j) <> Nothing) Then
                    If (etapa(i) > etapa(j)) Then

                        temp1 = etapa(i)
                        etapa(i) = etapa(j)
                        etapa(j) = temp1

                        temp2 = equipo(i)
                        equipo(i) = equipo(j)
                        equipo(j) = temp2

                        temp3 = km(i)
                        km(i) = km(j)
                        km(j) = temp3

                        temp4 = tiempo(i)
                        tiempo(i) = tiempo(j)
                        tiempo(j) = temp4

                        temp5 = nacionalidad(i)
                        nacionalidad(i) = nacionalidad(j)
                        nacionalidad(j) = temp5

                        temp6 = penalidad(i)
                        penalidad(i) = penalidad(j)
                        penalidad(j) = temp6
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i

















    End Sub



End Class
