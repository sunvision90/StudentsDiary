namespace StudentsDiary
{
    partial class AddEditStudent
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
            tbId = new TextBox();
            lbId = new Label();
            label1 = new Label();
            tbFirstName = new TextBox();
            label2 = new Label();
            tbLastName = new TextBox();
            label3 = new Label();
            tbMath = new TextBox();
            label4 = new Label();
            tbTechnology = new TextBox();
            label5 = new Label();
            tbPhysics = new TextBox();
            label6 = new Label();
            tbPolishLang = new TextBox();
            label7 = new Label();
            tbForeignLang = new TextBox();
            rtbComments = new RichTextBox();
            label8 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Location = new Point(94, 28);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(245, 23);
            tbId.TabIndex = 0;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(12, 31);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 15);
            lbId.TabIndex = 1;
            lbId.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Imię:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(94, 57);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(245, 23);
            tbFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(94, 86);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(245, 23);
            tbLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Matematyka:";
            // 
            // tbMath
            // 
            tbMath.Location = new Point(94, 115);
            tbMath.Name = "tbMath";
            tbMath.Size = new Size(245, 23);
            tbMath.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 9;
            label4.Text = "Technologia:";
            // 
            // tbTechnology
            // 
            tbTechnology.Location = new Point(94, 144);
            tbTechnology.Name = "tbTechnology";
            tbTechnology.Size = new Size(245, 23);
            tbTechnology.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Fizyka:";
            // 
            // tbPhysics
            // 
            tbPhysics.Location = new Point(94, 173);
            tbPhysics.Name = "tbPhysics";
            tbPhysics.Size = new Size(245, 23);
            tbPhysics.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 210);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 13;
            label6.Text = "Język polski:";
            // 
            // tbPolishLang
            // 
            tbPolishLang.Location = new Point(94, 202);
            tbPolishLang.Name = "tbPolishLang";
            tbPolishLang.Size = new Size(245, 23);
            tbPolishLang.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 239);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 15;
            label7.Text = "Język obcy:";
            // 
            // tbForeignLang
            // 
            tbForeignLang.Location = new Point(94, 231);
            tbForeignLang.Name = "tbForeignLang";
            tbForeignLang.Size = new Size(245, 23);
            tbForeignLang.TabIndex = 14;
            // 
            // rtbComments
            // 
            rtbComments.Location = new Point(94, 264);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(245, 96);
            rtbComments.TabIndex = 16;
            rtbComments.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 267);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 17;
            label8.Text = "Uwagi:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(264, 377);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Zatwierdź";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(94, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label8);
            Controls.Add(rtbComments);
            Controls.Add(label7);
            Controls.Add(tbForeignLang);
            Controls.Add(label6);
            Controls.Add(tbPolishLang);
            Controls.Add(label5);
            Controls.Add(tbPhysics);
            Controls.Add(label4);
            Controls.Add(tbTechnology);
            Controls.Add(label3);
            Controls.Add(tbMath);
            Controls.Add(label2);
            Controls.Add(tbLastName);
            Controls.Add(label1);
            Controls.Add(tbFirstName);
            Controls.Add(lbId);
            Controls.Add(tbId);
            Name = "AddEditStudent";
            Text = "AddEditStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private Label lbId;
        private Label label1;
        private TextBox tbFirstName;
        private Label label2;
        private TextBox tbLastName;
        private Label label3;
        private TextBox tbMath;
        private Label label4;
        private TextBox tbTechnology;
        private Label label5;
        private TextBox tbPhysics;
        private Label label6;
        private TextBox tbPolishLang;
        private Label label7;
        private TextBox tbForeignLang;
        private RichTextBox rtbComments;
        private Label label8;
        private Button btnConfirm;
        private Button btnCancel;
    }
}