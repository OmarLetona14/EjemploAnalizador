Public Class Token
    Enum Tipo
        NUMERO_ENTERO
        NUMERO_REAL
        SIGNO_MAS
        SIGNO_MEN
        SIGNO_POR
        SIGNO_DIV
        SIGNO_POW
        PARENTESIS_IZQ
        PARENTESIS_DER
    End Enum

    Private tipoToken As Tipo
    Private valor As String
    Public Sub New(ByVal tipo As Tipo, ByVal auxLex As String)
        Me.tipoToken = tipo
        Me.valor = auxLex
    End Sub
    Public Function getValor() As String
        Return valor
    End Function
    Public Function getTipoEnString() As String
        Select Case tipoToken
            Case Tipo.NUMERO_ENTERO
                Return "Numero Entero "
            Case Tipo.NUMERO_REAL
                Return "Numero Real   "
            Case Tipo.SIGNO_MAS
                Return "Signo Mas     "
            Case Tipo.SIGNO_MEN
                Return "Signo Menos   "
            Case Tipo.SIGNO_POR
                Return "Signo Por     "
            Case Tipo.SIGNO_DIV
                Return "Signo Division"
            Case Tipo.SIGNO_POW
                Return "Signo Potencia"
            Case Tipo.PARENTESIS_IZQ
                Return "Parentesis Izq"
            Case Tipo.PARENTESIS_DER
                Return "Parentesis Der"
            Case Else
                Return "Desconocido   "
        End Select
    End Function
End Class
