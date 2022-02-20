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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rblarge = New System.Windows.Forms.RadioButton()
        Me.rbmedium = New System.Windows.Forms.RadioButton()
        Me.rbsmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rblona = New System.Windows.Forms.RadioButton()
        Me.rbalgodon = New System.Windows.Forms.RadioButton()
        Me.rbseda = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_costototal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_venta = New System.Windows.Forms.TextBox()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SpringGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chumpas ""Tu mejor opción"""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.rblarge)
        Me.GroupBox1.Controls.Add(Me.rbmedium)
        Me.GroupBox1.Controls.Add(Me.rbsmall)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 165)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de chumpas"
        '
        'rblarge
        '
        Me.rblarge.AutoSize = True
        Me.rblarge.Location = New System.Drawing.Point(29, 124)
        Me.rblarge.Name = "rblarge"
        Me.rblarge.Size = New System.Drawing.Size(52, 17)
        Me.rblarge.TabIndex = 2
        Me.rblarge.TabStop = True
        Me.rblarge.Text = "Large"
        Me.rblarge.UseVisualStyleBackColor = True
        '
        'rbmedium
        '
        Me.rbmedium.AutoSize = True
        Me.rbmedium.Location = New System.Drawing.Point(29, 84)
        Me.rbmedium.Name = "rbmedium"
        Me.rbmedium.Size = New System.Drawing.Size(62, 17)
        Me.rbmedium.TabIndex = 1
        Me.rbmedium.TabStop = True
        Me.rbmedium.Text = "Medium"
        Me.rbmedium.UseVisualStyleBackColor = True
        '
        'rbsmall
        '
        Me.rbsmall.AutoSize = True
        Me.rbsmall.Location = New System.Drawing.Point(29, 43)
        Me.rbsmall.Name = "rbsmall"
        Me.rbsmall.Size = New System.Drawing.Size(50, 17)
        Me.rbsmall.TabIndex = 0
        Me.rbsmall.TabStop = True
        Me.rbsmall.Text = "Small"
        Me.rbsmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.rblona)
        Me.GroupBox2.Controls.Add(Me.rbalgodon)
        Me.GroupBox2.Controls.Add(Me.rbseda)
        Me.GroupBox2.Location = New System.Drawing.Point(241, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 165)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de material"
        '
        'rblona
        '
        Me.rblona.AutoSize = True
        Me.rblona.Location = New System.Drawing.Point(29, 128)
        Me.rblona.Name = "rblona"
        Me.rblona.Size = New System.Drawing.Size(49, 17)
        Me.rblona.TabIndex = 5
        Me.rblona.TabStop = True
        Me.rblona.Text = "Lona"
        Me.rblona.UseVisualStyleBackColor = True
        '
        'rbalgodon
        '
        Me.rbalgodon.AutoSize = True
        Me.rbalgodon.Location = New System.Drawing.Point(29, 44)
        Me.rbalgodon.Name = "rbalgodon"
        Me.rbalgodon.Size = New System.Drawing.Size(64, 17)
        Me.rbalgodon.TabIndex = 3
        Me.rbalgodon.TabStop = True
        Me.rbalgodon.Text = "Algodón"
        Me.rbalgodon.UseVisualStyleBackColor = True
        '
        'rbseda
        '
        Me.rbseda.AutoSize = True
        Me.rbseda.Location = New System.Drawing.Point(29, 84)
        Me.rbseda.Name = "rbseda"
        Me.rbseda.Size = New System.Drawing.Size(50, 17)
        Me.rbseda.TabIndex = 4
        Me.rbseda.TabStop = True
        Me.rbseda.Text = "Seda"
        Me.rbseda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad de chumpas a fabricar"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(77, 57)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.txt_costototal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_venta)
        Me.GroupBox3.Controls.Add(Me.txt_costo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(49, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'txt_costototal
        '
        Me.txt_costototal.Enabled = False
        Me.txt_costototal.Location = New System.Drawing.Point(498, 30)
        Me.txt_costototal.Name = "txt_costototal"
        Me.txt_costototal.Size = New System.Drawing.Size(100, 20)
        Me.txt_costototal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "El precio del costo total es:  Q."
        '
        'txt_venta
        '
        Me.txt_venta.Enabled = False
        Me.txt_venta.Location = New System.Drawing.Point(192, 63)
        Me.txt_venta.Name = "txt_venta"
        Me.txt_venta.Size = New System.Drawing.Size(100, 20)
        Me.txt_venta.TabIndex = 3
        '
        'txt_costo
        '
        Me.txt_costo.Enabled = False
        Me.txt_costo.Location = New System.Drawing.Point(192, 30)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(100, 20)
        Me.txt_costo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "El precio de venta  unitario es:  Q."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "El precio de costo unitario es:   Q."
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(425, 175)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 58)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Botones"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(173, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(92, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txt_cantidad)
        Me.GroupBox5.Location = New System.Drawing.Point(425, 68)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(256, 101)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ingreso de datos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(729, 443)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rblarge As RadioButton
    Friend WithEvents rbmedium As RadioButton
    Friend WithEvents rbsmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rblona As RadioButton
    Friend WithEvents rbalgodon As RadioButton
    Friend WithEvents rbseda As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_venta As TextBox
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_costototal As TextBox
    Friend WithEvents GroupBox5 As GroupBox
End Class
