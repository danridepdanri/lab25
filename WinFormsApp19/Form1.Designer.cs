namespace WinFormsApp19
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
            btnAddBuilding = new Button();
            btnAddResident = new Button();
            btnAddService = new Button();
            btnGenerateReport1 = new Button();
            dataGridView = new DataGridView();
            btnGenerateReport2 = new Button();
            btnSearch = new Button();
            txtSearchCriterion = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAddBuilding
            // 
            btnAddBuilding.Location = new Point(17, 353);
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.Size = new Size(113, 23);
            btnAddBuilding.TabIndex = 0;
            btnAddBuilding.Text = "btnAddBuilding";
            btnAddBuilding.UseVisualStyleBackColor = true;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // btnAddResident
            // 
            btnAddResident.Location = new Point(153, 353);
            btnAddResident.Name = "btnAddResident";
            btnAddResident.Size = new Size(120, 23);
            btnAddResident.TabIndex = 1;
            btnAddResident.Text = "btnAddResident";
            btnAddResident.UseVisualStyleBackColor = true;
            btnAddResident.Click += btnAddResident_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(288, 353);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(148, 23);
            btnAddService.TabIndex = 2;
            btnAddService.Text = "btnAddService";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnGenerateReport1
            // 
            btnGenerateReport1.Location = new Point(18, 404);
            btnGenerateReport1.Name = "btnGenerateReport1";
            btnGenerateReport1.Size = new Size(140, 23);
            btnGenerateReport1.TabIndex = 3;
            btnGenerateReport1.Text = "btnGenerateReport1";
            btnGenerateReport1.UseVisualStyleBackColor = true;
            btnGenerateReport1.Click += btnGenerateReport1_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(23, 39);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(740, 263);
            dataGridView.TabIndex = 4;
            // 
            // btnGenerateReport2
            // 
            btnGenerateReport2.Location = new Point(164, 404);
            btnGenerateReport2.Name = "btnGenerateReport2";
            btnGenerateReport2.Size = new Size(140, 23);
            btnGenerateReport2.TabIndex = 5;
            btnGenerateReport2.Text = "btnGenerateReport2";
            btnGenerateReport2.UseVisualStyleBackColor = true;
            btnGenerateReport2.Click += btnGenerateReport2_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(585, 404);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "btnSearch";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchCriterion
            // 
            txtSearchCriterion.Location = new Point(585, 375);
            txtSearchCriterion.Name = "txtSearchCriterion";
            txtSearchCriterion.Size = new Size(140, 23);
            txtSearchCriterion.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 345);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 8;
            label1.Text = "txtSearchCriterion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSearchCriterion);
            Controls.Add(btnSearch);
            Controls.Add(btnGenerateReport2);
            Controls.Add(dataGridView);
            Controls.Add(btnGenerateReport1);
            Controls.Add(btnAddService);
            Controls.Add(btnAddResident);
            Controls.Add(btnAddBuilding);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBuilding;
        private Button btnAddResident;
        private Button btnAddService;
        private Button btnGenerateReport1;
        private DataGridView dataGridView;
        private Button btnGenerateReport2;
        private Button btnSearch;
        private TextBox txtSearchCriterion;
        private Label label1;
    }
}