Imports System.Text
Imports System.IO.Ports
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports System.Drawing
Imports System.Linq


Public Class FrmMain

  Inherits Form

  Private tcpListener As TcpListener
  Private listenThread As Thread
  Private Delegate Sub WriteMessageDelegate(ByVal msg As String)
  Public cNro_Ip As String = String.Empty
  Public nNro_Port As Int32 = 3000
  Public oIni As cIniArray = New cIniArray

  Public cVersion As String = "Weight server v1"
  Public cPath As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) & "\"
  Public cFileIni As String = cPath & "WEIGHT SERVER.INI"
  Public cPesoBalanza As String = "0"
  Dim cLee As String = String.Empty



 Public Sub New()
   InitializeComponent()
  End Sub

  Private Sub Server()
   Me.tcpListener = New TcpListener(IPAddress.Parse(cNro_Ip), nNro_Port) ' Change to IPAddress.Any for internet wide Communication
   Me.listenThread = New Thread(New ThreadStart(AddressOf ListenForClients))
   Me.listenThread.Start()
  End Sub



  Private Sub ListenForClients()
   Me.tcpListener.Start()

   Do

    Dim client As TcpClient = Me.tcpListener.AcceptTcpClient()
    Dim clientThread As New Thread(New ParameterizedThreadStart(AddressOf HandleClientComm))
    clientThread.Start(client)
   Loop
  End Sub

  Private Sub HandleClientComm(ByVal client As Object)
   Dim tcpClient As TcpClient = DirectCast(client, TcpClient)
   Dim clientStream As NetworkStream = tcpClient.GetStream()

   Dim message(1024) As Byte
   Dim bytesRead As Integer

   Do
    bytesRead = 0

    Dim encoder As New ASCIIEncoding()
    Dim msg As String = encoder.GetString(message, 0, bytesRead)
    msg = Me.txtPesoBalanza.Text.Trim & vbCrLf
    Echo(msg, encoder, clientStream)
    System.Threading.Thread.Sleep(300)
   Loop

   tcpClient.Close()
  End Sub


  Private Sub Echo(ByVal msg As String, ByVal encoder As ASCIIEncoding, ByVal clientStream As NetworkStream)
   Dim buffer() As Byte = encoder.GetBytes(msg)
      Try
         clientStream.Write(buffer, 0, buffer.Length)
         clientStream.Flush()
      Catch
      End Try
    End Sub

 Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      End
 End Sub





Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
cbxPuerto.Items.Clear()
cbxPuerto.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames())
txtNroIp.Text = oIni.IniGet(cFileIni, "ETHERNET", "NRO_IP")
txtNroPto.Text = oIni.IniGet(cFileIni, "ETHERNET", "NRO_PUERTO")
cbxPuerto.Text = oIni.IniGet(cFileIni, "SERIAL", "PUERTO")
cbxBudios.Text = oIni.IniGet(cFileIni, "SEIAL", "BAUDIOS")


End Sub



Private Sub btnStart_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Try
          oCommBalanza.PortName = cbxPuerto.Text.Trim
          oCommBalanza.BaudRate = cbxBudios.Text.Trim
          oCommBalanza.DiscardNull = True
          oCommBalanza.Encoding = System.Text.Encoding.Default
          oCommBalanza.Open()

          oIni.IniWrite(cFileIni, "ETHERNET", "NRO_IP", txtNroIp.Text)
          oIni.IniWrite(cFileIni, "ETHERNET", "NRO_PUERTO", txtNroPto.Text)
          oIni.IniWrite(cFileIni, "SERIAL", "PUERTO", cbxPuerto.Text)
          oIni.IniWrite(cFileIni, "SEIAL", "BAUDIOS", cbxBudios.Text)
          cNro_Ip = txtNroIp.Text
          nNro_Port = Val(txtNroPto.Text)
          btnStart.Enabled = False
          txtNroIp.Enabled = False
          txtNroPto.Enabled = False
          oTimer_Balanza.Start()

          Server()

        Catch ex As Exception

             MsgBox("Error al abrir el puerto COMM" & cbxPuerto.Text, MsgBoxStyle.Critical, "")
        End Try

End Sub

Private Sub oTimer_Balanza_Tick(sender As Object, e As EventArgs) Handles oTimer_Balanza.Tick
Dim cPeso As String = String.Empty
Dim nPos As Integer = 0
If oCommBalanza.IsOpen Then
   cPeso = oCommBalanza.ReadExisting
   If cPeso.Length >= 30 Then
      nPos = InStr(cPeso, Chr(2), CompareMethod.Text) + 4
      Me.txtPesoBalanza.Text = Mid(cPeso, nPos, 6)
   Else
      If cPeso.Length = 0 Then
         Me.txtPesoBalanza.Text = "----"
      End If
   End If
End If

End Sub
End Class