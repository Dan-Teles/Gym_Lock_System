Imports System.Threading

Module Module1
    Public SQL, resp, status_conta, funcao, nome_usuario, foto_cliente As String
    Public cliente, cafe_manha, almoco, cafe_tarde, jantar As String
    Public data, horario_entrada, horario_saida As DateTime
    Public cont As Integer
    Public db As New ADODB.Connection 'Variável de BD
    Public rs As New ADODB.Recordset 'Variável de TB
    Public dirbanco = Application.StartupPath & "\banco_dados\BancoDados.mdb"

    Public Sub fadeIn(frm As Form)
        For i = 0 To 1 Step 0.2
            frm.Opacity = i
            frm.Refresh()
            Thread.Sleep(50)
        Next
    End Sub

    Public Sub fadeOut(frm As Form)
        For i = 1 To 0 Step -0.2
            frm.Opacity = i
            frm.Refresh()
            Thread.Sleep(50)
        Next
    End Sub


    Sub conecta_banco()
        Try
            'String de Conexão com o Banco de Dados - MSAccess
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco de dados" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_planos()
        Try
            With frm_recepcionista.cmb_planos.Items
                .Add("COMUM")
                .Add("BLACK")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar planos" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub carregar_objetivos()
        Try
            With frm_treino.cmb_objetivos.Items
                .Add("HIPERTROFIA")
                .Add("EMAGRECIMENTO")
                .Add("CONDICIONAMENTO")
                .Add("BEM ESTAR")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar planos" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_profissionais()
        Try
            With frm_recepcionista.cmb_profissional.Items
                .Add("FISIOTERAPEUTA")
                .Add("NUTRICIONISTA")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar profissionais" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_atendimentos()
        With frm_fisioterapeuta_atendimento.cmb_atendimento.Items
            .Add("LIBERAÇÃO MIOFASCIAL")
            .Add("VENTOSO TERAPIA")
            .Add("ALONGAMENTO")
            .Add("MASSAGEM RELAXANTE")
        End With
    End Sub
    Sub carregar_lesao()
        With frm_fisioterapeuta_atendimento.cmb_patologia.Items
            .Add("SIM")
            .Add("NÃO")
        End With
    End Sub

    Sub MostraTextoObj(objeto As Control, mensagem As String)
        Dim tooltip1 As New ToolTip()
        tooltip1.AutoPopDelay = 3000
        tooltip1.InitialDelay = 700
        tooltip1.ReshowDelay = 500
        tooltip1.ShowAlways = True
        tooltip1.SetToolTip(objeto, mensagem)
    End Sub

    Sub fechar_aplicação()
        resp = MsgBox("Deseja encerrar a Aplicação ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            horario_saida = TimeOfDay
            SQL = "update tb_controle_login set horario_saida ='" & horario_saida & "' where"
        End If
    End Sub

    Sub carregar_voltar()
        frm_fisioterapeuta.img_adm.Visible = True
        frm_recepcionista.img_adm.Visible = True
        frm_nutricionista.img_adm.Visible = True
        frm_instrutor.img_adm.Visible = True
    End Sub

    Sub ocultar_voltar()
        frm_fisioterapeuta.img_adm.Visible = False
        frm_recepcionista.img_adm.Visible = False
        frm_nutricionista.img_adm.Visible = False
        frm_instrutor.img_adm.Visible = False
    End Sub

    Sub carregar_dados_clientes()
        SQL = "select * from tb_clientes order by cpf asc"
        rs = db.Execute(SQL)
        cont = 1
        With frm_recepcionista.dgv_dados_clientes
            .Rows.Clear()   'limpa
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(12).Value, Nothing, Nothing)    'armazena o CPF
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub carregar_armarios()
        SQL = "select * from tb_armarios order by id_armario asc"
        rs = db.Execute(SQL)
        cont = 1
        With frm_recepcionista.dgv_armarios
            .Rows.Clear()   'limpa
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, Nothing, Nothing, Nothing, Nothing)    'armazena o CPF
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Sub carregar_semana()
        With frm_treino
            .cmb_peito.Items.Add("SEGUNDA")
            .cmb_triceps.Items.Add("TERÇA")
            .cmb_pernas.Items.Add("QUARTA")
            .cmb_costas.Items.Add("QUINTA")
            .cmb_biceps.Items.Add("SEXTA")
            .cmb_ombros.Items.Add("SABADO")
        End With
    End Sub

    Sub carregar_patologia()
        With frm_treino.cmb_apresenta_patologia.Items
            .Add("SIM")
            .Add("NÃO")
        End With
    End Sub

    Sub carregar_funcao()
        Try
            With frm_cadastrar_funcionario.cmb_funcao.Items
                .Add("FISIOTERAPEUTA")
                .Add("NUTRICIONISTA")
                .Add("INSTRUTOR")
                .Add("RECEPCIONISTA")
                .Add("ADMINISTRADOR")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar profissionais" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Sub limpar_dieta()
        With frm_dieta
            .txt_cliente.Clear()
            .txt_cafe_manha.Clear()
            .txt_cafe_tarde.Clear()
            .txt_almoco.Clear()
            .txt_jantar.Clear()
        End With
    End Sub

    Sub limpar_treino()
        With frm_treino
            .txt_biceps.Clear()
            .txt_cliente.Clear()
            .txt_costas.Clear()
            .txt_ombros.Clear()
            .txt_patologia.Clear()
            .txt_peito.Clear()
            .txt_pernas.Clear()
            .txt_triceps.Clear()
            .txt_cliente.Clear()
            .txt_patologia.Clear()
            .txt_patologia.Hide()
            .cmb_apresenta_patologia.ResetText()
            .txt_cliente.Select()
        End With
    End Sub

    Sub limpar_atendimento_fisio()
        With frm_fisioterapeuta_atendimento
            .txt_cliente.Clear()
            .txt_observacao.Clear()
            .txt_patologia.Clear()
            .cmb_patologia.ResetText()
            .cmb_atendimento.ResetText()
            .txt_cliente.Select()
        End With
    End Sub

End Module
