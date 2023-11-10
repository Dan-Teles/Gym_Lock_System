<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_recepcionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recepcionista))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.img_adm = New System.Windows.Forms.PictureBox()
        Me.img_sair = New System.Windows.Forms.PictureBox()
        Me.img_nutricionista = New System.Windows.Forms.PictureBox()
        Me.img_fisioterapeuta = New System.Windows.Forms.PictureBox()
        Me.img_agendar = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_cpf_agendamento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_agendamento = New System.Windows.Forms.DateTimePicker()
        Me.cmb_profissional = New System.Windows.Forms.ComboBox()
        Me.cmb_horarios = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome_agendamento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.lbl_planos = New System.Windows.Forms.Label()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_comp = New System.Windows.Forms.Label()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.lbl_uf = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_rg = New System.Windows.Forms.Label()
        Me.lbl_data_nascimento = New System.Windows.Forms.Label()
        Me.img_cadastrar = New System.Windows.Forms.PictureBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_planos = New System.Windows.Forms.ComboBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_clientes = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgv_armarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_nutricionista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_fisioterapeuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_agendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_cadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgv_armarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 332)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.img_adm)
        Me.TabPage1.Controls.Add(Me.img_sair)
        Me.TabPage1.Controls.Add(Me.img_nutricionista)
        Me.TabPage1.Controls.Add(Me.img_fisioterapeuta)
        Me.TabPage1.Controls.Add(Me.img_agendar)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txt_cpf_agendamento)
        Me.TabPage1.Controls.Add(Me.txt_data_agendamento)
        Me.TabPage1.Controls.Add(Me.cmb_profissional)
        Me.TabPage1.Controls.Add(Me.cmb_horarios)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_nome_agendamento)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(632, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AGENDAMENTOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'img_adm
        '
        Me.img_adm.BackColor = System.Drawing.Color.Transparent
        Me.img_adm.Image = CType(resources.GetObject("img_adm.Image"), System.Drawing.Image)
        Me.img_adm.Location = New System.Drawing.Point(101, 269)
        Me.img_adm.Name = "img_adm"
        Me.img_adm.Size = New System.Drawing.Size(25, 25)
        Me.img_adm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_adm.TabIndex = 68
        Me.img_adm.TabStop = False
        '
        'img_sair
        '
        Me.img_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_sair.Image = CType(resources.GetObject("img_sair.Image"), System.Drawing.Image)
        Me.img_sair.Location = New System.Drawing.Point(32, 244)
        Me.img_sair.Name = "img_sair"
        Me.img_sair.Size = New System.Drawing.Size(50, 50)
        Me.img_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_sair.TabIndex = 22
        Me.img_sair.TabStop = False
        '
        'img_nutricionista
        '
        Me.img_nutricionista.Image = CType(resources.GetObject("img_nutricionista.Image"), System.Drawing.Image)
        Me.img_nutricionista.Location = New System.Drawing.Point(365, 97)
        Me.img_nutricionista.Name = "img_nutricionista"
        Me.img_nutricionista.Size = New System.Drawing.Size(60, 60)
        Me.img_nutricionista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_nutricionista.TabIndex = 21
        Me.img_nutricionista.TabStop = False
        '
        'img_fisioterapeuta
        '
        Me.img_fisioterapeuta.Image = CType(resources.GetObject("img_fisioterapeuta.Image"), System.Drawing.Image)
        Me.img_fisioterapeuta.Location = New System.Drawing.Point(365, 97)
        Me.img_fisioterapeuta.Name = "img_fisioterapeuta"
        Me.img_fisioterapeuta.Size = New System.Drawing.Size(60, 60)
        Me.img_fisioterapeuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_fisioterapeuta.TabIndex = 20
        Me.img_fisioterapeuta.TabStop = False
        '
        'img_agendar
        '
        Me.img_agendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_agendar.Image = CType(resources.GetObject("img_agendar.Image"), System.Drawing.Image)
        Me.img_agendar.Location = New System.Drawing.Point(534, 224)
        Me.img_agendar.Name = "img_agendar"
        Me.img_agendar.Size = New System.Drawing.Size(70, 70)
        Me.img_agendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_agendar.TabIndex = 19
        Me.img_agendar.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(255, 178)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(216, 19)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "SELECIONE O HORÁRIO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 19)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "SELECIONE A DATA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(263, 19)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "SELECIONE O PROFISSIONAL"
        '
        'txt_cpf_agendamento
        '
        Me.txt_cpf_agendamento.BackColor = System.Drawing.Color.White
        Me.txt_cpf_agendamento.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_agendamento.Location = New System.Drawing.Point(32, 48)
        Me.txt_cpf_agendamento.Mask = "000.000.000-00"
        Me.txt_cpf_agendamento.Name = "txt_cpf_agendamento"
        Me.txt_cpf_agendamento.Size = New System.Drawing.Size(135, 26)
        Me.txt_cpf_agendamento.TabIndex = 0
        Me.txt_cpf_agendamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_data_agendamento
        '
        Me.txt_data_agendamento.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.txt_data_agendamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_data_agendamento.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_agendamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_data_agendamento.Location = New System.Drawing.Point(32, 200)
        Me.txt_data_agendamento.Name = "txt_data_agendamento"
        Me.txt_data_agendamento.Size = New System.Drawing.Size(177, 26)
        Me.txt_data_agendamento.TabIndex = 3
        '
        'cmb_profissional
        '
        Me.cmb_profissional.BackColor = System.Drawing.Color.White
        Me.cmb_profissional.CausesValidation = False
        Me.cmb_profissional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_profissional.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_profissional.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_profissional.FormattingEnabled = True
        Me.cmb_profissional.Location = New System.Drawing.Point(32, 124)
        Me.cmb_profissional.Name = "cmb_profissional"
        Me.cmb_profissional.Size = New System.Drawing.Size(200, 23)
        Me.cmb_profissional.TabIndex = 2
        Me.cmb_profissional.Text = "PROFISSIONAL"
        '
        'cmb_horarios
        '
        Me.cmb_horarios.BackColor = System.Drawing.Color.White
        Me.cmb_horarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_horarios.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_horarios.FormattingEnabled = True
        Me.cmb_horarios.Location = New System.Drawing.Point(259, 200)
        Me.cmb_horarios.Name = "cmb_horarios"
        Me.cmb_horarios.Size = New System.Drawing.Size(199, 23)
        Me.cmb_horarios.TabIndex = 4
        Me.cmb_horarios.Text = "HORÁRIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CPF"
        '
        'txt_nome_agendamento
        '
        Me.txt_nome_agendamento.BackColor = System.Drawing.Color.White
        Me.txt_nome_agendamento.Font = New System.Drawing.Font("High Tower Text", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_agendamento.Location = New System.Drawing.Point(194, 48)
        Me.txt_nome_agendamento.Name = "txt_nome_agendamento"
        Me.txt_nome_agendamento.Size = New System.Drawing.Size(410, 26)
        Me.txt_nome_agendamento.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(190, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 19)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "NOME"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.img_foto)
        Me.TabPage2.Controls.Add(Me.lbl_planos)
        Me.TabPage2.Controls.Add(Me.lbl_telefone)
        Me.TabPage2.Controls.Add(Me.lbl_email)
        Me.TabPage2.Controls.Add(Me.lbl_comp)
        Me.TabPage2.Controls.Add(Me.lbl_cidade)
        Me.TabPage2.Controls.Add(Me.lbl_bairro)
        Me.TabPage2.Controls.Add(Me.lbl_uf)
        Me.TabPage2.Controls.Add(Me.lbl_endereco)
        Me.TabPage2.Controls.Add(Me.lbl_cep)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.lbl_rg)
        Me.TabPage2.Controls.Add(Me.lbl_data_nascimento)
        Me.TabPage2.Controls.Add(Me.img_cadastrar)
        Me.TabPage2.Controls.Add(Me.txt_telefone)
        Me.TabPage2.Controls.Add(Me.txt_data)
        Me.TabPage2.Controls.Add(Me.txt_cep)
        Me.TabPage2.Controls.Add(Me.txt_rg)
        Me.TabPage2.Controls.Add(Me.txt_cpf)
        Me.TabPage2.Controls.Add(Me.cmb_planos)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.txt_num)
        Me.TabPage2.Controls.Add(Me.txt_cidade)
        Me.TabPage2.Controls.Add(Me.txt_bairro)
        Me.TabPage2.Controls.Add(Me.txt_uf)
        Me.TabPage2.Controls.Add(Me.txt_endereco)
        Me.TabPage2.Controls.Add(Me.txt_nome)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(632, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CADASTRO DE CLIENTES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "CONTATO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 19)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "LOCALIZAÇÃO"
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
        Me.lbl_planos.Location = New System.Drawing.Point(324, 79)
        Me.lbl_planos.Name = "lbl_planos"
        Me.lbl_planos.Size = New System.Drawing.Size(61, 15)
        Me.lbl_planos.TabIndex = 72
        Me.lbl_planos.Text = "PLANO"
        Me.lbl_planos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(18, 148)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(87, 15)
        Me.lbl_telefone.TabIndex = 71
        Me.lbl_telefone.Text = "TELEFONE"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(191, 148)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(69, 15)
        Me.lbl_email.TabIndex = 70
        Me.lbl_email.Text = "E-MAIL: "
        '
        'lbl_comp
        '
        Me.lbl_comp.AutoSize = True
        Me.lbl_comp.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comp.Location = New System.Drawing.Point(413, 215)
        Me.lbl_comp.Name = "lbl_comp"
        Me.lbl_comp.Size = New System.Drawing.Size(53, 15)
        Me.lbl_comp.TabIndex = 69
        Me.lbl_comp.Text = "COMP"
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cidade.Location = New System.Drawing.Point(219, 258)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(74, 15)
        Me.lbl_cidade.TabIndex = 68
        Me.lbl_cidade.Text = "CIDADE: "
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bairro.Location = New System.Drawing.Point(17, 258)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(68, 15)
        Me.lbl_bairro.TabIndex = 67
        Me.lbl_bairro.Text = "BAIRRO:"
        Me.lbl_bairro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_uf
        '
        Me.lbl_uf.AutoSize = True
        Me.lbl_uf.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uf.Location = New System.Drawing.Point(413, 258)
        Me.lbl_uf.Name = "lbl_uf"
        Me.lbl_uf.Size = New System.Drawing.Size(28, 15)
        Me.lbl_uf.TabIndex = 66
        Me.lbl_uf.Text = "UF"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(142, 215)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(98, 15)
        Me.lbl_endereco.TabIndex = 65
        Me.lbl_endereco.Text = "ENDEREÇO: "
        '
        'lbl_cep
        '
        Me.lbl_cep.AutoSize = True
        Me.lbl_cep.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cep.Location = New System.Drawing.Point(18, 215)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(36, 15)
        Me.lbl_cep.TabIndex = 64
        Me.lbl_cep.Text = "CEP"
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
        Me.img_cadastrar.Location = New System.Drawing.Point(550, 219)
        Me.img_cadastrar.Name = "img_cadastrar"
        Me.img_cadastrar.Size = New System.Drawing.Size(72, 72)
        Me.img_cadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cadastrar.TabIndex = 60
        Me.img_cadastrar.TabStop = False
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.White
        Me.txt_telefone.Location = New System.Drawing.Point(22, 166)
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
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.White
        Me.txt_cep.Location = New System.Drawing.Point(21, 233)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(118, 20)
        Me.txt_cep.TabIndex = 8
        Me.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'cmb_planos
        '
        Me.cmb_planos.BackColor = System.Drawing.Color.White
        Me.cmb_planos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_planos.FormattingEnabled = True
        Me.cmb_planos.Location = New System.Drawing.Point(327, 97)
        Me.cmb_planos.Name = "cmb_planos"
        Me.cmb_planos.Size = New System.Drawing.Size(182, 21)
        Me.cmb_planos.TabIndex = 5
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(194, 166)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(228, 20)
        Me.txt_email.TabIndex = 7
        '
        'txt_num
        '
        Me.txt_num.BackColor = System.Drawing.Color.White
        Me.txt_num.Location = New System.Drawing.Point(416, 233)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(67, 20)
        Me.txt_num.TabIndex = 10
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.Color.White
        Me.txt_cidade.Location = New System.Drawing.Point(222, 276)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(188, 20)
        Me.txt_cidade.TabIndex = 12
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.Color.White
        Me.txt_bairro.Location = New System.Drawing.Point(20, 276)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(196, 20)
        Me.txt_bairro.TabIndex = 11
        '
        'txt_uf
        '
        Me.txt_uf.BackColor = System.Drawing.Color.White
        Me.txt_uf.Location = New System.Drawing.Point(416, 276)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(41, 20)
        Me.txt_uf.TabIndex = 13
        '
        'txt_endereco
        '
        Me.txt_endereco.BackColor = System.Drawing.Color.White
        Me.txt_endereco.Location = New System.Drawing.Point(145, 233)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(265, 20)
        Me.txt_endereco.TabIndex = 9
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_dados_clientes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(632, 306)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "LISTAGEM DE CLIENTES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_dados_clientes
        '
        Me.dgv_dados_clientes.AllowUserToAddRows = False
        Me.dgv_dados_clientes.AllowUserToDeleteRows = False
        Me.dgv_dados_clientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_dados_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column12, Me.Column10, Me.Column11})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dados_clientes.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.Column8.HeaderText = "CPF CLIENTE"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "NOME CLIENTE"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "PLANO"
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgv_armarios)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(632, 306)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "CONTROLE DE ARMARIOS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgv_armarios
        '
        Me.dgv_armarios.AllowUserToAddRows = False
        Me.dgv_armarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_armarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_armarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_armarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("High Tower Text", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_armarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_armarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_armarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column3, Me.Column2, Me.Column5, Me.Column6})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("High Tower Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_armarios.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_armarios.Location = New System.Drawing.Point(-4, 0)
        Me.dgv_armarios.Name = "dgv_armarios"
        Me.dgv_armarios.ReadOnly = True
        Me.dgv_armarios.RowHeadersWidth = 51
        Me.dgv_armarios.Size = New System.Drawing.Size(633, 310)
        Me.dgv_armarios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° ARMÁRIO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "STATUS ARMÁRIO"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME CLIENTE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "TELEFONE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "EMPRESTAR CHAVE"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "RECOLHER CHAVE"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 80
        '
        'frm_recepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 333)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_recepcionista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_recepcionista"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_nutricionista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_fisioterapeuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_agendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_cadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgv_armarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cmb_planos As ComboBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_horarios As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_agendamento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dgv_armarios As DataGridView
    Friend WithEvents dgv_dados_clientes As DataGridView
    Friend WithEvents txt_data_agendamento As DateTimePicker
    Friend WithEvents txt_cpf_agendamento As MaskedTextBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_rg As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_profissional As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents img_agendar As PictureBox
    Friend WithEvents img_fisioterapeuta As PictureBox
    Friend WithEvents img_nutricionista As PictureBox
    Friend WithEvents img_cadastrar As PictureBox
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents lbl_cep As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_rg As Label
    Friend WithEvents lbl_data_nascimento As Label
    Friend WithEvents lbl_comp As Label
    Friend WithEvents lbl_cidade As Label
    Friend WithEvents lbl_bairro As Label
    Friend WithEvents lbl_uf As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_planos As Label
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents img_sair As PictureBox
    Friend WithEvents img_adm As PictureBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
