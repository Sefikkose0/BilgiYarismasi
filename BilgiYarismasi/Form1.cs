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
				richTextBox1.Text = "Saint Pierre Kilisesi Hangi �limizdedir";
				BtnA.Text = "Bursa";
				BtnB.Text = "�stanbul";
				BtnC.Text = "Mardin";
				BtnD.Text = "Hatay";
				label4.Text = "Hatay";
				BtnSonraki.Text = "Sonu�";

			}

			if (soruno == 1)
			{
				richTextBox1.Text = "Cumhuriyet ka� y�l�nda Kurulmu�tur";
				BtnA.Text = "1920";
				BtnB.Text = "1921";
				BtnC.Text = "1922";
				BtnD.Text = "1923";
				label4.Text = "1923";
			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Hangi ilimiz Ege B�lgesinde bulunmaz ";
				BtnA.Text = "Bal�kesir";
				BtnB.Text = "Ayd�n";
				BtnC.Text = "Mu�la";
				BtnD.Text = "�zmir";
				label4.Text = "Bal�kesir";
			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Son Ku�lar hangi yazar�m�za aittir";
				BtnA.Text = "Sait Faik Abas�yan�k";
				BtnB.Text = "Re�at Nuri G�ntekin";
				BtnC.Text = "Cemal S�reya";
				BtnD.Text = "Atilla �lhan";
				label4.Text = "Sait Faik Abas�yan�k";
				
			}
			if (soruno == 5)
			{
				BtnA.Enabled = false;
				BtnB.Enabled = false;
				BtnC.Enabled = false;
				BtnD.Enabled = false;
				MessageBox.Show(" Do�ru= " + dogru + " \n " + " Yanl��= " + yanlis);
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
