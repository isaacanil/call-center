Imports System
Imports System.Collections

Namespace Core.Domain.Logs
    Public Class LogErrorWrite
        Public Sub WriteLog(fecha As String, mensaje As String, origen As String, funcion As String)
            Try
                Using file As System.IO.StreamWriter = New System.IO.StreamWriter("Logs\LogError.txt", True)
                    file.WriteLine(fecha & " | " & mensaje & " | " & origen & " | " & funcion)
                    file.Close()
                End Using
            Catch ex As Exception
                Throw New Exception("Error en logs", ex)
            End Try
        End Sub
    End Class
End Namespace