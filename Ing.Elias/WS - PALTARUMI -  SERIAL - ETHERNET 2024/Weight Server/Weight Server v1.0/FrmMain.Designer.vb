<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
    Me.Panel_Ip = New System.Windows.Forms.Panel()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.txtNroIp = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNroPto = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Panel_Server = New System.Windows.Forms.Panel()
    Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
    Me.cbxBudios = New System.Windows.Forms.ComboBox()
    Me.cbxPuerto = New System.Windows.Forms.ComboBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtPesoBalanza = New System.Windows.Forms.TextBox()
    Me.oMenu = New System.Windows.Forms.ToolStrip()
    Me.btnStart = New System.Windows.Forms.ToolStripButton()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.oCommBalanza = New System.IO.Ports.SerialPort(Me.components)
    Me.oTimer_Balanza = New System.Windows.Forms.Timer(Me.components)
    Me.Panel_Ip.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.Panel_Server.SuspendLayout()
    CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer3.Panel1.SuspendLayout()
    Me.SplitContainer3.Panel2.SuspendLayout()
    Me.SplitContainer3.SuspendLayout()
    Me.oMenu.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel_Ip
    '
    Me.Panel_Ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel_Ip.Controls.Add(Me.SplitContainer1)
    Me.Panel_Ip.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel_Ip.Location = New System.Drawing.Point(0, 83)
    Me.Panel_Ip.Name = "Panel_Ip"
    Me.Panel_Ip.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Panel_Ip.Size = New System.Drawing.Size(180, 46)
    Me.Panel_Ip.TabIndex = 0
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.txtNroIp)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
    Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.txtNroPto)
    Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
    Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.SplitContainer1.Size = New System.Drawing.Size(178, 44)
    Me.SplitContainer1.SplitterDistance = 112
    Me.SplitContainer1.TabIndex = 118
    '
    'txtNroIp
    '
    Me.txtNroIp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtNroIp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroIp.Location = New System.Drawing.Point(0, 21)
    Me.txtNroIp.MaxLength = 20
    Me.txtNroIp.Name = "txtNroIp"
    Me.txtNroIp.Size = New System.Drawing.Size(112, 27)
    Me.txtNroIp.TabIndex = 1
    Me.txtNroIp.Text = "127.0.0.1"
    Me.txtNroIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.White
    Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(112, 21)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "NUMERO DE IP"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtNroPto
    '
    Me.txtNroPto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtNroPto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroPto.Location = New System.Drawing.Point(0, 21)
    Me.txtNroPto.MaxLength = 4
    Me.txtNroPto.Name = "txtNroPto"
    Me.txtNroPto.Size = New System.Drawing.Size(62, 27)
    Me.txtNroPto.TabIndex = 2
    Me.txtNroPto.Text = "3000"
    Me.txtNroPto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.Color.White
    Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.Location = New System.Drawing.Point(0, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(62, 21)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "PUERTO"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel_Server
    '
    Me.Panel_Server.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel_Server.Controls.Add(Me.SplitContainer3)
    Me.Panel_Server.Location = New System.Drawing.Point(-1, 0)
    Me.Panel_Server.Name = "Panel_Server"
    Me.Panel_Server.Size = New System.Drawing.Size(425, 133)
    Me.Panel_Server.TabIndex = 122
    '
    'SplitContainer3
    '
    Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer3.Name = "SplitContainer3"
    '
    'SplitContainer3.Panel1
    '
    Me.SplitContainer3.Panel1.Controls.Add(Me.cbxBudios)
    Me.SplitContainer3.Panel1.Controls.Add(Me.cbxPuerto)
    Me.SplitContainer3.Panel1.Controls.Add(Me.Label9)
    Me.SplitContainer3.Panel1.Controls.Add(Me.Panel_Ip)
    Me.SplitContainer3.Panel1.Controls.Add(Me.Label8)
    '
    'SplitContainer3.Panel2
    '
    Me.SplitContainer3.Panel2.Controls.Add(Me.txtPesoBalanza)
    Me.SplitContainer3.Size = New System.Drawing.Size(421, 129)
    Me.SplitContainer3.SplitterDistance = 180
    Me.SplitContainer3.TabIndex = 0
    '
    'cbxBudios
    '
    Me.cbxBudios.Dock = System.Windows.Forms.DockStyle.Right
    Me.cbxBudios.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbxBudios.FormattingEnabled = True
    Me.cbxBudios.Items.AddRange(New Object() {"9600", "4800", "2400", "1200"})
    Me.cbxBudios.Location = New System.Drawing.Point(92, 29)
    Me.cbxBudios.Name = "cbxBudios"
    Me.cbxBudios.Size = New System.Drawing.Size(88, 27)
    Me.cbxBudios.TabIndex = 5
    '
    'cbxPuerto
    '
    Me.cbxPuerto.Dock = System.Windows.Forms.DockStyle.Left
    Me.cbxPuerto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbxPuerto.FormattingEnabled = True
    Me.cbxPuerto.Location = New System.Drawing.Point(0, 29)
    Me.cbxPuerto.Name = "cbxPuerto"
    Me.cbxPuerto.Size = New System.Drawing.Size(88, 27)
    Me.cbxPuerto.TabIndex = 4
    '
    'Label9
    '
    Me.Label9.BackColor = System.Drawing.Color.White
    Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(0, 57)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(180, 26)
    Me.Label9.TabIndex = 3
    Me.Label9.Text = "SALIDA DE PESO"
    Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label8
    '
    Me.Label8.BackColor = System.Drawing.Color.White
    Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(0, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(180, 29)
    Me.Label8.TabIndex = 1
    Me.Label8.Text = "ORIGEN DE PESO"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtPesoBalanza
    '
    Me.txtPesoBalanza.BackColor = System.Drawing.Color.Blue
    Me.txtPesoBalanza.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPesoBalanza.ForeColor = System.Drawing.Color.White
    Me.txtPesoBalanza.Location = New System.Drawing.Point(1, 37)
    Me.txtPesoBalanza.Name = "txtPesoBalanza"
    Me.txtPesoBalanza.ReadOnly = True
    Me.txtPesoBalanza.Size = New System.Drawing.Size(224, 63)
    Me.txtPesoBalanza.TabIndex = 1
    Me.txtPesoBalanza.Text = "0"
    Me.txtPesoBalanza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'oMenu
    '
    Me.oMenu.AutoSize = False
    Me.oMenu.BackgroundImage = CType(resources.GetObject("oMenu.BackgroundImage"), System.Drawing.Image)
    Me.oMenu.Dock = System.Windows.Forms.DockStyle.Right
    Me.oMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStart})
    Me.oMenu.Location = New System.Drawing.Point(420, 0)
    Me.oMenu.Name = "oMenu"
    Me.oMenu.Size = New System.Drawing.Size(72, 157)
    Me.oMenu.TabIndex = 125
    Me.oMenu.Text = "ToolStrip1"
    '
    'btnStart
    '
    Me.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
    Me.btnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnStart.Name = "btnStart"
    Me.btnStart.Size = New System.Drawing.Size(70, 49)
    Me.btnStart.Text = "Inicio"
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(0, 136)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(420, 21)
    Me.Label3.TabIndex = 126
    Me.Label3.Text = "Derechos Reservados del Autor"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'oTimer_Balanza
    '
    Me.oTimer_Balanza.Interval = 350
    '
    'FrmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(492, 157)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.oMenu)
    Me.Controls.Add(Me.Panel_Server)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "FrmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Weight Server v1"
    Me.TopMost = True
    Me.Panel_Ip.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.PerformLayout()
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel2.PerformLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.Panel_Server.ResumeLayout(False)
    Me.SplitContainer3.Panel1.ResumeLayout(False)
    Me.SplitContainer3.Panel2.ResumeLayout(False)
    Me.SplitContainer3.Panel2.PerformLayout()
    CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer3.ResumeLayout(False)
    Me.oMenu.ResumeLayout(False)
    Me.oMenu.PerformLayout()
    Me.ResumeLayout(False)

End Sub
    Friend WithEvents Panel_Ip As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNroIp As System.Windows.Forms.TextBox
    Friend WithEvents txtNroPto As System.Windows.Forms.TextBox
    Friend WithEvents Panel_Server As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents oMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents oCommBalanza As System.IO.Ports.SerialPort
    Friend WithEvents cbxBudios As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPuerto As System.Windows.Forms.ComboBox
    Friend WithEvents txtPesoBalanza As System.Windows.Forms.TextBox
    Friend WithEvents oTimer_Balanza As System.Windows.Forms.Timer
End Class
