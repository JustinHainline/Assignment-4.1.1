namespace Assignment_4._1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FirstNametextbox = new TextBox();
            LastNametextbox = new TextBox();
            MobilePhonetextbox = new TextBox();
            WorkPhonetextbox = new TextBox();
            Addresstextbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 65);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 108);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Mobile Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 155);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 3;
            label4.Text = "Work Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 198);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // FirstNametextbox
            // 
            FirstNametextbox.Location = new Point(160, 17);
            FirstNametextbox.Name = "FirstNametextbox";
            FirstNametextbox.Size = new Size(150, 31);
            FirstNametextbox.TabIndex = 5;
            // 
            // LastNametextbox
            // 
            LastNametextbox.Location = new Point(160, 65);
            LastNametextbox.Name = "LastNametextbox";
            LastNametextbox.Size = new Size(150, 31);
            LastNametextbox.TabIndex = 6;
            // 
            // MobilePhonetextbox
            // 
            MobilePhonetextbox.Location = new Point(160, 113);
            MobilePhonetextbox.Name = "MobilePhonetextbox";
            MobilePhonetextbox.Size = new Size(150, 31);
            MobilePhonetextbox.TabIndex = 7;
            // 
            // WorkPhonetextbox
            // 
            WorkPhonetextbox.Location = new Point(161, 155);
            WorkPhonetextbox.Name = "WorkPhonetextbox";
            WorkPhonetextbox.Size = new Size(150, 31);
            WorkPhonetextbox.TabIndex = 8;
            // 
            // Addresstextbox
            // 
            Addresstextbox.Location = new Point(161, 195);
            Addresstextbox.Name = "Addresstextbox";
            Addresstextbox.Size = new Size(150, 31);
            Addresstextbox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(163, 259);
            button1.Name = "button1";
            button1.Size = new Size(148, 45);
            button1.TabIndex = 10;
            button1.Text = "Add Contact";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Addresstextbox);
            Controls.Add(WorkPhonetextbox);
            Controls.Add(MobilePhonetextbox);
            Controls.Add(LastNametextbox);
            Controls.Add(FirstNametextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Contact Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox FirstNametextbox;
        private TextBox LastNametextbox;
        private TextBox MobilePhonetextbox;
        private TextBox WorkPhonetextbox;
        private TextBox Addresstextbox;
        private Button button1;
    }
}
