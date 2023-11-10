﻿Public Class frm_nutricionista
    Private Sub frm_nutricionista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        MostraTextoObj(img_dieta, "Dietas")
        MostraTextoObj(img_bio, "Bioimpedância")
        MostraTextoObj(img_relatorios, "Relatórios")
        MostraTextoObj(img_agendamentos, "Agendamentos")


        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_nutricionista_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub img_sair_Click_1(sender As Object, e As EventArgs) Handles img_sair.Click
        resp = MsgBox("Deseja fazer logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Logout")
        If resp = vbYes Then
            fadeOut(Me)
            Dim frm = New frm_login
            frm.Show()
            fadeIn(frm)
        End If
    End Sub

    Private Sub img_atribuir_dieta_Click(sender As Object, e As EventArgs)
        fadeOut(Me)
        Dim frm = New frm_dieta
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_adm_Click(sender As Object, e As EventArgs) Handles img_adm.Click
        fadeOut(Me)
        Dim frm = New frm_admin
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_bio_Click(sender As Object, e As EventArgs) Handles img_bio.Click
        fadeOut(Me)
        Dim frm = New frm_bioimpedancia
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_dieta_Click(sender As Object, e As EventArgs) Handles img_dieta.Click
        fadeOut(Me)
        Dim frm = New frm_dieta
        frm.Show()
        fadeIn(frm)
    End Sub
End Class