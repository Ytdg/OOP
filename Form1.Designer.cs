namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.vh_button = new System.Windows.Forms.Button();
            this.Count_Vg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vh_button
            // 
            this.vh_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.vh_button.Location = new System.Drawing.Point(253, 12);
            this.vh_button.Name = "vh_button";
            this.vh_button.Size = new System.Drawing.Size(94, 43);
            this.vh_button.TabIndex = 0;
            this.vh_button.Text = "start_vagon";
            this.vh_button.UseVisualStyleBackColor = false;
            this.vh_button.Click += new System.EventHandler(this.vh_button_Click);
            // 
            // Count_Vg
            // 
            this.Count_Vg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Count_Vg.Location = new System.Drawing.Point(71, 22);
            this.Count_Vg.Name = "Count_Vg";
            this.Count_Vg.Size = new System.Drawing.Size(107, 22);
            this.Count_Vg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 430);
            this.Controls.Add(this.Count_Vg);
            this.Controls.Add(this.vh_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vh_button;
        private System.Windows.Forms.TextBox Count_Vg;
    }
}

