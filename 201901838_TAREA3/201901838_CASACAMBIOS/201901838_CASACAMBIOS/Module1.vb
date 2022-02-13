Imports System.Math
Module Module1

    Public Const cambioDolar = 7.69
    Public Const cambioPeso = 0.38
    Public Const cambioEuro = 8.79
    Public Const cambioColon = 0.0012
    Public Const comision1 = 2.5 / 100
    Public Const comision2 = 3 / 100
    Public totalcompra As Double
    Public totalventa As Double
    Public totalcomi1 As Double
    Public totalcomi2 As Double
    Public totalfinal1 As Double
    Public totalfinal2 As Double
    Public compra As Double
    Public venta As Double
    Public c1 As Double
    Public c2 As Double
    Public c3 As Double
    Public v1 As Double
    Public v2 As Double
    Public v3 As Double




    Sub limpiar()
        Form1.txt_compra.Clear()
        Form1.txt_venta.Clear()
        Form1.cbcompra.Checked = False
        Form1.cbventa.Checked = False
        Form1.rcodo.Checked = False
        Form1.rcope.Checked = False
        Form1.rcoeu.Checked = False
        Form1.rcoco.Checked = False
        'radioventas'
        Form1.rvedo.Checked = False
        Form1.rvepe.Checked = False
        Form1.rveeu.Checked = False
        Form1.rveco.Checked = False
        'formulario 2'
        Form2.txtco1.Clear()
        Form2.txtco2.Clear()
        Form2.txtco3.Clear()
        Form2.txtve1.Clear()
        Form2.txtve2.Clear()
        Form2.txtve3.Clear()
        Form1.txt_compra.Focus()




    End Sub


    Sub resultados()

        'darse cuenta que en cada instrucción se invoca el nombre de la clase a la que pertenece el objeto respectivo
        Form2.txtco1.Text = Str(Round(c1, 2))
        Form2.txtco2.Text = Str(Round(c2, 2))
        Form2.txtco3.Text = Str(Round(c3, 2))
        Form2.txtve1.Text = Str(Round(v1, 2))
        Form2.txtve2.Text = Str(Round(v2, 2))
        Form2.txtve3.Text = Str(Round(v3, 2))


    End Sub
End Module

