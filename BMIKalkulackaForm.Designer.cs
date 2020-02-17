namespace CS012BMIKalkulacka
{
    partial class BMIKalkulackaForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.vypocetBMIButton = new System.Windows.Forms.Button();
            this.hmotnostTextBox = new System.Windows.Forms.TextBox();
            this.vyskaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vypocetBMIButton
            // 
            this.vypocetBMIButton.Location = new System.Drawing.Point(43, 143);
            this.vypocetBMIButton.Name = "vypocetBMIButton";
            this.vypocetBMIButton.Size = new System.Drawing.Size(272, 36);
            this.vypocetBMIButton.TabIndex = 0;
            this.vypocetBMIButton.Text = "Výpočet BMI";
            this.vypocetBMIButton.UseVisualStyleBackColor = true;
            this.vypocetBMIButton.Click += new System.EventHandler(this.vypocetBMIButton_Click);
            // 
            // hmotnostTextBox
            // 
            this.hmotnostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hmotnostTextBox.Location = new System.Drawing.Point(150, 108);
            this.hmotnostTextBox.Name = "hmotnostTextBox";
            this.hmotnostTextBox.Size = new System.Drawing.Size(100, 29);
            this.hmotnostTextBox.TabIndex = 2;
            // 
            // vyskaTextBox
            // 
            this.vyskaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vyskaTextBox.Location = new System.Drawing.Point(150, 71);
            this.vyskaTextBox.Name = "vyskaTextBox";
            this.vyskaTextBox.Size = new System.Drawing.Size(100, 29);
            this.vyskaTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Výška";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hmotnost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(273, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(273, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "kg";
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMILabel.Location = new System.Drawing.Point(166, 192);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(34, 37);
            this.BMILabel.TabIndex = 8;
            this.BMILabel.Text = "?";
            // 
            // BMIKalkulackaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vyskaTextBox);
            this.Controls.Add(this.hmotnostTextBox);
            this.Controls.Add(this.vypocetBMIButton);
            this.Name = "BMIKalkulackaForm";
            this.Text = "CS012 - BMI Kalkulačka (Jiří Nguyen)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vypocetBMIButton;
        private System.Windows.Forms.TextBox hmotnostTextBox;
        private System.Windows.Forms.TextBox vyskaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BMILabel;
    }
}

