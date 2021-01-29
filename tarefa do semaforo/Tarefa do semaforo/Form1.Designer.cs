
namespace Tarefa_do_semaforo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbof = new System.Windows.Forms.RadioButton();
            this.rdbon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PRua2 = new System.Windows.Forms.PictureBox();
            this.PRua1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb23 = new System.Windows.Forms.RadioButton();
            this.rdb22 = new System.Windows.Forms.RadioButton();
            this.rdb21 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb13 = new System.Windows.Forms.RadioButton();
            this.rdb12 = new System.Windows.Forms.RadioButton();
            this.rdb11 = new System.Windows.Forms.RadioButton();
            this.auto = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRua2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRua1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbof);
            this.groupBox3.Controls.Add(this.rdbon);
            this.groupBox3.Location = new System.Drawing.Point(431, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(158, 95);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controle automático:";
            // 
            // rdbof
            // 
            this.rdbof.AutoSize = true;
            this.rdbof.Checked = true;
            this.rdbof.Location = new System.Drawing.Point(8, 60);
            this.rdbof.Margin = new System.Windows.Forms.Padding(4);
            this.rdbof.Name = "rdbof";
            this.rdbof.Size = new System.Drawing.Size(42, 21);
            this.rdbof.TabIndex = 1;
            this.rdbof.TabStop = true;
            this.rdbof.Text = "off";
            this.rdbof.UseVisualStyleBackColor = true;
            this.rdbof.CheckedChanged += new System.EventHandler(this.rdbof_CheckedChanged);
            // 
            // rdbon
            // 
            this.rdbon.AutoSize = true;
            this.rdbon.Location = new System.Drawing.Point(8, 25);
            this.rdbon.Margin = new System.Windows.Forms.Padding(4);
            this.rdbon.Name = "rdbon";
            this.rdbon.Size = new System.Drawing.Size(42, 21);
            this.rdbon.TabIndex = 0;
            this.rdbon.TabStop = true;
            this.rdbon.Text = "on";
            this.rdbon.UseVisualStyleBackColor = true;
            this.rdbon.CheckedChanged += new System.EventHandler(this.rdbon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Controle do trânsito";
            // 
            // PRua2
            // 
            this.PRua2.Location = new System.Drawing.Point(13, 62);
            this.PRua2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PRua2.Name = "PRua2";
            this.PRua2.Size = new System.Drawing.Size(157, 272);
            this.PRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PRua2.TabIndex = 15;
            this.PRua2.TabStop = false;
            // 
            // PRua1
            // 
            this.PRua1.Location = new System.Drawing.Point(245, 62);
            this.PRua1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PRua1.Name = "PRua1";
            this.PRua1.Size = new System.Drawing.Size(157, 272);
            this.PRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PRua1.TabIndex = 14;
            this.PRua1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb23);
            this.groupBox2.Controls.Add(this.rdb22);
            this.groupBox2.Controls.Add(this.rdb21);
            this.groupBox2.Location = new System.Drawing.Point(13, 355);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(158, 147);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinais da Rua 2";
            // 
            // rdb23
            // 
            this.rdb23.AutoSize = true;
            this.rdb23.Location = new System.Drawing.Point(9, 108);
            this.rdb23.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdb23.Name = "rdb23";
            this.rdb23.Size = new System.Drawing.Size(98, 21);
            this.rdb23.TabIndex = 5;
            this.rdb23.TabStop = true;
            this.rdb23.Tag = "6";
            this.rdb23.Text = "Sinal verde";
            this.rdb23.UseVisualStyleBackColor = true;
            this.rdb23.CheckedChanged += new System.EventHandler(this.MudançaEstado);
            // 
            // rdb22
            // 
            this.rdb22.AutoSize = true;
            this.rdb22.Location = new System.Drawing.Point(9, 69);
            this.rdb22.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdb22.Name = "rdb22";
            this.rdb22.Size = new System.Drawing.Size(115, 21);
            this.rdb22.TabIndex = 4;
            this.rdb22.TabStop = true;
            this.rdb22.Tag = "5";
            this.rdb22.Text = "Sinal amarelo";
            this.rdb22.UseVisualStyleBackColor = true;
            this.rdb22.CheckedChanged += new System.EventHandler(this.MudançaEstado);
            // 
            // rdb21
            // 
            this.rdb21.AutoSize = true;
            this.rdb21.Location = new System.Drawing.Point(9, 30);
            this.rdb21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdb21.Name = "rdb21";
            this.rdb21.Size = new System.Drawing.Size(122, 21);
            this.rdb21.TabIndex = 3;
            this.rdb21.Tag = "4";
            this.rdb21.Text = "Sinal vermelho";
            this.rdb21.UseVisualStyleBackColor = true;
            this.rdb21.CheckedChanged += new System.EventHandler(this.MudançaEstado);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb13);
            this.groupBox1.Controls.Add(this.rdb12);
            this.groupBox1.Controls.Add(this.rdb11);
            this.groupBox1.Location = new System.Drawing.Point(245, 355);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(158, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinais da Rua 1";
            // 
            // rdb13
            // 
            this.rdb13.AutoSize = true;
            this.rdb13.Location = new System.Drawing.Point(11, 110);
            this.rdb13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdb13.Name = "rdb13";
            this.rdb13.Size = new System.Drawing.Size(98, 21);
            this.rdb13.TabIndex = 2;
            this.rdb13.Tag = "3";
            this.rdb13.Text = "Sinal verde";
            this.rdb13.UseVisualStyleBackColor = true;
            this.rdb13.CheckedChanged += new System.EventHandler(this.MudançaEstado);
            // 
            // rdb12
            // 
            this.rdb12.AutoSize = true;
            this.rdb12.Location = new System.Drawing.Point(11, 71);
            this.rdb12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdb12.Name = "rdb12";
            this.rdb12.Size = new System.Drawing.Size(115, 21);
            this.rdb12.TabIndex = 1;
            this.rdb12.TabStop = true;
            this.rdb12.Tag = "2";
            this.rdb12.Text = "Sinal amarelo";
            this.rdb12.UseVisualStyleBackColor = true;
            this.rdb12.CheckedChanged += new System.EventHandler(this.MudançaEstado);
            // 
            // rdb11
            // 
            this.rdb11.AutoSize = true;
            this.rdb11.Location = new System.Drawing.Point(11, 33);
            this.rdb11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdb11.Name = "rdb11";
            this.rdb11.Size = new System.Drawing.Size(122, 21);
            this.rdb11.TabIndex = 0;
            this.rdb11.TabStop = true;
            this.rdb11.Tag = "1";
            this.rdb11.Text = "Sinal vermelho";
            this.rdb11.UseVisualStyleBackColor = true;
            this.rdb11.CheckedChanged += new System.EventHandler(this.MudançaEstado);
            // 
            // auto
            // 
            this.auto.Interval = 1500;
            this.auto.Tick += new System.EventHandler(this.auto_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PRua2);
            this.Controls.Add(this.PRua1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRua2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRua1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbof;
        private System.Windows.Forms.RadioButton rdbon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PRua2;
        private System.Windows.Forms.PictureBox PRua1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb23;
        private System.Windows.Forms.RadioButton rdb22;
        private System.Windows.Forms.RadioButton rdb21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb13;
        private System.Windows.Forms.RadioButton rdb12;
        private System.Windows.Forms.RadioButton rdb11;
        private System.Windows.Forms.Timer auto;
    }
}

