namespace StonksSimulator
{
    public partial class StonksForm : Form
    {


        private List<Akcie> meAkcie = new List<Akcie>();
        private double penize;
        public double Penize
        {
            get => penize;
            set
            {   
                penize = value;
                numericUpDown1.Maximum = (decimal)Penize;
                numericUpDown1.Minimum = 1;
                label1.Text = $"Peníze v bance:{penize}$";
            }
        }
        public StonksForm()
        {
            InitializeComponent();
            Penize = 190;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(meAkcie.Count < 5)
            {
                VlozAkcie();
            }
            else
            {
                MessageBox.Show("mas problem bro");
            }
        }
        public void AddPenize(double amount)
        {
            Penize += amount;
            if (penize > 200)
            {
                MessageBox.Show("Mistr Penez");
            }
        }
        public void RemoveAkcie(Akcie akcie)
        {
            flowLayoutPanel1.Controls.Remove(akcie); 
            meAkcie.Remove(akcie);
        }
        private void VlozAkcie()
        {
            Akcie akcie = new Akcie((double)numericUpDown1.Value, this); 
            meAkcie.Add(akcie);
            penize -= (double)numericUpDown1.Value;
            label1.Text = $"Peníze v bance: {penize}$";
            numericUpDown1.Maximum = (decimal)Penize;
            flowLayoutPanel1.Controls.Add(akcie);
        }
      
    }
}
