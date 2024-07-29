Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.IO.Ports

Imports System.Threading


Public Class FRMMAIN

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
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D

        Me.Text = Application.ProductName.ToString

        cIniFile = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) & "\" & cIniFile
        txtBalanza.Text = IniGet(cIniFile, "BALANZA", "BALANZA", "")
        txtPanel.Text = IniGet(cIniFile, "BALANZA", "PANEL", "")
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
End Class




