Imports System.Math
Module Module1
    'vector
    Public comienzo As Byte = 0
    'matriz
    Public comienzo1 As Byte = 0
    Public Const h_ingles = 150
    Public Const h_frances = 125
    Public Const h_portugues = 80


    Public carnet(8) As Integer
    Public Nombre(8) As String
    Public fecha(8) As String
    Public horas(8) As Integer
    Public idioma(8) As String
    Public viernes(8) As String
    Public sabado(8) As String
    Public dias(8) As String
    Public tipopago(8) As String
    Public descuentototal As Double
    Public total(8) As Double
    Public parcial(8) As Double

    Public academia(8, 11) As String


        Sub limpiar_entradas()
            Form1.txtcarnet.Clear()
        Form1.txtnombre.Clear()
            Form1.txthoras.Clear()
            Form1.ComboBox1.SelectedIndex = -1
            Form1.cbviernes.Checked = 0
            Form1.cbsabado.Checked = 0
            Form1.rbefectivo.Checked = 0
            Form1.rbcheque.Checked = 0
            Form1.txtcarnet.Focus()
        End Sub

        Sub limpiar_matriz()

        Form1.DataGridView1.Rows.Clear()
        comienzo1 = 0
        End Sub



        Sub salir()
            If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
                End
            Else
                limpiar_entradas()
                limpiar_matriz()
            End If
        End Sub

End Module
