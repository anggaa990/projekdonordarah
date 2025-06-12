namespace praktekwinform
{
    partial class TabelPendonor
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
            dgvPendonor = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPendonor).BeginInit();
            SuspendLayout();
            // 
            // dgvPendonor
            // 
            dgvPendonor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendonor.Location = new Point(61, 64);
            dgvPendonor.Name = "dgvPendonor";
            dgvPendonor.RowHeadersWidth = 51;
            dgvPendonor.Size = new Size(895, 499);
            dgvPendonor.TabIndex = 0;
            dgvPendonor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 22);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 1;
            label1.Text = "Data Pendonor";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TabelPendonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(981, 575);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvPendonor);
            Name = "TabelPendonor";
            Text = "TabelPendonor";
            Load += TabelPendonor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPendonor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPendonor;
        private Label label1;
        private Button button1;
    }
}