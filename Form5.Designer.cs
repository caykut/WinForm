namespace üretim_yönetim_sistemi
{
    partial class Form5
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
            this.işİstasyonuKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istasyonAçıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hammaddeAmbarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istasyonmaliyetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.işistasyonutanımııBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödevDataSet8 = new üretim_yönetim_sistemi.ÖdevDataSet8();
            this.işistasyonutanımıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ödevDataSet6 = new üretim_yönetim_sistemi.ÖdevDataSet6();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iş_istasyonu_tanımıTableAdapter = new üretim_yönetim_sistemi.ÖdevDataSet6TableAdapters.iş_istasyonu_tanımıTableAdapter();
            this.ödevDataSet7 = new üretim_yönetim_sistemi.ÖdevDataSet7();
            this.işistasyonutanımıBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iş_istasyonu_tanımıTableAdapter1 = new üretim_yönetim_sistemi.ÖdevDataSet7TableAdapters.iş_istasyonu_tanımıTableAdapter();
            this.iş_istasyonu_tanımııTableAdapter = new üretim_yönetim_sistemi.ÖdevDataSet8TableAdapters.iş_istasyonu_tanımııTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.işistasyonutanımııBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.işistasyonutanımıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.işistasyonutanımıBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.işİstasyonuKoduDataGridViewTextBoxColumn,
            this.istasyonAçıklamaDataGridViewTextBoxColumn,
            this.hammaddeAmbarıDataGridViewTextBoxColumn,
            this.istasyonmaliyetiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.işistasyonutanımııBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 410);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // işİstasyonuKoduDataGridViewTextBoxColumn
            // 
            this.işİstasyonuKoduDataGridViewTextBoxColumn.DataPropertyName = "İş_İstasyonu_Kodu";
            this.işİstasyonuKoduDataGridViewTextBoxColumn.HeaderText = "İş_İstasyonu_Kodu";
            this.işİstasyonuKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.işİstasyonuKoduDataGridViewTextBoxColumn.Name = "işİstasyonuKoduDataGridViewTextBoxColumn";
            this.işİstasyonuKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // istasyonAçıklamaDataGridViewTextBoxColumn
            // 
            this.istasyonAçıklamaDataGridViewTextBoxColumn.DataPropertyName = "İstasyon_Açıklama";
            this.istasyonAçıklamaDataGridViewTextBoxColumn.HeaderText = "İstasyon_Açıklama";
            this.istasyonAçıklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.istasyonAçıklamaDataGridViewTextBoxColumn.Name = "istasyonAçıklamaDataGridViewTextBoxColumn";
            this.istasyonAçıklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // hammaddeAmbarıDataGridViewTextBoxColumn
            // 
            this.hammaddeAmbarıDataGridViewTextBoxColumn.DataPropertyName = "Hammadde_Ambarı";
            this.hammaddeAmbarıDataGridViewTextBoxColumn.HeaderText = "Hammadde_Ambarı";
            this.hammaddeAmbarıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hammaddeAmbarıDataGridViewTextBoxColumn.Name = "hammaddeAmbarıDataGridViewTextBoxColumn";
            this.hammaddeAmbarıDataGridViewTextBoxColumn.Width = 125;
            // 
            // istasyonmaliyetiDataGridViewTextBoxColumn
            // 
            this.istasyonmaliyetiDataGridViewTextBoxColumn.DataPropertyName = "istasyon_maliyeti";
            this.istasyonmaliyetiDataGridViewTextBoxColumn.HeaderText = "istasyon_maliyeti";
            this.istasyonmaliyetiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.istasyonmaliyetiDataGridViewTextBoxColumn.Name = "istasyonmaliyetiDataGridViewTextBoxColumn";
            this.istasyonmaliyetiDataGridViewTextBoxColumn.Width = 125;
            // 
            // işistasyonutanımııBindingSource
            // 
            this.işistasyonutanımııBindingSource.DataMember = "iş_istasyonu_tanımıı";
            this.işistasyonutanımııBindingSource.DataSource = this.ödevDataSet8;
            // 
            // ödevDataSet8
            // 
            this.ödevDataSet8.DataSetName = "ÖdevDataSet8";
            this.ödevDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // işistasyonutanımıBindingSource
            // 
            this.işistasyonutanımıBindingSource.DataMember = "iş_istasyonu_tanımı";
            this.işistasyonutanımıBindingSource.DataSource = this.ödevDataSet6;
            // 
            // ödevDataSet6
            // 
            this.ödevDataSet6.DataSetName = "ÖdevDataSet6";
            this.ödevDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button4.Location = new System.Drawing.Point(222, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 70);
            this.button4.TabIndex = 31;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button3.Location = new System.Drawing.Point(222, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 70);
            this.button3.TabIndex = 30;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button2.Location = new System.Drawing.Point(19, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 65);
            this.button2.TabIndex = 29;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Location = new System.Drawing.Point(19, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox4.Location = new System.Drawing.Point(178, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox3.Location = new System.Drawing.Point(178, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox2.Location = new System.Drawing.Point(178, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox1.Location = new System.Drawing.Point(178, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "İstasyon_Maliyeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hammadde_Ambarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "İstasyon_Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "İş_İstasyonu_Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 59);
            this.label1.TabIndex = 17;
            this.label1.Text = "İş İstasyon Tanımı Formu";
            // 
            // iş_istasyonu_tanımıTableAdapter
            // 
            this.iş_istasyonu_tanımıTableAdapter.ClearBeforeFill = true;
            // 
            // ödevDataSet7
            // 
            this.ödevDataSet7.DataSetName = "ÖdevDataSet7";
            this.ödevDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // işistasyonutanımıBindingSource1
            // 
            this.işistasyonutanımıBindingSource1.DataMember = "iş_istasyonu_tanımı";
            this.işistasyonutanımıBindingSource1.DataSource = this.ödevDataSet7;
            // 
            // iş_istasyonu_tanımıTableAdapter1
            // 
            this.iş_istasyonu_tanımıTableAdapter1.ClearBeforeFill = true;
            // 
            // iş_istasyonu_tanımııTableAdapter
            // 
            this.iş_istasyonu_tanımııTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageKey = "(yok)";
            this.button5.Location = new System.Drawing.Point(19, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 28);
            this.button5.TabIndex = 33;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1232, 606);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.işistasyonutanımııBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.işistasyonutanımıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödevDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.işistasyonutanımıBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ÖdevDataSet6 ödevDataSet6;
        private System.Windows.Forms.BindingSource işistasyonutanımıBindingSource;
        private ÖdevDataSet6TableAdapters.iş_istasyonu_tanımıTableAdapter iş_istasyonu_tanımıTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn işİstasyonuKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istasyonAçıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hammaddeAmbarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istasyonmaliyetiDataGridViewTextBoxColumn;
        private ÖdevDataSet7 ödevDataSet7;
        private System.Windows.Forms.BindingSource işistasyonutanımıBindingSource1;
        private ÖdevDataSet7TableAdapters.iş_istasyonu_tanımıTableAdapter iş_istasyonu_tanımıTableAdapter1;
        private ÖdevDataSet8 ödevDataSet8;
        private System.Windows.Forms.BindingSource işistasyonutanımııBindingSource;
        private ÖdevDataSet8TableAdapters.iş_istasyonu_tanımııTableAdapter iş_istasyonu_tanımııTableAdapter;
        private System.Windows.Forms.Button button5;
    }
}