Imports System.Math
Module Module1
    'Se harán 6 reservaciones.
    Public iniciar As Byte = 0
    Public I As Byte

    Public Const sencilla1 = 400
    Public Const sencilla2 = 375
    Public Const doble1 = 700
    Public Const doble2 = 600
    Public Const compartida1 = 350
    Public Const compartida2 = 300


    Public nit(6) As Integer
    Public nombre(6) As String
    Public cabina(6) As String
    Public clase(6) As String
    Public numero(6) As Integer
    Public precio(6) As Double
    Public pagofinal(6) As Double





    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()

        End If
    End Sub


    Sub limpiar_entradas()
        Form1.txtnit.Clear()
        Form1.ComboBox1.Text = ""
        Form1.rbclase1.Checked = 0
        Form1.rbclase2.Checked = 0
        Form1.txtcliente.Clear()
        Form1.txtnumero.Clear()
        Form1.txtbusqueda.Clear()

        Form1.txtnit.Focus()
    End Sub


    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 5

            If (nit(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Round(nit(I), 2)), nombre(I), cabina(I), clase(I), (Str(Round(numero(I), 2))), (Str(Round(precio(I), 2))), (Str(Round(pagofinal(I), 2))))
            Else

                Exit For
            End If
        Next I

    End Sub



    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        iniciar = 0

        For I = 0 To 5

            nit(I) = Nothing
            nombre(I) = Nothing
            cabina(I) = Nothing
            clase(I) = Nothing
            numero(I) = Nothing
            precio(I) = Nothing
            pagofinal(I) = Nothing

            limpiar_entradas()
        Next I



    End Sub




    Sub cab1()

        If (Form1.rbclase1.Checked) Or (Form1.rbclase2.Checked) Then

            If Form1.rbclase1.Checked Then
                precio(iniciar) = sencilla1
                pagofinal(iniciar) = precio(iniciar) * Val(Form1.txtnumero.Text)
                clase(iniciar) = Form1.rbclase1.Text

            Else

            End If


            If Form1.rbclase2.Checked Then
                precio(iniciar) = sencilla2
                pagofinal(iniciar) = precio(iniciar) * Val(Form1.txtnumero.Text)
                clase(iniciar) = Form1.rbclase2.Text
            Else

            End If



        Else

            Exit Sub
        End If
    End Sub


    Sub cab2()

        If (Form1.rbclase1.Checked) Or (Form1.rbclase2.Checked) Then

            If Form1.rbclase1.Checked Then
                precio(iniciar) = doble1
                pagofinal(iniciar) = precio(iniciar) * Val(Form1.txtnumero.Text)
                clase(iniciar) = Form1.rbclase1.Text
            Else

            End If


            If Form1.rbclase2.Checked Then
                precio(iniciar) = doble2
                pagofinal(iniciar) = precio(iniciar) * Val(Form1.txtnumero.Text)
                clase(iniciar) = Form1.rbclase2.Text
            Else

            End If



        Else

            Exit Sub
        End If
    End Sub



    Sub cab3()

        If (Form1.rbclase1.Checked) Or (Form1.rbclase2.Checked) Then

            If Form1.rbclase1.Checked Then
                precio(iniciar) = compartida1
                pagofinal(iniciar) = precio(iniciar) * Val(Form1.txtnumero.Text)
                clase(iniciar) = Form1.rbclase1.Text
            Else

            End If


            If Form1.rbclase2.Checked Then
                precio(iniciar) = compartida2
                pagofinal(iniciar) = precio(iniciar) * Val(Form1.txtnumero.Text)
                clase(iniciar) = Form1.rbclase2.Text
            Else

            End If



        Else

            Exit Sub
        End If
    End Sub







End Module
