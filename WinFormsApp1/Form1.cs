using System.ComponentModel.Design;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // declaration de la variable personne
        private List<string[]> personnes;
        public Form1()
        {
            InitializeComponent();

            // Creation du bouton
            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.HeaderText = "Action";
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.UseColumnTextForButtonValue = true; // afficher le texte dans le bouton


            dgContacts.AllowUserToAddRows = false;

            personnes = new List<string[]>
            {
                new string[] { "Jean", "25" },
                new string[] { "Paul", "30" },
                new string[] { "Marie", "28" }
            };

            DataTable dataTable = new DataTable();


            dataTable.Columns.Add("Nom", typeof(string));
            dataTable.Columns.Add("Age", typeof(string));

            foreach (string[] personne in personnes)
            {
                dataTable.Rows.Add(personne[0], personne[1]);
            }

            this.dgContacts.DataSource = dataTable;
            this.dgContacts.Columns.Add(btnSupprimer);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Recuperer les valeurs des textBox 
            // type nom = <valeur>;
            string nom = textBox1.Text; // txtNom.Text;
            string email = textBox2.Text; // txtEmail.Text;
            string age = this.txtAge.Text;

            if (nom == "" || email == "" || age == "")
            {
                MessageBox.Show("Merci de remplir  tous les champs!");
            }
            else
            {
                // Ajout d'une nouvelle personne
                personnes.Add(new string[] { nom, age });

                DataTable dataTable = new DataTable();


                dataTable.Columns.Add("Nom", typeof(string));
                dataTable.Columns.Add("Age", typeof(string));

                foreach (string[] personne in personnes)
                {
                    dataTable.Rows.Add(personne[0], personne[1]);
                }

                this.dgContacts.DataSource = dataTable;
            }
            // Afficher ces valeurs dans une messageBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("@"))
            {
                this.erreurEmail.Show();
            }
            else
            {
                this.erreurEmail.Hide();
            }
            // verifier si le formulaire est valide et afficher le bouton le cas echeant
            verifForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                this.erreurNom.Hide();
            }
            else
            {
                this.erreurNom.Show();
            }
            // verifier si le formulaire est valide et afficher le bouton le cas echeant
            verifForm();
        }

        private void verifForm()
        {
            if (textBox2.Text != "" && textBox1.Text.Contains("@"))
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Cell clicked");

            if (e.ColumnIndex == dgContacts.Columns["btnSupprimer"].Index)
            {
                personnes.RemoveAt(e.RowIndex);


                DataTable dataTable = new DataTable();


                dataTable.Columns.Add("Nom", typeof(string));
                dataTable.Columns.Add("Age", typeof(string));

                foreach (string[] personne in personnes)
                {
                    dataTable.Rows.Add(personne[0], personne[1]);
                }

                this.dgContacts.DataSource = dataTable;

            }
        }


    }
}
