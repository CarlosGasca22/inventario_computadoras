namespace examen34
{
    partial class Listar
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
            this.dataGridViewCOMPUTADORA = new System.Windows.Forms.DataGridView();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCOMPUTADORA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCOMPUTADORA
            // 
            this.dataGridViewCOMPUTADORA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCOMPUTADORA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCOMPUTADORA.Location = new System.Drawing.Point(124, 58);
            this.dataGridViewCOMPUTADORA.Name = "dataGridViewCOMPUTADORA";
            this.dataGridViewCOMPUTADORA.Size = new System.Drawing.Size(507, 208);
            this.dataGridViewCOMPUTADORA.TabIndex = 0;
            // 
            // btnRegistros
            // 
            this.btnRegistros.Location = new System.Drawing.Point(216, 331);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(121, 23);
            this.btnRegistros.TabIndex = 1;
            this.btnRegistros.Text = "VER REGISTROS";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(440, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.dataGridViewCOMPUTADORA);
            this.Name = "Listar";
            this.Text = "Mostrar todos los registros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCOMPUTADORA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCOMPUTADORA;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnCancelar;
    }
}