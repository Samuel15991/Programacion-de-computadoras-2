Imports System.Math

Module Module1

    Public Const manosmall = 65.5
    Public Const manomedium = 85.99
    Public Const manolarge = 99.99
    Public Const materialalgodon = 15
    Public Const materialseda = 23.99
    Public Const materiallona = 30.99
    Public cantidad As Integer
    Public costo As Double
    Public venta As Double
    Public yarda1 = 2
    Public yarda2 = 2.5
    Public yarda3 = 3
    Public costototales As Double




    Sub limpiar()
        Form1.rbsmall.Checked = False
        Form1.rbmedium.Checked = False
        Form1.rblarge.Checked = False
        Form1.rbalgodon.Checked = False
        Form1.rbseda.Checked = False
        Form1.rblona.Checked = False
        Form1.txt_cantidad.Clear()
        Form1.txt_costo.Clear()
        Form1.txt_venta.Clear()
        Form1.txt_costototal.Clear()

    End Sub

    'mano de obra'
    Function manodeobra() As Double
        If (Form1.rbsmall.Checked) Then
            manodeobra = manosmall
            Return manodeobra

        ElseIf (Form1.rbmedium.Checked) Then
            manodeobra = manomedium
            Return manodeobra
        ElseIf (Form1.rblarge.Checked) Then
            manodeobra = manolarge
            Return manodeobra

        Else
            MsgBox("No seleccionó el tamaño de la chumpa")
            Return 0

        End If


    End Function

    'tipo de material'
    Function materialtipo() As Double
        If (Form1.rbalgodon.Checked) Then
            materialtipo = materialalgodon
            Return materialtipo

        ElseIf (Form1.rbseda.Checked) Then
            materialtipo = materialseda
            Return materialtipo
        ElseIf (Form1.rblona.Checked) Then
            materialtipo = materiallona
            Return materialtipo
        Else
            MsgBox("No seleccionó el material de la chumpa")
            Return 0


        End If
    End Function


    'mostrar resultados de los costos y ventas'

    Sub resultar()
        Form1.txt_costo.Text = Str(Round(costo, 2))
        Form1.txt_venta.Text = Str(Round(venta, 2))
        Form1.txt_costototal.Text = Str(Round(costototales, 2))



    End Sub


End Module
