Imports System.Drawing.Drawing2D
Public Class frm_recepcionista
    Private Sub frm_recepcionista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_planos()
        carregar_profissionais()
        carregar_dados_clientes()
        carregar_armarios()

        MostraTextoObj(img_agendar, "Agendar consulta")
        MostraTextoObj(img_cadastrar, "Cadastrar cliente")
        img_fisioterapeuta.Visible = False
        img_nutricionista.Visible = False

        If funcao = "ADMIN" Then
            img_adm.Visible = True
        Else
            img_adm.Visible = False
        End If

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub TabPage1_Paint(sender As Object, e As PaintEventArgs) Handles TabPage1.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)

    End Sub

    Private Sub TabPage2_Paint(sender As Object, e As PaintEventArgs) Handles TabPage2.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub DataGridView2_Paint(sender As Object, e As PaintEventArgs) Handles dgv_dados_clientes.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        'Dim oRAngle As Rectangle = New Rectangle(0, 38, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        'Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        'e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub DataGridView1_Paint(sender As Object, e As PaintEventArgs) Handles dgv_armarios.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        'Dim oRAngle As Rectangle = New Rectangle(0, 35, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        'Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        'e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub cmb_profissional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_profissional.SelectedIndexChanged
        If cmb_profissional.Text = "FISIOTERAPEUTA" Then
            img_fisioterapeuta.Visible = True
            img_nutricionista.Visible = False
        ElseIf cmb_profissional.Text = "NUTRICIONISTA" Then
            img_fisioterapeuta.Visible = False
            img_nutricionista.Visible = True
        Else
            img_fisioterapeuta.Visible = False
            img_nutricionista.Visible = False
        End If
    End Sub

    Private Sub txt_nome_Enter(sender As Object, e As EventArgs) Handles txt_nome.Enter
        If txt_nome.Text = "Nome completo" Then
            txt_nome.Text = ""
            txt_nome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_nome_Leave(sender As Object, e As EventArgs) Handles txt_nome.Leave
        If txt_nome.Text = "" Then
            txt_nome.Text = "Nome completo"
            txt_nome.ForeColor = SystemColors.ActiveCaption
        End If
    End Sub

    Private Sub img_sair_Click(sender As Object, e As EventArgs) Handles img_sair.Click
        resp = MsgBox("Deseja fazer logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Logout")
        If resp = vbYes Then
            fadeOut(Me)
            Dim frm = New frm_login
            frm.Show()
            fadeIn(frm)
        End If
    End Sub

    Private Sub img_adm_Click(sender As Object, e As EventArgs) Handles img_adm.Click
        fadeOut(Me)
        Dim frm = New frm_admin
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        'With OpenFileDialog
        '    .Title = "Selecione uma foto"
        '.InitialDirectory = Application.StartupPath & "\Fotos\"
        '.ShowDialog()
        'foto_cliente = .FileName
        'img_foto.Load(foto_cliente)
        'End With
    End Sub

    Private Sub img_cadastrar_Click(sender As Object, e As EventArgs) Handles img_cadastrar.Click
        If txt_nome.Text = "" Or
           txt_data.Text = "" Or
           txt_rg.Text = "" Or
           txt_cpf.Text = "" Or
           cmb_planos.Text = "" Or
           txt_telefone.Text = "" Or
           txt_email.Text = "" Or
           txt_cep.Text = "" Or
           txt_endereco.Text = "" Or
           txt_num.Text = "" Or
           txt_bairro.Text = "" Or
           txt_cidade.Text = "" Or
           txt_uf.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            SQL = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = "insert into tb_clientes values ('" & txt_cpf.Text & "', " &
                   "'" & txt_rg.Text & "', '" & txt_nome.Text & "', " &
                   "'" & txt_data.Value & "', '" & txt_cep.Text & "', " &
                   "'" & txt_endereco.Text & "', '" & txt_num.Text & "', " &
                   "'" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
                   "'" & txt_uf.Text & "', '" & txt_telefone.Text & "', " &
                   "'" & txt_email.Text & "', '" & cmb_planos.Text & "', " &
                   "'" & foto_cliente & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                resp = MsgBox("CPF: " & txt_cpf.Text & " ja esta cadastrado!" + vbNewLine &
                              "Deseja alterar os dados ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")

                If resp = vbYes Then
                    SQL = "update tb_clientes set nome='" & txt_nome.Text & "'," &
                                                  "data_nascimento='" & txt_data.Value & "'," &
                                                  "cep='" & txt_cep.Text & "'," &
                                                  "endereco='" & txt_endereco.Text & "'," &
                                                  "comp_num='" & txt_num.Text & "'," &
                                                  "bairro='" & txt_bairro.Text & "'," &
                                                  "cidade='" & txt_cidade.Text & "'," &
                                                  "uf='" & txt_uf.Text & "'," &
                                                  "telefone='" & txt_telefone.Text & "'," &
                                                  "e-mail='" & txt_email.Text & "'," &
                                                  "plano='" & cmb_planos.Text & "'," &
                                                  "foto='" & foto_cliente & "'where cpf='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Dados do Cliente atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
            carregar_dados_clientes()
            txt_nome.Clear()
            txt_data.Value = Now
            txt_rg.Clear()
            txt_cpf.Clear()
            cmb_planos.SelectedIndex = -1
            txt_telefone.Clear()
            txt_email.Clear()
            txt_cep.Clear()
            txt_endereco.Clear()
            txt_num.Clear()
            txt_bairro.Clear()
            txt_cidade.Clear()
            txt_uf.Clear()
            img_foto.Load(Application.StartupPath & "\icones\photo.png")
            txt_cpf.Focus()
        End If

    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        SQL = "select * from tb_cep where cep='" & txt_cep.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            txt_endereco.Text = rs.Fields(1).Value
            txt_bairro.Text = rs.Fields(3).Value
            txt_cidade.Text = rs.Fields(2).Value
            txt_uf.Text = rs.Fields(4).Value
            txt_num.Focus()
        Else
            MsgBox("CEP nao localizado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
    End Sub

    Private Sub img_agendar_Click(sender As Object, e As EventArgs) Handles img_agendar.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class