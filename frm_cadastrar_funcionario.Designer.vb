<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastrar_funcionario
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastrar_funcionario))
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_clientes = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.lbl_planos = New System.Windows.Forms.Label()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_rg = New System.Windows.Forms.Label()
        Me.lbl_data_nascimento = New System.Windows.Forms.Label()
        Me.img_cadastrar = New System.Windows.Forms.PictureBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_funcao = New System.Windows.Forms.ComboBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_cadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_dados_clientes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(632, 311)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "LISTAGEM DE FUNCIONÁRIOS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_dados_clientes
        '
        Me.dgv_dados_clientes.AllowUserToAddRows = False
        Me.dgv_dados_clientes.AllowUserToDeleteRows = False
        Me.dgv_dados_clientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_dados_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_dados_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column12, Me.Column10, Me.Column11})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dados_clientes.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_dados_clientes.GridColor = System.Drawing.SystemColors.Control
        Me.dgv_dados_clientes.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgv_dados_clientes.Location = New System.Drawing.Point(-4, 0)
        Me.dgv_dados_clientes.Name = "dgv_dados_clientes"
        Me.dgv_dados_clientes.ReadOnly = True
        Me.dgv_dados_clientes.RowHeadersWidth = 51
        Me.dgv_dados_clientes.Size = New System.Drawing.Size(638, 306)
        Me.dgv_dados_clientes.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "N°"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "CPF FUNCIONÁRIO"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "NOME FUNCIONÁRIO"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "FUNÇÃO"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "EDITAR"
        Me.Column10.Image = CType(resources.GetObject("Column10.Image"), System.Drawing.Image)
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column10.Width = 80
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column11.HeaderText = "EXCLUIR"
        Me.Column11.Image = CType(resources.GetObject("Column11.Image"), System.Drawing.Image)
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column11.Width = 80
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.img_foto)
        Me.TabPage2.Controls.Add(Me.lbl_planos)
        Me.TabPage2.Controls.Add(Me.lbl_telefone)
        Me.TabPage2.Controls.Add(Me.lbl_email)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.lbl_rg)
        Me.TabPage2.Controls.Add(Me.lbl_data_nascimento)
        Me.TabPage2.Controls.Add(Me.img_cadastrar)
        Me.TabPage2.Controls.Add(Me.txt_telefone)
        Me.TabPage2.Controls.Add(Me.txt_data)
        Me.TabPage2.Controls.Add(Me.txt_rg)
        Me.TabPage2.Controls.Add(Me.txt_cpf)
        Me.TabPage2.Controls.Add(Me.cmb_funcao)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.txt_nome)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(632, 311)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CADASTRO DE FUNCIONÁRIOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "CONTATO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 19)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "DADOS PESSOAIS"
        '
        'img_foto
        '
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(522, 14)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(100, 110)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 73
        Me.img_foto.TabStop = False
        '
        'lbl_planos
        '
        Me.lbl_planos.AutoSize = True
        Me.lbl_planos.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_planos.Location = New System.Drawing.Point(20, 133)
        Me.lbl_planos.Name = "lbl_planos"
        Me.lbl_planos.Size = New System.Drawing.Size(75, 15)
        Me.lbl_planos.TabIndex = 72
        Me.lbl_planos.Text = "FUNÇÃO"
        Me.lbl_planos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(19, 221)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(87, 15)
        Me.lbl_telefone.TabIndex = 71
        Me.lbl_telefone.Text = "TELEFONE"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(192, 221)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(69, 15)
        Me.lbl_email.TabIndex = 70
        Me.lbl_email.Text = "E-MAIL: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "CPF"
        '
        'lbl_rg
        '
        Me.lbl_rg.AutoSize = True
        Me.lbl_rg.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rg.Location = New System.Drawing.Point(19, 79)
        Me.lbl_rg.Name = "lbl_rg"
        Me.lbl_rg.Size = New System.Drawing.Size(27, 15)
        Me.lbl_rg.TabIndex = 62
        Me.lbl_rg.Text = "RG"
        '
        'lbl_data_nascimento
        '
        Me.lbl_data_nascimento.AutoSize = True
        Me.lbl_data_nascimento.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_nascimento.Location = New System.Drawing.Point(324, 33)
        Me.lbl_data_nascimento.Name = "lbl_data_nascimento"
        Me.lbl_data_nascimento.Size = New System.Drawing.Size(185, 15)
        Me.lbl_data_nascimento.TabIndex = 61
        Me.lbl_data_nascimento.Text = "DATA DE NASCIMENTO"
        '
        'img_cadastrar
        '
        Me.img_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_cadastrar.Image = CType(resources.GetObject("img_cadastrar.Image"), System.Drawing.Image)
        Me.img_cadastrar.Location = New System.Drawing.Point(550, 221)
        Me.img_cadastrar.Name = "img_cadastrar"
        Me.img_cadastrar.Size = New System.Drawing.Size(72, 72)
        Me.img_cadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cadastrar.TabIndex = 60
        Me.img_cadastrar.TabStop = False
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.White
        Me.txt_telefone.Location = New System.Drawing.Point(23, 239)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(125, 20)
        Me.txt_telefone.TabIndex = 6
        Me.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_data
        '
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(327, 53)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(182, 20)
        Me.txt_data.TabIndex = 1
        '
        'txt_rg
        '
        Me.txt_rg.BackColor = System.Drawing.Color.White
        Me.txt_rg.Location = New System.Drawing.Point(21, 97)
        Me.txt_rg.Mask = "00.000.000-0"
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(111, 20)
        Me.txt_rg.TabIndex = 3
        Me.txt_rg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.White
        Me.txt_cpf.Location = New System.Drawing.Point(172, 97)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(122, 20)
        Me.txt_cpf.TabIndex = 4
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_funcao
        '
        Me.cmb_funcao.BackColor = System.Drawing.Color.White
        Me.cmb_funcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_funcao.FormattingEnabled = True
        Me.cmb_funcao.Location = New System.Drawing.Point(23, 151)
        Me.cmb_funcao.Name = "cmb_funcao"
        Me.cmb_funcao.Size = New System.Drawing.Size(182, 21)
        Me.cmb_funcao.TabIndex = 5
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(195, 239)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(228, 20)
        Me.txt_email.TabIndex = 7
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.White
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_nome.Location = New System.Drawing.Point(22, 51)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(290, 22)
        Me.txt_nome.TabIndex = 0
        Me.txt_nome.Text = "Nome completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NOME"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 337)
        Me.TabControl1.TabIndex = 2
        '
        'frm_cadastrar_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 329)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastrar_funcionario"
        Me.Text = "frm_cadastrar_funcionario"
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_cadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_dados_clientes As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents lbl_planos As Label
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_rg As Label
    Friend WithEvents lbl_data_nascimento As Label
    Friend WithEvents img_cadastrar As PictureBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents txt_rg As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_funcao As ComboBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
End Class
