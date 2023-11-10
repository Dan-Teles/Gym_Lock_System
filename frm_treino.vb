Public Class frm_treino
    Private Sub frm_treino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_semana()
        carregar_patologia()
        carregar_objetivos()

        lbl_patologia.Visible = False
        txt_patologia.Visible = False

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_treino_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        Dim frm = New frm_instrutor
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub rbt_sim_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_sim.CheckedChanged
        If rbt_sim.Checked = True Then
            lbl_patologia.Visible = True
            txt_patologia.Visible = True
        End If
    End Sub


    Private Sub img_apagar_Click(sender As Object, e As EventArgs) Handles img_apagar.Click
        resp = MsgBox("Deseja apagar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            txt_peito.Text = ""
            txt_costas.Text = ""
            txt_pernas.Text = ""
            txt_ombros.Text = ""
            txt_biceps.Text = ""
            txt_triceps.Text = ""
            txt_peito.Focus()
        End If

    End Sub


    Private Sub img_registrar_treino_Click(sender As Object, e As EventArgs) Handles img_registrar_treino.Click
        SQL = "select * from tb_treino where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)
        
        resp = MsgBox("Deseja salvar as alteraçoes no treino?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbYes Then
            If rs.EOF = True Then
                SQL = "insert into tb_treino (cliente, objetivos, patologia, local_patologia, peito, costas, pernas, ombros, biceps, triceps) values ('" & txt_cliente.Text & "', " &
                   "'" & cmb_objetivos.Text & "', '" & cmb_apresenta_patologia.Text & "','" & txt_patologia.Text & "', " &
                   "'" & txt_peito.Text & "', " &
                   "'" & txt_costas.Text & "',  '" & txt_pernas.Text & "', " &
                   "'" & txt_ombros.Text & "',  '" & txt_biceps.Text & "', " &
                   "'" & txt_triceps.Text & "')"

                rs = db.Execute(UCase(SQL))
                MsgBox("Treino cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_treino()
            Else
                SQL = "update tb_treino objetivos = '" & cmb_objetivos.Text & "', " &
                                                      "patologia = '" & cmb_apresenta_patologia.Text & "', " &
                                                      "local_patologia='" & txt_patologia.Text & "'," &
                                                      "peito='" & txt_peito.Text & "'," &
                                                      "costas='" & txt_costas.Text & "'," &
                                                      "pernas='" & txt_pernas.Text & "'," &
                                                      "ombros='" & txt_ombros.Text & "'," &
                                                      "biceps='" & txt_biceps.Text & "'," &
                                                      "triceps='" & txt_triceps.Text & "'," &
                                                      "'where cliente='" & txt_cliente.Text & "'"

                rs = db.Execute(UCase(SQL))
                MsgBox("Treino atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_treino()
            End If
        End If
    End Sub

    Private Sub cmb_apresenta_patologia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_apresenta_patologia.SelectedIndexChanged
        If cmb_apresenta_patologia.Text = "SIM" Then
            lbl_patologia.Visible = True
            txt_patologia.Visible = True
        Else
            lbl_patologia.Visible = False
            txt_patologia.Visible = False
            txt_patologia.Text = "NAO APRESENTA"
        End If

    End Sub

    Private Sub txt_cliente_Leave(sender As Object, e As EventArgs) Handles txt_cliente.Leave
        SQL = "select * from tb_treino where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            cmb_objetivos.Text = rs.Fields(2).Value
            txt_patologia.Text = rs.Fields(3).Value
            txt_peito.Text = rs.Fields(5).Value
            txt_costas.Text = rs.Fields(6).Value
            txt_pernas.Text = rs.Fields(7).Value
            txt_ombros.Text = rs.Fields(8).Value
            txt_biceps.Text = rs.Fields(9).Value
            txt_triceps.Text = rs.Fields(10).Value

        Else
            cmb_objetivos.ResetText()
            txt_peito.Text = ""
            txt_costas.Text = ""
            txt_pernas.Text = ""
            txt_ombros.Text = ""
            txt_biceps.Text = ""
            txt_triceps.Text = ""
        End If
    End Sub


End Class