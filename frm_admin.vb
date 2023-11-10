Public Class frm_admin
    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        MostraTextoObj(img_sair, "Logout")
        MostraTextoObj(img_fisioterapeuta, "Fisioterapeuta")
        MostraTextoObj(img_nutricionista, "Nutricionista")
        MostraTextoObj(img_recepcionista, "Recepcionista")
        MostraTextoObj(img_cadastrar_funcionario, "Cadastrar funcionário")
        MostraTextoObj(img_armarios, "Armários")
        MostraTextoObj(img_instrutor, "Professores")


    End Sub

    Private Sub frm_admin_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
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

    Private Sub img_nutricionista_Click(sender As Object, e As EventArgs) Handles img_nutricionista.Click
        fadeOut(Me)
        Dim frm = New frm_nutricionista
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_fisioterapeuta_Click(sender As Object, e As EventArgs) Handles img_fisioterapeuta.Click
        fadeOut(Me)
        Dim frm = New frm_fisioterapeuta
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_recepcionista_Click(sender As Object, e As EventArgs) Handles img_recepcionista.Click
        fadeOut(Me)
        Dim frm = New frm_recepcionista
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_adm_Click(sender As Object, e As EventArgs) Handles img_adm.Click

    End Sub

    Private Sub img_instrutor_Click(sender As Object, e As EventArgs) Handles img_instrutor.Click
        fadeOut(Me)
        Dim frm = New frm_instrutor
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_armarios_Click(sender As Object, e As EventArgs) Handles img_armarios.Click
        fadeOut(Me)
        Dim frm = New frm_emprestar_chave
        frm.Show()
        fadeIn(frm)
    End Sub
End Class