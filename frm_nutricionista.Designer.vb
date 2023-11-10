<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nutricionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nutricionista))
        Me.img_dieta = New System.Windows.Forms.PictureBox()
        Me.img_bio = New System.Windows.Forms.PictureBox()
        Me.img_relatorios = New System.Windows.Forms.PictureBox()
        Me.img_agendamentos = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.img_sair = New System.Windows.Forms.PictureBox()
        Me.img_adm = New System.Windows.Forms.PictureBox()
        CType(Me.img_dieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_bio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_relatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_agendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_dieta
        '
        Me.img_dieta.BackColor = System.Drawing.Color.Transparent
        Me.img_dieta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_dieta.Image = CType(resources.GetObject("img_dieta.Image"), System.Drawing.Image)
        Me.img_dieta.Location = New System.Drawing.Point(73, 233)
        Me.img_dieta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_dieta.Name = "img_dieta"
        Me.img_dieta.Size = New System.Drawing.Size(77, 65)
        Me.img_dieta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_dieta.TabIndex = 1
        Me.img_dieta.TabStop = False
        '
        'img_bio
        '
        Me.img_bio.BackColor = System.Drawing.Color.Transparent
        Me.img_bio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_bio.Image = CType(resources.GetObject("img_bio.Image"), System.Drawing.Image)
        Me.img_bio.Location = New System.Drawing.Point(201, 233)
        Me.img_bio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_bio.Name = "img_bio"
        Me.img_bio.Size = New System.Drawing.Size(77, 65)
        Me.img_bio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_bio.TabIndex = 3
        Me.img_bio.TabStop = False
        '
        'img_relatorios
        '
        Me.img_relatorios.BackColor = System.Drawing.Color.Transparent
        Me.img_relatorios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_relatorios.Image = CType(resources.GetObject("img_relatorios.Image"), System.Drawing.Image)
        Me.img_relatorios.Location = New System.Drawing.Point(327, 233)
        Me.img_relatorios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_relatorios.Name = "img_relatorios"
        Me.img_relatorios.Size = New System.Drawing.Size(77, 65)
        Me.img_relatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_relatorios.TabIndex = 6
        Me.img_relatorios.TabStop = False
        '
        'img_agendamentos
        '
        Me.img_agendamentos.BackColor = System.Drawing.Color.Transparent
        Me.img_agendamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_agendamentos.Image = CType(resources.GetObject("img_agendamentos.Image"), System.Drawing.Image)
        Me.img_agendamentos.Location = New System.Drawing.Point(456, 233)
        Me.img_agendamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_agendamentos.Name = "img_agendamentos"
        Me.img_agendamentos.Size = New System.Drawing.Size(77, 65)
        Me.img_agendamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_agendamentos.TabIndex = 7
        Me.img_agendamentos.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(163, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "INSIRA O CPF DO CLIENTE:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 98)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox1.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(231, 138)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaskedTextBox1.Mask = "999.999.999-99"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(212, 31)
        Me.MaskedTextBox1.TabIndex = 10
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'img_sair
        '
        Me.img_sair.BackColor = System.Drawing.Color.Transparent
        Me.img_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_sair.Image = CType(resources.GetObject("img_sair.Image"), System.Drawing.Image)
        Me.img_sair.Location = New System.Drawing.Point(533, 15)
        Me.img_sair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_sair.Name = "img_sair"
        Me.img_sair.Size = New System.Drawing.Size(67, 62)
        Me.img_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_sair.TabIndex = 24
        Me.img_sair.TabStop = False
        '
        'img_adm
        '
        Me.img_adm.BackColor = System.Drawing.Color.Transparent
        Me.img_adm.Image = CType(resources.GetObject("img_adm.Image"), System.Drawing.Image)
        Me.img_adm.Location = New System.Drawing.Point(16, 15)
        Me.img_adm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_adm.Name = "img_adm"
        Me.img_adm.Size = New System.Drawing.Size(33, 31)
        Me.img_adm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_adm.TabIndex = 68
        Me.img_adm.TabStop = False
        '
        'frm_nutricionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 325)
        Me.Controls.Add(Me.img_adm)
        Me.Controls.Add(Me.img_sair)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_agendamentos)
        Me.Controls.Add(Me.img_relatorios)
        Me.Controls.Add(Me.img_bio)
        Me.Controls.Add(Me.img_dieta)
        Me.ForeColor = System.Drawing.Color.DarkCyan
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_nutricionista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_nutricionista"
        CType(Me.img_dieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_bio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_relatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_agendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_dieta As PictureBox
    Friend WithEvents img_bio As PictureBox
    Friend WithEvents img_relatorios As PictureBox
    Friend WithEvents img_agendamentos As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents img_sair As PictureBox
    Friend WithEvents img_adm As PictureBox
End Class
