namespace kutuphaneotomasyonu
{
    partial class KitapEmanetAl
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
            this.lbl_kitapad = new System.Windows.Forms.Label();
            this.txt_kitapad = new System.Windows.Forms.TextBox();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.txt_yazarad = new System.Windows.Forms.TextBox();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.btn_emanetal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gerigel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emanet alınacak kitabın bilgilerini giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_kitapad
            // 
            this.lbl_kitapad.AutoSize = true;
            this.lbl_kitapad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapad.Location = new System.Drawing.Point(108, 377);
            this.lbl_kitapad.Name = "lbl_kitapad";
            this.lbl_kitapad.Size = new System.Drawing.Size(97, 25);
            this.lbl_kitapad.TabIndex = 1;
            this.lbl_kitapad.Text = "Kitap Adı:";
            this.lbl_kitapad.Click += new System.EventHandler(this.lbl_kitapad_Click);
            // 
            // txt_kitapad
            // 
            this.txt_kitapad.Location = new System.Drawing.Point(249, 377);
            this.txt_kitapad.Name = "txt_kitapad";
            this.txt_kitapad.Size = new System.Drawing.Size(100, 22);
            this.txt_kitapad.TabIndex = 0;
            this.txt_kitapad.TextChanged += new System.EventHandler(this.txt_kitapad_TextChanged);
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.Location = new System.Drawing.Point(108, 429);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(123, 25);
            this.lbl_yazar.TabIndex = 1;
            this.lbl_yazar.Text = "Kitap Yazarı:";
            this.lbl_yazar.Click += new System.EventHandler(this.lbl_yazar_Click);
            // 
            // txt_yazarad
            // 
            this.txt_yazarad.Location = new System.Drawing.Point(249, 433);
            this.txt_yazarad.Name = "txt_yazarad";
            this.txt_yazarad.Size = new System.Drawing.Size(100, 22);
            this.txt_yazarad.TabIndex = 1;
            this.txt_yazarad.TextChanged += new System.EventHandler(this.txt_yazarad_TextChanged);
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tur.Location = new System.Drawing.Point(108, 487);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(124, 25);
            this.lbl_tur.TabIndex = 1;
            this.lbl_tur.Text = "Kitabın Türü:";
            this.lbl_tur.Click += new System.EventHandler(this.lbl_tur_Click);
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(249, 489);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(100, 22);
            this.txt_tur.TabIndex = 2;
            this.txt_tur.TextChanged += new System.EventHandler(this.txt_tur_TextChanged);
            // 
            // btn_emanetal
            // 
            this.btn_emanetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanetal.Location = new System.Drawing.Point(536, 394);
            this.btn_emanetal.Name = "btn_emanetal";
            this.btn_emanetal.Size = new System.Drawing.Size(134, 61);
            this.btn_emanetal.TabIndex = 3;
            this.btn_emanetal.Text = "Emanet Al";
            this.btn_emanetal.UseVisualStyleBackColor = true;
            this.btn_emanetal.Click += new System.EventHandler(this.btn_emanetal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_gerigel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 5;
            // 
            // btn_gerigel
            // 
            this.btn_gerigel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gerigel.Location = new System.Drawing.Point(0, 0);
            this.btn_gerigel.Name = "btn_gerigel";
            this.btn_gerigel.Size = new System.Drawing.Size(75, 48);
            this.btn_gerigel.TabIndex = 0;
            this.btn_gerigel.Text = "<";
            this.btn_gerigel.UseVisualStyleBackColor = true;
            this.btn_gerigel.Click += new System.EventHandler(this.btn_gerigel_Click);
            // 
            // KitapEmanetAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_emanetal);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.txt_yazarad);
            this.Controls.Add(this.txt_kitapad);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.lbl_kitapad);
            this.Controls.Add(this.label1);
            this.Name = "KitapEmanetAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEmanetAl";
            this.Load += new System.EventHandler(this.KitapEmanetAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kitapad;
        private System.Windows.Forms.TextBox txt_kitapad;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.TextBox txt_yazarad;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.TextBox txt_tur;
        private System.Windows.Forms.Button btn_emanetal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gerigel;
    }
}