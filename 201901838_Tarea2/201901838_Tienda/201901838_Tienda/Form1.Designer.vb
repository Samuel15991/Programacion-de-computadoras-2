<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_azucar = New System.Windows.Forms.TextBox()
        Me.txt_frijol = New System.Windows.Forms.TextBox()
        Me.txt_arroz = New System.Windows.Forms.TextBox()
        Me.lbl_azucar = New System.Windows.Forms.Label()
        Me.lbl_frijol = New System.Windows.Forms.Label()
        Me.lbl_arroz = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_descuentos = New System.Windows.Forms.TextBox()
        Me.txt_coniva = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_siniva = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_descuentos = New System.Windows.Forms.Label()
        Me.lbl_con_iva = New System.Windows.Forms.Label()
        Me.lbl_iva = New System.Windows.Forms.Label()
        Me.lbl_sin_iva = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.White
        Me.lbl_titulo.Font = New System.Drawing.Font("ISOCPEUR", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(255, 22)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(164, 21)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Tienda ""La Bendición"""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_azucar)
        Me.GroupBox1.Controls.Add(Me.txt_frijol)
        Me.GroupBox1.Controls.Add(Me.txt_arroz)
        Me.GroupBox1.Controls.Add(Me.lbl_azucar)
        Me.GroupBox1.Controls.Add(Me.lbl_frijol)
        Me.GroupBox1.Controls.Add(Me.lbl_arroz)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 183)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCIONES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ingrese la cantidad de libras que desea comprar"
        '
        'txt_azucar
        '
        Me.txt_azucar.Location = New System.Drawing.Point(166, 114)
        Me.txt_azucar.Name = "txt_azucar"
        Me.txt_azucar.Size = New System.Drawing.Size(78, 20)
        Me.txt_azucar.TabIndex = 2
        Me.txt_azucar.Text = "0"
        '
        'txt_frijol
        '
        Me.txt_frijol.Location = New System.Drawing.Point(166, 85)
        Me.txt_frijol.Name = "txt_frijol"
        Me.txt_frijol.Size = New System.Drawing.Size(78, 20)
        Me.txt_frijol.TabIndex = 1
        Me.txt_frijol.Text = "0"
        '
        'txt_arroz
        '
        Me.txt_arroz.Location = New System.Drawing.Point(166, 58)
        Me.txt_arroz.Name = "txt_arroz"
        Me.txt_arroz.Size = New System.Drawing.Size(78, 20)
        Me.txt_arroz.TabIndex = 0
        Me.txt_arroz.Text = "0"
        '
        'lbl_azucar
        '
        Me.lbl_azucar.AutoSize = True
        Me.lbl_azucar.Location = New System.Drawing.Point(10, 117)
        Me.lbl_azucar.Name = "lbl_azucar"
        Me.lbl_azucar.Size = New System.Drawing.Size(115, 13)
        Me.lbl_azucar.TabIndex = 2
        Me.lbl_azucar.Text = "Libra de azúcar Q2.50 "
        '
        'lbl_frijol
        '
        Me.lbl_frijol.AutoSize = True
        Me.lbl_frijol.Location = New System.Drawing.Point(10, 92)
        Me.lbl_frijol.Name = "lbl_frijol"
        Me.lbl_frijol.Size = New System.Drawing.Size(101, 13)
        Me.lbl_frijol.TabIndex = 1
        Me.lbl_frijol.Text = "Libra de frijol Q1.75 "
        '
        'lbl_arroz
        '
        Me.lbl_arroz.AutoSize = True
        Me.lbl_arroz.Location = New System.Drawing.Point(10, 65)
        Me.lbl_arroz.Name = "lbl_arroz"
        Me.lbl_arroz.Size = New System.Drawing.Size(106, 13)
        Me.lbl_arroz.TabIndex = 0
        Me.lbl_arroz.Text = "Libra de arroz Q2.00 "
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.Transparent
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(19, 19)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(80, 24)
        Me.btn_calcular.TabIndex = 2
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.Transparent
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(123, 19)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(80, 24)
        Me.btn_limpiar.TabIndex = 3
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(216, 19)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.txt_total)
        Me.GroupBox2.Controls.Add(Me.txt_descuentos)
        Me.GroupBox2.Controls.Add(Me.txt_coniva)
        Me.GroupBox2.Controls.Add(Me.txt_iva)
        Me.GroupBox2.Controls.Add(Me.txt_siniva)
        Me.GroupBox2.Controls.Add(Me.lbl_total)
        Me.GroupBox2.Controls.Add(Me.lbl_descuentos)
        Me.GroupBox2.Controls.Add(Me.lbl_con_iva)
        Me.GroupBox2.Controls.Add(Me.lbl_iva)
        Me.GroupBox2.Controls.Add(Me.lbl_sin_iva)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 183)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL EN QUETZALES (Q)"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(99, 144)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 7
        '
        'txt_descuentos
        '
        Me.txt_descuentos.Enabled = False
        Me.txt_descuentos.Location = New System.Drawing.Point(99, 115)
        Me.txt_descuentos.Name = "txt_descuentos"
        Me.txt_descuentos.Size = New System.Drawing.Size(100, 20)
        Me.txt_descuentos.TabIndex = 6
        '
        'txt_coniva
        '
        Me.txt_coniva.Enabled = False
        Me.txt_coniva.Location = New System.Drawing.Point(99, 87)
        Me.txt_coniva.Name = "txt_coniva"
        Me.txt_coniva.Size = New System.Drawing.Size(100, 20)
        Me.txt_coniva.TabIndex = 5
        '
        'txt_iva
        '
        Me.txt_iva.Enabled = False
        Me.txt_iva.Location = New System.Drawing.Point(99, 61)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(100, 20)
        Me.txt_iva.TabIndex = 4
        '
        'txt_siniva
        '
        Me.txt_siniva.Enabled = False
        Me.txt_siniva.Location = New System.Drawing.Point(99, 29)
        Me.txt_siniva.Name = "txt_siniva"
        Me.txt_siniva.Size = New System.Drawing.Size(100, 20)
        Me.txt_siniva.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(17, 147)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(55, 13)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Pago total"
        '
        'lbl_descuentos
        '
        Me.lbl_descuentos.AutoSize = True
        Me.lbl_descuentos.Location = New System.Drawing.Point(17, 117)
        Me.lbl_descuentos.Name = "lbl_descuentos"
        Me.lbl_descuentos.Size = New System.Drawing.Size(67, 13)
        Me.lbl_descuentos.TabIndex = 3
        Me.lbl_descuentos.Text = "Descuentos "
        '
        'lbl_con_iva
        '
        Me.lbl_con_iva.AutoSize = True
        Me.lbl_con_iva.Location = New System.Drawing.Point(17, 88)
        Me.lbl_con_iva.Name = "lbl_con_iva"
        Me.lbl_con_iva.Size = New System.Drawing.Size(73, 13)
        Me.lbl_con_iva.TabIndex = 2
        Me.lbl_con_iva.Text = "Pago con IVA"
        '
        'lbl_iva
        '
        Me.lbl_iva.AutoSize = True
        Me.lbl_iva.Location = New System.Drawing.Point(17, 61)
        Me.lbl_iva.Name = "lbl_iva"
        Me.lbl_iva.Size = New System.Drawing.Size(24, 13)
        Me.lbl_iva.TabIndex = 1
        Me.lbl_iva.Text = "IVA"
        '
        'lbl_sin_iva
        '
        Me.lbl_sin_iva.AutoSize = True
        Me.lbl_sin_iva.Location = New System.Drawing.Point(17, 29)
        Me.lbl_sin_iva.Name = "lbl_sin_iva"
        Me.lbl_sin_iva.Size = New System.Drawing.Size(68, 13)
        Me.lbl_sin_iva.TabIndex = 0
        Me.lbl_sin_iva.Text = "Pago sin IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox3.Controls.Add(Me.btn_limpiar)
        Me.GroupBox3.Controls.Add(Me.btn_calcular)
        Me.GroupBox3.Controls.Add(Me.btn_salir)
        Me.GroupBox3.Location = New System.Drawing.Point(190, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 66)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BOTONES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global._201901838_Tienda.My.Resources.Resources.granos_e1497627817769
        Me.ClientSize = New System.Drawing.Size(624, 358)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Name = "Form1"
        Me.Text = "Tienda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_azucar As TextBox
    Friend WithEvents txt_frijol As TextBox
    Friend WithEvents txt_arroz As TextBox
    Friend WithEvents lbl_azucar As Label
    Friend WithEvents lbl_frijol As Label
    Friend WithEvents lbl_arroz As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_descuentos As Label
    Friend WithEvents lbl_con_iva As Label
    Friend WithEvents lbl_iva As Label
    Friend WithEvents lbl_sin_iva As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_descuentos As TextBox
    Friend WithEvents txt_coniva As TextBox
    Friend WithEvents txt_iva As TextBox
    Friend WithEvents txt_siniva As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
