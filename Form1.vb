Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEntrada.Text = "4.124*(5+6.1781*(8/2^3)-7)-1"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entrada As String = txtEntrada.Text
        'Proceso de análisis léxico
        Dim lex As AnalizadorLexico = New AnalizadorLexico()
        Dim lTokens As List(Of Token) = lex.escanear(entrada)
        'Luego del analisis léxico obtenemos como salida una lista de tokens
        'en este caso es lTokens, ahora procedemos a imprimirla para mostrar en 
        'consola su contenido.
        lex.imprimirLista(lTokens)

    End Sub
End Class
