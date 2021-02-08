
namespace Dictionary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSpeakEnglish = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txbExplanation = new System.Windows.Forms.TextBox();
            this.txbMeaning = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSpeakEnglish);
            this.panel1.Controls.Add(this.cbWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 511);
            this.panel1.TabIndex = 0;
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.Location = new System.Drawing.Point(207, 1);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(25, 23);
            this.btnSpeakEnglish.TabIndex = 1;
            this.btnSpeakEnglish.UseVisualStyleBackColor = true;
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(4, 1);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(199, 514);
            this.cbWord.TabIndex = 0;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbExplanation);
            this.panel2.Controls.Add(this.txbMeaning);
            this.panel2.Location = new System.Drawing.Point(253, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 511);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbExplanation
            // 
            this.txbExplanation.Location = new System.Drawing.Point(3, 29);
            this.txbExplanation.Multiline = true;
            this.txbExplanation.Name = "txbExplanation";
            this.txbExplanation.Size = new System.Drawing.Size(455, 479);
            this.txbExplanation.TabIndex = 1;
            this.txbExplanation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbMeaning
            // 
            this.txbMeaning.Location = new System.Drawing.Point(3, 3);
            this.txbMeaning.Name = "txbMeaning";
            this.txbMeaning.Size = new System.Drawing.Size(455, 20);
            this.txbMeaning.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbExplanation;
        private System.Windows.Forms.TextBox txbMeaning;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.Button button1;
    }
}

