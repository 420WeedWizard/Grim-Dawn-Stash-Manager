<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StripStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoadStashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnloadStashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddGSTFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEmtpyStashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfirmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HotkeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrimDawnStashFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmptyStashFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ForumThreadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(494, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StripStatus
        '
        Me.StripStatus.Name = "StripStatus"
        Me.StripStatus.Size = New System.Drawing.Size(12, 17)
        Me.StripStatus.Text = "x"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 120)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(494, 387)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Title"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 279
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "File"
        Me.ColumnHeader4.Width = 99
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadStashToolStripMenuItem, Me.UnloadStashToolStripMenuItem, Me.EditToolStripMenuItem, Me.AddGSTFileToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 114)
        '
        'LoadStashToolStripMenuItem
        '
        Me.LoadStashToolStripMenuItem.Name = "LoadStashToolStripMenuItem"
        Me.LoadStashToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.LoadStashToolStripMenuItem.Text = "Load Stash"
        '
        'UnloadStashToolStripMenuItem
        '
        Me.UnloadStashToolStripMenuItem.Name = "UnloadStashToolStripMenuItem"
        Me.UnloadStashToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.UnloadStashToolStripMenuItem.Text = "Unload Stash"
        '
        'AddGSTFileToolStripMenuItem
        '
        Me.AddGSTFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectFileToolStripMenuItem, Me.AddEmtpyStashToolStripMenuItem})
        Me.AddGSTFileToolStripMenuItem.Name = "AddGSTFileToolStripMenuItem"
        Me.AddGSTFileToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AddGSTFileToolStripMenuItem.Text = "Add Stash"
        '
        'SelectFileToolStripMenuItem
        '
        Me.SelectFileToolStripMenuItem.Name = "SelectFileToolStripMenuItem"
        Me.SelectFileToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectFileToolStripMenuItem.Text = "Add .GST File"
        '
        'AddEmtpyStashToolStripMenuItem
        '
        Me.AddEmtpyStashToolStripMenuItem.Name = "AddEmtpyStashToolStripMenuItem"
        Me.AddEmtpyStashToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddEmtpyStashToolStripMenuItem.Text = "Add Emtpy Stash"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfirmToolStripMenuItem})
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ConfirmToolStripMenuItem
        '
        Me.ConfirmToolStripMenuItem.Name = "ConfirmToolStripMenuItem"
        Me.ConfirmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConfirmToolStripMenuItem.Text = "Confirm"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "v0.5"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Grim Dawn Stash Manager"
        Me.NotifyIcon1.Visible = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotkeyToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HotkeyToolStripMenuItem
        '
        Me.HotkeyToolStripMenuItem.Name = "HotkeyToolStripMenuItem"
        Me.HotkeyToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.HotkeyToolStripMenuItem.Text = "Hotkeys"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrimDawnStashFileToolStripMenuItem, Me.EmptyStashFileToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'GrimDawnStashFileToolStripMenuItem
        '
        Me.GrimDawnStashFileToolStripMenuItem.Name = "GrimDawnStashFileToolStripMenuItem"
        Me.GrimDawnStashFileToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GrimDawnStashFileToolStripMenuItem.Text = ".GST File"
        '
        'EmptyStashFileToolStripMenuItem
        '
        Me.EmptyStashFileToolStripMenuItem.Name = "EmptyStashFileToolStripMenuItem"
        Me.EmptyStashFileToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EmptyStashFileToolStripMenuItem.Text = "Empty Stash File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForumThreadToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.GrimDawnStashManagerV3.My.Resources.Resources._1452874527_preferences_desktop_keyboard
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EditToolStripMenuItem.Text = "Hotkeys"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.GrimDawnStashManagerV3.My.Resources.Resources.Unbenannt_12
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(494, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ForumThreadToolStripMenuItem
        '
        Me.ForumThreadToolStripMenuItem.Image = Global.GrimDawnStashManagerV3.My.Resources.Resources.test111
        Me.ForumThreadToolStripMenuItem.Name = "ForumThreadToolStripMenuItem"
        Me.ForumThreadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ForumThreadToolStripMenuItem.Text = "Forum Thread"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 532)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grim Dawn Stash Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddGSTFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfirmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmtpyStashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadStashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnloadStashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HotkeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrimDawnStashFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmptyStashFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForumThreadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
