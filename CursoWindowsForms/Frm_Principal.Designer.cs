
namespace CursoWindowsForms
{
    partial class Frm_Principal
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_DemonstracaoKey = new System.Windows.Forms.Button();
            this.Frm_HelloWorld = new System.Windows.Forms.Button();
            this.Frm_Mascara = new System.Windows.Forms.Button();
            this.Frm_ValidaCPF = new System.Windows.Forms.Button();
            this.Frm_ValidaCPF2 = new System.Windows.Forms.Button();
            this.Frm_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DemonstracaoKey
            // 
            this.Btn_DemonstracaoKey.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DemonstracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DemonstracaoKey.Image")));
            this.Btn_DemonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.Btn_DemonstracaoKey.Name = "Btn_DemonstracaoKey";
            this.Btn_DemonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.Btn_DemonstracaoKey.TabIndex = 0;
            this.Btn_DemonstracaoKey.Text = "Demonstração Key";
            this.Btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            this.Btn_DemonstracaoKey.Click += new System.EventHandler(this.Btn_DemonstracaoKey_Click);
            // 
            // Frm_HelloWorld
            // 
            this.Frm_HelloWorld.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.Frm_HelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("Frm_HelloWorld.Image")));
            this.Frm_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.Frm_HelloWorld.Name = "Frm_HelloWorld";
            this.Frm_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.Frm_HelloWorld.TabIndex = 1;
            this.Frm_HelloWorld.Text = "Hello World";
            this.Frm_HelloWorld.UseVisualStyleBackColor = true;
            this.Frm_HelloWorld.Click += new System.EventHandler(this.Frm_HelloWorld_Click);
            // 
            // Frm_Mascara
            // 
            this.Frm_Mascara.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.Frm_Mascara.Image = ((System.Drawing.Image)(resources.GetObject("Frm_Mascara.Image")));
            this.Frm_Mascara.Location = new System.Drawing.Point(252, 12);
            this.Frm_Mascara.Name = "Frm_Mascara";
            this.Frm_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Frm_Mascara.TabIndex = 2;
            this.Frm_Mascara.Text = "Mascara";
            this.Frm_Mascara.UseVisualStyleBackColor = true;
            this.Frm_Mascara.Click += new System.EventHandler(this.Frm_Mascara_Click);
            // 
            // Frm_ValidaCPF
            // 
            this.Frm_ValidaCPF.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.Frm_ValidaCPF.Image = ((System.Drawing.Image)(resources.GetObject("Frm_ValidaCPF.Image")));
            this.Frm_ValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.Frm_ValidaCPF.Name = "Frm_ValidaCPF";
            this.Frm_ValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.Frm_ValidaCPF.TabIndex = 3;
            this.Frm_ValidaCPF.Text = "Valida CPF";
            this.Frm_ValidaCPF.UseVisualStyleBackColor = true;
            this.Frm_ValidaCPF.Click += new System.EventHandler(this.Frm_ValidaCPF_Click);
            // 
            // Frm_ValidaCPF2
            // 
            this.Frm_ValidaCPF2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.Frm_ValidaCPF2.Image = ((System.Drawing.Image)(resources.GetObject("Frm_ValidaCPF2.Image")));
            this.Frm_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.Frm_ValidaCPF2.Name = "Frm_ValidaCPF2";
            this.Frm_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.Frm_ValidaCPF2.TabIndex = 4;
            this.Frm_ValidaCPF2.Text = "Valida CPF 2";
            this.Frm_ValidaCPF2.UseVisualStyleBackColor = true;
            this.Frm_ValidaCPF2.Click += new System.EventHandler(this.Frm_ValidaCPF2_Click);
            // 
            // Frm_ValidaSenha
            // 
            this.Frm_ValidaSenha.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.Frm_ValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("Frm_ValidaSenha.Image")));
            this.Frm_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.Frm_ValidaSenha.Name = "Frm_ValidaSenha";
            this.Frm_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Frm_ValidaSenha.TabIndex = 5;
            this.Frm_ValidaSenha.Text = "Valida Senha";
            this.Frm_ValidaSenha.UseVisualStyleBackColor = true;
            this.Frm_ValidaSenha.Click += new System.EventHandler(this.Frm_ValidaSenha_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.Frm_ValidaSenha);
            this.Controls.Add(this.Frm_ValidaCPF2);
            this.Controls.Add(this.Frm_ValidaCPF);
            this.Controls.Add(this.Frm_Mascara);
            this.Controls.Add(this.Frm_HelloWorld);
            this.Controls.Add(this.Btn_DemonstracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DemonstracaoKey;
        private System.Windows.Forms.Button Frm_HelloWorld;
        private System.Windows.Forms.Button Frm_Mascara;
        private System.Windows.Forms.Button Frm_ValidaCPF;
        private System.Windows.Forms.Button Frm_ValidaCPF2;
        private System.Windows.Forms.Button Frm_ValidaSenha;
    }
}