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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbventa = New System.Windows.Forms.CheckBox()
        Me.cbcompra = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_venta = New System.Windows.Forms.TextBox()
        Me.txt_compra = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rcoco = New System.Windows.Forms.RadioButton()
        Me.rcoeu = New System.Windows.Forms.RadioButton()
        Me.rcope = New System.Windows.Forms.RadioButton()
        Me.rcodo = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rveco = New System.Windows.Forms.RadioButton()
        Me.rveeu = New System.Windows.Forms.RadioButton()
        Me.rvepe = New System.Windows.Forms.RadioButton()
        Me.rvedo = New System.Windows.Forms.RadioButton()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbventa)
        Me.GroupBox1.Controls.Add(Me.cbcompra)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'cbventa
        '
        Me.cbventa.AutoSize = True
        Me.cbventa.Location = New System.Drawing.Point(23, 84)
        Me.cbventa.Name = "cbventa"
        Me.cbventa.Size = New System.Drawing.Size(54, 17)
        Me.cbventa.TabIndex = 1
        Me.cbventa.Text = "Venta"
        Me.cbventa.UseVisualStyleBackColor = True
        '
        'cbcompra
        '
        Me.cbcompra.AutoSize = True
        Me.cbcompra.Location = New System.Drawing.Point(23, 35)
        Me.cbcompra.Name = "cbcompra"
        Me.cbcompra.Size = New System.Drawing.Size(62, 17)
        Me.cbcompra.TabIndex = 0
        Me.cbcompra.Text = "Compra"
        Me.cbcompra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Casa de cambios"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_venta)
        Me.GroupBox2.Controls.Add(Me.txt_compra)
        Me.GroupBox2.Location = New System.Drawing.Point(375, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 143)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese la cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Compra"
        '
        'txt_venta
        '
        Me.txt_venta.Enabled = False
        Me.txt_venta.Location = New System.Drawing.Point(75, 80)
        Me.txt_venta.Name = "txt_venta"
        Me.txt_venta.Size = New System.Drawing.Size(100, 20)
        Me.txt_venta.TabIndex = 1
        '
        'txt_compra
        '
        Me.txt_compra.Enabled = False
        Me.txt_compra.Location = New System.Drawing.Point(75, 34)
        Me.txt_compra.Name = "txt_compra"
        Me.txt_compra.Size = New System.Drawing.Size(100, 20)
        Me.txt_compra.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.rcoco)
        Me.GroupBox3.Controls.Add(Me.rcoeu)
        Me.GroupBox3.Controls.Add(Me.rcope)
        Me.GroupBox3.Controls.Add(Me.rcodo)
        Me.GroupBox3.Location = New System.Drawing.Point(154, 215)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 155)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        '
        'rcoco
        '
        Me.rcoco.AutoSize = True
        Me.rcoco.Location = New System.Drawing.Point(23, 105)
        Me.rcoco.Name = "rcoco"
        Me.rcoco.Size = New System.Drawing.Size(118, 17)
        Me.rcoco.TabIndex = 3
        Me.rcoco.TabStop = True
        Me.rcoco.Text = "Colon costarricense"
        Me.rcoco.UseVisualStyleBackColor = True
        '
        'rcoeu
        '
        Me.rcoeu.AutoSize = True
        Me.rcoeu.Location = New System.Drawing.Point(23, 83)
        Me.rcoeu.Name = "rcoeu"
        Me.rcoeu.Size = New System.Drawing.Size(52, 17)
        Me.rcoeu.TabIndex = 2
        Me.rcoeu.TabStop = True
        Me.rcoeu.Text = "Euros"
        Me.rcoeu.UseVisualStyleBackColor = True
        '
        'rcope
        '
        Me.rcope.AutoSize = True
        Me.rcope.Location = New System.Drawing.Point(23, 56)
        Me.rcope.Name = "rcope"
        Me.rcope.Size = New System.Drawing.Size(97, 17)
        Me.rcope.TabIndex = 1
        Me.rcope.TabStop = True
        Me.rcope.Text = "Peso mexicano"
        Me.rcope.UseVisualStyleBackColor = True
        '
        'rcodo
        '
        Me.rcodo.AutoSize = True
        Me.rcodo.Location = New System.Drawing.Point(23, 33)
        Me.rcodo.Name = "rcodo"
        Me.rcodo.Size = New System.Drawing.Size(50, 17)
        Me.rcodo.TabIndex = 0
        Me.rcodo.TabStop = True
        Me.rcodo.Text = "Dolar"
        Me.rcodo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.rveco)
        Me.GroupBox4.Controls.Add(Me.rveeu)
        Me.GroupBox4.Controls.Add(Me.rvepe)
        Me.GroupBox4.Controls.Add(Me.rvedo)
        Me.GroupBox4.Location = New System.Drawing.Point(375, 215)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(185, 155)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        '
        'rveco
        '
        Me.rveco.AutoSize = True
        Me.rveco.Location = New System.Drawing.Point(17, 105)
        Me.rveco.Name = "rveco"
        Me.rveco.Size = New System.Drawing.Size(118, 17)
        Me.rveco.TabIndex = 7
        Me.rveco.TabStop = True
        Me.rveco.Text = "Colon costarricense"
        Me.rveco.UseVisualStyleBackColor = True
        '
        'rveeu
        '
        Me.rveeu.AutoSize = True
        Me.rveeu.Location = New System.Drawing.Point(17, 83)
        Me.rveeu.Name = "rveeu"
        Me.rveeu.Size = New System.Drawing.Size(52, 17)
        Me.rveeu.TabIndex = 6
        Me.rveeu.TabStop = True
        Me.rveeu.Text = "Euros"
        Me.rveeu.UseVisualStyleBackColor = True
        '
        'rvepe
        '
        Me.rvepe.AutoSize = True
        Me.rvepe.Location = New System.Drawing.Point(17, 56)
        Me.rvepe.Name = "rvepe"
        Me.rvepe.Size = New System.Drawing.Size(97, 17)
        Me.rvepe.TabIndex = 5
        Me.rvepe.TabStop = True
        Me.rvepe.Text = "Peso mexicano"
        Me.rvepe.UseVisualStyleBackColor = True
        '
        'rvedo
        '
        Me.rvedo.AutoSize = True
        Me.rvedo.Location = New System.Drawing.Point(17, 33)
        Me.rvedo.Name = "rvedo"
        Me.rvedo.Size = New System.Drawing.Size(50, 17)
        Me.rvedo.TabIndex = 4
        Me.rvedo.TabStop = True
        Me.rvedo.Text = "Dolar"
        Me.rvedo.UseVisualStyleBackColor = True
        '
        'btn_calc
        '
        Me.btn_calc.BackColor = System.Drawing.Color.Yellow
        Me.btn_calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_calc.Location = New System.Drawing.Point(223, 395)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(95, 43)
        Me.btn_calc.TabIndex = 5
        Me.btn_calc.Text = "Calcular"
        Me.btn_calc.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.Yellow
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(324, 395)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(93, 43)
        Me.btn_limpiar.TabIndex = 6
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Yellow
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(423, 395)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(89, 43)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbventa As CheckBox
    Friend WithEvents cbcompra As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_venta As TextBox
    Friend WithEvents txt_compra As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rcoco As RadioButton
    Friend WithEvents rcoeu As RadioButton
    Friend WithEvents rcope As RadioButton
    Friend WithEvents rcodo As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rveco As RadioButton
    Friend WithEvents rveeu As RadioButton
    Friend WithEvents rvepe As RadioButton
    Friend WithEvents rvedo As RadioButton
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
End Class
