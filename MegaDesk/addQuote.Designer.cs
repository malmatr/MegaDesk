namespace MegaDesk
{
    partial class AddQuote
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            DateLabel = new Label();
            NameBox = new TextBox();
            DepthBox = new TextBox();
            WidthBox = new TextBox();
            DrawerInput = new ComboBox();
            ShippingComboBox = new ComboBox();
            MaterialComboBox = new ComboBox();
            WidthErrorProvider = new ErrorProvider(components);
            NameErrorProvider = new ErrorProvider(components);
            DepthErrorProvider = new ErrorProvider(components);
            DrawerErrorProvider = new ErrorProvider(components);
            ShippingErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepthErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrawerErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShippingErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 372);
            button1.Name = "button1";
            button1.Size = new Size(190, 50);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(241, 372);
            button2.Name = "button2";
            button2.Size = new Size(190, 50);
            button2.TabIndex = 1;
            button2.Text = "Submit Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(231, 71);
            label1.TabIndex = 2;
            label1.Text = "MegaDesk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 3;
            label2.Text = "Todays Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(197, 23);
            label3.TabIndex = 4;
            label3.Text = "Please Enter Your Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 5;
            label4.Text = "Desk Width:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(85, 17);
            label5.TabIndex = 6;
            label5.Text = "requirements";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 286);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 7;
            label6.Text = "Material Type:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 241);
            label7.Name = "label7";
            label7.Size = new Size(176, 23);
            label7.TabIndex = 8;
            label7.Text = "Desk Drawer Amount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 197);
            label8.Name = "label8";
            label8.Size = new Size(102, 23);
            label8.TabIndex = 9;
            label8.Text = "Desk Depth:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 330);
            label9.Name = "label9";
            label9.Size = new Size(167, 23);
            label9.TabIndex = 10;
            label9.Text = "Shipping Timeframe:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 353);
            label10.Name = "label10";
            label10.Size = new Size(85, 17);
            label10.TabIndex = 11;
            label10.Text = "requirements";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(329, 59);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(102, 23);
            DateLabel.TabIndex = 12;
            DateLabel.Text = "Todays Date";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(279, 101);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(152, 27);
            NameBox.TabIndex = 13;
            NameBox.Validating += NameBox_Validating;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(279, 193);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(152, 27);
            DepthBox.TabIndex = 14;
            DepthBox.Validating += DepthBox_Validating;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(279, 143);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(152, 27);
            WidthBox.TabIndex = 15;
            WidthBox.Validating += WidthBox_Validating;
            // 
            // DrawerInput
            // 
            DrawerInput.FormattingEnabled = true;
            DrawerInput.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            DrawerInput.Location = new Point(280, 240);
            DrawerInput.Name = "DrawerInput";
            DrawerInput.Size = new Size(151, 28);
            DrawerInput.TabIndex = 16;
            DrawerInput.Validating += DrawerComboBox_Validating;
            // 
            // ShippingComboBox
            // 
            ShippingComboBox.FormattingEnabled = true;
            ShippingComboBox.Items.AddRange(new object[] { "3", "5", "7" });
            ShippingComboBox.Location = new Point(280, 329);
            ShippingComboBox.Name = "ShippingComboBox";
            ShippingComboBox.Size = new Size(151, 28);
            ShippingComboBox.TabIndex = 17;
            ShippingComboBox.Validating += ShippingComboBox_Validating;
            // 
            // MaterialComboBox
            // 
            MaterialComboBox.FormattingEnabled = true;
            MaterialComboBox.Location = new Point(280, 285);
            MaterialComboBox.Name = "MaterialComboBox";
            MaterialComboBox.Size = new Size(151, 28);
            MaterialComboBox.TabIndex = 18;
            // 
            // WidthErrorProvider
            // 
            WidthErrorProvider.ContainerControl = this;
            // 
            // NameErrorProvider
            // 
            NameErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            DepthErrorProvider.ContainerControl = this;
            // 
            // DrawerErrorProvider
            // 
            DrawerErrorProvider.ContainerControl = this;
            // 
            // ShippingErrorProvider
            // 
            ShippingErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 434);
            Controls.Add(MaterialComboBox);
            Controls.Add(ShippingComboBox);
            Controls.Add(DrawerInput);
            Controls.Add(WidthBox);
            Controls.Add(DepthBox);
            Controls.Add(NameBox);
            Controls.Add(DateLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AddQuote";
            Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepthErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrawerErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShippingErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label DateLabel;
        private TextBox NameBox;
        private TextBox DepthBox;
        private TextBox WidthBox;
        private ComboBox DrawerInput;
        private ComboBox ShippingComboBox;
        private ComboBox MaterialComboBox;
        private ErrorProvider WidthErrorProvider;
        private ErrorProvider NameErrorProvider;
        private ErrorProvider DepthErrorProvider;
        private ErrorProvider DrawerErrorProvider;
        private ErrorProvider ShippingErrorProvider;
    }
}