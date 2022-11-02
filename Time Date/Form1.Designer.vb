<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Timedate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timedate))
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.themepanel = New System.Windows.Forms.Panel()
        Me.savetheme = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.theme4 = New Bunifu.UI.WinForms.BunifuRadioButton()
        Me.theme3 = New Bunifu.UI.WinForms.BunifuRadioButton()
        Me.theme2 = New Bunifu.UI.WinForms.BunifuRadioButton()
        Me.theme1 = New Bunifu.UI.WinForms.BunifuRadioButton()
        Me.defaultt = New Bunifu.UI.WinForms.BunifuRadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.timepanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuHSlider1 = New Bunifu.UI.WinForms.BunifuHSlider()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.themepanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.timepanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.Controls.Add(Me.BunifuHSlider1)
        Me.toolbar.Controls.Add(Me.PictureBox1)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(660, 41)
        Me.toolbar.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Time_Date.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(588, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Image = Global.Time_Date.My.Resources.Resources.exitt
        Me.exitt.Location = New System.Drawing.Point(620, 8)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 28)
        Me.exitt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'themepanel
        '
        Me.themepanel.BackColor = System.Drawing.Color.White
        Me.themepanel.Controls.Add(Me.savetheme)
        Me.themepanel.Controls.Add(Me.BunifuLabel5)
        Me.themepanel.Controls.Add(Me.BunifuLabel4)
        Me.themepanel.Controls.Add(Me.BunifuLabel3)
        Me.themepanel.Controls.Add(Me.BunifuLabel2)
        Me.themepanel.Controls.Add(Me.BunifuLabel1)
        Me.themepanel.Controls.Add(Me.theme4)
        Me.themepanel.Controls.Add(Me.theme3)
        Me.themepanel.Controls.Add(Me.theme2)
        Me.themepanel.Controls.Add(Me.theme1)
        Me.themepanel.Controls.Add(Me.defaultt)
        Me.themepanel.Controls.Add(Me.Label2)
        Me.themepanel.Controls.Add(Me.PictureBox3)
        Me.themepanel.Location = New System.Drawing.Point(36, 79)
        Me.themepanel.Name = "themepanel"
        Me.themepanel.Size = New System.Drawing.Size(599, 193)
        Me.themepanel.TabIndex = 29
        '
        'savetheme
        '
        Me.savetheme.AllowAnimations = True
        Me.savetheme.AllowMouseEffects = True
        Me.savetheme.AllowToggling = False
        Me.savetheme.AnimationSpeed = 200
        Me.savetheme.AutoGenerateColors = False
        Me.savetheme.AutoRoundBorders = False
        Me.savetheme.AutoSizeLeftIcon = True
        Me.savetheme.AutoSizeRightIcon = True
        Me.savetheme.BackColor = System.Drawing.Color.Transparent
        Me.savetheme.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.savetheme.BackgroundImage = CType(resources.GetObject("savetheme.BackgroundImage"), System.Drawing.Image)
        Me.savetheme.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.savetheme.ButtonText = "Save"
        Me.savetheme.ButtonTextMarginLeft = 0
        Me.savetheme.ColorContrastOnClick = 45
        Me.savetheme.ColorContrastOnHover = 45
        Me.savetheme.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.savetheme.CustomizableEdges = BorderEdges2
        Me.savetheme.DialogResult = System.Windows.Forms.DialogResult.None
        Me.savetheme.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.savetheme.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.savetheme.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.savetheme.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.savetheme.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savetheme.ForeColor = System.Drawing.Color.White
        Me.savetheme.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.savetheme.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.savetheme.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.savetheme.IconMarginLeft = 11
        Me.savetheme.IconPadding = 10
        Me.savetheme.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.savetheme.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.savetheme.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.savetheme.IconSize = 25
        Me.savetheme.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.savetheme.IdleBorderRadius = 30
        Me.savetheme.IdleBorderThickness = 1
        Me.savetheme.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.savetheme.IdleIconLeftImage = Nothing
        Me.savetheme.IdleIconRightImage = Nothing
        Me.savetheme.IndicateFocus = False
        Me.savetheme.Location = New System.Drawing.Point(384, 7)
        Me.savetheme.Name = "savetheme"
        Me.savetheme.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.savetheme.OnDisabledState.BorderRadius = 30
        Me.savetheme.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.savetheme.OnDisabledState.BorderThickness = 1
        Me.savetheme.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.savetheme.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.savetheme.OnDisabledState.IconLeftImage = Nothing
        Me.savetheme.OnDisabledState.IconRightImage = Nothing
        Me.savetheme.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.savetheme.onHoverState.BorderRadius = 30
        Me.savetheme.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.savetheme.onHoverState.BorderThickness = 1
        Me.savetheme.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.savetheme.onHoverState.ForeColor = System.Drawing.Color.White
        Me.savetheme.onHoverState.IconLeftImage = Nothing
        Me.savetheme.onHoverState.IconRightImage = Nothing
        Me.savetheme.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.savetheme.OnIdleState.BorderRadius = 30
        Me.savetheme.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.savetheme.OnIdleState.BorderThickness = 1
        Me.savetheme.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.savetheme.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.savetheme.OnIdleState.IconLeftImage = Nothing
        Me.savetheme.OnIdleState.IconRightImage = Nothing
        Me.savetheme.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.savetheme.OnPressedState.BorderRadius = 30
        Me.savetheme.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.savetheme.OnPressedState.BorderThickness = 1
        Me.savetheme.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.savetheme.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.savetheme.OnPressedState.IconLeftImage = Nothing
        Me.savetheme.OnPressedState.IconRightImage = Nothing
        Me.savetheme.Size = New System.Drawing.Size(121, 35)
        Me.savetheme.TabIndex = 35
        Me.savetheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.savetheme.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.savetheme.TextMarginLeft = 0
        Me.savetheme.TextPadding = New System.Windows.Forms.Padding(0)
        Me.savetheme.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel5.Location = New System.Drawing.Point(121, 160)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(66, 21)
        Me.BunifuLabel5.TabIndex = 34
        Me.BunifuLabel5.Text = "Theme 4"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel4.Location = New System.Drawing.Point(121, 123)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(66, 21)
        Me.BunifuLabel4.TabIndex = 34
        Me.BunifuLabel4.Text = "Theme 3"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel3.Location = New System.Drawing.Point(121, 89)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(66, 21)
        Me.BunifuLabel3.TabIndex = 34
        Me.BunifuLabel3.Text = "Theme 2"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(121, 49)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(66, 21)
        Me.BunifuLabel2.TabIndex = 34
        Me.BunifuLabel2.Text = "Theme 1"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(121, 12)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(58, 21)
        Me.BunifuLabel1.TabIndex = 34
        Me.BunifuLabel1.Text = "Default"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'theme4
        '
        Me.theme4.AllowBindingControlLocation = False
        Me.theme4.BackColor = System.Drawing.Color.Transparent
        Me.theme4.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right
        Me.theme4.BorderThickness = 1
        Me.theme4.Checked = False
        Me.theme4.Location = New System.Drawing.Point(74, 160)
        Me.theme4.Name = "theme4"
        Me.theme4.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme4.OutlineColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme4.OutlineColorUnchecked = System.Drawing.Color.DarkGray
        Me.theme4.RadioColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme4.RadioColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme4.Size = New System.Drawing.Size(21, 21)
        Me.theme4.TabIndex = 33
        Me.theme4.Text = Nothing
        '
        'theme3
        '
        Me.theme3.AllowBindingControlLocation = False
        Me.theme3.BackColor = System.Drawing.Color.Transparent
        Me.theme3.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right
        Me.theme3.BorderThickness = 1
        Me.theme3.Checked = False
        Me.theme3.Location = New System.Drawing.Point(74, 123)
        Me.theme3.Name = "theme3"
        Me.theme3.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme3.OutlineColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme3.OutlineColorUnchecked = System.Drawing.Color.DarkGray
        Me.theme3.RadioColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme3.RadioColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme3.Size = New System.Drawing.Size(21, 21)
        Me.theme3.TabIndex = 32
        Me.theme3.Text = Nothing
        '
        'theme2
        '
        Me.theme2.AllowBindingControlLocation = False
        Me.theme2.BackColor = System.Drawing.Color.Transparent
        Me.theme2.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right
        Me.theme2.BorderThickness = 1
        Me.theme2.Checked = False
        Me.theme2.Location = New System.Drawing.Point(74, 86)
        Me.theme2.Name = "theme2"
        Me.theme2.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme2.OutlineColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme2.OutlineColorUnchecked = System.Drawing.Color.DarkGray
        Me.theme2.RadioColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme2.RadioColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme2.Size = New System.Drawing.Size(21, 21)
        Me.theme2.TabIndex = 31
        Me.theme2.Text = Nothing
        '
        'theme1
        '
        Me.theme1.AllowBindingControlLocation = False
        Me.theme1.BackColor = System.Drawing.Color.Transparent
        Me.theme1.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right
        Me.theme1.BorderThickness = 1
        Me.theme1.Checked = False
        Me.theme1.Location = New System.Drawing.Point(74, 49)
        Me.theme1.Name = "theme1"
        Me.theme1.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme1.OutlineColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme1.OutlineColorUnchecked = System.Drawing.Color.DarkGray
        Me.theme1.RadioColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.theme1.RadioColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.theme1.Size = New System.Drawing.Size(21, 21)
        Me.theme1.TabIndex = 30
        Me.theme1.Text = Nothing
        '
        'defaultt
        '
        Me.defaultt.AllowBindingControlLocation = False
        Me.defaultt.BackColor = System.Drawing.Color.Transparent
        Me.defaultt.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right
        Me.defaultt.BorderThickness = 1
        Me.defaultt.Checked = True
        Me.defaultt.Location = New System.Drawing.Point(74, 12)
        Me.defaultt.Name = "defaultt"
        Me.defaultt.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.defaultt.OutlineColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.defaultt.OutlineColorUnchecked = System.Drawing.Color.DarkGray
        Me.defaultt.RadioColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.defaultt.RadioColorTabFocused = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.defaultt.Size = New System.Drawing.Size(21, 21)
        Me.defaultt.TabIndex = 29
        Me.defaultt.Text = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(470, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "© 2022 Theemain"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Time_Date.My.Resources.Resources.exit1
        Me.PictureBox3.Location = New System.Drawing.Point(538, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'timepanel
        '
        Me.timepanel.BackColor = System.Drawing.Color.White
        Me.timepanel.Controls.Add(Me.Label1)
        Me.timepanel.Location = New System.Drawing.Point(46, 104)
        Me.timepanel.Name = "timepanel"
        Me.timepanel.Size = New System.Drawing.Size(580, 136)
        Me.timepanel.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATE                     TIME"
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Time_Date.My.Resources.Resources.settings
        Me.PictureBox2.Location = New System.Drawing.Point(13, 293)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.toolbar
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuHSlider1
        '
        Me.BunifuHSlider1.AllowCursorChanges = True
        Me.BunifuHSlider1.AllowHomeEndKeysDetection = False
        Me.BunifuHSlider1.AllowIncrementalClickMoves = True
        Me.BunifuHSlider1.AllowMouseDownEffects = False
        Me.BunifuHSlider1.AllowMouseHoverEffects = False
        Me.BunifuHSlider1.AllowScrollingAnimations = True
        Me.BunifuHSlider1.AllowScrollKeysDetection = True
        Me.BunifuHSlider1.AllowScrollOptionsMenu = True
        Me.BunifuHSlider1.AllowShrinkingOnFocusLost = False
        Me.BunifuHSlider1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuHSlider1.BackgroundImage = CType(resources.GetObject("BunifuHSlider1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuHSlider1.BindingContainer = Nothing
        Me.BunifuHSlider1.BorderRadius = 1
        Me.BunifuHSlider1.BorderThickness = 1
        Me.BunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuHSlider1.DrawThickBorder = False
        Me.BunifuHSlider1.DurationBeforeShrink = 2000
        Me.BunifuHSlider1.ElapsedColor = System.Drawing.Color.DodgerBlue
        Me.BunifuHSlider1.LargeChange = 10
        Me.BunifuHSlider1.Location = New System.Drawing.Point(12, 7)
        Me.BunifuHSlider1.Maximum = 100
        Me.BunifuHSlider1.Minimum = 10
        Me.BunifuHSlider1.MinimumSize = New System.Drawing.Size(0, 31)
        Me.BunifuHSlider1.MinimumThumbLength = 18
        Me.BunifuHSlider1.Name = "BunifuHSlider1"
        Me.BunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
        Me.BunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
        Me.BunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver
        Me.BunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuHSlider1.ShrinkSizeLimit = 3
        Me.BunifuHSlider1.Size = New System.Drawing.Size(316, 31)
        Me.BunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
        Me.BunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
        Me.BunifuHSlider1.SmallChange = 10
        Me.BunifuHSlider1.TabIndex = 32
        Me.BunifuHSlider1.ThumbColor = System.Drawing.Color.DodgerBlue
        Me.BunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control
        Me.BunifuHSlider1.ThumbLength = 34
        Me.BunifuHSlider1.ThumbMargin = 1
        Me.BunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
        Me.BunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline
        Me.BunifuHSlider1.Value = 100
        '
        'Timedate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 340)
        Me.Controls.Add(Me.timepanel)
        Me.Controls.Add(Me.themepanel)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Timedate"
        Me.Text = "Time Date"
        Me.toolbar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.themepanel.ResumeLayout(False)
        Me.themepanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.timepanel.ResumeLayout(False)
        Me.timepanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolbar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents themepanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents theme4 As Bunifu.UI.WinForms.BunifuRadioButton
    Friend WithEvents theme3 As Bunifu.UI.WinForms.BunifuRadioButton
    Friend WithEvents theme2 As Bunifu.UI.WinForms.BunifuRadioButton
    Friend WithEvents theme1 As Bunifu.UI.WinForms.BunifuRadioButton
    Friend WithEvents defaultt As Bunifu.UI.WinForms.BunifuRadioButton
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents savetheme As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents timepanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuHSlider1 As Bunifu.UI.WinForms.BunifuHSlider
End Class
