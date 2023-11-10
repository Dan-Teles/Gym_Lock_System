<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_emprestar_chave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emprestar_chave))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.img_emprestar_chave = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.img_voltar = New System.Windows.Forms.PictureBox()
        Me.cmb_numero_armario = New System.Windows.Forms.ComboBox()
        CType(Me.img_emprestar_chave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 217)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° DO ARMÁRIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF DO CLIENTE"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.White
        Me.txt_nome.Location = New System.Drawing.Point(37, 118)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(353, 22)
        Me.txt_nome.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOME DO CLIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TELEFONE DO CLIENTE"
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.White
        Me.txt_telefone.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.txt_telefone.Location = New System.Drawing.Point(37, 174)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(183, 27)
        Me.txt_telefone.TabIndex = 60
        Me.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'img_emprestar_chave
        '
        Me.img_emprestar_chave.BackColor = System.Drawing.Color.Transparent
        Me.img_emprestar_chave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_emprestar_chave.Image = CType(resources.GetObject("img_emprestar_chave.Image"), System.Drawing.Image)
        Me.img_emprestar_chave.Location = New System.Drawing.Point(308, 247)
        Me.img_emprestar_chave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_emprestar_chave.Name = "img_emprestar_chave"
        Me.img_emprestar_chave.Size = New System.Drawing.Size(100, 92)
        Me.img_emprestar_chave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_emprestar_chave.TabIndex = 61
        Me.img_emprestar_chave.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.White
        Me.txt_cpf.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(37, 63)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(189, 27)
        Me.txt_cpf.TabIndex = 62
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 247)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'img_voltar
        '
        Me.img_voltar.BackColor = System.Drawing.Color.Transparent
        Me.img_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_voltar.Image = CType(resources.GetObject("img_voltar.Image"), System.Drawing.Image)
        Me.img_voltar.Location = New System.Drawing.Point(7, 5)
        Me.img_voltar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_voltar.Name = "img_voltar"
        Me.img_voltar.Size = New System.Drawing.Size(37, 34)
        Me.img_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_voltar.TabIndex = 64
        Me.img_voltar.TabStop = False
        '
        'cmb_numero_armario
        '
        Me.cmb_numero_armario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_numero_armario.FormattingEnabled = True
        Me.cmb_numero_armario.Location = New System.Drawing.Point(227, 214)
        Me.cmb_numero_armario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_numero_armario.Name = "cmb_numero_armario"
        Me.cmb_numero_armario.Size = New System.Drawing.Size(68, 24)
        Me.cmb_numero_armario.TabIndex = 66
        '
        'frm_emprestar_chave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(429, 354)
        Me.Controls.Add(Me.cmb_numero_armario)
        Me.Controls.Add(Me.img_voltar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.img_emprestar_chave)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_emprestar_chave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_emprestar_chave"
        CType(Me.img_emprestar_chave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents img_emprestar_chave As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents img_voltar As PictureBox
    Friend WithEvents cmb_numero_armario As ComboBox
End Class
