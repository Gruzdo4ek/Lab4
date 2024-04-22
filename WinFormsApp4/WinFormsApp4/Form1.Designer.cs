namespace WinFormsApp4
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
            button1 = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            button2 = new Button();
            queue = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(318, 34);
            button1.TabIndex = 0;
            button1.Text = "Перезаполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 52);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(318, 54);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 112);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(212, 180);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(230, 112);
            button2.Name = "button2";
            button2.Size = new Size(100, 180);
            button2.TabIndex = 3;
            button2.Text = "Взять";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // queue
            // 
            queue.Location = new Point(336, 43);
            queue.Name = "queue";
            queue.Size = new Size(122, 249);
            queue.TabIndex = 4;
            queue.Text = "";
            queue.TextChanged += queue_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 5;
            label1.Text = "Очередь";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 308);
            Controls.Add(label1);
            Controls.Add(queue);
            Controls.Add(button2);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button button2;
        private RichTextBox queue;
        private Label label1;
    }
}