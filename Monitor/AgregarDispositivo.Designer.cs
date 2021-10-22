namespace Monitor.Pantallas.Dispositivo
{
    partial class AgregarDispositivo
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.domoticaDataSet = new Monitor.domoticaDataSet();
            this.tipoDispositivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDispositivoTableAdapter = new Monitor.domoticaDataSetTableAdapters.tipoDispositivoTableAdapter();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDispositivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.tipoDispositivoBindingSource;
            this.cmbTipo.DisplayMember = "nombre_tipo_dispositivo";
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(106, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(190, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.ValueMember = "id_tipo_dispositivo";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // domoticaDataSet
            // 
            this.domoticaDataSet.DataSetName = "domoticaDataSet";
            this.domoticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDispositivoBindingSource
            // 
            this.tipoDispositivoBindingSource.DataMember = "tipoDispositivo";
            this.tipoDispositivoBindingSource.DataSource = this.domoticaDataSet;
            // 
            // tipoDispositivoTableAdapter
            // 
            this.tipoDispositivoTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(106, 119);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 178);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label1);
            this.Name = "AgregarDispositivo";
            this.Text = "AgregarDispositivo";
            this.Load += new System.EventHandler(this.AgregarDispositivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.domoticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDispositivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private domoticaDataSet domoticaDataSet;
        private System.Windows.Forms.BindingSource tipoDispositivoBindingSource;
        private domoticaDataSetTableAdapters.tipoDispositivoTableAdapter tipoDispositivoTableAdapter;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}