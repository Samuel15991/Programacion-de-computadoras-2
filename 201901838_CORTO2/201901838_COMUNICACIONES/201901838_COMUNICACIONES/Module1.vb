Imports System.Math
Module Module1
    Public iniciar As Byte = 0
    Public Const ptablet = 375
    Public Const pdrone = 560
    Public Const pcelular = 1450
    Public Const ptv = 3250
    Public Const vcomision = 0.055
    Public comision(7) As Double
    Public Nombre(7) As String
    Public Bruto(7) As Double
    Public articulo(7) As String
    Public parcial(7) As Double
    Public sueldo(7) As Double
    Public sueldoneto(6) As Double
    Public bono(6) As Double

    Sub salir()
        If (MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        
        End If
    End Sub
    Sub calcular()

        If (iniciar <= 7) Then

            If (Form1.txtnombre.Text <> "") And (Form1.txtbruto.Text <> "") Then
                Nombre(iniciar) = Form1.txtnombre.Text

                Bruto(iniciar) = Form1.txtbruto.Text

            Else
                MsgBox("No ingresó los datos")
                Form1.txtnombre.Focus()
                Exit Sub
            End If

            If (IsNumeric(Form1.txtbruto.Text) And Val(Form1.txtbruto.Text) > 0) Then

                sueldo(iniciar) = Val(Form1.txtbruto.Text)
            Else
                MsgBox("Error, dato del sueldo bruto no válido")
                Form1.txtbruto.Focus() : Exit Sub
            End If
            

            Select Case (Form1.ComboBox1.SelectedIndex)
                Case 0 : articulo(iniciar) = Round(comision(iniciar) * vcomision, 2)
                Case 1 : articulo(iniciar) = Round(comision(iniciar) * vcomision, 2)
                Case 2 : articulo(iniciar) = Round(comision(iniciar) * vcomision, 2)
                Case 3 : articulo(iniciar) = Round(comision(iniciar) * vcomision, 2)
                Case Else
                    MsgBox("Error, no seleccionó tipo de articulo")
                    Form1.ComboBox1.Focus() : Exit Sub
            End Select

            articulo(iniciar) = Form1.ComboBox1.Text
            sueldoneto(iniciar) = sueldo(iniciar) + comision(iniciar) + bono(iniciar)
           


            iniciar = iniciar + 1

            
            If (iniciar = 7) Then
                MsgBox("Vectores llenos")
            End If
        End If


         Sub limpiar_entradas()
        Form1.txtnombre.Clear()
        Form1.txtbruto.Clear()
        

        Form1.ComboBox1.SelectedIndex = -1
        
    End Sub






End Module
