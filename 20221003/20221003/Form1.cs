namespace _20221003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osszeg_v1(string num1_str, string num2_str)
        {
            int num1 = Convert.ToInt32(num1_str);
            int num2 = Convert.ToInt32(num2_str);
            int osszeg = num1 + num2;
            Eredmeny.Text = osszeg.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string num1_str = szam1.Text;
            string num2_str = szam2.Text;

            // osszeg_v1(num1_str, num2_str);
            int num1;
            int num2;
            bool num1_siker = int.TryParse(num1_str, out num1);
            bool num2_siker = int.TryParse(num2_str, out num2);

            Font veribig = new Font("Arial", 20);
            Font normal = new Font("Segoe UI", 9);
            Eredmeny.ForeColor = Color.Red;
            Eredmeny.Font = veribig;
            if (!num1_siker && !num2_siker)
                Eredmeny.Text = "HIBA: Egyik szám sem integer!!!";
            else if (!num1_siker)
                Eredmeny.Text = "HIBA: SZÁM1 nem integer!!!";
            else if (!num2_siker)
                Eredmeny.Text = "HIBA: SZÁM2 nem integer!!!";
            else
            {
                int osszeg = num1 + num2;
                Eredmeny.ForeColor = Color.Black;
                Eredmeny.Font = normal;
                Eredmeny.Text = osszeg.ToString();
            }

        }

        
    }
}