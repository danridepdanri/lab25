namespace WinFormsApp19
{
    partial class AddResidentDialog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtResidentID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtContactNumber = new TextBox();
            btnAddResident = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "txtResidentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 53);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "txtLastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 87);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "txtFirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 131);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "txtContactNumber";
            // 
            // txtResidentID
            // 
            txtResidentID.Location = new Point(117, 18);
            txtResidentID.Name = "txtResidentID";
            txtResidentID.Size = new Size(162, 23);
            txtResidentID.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(117, 53);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(162, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(117, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(162, 23);
            txtFirstName.TabIndex = 6;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(133, 128);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(146, 23);
            txtContactNumber.TabIndex = 7;
            // 
            // btnAddResident
            // 
            btnAddResident.Location = new Point(22, 379);
            btnAddResident.Name = "btnAddResident";
            btnAddResident.Size = new Size(75, 23);
            btnAddResident.TabIndex = 8;
            btnAddResident.Text = "ADD";
            btnAddResident.UseVisualStyleBackColor = true;
            btnAddResident.Click += btnAddResident_Click;
            // 
            // AddResidentDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddResident);
            Controls.Add(txtContactNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtResidentID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddResidentDialog";
            Text = "AddResidentDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtResidentID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtContactNumber;
        private Button btnAddResident;
    }
}