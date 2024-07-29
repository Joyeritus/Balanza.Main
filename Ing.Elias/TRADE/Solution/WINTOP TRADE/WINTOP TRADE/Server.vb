Imports System.Net
Imports System.Net.Sockets
Imports System.Data
Imports System.Data.Common
Imports System.IO.Ports
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic
Public Class Module1  ' The SOCKET LISTENER SERVER

    REM Const localTCP_Port = 8005 ' Or whatever port you like above 2048 
    Const localTCP_Port = 5000 ' Or whatever port you like above 2048 

    Public Sub mainListen()

        Dim locIP_toStart As String = ""
        Dim ee As String = String.Empty
        ee = Application.ProductName.ToString
        'If Application.ProductName.ToString = "SIRION-1" Then     'Here we use the technique we described in detail in 
        If Application.ProductName.ToString = "DYNASERVER" Then     'Here we use the technique we described in detail in 
            REM locIP_toStart = "192.168.1.120"                        'Form1.vb, to discriminate on which IP/card to bind 
            REM locIP_toStart = GetIp()
            locIP_toStart = "127.0.0.1"

        ElseIf Application.ProductName.ToString = "SIRION-2" Then 'the running binary of our application  
            locIP_toStart = "10.10.10.20"
        End If
        locIP_toStart = Form1.txtIp.Text
        Dim localIP_Address As System.Net.IPAddress = System.Net.IPAddress.Parse(locIP_toStart)
        Dim listener As New System.Net.Sockets.TcpListener(localIP_Address, localTCP_Port)

        listener.Start() ' Server is started and is ready for Sockets Creation 

        While True  ' Endless loop of this thread that waits for remote clients connection requests
            Dim sirion As New SirionClient(listener.AcceptTcpClient) ' When remote connection request happens, then the
        End While                                                    ' new OBJECT Client named "sirion" is created from 
        '                                                            ' the SirionClient Class
    End Sub


'Public Function getIp() As String

'       Dim valorIp As String

'        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()

'        Return valorIp

'    End
'End Function
'Public Function GetIp() As String
'Dim ip As System.Net.IPHostEntry
'ip = Dns.GetHostEntry(My.Computer.Name)
'GetIp = ip.AddressList(0).ToString
'End Function
''Private Function dameIP() As String


'        Dim nombrePC As String
'        Dim entradasIP As Net.IPHostEntry

'        nombrePC = Dns.GetHostName

'        entradasIP = Dns.GetHostByName(nombrePC)

'        Dim direccion_Ip As String = entradasIP.AddressList(0).ToString

'        Return direccion_Ip

'    End Function




End Class



