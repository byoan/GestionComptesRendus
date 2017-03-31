namespace GestionComptesRendus
{
    partial class CompteRenduDeVisite
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.entityDataSource1 = new EFWinforms.EntityDataSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFQTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.entityBindingNavigator1 = new EFWinforms.EntityBindingNavigator();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro de rapport";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSource1, "RAPPORT_VISITE.RAP_NUM", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(113, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(GestionComptesRendus.GestionComptesRendusEntities);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Praticien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSource1, "RAPPORT_VISITE.VIS_MATRICULE", true));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motif Visite";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSource1, "RAPPORT_VISITE.RAP_MOTIF", true));
            this.textBox2.Location = new System.Drawing.Point(512, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bilan :";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSource1, "RAPPORT_VISITE.RAP_BILAN", true));
            this.textBox3.Location = new System.Drawing.Point(16, 140);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 146);
            this.textBox3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn,
            this.oFFQTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "RAPPORT_VISITE.OFFRIR";
            this.dataGridView1.DataSource = this.entityDataSource1;
            this.dataGridView1.Location = new System.Drawing.Point(348, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 146);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // mEDDEPOTLEGALDataGridViewTextBoxColumn
            // 
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.DataPropertyName = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.HeaderText = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.Name = "mEDDEPOTLEGALDataGridViewTextBoxColumn";
            // 
            // oFFQTEDataGridViewTextBoxColumn
            // 
            this.oFFQTEDataGridViewTextBoxColumn.DataPropertyName = "OFF_QTE";
            this.oFFQTEDataGridViewTextBoxColumn.HeaderText = "OFF_QTE";
            this.oFFQTEDataGridViewTextBoxColumn.Name = "oFFQTEDataGridViewTextBoxColumn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Offre d\'échantillons :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Détails";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSource1, "RAPPORT_VISITE.PRA_NUM", true));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(46, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // entityBindingNavigator1
            // 
            this.entityBindingNavigator1.DataMember = "RAPPORT_VISITE";
            this.entityBindingNavigator1.DataSource = this.entityDataSource1;
            this.entityBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.entityBindingNavigator1.Name = "entityBindingNavigator1";
            this.entityBindingNavigator1.ShowSaveUndoRefreshButtons = false;
            this.entityBindingNavigator1.Size = new System.Drawing.Size(646, 25);
            this.entityBindingNavigator1.TabIndex = 0;
            this.entityBindingNavigator1.Text = "entityBindingNavigator1";
            this.entityBindingNavigator1.PositionChanged += new System.EventHandler(this.entityBindingNavigator1_PositionChanged);
            this.entityBindingNavigator1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.entityBindingNavigator1_ItemClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompteRenduDeVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entityBindingNavigator1);
            this.Name = "CompteRenduDeVisite";
            this.Text = "Consultation Rapports de Visite - GSB";
            this.Load += new System.EventHandler(this.CompteRenduDeVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EFWinforms.EntityBindingNavigator entityBindingNavigator1;
        private EFWinforms.EntityDataSource entityDataSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDDEPOTLEGALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFQTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}