Public Class frm_fisioterapeuta
    Private Sub frm_fisioterapeuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        'ToolTip para os ícones
        MostraTextoObj(img_atendimento, "Iniciar Atendimento")
        MostraTextoObj(img_agendamentos, "Agendamentos")
        MostraTextoObj(img_relatorios, "Relatório do paciente")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

    End Sub
    Private Sub img_voltar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frm = New frm_recepcionista
        frm.Show()
        fadeIn(frm)
    End Sub
    Private Sub frm_fisioterapeuta_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub img_sair_Click(sender As Object, e As EventArgs) Handles img_sair.Click
        fadeOut(Me)
        Dim frm = New frm_login
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_adm_Click(sender As Object, e As EventArgs) Handles img_adm.Click
        fadeOut(Me)
        Dim frm = New frm_admin
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_atendimento_Click(sender As Object, e As EventArgs) Handles img_atendimento.Click
        fadeOut(Me)
        Dim frm = New frm_fisioterapeuta_atendimento
        frm.Show()
        fadeIn(frm)
    End Sub
End Class