Imports System.Math
Module Module1
    '7 cientes.
    Public iniciar As Byte = 0
    Public I As Byte


    Public Nombre(7) As String
    Public Nit(7) As Integer
    Public dias(7) As Integer
    Public habitacion(7) As String
    Public pago(7) As String
    Public impuesto(7) As Double
    Public total(7) As Double
    Public parcial(7) As Double

    Public Const hsencilla = 250
    Public Const hdoble = 400
    Public Const hcabaña = 650

    Public habisencilla(7) As String
    Public habidoble(7) As String
    Public habicabaña(7) As String



    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6

            If (Nombre(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add((Nombre(I)), Nit(I), Str(dias(I)), (habitacion(I)), Str(pago(I)), Str(impuesto(I)), Str(total(I)))
            Else

                Exit For
            End If
        Next I

    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        iniciar = 0

        For I = 0 To 6

            Nombre(iniciar) = Nothing
            Nit(iniciar) = Nothing
            dias(iniciar) = Nothing
            habitacion(iniciar) = Nothing
            pago(iniciar) = Nothing
            impuesto(iniciar) = Nothing
            total(iniciar) = Nothing

        Next I

    End Sub



    Sub sencilla()

        habisencilla(iniciar) = hsencilla

        parcial(iniciar) = (habisencilla(iniciar) * Val(Form1.txtdias.Text))

    End Sub

    Sub doble()

        habidoble(iniciar) = hdoble

        parcial(iniciar) = (habidoble(iniciar) * Val(Form1.txtdias.Text))

    End Sub

    Sub cabaña()

        habicabaña(iniciar) = hcabaña

        parcial(iniciar) = (habicabaña(iniciar) * Val(Form1.txtdias.Text))

    End Sub



    Function descuentos() As Double

        Si el pago es en efectivo 15% de descuento sobre el resultado del inciso 3,
        If (Form1.rbefectivo.Checked) Then
            tipopago(iniciar) = Form1.rbefectivo.Text
            descuentototal = parcial(iniciar) * 0.15
            Return descuentototal * -1

        ElseIf (Form1.rbcheque.Checked) Then
            tipopago(iniciar) = Form1.rbcheque.Text
            descuentototal = parcial(iniciar) * 0.15
            Return descuentototal * -1

            'si es hecho con tarjeta de débito el 8%
        ElseIf (Form1.rbdebito.Checked) Then
            tipopago(iniciar) = Form1.rbdebito.Text
            descuentototal = parcial(iniciar) * 0.08
            Return descuentototal * -1

            'si es realizado con tarjeta de crédito es recargo de 5%.
        ElseIf (Form1.rbcredito.Checked) Then
            tipopago(iniciar) = Form1.rbcredito.Text
            recargototal = parcial(iniciar) * 0.05
            Return recargototal
        End If



    End Function


End Module
