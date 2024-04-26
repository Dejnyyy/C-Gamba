using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonksSimulator
{
    public partial class Akcie : UserControl
    {

        StonksForm parentForm; 

        

        double porizovaciCena;
        public double ZmenaCeny => porizovaciCena / 10;
        List<double> historieCen = new List<double>();

        public double aktualniCena;
        public bool jeVPlusu => AktualniCena > porizovaciCena;
        public double AktualniCena
        {
            get => aktualniCena;
            set
            {
                aktualniCena = value;

                label1.ForeColor = jeVPlusu ? Color.Lime : Color.Red;
                label1.Text = AktualniCenaText;
                historieCen.Add(AktualniCena);
            }
        }

        public string AktualniCenaText => $"{aktualniCena}$";
        private Akcie()
        {
            InitializeComponent();

        }
        public Akcie(double porizovaciCena, StonksForm parentForm) : this()
        {
            this.parentForm = parentForm;
            this.porizovaciCena = porizovaciCena;
            this.AktualniCena = porizovaciCena;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int pocetPrvku = 10;
            int index = Math.Clamp(historieCen.Count - pocetPrvku, 0, historieCen.Count);
            int y = pictureBox1.Height / 2;
            int predesleY = pictureBox1.Height / 2;
            for (int i = 1; i < pocetPrvku && i <  historieCen.Count; i++)
            {
                if (historieCen[i + index]  > historieCen[i + index - 1] )
                {
                    y -= 10;
                }
                else if (historieCen[i + index] < historieCen[i + index - 1])
                {
                    y += 10;
                }
                e.Graphics.DrawLine(Pens.Green,
                    (i-1) * ( pictureBox1.Width/ pocetPrvku),
                    predesleY,
                    i *(pictureBox1.Width / pocetPrvku),
                    y);
                predesleY = y;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZmenaTrhu();
            Refresh();
        }

        private void ZmenaTrhu()
        {
            int nahoda = Random.Shared.Next(100);
            if (nahoda > 60)
            {
                AktualniCena += ZmenaCeny;
            }
            else if (nahoda > 40 && nahoda <= 60)
            {
                AktualniCena = AktualniCena;
            }
            else
            {
                AktualniCena -= ZmenaCeny;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdejAkcie();
        }

        private void ProdejAkcie()
        {
            parentForm.AddPenize(AktualniCena);
            parentForm.RemoveAkcie(this);
        }

    }
}
