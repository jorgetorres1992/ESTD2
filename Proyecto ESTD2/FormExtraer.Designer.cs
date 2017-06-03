namespace Proyecto_ESTD2
{
    partial class FormExtraer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCarpeta = new System.Windows.Forms.RadioButton();
            this.radioArchivo = new System.Windows.Forms.RadioButton();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDestino = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extraer Archivo y Carpetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(306, 83);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(273, 20);
            this.txtOrigen.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(306, 173);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(273, 20);
            this.txtDestino.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCarpeta);
            this.groupBox1.Controls.Add(this.radioArchivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione Tipo Dato a Extraer";
            // 
            // radioCarpeta
            // 
            this.radioCarpeta.AutoSize = true;
            this.radioCarpeta.Checked = true;
            this.radioCarpeta.Location = new System.Drawing.Point(6, 67);
            this.radioCarpeta.Name = "radioCarpeta";
            this.radioCarpeta.Size = new System.Drawing.Size(68, 19);
            this.radioCarpeta.TabIndex = 3;
            this.radioCarpeta.TabStop = true;
            this.radioCarpeta.Text = "Carpeta";
            this.radioCarpeta.UseVisualStyleBackColor = true;
            this.radioCarpeta.CheckedChanged += new System.EventHandler(this.radioCarpeta_CheckedChanged);
            // 
            // radioArchivo
            // 
            this.radioArchivo.AutoSize = true;
            this.radioArchivo.Location = new System.Drawing.Point(6, 30);
            this.radioArchivo.Name = "radioArchivo";
            this.radioArchivo.Size = new System.Drawing.Size(70, 19);
            this.radioArchivo.TabIndex = 2;
            this.radioArchivo.Text = "Archivos";
            this.radioArchivo.UseVisualStyleBackColor = true;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(321, 117);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(97, 37);
            this.btnArchivo.TabIndex = 6;
            this.btnArchivo.Text = "Seleccione Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Location = new System.Drawing.Point(464, 117);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(97, 37);
            this.btnCarpeta.TabIndex = 7;
            this.btnCarpeta.Text = "Selecione Carpeta";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // btnMover
            // 
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(68, 193);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(115, 46);
            this.btnMover.TabIndex = 9;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(68, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(321, 216);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(97, 37);
            this.btnDestino.TabIndex = 11;
            this.btnDestino.Text = "Seleccione Destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // FormExtraer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 300);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnCarpeta);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormExtraer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extraer Archivo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCarpeta;
        private System.Windows.Forms.RadioButton radioArchivo;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDestino;
    }
}