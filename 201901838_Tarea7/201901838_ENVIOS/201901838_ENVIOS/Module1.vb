Imports System.Math
Module Module1
    Public iniciar As Byte = 0
    Public Const documentosporcentaje = 0.015
    Public Const ropaporcentaje = 6 / 100
    Public Const perecederosporcentaje = 5.5 / 100
    Public Const plasticoporcentaje = 4.5 / 100
    Public Const locionesporcentaje = 2 / 100

    Public Nombre(10) As String
    Public valor(10) As Double
    Public peso(10) As Double
    Public paquete(10) As String
    Public pagoparcial(10) As Double
    Public impuesto(10) As Double
    Public pagototal(10) As Double
    Public envios(10) As String
    Public forma(10) As String
    Public camion(10) As Integer
    Public moto(10) As Integer
    Public combo(10) As String



    Sub salir()
        If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiarentradas()
            limpiarvectores()
        End If
    End Sub




    Sub Documentos()

        If (Form1.rbcamion.Checked) Or (Form1.rbmoto.Checked) Then

            If Form1.rbcamion.Checked Then
                camion(iniciar) = 50
            Else
                camion(iniciar) = 0
            End If
            If Form1.rbmoto.Checked Then
                moto(iniciar) = 15
            Else
                moto(iniciar) = 0
            End If

            pagoparcial(iniciar) = (camion(iniciar) + moto(iniciar)) + Val(Form1.txtpeso.Text) * Val(Form1.txtvalor.Text)


            If Val(Form1.txtpeso.Text) > 0 And Val(Form1.txtpeso.Text) <= 5 Then
                impuesto(iniciar) = documentosporcentaje
                pagototal(iniciar) = pagoparcial(iniciar) + pagoparcial(iniciar) * documentosporcentaje

            Else
                pagototal(iniciar) = pagoparcial(iniciar)
            End If
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If

    End Sub


    Sub ropa()

        If (Form1.rbcamion.Checked) Or (Form1.rbmoto.Checked) Then

            If Form1.rbcamion.Checked Then
                camion(iniciar) = 50
            Else
                camion(iniciar) = 0
            End If
            If Form1.rbmoto.Checked Then
                moto(iniciar) = 15
            Else
                moto(iniciar) = 0
            End If

            pagoparcial(iniciar) = (camion(iniciar) + moto(iniciar)) + Val(Form1.txtpeso.Text) * Val(Form1.txtvalor.Text)
            If Val(Form1.txtpeso.Text) > 0 And Val(Form1.txtpeso.Text) <= 5 Then
                impuesto(iniciar) = ropaporcentaje
                pagototal(iniciar) = pagoparcial(iniciar) + pagoparcial(iniciar) * ropaporcentaje
            Else
                pagototal(iniciar) = pagoparcial(iniciar)
            End If
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub

    Sub pedecederos()

        If (Form1.rbcamion.Checked) Or (Form1.rbmoto.Checked) Then

            If Form1.rbcamion.Checked Then
                camion(iniciar) = 50
            Else
                camion(iniciar) = 0
            End If
            If Form1.rbmoto.Checked Then
                moto(iniciar) = 15
            Else
                moto(iniciar) = 0
            End If

            pagoparcial(iniciar) = (camion(iniciar) + moto(iniciar)) + Val(Form1.txtpeso.Text) * Val(Form1.txtvalor.Text)
            If Val(Form1.txtpeso.Text) > 0 And Val(Form1.txtpeso.Text) <= 5 Then
                impuesto(iniciar) = perecederosporcentaje
                pagototal(iniciar) = pagoparcial(iniciar) + pagoparcial(iniciar) * perecederosporcentaje
            Else
                pagototal(iniciar) = pagoparcial(iniciar)
            End If
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub


    Sub plastico1()

        If (Form1.rbcamion.Checked) Or (Form1.rbmoto.Checked) Then

            If Form1.rbcamion.Checked Then
                camion(iniciar) = 50
            Else
                camion(iniciar) = 0
            End If
            If Form1.rbmoto.Checked Then
                moto(iniciar) = 15
            Else
                moto(iniciar) = 0
            End If

            pagoparcial(iniciar) = (camion(iniciar) + moto(iniciar)) + Val(Form1.txtpeso.Text) * Val(Form1.txtvalor.Text)
            If Val(Form1.txtpeso.Text) > 0 And Val(Form1.txtpeso.Text) <= 5 Then
                impuesto(iniciar) = plasticoporcentaje
                pagototal(iniciar) = pagoparcial(iniciar) + pagoparcial(iniciar) * plasticoporcentaje
            Else
                pagototal(iniciar) = pagoparcial(iniciar)
            End If
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub


    Sub lociones()

        If (Form1.rbcamion.Checked) Or (Form1.rbmoto.Checked) Then

            If Form1.rbcamion.Checked Then
                camion(iniciar) = 50
            Else
                camion(iniciar) = 0
            End If
            If Form1.rbmoto.Checked Then
                moto(iniciar) = 15
            Else
                moto(iniciar) = 0
            End If

            pagoparcial(iniciar) = (camion(iniciar) + moto(iniciar)) + Val(Form1.txtpeso.Text) * Val(Form1.txtvalor.Text)
            If Val(Form1.txtpeso.Text) > 0 And Val(Form1.txtpeso.Text) <= 5 Then
                impuesto(iniciar) = locionesporcentaje
                pagototal(iniciar) = pagoparcial(iniciar) + pagoparcial(iniciar) * locionesporcentaje
            Else
                pagototal(iniciar) = pagoparcial(iniciar)
            End If
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub


    Sub resultados()
        Form1.ListBox1.Items.Add(Nombre(iniciar))
        Form1.ListBox2.Items.Add(valor(iniciar))
        Form1.ListBox3.Items.Add(peso(iniciar))
        Form1.ListBox4.Items.Add(combo(iniciar))
        Form1.ListBox5.Items.Add(forma(iniciar))
        Form1.ListBox6.Items.Add(impuesto(iniciar))
        'Form1.ListBox7.Items.Add(pagoparcial(iniciar))
        'Form1.ListBox8.Items.Add(pagototal(iniciar))




    End Sub

    Sub mostrar()
        Dim i As Byte
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()

        For i = 0 To 9
            If Nombre(i) <> Nothing Then
                Form1.ListBox1.Items.Add(Nombre(i))
            Else
                Exit For
            End If
        Next i

        For i = 0 To 9
            If valor(i) <> Nothing Then
                Form1.ListBox2.Items.Add(valor(i))
            Else
                Exit For
            End If
        Next i

        For i = 0 To 9
            If peso(i) <> Nothing Then
                Form1.ListBox3.Items.Add(peso(i))
            Else
                Exit For
            End If
        Next i




        For i = 0 To 9
            If combo(i) <> Nothing Then
                Form1.ListBox4.Items.Add(combo(i))
            Else
                Exit For
            End If
        Next i

        For i = 0 To 9
            If forma(i) <> Nothing Then
                Form1.ListBox5.Items.Add(forma(i))
            Else
                Exit For
            End If
        Next i


        For i = 0 To 9
            If impuesto(i) <> Nothing Then
                Form1.ListBox6.Items.Add(impuesto(i))
            Else
                Exit For
            End If
        Next i


        For i = 0 To 9
            If pagoparcial(i) <> Nothing Then
                Form1.ListBox7.Items.Add(pagoparcial(i))
            Else
                Exit For
            End If
        Next i

        For i = 0 To 9
            If pagototal(i) <> Nothing Then
                Form1.ListBox8.Items.Add(pagototal(i))
            Else
                Exit For
            End If
        Next i

    End Sub

    Sub limpiarvectores()


        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        iniciar = 0


    End Sub

    Sub limpiarentradas()
        Form1.txtnombre.Clear()
        Form1.txtvalor.Clear()
        Form1.txtvalor.Clear()
        Form1.txtpeso.Clear()

        Form1.ComboBox1.SelectedIndex = -1
        Form1.rbcamion.Checked = 0
        Form1.rbmoto.Checked = 0
        Form1.txtnombre.Focus()

    End Sub







End Module
