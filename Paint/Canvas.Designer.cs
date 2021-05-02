
namespace Paint
{
    partial class Canvas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Canvas));
            this.Panel = new System.Windows.Forms.Panel();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.AnchorColorSelectionLabel = new System.Windows.Forms.Label();
            this.BorderColorSelectionLabel = new System.Windows.Forms.Label();
            this.ColorSelectionLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ThicknessLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.FillComboBox = new System.Windows.Forms.CheckBox();
            this.ThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.BorderOffsetCombobox = new System.Windows.Forms.ComboBox();
            this.StyleComboBox = new System.Windows.Forms.ComboBox();
            this.BorderThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.BorderStyleComboBox = new System.Windows.Forms.ComboBox();
            this.BorderColorLabel = new System.Windows.Forms.Label();
            this.BorderThicknessLabel = new System.Windows.Forms.Label();
            this.BorderStyleLabel = new System.Windows.Forms.Label();
            this.BorderOffsetLabel = new System.Windows.Forms.Label();
            this.AnchorColorLabel = new System.Windows.Forms.Label();
            this.AnchorSizeComboBox = new System.Windows.Forms.ComboBox();
            this.AnchorSizeLabel = new System.Windows.Forms.Label();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.SelectionRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.LineRadioButton = new System.Windows.Forms.RadioButton();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripDesignButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSourceButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMousePointLabel = new System.Windows.Forms.ToolStripLabel();
            this.SourceTextbox = new System.Windows.Forms.TextBox();
            this.Panel.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            this.ToolBox.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Controls.Add(this.SettingsBox);
            this.Panel.Controls.Add(this.ToolBox);
            this.Panel.Controls.Add(this.ImportButton);
            this.Panel.Controls.Add(this.SaveButton);
            this.Panel.Location = new System.Drawing.Point(1566, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(400, 1431);
            this.Panel.TabIndex = 0;
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.AnchorColorSelectionLabel);
            this.SettingsBox.Controls.Add(this.BorderColorSelectionLabel);
            this.SettingsBox.Controls.Add(this.ColorSelectionLabel);
            this.SettingsBox.Controls.Add(this.ColorLabel);
            this.SettingsBox.Controls.Add(this.ThicknessLabel);
            this.SettingsBox.Controls.Add(this.StyleLabel);
            this.SettingsBox.Controls.Add(this.FillComboBox);
            this.SettingsBox.Controls.Add(this.ThicknessComboBox);
            this.SettingsBox.Controls.Add(this.BorderOffsetCombobox);
            this.SettingsBox.Controls.Add(this.StyleComboBox);
            this.SettingsBox.Controls.Add(this.BorderThicknessComboBox);
            this.SettingsBox.Controls.Add(this.BorderStyleComboBox);
            this.SettingsBox.Controls.Add(this.BorderColorLabel);
            this.SettingsBox.Controls.Add(this.BorderThicknessLabel);
            this.SettingsBox.Controls.Add(this.BorderStyleLabel);
            this.SettingsBox.Controls.Add(this.BorderOffsetLabel);
            this.SettingsBox.Controls.Add(this.AnchorColorLabel);
            this.SettingsBox.Controls.Add(this.AnchorSizeComboBox);
            this.SettingsBox.Controls.Add(this.AnchorSizeLabel);
            this.SettingsBox.Location = new System.Drawing.Point(12, 315);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(374, 556);
            this.SettingsBox.TabIndex = 5;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Settings";
            // 
            // AnchorColorSelectionLabel
            // 
            this.AnchorColorSelectionLabel.AutoSize = true;
            this.AnchorColorSelectionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnchorColorSelectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnchorColorSelectionLabel.Location = new System.Drawing.Point(196, 450);
            this.AnchorColorSelectionLabel.MinimumSize = new System.Drawing.Size(169, 43);
            this.AnchorColorSelectionLabel.Name = "AnchorColorSelectionLabel";
            this.AnchorColorSelectionLabel.Size = new System.Drawing.Size(169, 43);
            this.AnchorColorSelectionLabel.TabIndex = 14;
            this.AnchorColorSelectionLabel.Click += new System.EventHandler(this.AnchorColorSelectionLabel_Click);
            // 
            // BorderColorSelectionLabel
            // 
            this.BorderColorSelectionLabel.AutoSize = true;
            this.BorderColorSelectionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderColorSelectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorderColorSelectionLabel.Location = new System.Drawing.Point(197, 296);
            this.BorderColorSelectionLabel.MinimumSize = new System.Drawing.Size(169, 43);
            this.BorderColorSelectionLabel.Name = "BorderColorSelectionLabel";
            this.BorderColorSelectionLabel.Size = new System.Drawing.Size(169, 43);
            this.BorderColorSelectionLabel.TabIndex = 14;
            this.BorderColorSelectionLabel.Click += new System.EventHandler(this.BorderColorSelectionLabel_Click);
            // 
            // ColorSelectionLabel
            // 
            this.ColorSelectionLabel.AutoSize = true;
            this.ColorSelectionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColorSelectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorSelectionLabel.Location = new System.Drawing.Point(196, 145);
            this.ColorSelectionLabel.MinimumSize = new System.Drawing.Size(169, 43);
            this.ColorSelectionLabel.Name = "ColorSelectionLabel";
            this.ColorSelectionLabel.Size = new System.Drawing.Size(169, 43);
            this.ColorSelectionLabel.TabIndex = 13;
            this.ColorSelectionLabel.Click += new System.EventHandler(this.ColorSelectionLabel_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(6, 148);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(88, 37);
            this.ColorLabel.TabIndex = 12;
            this.ColorLabel.Text = "Color:";
            // 
            // ThicknessLabel
            // 
            this.ThicknessLabel.AutoSize = true;
            this.ThicknessLabel.Location = new System.Drawing.Point(6, 96);
            this.ThicknessLabel.Name = "ThicknessLabel";
            this.ThicknessLabel.Size = new System.Drawing.Size(135, 37);
            this.ThicknessLabel.TabIndex = 11;
            this.ThicknessLabel.Text = "Thickness:";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(6, 45);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(79, 37);
            this.StyleLabel.TabIndex = 10;
            this.StyleLabel.Text = "Style:";
            // 
            // FillComboBox
            // 
            this.FillComboBox.AutoSize = true;
            this.FillComboBox.Location = new System.Drawing.Point(6, 504);
            this.FillComboBox.Name = "FillComboBox";
            this.FillComboBox.Size = new System.Drawing.Size(83, 41);
            this.FillComboBox.TabIndex = 4;
            this.FillComboBox.Text = "Fill";
            this.FillComboBox.UseVisualStyleBackColor = true;
            this.FillComboBox.CheckedChanged += new System.EventHandler(this.FillComboBox_CheckedChanged);
            // 
            // ThicknessComboBox
            // 
            this.ThicknessComboBox.FormattingEnabled = true;
            this.ThicknessComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.ThicknessComboBox.Location = new System.Drawing.Point(197, 93);
            this.ThicknessComboBox.Name = "ThicknessComboBox";
            this.ThicknessComboBox.Size = new System.Drawing.Size(169, 45);
            this.ThicknessComboBox.TabIndex = 2;
            this.ThicknessComboBox.Text = "Thickness";
            this.ThicknessComboBox.SelectedIndexChanged += new System.EventHandler(this.ThicknessComboBox_SelectedIndexChanged);
            // 
            // BorderOffsetCombobox
            // 
            this.BorderOffsetCombobox.FormattingEnabled = true;
            this.BorderOffsetCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.BorderOffsetCombobox.Location = new System.Drawing.Point(196, 345);
            this.BorderOffsetCombobox.Name = "BorderOffsetCombobox";
            this.BorderOffsetCombobox.Size = new System.Drawing.Size(169, 45);
            this.BorderOffsetCombobox.TabIndex = 9;
            this.BorderOffsetCombobox.Text = "Offset";
            this.BorderOffsetCombobox.SelectedIndexChanged += new System.EventHandler(this.BorderOffsetCombobox_SelectedIndexChanged);
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash-Dot",
            "Dash-Dot-Dot"});
            this.StyleComboBox.Location = new System.Drawing.Point(197, 42);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(169, 45);
            this.StyleComboBox.TabIndex = 1;
            this.StyleComboBox.Text = "Style";
            this.StyleComboBox.SelectedIndexChanged += new System.EventHandler(this.StyleComboBox_SelectedIndexChanged);
            // 
            // BorderThicknessComboBox
            // 
            this.BorderThicknessComboBox.FormattingEnabled = true;
            this.BorderThicknessComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.BorderThicknessComboBox.Location = new System.Drawing.Point(197, 245);
            this.BorderThicknessComboBox.Name = "BorderThicknessComboBox";
            this.BorderThicknessComboBox.Size = new System.Drawing.Size(169, 45);
            this.BorderThicknessComboBox.TabIndex = 5;
            this.BorderThicknessComboBox.Text = "Width";
            this.BorderThicknessComboBox.SelectedIndexChanged += new System.EventHandler(this.BorderThicknessComboBox_SelectedIndexChanged);
            // 
            // BorderStyleComboBox
            // 
            this.BorderStyleComboBox.FormattingEnabled = true;
            this.BorderStyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash-Dot",
            "Dash-Dot-Dot"});
            this.BorderStyleComboBox.Location = new System.Drawing.Point(197, 194);
            this.BorderStyleComboBox.Name = "BorderStyleComboBox";
            this.BorderStyleComboBox.Size = new System.Drawing.Size(168, 45);
            this.BorderStyleComboBox.TabIndex = 5;
            this.BorderStyleComboBox.Text = "Style";
            this.BorderStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.BorderStyleComboBox_SelectedIndexChanged);
            // 
            // BorderColorLabel
            // 
            this.BorderColorLabel.AutoSize = true;
            this.BorderColorLabel.Location = new System.Drawing.Point(4, 299);
            this.BorderColorLabel.Name = "BorderColorLabel";
            this.BorderColorLabel.Size = new System.Drawing.Size(174, 37);
            this.BorderColorLabel.TabIndex = 7;
            this.BorderColorLabel.Text = "Border Color:";
            // 
            // BorderThicknessLabel
            // 
            this.BorderThicknessLabel.AutoSize = true;
            this.BorderThicknessLabel.Location = new System.Drawing.Point(4, 248);
            this.BorderThicknessLabel.Name = "BorderThicknessLabel";
            this.BorderThicknessLabel.Size = new System.Drawing.Size(181, 37);
            this.BorderThicknessLabel.TabIndex = 6;
            this.BorderThicknessLabel.Text = "Border Width:";
            // 
            // BorderStyleLabel
            // 
            this.BorderStyleLabel.AutoSize = true;
            this.BorderStyleLabel.Location = new System.Drawing.Point(4, 197);
            this.BorderStyleLabel.Name = "BorderStyleLabel";
            this.BorderStyleLabel.Size = new System.Drawing.Size(165, 37);
            this.BorderStyleLabel.TabIndex = 5;
            this.BorderStyleLabel.Text = "Border Style:";
            // 
            // BorderOffsetLabel
            // 
            this.BorderOffsetLabel.AutoSize = true;
            this.BorderOffsetLabel.Location = new System.Drawing.Point(4, 348);
            this.BorderOffsetLabel.Name = "BorderOffsetLabel";
            this.BorderOffsetLabel.Size = new System.Drawing.Size(179, 37);
            this.BorderOffsetLabel.TabIndex = 4;
            this.BorderOffsetLabel.Text = "Border Offset:";
            // 
            // AnchorColorLabel
            // 
            this.AnchorColorLabel.AutoSize = true;
            this.AnchorColorLabel.Location = new System.Drawing.Point(4, 450);
            this.AnchorColorLabel.Name = "AnchorColorLabel";
            this.AnchorColorLabel.Size = new System.Drawing.Size(179, 37);
            this.AnchorColorLabel.TabIndex = 2;
            this.AnchorColorLabel.Text = "Anchor Color:";
            // 
            // AnchorSizeComboBox
            // 
            this.AnchorSizeComboBox.FormattingEnabled = true;
            this.AnchorSizeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.AnchorSizeComboBox.Location = new System.Drawing.Point(197, 396);
            this.AnchorSizeComboBox.Name = "AnchorSizeComboBox";
            this.AnchorSizeComboBox.Size = new System.Drawing.Size(169, 45);
            this.AnchorSizeComboBox.TabIndex = 1;
            this.AnchorSizeComboBox.Text = "16";
            this.AnchorSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.AnchorSizeComboBox_SelectedIndexChanged);
            // 
            // AnchorSizeLabel
            // 
            this.AnchorSizeLabel.AutoSize = true;
            this.AnchorSizeLabel.Location = new System.Drawing.Point(4, 399);
            this.AnchorSizeLabel.Name = "AnchorSizeLabel";
            this.AnchorSizeLabel.Size = new System.Drawing.Size(161, 37);
            this.AnchorSizeLabel.TabIndex = 0;
            this.AnchorSizeLabel.Text = "Anchor Size:";
            // 
            // ToolBox
            // 
            this.ToolBox.Controls.Add(this.SelectionRadioButton);
            this.ToolBox.Controls.Add(this.RectangleRadioButton);
            this.ToolBox.Controls.Add(this.CircleRadioButton);
            this.ToolBox.Controls.Add(this.LineRadioButton);
            this.ToolBox.Location = new System.Drawing.Point(12, 69);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(374, 240);
            this.ToolBox.TabIndex = 3;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "Tools";
            // 
            // SelectionRadioButton
            // 
            this.SelectionRadioButton.AutoSize = true;
            this.SelectionRadioButton.Location = new System.Drawing.Point(6, 183);
            this.SelectionRadioButton.Name = "SelectionRadioButton";
            this.SelectionRadioButton.Size = new System.Drawing.Size(143, 41);
            this.SelectionRadioButton.TabIndex = 2;
            this.SelectionRadioButton.TabStop = true;
            this.SelectionRadioButton.Text = "Selector";
            this.SelectionRadioButton.UseVisualStyleBackColor = true;
            this.SelectionRadioButton.CheckedChanged += new System.EventHandler(this.SelectionRadioButton_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Location = new System.Drawing.Point(6, 136);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(164, 41);
            this.RectangleRadioButton.TabIndex = 1;
            this.RectangleRadioButton.TabStop = true;
            this.RectangleRadioButton.Text = "Rectangle";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(6, 89);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(114, 41);
            this.CircleRadioButton.TabIndex = 1;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Circle";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.CircleRadioButton_CheckedChanged);
            // 
            // LineRadioButton
            // 
            this.LineRadioButton.AutoSize = true;
            this.LineRadioButton.Location = new System.Drawing.Point(6, 42);
            this.LineRadioButton.Name = "LineRadioButton";
            this.LineRadioButton.Size = new System.Drawing.Size(97, 41);
            this.LineRadioButton.TabIndex = 0;
            this.LineRadioButton.TabStop = true;
            this.LineRadioButton.Text = "Line";
            this.LineRadioButton.UseVisualStyleBackColor = true;
            this.LineRadioButton.CheckedChanged += new System.EventHandler(this.LineRadioButton_CheckedChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(211, 12);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(175, 51);
            this.ImportButton.TabIndex = 2;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(193, 51);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDesignButton,
            this.ToolStripSeperator1,
            this.ToolStripSourceButton,
            this.ToolStripSeparator2,
            this.ToolStripMousePointLabel});
            this.ToolStrip.Location = new System.Drawing.Point(0, 1408);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1978, 47);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripDesignButton
            // 
            this.ToolStripDesignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDesignButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDesignButton.Name = "ToolStripDesignButton";
            this.ToolStripDesignButton.Size = new System.Drawing.Size(103, 41);
            this.ToolStripDesignButton.Text = "Design";
            this.ToolStripDesignButton.Click += new System.EventHandler(this.ToolStripDesignButton_Click);
            // 
            // ToolStripSeperator1
            // 
            this.ToolStripSeperator1.Name = "ToolStripSeperator1";
            this.ToolStripSeperator1.Size = new System.Drawing.Size(6, 47);
            // 
            // ToolStripSourceButton
            // 
            this.ToolStripSourceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripSourceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSourceButton.Name = "ToolStripSourceButton";
            this.ToolStripSourceButton.Size = new System.Drawing.Size(101, 41);
            this.ToolStripSourceButton.Text = "Source";
            this.ToolStripSourceButton.Click += new System.EventHandler(this.ToolStripSourceButton_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // ToolStripMousePointLabel
            // 
            this.ToolStripMousePointLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMousePointLabel.Name = "ToolStripMousePointLabel";
            this.ToolStripMousePointLabel.Size = new System.Drawing.Size(0, 41);
            this.ToolStripMousePointLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // SourceTextbox
            // 
            this.SourceTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceTextbox.Location = new System.Drawing.Point(12, 12);
            this.SourceTextbox.Multiline = true;
            this.SourceTextbox.Name = "SourceTextbox";
            this.SourceTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SourceTextbox.Size = new System.Drawing.Size(1954, 1393);
            this.SourceTextbox.TabIndex = 2;
            this.SourceTextbox.Text = resources.GetString("SourceTextbox.Text");
            this.SourceTextbox.Visible = false;
            // 
            // Canvas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1978, 1455);
            this.Controls.Add(this.SourceTextbox);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.Panel);
            this.DoubleBuffered = true;
            this.Name = "Canvas";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Canvas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.Panel.ResumeLayout(false);
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.ToolBox.ResumeLayout(false);
            this.ToolBox.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox ToolBox;
        private System.Windows.Forms.RadioButton LineRadioButton;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.RadioButton SelectionRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.CheckBox FillComboBox;
        private System.Windows.Forms.ComboBox ThicknessComboBox;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label ThicknessLabel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.ComboBox BorderOffsetCombobox;
        private System.Windows.Forms.ComboBox BorderThicknessComboBox;
        private System.Windows.Forms.ComboBox BorderStyleComboBox;
        private System.Windows.Forms.Label BorderColorLabel;
        private System.Windows.Forms.Label BorderThicknessLabel;
        private System.Windows.Forms.Label BorderStyleLabel;
        private System.Windows.Forms.Label BorderOffsetLabel;
        private System.Windows.Forms.Label AnchorColorLabel;
        private System.Windows.Forms.ComboBox AnchorSizeComboBox;
        private System.Windows.Forms.Label AnchorSizeLabel;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripDesignButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton ToolStripSourceButton;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeperator1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ToolStripMousePointLabel;
        private System.Windows.Forms.Label AnchorColorSelectionLabel;
        private System.Windows.Forms.Label BorderColorSelectionLabel;
        private System.Windows.Forms.Label ColorSelectionLabel;
        private System.Windows.Forms.TextBox SourceTextbox;
    }
}