Module Module1
    Public diretorio, SQL,resp As String
    Public db As New ADODB.Connection 'Variável de BD
    Public rs As New ADODB.Recordset 'Variável de TB
    Public dirbanco = Application.StartupPath & "\banco_dados\cadastro.mdb"

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
            MsgBox("Conexão com banco de dados estabelecida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

End Module