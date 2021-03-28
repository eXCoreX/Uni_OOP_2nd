
namespace Lab_2_IndividualTask_2
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
            this.buttonTransparency = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.buttonSuperMega = new System.Windows.Forms.Button();
            this.checkBoxTrasparency = new System.Windows.Forms.CheckBox();
            this.checkBoxBackground = new System.Windows.Forms.CheckBox();
            this.checkBoxHello = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonTransparency
            // 
            this.buttonTransparency.Location = new System.Drawing.Point(25, 22);
            this.buttonTransparency.Name = "buttonTransparency";
            this.buttonTransparency.Size = new System.Drawing.Size(101, 49);
            this.buttonTransparency.TabIndex = 0;
            this.buttonTransparency.Text = "Прозорість";
            this.buttonTransparency.UseVisualStyleBackColor = true;
            this.buttonTransparency.Click += new System.EventHandler(this.buttonTransparency_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(233, 22);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(112, 49);
            this.buttonBackground.TabIndex = 1;
            this.buttonBackground.Text = "Колір тла";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(456, 22);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(110, 49);
            this.buttonHello.TabIndex = 2;
            this.buttonHello.Text = "hello World";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonSuperMega
            // 
            this.buttonSuperMega.Location = new System.Drawing.Point(25, 121);
            this.buttonSuperMega.Name = "buttonSuperMega";
            this.buttonSuperMega.Size = new System.Drawing.Size(541, 57);
            this.buttonSuperMega.TabIndex = 3;
            this.buttonSuperMega.Text = "супермегакнопка";
            this.buttonSuperMega.UseVisualStyleBackColor = true;
            this.buttonSuperMega.Click += new System.EventHandler(this.buttonSuperMega_Click);
            // 
            // checkBoxTrasparency
            // 
            this.checkBoxTrasparency.AutoSize = true;
            this.checkBoxTrasparency.Location = new System.Drawing.Point(25, 212);
            this.checkBoxTrasparency.Name = "checkBoxTrasparency";
            this.checkBoxTrasparency.Size = new System.Drawing.Size(246, 17);
            this.checkBoxTrasparency.TabIndex = 4;
            this.checkBoxTrasparency.Text = "\"супермегакнопка\" поглинає \"Прозорість\"";
            this.checkBoxTrasparency.UseVisualStyleBackColor = true;
            this.checkBoxTrasparency.CheckedChanged += new System.EventHandler(this.checkBoxTrasparency_CheckedChanged);
            // 
            // checkBoxBackground
            // 
            this.checkBoxBackground.AutoSize = true;
            this.checkBoxBackground.Location = new System.Drawing.Point(25, 255);
            this.checkBoxBackground.Name = "checkBoxBackground";
            this.checkBoxBackground.Size = new System.Drawing.Size(236, 17);
            this.checkBoxBackground.TabIndex = 5;
            this.checkBoxBackground.Text = "\"супермегакнопка\" поглинає \"Колір тла\"";
            this.checkBoxBackground.UseVisualStyleBackColor = true;
            this.checkBoxBackground.CheckedChanged += new System.EventHandler(this.checkBoxBackground_CheckedChanged);
            // 
            // checkBoxHello
            // 
            this.checkBoxHello.AutoSize = true;
            this.checkBoxHello.Location = new System.Drawing.Point(25, 296);
            this.checkBoxHello.Name = "checkBoxHello";
            this.checkBoxHello.Size = new System.Drawing.Size(244, 17);
            this.checkBoxHello.TabIndex = 6;
            this.checkBoxHello.Text = "\"супермегакнопка\" поглинає \"Hello World\"";
            this.checkBoxHello.UseVisualStyleBackColor = true;
            this.checkBoxHello.CheckedChanged += new System.EventHandler(this.checkBoxHello_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 341);
            this.Controls.Add(this.checkBoxHello);
            this.Controls.Add(this.checkBoxBackground);
            this.Controls.Add(this.checkBoxTrasparency);
            this.Controls.Add(this.buttonSuperMega);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.buttonTransparency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTransparency;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button buttonSuperMega;
        private System.Windows.Forms.CheckBox checkBoxTrasparency;
        private System.Windows.Forms.CheckBox checkBoxBackground;
        private System.Windows.Forms.CheckBox checkBoxHello;
    }
}

