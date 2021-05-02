
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.designBtn = new System.Windows.Forms.Button();
            this.sourceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.whiteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // designBtn
            // 
            this.designBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.designBtn.AutoSize = true;
            this.designBtn.BackColor = System.Drawing.Color.Teal;
            this.designBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.designBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.designBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.designBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.designBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.designBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.designBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.designBtn.ForeColor = System.Drawing.Color.White;
            this.designBtn.Location = new System.Drawing.Point(12, 635);
            this.designBtn.Name = "designBtn";
            this.designBtn.Size = new System.Drawing.Size(100, 34);
            this.designBtn.TabIndex = 2;
            this.designBtn.Text = "Design";
            this.designBtn.UseMnemonic = false;
            this.designBtn.UseVisualStyleBackColor = false;
            this.designBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.designBtn_MouseClick);
            // 
            // sourceBtn
            // 
            this.sourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sourceBtn.AutoSize = true;
            this.sourceBtn.BackColor = System.Drawing.Color.Transparent;
            this.sourceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sourceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sourceBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.sourceBtn.FlatAppearance.BorderSize = 2;
            this.sourceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sourceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.sourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourceBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sourceBtn.ForeColor = System.Drawing.Color.Teal;
            this.sourceBtn.Location = new System.Drawing.Point(118, 635);
            this.sourceBtn.Name = "sourceBtn";
            this.sourceBtn.Size = new System.Drawing.Size(100, 34);
            this.sourceBtn.TabIndex = 3;
            this.sourceBtn.Text = "Source";
            this.sourceBtn.UseVisualStyleBackColor = false;
            this.sourceBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sourceBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(180, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tools";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(341, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Colors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(785, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shapes";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.BackColor = System.Drawing.Color.Transparent;
            this.rectangleBtn.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.rectangleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleBtn.FlatAppearance.BorderSize = 0;
            this.rectangleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rectangleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleBtn.Location = new System.Drawing.Point(647, 285);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(32, 34);
            this.rectangleBtn.TabIndex = 11;
            this.rectangleBtn.UseVisualStyleBackColor = false;
            this.rectangleBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleBtn_MouseClick);
            // 
            // circleBtn
            // 
            this.circleBtn.BackColor = System.Drawing.Color.Transparent;
            this.circleBtn.BackgroundImage = global::Paint.Properties.Resources.circle;
            this.circleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleBtn.FlatAppearance.BorderSize = 0;
            this.circleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.circleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.circleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleBtn.Location = new System.Drawing.Point(597, 285);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(32, 34);
            this.circleBtn.TabIndex = 12;
            this.circleBtn.UseVisualStyleBackColor = false;
            this.circleBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circleBtn_MouseClick);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.Transparent;
            this.lineBtn.BackgroundImage = global::Paint.Properties.Resources.line;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineBtn.FlatAppearance.BorderSize = 0;
            this.lineBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lineBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.Location = new System.Drawing.Point(542, 263);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(32, 34);
            this.lineBtn.TabIndex = 13;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineBtn_MouseClick);
            // 
            // moveBtn
            // 
            this.moveBtn.BackColor = System.Drawing.Color.Transparent;
            this.moveBtn.BackgroundImage = global::Paint.Properties.Resources.move;
            this.moveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.moveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveBtn.FlatAppearance.BorderSize = 0;
            this.moveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.moveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.moveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveBtn.Location = new System.Drawing.Point(186, 50);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(32, 34);
            this.moveBtn.TabIndex = 15;
            this.moveBtn.UseVisualStyleBackColor = false;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            this.moveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseClick);
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.AcceptsTab = true;
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.Color.Teal;
            this.textBox.Location = new System.Drawing.Point(87, 121);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(1076, 25);
            this.textBox.TabIndex = 17;
            this.textBox.WordWrap = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Solid",
            "Dot",
            "Dash"});
            this.comboBox1.Location = new System.Drawing.Point(681, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.Teal;
            this.saveBtn.Location = new System.Drawing.Point(12, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 36);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // openBtn
            // 
            this.openBtn.AutoSize = true;
            this.openBtn.BackColor = System.Drawing.Color.Transparent;
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.openBtn.FlatAppearance.BorderSize = 2;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openBtn.ForeColor = System.Drawing.Color.Teal;
            this.openBtn.Location = new System.Drawing.Point(12, 54);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(85, 36);
            this.openBtn.TabIndex = 21;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            this.openBtn.MouseLeave += new System.EventHandler(this.openBtn_MouseLeave);
            this.openBtn.MouseHover += new System.EventHandler(this.openBtn_MouseHover);
            // 
            // drawBtn
            // 
            this.drawBtn.BackColor = System.Drawing.Color.Transparent;
            this.drawBtn.BackgroundImage = global::Paint.Properties.Resources.draw;
            this.drawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.drawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawBtn.FlatAppearance.BorderSize = 0;
            this.drawBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.drawBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.drawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawBtn.Location = new System.Drawing.Point(186, 12);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(32, 34);
            this.drawBtn.TabIndex = 14;
            this.drawBtn.UseVisualStyleBackColor = false;
            this.drawBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawBtn_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(118, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "|";
            // 
            // whiteBtn
            // 
            this.whiteBtn.BackColor = System.Drawing.Color.Transparent;
            this.whiteBtn.BackgroundImage = global::Paint.Properties.Resources.white;
            this.whiteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.whiteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whiteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.whiteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.whiteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.whiteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whiteBtn.Location = new System.Drawing.Point(305, 12);
            this.whiteBtn.Name = "whiteBtn";
            this.whiteBtn.Size = new System.Drawing.Size(36, 36);
            this.whiteBtn.TabIndex = 23;
            this.whiteBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Paint.Properties.Resources.black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(347, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Paint.Properties.Resources.gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(389, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Paint.Properties.Resources.red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(305, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 36);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Paint.Properties.Resources.green;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(347, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 36);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Paint.Properties.Resources.blue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(389, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 36);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(259, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "|";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Paint.Properties.Resources.blue;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(431, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 36);
            this.button6.TabIndex = 30;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.whiteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.rectangleBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceBtn);
            this.Controls.Add(this.designBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Canvas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Canvas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button designBtn;
        private System.Windows.Forms.Button sourceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button whiteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
    }
}

