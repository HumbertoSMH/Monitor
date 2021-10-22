namespace Monitor.Pantallas.Zona
{
    partial class AgregarDispotivoAZona
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
            this.cmbDispositivo = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.domoticaDataSet = new Monitor.domoticaDataSet();
            this.domoticaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDispositivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDispositivoTableAdapter = new Monitor.domoticaDataSetTableAdapters.tipoDispositivoTableAdapter();
            this.domoticaDataSet2 = new Monitor.domoticaDataSet2();
            this.dispositivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispositivoTableAdapter = new Monitor.domoticaDataSet2TableAdapters.dispositivoTableAdapter();
            this.domoticaDataSet3 = new Monitor.domoticaDataSet3();
            this.zonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zonaTableAdapter = new Monitor.domoticaDataSet3TableAdapters.zonaTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDispositivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDispositivo
            // 
            this.cmbDispositivo.DataSource = this.dispositivoBindingSource;
            this.cmbDispositivo.DisplayMember = "nombre_dispotivo";
            this.cmbDispositivo.FormattingEnabled = true;
            this.cmbDispositivo.Location = new System.Drawing.Point(113, 28);
            this.cmbDispositivo.Name = "cmbDispositivo";
            this.cmbDispositivo.Size = new System.Drawing.Size(183, 21);
            this.cmbDispositivo.TabIndex = 0;
            this.cmbDispositivo.ValueMember = "id_dispositivo";
            // 
            // cmbZona
            // 
            this.cmbZona.DataSource = this.zonaBindingSource;
            this.cmbZona.DisplayMember = "nombre_zona";
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(113, 68);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(183, 21);
            this.cmbZona.TabIndex = 1;
            this.cmbZona.ValueMember = "id_zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dispositivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zona";
            // 
            // domoticaDataSet
            // 
            this.domoticaDataSet.DataSetName = "domoticaDataSet";
            this.domoticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domoticaDataSetBindingSource
            // 
            this.domoticaDataSetBindingSource.DataSource = this.domoticaDataSet;
            this.domoticaDataSetBindingSource.Position = 0;
            // 
            // tipoDispositivoBindingSource
            // 
            this.tipoDispositivoBindingSource.DataMember = "tipoDispositivo";
            this.tipoDispositivoBindingSource.DataSource = this.domoticaDataSetBindingSource;
            // 
            // tipoDispositivoTableAdapter
            // 
            this.tipoDispositivoTableAdapter.ClearBeforeFill = true;
            // 
            // domoticaDataSet2
            // 
            this.domoticaDataSet2.DataSetName = "domoticaDataSet2";
            this.domoticaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispositivoBindingSource
            // 
            this.dispositivoBindingSource.DataMember = "dispositivo";
            this.dispositivoBindingSource.DataSource = this.domoticaDataSet2;
            // 
            // dispositivoTableAdapter
            // 
            this.dispositivoTableAdapter.ClearBeforeFill = true;
            // 
            // domoticaDataSet3
            // 
            this.domoticaDataSet3.DataSetName = "domoticaDataSet3";
            this.domoticaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonaBindingSource
            // 
            this.zonaBindingSource.DataMember = "zona";
            this.zonaBindingSource.DataSource = this.domoticaDataSet3;
            // 
            // zonaTableAdapter
            // 
            this.zonaTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(113, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarDispotivoAZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 162);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.cmbDispositivo);
            this.Name = "AgregarDispotivoAZona";
            this.Text = "AgregarDispotivoAZona";
            this.Load += new System.EventHandler(this.AgregarDispotivoAZona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDispositivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDispositivo;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource domoticaDataSetBindingSource;
        private domoticaDataSet domoticaDataSet;
        private System.Windows.Forms.BindingSource tipoDispositivoBindingSource;
        private domoticaDataSetTableAdapters.tipoDispositivoTableAdapter tipoDispositivoTableAdapter;
        private domoticaDataSet2 domoticaDataSet2;
        private System.Windows.Forms.BindingSource dispositivoBindingSource;
        private domoticaDataSet2TableAdapters.dispositivoTableAdapter dispositivoTableAdapter;
        private domoticaDataSet3 domoticaDataSet3;
        private System.Windows.Forms.BindingSource zonaBindingSource;
        private domoticaDataSet3TableAdapters.zonaTableAdapter zonaTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
    }
}