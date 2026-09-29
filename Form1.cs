namespace ListBox
{

    public partial class Form1 : Form
    {
        List<string> OrigineDati=new List<string>();

        public Form1()
        {
            InitializeComponent();
            OrigineDati.Add("Cane");
            OrigineDati.Add("Gatto");
            OrigineDati.Add("Lupo");
            OrigineDati.Add("Volpe");
            OrigineDati.Add("Orso");
            OrigineDati.Add("Tigre");
            OrigineDati.Add("Leone");
            OrigineDati.Add("Elefante");
            OrigineDati.Add("Giraffa");
            OrigineDati.Add("Zebra");
            OrigineDati.Add("Cavallo");
            OrigineDati.Add("Delfino");
            OrigineDati.Add("Aquila");
            OrigineDati.Add("Gufo");
            OrigineDati.Add("Pinguino");
            OrigineDati.Add("Tartaruga");
            aggiorna();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textmodifica_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtaggiungi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtaggiungi.Text== null || txtaggiungi.Text == "")
            {
                MessageBox.Show("ERRORE TEXTBOX VUOTA");
            }
            else
            {
                string elementoAggiornato = txtaggiungi.Text.ToLower();
                OrigineDati.Add(elementoAggiornato);
                aggiorna();

            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void aggiorna()
        {
            listBox1.Items.Clear();

            foreach(string a in OrigineDati)
            {
                listBox1.Items.Add(a);
            }
        }
    }


}
