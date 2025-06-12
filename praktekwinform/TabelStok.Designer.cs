namespace praktekwinform
{
    partial class TabelStok
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
            dataGridViewStok = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStok
            // 
            dataGridViewStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStok.Location = new Point(56, 77);
            dataGridViewStok.Name = "dataGridViewStok";
            dataGridViewStok.RowHeadersWidth = 51;
            dataGridViewStok.Size = new Size(652, 261);
            dataGridViewStok.TabIndex = 0;
            dataGridViewStok.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 43);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 1;
            label1.Text = "Data Stok Darah";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(56, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TabelStok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridViewStok);
            Name = "TabelStok";
            Text = "TabelStok";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStok;
        private Label label1;
        private Button button1;
    }
}