namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.GroupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.od = new System.Windows.Forms.TextBox();
            this.Do = new System.Windows.Forms.TextBox();
            this.losuj = new System.Windows.Forms.Button();
            this.GroupBoxLosowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 36);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(98, 28);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // GroupBoxLosowanie
            // 
            this.GroupBoxLosowanie.Controls.Add(this.losuj);
            this.GroupBoxLosowanie.Controls.Add(this.Do);
            this.GroupBoxLosowanie.Controls.Add(this.od);
            this.GroupBoxLosowanie.Controls.Add(this.label2);
            this.GroupBoxLosowanie.Controls.Add(this.label1);
            this.GroupBoxLosowanie.Location = new System.Drawing.Point(12, 88);
            this.GroupBoxLosowanie.Name = "GroupBoxLosowanie";
            this.GroupBoxLosowanie.Size = new System.Drawing.Size(300, 81);
            this.GroupBoxLosowanie.TabIndex = 1;
            this.GroupBoxLosowanie.TabStop = false;
            this.GroupBoxLosowanie.Text = "Losowanie";
            this.GroupBoxLosowanie.Visible = false;
            this.GroupBoxLosowanie.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "do:";
            // 
            // od
            // 
            this.od.Location = new System.Drawing.Point(35, 17);
            this.od.Name = "od";
            this.od.Size = new System.Drawing.Size(43, 20);
            this.od.TabIndex = 4;
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(35, 46);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(43, 20);
            this.Do.TabIndex = 5;
            // 
            // losuj
            // 
            this.losuj.Location = new System.Drawing.Point(194, 30);
            this.losuj.Name = "losuj";
            this.losuj.Size = new System.Drawing.Size(75, 23);
            this.losuj.TabIndex = 6;
            this.losuj.Text = "Losuj";
            this.losuj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 439);
            this.Controls.Add(this.buttonNowaGra);
            this.Controls.Add(this.GroupBoxLosowanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBoxLosowanie.ResumeLayout(false);
            this.GroupBoxLosowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox GroupBoxLosowanie;
        private System.Windows.Forms.Button losuj;
        private System.Windows.Forms.TextBox Do;
        private System.Windows.Forms.TextBox od;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

