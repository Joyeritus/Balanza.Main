Imports System.IO
Imports System.Net.Sockets

Public Class SirionClient  ' The class that instatiates the client objects. The name SirionClient already explained in Form1.vb

    Private _client As TcpClient
    Private data() As Byte
    Private fs1 As StreamWriter

    Public Shared Event whocon(ByVal whoConnected As String)
    Public Shared Event whodiscon(ByVal whoDisconnected As String)
    Public Shared Event datain(ByVal datain As String)

    Public Shared AllSirions As New Hashtable 'Keeps track for all active connections - IP:port

    Public Shared wait_aSec As String = "I ROBOT"

    Public messageReceived As String
    Public whoDisconnected As String
    Public whoConnected As String

    Private _clientIP As String




    Public Sub New(ByVal client As TcpClient)

        _client = client
        _clientIP = client.Client.RemoteEndPoint.ToString

        AllSirions.Add(_clientIP, Me) ' Update of the Hash Table. ' SyncLock may be needed here
        Me.whoConnected = _clientIP

        'SyncLock Form1.whoConnected
        '    Form1.whoConnected = Me.whoConnected
        'End SyncLock
        RaiseEvent whocon(whoConnected)

        ReDim data(_client.ReceiveBufferSize - 1) 'Socket's Buffer reading starts here.
        _client.GetStream.BeginRead(data, 0, CInt(_client.ReceiveBufferSize), AddressOf ReceiveMessage, Nothing)

    End Sub

    Public Sub ReceiveMessage(ByVal ar As IAsyncResult)

        Dim bytesRead As Integer
        Dim messageReceived As String = ""


        Try
            SyncLock _client.GetStream
                bytesRead = _client.GetStream.EndRead(ar)
            End SyncLock

            If bytesRead < 1 Then ' Remote Client closed connection !!! NOT QUITE, NOT ALWAYS

                _client.Close() ' So this command is needed, as I explain in the FORM1.vb initial comments.

                AllSirions.Remove(_clientIP) ' Update of the Hash Table. ' SyncLock may be needed here
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
                    'messageReceived &= data(j).ToString.PadLeft(2, "0") & " "
                    messageReceived &= Chr(Val(data(j).ToString))
                Next

                'If messageReceived = "" Then
                '    messageReceived = " "
                'End If

                SendMessage(messageReceived)

                'Try
                '    ProcessMessage(messageReceived, _clientIP)
                'Catch ex As Exception

                'End Try

                SyncLock _client.GetStream  'Read next packet of data from remote client
                    _client.GetStream.BeginRead(data, 0, CInt(_client.ReceiveBufferSize), AddressOf ReceiveMessage, Nothing)
                End SyncLock

            End If

        Catch ex As Exception
            ' Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Sub SendMessage(ByVal message As String)

        ' Here you can pass any message you want to send it to the remote client, but in my project, the remote
        ' hardware Net Modules named SIRIONs, as we have already said, wait for the following specific byte
        ' stream in order to continue sending their data. 
If message.Trim = "P" Then
        Try
            Dim ns As System.Net.Sockets.NetworkStream

            SyncLock _client.GetStream
                ns = _client.GetStream
                ' End SyncLock  ' May also be placed here [ Any remarks on this from anyone ? ]
                ' There are a lot that could be said here regarding to which chunk of code the SyncLock 
                ' may include
                Dim bytesToSend As Byte()
                Dim cWeightSend As String = Chr(2) & cPeso & vbCr
                bytesToSend = System.Text.Encoding.ASCII.GetBytes(cWeightSend)

                'Dim bytesToSend As [Byte]() = {10, 10, 10, 0, 30, 0, 38, 0, 0, 2, 216, 48}
                ns.Write(bytesToSend, 0, bytesToSend.Length)
                ns.Flush()

            End SyncLock
        Catch ex As Exception
            ' Console.WriteLine(ex.ToString)
        End Try
End If

    End Sub

    Public Sub ProcessMessage(ByVal str As String, ByVal theIP As String)

        Dim SIG_DATE As String = Now().ToString("ddMMyy")
        Dim SIG_TIME As String = Now().ToString("HH:mm:ff")
        Dim DAQ_code As String = "" ' here you can store the meaningful data after whatever translation of the "str"
        Dim byteSTR As String = ""

        RaiseEvent datain(theIP & " <---> " & str)

        byteSTR = theIP & " <---> " & str & vbCrLf

        'If recording.globalRec = 1 And False Then ' Historic Recordings ON

        '    SyncLock wait_aSec

        '        While True
        '            If File.Exists("c:\DATA\WAIT-HIS") Then  'An old but VERY efficient technique to lock files for exclusive write
        '                ' I'm locked
        '            Else
        '                Try
        '                    fs1 = File.CreateText("c:\DATA\WAIT-HIS") ' I lock the others
        '                    fs1.Close()
        '                    fs1 = Nothing

        '                    If File.Exists("C:\DATA\DAQ_DATA.HIS") = False Then
        '                        fs1 = File.CreateText("C:\DATA\DAQ_DATA.HIS")
        '                        fs1.Close()
        '                        fs1 = Nothing
        '                    End If

        '                    fs1 = File.AppendText("C:\DATA\DAQ_DATA.HIS")
        '                    fs1.Write(byteSTR)
        '                    fs1.Close()
        '                    fs1 = Nothing
        '                    File.Delete("C:\DATA\WAIT-HIS") 'I release the lock
        '                    ' or KILL("C:\DATA\WAIT-HIS")
        '                Catch ex As Exception
        '                    MsgBox(Application.ProductName & "     " & ex.ToString)
        '                End Try
        '                Exit While
        '            End If
        '        End While

        '    End SyncLock

        'End If


    End Sub


End Class

