Imports System.Math
Module Module1
    Public indice As Byte = 0
    Public empeño(6, 11) As String
    Public list As Byte
    Public list1 As Double

    Public Const corto_tv = 250
    Public Const corto_telefono = 550
    Public Const corto_laptop = 770
    Public Const corto_refri = 1000

    Public Const largo_tv = 300
    Public Const largo_telefono = 600
    Public Const largo_laptop = 800
    Public Const largo_refri = 1200

    Public nombre(6) As String
    Public cui(6) As Integer
    Public costo(6) As Double
    Public tipoplazo(6) As String
    Public descuentototal(6) As Double
    Public total(6) As Double
    Public parcial(6) As Double
    Public tv(6) As Double


    Sub limpiar_entradas()
        
        Form1.ComboBox1.SelectedIndex = -1
        Form1.cbtv.Checked = 0
        Form1.cbtel.Checked = 0
        Form1.cbrefri.Checked = 0
        Form1.cblaptop.Checked = 0

        Form1.txtnombre.Clear()
        Form1.txtcui.Clear()
        Form1.txtcosto.Clear()
        Form1.ComboBox1.Focus()

    End Sub

    Sub limpiar_matriz()

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        indice = 0

    End Sub

    Sub salir()
        If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            limpiar_matriz()
        End If
    End Sub

    'Si la TV y Refrigeradora, fueron empeñados a CORTO plazo hay un 15% de descuento sobre
    'el parcial a pagar y si fueron a LARGO solo hay 5% de descuento..

    Sub cortoplazo()
        If (Form1.cbtv.Checked) Or (Form1.cbrefri.Checked) Then
            If Form1.cbtv.Checked Then
                descuentototal(indice) = Val(Form1.txtcosto) * 0.15
                empeño(indice, 5) = Form1.ListBox6.Items.Add(parcial(indice))

            
            End If
            If Form1.cbrefri.Checked Then
                descuentototal(indice) = Val(Form1.txtcosto) * 0.15
                empeño(indice, 5) = Form1.ListBox6.Items.Add(parcial(indice))



            End If
        End If

    End Sub

    Sub largoplazo()
        'Si el TELEFONO y la LAPTOP fueron empeñados a LARGO plazo hay un 10% de descuento
        'sobre el parcial si no solo un 5%.
    End Sub
  

End Module
