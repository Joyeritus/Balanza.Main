
Public Class Form1
    Public oHbmTrade As ZTRADE

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oHbmTrade = New ZTRADE
        btnStart.Enabled = True
        btnStop.Enabled = False
        cbxIntervalo.Text = cbxIntervalo.Items(0)
    End Sub


    Private Sub oTimer_Peso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oTimer_Peso.Tick
        Dim cEnvia As String = String.Empty
        oHbmTrade.TRADE_Send()
        lblPeso.Text = oHbmTrade.TRADE_Peso
        cEnvia = "=" & StrReverse(lblPeso.Text).Trim.PadRight(6, "0")
        oComm.WriteLine(cEnvia)
    End Sub

    Private Sub btnStart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim nIntervalo As Int16 = 0
        ' Valores en milisegundos para el timer
        ' Es para la comunicacion a tiempo real
        Select Case Val(Mid(cbxIntervalo.Text, 1, 1))
            Case 1
                nIntervalo = 250
            Case 2
                nIntervalo = 500
            Case 3
                nIntervalo = 750
            Case 4
                nIntervalo = 1000
            Case 5
                nIntervalo = 1500
            Case 6
                nIntervalo = 2000
        End Select
        oTimer_Peso.Interval = nIntervalo
        If oHbmTrade.TRADE_Open() Then
            lblEstado.Text = "Conectado"
            oTimer_Peso.Start()
        Else
            lblEstado.Text = "Error de conexion"
            oTimer_Peso.Stop()
        End If
        btnStart.Enabled = False
        btnStop.Enabled = True
        oComm.PortName = "COM5"
        oComm.Open()

        oComm.WriteLine("====")
        oComm.WriteLine("=EDART")
        oComm.WriteLine("=EDART")
        oComm.WriteLine("=EDART")
    End Sub

    Private Sub btnStop_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        oTimer_Peso.Stop()
        oComm.Close()
        oHbmTrade.TRADE_Close()
        lblPeso.Text = String.Empty
        lblEstado.Text = String.Empty
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub
End Class




