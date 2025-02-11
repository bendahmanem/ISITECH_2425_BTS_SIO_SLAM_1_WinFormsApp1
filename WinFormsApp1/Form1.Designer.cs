namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtNom = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            txtErrAge = new Label();
            txtAge = new TextBox();
            labelAge = new Label();
            erreurNom = new Label();
            erreurEmail = new Label();
            dgContacts = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(154, 353);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(374, 54);
            button1.TabIndex = 0;
            button1.Text = "Ajouter un contact";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNom
            // 
            txtNom.AutoSize = true;
            txtNom.Location = new Point(46, 41);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(63, 32);
            txtNom.TabIndex = 1;
            txtNom.Text = "nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 139);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 2;
            label2.Text = "email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtErrAge);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(labelAge);
            groupBox1.Controls.Add(erreurNom);
            groupBox1.Controls.Add(erreurEmail);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(187, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 468);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtErrAge
            // 
            txtErrAge.AutoSize = true;
            txtErrAge.ForeColor = Color.Red;
            txtErrAge.Location = new Point(404, 228);
            txtErrAge.Name = "txtErrAge";
            txtErrAge.Size = new Size(198, 32);
            txtErrAge.TabIndex = 9;
            txtErrAge.Text = "L'age est invalide";
            txtErrAge.Visible = false;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(154, 221);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 39);
            txtAge.TabIndex = 8;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(46, 224);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(53, 32);
            labelAge.TabIndex = 7;
            labelAge.Text = "age";
            // 
            // erreurNom
            // 
            erreurNom.AutoSize = true;
            erreurNom.ForeColor = Color.Red;
            erreurNom.Location = new Point(394, 45);
            erreurNom.Name = "erreurNom";
            erreurNom.Size = new Size(328, 32);
            erreurNom.TabIndex = 6;
            erreurNom.Text = "Veuillez entrer un nom valide";
            erreurNom.Visible = false;
            // 
            // erreurEmail
            // 
            erreurEmail.AutoSize = true;
            erreurEmail.ForeColor = Color.Red;
            erreurEmail.Location = new Point(404, 143);
            erreurEmail.Name = "erreurEmail";
            erreurEmail.Size = new Size(329, 32);
            erreurEmail.TabIndex = 5;
            erreurEmail.Text = "Le format d'email est invalide";
            erreurEmail.Visible = false;
            erreurEmail.Click += label1_Click;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.AllowUserToDeleteRows = false;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Location = new Point(1117, 100);
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.RowHeadersWidth = 82;
            dgContacts.Size = new Size(842, 604);
            dgContacts.TabIndex = 6;
            dgContacts.CellContentClick += dgContacts_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2010, 992);
            Controls.Add(dgContacts);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label txtNom;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label erreurEmail;
        private Label erreurNom;
        private Label txtErrAge;
        private TextBox txtAge;
        private Label labelAge;
        private DataGridView dgContacts;
    }
}
