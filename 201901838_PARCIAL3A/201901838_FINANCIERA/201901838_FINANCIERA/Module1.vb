Imports System.Math
Module Module1

    Public iniciar As Byte = 0
    Public I As Byte
    Public Const quetzal = 255
    Public Const brava = 490
    Public Const mirador1 = 1190



    Public id(7) As Integer
    Public tipoviaje(7) As String
    Public cobrodia(7) As Integer
    Public dias(7) As Integer
    Public personas(7) As Integer
    Public pagofinal(7) As Double




    Sub tipo1()
        'Calcule el total a pagar según la tabla de precios, multiplicar el número de días por el precio respectivo por
        'la cantidad de personas. Guardar este dato en otro vector. 
        cobrodia(iniciar) = quetzal
        pagofinal(iniciar) = cobrodia(iniciar) * ((Val(Form1.txtnu.Text)) * (Val(Form1.txtpersonas.Text)))


    End Sub


    Sub tipo2()
        'Calcule el total a pagar según la tabla de precios, multiplicar el número de días por el precio respectivo por
        'la cantidad de personas. Guardar este dato en otro vector. 
        cobrodia(iniciar) = brava
        pagofinal(iniciar) = cobrodia(iniciar) * (Val(Form1.txtnu.Text)) * (Val(Form1.txtpersonas.Text))

    End Sub


    Sub tipo3()
        cobrodia(iniciar) = mirador1
        pagofinal(iniciar) = cobrodia(iniciar) * Val(Form1.txtnu.Text) * Val(Form1.txtpersonas.Text)


    End Sub


    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6

            If (id(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Round(id(I), 2)), tipoviaje(I), (Str(Round(dias(I), 2))), (Str(Round(personas(I), 2))), (Str(Round(cobrodia(I), 2))), (Str(Round(pagofinal(I), 2))))
            Else

                Exit For
            End If
        Next I

    End Sub


    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        iniciar = 0

        For I = 0 To 6

            id(I) = Nothing
            dias(I) = Nothing
            personas(I) = Nothing
            tipoviaje(I) = Nothing
            cobrodia(I) = Nothing
            pagofinal(I) = Nothing
            limpiar_entradas()
        Next I



    End Sub


    Sub limpiar_entradas()
        Form1.txtid.Clear()
        Form1.ComboBox1.Text = ""
        Form1.txtnu.Clear()
        Form1.txtpersonas.Clear()
        Form1.txtbuscar.Clear()

        Form1.txtid.Focus()
    End Sub

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()

        End If
    End Sub





End Module
