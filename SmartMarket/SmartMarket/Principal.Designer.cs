namespace SmartMarket
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.TxtEndArquivo = new System.Windows.Forms.TextBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.FolderBuscarArquivo = new System.Windows.Forms.OpenFileDialog();
            this.GrpAlgoritmos = new System.Windows.Forms.GroupBox();
            this.RButLRU = new System.Windows.Forms.RadioButton();
            this.RButSecondChance = new System.Windows.Forms.RadioButton();
            this.RButFIFO = new System.Windows.Forms.RadioButton();
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.GrpAlgoritmos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEndArquivo
            // 
            this.TxtEndArquivo.Location = new System.Drawing.Point(44, 31);
            this.TxtEndArquivo.Name = "TxtEndArquivo";
            this.TxtEndArquivo.Size = new System.Drawing.Size(285, 20);
            this.TxtEndArquivo.TabIndex = 0;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(347, 31);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(75, 23);
            this.BtnUpload.TabIndex = 1;
            this.BtnUpload.Text = "Buscar";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // FolderBuscarArquivo
            // 
            this.FolderBuscarArquivo.FileName = "openFileDialog1";
            // 
            // GrpAlgoritmos
            // 
            this.GrpAlgoritmos.Controls.Add(this.RButLRU);
            this.GrpAlgoritmos.Controls.Add(this.RButSecondChance);
            this.GrpAlgoritmos.Controls.Add(this.RButFIFO);
            this.GrpAlgoritmos.Location = new System.Drawing.Point(44, 76);
            this.GrpAlgoritmos.Name = "GrpAlgoritmos";
            this.GrpAlgoritmos.Size = new System.Drawing.Size(285, 88);
            this.GrpAlgoritmos.TabIndex = 2;
            this.GrpAlgoritmos.TabStop = false;
            this.GrpAlgoritmos.Text = "Algoritmos Disponíveis";
            // 
            // RButLRU
            // 
            this.RButLRU.AutoSize = true;
            this.RButLRU.Location = new System.Drawing.Point(6, 66);
            this.RButLRU.Name = "RButLRU";
            this.RButLRU.Size = new System.Drawing.Size(47, 17);
            this.RButLRU.TabIndex = 2;
            this.RButLRU.TabStop = true;
            this.RButLRU.Text = "LRU";
            this.RButLRU.UseVisualStyleBackColor = true;
            // 
            // RButSecondChance
            // 
            this.RButSecondChance.AutoSize = true;
            this.RButSecondChance.Location = new System.Drawing.Point(6, 43);
            this.RButSecondChance.Name = "RButSecondChance";
            this.RButSecondChance.Size = new System.Drawing.Size(102, 17);
            this.RButSecondChance.TabIndex = 1;
            this.RButSecondChance.TabStop = true;
            this.RButSecondChance.Text = "Second Chance";
            this.RButSecondChance.UseVisualStyleBackColor = true;
            // 
            // RButFIFO
            // 
            this.RButFIFO.AutoSize = true;
            this.RButFIFO.Location = new System.Drawing.Point(7, 20);
            this.RButFIFO.Name = "RButFIFO";
            this.RButFIFO.Size = new System.Drawing.Size(48, 17);
            this.RButFIFO.TabIndex = 0;
            this.RButFIFO.TabStop = true;
            this.RButFIFO.Text = "FIFO";
            this.RButFIFO.UseVisualStyleBackColor = true;
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(420, 226);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(75, 23);
            this.BtnExecutar.TabIndex = 3;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.BtnExecutar);
            this.Controls.Add(this.GrpAlgoritmos);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.TxtEndArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Smart Market";
            this.GrpAlgoritmos.ResumeLayout(false);
            this.GrpAlgoritmos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEndArquivo;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.OpenFileDialog FolderBuscarArquivo;
        private System.Windows.Forms.GroupBox GrpAlgoritmos;
        private System.Windows.Forms.RadioButton RButLRU;
        private System.Windows.Forms.RadioButton RButSecondChance;
        private System.Windows.Forms.RadioButton RButFIFO;
        private System.Windows.Forms.Button BtnExecutar;
    }
}

