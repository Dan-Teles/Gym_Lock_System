Public Class frm_bioimpedancia
    Private Sub Bioimpedancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conecta_banco()
        MostraTextoObj(img_bio, "Registrar bioimpedância")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub Bioimpedancia_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        Dim frm = New frm_nutricionista
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub img_bio_Click(sender As Object, e As EventArgs) Handles img_bio.Click
        SQL = "select * from tb_bioimpedancia where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)

        resp = MsgBox("Deseja salvar as alteraçoes na bioimpedância?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbYes Then
            If rs.EOF = True Then
                SQL = "insert into tb_bioimpedancia (cliente, altura, peso, massa_magra, gordura_corporal, massa_magra_porc, gordura_corporal_porc, gordura_visceral) values ('" & txt_cliente.Text & "', " &
                   "'" & txt_altura.Text & "','" & txt_peso.Text & "', " &
                   "'" & txt_massa_magra.Text & "', " &
                   "'" & txt_gordura_corporal.Text & "',  '" & txt_massa_magra_porcentagem.Text & "', " &
                   "'" & txt_gordura_corporal_porcentagem.Text & "',  '" & txt_gordura_visceral.Text & "')"

                rs = db.Execute(UCase(SQL))
                MsgBox("Bioimpedância cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_treino()
            Else
                SQL = "update tb_bioimpedancia altura = '" & txt_altura.Text & "', " &
                                                      "peso='" & txt_peso.Text & "'," &
                                                      "massa_magra='" & txt_massa_magra.Text & "'," &
                                                      "gordura_corporal='" & txt_gordura_corporal.Text & "'," &
                                                      "massa_magra_porc='" & txt_massa_magra_porcentagem.Text & "'," &
                                                      "gordura_corporal_porc='" & txt_gordura_corporal_porcentagem.Text & "'," &
                                                      "gordura_visceral='" & txt_gordura_visceral.Text & "'," &
                                                      "'where cliente='" & txt_cliente.Text & "'"

                rs = db.Execute(UCase(SQL))
                MsgBox("Bioimpedância atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_treino()
            End If
        End If
    End Sub

    Private Sub txt_cliente_Leave(sender As Object, e As EventArgs) Handles txt_cliente.Leave
        SQL = "select * from tb_bioimpedancia where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            txt_cliente.Text = rs.Fields(1).Value
            txt_altura.Text = rs.Fields(2).Value
            txt_peso.Text = rs.Fields(3).Value
            txt_massa_magra.Text = rs.Fields(4).Value
            txt_gordura_corporal.Text = rs.Fields(5).Value
            txt_massa_magra_porcentagem.Text = rs.Fields(6).Value
            txt_gordura_corporal_porcentagem.Text = rs.Fields(7).Value
            txt_gordura_visceral.Text = rs.Fields(8).Value
        Else
            txt_altura.Text = ""
            txt_peso.Text = ""
            txt_massa_magra.Text = ""
            txt_gordura_corporal.Text = ""
            txt_massa_magra_porcentagem.Text = ""
            txt_gordura_corporal_porcentagem.Text = ""
            txt_gordura_visceral.Text = ""
        End If
    End Sub
End Class