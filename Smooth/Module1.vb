Imports System.Data.Odbc
Module Module1
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public sql As String
    Public x As Integer
    Public Monto As Double
    Public MontoProd As Double
    Public IdPersona As Integer
    Public DniPersona As String
    Public IdProd As Integer
    Public FormaPago As String

    Public Function conectar()
        Try
            cnn = New OdbcConnection("DSN=smooth")

            cnn.Open()

            MsgBox("La conexion se desarrollo con exito", , "Estado de la Conexion")

        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & "Falla de la conexión con la Base de Datos", , "Sin conexión")

        End Try

        Return 0

    End Function

 
    Public Sub Proc(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

    End Sub

    Public Sub Proc1(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs1 = cmd.ExecuteReader
        cmd.Dispose()

    End Sub
End Module
