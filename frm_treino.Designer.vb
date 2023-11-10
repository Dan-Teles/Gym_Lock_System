<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_treino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_treino))
        Me.img_voltar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_patologia = New System.Windows.Forms.Label()
        Me.rbt_sim = New System.Windows.Forms.RadioButton()
        Me.rbt_nao = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_peito = New System.Windows.Forms.ComboBox()
        Me.cmb_costas = New System.Windows.Forms.ComboBox()
        Me.cmb_pernas = New System.Windows.Forms.ComboBox()
        Me.cmb_ombros = New System.Windows.Forms.ComboBox()
        Me.cmb_biceps = New System.Windows.Forms.ComboBox()
        Me.cmb_triceps = New System.Windows.Forms.ComboBox()
        Me.txt_peito = New System.Windows.Forms.TextBox()
        Me.txt_costas = New System.Windows.Forms.TextBox()
        Me.txt_pernas = New System.Windows.Forms.TextBox()
        Me.txt_biceps = New System.Windows.Forms.TextBox()
        Me.txt_ombros = New System.Windows.Forms.TextBox()
        Me.txt_triceps = New System.Windows.Forms.TextBox()
        Me.img_registrar_treino = New System.Windows.Forms.PictureBox()
        Me.img_apagar = New System.Windows.Forms.PictureBox()
        Me.cmb_apresenta_patologia = New System.Windows.Forms.ComboBox()
        Me.txt_patologia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_objetivos = New System.Windows.Forms.ComboBox()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_registrar_treino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_apagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_voltar
        '
        Me.img_voltar.BackColor = System.Drawing.Color.Transparent
        Me.img_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_voltar.Image = CType(resources.GetObject("img_voltar.Image"), System.Drawing.Image)
        Me.img_voltar.Location = New System.Drawing.Point(4, 4)
        Me.img_voltar.Name = "img_voltar"
        Me.img_voltar.Size = New System.Drawing.Size(28, 28)
        Me.img_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_voltar.TabIndex = 66
        Me.img_voltar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "TREINO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "CLIENTE"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cliente.Location = New System.Drawing.Point(40, 68)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(269, 23)
        Me.txt_cliente.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 15)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "POSSUI PATOLOGIAS/RESTRIÇÕES"
        '
        'lbl_patologia
        '
        Me.lbl_patologia.AutoSize = True
        Me.lbl_patologia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_patologia.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patologia.Location = New System.Drawing.Point(37, 123)
        Me.lbl_patologia.Name = "lbl_patologia"
        Me.lbl_patologia.Size = New System.Drawing.Size(272, 15)
        Me.lbl_patologia.TabIndex = 71
        Me.lbl_patologia.Text = "LOCAL DA PATOLOGIA/RESTRIÇÃO"
        '
        'rbt_sim
        '
        Me.rbt_sim.AutoSize = True
        Me.rbt_sim.BackColor = System.Drawing.Color.Transparent
        Me.rbt_sim.Location = New System.Drawing.Point(344, 99)
        Me.rbt_sim.Name = "rbt_sim"
        Me.rbt_sim.Size = New System.Drawing.Size(42, 17)
        Me.rbt_sim.TabIndex = 72
        Me.rbt_sim.TabStop = True
        Me.rbt_sim.Text = "Sim"
        Me.rbt_sim.UseVisualStyleBackColor = False
        '
        'rbt_nao
        '
        Me.rbt_nao.AutoSize = True
        Me.rbt_nao.BackColor = System.Drawing.Color.Transparent
        Me.rbt_nao.Location = New System.Drawing.Point(405, 99)
        Me.rbt_nao.Name = "rbt_nao"
        Me.rbt_nao.Size = New System.Drawing.Size(45, 17)
        Me.rbt_nao.TabIndex = 73
        Me.rbt_nao.TabStop = True
        Me.rbt_nao.Text = "Não"
        Me.rbt_nao.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "PEITO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "BÍCEPS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "OMBROS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "PERNAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "COSTAS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(254, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "TRÍCEPS"
        '
        'cmb_peito
        '
        Me.cmb_peito.BackColor = System.Drawing.Color.White
        Me.cmb_peito.FormattingEnabled = True
        Me.cmb_peito.Location = New System.Drawing.Point(102, 159)
        Me.cmb_peito.Name = "cmb_peito"
        Me.cmb_peito.Size = New System.Drawing.Size(121, 21)
        Me.cmb_peito.TabIndex = 81
        '
        'cmb_costas
        '
        Me.cmb_costas.BackColor = System.Drawing.Color.White
        Me.cmb_costas.FormattingEnabled = True
        Me.cmb_costas.Location = New System.Drawing.Point(329, 159)
        Me.cmb_costas.Name = "cmb_costas"
        Me.cmb_costas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_costas.TabIndex = 82
        '
        'cmb_pernas
        '
        Me.cmb_pernas.BackColor = System.Drawing.Color.White
        Me.cmb_pernas.FormattingEnabled = True
        Me.cmb_pernas.Location = New System.Drawing.Point(102, 276)
        Me.cmb_pernas.Name = "cmb_pernas"
        Me.cmb_pernas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_pernas.TabIndex = 83
        '
        'cmb_ombros
        '
        Me.cmb_ombros.BackColor = System.Drawing.Color.White
        Me.cmb_ombros.FormattingEnabled = True
        Me.cmb_ombros.Location = New System.Drawing.Point(329, 273)
        Me.cmb_ombros.Name = "cmb_ombros"
        Me.cmb_ombros.Size = New System.Drawing.Size(121, 21)
        Me.cmb_ombros.TabIndex = 84
        '
        'cmb_biceps
        '
        Me.cmb_biceps.BackColor = System.Drawing.Color.White
        Me.cmb_biceps.FormattingEnabled = True
        Me.cmb_biceps.Location = New System.Drawing.Point(103, 396)
        Me.cmb_biceps.Name = "cmb_biceps"
        Me.cmb_biceps.Size = New System.Drawing.Size(121, 21)
        Me.cmb_biceps.TabIndex = 85
        '
        'cmb_triceps
        '
        Me.cmb_triceps.BackColor = System.Drawing.Color.White
        Me.cmb_triceps.FormattingEnabled = True
        Me.cmb_triceps.Location = New System.Drawing.Point(329, 396)
        Me.cmb_triceps.Name = "cmb_triceps"
        Me.cmb_triceps.Size = New System.Drawing.Size(121, 21)
        Me.cmb_triceps.TabIndex = 86
        '
        'txt_peito
        '
        Me.txt_peito.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_peito.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_peito.Location = New System.Drawing.Point(40, 186)
        Me.txt_peito.Multiline = True
        Me.txt_peito.Name = "txt_peito"
        Me.txt_peito.Size = New System.Drawing.Size(183, 79)
        Me.txt_peito.TabIndex = 87
        Me.txt_peito.Text = "4 x 12 Supino reto"
        '
        'txt_costas
        '
        Me.txt_costas.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_costas.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_costas.Location = New System.Drawing.Point(267, 186)
        Me.txt_costas.Multiline = True
        Me.txt_costas.Name = "txt_costas"
        Me.txt_costas.Size = New System.Drawing.Size(183, 79)
        Me.txt_costas.TabIndex = 88
        Me.txt_costas.Text = "4 x 12 Remada baixa"
        '
        'txt_pernas
        '
        Me.txt_pernas.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pernas.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_pernas.Location = New System.Drawing.Point(40, 303)
        Me.txt_pernas.Multiline = True
        Me.txt_pernas.Name = "txt_pernas"
        Me.txt_pernas.Size = New System.Drawing.Size(183, 79)
        Me.txt_pernas.TabIndex = 89
        Me.txt_pernas.Text = "4 x 12 Leg press 45º"
        '
        'txt_biceps
        '
        Me.txt_biceps.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_biceps.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_biceps.Location = New System.Drawing.Point(40, 423)
        Me.txt_biceps.Multiline = True
        Me.txt_biceps.Name = "txt_biceps"
        Me.txt_biceps.Size = New System.Drawing.Size(183, 79)
        Me.txt_biceps.TabIndex = 90
        Me.txt_biceps.Text = "4 x 12 Rosca direta"
        '
        'txt_ombros
        '
        Me.txt_ombros.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ombros.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_ombros.Location = New System.Drawing.Point(267, 303)
        Me.txt_ombros.Multiline = True
        Me.txt_ombros.Name = "txt_ombros"
        Me.txt_ombros.Size = New System.Drawing.Size(183, 79)
        Me.txt_ombros.TabIndex = 91
        Me.txt_ombros.Text = "3 x 15 Elevação lateral"
        '
        'txt_triceps
        '
        Me.txt_triceps.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_triceps.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_triceps.Location = New System.Drawing.Point(267, 423)
        Me.txt_triceps.Multiline = True
        Me.txt_triceps.Name = "txt_triceps"
        Me.txt_triceps.Size = New System.Drawing.Size(183, 79)
        Me.txt_triceps.TabIndex = 92
        Me.txt_triceps.Text = "4 x 12 Tríceps corda"
        '
        'img_registrar_treino
        '
        Me.img_registrar_treino.BackColor = System.Drawing.Color.Transparent
        Me.img_registrar_treino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_registrar_treino.Image = CType(resources.GetObject("img_registrar_treino.Image"), System.Drawing.Image)
        Me.img_registrar_treino.Location = New System.Drawing.Point(405, 508)
        Me.img_registrar_treino.Name = "img_registrar_treino"
        Me.img_registrar_treino.Size = New System.Drawing.Size(45, 45)
        Me.img_registrar_treino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_registrar_treino.TabIndex = 93
        Me.img_registrar_treino.TabStop = False
        '
        'img_apagar
        '
        Me.img_apagar.BackColor = System.Drawing.Color.Transparent
        Me.img_apagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_apagar.Image = CType(resources.GetObject("img_apagar.Image"), System.Drawing.Image)
        Me.img_apagar.Location = New System.Drawing.Point(40, 508)
        Me.img_apagar.Name = "img_apagar"
        Me.img_apagar.Size = New System.Drawing.Size(45, 45)
        Me.img_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_apagar.TabIndex = 94
        Me.img_apagar.TabStop = False
        '
        'cmb_apresenta_patologia
        '
        Me.cmb_apresenta_patologia.FormattingEnabled = True
        Me.cmb_apresenta_patologia.Location = New System.Drawing.Point(296, 96)
        Me.cmb_apresenta_patologia.Name = "cmb_apresenta_patologia"
        Me.cmb_apresenta_patologia.Size = New System.Drawing.Size(156, 21)
        Me.cmb_apresenta_patologia.TabIndex = 95
        '
        'txt_patologia
        '
        Me.txt_patologia.Location = New System.Drawing.Point(296, 122)
        Me.txt_patologia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_patologia.Name = "txt_patologia"
        Me.txt_patologia.Size = New System.Drawing.Size(156, 20)
        Me.txt_patologia.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(312, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "OBJETIVO"
        '
        'cmb_objetivos
        '
        Me.cmb_objetivos.Font = New System.Drawing.Font("High Tower Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_objetivos.FormattingEnabled = True
        Me.cmb_objetivos.Location = New System.Drawing.Point(315, 68)
        Me.cmb_objetivos.Name = "cmb_objetivos"
        Me.cmb_objetivos.Size = New System.Drawing.Size(137, 22)
        Me.cmb_objetivos.TabIndex = 98
        '
        'frm_treino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 560)
        Me.Controls.Add(Me.cmb_objetivos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_patologia)
        Me.Controls.Add(Me.cmb_apresenta_patologia)
        Me.Controls.Add(Me.img_apagar)
        Me.Controls.Add(Me.img_registrar_treino)
        Me.Controls.Add(Me.txt_triceps)
        Me.Controls.Add(Me.txt_ombros)
        Me.Controls.Add(Me.txt_biceps)
        Me.Controls.Add(Me.txt_pernas)
        Me.Controls.Add(Me.txt_costas)
        Me.Controls.Add(Me.txt_peito)
        Me.Controls.Add(Me.cmb_triceps)
        Me.Controls.Add(Me.cmb_biceps)
        Me.Controls.Add(Me.cmb_ombros)
        Me.Controls.Add(Me.cmb_pernas)
        Me.Controls.Add(Me.cmb_costas)
        Me.Controls.Add(Me.cmb_peito)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbt_nao)
        Me.Controls.Add(Me.rbt_sim)
        Me.Controls.Add(Me.lbl_patologia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.img_voltar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_treino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_treino"
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_registrar_treino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_apagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_voltar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_patologia As Label
    Friend WithEvents rbt_sim As RadioButton
    Friend WithEvents rbt_nao As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_peito As ComboBox
    Friend WithEvents cmb_costas As ComboBox
    Friend WithEvents cmb_pernas As ComboBox
    Friend WithEvents cmb_ombros As ComboBox
    Friend WithEvents cmb_biceps As ComboBox
    Friend WithEvents cmb_triceps As ComboBox
    Friend WithEvents txt_peito As TextBox
    Friend WithEvents txt_costas As TextBox
    Friend WithEvents txt_pernas As TextBox
    Friend WithEvents txt_biceps As TextBox
    Friend WithEvents txt_ombros As TextBox
    Friend WithEvents txt_triceps As TextBox
    Friend WithEvents img_registrar_treino As PictureBox
    Friend WithEvents img_apagar As PictureBox
    Friend WithEvents cmb_apresenta_patologia As ComboBox
    Friend WithEvents txt_patologia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_objetivos As ComboBox
End Class
