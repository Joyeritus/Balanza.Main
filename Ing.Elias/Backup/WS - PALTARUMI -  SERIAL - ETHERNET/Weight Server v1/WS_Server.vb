Imports System.Net
Imports System.Net.Sockets

Public Class WS_Module_Server  '  SOCKET LISTENER SERVER
    Public Sub mainListen()
        Dim locIP_toStart As String = String.Empty
        Dim localIP_Address As System.Net.IPAddress = System.Net.IPAddress.Parse(gServer_IP)
        Dim listener As New System.Net.Sockets.TcpListener(localIP_Address, gServer_Port)
        listener.Start() ' Inicia servidor y esta listo para a creacion denuevos sockets 
        While True
            Dim WS_Servidor As New WS_Client(listener.AcceptTcpClient)
        End While
        '                                                           
    End Sub

End Class



