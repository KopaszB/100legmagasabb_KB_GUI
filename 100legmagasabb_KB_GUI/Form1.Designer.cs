
namespace _100legmagasabb_KB_GUI
{
    partial class Form1
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
            this.button_Orszag = new System.Windows.Forms.Button();
            this.button_Osszemelet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_adatok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adatok)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Orszag
            // 
            this.button_Orszag.Location = new System.Drawing.Point(26, 29);
            this.button_Orszag.Name = "button_Orszag";
            this.button_Orszag.Size = new System.Drawing.Size(158, 41);
            this.button_Orszag.TabIndex = 0;
            this.button_Orszag.Text = "Ország";
            this.button_Orszag.UseVisualStyleBackColor = true;
            this.button_Orszag.Click += new System.EventHandler(this.button_Orszag_Click);
            // 
            // button_Osszemelet
            // 
            this.button_Osszemelet.Location = new System.Drawing.Point(26, 148);
            this.button_Osszemelet.Name = "button_Osszemelet";
            this.button_Osszemelet.Size = new System.Drawing.Size(158, 39);
            this.button_Osszemelet.TabIndex = 1;
            this.button_Osszemelet.Text = "Összemelet";
            this.button_Osszemelet.UseVisualStyleBackColor = true;
            this.button_Osszemelet.Click += new System.EventHandler(this.button_Osszemelet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ország";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A 400m-nél magasabb épületek száma";
            // 
            // dataGridView_adatok
            // 
            this.dataGridView_adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adatok.Location = new System.Drawing.Point(296, 29);
            this.dataGridView_adatok.MultiSelect = false;
            this.dataGridView_adatok.Name = "dataGridView_adatok";
            this.dataGridView_adatok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_adatok.Size = new System.Drawing.Size(470, 305);
            this.dataGridView_adatok.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_adatok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Osszemelet);
            this.Controls.Add(this.button_Orszag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Orszag;
        private System.Windows.Forms.Button button_Osszemelet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_adatok;
    }
}

