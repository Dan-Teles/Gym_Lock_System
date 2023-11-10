<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_instrutor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_instrutor))
        Me.img_sair = New System.Windows.Forms.PictureBox()
        Me.txt_cpf_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_cadastrar_treino = New System.Windows.Forms.PictureBox()
        Me.img_adm = New System.Windows.Forms.PictureBox()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_cadastrar_treino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_sair
        '
        Me.img_sair.BackColor = System.Drawing.Color.Transparent
        Me.img_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_sair.Image = CType(resources.GetObject("img_sair.Image"), System.Drawing.Image)
        Me.img_sair.Location = New System.Drawing.Point(410, 4)
        Me.img_sair.Margin = New System.Windows.Forms.Padding(4)
        Me.img_sair.Name = "img_sair"
        Me.img_sair.Size = New System.Drawing.Size(67, 62)
        Me.img_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_sair.TabIndex = 23
        Me.img_sair.TabStop = False
        '
        'txt_cpf_cliente
        '
        Me.txt_cpf_cliente.BackColor = System.Drawing.Color.White
        Me.txt_cpf_cliente.Font = New System.Drawing.Font("Imprint MT Shadow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_cpf_cliente.Location = New System.Drawing.Point(127, 74)
        Me.txt_cpf_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf_cliente.Mask = "000.000.000-00"
        Me.txt_cpf_cliente.Name = "txt_cpf_cliente"
        Me.txt_cpf_cliente.Size = New System.Drawing.Size(208, 30)
        Me.txt_cpf_cliente.TabIndex = 25
        Me.txt_cpf_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(71, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "INSIRA O CPF DO CLIENTE"
        '
        'img_cadastrar_treino
        '
        Me.img_cadastrar_treino.BackColor = System.Drawing.Color.Transparent
        Me.img_cadastrar_treino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_cadastrar_treino.Image = CType(resources.GetObject("img_cadastrar_treino.Image"), System.Drawing.Image)
        Me.img_cadastrar_treino.Location = New System.Drawing.Point(185, 127)
        Me.img_cadastrar_treino.Margin = New System.Windows.Forms.Padding(4)
        Me.img_cadastrar_treino.Name = "img_cadastrar_treino"
        Me.img_cadastrar_treino.Size = New System.Drawing.Size(80, 74)
        Me.img_cadastrar_treino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cadastrar_treino.TabIndex = 26
        Me.img_cadastrar_treino.TabStop = False
        '
        'img_adm
        '
        Me.img_adm.BackColor = System.Drawing.Color.Transparent
        Me.img_adm.Image = CType(resources.GetObject("img_adm.Image"), System.Drawing.Image)
        Me.img_adm.Location = New System.Drawing.Point(13, 14)
        Me.img_adm.Margin = New System.Windows.Forms.Padding(4)
        Me.img_adm.Name = "img_adm"
        Me.img_adm.Size = New System.Drawing.Size(33, 31)
        Me.img_adm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_adm.TabIndex = 68
        Me.img_adm.TabStop = False
        '
        'frm_instrutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 225)
        Me.Controls.Add(Me.img_adm)
        Me.Controls.Add(Me.img_cadastrar_treino)
        Me.Controls.Add(Me.txt_cpf_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_sair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_instrutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_instrutor"
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_cadastrar_treino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_sair As PictureBox
    Friend WithEvents txt_cpf_cliente As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents img_cadastrar_treino As PictureBox
    Friend WithEvents img_adm As PictureBox
End Class
