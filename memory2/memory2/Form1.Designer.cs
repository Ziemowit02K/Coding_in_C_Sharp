namespace memory2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCzasGry = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCzasStart = new System.Windows.Forms.Label();
            this.panelKart = new System.Windows.Forms.Panel();
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerZakrywajacy = new System.Windows.Forms.Timer(this.components);
            this.timerStartowy = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas:";
            // 
            // lblCzasGry
            // 
            this.lblCzasGry.AutoSize = true;
            this.lblCzasGry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasGry.Location = new System.Drawing.Point(68, 13);
            this.lblCzasGry.Name = "lblCzasGry";
            this.lblCzasGry.Size = new System.Drawing.Size(29, 20);
            this.lblCzasGry.TabIndex = 1;
            this.lblCzasGry.Text = "60";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty.Location = new System.Drawing.Point(193, 13);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(19, 20);
            this.lblPunkty.TabIndex = 3;
            this.lblPunkty.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(124, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Punkty:";
            // 
            // lblCzasStart
            // 
            this.lblCzasStart.AutoSize = true;
            this.lblCzasStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasStart.Location = new System.Drawing.Point(411, 13);
            this.lblCzasStart.Name = "lblCzasStart";
            this.lblCzasStart.Size = new System.Drawing.Size(103, 20);
            this.lblCzasStart.TabIndex = 4;
            this.lblCzasStart.Text = "Start za 5...";
            // 
            // panelKart
            // 
            this.panelKart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelKart.Location = new System.Drawing.Point(17, 51);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(497, 31);
            this.panelKart.TabIndex = 5;
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            this.timerCzasGry.Tick += new System.EventHandler(this.TimerCzasGry_Tick);
            // 
            // timerZakrywajacy
            // 
            this.timerZakrywajacy.Interval = 1000;
            this.timerZakrywajacy.Tick += new System.EventHandler(this.TimerZakrywajacy_Tick);
            // 
            // timerStartowy
            // 
            this.timerStartowy.Interval = 1000;
            this.timerStartowy.Tick += new System.EventHandler(this.TimerStartowy_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(615, 112);
            this.Controls.Add(this.panelKart);
            this.Controls.Add(this.lblCzasStart);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCzasGry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Gra Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCzasGry;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCzasStart;
        private System.Windows.Forms.Panel panelKart;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerZakrywajacy;
        private System.Windows.Forms.Timer timerStartowy;
    }
}

