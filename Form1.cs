namespace VTYS_deneme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Eser_btn_Click(object sender, EventArgs e)
        {
            Form2 eserForm = new Form2();
            eserForm.Show();
        }

        private void sanatci_btn_Click(object sender, EventArgs e)
        {
            Form3 sanatciForm = new Form3();
            sanatciForm.Show();

        }

        private void Bilet_btn_Click(object sender, EventArgs e)
        {
            Form4 biletForm = new Form4();
            biletForm.Show();
        }

        private void Ziyaretci_btn_Click(object sender, EventArgs e)
        {
            Form5 ziyaretciform = new Form5();
          ziyaretciform.Show();

        }

        private void Calisan_btn_Click(object sender, EventArgs e)
        {
            Form6 personelform = new Form6();
            personelform.Show();

        }

        private void Hediyelik_btn_Click(object sender, EventArgs e)
        {
            Form7 hediyelikesyaform = new Form7();
            hediyelikesyaform.Show();

        }

       
    }
}