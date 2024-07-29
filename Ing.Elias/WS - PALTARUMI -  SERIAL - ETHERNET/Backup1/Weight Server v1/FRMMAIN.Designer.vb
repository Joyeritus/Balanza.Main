<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMAIN))
Me.lblPesoReal = New System.Windows.Forms.Label
Me.txtIP = New System.Windows.Forms.TextBox
Me.txtPort = New System.Windows.Forms.TextBox
Me.btnMnu = New System.Windows.Forms.ToolStrip
Me.btnStart = New System.Windows.Forms.ToolStripButton
Me.btnStop = New System.Windows.Forms.ToolStripButton
Me.lblConectados = New System.Windows.Forms.ToolStripLabel
Me.mnu = New System.Windows.Forms.ToolStrip
Me.btnA = New System.Windows.Forms.ToolStripButton
Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
Me.btnB = New System.Windows.Forms.ToolStripButton
Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
Me.btnC = New System.Windows.Forms.ToolStripButton
Me.oMeter = New System.Windows.Forms.ToolStripProgressBar
Me.Panel1 = New System.Windows.Forms.Panel
Me.txtBalanza = New System.Windows.Forms.TextBox
Me.Label3 = New System.Windows.Forms.Label
Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
Me.PictureBox1 = New System.Windows.Forms.PictureBox
Me.lblPesoDescontado = New System.Windows.Forms.Label
Me.oTimer = New System.Windows.Forms.Timer(Me.components)
Me.Panel2 = New System.Windows.Forms.Panel
Me.txtPanel = New System.Windows.Forms.TextBox
Me.Label5 = New System.Windows.Forms.Label
Me.Panel3 = New System.Windows.Forms.Panel
Me.Label1 = New System.Windows.Forms.Label
Me.Panel4 = New System.Windows.Forms.Panel
Me.Label2 = New System.Windows.Forms.Label
Me.oCommBalanza = New System.IO.Ports.SerialPort(Me.components)
Me.oCommPanel = New System.IO.Ports.SerialPort(Me.components)
Me.btnMnu.SuspendLayout()
Me.mnu.SuspendLayout()
Me.Panel1.SuspendLayout()
Me.SplitContainer2.Panel2.SuspendLayout()
Me.SplitContainer2.SuspendLayout()
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.Panel2.SuspendLayout()
Me.Panel3.SuspendLayout()
Me.Panel4.SuspendLayout()
Me.SuspendLayout()
'
'lblPesoReal
'
Me.lblPesoReal.BackColor = System.Drawing.Color.White
Me.lblPesoReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.lblPesoReal.Font = New System.Drawing.Font("Calibri", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPesoReal.ForeColor = System.Drawing.Color.Black
Me.lblPesoReal.Location = New System.Drawing.Point(1, 37)
Me.lblPesoReal.Name = "lblPesoReal"
Me.lblPesoReal.Size = New System.Drawing.Size(182, 63)
Me.lblPesoReal.TabIndex = 10
Me.lblPesoReal.Text = "0"
Me.lblPesoReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
'
'txtIP
'
Me.txtIP.Dock = System.Windows.Forms.DockStyle.Bottom
Me.txtIP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtIP.Location = New System.Drawing.Point(0, 20)
Me.txtIP.Name = "txtIP"
Me.txtIP.ReadOnly = True
Me.txtIP.Size = New System.Drawing.Size(134, 26)
Me.txtIP.TabIndex = 11
Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'txtPort
'
Me.txtPort.Dock = System.Windows.Forms.DockStyle.Bottom
Me.txtPort.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtPort.Location = New System.Drawing.Point(0, 20)
Me.txtPort.Name = "txtPort"
Me.txtPort.ReadOnly = True
Me.txtPort.Size = New System.Drawing.Size(134, 26)
Me.txtPort.TabIndex = 20
Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'btnMnu
'
Me.btnMnu.AutoSize = False
Me.btnMnu.BackgroundImage = CType(resources.GetObject("btnMnu.BackgroundImage"), System.Drawing.Image)
Me.btnMnu.Dock = System.Windows.Forms.DockStyle.Right
Me.btnMnu.ImageScalingSize = New System.Drawing.Size(90, 40)
Me.btnMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStart, Me.btnStop, Me.lblConectados})
Me.btnMnu.Location = New System.Drawing.Point(446, 0)
Me.btnMnu.Name = "btnMnu"
Me.btnMnu.Size = New System.Drawing.Size(100, 156)
Me.btnMnu.TabIndex = 21
Me.btnMnu.Text = "ToolStrip1"
'
'btnStart
'
Me.btnStart.AutoSize = False
Me.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
Me.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnStart.Name = "btnStart"
Me.btnStart.Size = New System.Drawing.Size(80, 60)
Me.btnStart.Text = "Start"
'
'btnStop
'
Me.btnStop.AutoSize = False
Me.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnStop.Name = "btnStop"
Me.btnStop.Size = New System.Drawing.Size(80, 60)
'
'lblConectados
'
Me.lblConectados.AutoSize = False
Me.lblConectados.Name = "lblConectados"
Me.lblConectados.Size = New System.Drawing.Size(127, 30)
'
'mnu
'
Me.mnu.AutoSize = False
Me.mnu.BackgroundImage = CType(resources.GetObject("mnu.BackgroundImage"), System.Drawing.Image)
Me.mnu.Dock = System.Windows.Forms.DockStyle.Bottom
Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnA, Me.ToolStripSeparator1, Me.btnB, Me.ToolStripSeparator2, Me.btnC, Me.oMeter})
Me.mnu.Location = New System.Drawing.Point(0, 132)
Me.mnu.Name = "mnu"
Me.mnu.Size = New System.Drawing.Size(446, 65)
Me.mnu.TabIndex = 25
Me.mnu.Text = "ToolStrip1"
Me.mnu.Visible = False
'
'btnA
'
Me.btnA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnA.Image = CType(resources.GetObject("btnA.Image"), System.Drawing.Image)
Me.btnA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
Me.btnA.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnA.Name = "btnA"
Me.btnA.Size = New System.Drawing.Size(54, 62)
Me.btnA.Text = "ToolStripButton2"
Me.btnA.ToolTipText = "A"
'
'ToolStripSeparator1
'
Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 65)
'
'btnB
'
Me.btnB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnB.Image = CType(resources.GetObject("btnB.Image"), System.Drawing.Image)
Me.btnB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
Me.btnB.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnB.Name = "btnB"
Me.btnB.Size = New System.Drawing.Size(54, 62)
Me.btnB.Text = "ToolStripButton3"
Me.btnB.ToolTipText = "B"
'
'ToolStripSeparator2
'
Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 65)
'
'btnC
'
Me.btnC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnC.Image = CType(resources.GetObject("btnC.Image"), System.Drawing.Image)
Me.btnC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
Me.btnC.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnC.Name = "btnC"
Me.btnC.Size = New System.Drawing.Size(54, 62)
Me.btnC.Text = "ToolStripButton4"
Me.btnC.ToolTipText = "C"
'
'oMeter
'
Me.oMeter.AutoSize = False
Me.oMeter.Name = "oMeter"
Me.oMeter.Size = New System.Drawing.Size(230, 25)
'
'Panel1
'
Me.Panel1.Controls.Add(Me.txtBalanza)
Me.Panel1.Controls.Add(Me.Label3)
Me.Panel1.Location = New System.Drawing.Point(189, 14)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(111, 46)
Me.Panel1.TabIndex = 26
'
'txtBalanza
'
Me.txtBalanza.Dock = System.Windows.Forms.DockStyle.Bottom
Me.txtBalanza.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtBalanza.Location = New System.Drawing.Point(0, 20)
Me.txtBalanza.Name = "txtBalanza"
Me.txtBalanza.ReadOnly = True
Me.txtBalanza.Size = New System.Drawing.Size(111, 26)
Me.txtBalanza.TabIndex = 23
Me.txtBalanza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'Label3
'
Me.Label3.BackColor = System.Drawing.Color.Silver
Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label3.Location = New System.Drawing.Point(0, 0)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(111, 19)
Me.Label3.TabIndex = 22
Me.Label3.Text = "BALANZA"
Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
'
'SplitContainer2
'
Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.SplitContainer2.Location = New System.Drawing.Point(48, 163)
Me.SplitContainer2.Name = "SplitContainer2"
Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
'
'SplitContainer2.Panel2
'
Me.SplitContainer2.Panel2.Controls.Add(Me.PictureBox1)
Me.SplitContainer2.Size = New System.Drawing.Size(169, 119)
Me.SplitContainer2.SplitterDistance = 59
Me.SplitContainer2.TabIndex = 27
'
'PictureBox1
'
Me.PictureBox1.BackColor = System.Drawing.Color.White
Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
Me.PictureBox1.Name = "PictureBox1"
Me.PictureBox1.Size = New System.Drawing.Size(19, 16)
Me.PictureBox1.TabIndex = 31
Me.PictureBox1.TabStop = False
'
'lblPesoDescontado
'
Me.lblPesoDescontado.BackColor = System.Drawing.Color.White
Me.lblPesoDescontado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.lblPesoDescontado.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPesoDescontado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
Me.lblPesoDescontado.Location = New System.Drawing.Point(193, 156)
Me.lblPesoDescontado.Name = "lblPesoDescontado"
Me.lblPesoDescontado.Size = New System.Drawing.Size(165, 52)
Me.lblPesoDescontado.TabIndex = 11
Me.lblPesoDescontado.Text = "0"
Me.lblPesoDescontado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
Me.lblPesoDescontado.Visible = False
'
'oTimer
'
'
'Panel2
'
Me.Panel2.Controls.Add(Me.txtPanel)
Me.Panel2.Controls.Add(Me.Label5)
Me.Panel2.Location = New System.Drawing.Point(189, 66)
Me.Panel2.Name = "Panel2"
Me.Panel2.Size = New System.Drawing.Size(111, 46)
Me.Panel2.TabIndex = 28
'
'txtPanel
'
Me.txtPanel.Dock = System.Windows.Forms.DockStyle.Bottom
Me.txtPanel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtPanel.Location = New System.Drawing.Point(0, 20)
Me.txtPanel.Name = "txtPanel"
Me.txtPanel.ReadOnly = True
Me.txtPanel.Size = New System.Drawing.Size(111, 26)
Me.txtPanel.TabIndex = 23
Me.txtPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'Label5
'
Me.Label5.BackColor = System.Drawing.Color.Silver
Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label5.Location = New System.Drawing.Point(0, 0)
Me.Label5.Name = "Label5"
Me.Label5.Size = New System.Drawing.Size(111, 19)
Me.Label5.TabIndex = 22
Me.Label5.Text = "PANEL"
Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
'
'Panel3
'
Me.Panel3.Controls.Add(Me.Label1)
Me.Panel3.Controls.Add(Me.txtIP)
Me.Panel3.Location = New System.Drawing.Point(306, 14)
Me.Panel3.Name = "Panel3"
Me.Panel3.Size = New System.Drawing.Size(134, 46)
Me.Panel3.TabIndex = 29
'
'Label1
'
Me.Label1.BackColor = System.Drawing.Color.Silver
Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label1.Location = New System.Drawing.Point(0, 0)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(134, 19)
Me.Label1.TabIndex = 22
Me.Label1.Text = "NRO IP"
Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
'
'Panel4
'
Me.Panel4.Controls.Add(Me.Label2)
Me.Panel4.Controls.Add(Me.txtPort)
Me.Panel4.Location = New System.Drawing.Point(306, 66)
Me.Panel4.Name = "Panel4"
Me.Panel4.Size = New System.Drawing.Size(134, 46)
Me.Panel4.TabIndex = 30
'
'Label2
'
Me.Label2.BackColor = System.Drawing.Color.Silver
Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label2.Location = New System.Drawing.Point(0, 0)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(134, 19)
Me.Label2.TabIndex = 22
Me.Label2.Text = "NRO PORT"
Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
'
'oCommBalanza
'
'
'FRMMAIN
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.CornflowerBlue
Me.ClientSize = New System.Drawing.Size(546, 156)
Me.Controls.Add(Me.lblPesoReal)
Me.Controls.Add(Me.Panel4)
Me.Controls.Add(Me.lblPesoDescontado)
Me.Controls.Add(Me.Panel3)
Me.Controls.Add(Me.Panel2)
Me.Controls.Add(Me.SplitContainer2)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Me.mnu)
Me.Controls.Add(Me.btnMnu)
Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
Me.MaximizeBox = False
Me.Name = "FRMMAIN"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "Weight Server "
Me.TopMost = True
Me.btnMnu.ResumeLayout(False)
Me.btnMnu.PerformLayout()
Me.mnu.ResumeLayout(False)
Me.mnu.PerformLayout()
Me.Panel1.ResumeLayout(False)
Me.Panel1.PerformLayout()
Me.SplitContainer2.Panel2.ResumeLayout(False)
Me.SplitContainer2.ResumeLayout(False)
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
Me.Panel2.ResumeLayout(False)
Me.Panel2.PerformLayout()
Me.Panel3.ResumeLayout(False)
Me.Panel3.PerformLayout()
Me.Panel4.ResumeLayout(False)
Me.Panel4.PerformLayout()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents lblPesoReal As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents btnMnu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblConectados As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnB As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnC As System.Windows.Forms.ToolStripButton
    Friend WithEvents oMeter As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblPesoDescontado As System.Windows.Forms.Label
    Friend WithEvents txtBalanza As System.Windows.Forms.TextBox
    Friend WithEvents oTimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPanel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents oCommBalanza As System.IO.Ports.SerialPort
    Friend WithEvents oCommPanel As System.IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
