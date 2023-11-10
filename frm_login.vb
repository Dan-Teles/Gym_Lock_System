Public Class frm_login


    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        img_vizualizar_senha.Visible = False
        img_modo_noturno.Visible = False
        MostraTextoObj(img_esqueceu_senha, "Esqueceu sua senha?")
        MostraTextoObj(img_entrar, "Entrar")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_login_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub img_esqueceu_senha_DoubleClick(sender As Object, e As EventArgs) Handles img_esqueceu_senha.DoubleClick
        Me.Hide()
        frm_esqueceu_senha.Show()
    End Sub

    Private Sub img_sair_Click(sender As Object, e As EventArgs) Handles img_sair.Click
        fadeOut(Me)
        Me.Close()
    End Sub

    Private Sub img_vizualizar_senha_Click(sender As Object, e As EventArgs) Handles img_vizualizar_senha.Click
        img_nao_senha.Visible = True
        img_vizualizar_senha.Visible = False
        txt_senha.PasswordChar = "•"
    End Sub

    Private Sub img_nao_senha_Click(sender As Object, e As EventArgs) Handles img_nao_senha.Click
        img_nao_senha.Visible = False
        img_vizualizar_senha.Visible = True
        txt_senha.PasswordChar = ""
    End Sub

    Private Sub img_modo_noturno_Click(sender As Object, e As EventArgs) Handles img_modo_noturno.Click
        img_modo_noturno.Visible = False
        img_modo_diurno.Visible = True
    End Sub

    Private Sub img_modo_diurno_Click(sender As Object, e As EventArgs) Handles img_modo_diurno.Click
        img_modo_noturno.Visible = True
        img_modo_diurno.Visible = False
    End Sub

    Private Sub img_esqueceu_senha_Click(sender As Object, e As EventArgs) Handles img_esqueceu_senha.Click
        Me.Hide()
        Dim frm = New frm_esqueceu_senha
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_entrar_Click(sender As Object, e As EventArgs) Handles img_entrar.Click
        Dim email As String

        data = Today()
        horario_entrada = TimeOfDay()

        If txt_login.Text = "" Or
            txt_senha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            If txt_login.Text = "admin" And txt_senha.Text = "admin" Then
                funcao = "ADMIN"
                Me.Hide()
                Call carregar_voltar()
                frm_admin.ShowDialog()
            End If

            SQL = "select * from tb_login where (usuario='" & txt_login.Text & "' or email='" & txt_login.Text & "') and senha='" & txt_senha.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                nome_usuario = rs.Fields(1).Value
                email = rs.Fields(2).Value
                funcao = rs.Fields(5).Value
                status_conta = rs.Fields(6).Value

                If status_conta = "ATIVA" And funcao = "RECEPCIONISTA" Then
                    MsgBox("Conta logada com sucesso!" + vbNewLine &
                               "Bem-Vindo " & nome_usuario & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    Call ocultar_voltar()
                    frm_recepcionista.ShowDialog()
                ElseIf status_conta = "ATIVA" And funcao = "FISIOTERAPEUTA" Then
                    MsgBox("Conta logada com sucesso!" + vbNewLine &
                              "Bem-Vindo " & nome_usuario & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    Call ocultar_voltar()
                    frm_fisioterapeuta.ShowDialog()
                ElseIf status_conta = "ATIVA" And funcao = "NUTRICIONISTA" Then
                    MsgBox("Conta logada com sucesso!" + vbNewLine &
                              "Bem-Vindo " & nome_usuario & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    Call ocultar_voltar()
                    frm_nutricionista.ShowDialog()
                ElseIf status_conta = "ATIVA" And funcao = "INSTRUTOR" Then
                    MsgBox("Conta logada com sucesso!" + vbNewLine &
                              "Bem-Vindo " & nome_usuario & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    Call ocultar_voltar()
                    frm_instrutor.ShowDialog()
                ElseIf status_conta = "BLOQUEADO" Then
                    MsgBox("Conta bloqueada! Contate o administrador", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
                    Me.Close()
                End If

                'perguntar como fazer insert em tabelas que estão relacionadas
                'SQL = "insert into tb_controle_login (data,horario_entrada) values ('" & data & "','" & horario_entrada & "')"
                ' rs = db.Execute(UCase(SQL))

            Else
                MsgBox("Conta Invalida ou Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")
            End If
        End If

        txt_login.Clear()
        txt_senha.Clear()
        txt_login.Focus()
    End Sub
End Class