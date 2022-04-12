namespace NagradniZadatak
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
            this.OtvoriPaint = new System.Windows.Forms.Button();
            this.OtvoriNotepad = new System.Windows.Forms.Button();
            this.OtvoriCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtvoriPaint
            // 
            this.OtvoriPaint.Location = new System.Drawing.Point(31, 49);
            this.OtvoriPaint.Name = "OtvoriPaint";
            this.OtvoriPaint.Size = new System.Drawing.Size(123, 49);
            this.OtvoriPaint.TabIndex = 0;
            this.OtvoriPaint.Text = "Otvori paint";
            this.OtvoriPaint.UseVisualStyleBackColor = true;
            this.OtvoriPaint.Click += new System.EventHandler(this.OtvoriPaint_Click);
            // 
            // OtvoriNotepad
            // 
            this.OtvoriNotepad.Location = new System.Drawing.Point(291, 49);
            this.OtvoriNotepad.Name = "OtvoriNotepad";
            this.OtvoriNotepad.Size = new System.Drawing.Size(123, 49);
            this.OtvoriNotepad.TabIndex = 1;
            this.OtvoriNotepad.Text = "Otvori notepad";
            this.OtvoriNotepad.UseVisualStyleBackColor = true;
            this.OtvoriNotepad.Click += new System.EventHandler(this.OtvoriNotepad_Click);
            // 
            // OtvoriCmd
            // 
            this.OtvoriCmd.Location = new System.Drawing.Point(570, 49);
            this.OtvoriCmd.Name = "OtvoriCmd";
            this.OtvoriCmd.Size = new System.Drawing.Size(123, 49);
            this.OtvoriCmd.TabIndex = 2;
            this.OtvoriCmd.Text = "Otvori CMD";
            this.OtvoriCmd.UseVisualStyleBackColor = true;
            this.OtvoriCmd.Click += new System.EventHandler(this.OtvoriCmd_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OtvoriCmd);
            this.Controls.Add(this.OtvoriNotepad);
            this.Controls.Add(this.OtvoriPaint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button OtvoriPaint;
        private Button OtvoriNotepad;
        private Button OtvoriCmd;
    }
}