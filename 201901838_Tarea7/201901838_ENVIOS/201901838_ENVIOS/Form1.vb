Imports System.Math
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totallociones As Double = 0
        Dim totalplastico As Integer = 0
        Dim totaldocumentos As Double = 0
        Dim totalropa As Integer = 0
        Dim totalpaquetes As Double = 0
        Dim i As Byte


        For i = 0 To 9
            If (combo(i) = "Ropa") Then
                totalropa = totalropa + 1
            Else
                Exit For
            End If
        Next i
        txte1.Text = (Str(totallociones))
        txte2.Text = (Str(totalplastico))
        txte3.Text = (Str(totaldocumentos))
        txte4.Text = (Str(totalropa))



        For i = 0 To 9
            If (combo(i) = "Artículos de plástico") Then
                totalplastico = totalplastico + 1
            Else
                Exit For
            End If
        Next i
        txte1.Text = (Str(totallociones))
        txte2.Text = (Str(totalplastico))
        txte3.Text = (Str(totaldocumentos))
        txte4.Text = (Str(totalropa))


        For i = 0 To 9
            If (combo(i) = "Lociones") Then
                totallociones = totallociones + Val(pagototal(i))
            Else
                Exit For
            End If
        Next i
        txte1.Text = (Str(totallociones))
        txte2.Text = (Str(totalplastico))
        txte3.Text = (Str(totaldocumentos))
        txte4.Text = (Str(totalropa))


        For i = 0 To 9
            If (combo(i) = "Documentos") Then
                totaldocumentos = totaldocumentos + Val(pagototal(i))
            Else
                Exit For
            End If
        Next i
        txte1.Text = (Str(totallociones))
        txte2.Text = (Str(totalplastico))
        txte3.Text = (Str(totaldocumentos))
        txte4.Text = (Str(totalropa))







        '+1 contar

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If (iniciar <= 9) Then
            If (txtnombre.Text <> "") And (txtpeso.Text <> "") And (txtvalor.Text <> "") Then
                Nombre(iniciar) = txtnombre.Text
                peso(iniciar) = txtpeso.Text
                valor(iniciar) = txtvalor.Text


            Else
                MsgBox("No ingresó los datos")
                txtnombre.Focus()
                Exit Sub
            End If
        End If

        If (ComboBox1.SelectedIndex > -1) Then
            combo(iniciar) = ComboBox1.Text
        Else
            MsgBox("No seleccionó el tipo de paquete")
            ComboBox1.Focus()
            Exit Sub
        End If


        envios(iniciar) = 0
        Select Case (ComboBox1.SelectedIndex)
            Case 0 : Documentos()
            Case 1 : ropa()
            Case 2 : pedecederos()
            Case 3 : plastico1()
            Case 4 : lociones()



        End Select


        If (rbcamion.Checked) Then
            forma(iniciar) = rbcamion.Text
            'resultados()
            iniciar = iniciar + 1

        ElseIf (rbmoto.Checked) Then
            forma(iniciar) = rbmoto.Text
            'resultados()
            iniciar = iniciar + 1
        Else
            MsgBox("No seleccionó la forma de envío ")
            Exit Sub


        End If

        If (iniciar = 10) Then
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub MostrarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarVectoresToolStripMenuItem.Click
        mostrar()


    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiarvectores()
        iniciar = 0


    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiarentradas()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txte1.Clear()
        txte2.Clear()
        txte3.Clear()
        txte4.Clear()

    End Sub

    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
