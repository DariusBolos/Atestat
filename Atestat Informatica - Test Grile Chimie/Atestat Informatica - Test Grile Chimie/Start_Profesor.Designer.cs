namespace Atestat_Informatica___Test_Grile_Chimie
{
    partial class Start_Profesor
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_sterge = new MaterialSkin.Controls.MaterialButton();
            this.button_adauga = new MaterialSkin.Controls.MaterialButton();
            this.button_modifica = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView_grile = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_rezultate = new System.Windows.Forms.DataGridView();
            this.label_nume = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grile)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rezultate)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(978, 494);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_sterge);
            this.tabPage1.Controls.Add(this.button_adauga);
            this.tabPage1.Controls.Add(this.button_modifica);
            this.tabPage1.Controls.Add(this.dataGridView_grile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_sterge
            // 
            this.button_sterge.AutoSize = false;
            this.button_sterge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_sterge.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_sterge.Depth = 0;
            this.button_sterge.HighEmphasis = true;
            this.button_sterge.Icon = null;
            this.button_sterge.Location = new System.Drawing.Point(686, 371);
            this.button_sterge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_sterge.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_sterge.Size = new System.Drawing.Size(168, 49);
            this.button_sterge.TabIndex = 12;
            this.button_sterge.Text = "Sterge";
            this.button_sterge.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_sterge.UseAccentColor = false;
            this.button_sterge.UseVisualStyleBackColor = true;
            this.button_sterge.Click += new System.EventHandler(this.button_sterge_Click);
            // 
            // button_adauga
            // 
            this.button_adauga.AutoSize = false;
            this.button_adauga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_adauga.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_adauga.Depth = 0;
            this.button_adauga.HighEmphasis = true;
            this.button_adauga.Icon = null;
            this.button_adauga.Location = new System.Drawing.Point(405, 371);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_adauga.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_adauga.Size = new System.Drawing.Size(168, 49);
            this.button_adauga.TabIndex = 11;
            this.button_adauga.Text = "Adauga";
            this.button_adauga.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_adauga.UseAccentColor = false;
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // button_modifica
            // 
            this.button_modifica.AutoSize = false;
            this.button_modifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_modifica.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_modifica.Depth = 0;
            this.button_modifica.HighEmphasis = true;
            this.button_modifica.Icon = null;
            this.button_modifica.Location = new System.Drawing.Point(123, 371);
            this.button_modifica.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_modifica.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_modifica.Size = new System.Drawing.Size(168, 49);
            this.button_modifica.TabIndex = 10;
            this.button_modifica.Text = "Modifica";
            this.button_modifica.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_modifica.UseAccentColor = false;
            this.button_modifica.UseVisualStyleBackColor = true;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // dataGridView_grile
            // 
            this.dataGridView_grile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_grile.Location = new System.Drawing.Point(123, 81);
            this.dataGridView_grile.Name = "dataGridView_grile";
            this.dataGridView_grile.ReadOnly = true;
            this.dataGridView_grile.Size = new System.Drawing.Size(731, 247);
            this.dataGridView_grile.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_rezultate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezultate Elevi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_rezultate
            // 
            this.dataGridView_rezultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rezultate.Location = new System.Drawing.Point(51, 21);
            this.dataGridView_rezultate.Name = "dataGridView_rezultate";
            this.dataGridView_rezultate.Size = new System.Drawing.Size(869, 427);
            this.dataGridView_rezultate.TabIndex = 1;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.BackColor = System.Drawing.Color.Transparent;
            this.label_nume.Depth = 0;
            this.label_nume.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_nume.Location = new System.Drawing.Point(859, 34);
            this.label_nume.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(43, 19);
            this.label_nume.TabIndex = 13;
            this.label_nume.Text = "Nume";
            // 
            // Start_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 567);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Start_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina de start";
            this.Load += new System.EventHandler(this.Start_Profesor_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rezultate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_grile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_rezultate;
        private MaterialSkin.Controls.MaterialButton button_sterge;
        private MaterialSkin.Controls.MaterialButton button_adauga;
        private MaterialSkin.Controls.MaterialButton button_modifica;
        private MaterialSkin.Controls.MaterialLabel label_nume;
    }
}