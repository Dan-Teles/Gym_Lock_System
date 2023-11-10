<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dieta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dieta))
        Me.img_voltar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cafe_manha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_almoco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cafe_tarde = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_jantar = New System.Windows.Forms.TextBox()
        Me.img_apagar = New System.Windows.Forms.PictureBox()
        Me.img_registrar_dieta = New System.Windows.Forms.PictureBox()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_apagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_registrar_dieta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_voltar
        '
        Me.img_voltar.BackColor = System.Drawing.Color.Transparent
        Me.img_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_voltar.Image = CType(resources.GetObject("img_voltar.Image"), System.Drawing.Image)
        Me.img_voltar.Location = New System.Drawing.Point(5, 5)
        Me.img_voltar.Margin = New System.Windows.Forms.Padding(4)
        Me.img_voltar.Name = "img_voltar"
        Me.img_voltar.Size = New System.Drawing.Size(37, 34)
        Me.img_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_voltar.TabIndex = 67
        Me.img_voltar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "DIETA"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Location = New System.Drawing.Point(35, 74)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(564, 22)
        Me.txt_cliente.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 20)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "CAFÉ DA MANHÃ"
        '
        'txt_cafe_manha
        '
        Me.txt_cafe_manha.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cafe_manha.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_cafe_manha.Location = New System.Drawing.Point(35, 135)
        Me.txt_cafe_manha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cafe_manha.Multiline = True
        Me.txt_cafe_manha.Name = "txt_cafe_manha"
        Me.txt_cafe_manha.Size = New System.Drawing.Size(564, 111)
        Me.txt_cafe_manha.TabIndex = 1
        Me.txt_cafe_manha.Text = "2x Ovos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "ALMOÇO"
        '
        'txt_almoco
        '
        Me.txt_almoco.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_almoco.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_almoco.Location = New System.Drawing.Point(35, 286)
        Me.txt_almoco.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_almoco.Multiline = True
        Me.txt_almoco.Name = "txt_almoco"
        Me.txt_almoco.Size = New System.Drawing.Size(564, 111)
        Me.txt_almoco.TabIndex = 2
        Me.txt_almoco.Text = "200g de Frango grelhado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 416)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "CAFÉ DA TARDE"
        '
        'txt_cafe_tarde
        '
        Me.txt_cafe_tarde.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cafe_tarde.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_cafe_tarde.Location = New System.Drawing.Point(35, 438)
        Me.txt_cafe_tarde.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cafe_tarde.Multiline = True
        Me.txt_cafe_tarde.Name = "txt_cafe_tarde"
        Me.txt_cafe_tarde.Size = New System.Drawing.Size(564, 111)
        Me.txt_cafe_tarde.TabIndex = 3
        Me.txt_cafe_tarde.Text = "1x Banana"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 566)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "JANTAR"
        '
        'txt_jantar
        '
        Me.txt_jantar.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jantar.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_jantar.Location = New System.Drawing.Point(35, 588)
        Me.txt_jantar.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_jantar.Multiline = True
        Me.txt_jantar.Name = "txt_jantar"
        Me.txt_jantar.Size = New System.Drawing.Size(564, 111)
        Me.txt_jantar.TabIndex = 4
        Me.txt_jantar.Text = "250g de Patinho moído"
        '
        'img_apagar
        '
        Me.img_apagar.BackColor = System.Drawing.Color.Transparent
        Me.img_apagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_apagar.Image = CType(resources.GetObject("img_apagar.Image"), System.Drawing.Image)
        Me.img_apagar.Location = New System.Drawing.Point(35, 721)
        Me.img_apagar.Margin = New System.Windows.Forms.Padding(4)
        Me.img_apagar.Name = "img_apagar"
        Me.img_apagar.Size = New System.Drawing.Size(60, 55)
        Me.img_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_apagar.TabIndex = 95
        Me.img_apagar.TabStop = False
        '
        'img_registrar_dieta
        '
        Me.img_registrar_dieta.BackColor = System.Drawing.Color.Transparent
        Me.img_registrar_dieta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_registrar_dieta.Image = CType(resources.GetObject("img_registrar_dieta.Image"), System.Drawing.Image)
        Me.img_registrar_dieta.Location = New System.Drawing.Point(540, 721)
        Me.img_registrar_dieta.Margin = New System.Windows.Forms.Padding(4)
        Me.img_registrar_dieta.Name = "img_registrar_dieta"
        Me.img_registrar_dieta.Size = New System.Drawing.Size(60, 55)
        Me.img_registrar_dieta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_registrar_dieta.TabIndex = 96
        Me.img_registrar_dieta.TabStop = False
        '
        'frm_dieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 788)
        Me.Controls.Add(Me.img_registrar_dieta)
        Me.Controls.Add(Me.img_apagar)
        Me.Controls.Add(Me.txt_jantar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_cafe_tarde)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_almoco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cafe_manha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_dieta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_dieta"
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_apagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_registrar_dieta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_voltar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cafe_manha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_almoco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cafe_tarde As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_jantar As TextBox
    Friend WithEvents img_apagar As PictureBox
    Friend WithEvents img_registrar_dieta As PictureBox
End Class
