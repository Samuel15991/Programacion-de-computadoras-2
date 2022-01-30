Imports System.Math
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_titulo.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lbl_con_iva.Click

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim arroz As Integer
        Dim frijol As Integer
        Dim azucar As Integer
        Dim siva As Double
        Dim viva As Double
        Dim civa As Double
        Dim descuento As Double
        Dim total As Double

        Const a = 2
        Const f = 1.75
        Const az = 2.5

        arroz = txt_arroz.Text
        frijol = txt_frijol.Text
        azucar = txt_azucar.Text
        'calculo de precio sin iva
        siva = ((Val(arroz * a)) + (Val(frijol * f)) + (Val(azucar * az)))
        txt_siniva.Text = Str(Round(siva, 2))
        'calculo del iva 
        viva = ((arroz * a) + (frijol * f) + (azucar * az)) * 0.12
        txt_iva.Text = Str(Round(viva, 2))
        'calculo del precio con el iva
        civa = ((arroz * a) + (frijol * f) + (azucar * az)) + viva
        txt_coniva.Text = Str(Round(civa, 2))
        'descuento
        descuento = civa * 0.025
        txt_descuentos.Text = Str(Round(descuento, 2))
        'pago final 
        total = civa - descuento
        txt_total.Text = Str(Round(total, 2))
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("Que tenga un feliz dia")
        End

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_siniva.Clear()
        txt_coniva.Clear()
        txt_iva.Clear()
        txt_descuentos.Clear()
        txt_total.Clear()
        txt_arroz.Clear()
        txt_frijol.Clear()
        txt_azucar.Clear()
        txt_arroz.Focus()
    End Sub

    Private Sub txt_arroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_arroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_frijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_frijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_azucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_azucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbl_descuentos.Click

    End Sub
End Class
