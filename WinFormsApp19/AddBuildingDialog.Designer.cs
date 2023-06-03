namespace WinFormsApp19
{
    partial class AddBuildingDialog
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
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBuildingID = new TextBox();
            txtAddress = new TextBox();
            txtFloors = new TextBox();
            txtArea = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "BuildingID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 65);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 107);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "NumberOfFloors";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 151);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "TotalArea";
            // 
            // txtBuildingID
            // 
            txtBuildingID.Location = new Point(94, 17);
            txtBuildingID.Name = "txtBuildingID";
            txtBuildingID.Size = new Size(414, 23);
            txtBuildingID.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 62);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(414, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtFloors
            // 
            txtFloors.Location = new Point(125, 104);
            txtFloors.Name = "txtFloors";
            txtFloors.Size = new Size(383, 23);
            txtFloors.TabIndex = 7;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(125, 148);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(383, 23);
            txtArea.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(655, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddBuildingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(txtArea);
            Controls.Add(txtFloors);
            Controls.Add(txtAddress);
            Controls.Add(txtBuildingID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "AddBuildingDialog";
            Text = "AddBuildingDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBuildingID;
        private TextBox txtAddress;
        private TextBox txtFloors;
        private TextBox txtArea;
        private Button btnCancel;
    }
}