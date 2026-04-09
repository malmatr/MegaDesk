namespace MegaDesk
{
    partial class ViewQuotes
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
            DateLabel = new Label();
            WidthReq = new Label();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold);
            DateLabel.Location = new Point(26, 36);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(58, 30);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "Date";
            // 
            // WidthReq
            // 
            WidthReq.AutoSize = true;
            WidthReq.Font = new Font("Segoe UI", 9F);
            WidthReq.Location = new Point(26, 66);
            WidthReq.Name = "WidthReq";
            WidthReq.Size = new Size(41, 20);
            WidthReq.TabIndex = 1;
            WidthReq.Text = "Date";
            // 
            // ViewQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WidthReq);
            Controls.Add(DateLabel);
            Name = "ViewQuotes";
            Text = "ViewQuotes";
            Load += ViewQuotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private Label WidthReq;
    }
}