Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Me.Close()

        Else
            limpiar()


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rbsmall.Checked = False And rbmedium.Checked = False And rblarge.Checked = False Then
            MsgBox("Usted no seleccionó el tamaño")

        End If

        If rbalgodon.Checked = False And rbseda.Checked = False AndAlso rblona.Checked = False Then
            MsgBox("No seleccionó el material")

        End If

        If txt_cantidad.Text = "" Then
            MsgBox("Ingrese la cantidad de chumpas")
        End If


        If (rbsmall.Checked) Then

            If (rbsmall.Checked) And (rbalgodon.Checked) Then
                costo = manosmall + materialalgodon * yarda1
                resultar()

            ElseIf (rbsmall.Checked) And (rbseda.Checked) Then
                costo = manodeobra() + materialtipo() * yarda1
                resultar()

            ElseIf (rbsmall.Checked) And (rblona.Checked) Then
                costo = manodeobra() + materialtipo() * yarda1
                resultar()

            Else
                costo = 0

            End If
        End If


        If (rbmedium.Checked) Then

            If (rbmedium.Checked) And (rbalgodon.Checked) Then
                costo = manodeobra() + materialtipo() * yarda2
                resultar()
            ElseIf (rbmedium.Checked) And (rbseda.Checked) Then
                costo = manodeobra() + materialtipo() * yarda2
                resultar()
            ElseIf (rbmedium.Checked) And (rblona.Checked) Then
                costo = manodeobra() + materialtipo() * yarda2
                resultar()
            Else
                costo = 0

            End If
        End If

        If (rblarge.Checked) Then

            If (rblarge.Checked) And (rbalgodon.Checked) Then
                costo = manodeobra() + materialtipo() * yarda3
                resultar()
            ElseIf (rblarge.Checked) And (rbseda.Checked) Then
                costo = manodeobra() + materialtipo() * yarda3
                resultar()
            ElseIf (rblarge.Checked) And (rblona.Checked) Then
                costo = manodeobra() + materialtipo() * yarda3
                resultar()
            Else
                costo = 0

            End If
        End If








        'costo total'
        If (rbsmall.Checked) Then

            If (rbsmall.Checked) And (rbalgodon.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda1) * Val(txt_cantidad.Text)
                resultar()

            ElseIf (rbsmall.Checked) And (rbseda.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda1) * Val(txt_cantidad.Text)
                resultar()

            ElseIf (rbsmall.Checked) And (rblona.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda1) * Val(txt_cantidad.Text)
                resultar()

            Else
                costototales = 0

            End If
        End If



        If (rbmedium.Checked) Then

            If (rbmedium.Checked) And (rbalgodon.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda2) * Val(txt_cantidad.Text)
                resultar()
            ElseIf (rbmedium.Checked) And (rbseda.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda2) * Val(txt_cantidad.Text)
                resultar()
            ElseIf (rbmedium.Checked) And (rblona.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda2) * Val(txt_cantidad.Text)
                resultar()
            Else
                costototales = 0

            End If
        End If


        If (rblarge.Checked) Then

            If (rblarge.Checked) And (rbalgodon.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda3) * Val(txt_cantidad.Text)
                resultar()
            ElseIf (rblarge.Checked) And (rbseda.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda3) * Val(txt_cantidad.Text)
                resultar()
            ElseIf (rblarge.Checked) And (rblona.Checked) Then
                costototales = (manodeobra() + materialtipo() * yarda3) * Val(txt_cantidad.Text)
                resultar()
            Else
                costototales = 0

            End If

        End If










        'ventas unitarias'
        If (rbsmall.Checked) Then

            If (rbsmall.Checked) And (rbalgodon.Checked) Then
                venta = costo + costo * 0.65

                resultar()

            ElseIf (rbsmall.Checked) And (rbseda.Checked) Then
                venta = costo + costo * 0.65
                resultar()
            ElseIf (rbsmall.Checked) And (rblona.Checked) Then
                venta = costo + costo * 0.65
                resultar()
            Else
                venta = 0

            End If
        End If



        If (rbmedium.Checked) Then
            If (rbmedium.Checked) And (rbalgodon.Checked) Then
                venta = costo + costo * 0.65
                resultar()

            ElseIf (rbmedium.Checked) And (rbseda.Checked) Then
                venta = costo + costo * 0.65
                resultar()
            ElseIf (rbmedium.Checked) And (rblona.Checked) Then
                venta = costo + costo * 0.65
                resultar()
            Else
                venta = 0

            End If
        End If


        If (rblarge.Checked) Then
            If (rblarge.Checked) And (rbalgodon.Checked) Then
                venta = costo + costo * 0.65
                resultar()

            ElseIf (rblarge.Checked) And (rbseda.Checked) Then
                venta = costo + costo * 0.65
                resultar()
            ElseIf (rblarge.Checked) And (rblona.Checked) Then
                venta = costo + costo * 0.65
                resultar()
            Else
                venta = 0

            End If
        End If












    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged

    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
