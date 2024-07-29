Imports NDde.Client

Public Class ZTRADE
Dim cStringData As String = String.Empty
Dim cDDEServer As String = "TRADE"
Dim cDDETopic As String = "IO"
Dim cDDEItem As String = "OUTPUT"
Dim cDDECommand As String = "@GI;23"
Dim nTimeOut As Int32 = 60000
Dim cPesoTrade As String = String.Empty
Dim aTrade() As String
Dim TRADE_String As String = String.Empty
Private WithEvents client As DdeClient

Public Function TRADE_Open() As Boolean
  Try
      ' conecta al servidor DDE. Este deberia estar en ejecucion
      client = New DdeClient(cDDEServer, cDDETopic, Form1)
      client.Connect()
      client.StartAdvise(cDDEItem, 1, True, nTimeOut)
      TRADE_Open = True
  Catch ex As Exception
      TRADE_Open = False
  End Try
End Function

Public Function TRADE_Close() As Boolean
 client.StopAdvise(cDDEItem, nTimeOut)
 client.Disconnect()
 TRADE_Close = True
End Function
Public Sub TRADE_Send()
Try
  ' Operacion de ejeccion asincrona
  ' Envia el comando DDE  
  client.Execute(cDDECommand, 4000)
Catch ex As Exception
  cStringData = "Error al enviar "
End Try
End Sub


Private Sub client_Advise(ByVal sender As Object, ByVal e As NDde.Client.DdeAdviseEventArgs) Handles client.Advise
' esta subrutina se ejecuta cada vez que se actualiza el elemento de datos del servidor DDE especificado
cStringData = e.Text
TRADE_String = e.Text
aTrade = cStringData.Split(",")
If UBound(aTrade) > 0 Then
    aTrade(9) = aTrade(9).Replace(Chr(34), "")
    aTrade(9) = aTrade(9).Replace(Chr(32), "")
    cPesoTrade = Str(Val(aTrade(9)))
Else
   cPesoTrade = "0"
End If
End Sub

 Private Sub client_Disconnected(ByVal sender As Object, ByVal e As NDde.Client.DdeDisconnectedEventArgs) Handles client.Disconnected
     cStringData = "Desconectado"
 End Sub

Public Function TRADE_Peso() As String
 TRADE_Peso = cPesoTrade
End Function

Public Function TRADE_StringRequest() As String
 TRADE_StringRequest = TRADE_String
End Function


End Class
