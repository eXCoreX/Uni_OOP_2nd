
namespace Lab_1_ComTask_1
{
    partial class Form3
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
            this.buttonClose2And3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose2And3
            // 
            this.buttonClose2And3.Location = new System.Drawing.Point(222, 127);
            this.buttonClose2And3.Name = "buttonClose2And3";
            this.buttonClose2And3.Size = new System.Drawing.Size(333, 173);
            this.buttonClose2And3.TabIndex = 0;
            this.buttonClose2And3.Text = "Close forms 2 and 3";
            this.buttonClose2And3.UseVisualStyleBackColor = true;
            this.buttonClose2And3.Click += new System.EventHandler(this.buttonClose2And3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose2And3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose2And3;
    }
}