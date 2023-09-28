namespace SifreKontrolüÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSifreGiris_TextChanged(object sender, EventArgs e)
        {
            string sifre;
            sifre = txtSifreGiris.Text;

            string harfler = "ABCDEFGHIİJKLMNOÖPRSŞTUÜVYZabcçdefghıijklmnoöprsştuüvyz";
            string sayilar = "0123456789";
            string ozel = "*/";

            bool harfMi = false;
            bool sayMi = false;
            bool ozelMi = false;



            if (sifre.Length < 6)
            {
                label3.Text = "zayıf";
                label3.BackColor = Color.Red;

            }
            foreach (char item in sifre)
            {
                if (harfler.IndexOf(item) != -1)
                {
                    harfMi = true;
                }

                if (sayilar.IndexOf(item) != -1)
                {
                    sayMi = true;
                }
                if (ozel.IndexOf(item) != -1)
                {
                    ozelMi = true;
                }
            }

            if (harfMi == true && sayMi == true && ozelMi == true)
            {
                label3.Text = "Güçlü";
                label3.BackColor = Color.Green;
            }
            else if (harfMi == true && sayMi == true || harfMi == true && ozelMi == true || ozelMi == true && sayMi == true)
            {
                label3.Text = "Orta";
                label3.BackColor = Color.Blue;
            }
            else
            {
                label3.Text = "Zayıf";
                label3.BackColor = Color.Red;
            }

        }
    }
}