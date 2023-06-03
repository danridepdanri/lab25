namespace WinFormsApp19
{
    partial class AddServiceDialog
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
            dtpServiceDate = new DateTimePicker();
            txtServiceID = new TextBox();
            txtResidentID = new TextBox();
            txtServiceName = new TextBox();
            btnAddService = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "txtServiceID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "txtResidentID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 92);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "txtServiceName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 136);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "dtpServiceDate";
            // 
            // dtpServiceDate
            // 
            dtpServiceDate.Location = new Point(130, 130);
            dtpServiceDate.Name = "dtpServiceDate";
            dtpServiceDate.Size = new Size(200, 23);
            dtpServiceDate.TabIndex = 4;
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new Point(130, 14);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new Size(200, 23);
            txtServiceID.TabIndex = 5;
            // 
            // txtResidentID
            // 
            txtResidentID.Location = new Point(130, 43);
            txtResidentID.Name = "txtResidentID";
            txtResidentID.Size = new Size(200, 23);
            txtResidentID.TabIndex = 6;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(130, 89);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(200, 23);
            txtServiceName.TabIndex = 7;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(23, 406);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(93, 23);
            btnAddService.TabIndex = 8;
            btnAddService.Text = "ADD";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // AddServiceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddService);
            Controls.Add(txtServiceName);
            Controls.Add(txtResidentID);
            Controls.Add(txtServiceID);
            Controls.Add(dtpServiceDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddServiceDialog";
            Text = "AddServiceDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpServiceDate;
        private TextBox txtServiceID;
        private TextBox txtResidentID;
        private TextBox txtServiceName;
        private Button btnAddService;
    }
}