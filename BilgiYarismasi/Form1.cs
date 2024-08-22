namespace BilgiYarismasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int soruno = 0, dogru = 0, yanlis = 0;
		private void BtnSonraki_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = true;
			BtnB.Enabled = true;
			BtnC.Enabled = true;
			BtnD.Enabled = true;
			BtnSonraki.Enabled = false;

			pictureBox1.Visible = false;
			pictureBox2.Visible = false;

			soruno++;
			LblSoruNo.Text = soruno.ToString();
			if (soruno == 4)
			{
				richTextBox1.Text = "Saint Pierre Kilisesi Hangi Ýlimizdedir";
				BtnA.Text = "Bursa";
				BtnB.Text = "Ýstanbul";
				BtnC.Text = "Mardin";
				BtnD.Text = "Hatay";
				label4.Text = "Hatay";
				BtnSonraki.Text = "Sonuç";

			}

			if (soruno == 1)
			{
				richTextBox1.Text = "Cumhuriyet kaç yýlýnda Kurulmuþtur";
				BtnA.Text = "1920";
				BtnB.Text = "1921";
				BtnC.Text = "1922";
				BtnD.Text = "1923";
				label4.Text = "1923";
			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Hangi ilimiz Ege Bölgesinde bulunmaz ";
				BtnA.Text = "Balýkesir";
				BtnB.Text = "Aydýn";
				BtnC.Text = "Muðla";
				BtnD.Text = "Ýzmir";
				label4.Text = "Balýkesir";
			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Son Kuþlar hangi yazarýmýza aittir";
				BtnA.Text = "Sait Faik Abasýyanýk";
				BtnB.Text = "Reþat Nuri Güntekin";
				BtnC.Text = "Cemal Süreya";
				BtnD.Text = "Atilla Ýlhan";
				label4.Text = "Sait Faik Abasýyanýk";
				
			}
			if (soruno == 5)
			{
				BtnA.Enabled = false;
				BtnB.Enabled = false;
				BtnC.Enabled = false;
				BtnD.Enabled = false;
				MessageBox.Show(" Doðru= " + dogru + " \n " + " Yanlýþ= " + yanlis);
			}

	



		}

		private void BtnA_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;


			label5.Text = BtnA.Text;
			if (label5.Text == label4.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
			
		}

		private void BtnB_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnB.Text;
			if (label5.Text == label4.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
			

		}

		private void BtnC_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnC.Text;
			if (label5.Text == label4.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
			

		}

		private void BtnD_Click(object sender, EventArgs e)
		{
			BtnA.Enabled = false;
			BtnB.Enabled = false;
			BtnC.Enabled = false;
			BtnD.Enabled = false;
			BtnSonraki.Enabled = true;

			label5.Text = BtnD.Text;
			if (label5.Text == label4.Text)
			{
				dogru++;
				LblDogru.Text = dogru.ToString();
				pictureBox1.Visible = true;
			}
			else
			{
				yanlis++;
				LblYanlis.Text = yanlis.ToString();
				pictureBox2.Visible = true;
			}
			
		}
	}
}
