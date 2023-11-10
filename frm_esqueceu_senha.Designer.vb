<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_esqueceu_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_esqueceu_senha))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_user_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_palavra_chave = New System.Windows.Forms.TextBox()
        Me.img_recuperar_senha = New System.Windows.Forms.PictureBox()
        Me.img_voltar = New System.Windows.Forms.PictureBox()
        CType(Me.img_recuperar_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIGITE USUÁRIO OU E-MAIL"
        '
        'txt_user_email
        '
        Me.txt_user_email.Location = New System.Drawing.Point(48, 121)
        Me.txt_user_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_user_email.Name = "txt_user_email"
        Me.txt_user_email.Size = New System.Drawing.Size(388, 22)
        Me.txt_user_email.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(115, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RECUPERAR SENHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DIGITE SUA PALAVRA-CHAVE"
        '
        'txt_palavra_chave
        '
        Me.txt_palavra_chave.Location = New System.Drawing.Point(48, 188)
        Me.txt_palavra_chave.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_palavra_chave.Name = "txt_palavra_chave"
        Me.txt_palavra_chave.Size = New System.Drawing.Size(388, 22)
        Me.txt_palavra_chave.TabIndex = 4
        '
        'img_recuperar_senha
        '
        Me.img_recuperar_senha.BackColor = System.Drawing.Color.Transparent
        Me.img_recuperar_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_recuperar_senha.Image = CType(resources.GetObject("img_recuperar_senha.Image"), System.Drawing.Image)
        Me.img_recuperar_senha.Location = New System.Drawing.Point(413, 236)
        Me.img_recuperar_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.img_recuperar_senha.Name = "img_recuperar_senha"
        Me.img_recuperar_senha.Size = New System.Drawing.Size(67, 62)
        Me.img_recuperar_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_recuperar_senha.TabIndex = 5
        Me.img_recuperar_senha.TabStop = False
        '
        'img_voltar
        '
        Me.img_voltar.BackColor = System.Drawing.Color.Transparent
        Me.img_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_voltar.Image = CType(resources.GetObject("img_voltar.Image"), System.Drawing.Image)
        Me.img_voltar.Location = New System.Drawing.Point(8, 9)
        Me.img_voltar.Margin = New System.Windows.Forms.Padding(4)
        Me.img_voltar.Name = "img_voltar"
        Me.img_voltar.Size = New System.Drawing.Size(37, 34)
        Me.img_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_voltar.TabIndex = 65
        Me.img_voltar.TabStop = False
        '
        'frm_esqueceu_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 318)
        Me.Controls.Add(Me.img_voltar)
        Me.Controls.Add(Me.img_recuperar_senha)
        Me.Controls.Add(Me.txt_palavra_chave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_user_email)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_esqueceu_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_esqueceu_senha"
        CType(Me.img_recuperar_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_user_email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_palavra_chave As TextBox
    Friend WithEvents img_recuperar_senha As PictureBox
    Friend WithEvents img_voltar As PictureBox
End Class
