namespace Task3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_watch = new System.Windows.Forms.Label();
            this.button_baku = new System.Windows.Forms.Button();
            this.button_london = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_watch
            // 
            this.label1_watch.AutoSize = true;
            this.label1_watch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_watch.Location = new System.Drawing.Point(260, 28);
            this.label1_watch.Name = "label1_watch";
            this.label1_watch.Size = new System.Drawing.Size(0, 20);
            this.label1_watch.TabIndex = 0;
            // 
            // button_baku
            // 
            this.button_baku.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_baku.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_baku.Location = new System.Drawing.Point(27, 137);
            this.button_baku.Name = "button_baku";
            this.button_baku.Size = new System.Drawing.Size(75, 48);
            this.button_baku.TabIndex = 1;
            this.button_baku.Text = "Baku";
            this.button_baku.UseVisualStyleBackColor = false;
            this.button_baku.Click += new System.EventHandler(this.button_baku_Click);
            // 
            // button_london
            // 
            this.button_london.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_london.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_london.Location = new System.Drawing.Point(27, 223);
            this.button_london.Name = "button_london";
            this.button_london.Size = new System.Drawing.Size(75, 51);
            this.button_london.TabIndex = 1;
            this.button_london.Text = "London";
            this.button_london.UseVisualStyleBackColor = false;
            this.button_london.Click += new System.EventHandler(this.button_london_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(568, 479);
            this.Controls.Add(this.button_london);
            this.Controls.Add(this.button_baku);
            this.Controls.Add(this.label1_watch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_watch;
        private Button button_baku;
        private Button button_london;
    }
}