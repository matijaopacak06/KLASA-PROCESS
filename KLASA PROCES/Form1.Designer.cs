namespace KLASA_PROCES
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
            this.buttonExplorer = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonStartInfo = new System.Windows.Forms.Button();
            this.buttonNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExplorer
            // 
            this.buttonExplorer.Location = new System.Drawing.Point(142, 98);
            this.buttonExplorer.Name = "buttonExplorer";
            this.buttonExplorer.Size = new System.Drawing.Size(103, 52);
            this.buttonExplorer.TabIndex = 0;
            this.buttonExplorer.Text = "PokreniteInternetExplorer";
            this.buttonExplorer.UseVisualStyleBackColor = true;
            this.buttonExplorer.Click += new System.EventHandler(this.buttonExplorer_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(129, 202);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(135, 57);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.Text = "Pokrenite Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(457, 95);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(148, 55);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "Pokrenite Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonStartInfo
            // 
            this.buttonStartInfo.Location = new System.Drawing.Point(480, 209);
            this.buttonStartInfo.Name = "buttonStartInfo";
            this.buttonStartInfo.Size = new System.Drawing.Size(125, 43);
            this.buttonStartInfo.TabIndex = 3;
            this.buttonStartInfo.Text = "Start Info";
            this.buttonStartInfo.UseVisualStyleBackColor = true;
            this.buttonStartInfo.Click += new System.EventHandler(this.buttonStartInfo_Click);
            // 
            // buttonNotepad
            // 
            this.buttonNotepad.Location = new System.Drawing.Point(256, 306);
            this.buttonNotepad.Name = "buttonNotepad";
            this.buttonNotepad.Size = new System.Drawing.Size(151, 53);
            this.buttonNotepad.TabIndex = 4;
            this.buttonNotepad.Text = "notepad";
            this.buttonNotepad.UseVisualStyleBackColor = true;
            this.buttonNotepad.Click += new System.EventHandler(this.buttonNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNotepad);
            this.Controls.Add(this.buttonStartInfo);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExplorer;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonStartInfo;
        private System.Windows.Forms.Button buttonNotepad;
    }
}

