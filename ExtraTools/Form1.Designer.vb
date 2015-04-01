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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEMO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EshopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΟργάνωσηToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.SalesToolStripMenuItem, Me.MantisToolStripMenuItem, Me.EshopToolStripMenuItem, Me.ΟργάνωσηToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.StartToolStripMenuItem.Text = "Αρχική"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEMO2ToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ItemsToolStripMenuItem.Text = "Αποθήκη"
        '
        'NEMO2ToolStripMenuItem
        '
        Me.NEMO2ToolStripMenuItem.Name = "NEMO2ToolStripMenuItem"
        Me.NEMO2ToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.NEMO2ToolStripMenuItem.Text = "NEMO 2"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalesToolStripMenuItem.Text = "Exports"
        '
        'MantisToolStripMenuItem
        '
        Me.MantisToolStripMenuItem.Name = "MantisToolStripMenuItem"
        Me.MantisToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MantisToolStripMenuItem.Text = "Mantis"
        '
        'EshopToolStripMenuItem
        '
        Me.EshopToolStripMenuItem.Name = "EshopToolStripMenuItem"
        Me.EshopToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EshopToolStripMenuItem.Text = "E-shop"
        '
        'ΟργάνωσηToolStripMenuItem
        '
        Me.ΟργάνωσηToolStripMenuItem.Name = "ΟργάνωσηToolStripMenuItem"
        Me.ΟργάνωσηToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ΟργάνωσηToolStripMenuItem.Text = "Οργάνωση"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 529)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Extra Tools"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EshopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEMO2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Protected Sub MDIChildNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEMO2ToolStripMenuItem.Click
        Dim NewMDIChild As New Form2()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub
    Friend WithEvents ΟργάνωσηToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
