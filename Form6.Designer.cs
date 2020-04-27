namespace üretim_yönetim_sistemi
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operasyonkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.işlemsüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beklemeSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taşımasüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operasyonaçıklamasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operasyontanımıformuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödevDataSet9 = new üretim_yönetim_sistemi.ÖdevDataSet9();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.operasyon_tanımı_formuTableAdapter = new üretim_yönetim_sistemi.ÖdevDataSet9TableAdapters.operasyon_tanımı_formuTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operasyontanımıformuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operasyonkoduDataGridViewTextBoxColumn,
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn,
            this.işlemsüresiDataGridViewTextBoxColumn,
            this.beklemeSüresiDataGridViewTextBoxColumn,
            this.taşımasüresiDataGridViewTextBoxColumn,
            this.operasyonaçıklamasıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operasyontanımıformuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(506, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 410);
            this.dataGridView1.TabIndex = 32;
            // 
            // operasyonkoduDataGridViewTextBoxColumn
            // 
            this.operasyonkoduDataGridViewTextBoxColumn.DataPropertyName = "operasyon_kodu";
            this.operasyonkoduDataGridViewTextBoxColumn.HeaderText = "operasyon_kodu";
            this.operasyonkoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operasyonkoduDataGridViewTextBoxColumn.Name = "operasyonkoduDataGridViewTextBoxColumn";
            this.operasyonkoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamoperasyonsüresiDataGridViewTextBoxColumn
            // 
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn.DataPropertyName = "toplam_operasyon_süresi";
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn.HeaderText = "toplam_operasyon_süresi";
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn.Name = "toplamoperasyonsüresiDataGridViewTextBoxColumn";
            this.toplamoperasyonsüresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // işlemsüresiDataGridViewTextBoxColumn
            // 
            this.işlemsüresiDataGridViewTextBoxColumn.DataPropertyName = "işlem_süresi";
            this.işlemsüresiDataGridViewTextBoxColumn.HeaderText = "işlem_süresi";
            this.işlemsüresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.işlemsüresiDataGridViewTextBoxColumn.Name = "işlemsüresiDataGridViewTextBoxColumn";
            this.işlemsüresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // beklemeSüresiDataGridViewTextBoxColumn
            // 
            this.beklemeSüresiDataGridViewTextBoxColumn.DataPropertyName = "Bekleme_Süresi";
            this.beklemeSüresiDataGridViewTextBoxColumn.HeaderText = "Bekleme_Süresi";
            this.beklemeSüresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beklemeSüresiDataGridViewTextBoxColumn.Name = "beklemeSüresiDataGridViewTextBoxColumn";
            this.beklemeSüresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // taşımasüresiDataGridViewTextBoxColumn
            // 
            this.taşımasüresiDataGridViewTextBoxColumn.DataPropertyName = "taşıma_süresi";
            this.taşımasüresiDataGridViewTextBoxColumn.HeaderText = "taşıma_süresi";
            this.taşımasüresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taşımasüresiDataGridViewTextBoxColumn.Name = "taşımasüresiDataGridViewTextBoxColumn";
            this.taşımasüresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // operasyonaçıklamasıDataGridViewTextBoxColumn
            // 
            this.operasyonaçıklamasıDataGridViewTextBoxColumn.DataPropertyName = "operasyon_açıklaması";
            this.operasyonaçıklamasıDataGridViewTextBoxColumn.HeaderText = "operasyon_açıklaması";
            this.operasyonaçıklamasıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operasyonaçıklamasıDataGridViewTextBoxColumn.Name = "operasyonaçıklamasıDataGridViewTextBoxColumn";
            this.operasyonaçıklamasıDataGridViewTextBoxColumn.Width = 125;
            // 
            // operasyontanımıformuBindingSource
            // 
            this.operasyontanımıformuBindingSource.DataMember = "operasyon_tanımı_formu";
            this.operasyontanımıformuBindingSource.DataSource = this.ödevDataSet9;
            // 
            // ödevDataSet9
            // 
            this.ödevDataSet9.DataSetName = "ÖdevDataSet9";
            this.ödevDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 65);
            this.button2.TabIndex = 29;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox5.Location = new System.Drawing.Point(263, 391);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 22);
            this.textBox5.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox4.Location = new System.Drawing.Point(263, 340);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox3.Location = new System.Drawing.Point(263, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox2.Location = new System.Drawing.Point(263, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox1.Location = new System.Drawing.Point(263, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Taşıma Süresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Bekleme_Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "İşlem_Süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tolam_Operasyon_Süresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Operasyon_Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(376, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 59);
            this.label1.TabIndex = 17;
            this.label1.Text = "Operasyon Tanımı Formu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Operasyon_Açıklaması";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox6.Location = new System.Drawing.Point(263, 443);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 22);
            this.textBox6.TabIndex = 34;
            // 
            // operasyon_tanımı_formuTableAdapter
            // 
            this.operasyon_tanımı_formuTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageKey = "(yok)";
            this.button5.Location = new System.Drawing.Point(26, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 28);
            this.button5.TabIndex = 35;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1233, 687);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operasyontanımıformuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private ÖdevDataSet9 ödevDataSet9;
        private System.Windows.Forms.BindingSource operasyontanımıformuBindingSource;
        private ÖdevDataSet9TableAdapters.operasyon_tanımı_formuTableAdapter operasyon_tanımı_formuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operasyonkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamoperasyonsüresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemsüresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beklemeSüresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taşımasüresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operasyonaçıklamasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}