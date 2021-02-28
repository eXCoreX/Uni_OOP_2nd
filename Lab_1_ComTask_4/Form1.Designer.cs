
namespace Lab_1_ComTask_4
{
    partial class Form1
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
            this.buttonAddLabel = new System.Windows.Forms.Button();
            this.labelSelectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddLabel
            // 
            this.buttonAddLabel.Location = new System.Drawing.Point(303, 182);
            this.buttonAddLabel.Name = "buttonAddLabel";
            this.buttonAddLabel.Size = new System.Drawing.Size(213, 91);
            this.buttonAddLabel.TabIndex = 0;
            this.buttonAddLabel.Text = "Add new label";
            this.buttonAddLabel.UseVisualStyleBackColor = true;
            this.buttonAddLabel.Click += new System.EventHandler(this.buttonAddLabel_Click);
            // 
            // labelSelectedLabel
            // 
            this.labelSelectedLabel.AutoSize = true;
            this.labelSelectedLabel.Location = new System.Drawing.Point(298, 60);
            this.labelSelectedLabel.Name = "labelSelectedLabel";
            this.labelSelectedLabel.Size = new System.Drawing.Size(218, 25);
            this.labelSelectedLabel.TabIndex = 1;
            this.labelSelectedLabel.Text = "Selected Label: None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectedLabel);
            this.Controls.Add(this.buttonAddLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddLabel;
        private System.Windows.Forms.Label labelSelectedLabel;
    }
}

