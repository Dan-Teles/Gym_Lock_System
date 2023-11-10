Public Class frm_esqueceu_senha

    Dim senha, palavra_chave As String
    Private Sub frm_esqueceu_senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        MostraTextoObj(img_recuperar_senha, "Recuperar senha")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

        img_recuperar_senha.Enabled = False
    End Sub

    Private Sub frm_esqueceu_senha_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub img_voltar_Click(sender As Object, e As EventArgs) Handles img_voltar.Click
        fadeOut(Me)
        Dim frm = New frm_login
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_recuperar_senha_Click(sender As Object, e As EventArgs) Handles img_recuperar_senha.Click
        If (UCase(txt_palavra_chave.Text) <> palavra_chave) Then
            MsgBox("Palavra chave não confere com a cadastrada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_palavra_chave.Clear()
            txt_palavra_chave.Focus()
        Else
            MsgBox("Usuario: " & txt_user_email.Text & "" + vbNewLine &
                       "Senha: " & senha & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            fadeOut(Me)
            Dim frm = New frm_login
            frm.Show()
            fadeIn(frm)
        End If
    End Sub

    Private Sub txt_user_email_LostFocus(sender As Object, e As EventArgs) Handles txt_user_email.LostFocus
        SQL = "select * from tb_login where usuario='" & txt_user_email.Text & "' or email='" & txt_user_email.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            img_recuperar_senha.Enabled = True
            senha = rs.Fields(3).Value
            palavra_chave = rs.Fields(4).Value
        Else
            MsgBox("Usuario não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            img_recuperar_senha.Enabled = False
            txt_user_email.Clear()
            txt_user_email.Focus()
        End If
    End Sub
End Class