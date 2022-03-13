Public Class Form1

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcularToolStripMenuItem.Click

      
        If txthoras.Text = "" Then
            MsgBox("No ingresó la cantidad de horas")
            Exit Sub

        End If

        If txtnombre.Text = "" Then
            MsgBox("No ingresó el nombre")
            Exit Sub
        End If


        If txtcarnet.Text = "" Then
            MsgBox("No ingresó el carnet")
            Exit Sub
        End If

        If cbsabado.Checked = False And cbviernes.Checked = False Then

            MsgBox("No seleccionó el dia")
            Exit Sub


        End If








        If (comienzo1 <= 7) Then
            academia(comienzo1, 0) = txtcarnet.Text
            academia(comienzo1, 1) = txtnombre.Text
            academia(comienzo1, 2) = dtpfecha.Value
            academia(comienzo1, 3) = ComboBox1.Text
            academia(comienzo1, 4) = txthoras.Text
            academia(comienzo1, 5) = cbviernes.Text
            academia(comienzo1, 5) = cbsabado.Text

        End If





        Select Case ComboBox1.SelectedIndex
            Case 0
                academia(comienzo1, 7) = Str(((Val(academia(comienzo1, 4) * h_ingles))))
            Case 1
                academia(comienzo1, 7) = Str(((Val(academia(comienzo1, 4) * h_portugues))))
            Case 2
                academia(comienzo1, 7) = Str(((Val(academia(comienzo1, 4) * h_frances))))
            Case Else
                MsgBox("No seleccionó el idioma")
                Exit Sub

        End Select


        'descuentos
        If rbcheque.Checked Or rbefectivo.Checked Then



            If rbefectivo.Checked Then
                If rbefectivo.Checked And cbviernes.Checked Then
                    academia(comienzo1, 6) = rbefectivo.Text
                    academia(comienzo1, 8) = Str(Val(academia(comienzo1, 7) * 0.02))
                    academia(comienzo1, 5) = "Viernes"
                End If
                academia(comienzo1, 10) = Str(Val(academia(comienzo1, 7)) - Val(academia(comienzo1, 8)))





                If rbefectivo.Checked And cbsabado.Checked Then
                    academia(comienzo1, 6) = rbefectivo.Text
                    academia(comienzo1, 8) = Str(Val(academia(comienzo1, 7) * 0.02))
                    academia(comienzo1, 5) = "Sábado"
                End If
                academia(comienzo1, 10) = Str(Val(academia(comienzo1, 7)) - Val(academia(comienzo1, 8)))





                If rbefectivo.Checked And cbsabado.Checked And cbviernes.Checked Then
                    academia(comienzo1, 6) = rbefectivo.Text
                    academia(comienzo1, 8) = Str(Val(academia(comienzo1, 7) * 0.02))
                    academia(comienzo1, 5) = "Viernes y Sábado"
                    academia(comienzo1, 9) = Str(Val(academia(comienzo1, 7) * 0.05))
                Else
                    academia(comienzo1, 9) = 0
                End If
                academia(comienzo1, 10) = Str(Val(academia(comienzo1, 7)) - Val(academia(comienzo1, 8) + Val(academia(comienzo1, 9))))
            


            End If




            If rbcheque.Checked Then

                If rbcheque.Checked And cbviernes.Checked Then
                    academia(comienzo1, 6) = rbcheque.Text
                    academia(comienzo1, 8) = Str(Val(academia(comienzo1, 7) * 0.015))
                    academia(comienzo1, 5) = "Viernes"
                End If
                academia(comienzo1, 10) = Str(Val(academia(comienzo1, 7)) - Val(academia(comienzo1, 8)))



                If rbcheque.Checked And cbsabado.Checked Then
                    academia(comienzo1, 6) = rbcheque.Text
                    academia(comienzo1, 8) = Str(Val(academia(comienzo1, 7) * 0.015))
                    academia(comienzo1, 5) = "Sábado"
                End If
                academia(comienzo1, 10) = Str(Val(academia(comienzo1, 7)) - Val(academia(comienzo1, 8)))


                If rbcheque.Checked And cbsabado.Checked And cbviernes.Checked Then
                    academia(comienzo1, 6) = rbcheque.Text
                    academia(comienzo1, 8) = Str(Val(academia(comienzo1, 7) * 0.015))
                    academia(comienzo1, 5) = "Viernes y Sábado"
                    academia(comienzo1, 9) = Str(Val(academia(comienzo1, 7) * 0.05))
                Else
                    academia(comienzo1, 9) = 0
                End If
                academia(comienzo1, 10) = Str(Val(academia(comienzo1, 7)) - Val(academia(comienzo1, 8) + Val(academia(comienzo1, 9))))


            End If
        Else
            MsgBox("No seleccionó el metodo de pago")
            Exit Sub

        End If



        verresultados()
        comienzo1 = comienzo1 + 1



        If (comienzo1 = 8) Then
            MsgBox("La matriz está llena")
        End If


    End Sub


    Sub verresultados()
        DataGridView1.Rows.Add(academia(comienzo1, 0), academia(comienzo1, 1), academia(comienzo1, 2), academia(comienzo1, 3), academia(comienzo1, 4), academia(comienzo1, 5), academia(comienzo1, 6), academia(comienzo1, 7), academia(comienzo1, 8), academia(comienzo1, 9), academia(comienzo1, 10))
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Call limpiar_entradas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()

    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        Call limpiar_matriz()
    End Sub

    Private Sub txthoras_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txthoras.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcarnet_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcarnet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
