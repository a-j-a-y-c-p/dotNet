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
            dataGridView1 = new DataGridView();
            FillDataSet = new Button();
            Update = new Button();
            Undo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FillDataSet
            // 
            FillDataSet.Location = new Point(622, 100);
            FillDataSet.Name = "FillDataSet";
            FillDataSet.Size = new Size(94, 29);
            FillDataSet.TabIndex = 1;
            FillDataSet.Text = "FillDataSet";
            FillDataSet.UseVisualStyleBackColor = true;
            FillDataSet.Click += button1_Click;
            // 
            // Update
            // 
            Update.Location = new Point(622, 162);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 2;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // Undo
            // 
            Undo.Location = new Point(622, 234);
            Undo.Name = "Undo";
            Undo.Size = new Size(94, 29);
            Undo.TabIndex = 3;
            Undo.Text = "Undo";
            Undo.UseVisualStyleBackColor = true;
            Undo.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 453);
            Controls.Add(Undo);
            Controls.Add(Update);
            Controls.Add(FillDataSet);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button FillDataSet;
        private Button Update;
        private Button Undo;
    }
}
