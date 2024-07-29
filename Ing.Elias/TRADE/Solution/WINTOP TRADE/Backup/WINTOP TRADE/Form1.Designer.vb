<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
Me.Label4 = New System.Windows.Forms.Label
Me.lblPeso = New System.Windows.Forms.Label
Me.oTimer_Peso = New System.Windows.Forms.Timer(Me.components)
Me.lblEstado = New System.Windows.Forms.Label
Me.btnMnu = New System.Windows.Forms.ToolStrip
Me.btnStart = New System.Windows.Forms.ToolStripButton
Me.btnStop = New System.Windows.Forms.ToolStripButton
Me.lblConectados = New System.Windows.Forms.ToolStripLabel
Me.Label1 = New System.Windows.Forms.Label
Me.cbxIntervalo = New System.Windows.Forms.ComboBox
Me.btnMnu.SuspendLayout()
Me.SuspendLayout()
'
'Label4
'
Me.Label4.AutoSize = True
Me.Label4.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
Me.Label4.ForeColor = System.Drawing.Color.Yellow
Me.Label4.Location = New System.Drawing.Point(66, 365)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(0, 17)
Me.Label4.TabIndex = 9
'
'lblPeso
'
Me.lblPeso.BackColor = System.Drawing.Color.White
Me.lblPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.lblPeso.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblPeso.Location = New System.Drawing.Point(136, 39)
Me.lblPeso.Name = "lblPeso"
Me.lblPeso.Size = New System.Drawing.Size(354, 112)
Me.lblPeso.TabIndex = 11
Me.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'
'oTimer_Peso
'
Me.oTimer_Peso.Interval = 350
'
'lblEstado
'
Me.lblEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
Me.lblEstado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
Me.lblEstado.Location = New System.Drawing.Point(0, 163)
Me.lblEstado.Name = "lblEstado"
Me.lblEstado.Size = New System.Drawing.Size(499, 35)
Me.lblEstado.TabIndex = 12
Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'
'btnMnu
'
Me.btnMnu.AutoSize = False
Me.btnMnu.BackgroundImage = CType(resources.GetObject("btnMnu.BackgroundImage"), System.Drawing.Image)
Me.btnMnu.Dock = System.Windows.Forms.DockStyle.Left
Me.btnMnu.ImageScalingSize = New System.Drawing.Size(90, 40)
Me.btnMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStart, Me.btnStop, Me.lblConectados})
Me.btnMnu.Location = New System.Drawing.Point(0, 0)
Me.btnMnu.Name = "btnMnu"
Me.btnMnu.Size = New System.Drawing.Size(119, 163)
Me.btnMnu.TabIndex = 20
Me.btnMnu.Text = "ToolStrip1"
'
'btnStart
'
Me.btnStart.AutoSize = False
Me.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
Me.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnStart.Name = "btnStart"
Me.btnStart.Size = New System.Drawing.Size(100, 60)
Me.btnStart.Text = "Start"
'
'btnStop
'
Me.btnStop.AutoSize = False
Me.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnStop.Name = "btnStop"
Me.btnStop.Size = New System.Drawing.Size(100, 60)
'
'lblConectados
'
Me.lblConectados.AutoSize = False
Me.lblConectados.Name = "lblConectados"
Me.lblConectados.Size = New System.Drawing.Size(127, 30)
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label1.ForeColor = System.Drawing.Color.White
Me.Label1.Location = New System.Drawing.Point(150, 12)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(149, 16)
Me.Label1.TabIndex = 21
Me.Label1.Text = "Intervalo de lecturas"
'
'cbxIntervalo
'
Me.cbxIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
Me.cbxIntervalo.FormattingEnabled = True
Me.cbxIntervalo.Items.AddRange(New Object() {"1) 0.25 seg", "2) 0.50 seg", "3) 0.75 seg", "4) 1 seg", "5) 1.5 seg", "6) 2 seg"})
Me.cbxIntervalo.Location = New System.Drawing.Point(305, 7)
Me.cbxIntervalo.Name = "cbxIntervalo"
Me.cbxIntervalo.Size = New System.Drawing.Size(121, 21)
Me.cbxIntervalo.TabIndex = 22
'
'Form1
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.CornflowerBlue
Me.ClientSize = New System.Drawing.Size(499, 198)
Me.Controls.Add(Me.cbxIntervalo)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.btnMnu)
Me.Controls.Add(Me.lblEstado)
Me.Controls.Add(Me.lblPeso)
Me.Controls.Add(Me.Label4)
Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
Me.MaximizeBox = False
Me.Name = "Form1"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "WINTOP TRADE"
Me.TopMost = True
Me.btnMnu.ResumeLayout(False)
Me.btnMnu.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents oTimer_Peso As System.Windows.Forms.Timer
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnMnu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblConectados As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxIntervalo As System.Windows.Forms.ComboBox
End Class
