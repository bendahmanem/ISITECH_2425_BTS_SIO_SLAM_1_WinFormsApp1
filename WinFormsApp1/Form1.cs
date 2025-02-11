using System.ComponentModel.Design;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Recuperer les valeurs des textBox 
            // type nom = <valeur>;
            string nom = textBox1.Text; // txtNom.Text;
            string email = textBox2.Text; // txtEmail.Text;

            if (nom == "" || email == "")
            {
                MessageBox.Show("Merci de remplir  tous les champs!");
            }
            else
            {
                MessageBox.Show(" Le contact " + nom + ", " + email + " a bien ete ajoute!");
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
            } else
            {
                this.button1.Enabled = false;
            }
        }
    }
}
