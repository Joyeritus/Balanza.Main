Imports System.IO
Imports System.Net.Sockets

Public Class WS_Client  ' Clase que identifica al objeto cliente
    Private _client As TcpClient
    Private data() As Byte
    Public Shared Event whocon(ByVal whoConnected As String)
    Public Shared Event whodiscon(ByVal whoDisconnected As String)
    Public Shared Event datain(ByVal datain As String)

    Public Shared WS_Conect As New Hashtable 'Keeps track for all active connections - IP:port

    Public messageReceived As String
    Public whoDisconnected As String
    Public whoConnected As String

    Private _clientIP As String

    Public Sub New(ByVal client As TcpClient)

        _client = client
        _clientIP = client.Client.RemoteEndPoint.ToString

        WS_Conect.Add(_clientIP, Me) ' Actualiza Hash Table. ' SyncLock es necesario
        Me.whoConnected = _clientIP

        'SyncLock Form1.whoConnected
        '    Form1.whoConnected = Me.whoConnected
        'End SyncLock
        RaiseEvent whocon(whoConnected)

        ReDim data(_client.ReceiveBufferSize - 1)
        _client.GetStream.BeginRead(data, 0, CInt(_client.ReceiveBufferSize), AddressOf ReceiveMessage, Nothing)

    End Sub

    Public Sub ReceiveMessage(ByVal ar As IAsyncResult)
        Dim bytesRead As Integer
        Dim messageReceived As String = ""
        Try
            SyncLock _client.GetStream
                bytesRead = _client.GetStream.EndRead(ar)
            End SyncLock
            If bytesRead < 1 Then ' Remote Client closed connection

                _client.Close() ' Este comando es necessario

                WS_Conect.Remove(_clientIP) ' actualiza Hash Table. ' SyncLock es necesario
                Me.whoDisconnected = _clientIP

                _clientIP = Nothing

                'SyncLock Form1.whoDisconnected
                '    Form1.whoDisconnected = Me.whoDisconnected
                'End SyncLock
                RaiseEvent whodiscon(whoDisconnected)

                Exit Sub

            Else

                Dim j As Integer
                For j = 0 To bytesRead - 1
                    messageReceived &= Chr(Val(data(j).ToString))
                Next
                SendMessage(messageReceived)

                SyncLock _client.GetStream  'Read next packet of data from remote client
                    _client.GetStream.BeginRead(data, 0, CInt(_client.ReceiveBufferSize), AddressOf ReceiveMessage, Nothing)
                End SyncLock

            End If

        Catch
        REM ex As Exception

        End Try

    End Sub

    Public Sub SendMessage(ByVal message As String)

        If message.Trim.ToUpper = "P" Then
           Try

               Dim ns As System.Net.Sockets.NetworkStream

               SyncLock _client.GetStream
                   ns = _client.GetStream
                   Dim bytesToSend As Byte()
                   Dim cWeightSend As String = Chr(2) & Chr(32) & cPesoDescontado & Chr(32) & vbCr
                   bytesToSend = System.Text.Encoding.ASCII.GetBytes(cWeightSend)
                   ns.Write(bytesToSend, 0, bytesToSend.Length)
                   ns.Flush()
               End SyncLock
           Catch
           REM ex As Exception

           End Try
        End If

    End Sub

End Class

