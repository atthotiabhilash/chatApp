namespace server
{
    partial class Server
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
            outputBox = new TextBox();
            clear = new Button();
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.Location = new Point(146, 24);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(533, 272);
            outputBox.TabIndex = 1;
            outputBox.TextChanged += outputBox_TextChanged;
            // 
            // clear
            // 
            clear.Location = new Point(567, 302);
            clear.Name = "clear";
            clear.Size = new Size(112, 34);
            clear.TabIndex = 2;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clear);
            Controls.Add(outputBox);
            Name = "MessageForm";
            Text = "MessageForm";
            Load += MessageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Message_Received;
        private Label Message;
        private TextBox outputBox;
        private Button clear;
    }
}