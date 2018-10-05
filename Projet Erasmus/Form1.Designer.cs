namespace Projet_Erasmus
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
            this.cmdLoadFile = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLoadFile
            // 
            this.cmdLoadFile.Location = new System.Drawing.Point(568, 49);
            this.cmdLoadFile.Name = "cmdLoadFile";
            this.cmdLoadFile.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadFile.TabIndex = 0;
            this.cmdLoadFile.Text = "LoadFile";
            this.cmdLoadFile.UseVisualStyleBackColor = true;
            this.cmdLoadFile.Click += new System.EventHandler(this.cmdLoadFile_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(568, 91);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Add Student";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(568, 133);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLoadFile;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdPrint;
    }
}

