Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.IO.Ports

Imports System.Threading


Public Class FRMMAIN

    Public WithEvents connected As WS_Client
    Public WithEvents disconnected As WS_Client
    Dim BeginServer As New Thread(AddressOf ServerBegin)
    Delegate Sub oCommBalanza_Delegado(ByVal data As String)


Private Sub FRMMAIN_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim localApp As Process() = Process.GetProcesses

   For Each ep As Process In localApp
       If ep.ProcessName = Application.ProductName Then
           ep.Kill()
       End If
   Next
   End
 End Sub

    Private Sub FRMMAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D

        AddHandler WS_Client.whocon, AddressOf whoConnected_changed          ' The Handlers of the above Events
        AddHandler WS_Client.whodiscon, AddressOf whoDisconnected_changed
        Me.Text = Application.ProductName.ToString
        oMeter.Minimum = 0
        oMeter.Maximum = 10
        cIniFile = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) & "\" & cIniFile
        txtIP.Text = IniGet(cIniFile, "ETHERNET", "TCP_IP", "")
        txtPort.Text = IniGet(cIniFile, "ETHERNET", "TCP_PORT", "")
        txtBalanza.Text = IniGet(cIniFile, "BALANZA", "BALANZA", "")
        txtPanel.Text = IniGet(cIniFile, "BALANZA", "PANEL", "")
        txtIP.Text = "127.0.0.1"
        '
        ' Activa la lectura de peso
        '
        Try
          oCommBalanza.PortName = txtBalanza.Text
          oCommBalanza.Open()
          oTimer.Enabled = True
        Catch ex As Exception
             oTimer.Enabled = False
             MsgBox("Error al abrir el puerto " & txtBalanza.Text, MsgBoxStyle.Critical, "")
        End Try
        '
        ' Activa la salida al panel
        '
        Try
           oCommPanel.PortName = txtPanel.Text
           oCommPanel.Open()
        Catch
        End Try
        btnStart.Enabled = True
        btnStop.Enabled = False



    End Sub

    Private Sub whoConnected_changed(ByVal whoConnected As String) Handles connected.whocon  ' Actions when events happen

        update_Connections()

    End Sub

    Private Sub whoDisconnected_changed(ByVal whoDisconnected As String) Handles disconnected.whodiscon ' Actions when events happen

        update_Connections()

    End Sub



Sub ServerBegin()
    Dim localServer As New WS_Module_Server      ' The Listener Class 
    localServer.mainListen()
End Sub


Private Sub update_Connections()
    Dim i As Integer = WS_Client.WS_Conect.Count
    If i <= 10 Then
        oMeter.Maximum = 10
    ElseIf i > 10 And i <= 100 Then
        oMeter.Maximum = 100
    ElseIf i > 100 And i <= 1000 Then
        oMeter.Maximum = 1000
    ElseIf i > 1000 Then
        oMeter.Maximum = 3000
    End If
    oMeter.Value = i
End Sub

Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
    gServer_IP = txtIP.Text.ToString
    gServer_Port = Val(txtPort.Text)
    btnStart.Enabled = False
    btnStop.Enabled = True
    BeginServer.Start()
End Sub

Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
Dim localApp As Process() = Process.GetProcesses
For Each ep As Process In localApp
    If ep.ProcessName = Application.ProductName Then
        ep.Kill()
    End If
Next
End
End Sub

Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
lblPesoDescontado.BackColor = Color.DarkBlue
lblPesoDescontado.ForeColor = Color.White
nDscto = TxtNum(IniGet(cIniFile, "FACTOR", "FACTOR_A", ""))
End Sub

Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
lblPesoDescontado.BackColor = Color.LightGreen
lblPesoDescontado.ForeColor = Color.Black
nDscto = TxtNum(IniGet(cIniFile, "FACTOR", "FACTOR_B", ""))
End Sub

Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
 lblPesoDescontado.BackColor = Color.Orange
lblPesoDescontado.ForeColor = Color.Black
nDscto = TxtNum(IniGet(cIniFile, "FACTOR", "FACTOR_C", ""))
End Sub

Private Sub oCommBalanza_DataReceived(ByVal sender As Object, _
                ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) _
                Handles oCommBalanza.DataReceived
    Dim cLee As String = oCommBalanza.ReadExisting
    Dim cPuertoTrama As New oCommBalanza_Delegado(AddressOf Me.PesoBalanza)
    Me.Invoke(cPuertoTrama, cLee)
End Sub
Sub PesoBalanza(ByVal cData As String)
    cTrama += cData
    If cTrama.Length >= 14 Then
       Dim nPos As Integer = InStr(cTrama, Chr(2), CompareMethod.Text) + 1
       cPesoBalanza = Mid(cTrama, nPos, 6)
       cTrama = String.Empty
    End If
End Sub

Private Sub oTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oTimer.Tick
Dim nCalculo As Double = 0.0
lblPesoReal.Text = cPesoBalanza
cPesoDescontado = lblPesoReal.Text
'Try
'    nCalculo = Val(lblPesoReal.Text) * (nDscto / 100)
'    nCalculo = Val(lblPesoReal.Text) - nCalculo
'    cPesoDescontado = Format(nCalculo, "#####0")
'Catch
'End Try
'lblPesoDescontado.Text = cPesoDescontado.Trim
If oCommPanel.IsOpen Then
   oCommPanel.WriteLine(Chr(2) & "ABC " & lblPesoDescontado.Text & "000000" & Chr(13))
End If
End Sub

Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
nDscto = 0
lblPesoDescontado.BackColor = Color.White
lblPesoDescontado.ForeColor = Color.Black
End Sub
End Class




