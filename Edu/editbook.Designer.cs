namespace Edu
{
    partial class editbook
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
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.nameerror = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(800, 96);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Size = new System.Drawing.Size(800, 46);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(310, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 52);
            this.button4.TabIndex = 176;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 174;
            this.label2.Text = "Book Name";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(310, 190);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(204, 20);
            this.nametext.TabIndex = 173;
            this.nametext.Tag = "";
            // 
            // nameerror
            // 
            this.nameerror.AutoSize = true;
            this.nameerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameerror.ForeColor = System.Drawing.Color.Red;
            this.nameerror.Location = new System.Drawing.Point(476, 172);
            this.nameerror.Name = "nameerror";
            this.nameerror.Size = new System.Drawing.Size(17, 24);
            this.nameerror.TabIndex = 175;
            this.nameerror.Text = "*";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(425, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 52);
            this.button5.TabIndex = 177;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // editbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.nameerror);
            this.Name = "editbook";
            this.Text = "editbook";
            this.Load += new System.EventHandler(this.editbook_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.nameerror, 0);
            this.Controls.SetChildIndex(this.nametext, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nametext;
        public System.Windows.Forms.Label nameerror;
        public System.Windows.Forms.Button button5;
    }
}