Imports System.Math
Module Module1
    Public iniciar As Byte = 0
    Public I As Byte


    Public etapa(12) As Integer
    Public equipo(12) As String
    Public km(12) As Double
    Public tiempo(12) As Integer
    Public nacionalidad(12) As String
    Public penalidad(12) As Double

    Sub limpiar_entradas()
        Form1.txtetapa.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.txtkm.Clear()
        Form1.txtminutos.Clear()
        Form1.txtbusqueda.Clear()

        Form1.txtetapa.Focus()
    End Sub


    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        iniciar = 0

        For I = 0 To 11

            etapa(I) = Nothing
            equipo(I) = Nothing
            km(I) = Nothing
            tiempo(I) = Nothing
            nacionalidad(I) = Nothing
            penalidad(I) = Nothing

        Next I
        limpiar_entradas()

    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()

        End If
    End Sub




    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11

            If (etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(etapa(I)), equipo(I), Str(km(I)), Str(tiempo(I)), (nacionalidad(I)), Str(penalidad(I)))
            Else

                Exit For
            End If
        Next I

    End Sub







    Sub sky()

        'una penalización de tiempo para el corredor que haya realizado más de 120 minutos se
        'penaliza con + 30 minutos,
        If (Form1.txtminutos.Text >= 120) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 30

        Else
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar)


        End If
        'más de 140 minutos se penaliza con +40 minutos,
        If (Form1.txtminutos.Text >= 140) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 40
        Else

        End If

        'más de 160 minutos se penaliza con +50

        If (Form1.txtminutos.Text >= 160) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 50
        Else

        End If

    End Sub



    Sub movistar()

        'una penalización de tiempo para el corredor que haya realizado más de 120 minutos se
        'penaliza con + 30 minutos,
        If (Form1.txtminutos.Text >= 120) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 30

        Else
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar)

        End If
        'más de 140 minutos se penaliza con +40 minutos,
        If (Form1.txtminutos.Text >= 140) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 40
        Else

        End If

        'más de 160 minutos se penaliza con +50

        If (Form1.txtminutos.Text >= 160) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 50
        Else

        End If

        'minutos.Si llego antes de los 85 minutos y es del equipo Movistar reducir su tiempo en 15 minutos
        If (Form1.txtminutos.Text <= 85) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) - 15
        Else
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar)

        End If

    End Sub




    Sub prociclyng()
        If (Form1.txtminutos.Text >= 120) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 30

        Else

        End If
        'más de 140 minutos se penaliza con +40 minutos,
        If (Form1.txtminutos.Text >= 140) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 40
        Else

        End If

        'más de 160 minutos se penaliza con +50

        If (Form1.txtminutos.Text >= 160) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 50
        Else

        End If

    End Sub


    'si es del equipo Pro Team reducir su tiempo en 10 minutos.
    Sub proteam()

        'una penalización de tiempo para el corredor que haya realizado más de 120 minutos se
        'penaliza con + 30 minutos,
        If (Form1.txtminutos.Text >= 120) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 30
        Else
        End If
        'más de 140 minutos se penaliza con +40 minutos,
        If (Form1.txtminutos.Text >= 140) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 40
        Else
        End If

        'más de 160 minutos se penaliza con +50

        If (Form1.txtminutos.Text >= 160) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) + 50
        Else
        End If

        'minutos.Si llego antes de los 85 minutos y es del equipo Movistar reducir su tiempo en 10 minutos

        If (Form1.txtminutos.Text <= 85) Then
            tiempo(iniciar) = tiempo(iniciar)
            penalidad(iniciar) = tiempo(iniciar) - 10
        Else


        End If




    End Sub






End Module
