Public Class frm_fisioterapeuta_atendimento
    Private Sub frm_fisioterapeuta_atendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_atendimentos()
        carregar_lesao()


        lbl_grupo_muscular.Visible = False
        lbl_observacao.Visible = False
        txt_patologia.Visible = False
        txt_observacao.Visible = False
        img_info.Visible = False

        MostraTextoObj(img_info, "Descreva a lesão ou patologia")
        MostraTextoObj(img_registrar, "Registrar")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_fisioterapeuta_atendimento_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        Dim frm = New frm_fisioterapeuta
        frm.Show()
        fadeIn(frm)
    End Sub

    Private Sub cmb_apresenta_patologia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_patologia.SelectedIndexChanged
        If cmb_patologia.Text = "NÃO" Then
            lbl_grupo_muscular.Visible = False
            lbl_observacao.Visible = False
            txt_patologia.Visible = False
            txt_observacao.Visible = False
            img_info.Visible = False
            img_preencher.Visible = True
            txt_patologia.Text = "NÃO APRESENTA"
            txt_observacao.Text = "NÃO APRESENTA"

        Else
            lbl_grupo_muscular.Visible = True
            lbl_observacao.Visible = True
            txt_patologia.Visible = True
            txt_observacao.Visible = True
            img_info.Visible = True
            img_preencher.Visible = True
        End If
    End Sub

    Private Sub img_registrar_Click(sender As Object, e As EventArgs) Handles img_registrar.Click
        SQL = "select * from tb_atendimento_fisio where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)

        resp = MsgBox("Deseja salvar as alterações no formulário?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbYes Then
            If rs.EOF = True Then
                SQL = "insert into tb_atendimento_fisio (cliente, atendimento, patologia, agrupamento, observacao) values ('" & txt_cliente.Text & "', " &
                   "'" & cmb_atendimento.Text & "','" & cmb_patologia.Text & "', " &
                   "'" & txt_patologia.Text & "', " &
                   "'" & txt_observacao.Text & "')"

                rs = db.Execute(UCase(SQL))
                MsgBox("Formulário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_atendimento_fisio()
            Else
                SQL = "update tb_atendimento_fisio atendimento = '" & cmb_atendimento.Text & "', " &
                                                      "patologia='" & cmb_patologia.Text & "'," &
                                                      "agrupamento='" & txt_patologia.Text & "'," &
                                                      "observacao='" & txt_observacao.Text & "'," &
                                                      "'where cliente='" & txt_cliente.Text & "'"

                rs = db.Execute(UCase(SQL))
                MsgBox("Formulário atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_atendimento_fisio()
            End If
        End If
    End Sub

    Private Sub txt_cliente_Leave(sender As Object, e As EventArgs) Handles txt_cliente.Leave
        SQL = "select * from tb_atendimento_fisio where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            cmb_atendimento.Text = rs.Fields(2).Value
            cmb_patologia.Text = rs.Fields(3).Value
            txt_patologia.Text = rs.Fields(4).Value
            txt_observacao.Text = rs.Fields(5).Value
        Else
            cmb_atendimento.ResetText()
            cmb_patologia.ResetText()
            txt_patologia.Text = ""
            txt_observacao.Text = ""
        End If
    End Sub

    Private Sub cmb_atendimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_atendimento.SelectedIndexChanged

    End Sub
End Class