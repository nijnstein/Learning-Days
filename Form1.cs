namespace Datums01
{
    public partial class Form1 : Form
    {
        int vraagNr = 0;
        int aantalGoed = 0;
        int aantalFout = 0;

        Vraag vraag = null;
        int[] antwoordmap = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Volgende(); 
        }

        void Volgende()
        {
            bericht.Visible = false;

            vraagNr++;

            vraag = VraagGenerator.Volgende();
            antwoordmap = VraagGenerator.Randomize(new int[] { 1, 2, 3, 4 });

            button1.Text = vraag[antwoordmap[0]];
            button2.Text = vraag[antwoordmap[1]];
            button3.Text = vraag[antwoordmap[2]];
            button4.Text = vraag[antwoordmap[3]];

            button1.Tag = antwoordmap[0];
            button2.Tag = antwoordmap[1];
            button3.Tag = antwoordmap[2];
            button4.Tag = antwoordmap[3];

            goedLabel.Text = $"Aantal goed: {aantalGoed}";
            foutLabel.Text = $"Aantal fout: {aantalFout}";
            VraagLabel.Text = vraag.Text;
            Text = $"Datums01: Vraag {vraagNr}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((int)(sender as Button).Tag == 1)
            {
                aantalGoed++;

                bericht.Text = "GOED"; 
                bericht.ForeColor = Color.Green;
                bericht.Visible = true;

                Application.DoEvents();
                Thread.Sleep(1000);
                
                Volgende(); 
            }
            else
            {
                aantalFout++;

                bericht.Text = "FOUT";
                bericht.ForeColor = Color.Red;
                bericht.Visible = true;

                Application.DoEvents();
                Thread.Sleep(2000);

                bericht.Visible = false;
            }
        }
    }
}
