Imports System.Math
Module Module1
    Public iniciar As Byte = 0
    Public I As Byte
    Public Const base1 = 500
    Public Const base2 = 400
    Public Const base3 = 300
    Public Const base4 = 200


    Public placa(7) As Integer
    Public tipoauto(7) As String
    Public cobrobase(7) As Integer
    Public kinicial(7) As Double
    Public kfinal(7) As Double
    Public pagofinal(7) As Double

    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6

            If (placa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(placa(I)), tipoauto(I), Str(cobrobase(I)), Str(kinicial(I)), Str(kfinal(I)), Str(pagofinal(I)))
            Else

                Exit For
            End If
        Next I

    End Sub


    Sub limpiar_entradas()
        Form1.txtplaca.Clear()
        Form1.ComboBox1.Text = ""
        Form1.txtkf.Clear()
        Form1.txtki.Clear()
        Form1.txtbusqueda.Clear()

        Form1.txtplaca.Focus()
    End Sub



    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        iniciar = 0

        For I = 0 To 6

            placa(I) = Nothing
            tipoauto(I) = Nothing
            cobrobase(I) = Nothing
            kinicial(I) = Nothing
            kfinal(I) = Nothing
            pagofinal(I) = Nothing

        Next I

    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()

        End If
    End Sub





    Sub tipo1()
        'Si el carro recorre entre 0-50 kms se cobra Q3 por km recorrido,
        'Por el tipo 1 se cobran Q500 como base,


        If (Form1.txtki.Text > 0) And (Form1.txtkf.Text <= 50) Then
            cobrobase(iniciar) = base1
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 3
        Else

        End If

        If (Form1.txtki.Text >= 51) And (Form1.txtkf.Text <= 70) Then
            cobrobase(iniciar) = base1
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 4
        Else

        End If


        'si son más de 70 kms, se cobra Q5 por km recorrido.
        If (Form1.txtki.Text > 70) Then
            cobrobase(iniciar) = base1
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 5
        Else

        End If

    End Sub






    Sub tipo2()
        'Si el carro recorre entre 0-50 kms se cobra Q3 por km recorrido,
        'Por el tipo 1 se cobran Q500 como base,


        If (Form1.txtki.Text > 0) And (Form1.txtkf.Text <= 50) Then
            cobrobase(iniciar) = base2
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 3
        Else

        End If

        If (Form1.txtki.Text >= 51) And (Form1.txtkf.Text <= 70) Then
            cobrobase(iniciar) = base2
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 4
        Else

        End If


        'si son más de 70 kms, se cobra Q5 por km recorrido.
        If (Form1.txtki.Text > 70) Then
            cobrobase(iniciar) = base2
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 5
        Else

        End If

    End Sub


    Sub tipo3()
        'Si el carro recorre entre 0-50 kms se cobra Q3 por km recorrido,
        'Por el tipo 1 se cobran Q500 como base,


        If (Form1.txtki.Text > 0) And (Form1.txtkf.Text <= 50) Then
            cobrobase(iniciar) = base3
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 3
        Else

        End If

        If (Form1.txtki.Text >= 51) And (Form1.txtkf.Text <= 70) Then
            cobrobase(iniciar) = base3
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 4
        Else

        End If


        'si son más de 70 kms, se cobra Q5 por km recorrido.
        If (Form1.txtki.Text > 70) Then
            cobrobase(iniciar) = base3
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 5
        Else

        End If

    End Sub



    Sub tipo4()
        'Si el carro recorre entre 0-50 kms se cobra Q3 por km recorrido,
        'Por el tipo 1 se cobran Q500 como base,


        If (Form1.txtki.Text > 0) And (Form1.txtkf.Text <= 50) Then
            cobrobase(iniciar) = base4
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 3
        Else

        End If

        If (Form1.txtki.Text >= 51) And (Form1.txtkf.Text <= 70) Then
            cobrobase(iniciar) = base4
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 4
        Else

        End If


        'si son más de 70 kms, se cobra Q5 por km recorrido.
        If (Form1.txtki.Text > 70) Then
            cobrobase(iniciar) = base4
            pagofinal(iniciar) = cobrobase(iniciar) + (Val(Form1.txtkf.Text) - Val(Form1.txtki.Text)) * 5
        Else

        End If

    End Sub














End Module
