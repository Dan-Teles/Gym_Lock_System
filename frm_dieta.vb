Public Class frm_dieta
    Private Sub frm_dieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        If txt_cliente.Text = "" Then
            txt_cafe_manha.Text = ""
            txt_almoco.Text = ""
            txt_cafe_tarde.Text = ""
            txt_jantar.Text = ""
        End If

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_dieta_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub img_apagar_Click(sender As Object, e As EventArgs) Handles img_apagar.Click
        resp = MsgBox("Deseja apagar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            txt_cafe_manha.Text = ""
            txt_almoco.Text = ""
            txt_cafe_tarde.Text = ""
            txt_jantar.Text = ""
            txt_cafe_manha.Focus()
        End If

    End Sub



    Private Sub img_registrar_dieta_Click(sender As Object, e As EventArgs) Handles img_registrar_dieta.Click
        SQL = "select * from tb_dieta where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)

        resp = MsgBox("Deseja salvar as alteraçoes na dieta?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbYes Then
            If rs.EOF = True Then
                SQL = "insert into tb_dieta (cliente, cafe_manha, almoco, cafe_tarde, jantar) values ('" & txt_cliente.Text & "','" & txt_cafe_manha.Text & "', '" & txt_almoco.Text & "','" & txt_cafe_tarde.Text & "', '" & txt_jantar.Text & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dieta cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_dieta()
                txt_cliente.Select()
            Else

                SQL = "update tb_dieta set cafe_manha='" & txt_cafe_manha.Text & "'," &
                                                      "almoco='" & txt_almoco.Text & "'," &
                                                      "cafe_tarde='" & txt_cafe_tarde.Text & "'," &
                                                      "jantar='" & txt_jantar.Text & "'where cliente='" & txt_cliente.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dieta atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Call limpar_dieta()
                txt_cliente.Select()
            End If
        End If
    End Sub


    Private Sub txt_cliente_Leave(sender As Object, e As EventArgs) Handles txt_cliente.Leave
        SQL = "select * from tb_dieta where cliente='" & txt_cliente.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then
            txt_cliente.Text = rs.Fields(1).Value
            txt_cafe_manha.Text = rs.Fields(2).Value
            txt_almoco.Text = rs.Fields(3).Value
            txt_cafe_tarde.Text = rs.Fields(4).Value
            txt_jantar.Text = rs.Fields(5).Value
        Else
            txt_cafe_manha.Text = ""
            txt_almoco.Text = ""
            txt_cafe_tarde.Text = ""
            txt_jantar.Text = ""
        End If
    End Sub
End Class