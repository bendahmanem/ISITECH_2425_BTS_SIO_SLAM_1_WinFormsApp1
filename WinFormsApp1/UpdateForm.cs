using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateForm : Form
    {
        private int _contactId;

        public UpdateForm(int contactId)
        {
            InitializeComponent();

            // Requeet SQL qui permet de pre remplir les textBox
            // Pour cela on a besoin de l'id du contact a m
            _contactId = contactId;

            // A l'aide de l'ID on recupere le contact en base et on remplit
            // les TextBox avec les bonnes informations


            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Effectuer la requete d'update 
            // UPDATE Contacts SET  nom= @nom, email=@email WHERE ID=@ID;

            // UPDATE table_name
            // SET column1 = value1, column2 = value2, ...
            // WHERE condition;

            // reafficher le form1
        }
    }
}
