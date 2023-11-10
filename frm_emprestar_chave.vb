Public Class frm_emprestar_chave
    Private Sub frm_emprestar_chave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        MostraTextoObj(img_emprestar_chave, "Emprestar chave")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_emprestar_chave_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        Dim frm = New frm_recepcionista
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_emprestar_chave_Click(sender As Object, e As EventArgs) Handles img_emprestar_chave.Click

    End Sub
End Class