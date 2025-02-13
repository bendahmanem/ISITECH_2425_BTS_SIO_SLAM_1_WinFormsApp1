namespace WinFormsApp1
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNom = new Label();
            lblEmail = new Label();
            txtNom = new TextBox();
            txtEmail = new TextBox();
            btnModifier = new Button();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(242, 100);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(67, 32);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(242, 191);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(396, 93);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(298, 39);
            txtNom.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(396, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 39);
            txtEmail.TabIndex = 3;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(314, 314);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(150, 46);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModifier);
            Controls.Add(txtEmail);
            Controls.Add(txtNom);
            Controls.Add(lblEmail);
            Controls.Add(lblNom);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Label lblEmail;
        private TextBox txtNom;
        private TextBox txtEmail;
        private Button btnModifier;
    }
}