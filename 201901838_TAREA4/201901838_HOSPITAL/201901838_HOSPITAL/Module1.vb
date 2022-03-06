Imports System.Math
Module Module1

    Public iniciar As Byte = 0
    Public Const privada_enca = 350
    Public Const privada_operacion = 550
    Public Const privada_maternidad = 450

    Public Const semiprivada_enca = 250
    Public Const semiprivada_operacion = 400
    Public Const semiprivada_maternidad = 350

    Public Const noprivada_enca = 150
    Public Const noprivada_operacion = 300
    Public Const noprivada_maternidad = 250

    Public descuentototal As Double
    Public recargototal As Double
    Public Nombre(6) As String
    Public Nit(6) As Integer
    Public Dias(6) As Integer
    Public Honorarios(6) As Double
    Public Servicio(6) As String
    Public Habitacion(6) As String
    Public parcial(6) As Double
    Public descuento(6) As Double
    Public recargo(6) As Double
    Public total(6) As Double
    Public encamamiento(6) As Integer
    Public operacion(6) As Integer
    Public maternidad(6) As Integer
    Public tipopago(6) As String

    Sub salir()
        If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            limpiar_vectores()
        End If
    End Sub


    Sub limpiar_entradas()
        Form1.txtnombre.Clear()
        Form1.txtnit.Clear()
        Form1.txtdias.Clear()
        Form1.txthonorarios.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.cbenca.Checked = 0
        Form1.cbmater.Checked = 0
        Form1.cbope.Checked = 0
        Form1.rbefectivo.Checked = 0
        Form1.rbcheque.Checked = 0
        Form1.rbcredito.Checked = 0
        Form1.rbdebito.Checked = 0
        Form1.txtnombre.Focus()


    End Sub



    Sub limpiar_vectores()
        iniciar = 0
        Form1.DataGridView1.Rows.Clear()


    End Sub








    Sub privado()

        If (Form1.cbenca.Checked) Or (Form1.cbope.Checked) Or (Form1.cbmater.Checked) Then

            If Form1.cbenca.Checked Then
                encamamiento(iniciar) = privada_enca
            Else
                encamamiento(iniciar) = 0
            End If
            If Form1.cbope.Checked Then
                operacion(iniciar) = privada_operacion
            Else
                operacion(iniciar) = 0
            End If
            If Form1.cbmater.Checked Then
                maternidad(iniciar) = privada_maternidad
            Else
                maternidad(iniciar) = 0

            End If
            parcial(iniciar) = (encamamiento(iniciar) + operacion(iniciar) + maternidad(iniciar)) * Val(Form1.txtdias.Text)
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub


    Sub semiprivado()

        If (Form1.cbenca.Checked) Or (Form1.cbope.Checked) Or (Form1.cbmater.Checked) Then

            If Form1.cbenca.Checked Then
                encamamiento(iniciar) = semiprivada_enca
            Else
                encamamiento(iniciar) = 0
            End If
            If Form1.cbope.Checked Then
                operacion(iniciar) = semiprivada_operacion
            Else
                operacion(iniciar) = 0
            End If
            If Form1.cbmater.Checked Then
                maternidad(iniciar) = semiprivada_maternidad
            Else
                maternidad(iniciar) = 0

            End If
            parcial(iniciar) = (encamamiento(iniciar) + operacion(iniciar) + maternidad(iniciar)) * Val(Form1.txtdias.Text)
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub


   

    Sub noprivado()

        If (Form1.cbenca.Checked) Or (Form1.cbope.Checked) Or (Form1.cbmater.Checked) Then

            If Form1.cbenca.Checked Then
                encamamiento(iniciar) = noprivada_enca
            Else
                encamamiento(iniciar) = 0
            End If
            If Form1.cbope.Checked Then
                operacion(iniciar) = noprivada_operacion
            Else
                operacion(iniciar) = 0
            End If
            If Form1.cbmater.Checked Then
                maternidad(iniciar) = noprivada_maternidad
            Else
                maternidad(iniciar) = 0

            End If
        Else
            MsgBox("No seleccionó el tipo de servicio")
            Exit Sub
        End If
    End Sub





    Function descuento_recargo() As Double
        
        'Si el pago es en efectivo o cheque debe hacerse el 15% de descuento sobre el subtotal a pagar
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
      

    Function totalfinal() As Double
        'If Form1.rbefectivo.Checked Or Form1.rbdebito.Checked Or Form1.rbcheque.Checked Then
        totalfinal = parcial(iniciar) + descuento(iniciar) + recargo(iniciar)

        Return totalfinal
        'Else

        'totalfinal = parcial(iniciar) + recargo(iniciar)
        'Return totalfinal()
        'End If


    End Function



    Sub resultados()
        Form1.DataGridView1.Rows.Add(Nombre(iniciar), Nit(iniciar), Dias(iniciar), Honorarios(iniciar), Habitacion(iniciar), (Str(Round(encamamiento(iniciar), 2))), (Str(Round(operacion(iniciar), 2))), (Str(Round(maternidad(iniciar), 2))), tipopago(iniciar), (Str(Round(parcial(iniciar), 2))), (Str(Round(descuento(iniciar), 2))), (Str(Round(recargo(iniciar), 2))), (Str(Round(total(iniciar), 2))))

    End Sub
  

End Module
