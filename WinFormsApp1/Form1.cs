using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // declaration de la variable personne
        private List<string[]> personnes;
        private UpdateForm UpdateFormInstance;
        private string connectionString = "Data Source=np:\\\\.\\pipe\\LOCALDB#61B8582D\\tsql\\query;Initial Catalog=ContactsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Form1()
        {
            InitializeComponent();

            using (SqlConnection connection  = new SqlConnection(connectionString))
            {
                // Permet l'ouverture de la connexion a la bdd
                connection.Open();
                
                // La requete SQL que nous allons executer
                string query = "SELECT * FROM Contacts;";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();

                // Recupere les Rows retournees par la requete SQL contenue dans la variable
                // Query
                sqlDataAdapter.Fill(dt);

                this.dgContacts.DataSource = dt;
            }    

            // Creation du bouton supprimer
            DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.HeaderText = "Action";
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.UseColumnTextForButtonValue = true; // afficher le texte dans le bouton

            // Creation du bouton modifier
            DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
            btnModifier.Text = "Modifier";
            btnModifier.HeaderText = "Action";
            btnModifier.Name = "btnModifier";
            btnModifier.UseColumnTextForButtonValue = true; // afficher le texte dans le bouton


            dgContacts.AllowUserToAddRows = false;



            // this.dgContacts.DataSource = dataTable;
            this.dgContacts.Columns.Add(btnModifier);
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
                using (SqlConnection connection  = new SqlConnection (connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Contacts (nom, email) VALUES ( @nom , @email )";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                    var dt = new DataTable();
                    string selectQuery = "SELECT * FROM Contacts";
                    SqlDataAdapter da = new SqlDataAdapter(selectQuery, connection);
                    da.Fill(dt);
                    dgContacts.DataSource = dt;
                }
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                // -recuperer l'id du contact a supprimer lors du click sur le bouton supprimer
                int contactId = (int) this.dgContacts.Rows[e.RowIndex].Cells["ID"].Value;

                //- Demander confirmation a l'utilisateur (voir ppt)
                string query = "DELETE FROM Contacts WHERE ID=@ID";
                    //- Preparer la requete
                    conn.Open();
                    SqlCommand commande = new SqlCommand(query, conn);
                    commande.Parameters.AddWithValue("@ID", contactId);
                    commande.ExecuteNonQuery();

                //-Mettre a jour la vue


                }



            }

            if (e.ColumnIndex == dgContacts.Columns["btnModifier"].Index)
            {
                int contactId = (int)this.dgContacts.Rows[e.RowIndex].Cells["ID"].Value;

                UpdateFormInstance = new UpdateForm(contactId);
                
                // Passer les donnees au form de modification
                UpdateFormInstance.Show();

                

            }

        }


    }
}
