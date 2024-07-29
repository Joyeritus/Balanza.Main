Imports System.Net.Sockets

Public Class Module1  ' The SOCKET LISTENER SERVER

    Const localTCP_Port = 8005 ' Or whatever port you like above 2048 

    Public Sub mainListen()

        Dim locIP_toStart As String = ""

        If Application.ProductName.ToString = "SIRION-1" Then     'Here we use the technique we described in detail in 
            locIP_toStart = "192.168.1.20"                        'Form1.vb, to discriminate on which IP/card to bind 
        ElseIf Application.ProductName.ToString = "SIRION-2" Then 'the running binary of our application  
            locIP_toStart = "10.10.10.20"
        End If

        Dim localIP_Address As System.Net.IPAddress = System.Net.IPAddress.Parse(locIP_toStart)
        Dim listener As New System.Net.Sockets.TcpListener(localIP_Address, localTCP_Port)

        listener.Start() ' Server is started and is ready for Sockets Creation 

        While True  ' Endless loop of this thread that waits for remote clients connection requests
            Dim sirion As New SirionClient(listener.AcceptTcpClient) ' When remote connection request happens, then the
        End While                                                    ' new OBJECT Client named "sirion" is created from 
        '                                                            ' the SirionClient Class
    End Sub


End Class



