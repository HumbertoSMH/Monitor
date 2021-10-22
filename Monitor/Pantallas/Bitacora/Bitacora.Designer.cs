namespace Monitor.Pantallas.Bitacora
{
    partial class Bitacora
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
            this.domoticaDataSet5 = new Monitor.domoticaDataSet5();
            this.spbitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_bitacoraTableAdapter = new Monitor.domoticaDataSet5TableAdapters.sp_bitacoraTableAdapter();
            this.dispositivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbitacoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dispositivoDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.eventoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spbitacoraBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // domoticaDataSet5
            // 
            this.domoticaDataSet5.DataSetName = "domoticaDataSet5";
            this.domoticaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spbitacoraBindingSource
            // 
            this.spbitacoraBindingSource.DataMember = "sp_bitacora";
            this.spbitacoraBindingSource.DataSource = this.domoticaDataSet5;
            // 
            // sp_bitacoraTableAdapter
            // 
            this.sp_bitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // dispositivoDataGridViewTextBoxColumn
            // 
            this.dispositivoDataGridViewTextBoxColumn.DataPropertyName = "Dispositivo";
            this.dispositivoDataGridViewTextBoxColumn.HeaderText = "Dispositivo";
            this.dispositivoDataGridViewTextBoxColumn.Name = "dispositivoDataGridViewTextBoxColumn";
            this.dispositivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            this.zonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventoDataGridViewTextBoxColumn
            // 
            this.eventoDataGridViewTextBoxColumn.DataPropertyName = "Evento";
            this.eventoDataGridViewTextBoxColumn.HeaderText = "Evento";
            this.eventoDataGridViewTextBoxColumn.Name = "eventoDataGridViewTextBoxColumn";
            this.eventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbitacoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private domoticaDataSet5 domoticaDataSet5;
        private System.Windows.Forms.BindingSource spbitacoraBindingSource;
        private domoticaDataSet5TableAdapters.sp_bitacoraTableAdapter sp_bitacoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}