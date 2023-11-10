<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bioimpedancia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_bioimpedancia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_gordura_corporal_porcentagem = New System.Windows.Forms.TextBox()
        Me.txt_massa_magra_porcentagem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_massa_magra = New System.Windows.Forms.TextBox()
        Me.txt_gordura_corporal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_gordura_visceral = New System.Windows.Forms.TextBox()
        Me.img_voltar = New System.Windows.Forms.PictureBox()
        Me.img_bio = New System.Windows.Forms.PictureBox()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_bio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(32, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(36, 69)
        Me.txt_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(407, 22)
        Me.txt_cliente.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Altura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(292, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 22)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Peso"
        '
        'txt_altura
        '
        Me.txt_altura.Location = New System.Drawing.Point(36, 133)
        Me.txt_altura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(147, 22)
        Me.txt_altura.TabIndex = 23
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(296, 133)
        Me.txt_peso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(147, 22)
        Me.txt_peso.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(247, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 22)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "% Gordura corporal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(32, 241)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "% Massa magra"
        '
        'txt_gordura_corporal_porcentagem
        '
        Me.txt_gordura_corporal_porcentagem.Location = New System.Drawing.Point(296, 266)
        Me.txt_gordura_corporal_porcentagem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_gordura_corporal_porcentagem.Name = "txt_gordura_corporal_porcentagem"
        Me.txt_gordura_corporal_porcentagem.Size = New System.Drawing.Size(147, 22)
        Me.txt_gordura_corporal_porcentagem.TabIndex = 27
        '
        'txt_massa_magra_porcentagem
        '
        Me.txt_massa_magra_porcentagem.Location = New System.Drawing.Point(36, 266)
        Me.txt_massa_magra_porcentagem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_massa_magra_porcentagem.Name = "txt_massa_magra_porcentagem"
        Me.txt_massa_magra_porcentagem.Size = New System.Drawing.Size(147, 22)
        Me.txt_massa_magra_porcentagem.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(32, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 22)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Massa magra"
        '
        'txt_massa_magra
        '
        Me.txt_massa_magra.Location = New System.Drawing.Point(36, 198)
        Me.txt_massa_magra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_massa_magra.Name = "txt_massa_magra"
        Me.txt_massa_magra.Size = New System.Drawing.Size(147, 22)
        Me.txt_massa_magra.TabIndex = 30
        '
        'txt_gordura_corporal
        '
        Me.txt_gordura_corporal.Location = New System.Drawing.Point(296, 198)
        Me.txt_gordura_corporal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_gordura_corporal.Name = "txt_gordura_corporal"
        Me.txt_gordura_corporal.Size = New System.Drawing.Size(147, 22)
        Me.txt_gordura_corporal.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(272, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 22)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Gordura corporal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(32, 311)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 22)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Gordura visceral"
        '
        'txt_gordura_visceral
        '
        Me.txt_gordura_visceral.Location = New System.Drawing.Point(36, 336)
        Me.txt_gordura_visceral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_gordura_visceral.Name = "txt_gordura_visceral"
        Me.txt_gordura_visceral.Size = New System.Drawing.Size(147, 22)
        Me.txt_gordura_visceral.TabIndex = 34
        '
        'img_voltar
        '
        Me.img_voltar.BackColor = System.Drawing.Color.Transparent
        Me.img_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_voltar.Image = CType(resources.GetObject("img_voltar.Image"), System.Drawing.Image)
        Me.img_voltar.Location = New System.Drawing.Point(16, 6)
        Me.img_voltar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_voltar.Name = "img_voltar"
        Me.img_voltar.Size = New System.Drawing.Size(37, 34)
        Me.img_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_voltar.TabIndex = 67
        Me.img_voltar.TabStop = False
        '
        'img_bio
        '
        Me.img_bio.BackColor = System.Drawing.Color.Transparent
        Me.img_bio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_bio.Image = CType(resources.GetObject("img_bio.Image"), System.Drawing.Image)
        Me.img_bio.Location = New System.Drawing.Point(367, 336)
        Me.img_bio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_bio.Name = "img_bio"
        Me.img_bio.Size = New System.Drawing.Size(77, 65)
        Me.img_bio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_bio.TabIndex = 68
        Me.img_bio.TabStop = False
        '
        'frm_bioimpedancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 422)
        Me.Controls.Add(Me.img_bio)
        Me.Controls.Add(Me.img_voltar)
        Me.Controls.Add(Me.txt_gordura_visceral)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_gordura_corporal)
        Me.Controls.Add(Me.txt_massa_magra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_massa_magra_porcentagem)
        Me.Controls.Add(Me.txt_gordura_corporal_porcentagem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_bioimpedancia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bioimpedancia"
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_bio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_altura As TextBox
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_gordura_corporal_porcentagem As TextBox
    Friend WithEvents txt_massa_magra_porcentagem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_massa_magra As TextBox
    Friend WithEvents txt_gordura_corporal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_gordura_visceral As TextBox
    Friend WithEvents img_voltar As PictureBox
    Friend WithEvents img_bio As PictureBox
End Class
