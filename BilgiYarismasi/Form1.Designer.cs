namespace BilgiYarismasi
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			richTextBox1 = new RichTextBox();
			BtnA = new Button();
			BtnB = new Button();
			BtnC = new Button();
			BtnD = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			BtnSonraki = new Button();
			LblSoruNo = new Label();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			LblDogru = new Label();
			LblYanlis = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			label4 = new Label();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = Color.FromArgb(255, 255, 192);
			richTextBox1.Location = new Point(12, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(492, 189);
			richTextBox1.TabIndex = 0;
			richTextBox1.Text = "";
			// 
			// BtnA
			// 
			BtnA.Location = new Point(12, 219);
			BtnA.Name = "BtnA";
			BtnA.Size = new Size(215, 43);
			BtnA.TabIndex = 1;
			BtnA.Text = "A";
			BtnA.UseVisualStyleBackColor = true;
			BtnA.Click += BtnA_Click;
			// 
			// BtnB
			// 
			BtnB.Location = new Point(289, 219);
			BtnB.Name = "BtnB";
			BtnB.Size = new Size(215, 43);
			BtnB.TabIndex = 2;
			BtnB.Text = "B";
			BtnB.UseVisualStyleBackColor = true;
			BtnB.Click += BtnB_Click;
			// 
			// BtnC
			// 
			BtnC.Location = new Point(12, 268);
			BtnC.Name = "BtnC";
			BtnC.Size = new Size(215, 43);
			BtnC.TabIndex = 3;
			BtnC.Text = "C";
			BtnC.UseVisualStyleBackColor = true;
			BtnC.Click += BtnC_Click;
			// 
			// BtnD
			// 
			BtnD.Location = new Point(289, 268);
			BtnD.Name = "BtnD";
			BtnD.Size = new Size(215, 43);
			BtnD.TabIndex = 4;
			BtnD.Text = "D";
			BtnD.UseVisualStyleBackColor = true;
			BtnD.Click += BtnD_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(573, 35);
			label1.Name = "label1";
			label1.Size = new Size(96, 28);
			label1.TabIndex = 5;
			label1.Text = "Soru No:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(592, 63);
			label2.Name = "label2";
			label2.Size = new Size(77, 28);
			label2.TabIndex = 6;
			label2.Text = "Doğru:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(597, 91);
			label3.Name = "label3";
			label3.Size = new Size(72, 28);
			label3.TabIndex = 7;
			label3.Text = "Yanlış:";
			// 
			// BtnSonraki
			// 
			BtnSonraki.Location = new Point(592, 138);
			BtnSonraki.Name = "BtnSonraki";
			BtnSonraki.Size = new Size(103, 35);
			BtnSonraki.TabIndex = 8;
			BtnSonraki.Text = "Sonraki";
			BtnSonraki.UseVisualStyleBackColor = true;
			BtnSonraki.Click += BtnSonraki_Click;
			// 
			// LblSoruNo
			// 
			LblSoruNo.AutoSize = true;
			LblSoruNo.Location = new Point(666, 35);
			LblSoruNo.Name = "LblSoruNo";
			LblSoruNo.Size = new Size(24, 28);
			LblSoruNo.TabIndex = 9;
			LblSoruNo.Text = "0";
			// 
			// LblDogru
			// 
			LblDogru.AutoSize = true;
			LblDogru.Location = new Point(666, 63);
			LblDogru.Name = "LblDogru";
			LblDogru.Size = new Size(24, 28);
			LblDogru.TabIndex = 10;
			LblDogru.Text = "0";
			// 
			// LblYanlis
			// 
			LblYanlis.AutoSize = true;
			LblYanlis.Location = new Point(666, 91);
			LblYanlis.Name = "LblYanlis";
			LblYanlis.Size = new Size(24, 28);
			LblYanlis.TabIndex = 11;
			LblYanlis.Text = "0";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(583, 219);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(125, 92);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 12;
			pictureBox1.TabStop = false;
			pictureBox1.Visible = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(583, 219);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(125, 92);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 13;
			pictureBox2.TabStop = false;
			pictureBox2.Visible = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(240, 323);
			label4.Name = "label4";
			label4.Size = new Size(68, 28);
			label4.TabIndex = 14;
			label4.Text = "label4";
			label4.Visible = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(314, 323);
			label5.Name = "label5";
			label5.Size = new Size(67, 28);
			label5.TabIndex = 15;
			label5.Text = "label5";
			label5.Visible = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(12F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(747, 327);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(LblYanlis);
			Controls.Add(LblDogru);
			Controls.Add(LblSoruNo);
			Controls.Add(BtnSonraki);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(BtnD);
			Controls.Add(BtnC);
			Controls.Add(BtnB);
			Controls.Add(BtnA);
			Controls.Add(richTextBox1);
			Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			Margin = new Padding(4);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox richTextBox1;
		private Button BtnA;
		private Button BtnB;
		private Button BtnC;
		private Button BtnD;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button BtnSonraki;
		private Label LblSoruNo;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label LblDogru;
		private Label LblYanlis;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label4;
		private Label label5;
	}
}
