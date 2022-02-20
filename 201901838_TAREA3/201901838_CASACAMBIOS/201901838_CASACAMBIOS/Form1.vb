Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, cbcompra.CheckedChanged
        If cbcompra.Checked = True Then
            txt_compra.Enabled = True
        Else
            txt_compra.Enabled = False
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, cbventa.CheckedChanged
        If cbventa.Checked = True Then
            txt_venta.Enabled = True
        Else
            txt_venta.Enabled = False
        End If

    End Sub
    'boton calcular'
    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click



        If ((cbcompra.Checked) Or (cbventa.Checked)) Then

            If (cbcompra.Checked) Then

                If (IsNumeric(txt_compra.Text) And Val(txt_compra.Text) > 0) Then
                    compra = Val(txt_compra.Text)
                Else
                    MsgBox("Ingresó un valor erroneo")
                    txt_compra.Focus()

                    Exit Sub
                End If
            Else
                compra = 0
            End If





            If (cbventa.Checked) Then
                    If (IsNumeric(txt_venta.Text) And Val(txt_venta.Text) > 0) Then
                        venta = Val(txt_venta.Text)
                    Else
                        MsgBox("Ingresó un valor erroneo")
                        txt_venta.Focus()
                        Exit Sub
                    End If
                Else
                    venta = 0
                End If
            End If




        If (cbcompra.Checked) Then
            If (cbcompra.Checked) And (rcodo.Checked) Then

                c1 = compra / cambioDolar
                c2 = c1 * comision1
                c3 = c1 + c2
                resultados()



            ElseIf (cbcompra.Checked) And (rcope.Checked) Then

                c1 = compra / cambioPeso
                c2 = c1 * comision1
                c3 = c1 + c2
                resultados()


            ElseIf (cbcompra.Checked) And (rcoeu.Checked) Then

                c1 = compra / cambioEuro
                c2 = c1 * comision1
                c3 = c1 + c2 : resultados()


            ElseIf (cbcompra.Checked) And (rcoco.Checked) Then

                c1 = compra / cambioColon
                c2 = c1 * comision1
                c3 = c1 + c2
                resultados()

            Else

                MsgBox("No selecciono ninguna moneda")
                Exit Sub
            End If
            Me.Hide()
            Form2.Show()
        End If





        If (cbventa.Checked) Then
            If (cbventa.Checked) And (rvedo.Checked) Then

                v1 = venta * cambioDolar
                v2 = v1 * comision2
                v3 = v1 + v2
                resultados()

            ElseIf (cbventa.Checked) And (rvepe.Checked) Then

                v1 = venta * cambioPeso
                v2 = v1 * comision2
                v3 = v1 + v2
                resultados()


            ElseIf (cbventa.Checked) And (rveeu.Checked) Then

                v1 = venta * cambioEuro
                v2 = v1 * comision2
                v3 = v1 + v2
            ElseIf (cbventa.Checked) And (rveco.Checked) Then

                v1 = venta * cambioColon
                v2 = v1 * comision2
                v3 = v1 + v2
                resultados()

            Else

                MsgBox("No selecciono ninguna moneda")
                Exit Sub
            End If

            Me.Hide()
            Form2.Show()
        End If



    End Sub
    'boton limpiar'
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()

    End Sub
    'boton salir'
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            limpiar()

        End If
    End Sub
End Class
