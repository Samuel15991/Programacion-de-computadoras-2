Imports System.Math
Module Module1
    Public control As Byte = 0
    Public Const msofa = 250.99
    Public Const mindividual = 150.99
    Public Const mdoble = 200.99

    Public Const ycuero = 75
    Public Const ycuerina = 45.99

    Public Const yardasofa = 8
    Public Const yardaindividual = 3.5
    Public Const yardadoble = 6

    Public manoobra(8) As Double
    Public cantidad(8) As Integer
    Public sillones(8) As String
    Public precio(8) As Double
    Public costo(8) As Double
    Public venta(8) As Double
    Public tela1(8) As String
    Public tela2(8) As Double
    Public tela(8) As String
    Public yarda(8) As Double
    Public tamaño(8) As String



    Sub limpiar_entradas()
        Form1.txtcantidad.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.rbcuerina.Checked = 0
        Form1.rbcuero.Checked = 0
        Form1.txtcantidad.Focus()


    End Sub


    Sub limpiar_vectores()
        control = 0
        Form1.DataGridView1.Rows.Clear()


    End Sub

    Sub salir()
        If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            limpiar_vectores()
        End If
    End Sub



    Sub resultados()
        Form1.DataGridView1.Rows.Add(tamaño(control), tela(control), cantidad(control), (Str(Round(costo(control), 2))), (Str(Round(venta(control), 2))))
    End Sub


    Sub sofa()
        If Form1.rbcuero.Checked Or Form1.rbcuerina.Checked Then
          

            If Form1.rbcuero.Checked Then

                manoobra(control) = msofa
                tela(control) = ycuero
                yarda(control) = yardasofa
            Else
                manoobra(control) = msofa
                tela(control) = ycuerina
                yarda(control) = yardasofa
            End If
            costo(control) = (manoobra(control) + tela(control) * yarda(control)) * Val(Form1.txtcantidad.Text)
            venta(control) = costo(control) + costo(control) * 0.65
            If Form1.rbcuero.Checked Then

                tela(control) = Form1.rbcuero.Text
            Else

                tela(control) = Form1.rbcuerina.Text
            End If

            resultados()
            control = control + 1
        End If




    End Sub




    Sub individual()
        If Form1.rbcuero.Checked Or Form1.rbcuerina.Checked Then
            If Form1.rbcuero.Checked Then
                manoobra(control) = mindividual
                tela(control) = ycuero

                yarda(control) = yardaindividual
            Else
                manoobra(control) = mindividual
                tela(control) = ycuerina
                yarda(control) = yardaindividual

            End If
            costo(control) = (manoobra(control) + tela(control) * yarda(control)) * Val(Form1.txtcantidad.Text)
            venta(control) = costo(control) + costo(control) * 0.65
            If Form1.rbcuero.Checked Then

                tela(control) = Form1.rbcuero.Text
            Else

                tela(control) = Form1.rbcuerina.Text
            End If
            resultados()
            control = control + 1
        End If
    End Sub



    Sub doble()
        If Form1.rbcuero.Checked Or Form1.rbcuerina.Checked Then
            If Form1.rbcuero.Checked Then
                manoobra(control) = mdoble
                tela(control) = ycuero
                yarda(control) = yardadoble
            Else
                manoobra(control) = mdoble
                tela(control) = ycuerina
                yarda(control) = yardadoble
            End If
            costo(control) = (manoobra(control) + tela(control) * yarda(control)) * Val(Form1.txtcantidad.Text)
            venta(control) = costo(control) + costo(control) * 0.65
            If Form1.rbcuero.Checked Then

                tela(control) = Form1.rbcuero.Text
            Else

                tela(control) = Form1.rbcuerina.Text
            End If
            resultados()
            control = control + 1
        End If
    End Sub

   





End Module

