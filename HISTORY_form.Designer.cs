namespace EASYCALCULATOR_project
{
    partial class HISTORY_form
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
            this.history_text_box = new System.Windows.Forms.TextBox();
            this.h_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // history_text_box
            // 
            this.history_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_text_box.Location = new System.Drawing.Point(12, 55);
            this.history_text_box.Multiline = true;
            this.history_text_box.Name = "history_text_box";
            this.history_text_box.ReadOnly = true;
            this.history_text_box.Size = new System.Drawing.Size(413, 383);
            this.history_text_box.TabIndex = 0;
            this.history_text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // h_label
            // 
            this.h_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.h_label.AutoSize = true;
            this.h_label.BackColor = System.Drawing.Color.White;
            this.h_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_label.ForeColor = System.Drawing.Color.Black;
            this.h_label.Location = new System.Drawing.Point(144, 9);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(145, 33);
            this.h_label.TabIndex = 1;
            this.h_label.Text = "HISTORY";
            this.h_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HISTORY_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.h_label);
            this.Controls.Add(this.history_text_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HISTORY_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox history_text_box;
        private System.Windows.Forms.Label h_label;
    }
}