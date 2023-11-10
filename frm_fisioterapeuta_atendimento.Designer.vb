<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fisioterapeuta_atendimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fisioterapeuta_atendimento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_atendimento = New System.Windows.Forms.ComboBox()
        Me.lbl_grupo_muscular = New System.Windows.Forms.Label()
        Me.lbl_observacao = New System.Windows.Forms.Label()
        Me.txt_observacao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.img_registrar = New System.Windows.Forms.PictureBox()
        Me.img_sair = New System.Windows.Forms.PictureBox()
        Me.img_info = New System.Windows.Forms.PictureBox()
        Me.img_preencher = New System.Windows.Forms.PictureBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.cmb_patologia = New System.Windows.Forms.ComboBox()
        Me.txt_patologia = New System.Windows.Forms.TextBox()
        CType(Me.img_registrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_preencher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(32, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'cmb_atendimento
        '
        Me.cmb_atendimento.FormattingEnabled = True
        Me.cmb_atendimento.Location = New System.Drawing.Point(244, 102)
        Me.cmb_atendimento.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_atendimento.Name = "cmb_atendimento"
        Me.cmb_atendimento.Size = New System.Drawing.Size(251, 24)
        Me.cmb_atendimento.TabIndex = 3
        '
        'lbl_grupo_muscular
        '
        Me.lbl_grupo_muscular.AutoSize = True
        Me.lbl_grupo_muscular.BackColor = System.Drawing.Color.Transparent
        Me.lbl_grupo_muscular.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_grupo_muscular.Location = New System.Drawing.Point(28, 184)
        Me.lbl_grupo_muscular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_grupo_muscular.Name = "lbl_grupo_muscular"
        Me.lbl_grupo_muscular.Size = New System.Drawing.Size(212, 22)
        Me.lbl_grupo_muscular.TabIndex = 6
        Me.lbl_grupo_muscular.Text = "Agrupamento da lesao"
        '
        'lbl_observacao
        '
        Me.lbl_observacao.AutoSize = True
        Me.lbl_observacao.BackColor = System.Drawing.Color.Transparent
        Me.lbl_observacao.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_observacao.Location = New System.Drawing.Point(28, 232)
        Me.lbl_observacao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_observacao.Name = "lbl_observacao"
        Me.lbl_observacao.Size = New System.Drawing.Size(120, 22)
        Me.lbl_observacao.TabIndex = 8
        Me.lbl_observacao.Text = "Observações"
        '
        'txt_observacao
        '
        Me.txt_observacao.Location = New System.Drawing.Point(32, 263)
        Me.txt_observacao.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_observacao.Multiline = True
        Me.txt_observacao.Name = "txt_observacao"
        Me.txt_observacao.Size = New System.Drawing.Size(452, 114)
        Me.txt_observacao.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(28, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Atendimento prestado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(28, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Possui lesões ou patologias?"
        '
        'img_registrar
        '
        Me.img_registrar.BackColor = System.Drawing.Color.Transparent
        Me.img_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_registrar.Image = CType(resources.GetObject("img_registrar.Image"), System.Drawing.Image)
        Me.img_registrar.Location = New System.Drawing.Point(420, 385)
        Me.img_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.img_registrar.Name = "img_registrar"
        Me.img_registrar.Size = New System.Drawing.Size(80, 74)
        Me.img_registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_registrar.TabIndex = 15
        Me.img_registrar.TabStop = False
        '
        'img_sair
        '
        Me.img_sair.BackColor = System.Drawing.Color.Transparent
        Me.img_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_sair.Image = CType(resources.GetObject("img_sair.Image"), System.Drawing.Image)
        Me.img_sair.Location = New System.Drawing.Point(478, 7)
        Me.img_sair.Margin = New System.Windows.Forms.Padding(4)
        Me.img_sair.Name = "img_sair"
        Me.img_sair.Size = New System.Drawing.Size(39, 36)
        Me.img_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_sair.TabIndex = 16
        Me.img_sair.TabStop = False
        '
        'img_info
        '
        Me.img_info.BackColor = System.Drawing.Color.Transparent
        Me.img_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_info.Image = CType(resources.GetObject("img_info.Image"), System.Drawing.Image)
        Me.img_info.Location = New System.Drawing.Point(167, 236)
        Me.img_info.Margin = New System.Windows.Forms.Padding(4)
        Me.img_info.Name = "img_info"
        Me.img_info.Size = New System.Drawing.Size(20, 18)
        Me.img_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_info.TabIndex = 17
        Me.img_info.TabStop = False
        '
        'img_preencher
        '
        Me.img_preencher.BackColor = System.Drawing.Color.Transparent
        Me.img_preencher.Image = CType(resources.GetObject("img_preencher.Image"), System.Drawing.Image)
        Me.img_preencher.Location = New System.Drawing.Point(103, 189)
        Me.img_preencher.Margin = New System.Windows.Forms.Padding(4)
        Me.img_preencher.Name = "img_preencher"
        Me.img_preencher.Size = New System.Drawing.Size(305, 244)
        Me.img_preencher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_preencher.TabIndex = 18
        Me.img_preencher.TabStop = False
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(114, 58)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(381, 22)
        Me.txt_cliente.TabIndex = 19
        '
        'cmb_patologia
        '
        Me.cmb_patologia.FormattingEnabled = True
        Me.cmb_patologia.Location = New System.Drawing.Point(299, 143)
        Me.cmb_patologia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_patologia.Name = "cmb_patologia"
        Me.cmb_patologia.Size = New System.Drawing.Size(196, 24)
        Me.cmb_patologia.TabIndex = 96
        '
        'txt_patologia
        '
        Me.txt_patologia.Location = New System.Drawing.Point(244, 184)
        Me.txt_patologia.Name = "txt_patologia"
        Me.txt_patologia.Size = New System.Drawing.Size(251, 22)
        Me.txt_patologia.TabIndex = 99
        '
        'frm_fisioterapeuta_atendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(523, 480)
        Me.Controls.Add(Me.txt_patologia)
        Me.Controls.Add(Me.cmb_patologia)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.img_info)
        Me.Controls.Add(Me.img_sair)
        Me.Controls.Add(Me.img_registrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_observacao)
        Me.Controls.Add(Me.lbl_observacao)
        Me.Controls.Add(Me.lbl_grupo_muscular)
        Me.Controls.Add(Me.cmb_atendimento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_preencher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_fisioterapeuta_atendimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_fisioterapeuta_atendimento"
        CType(Me.img_registrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_preencher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_atendimento As ComboBox
    Friend WithEvents lbl_grupo_muscular As Label
    Friend WithEvents lbl_observacao As Label
    Friend WithEvents txt_observacao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents img_registrar As PictureBox
    Friend WithEvents img_sair As PictureBox
    Friend WithEvents img_info As PictureBox
    Friend WithEvents img_preencher As PictureBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents cmb_patologia As ComboBox
    Friend WithEvents txt_patologia As TextBox
End Class
