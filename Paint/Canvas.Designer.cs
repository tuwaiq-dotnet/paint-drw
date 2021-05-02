
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.designBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.designBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.designBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.designBtn.ForeColor = System.Drawing.Color.White;
            this.designBtn.Location = new System.Drawing.Point(12, 637);
            this.designBtn.Name = "designBtn";
            this.designBtn.Size = new System.Drawing.Size(100, 32);
            this.designBtn.TabIndex = 2;
            this.designBtn.Text = "Design";
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
            this.sourceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourceBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sourceBtn.ForeColor = System.Drawing.Color.Teal;
            this.sourceBtn.Location = new System.Drawing.Point(118, 637);
            this.sourceBtn.Name = "sourceBtn";
            this.sourceBtn.Size = new System.Drawing.Size(100, 32);
            this.sourceBtn.TabIndex = 3;
            this.sourceBtn.Text = "Source";
            this.sourceBtn.UseVisualStyleBackColor = false;
            this.sourceBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sourceBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(65, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImage = global::Paint.Properties.Resources.save_btn;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(12, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(70, 32);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openBtn.BackColor = System.Drawing.Color.Transparent;
            this.openBtn.BackgroundImage = global::Paint.Properties.Resources.open_btn;
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Location = new System.Drawing.Point(87, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(70, 32);
            this.openBtn.TabIndex = 6;
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            this.openBtn.MouseLeave += new System.EventHandler(this.openBtn_MouseLeave);
            this.openBtn.MouseHover += new System.EventHandler(this.openBtn_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(249, 64);
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
            this.label4.Location = new System.Drawing.Point(365, 82);
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
            this.label5.Location = new System.Drawing.Point(542, 82);
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
            this.rectangleBtn.Location = new System.Drawing.Point(510, 17);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(32, 32);
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
            this.circleBtn.Location = new System.Drawing.Point(559, 17);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(32, 32);
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
            this.lineBtn.Location = new System.Drawing.Point(606, 17);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(32, 32);
            this.lineBtn.TabIndex = 13;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineBtn_MouseClick);
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
            this.drawBtn.Location = new System.Drawing.Point(235, 12);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(32, 32);
            this.drawBtn.TabIndex = 14;
            this.drawBtn.UseVisualStyleBackColor = false;
            this.drawBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawBtn_MouseClick);
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
            this.moveBtn.Location = new System.Drawing.Point(273, 12);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(32, 32);
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
            this.textBox.Location = new System.Drawing.Point(87, 113);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(1076, 23);
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
            this.comboBox1.Location = new System.Drawing.Point(922, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = global::Paint.Properties.Resources.bar;
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 32);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceBtn);
            this.Controls.Add(this.designBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Canvas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Canvas_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button designBtn;
        private System.Windows.Forms.Button sourceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

