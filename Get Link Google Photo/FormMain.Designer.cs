namespace Get_Link_Google_Photo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.rdPhoto = new System.Windows.Forms.RadioButton();
            this.rdAlbum = new System.Windows.Forms.RadioButton();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.tbOuput = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link";
            // 
            // rdPhoto
            // 
            this.rdPhoto.AutoSize = true;
            this.rdPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhoto.Location = new System.Drawing.Point(77, 9);
            this.rdPhoto.Name = "rdPhoto";
            this.rdPhoto.Size = new System.Drawing.Size(63, 21);
            this.rdPhoto.TabIndex = 1;
            this.rdPhoto.TabStop = true;
            this.rdPhoto.Text = "Photo";
            this.rdPhoto.UseVisualStyleBackColor = true;
            this.rdPhoto.CheckedChanged += new System.EventHandler(this.rdPhoto_CheckedChanged);
            // 
            // rdAlbum
            // 
            this.rdAlbum.AutoSize = true;
            this.rdAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAlbum.Location = new System.Drawing.Point(146, 9);
            this.rdAlbum.Name = "rdAlbum";
            this.rdAlbum.Size = new System.Drawing.Size(65, 21);
            this.rdAlbum.TabIndex = 2;
            this.rdAlbum.TabStop = true;
            this.rdAlbum.Text = "Album";
            this.rdAlbum.UseVisualStyleBackColor = true;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(29, 39);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(423, 20);
            this.tbUrl.TabIndex = 3;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.tbOuput);
            this.grbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResult.Location = new System.Drawing.Point(29, 114);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(423, 227);
            this.grbResult.TabIndex = 4;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Result";
            // 
            // tbOuput
            // 
            this.tbOuput.Location = new System.Drawing.Point(6, 37);
            this.tbOuput.MaxLength = 0;
            this.tbOuput.Multiline = true;
            this.tbOuput.Name = "tbOuput";
            this.tbOuput.ReadOnly = true;
            this.tbOuput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOuput.Size = new System.Drawing.Size(411, 184);
            this.tbOuput.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.Location = new System.Drawing.Point(29, 66);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(423, 32);
            this.btGet.TabIndex = 5;
            this.btGet.Text = "Get";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 366);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.rdAlbum);
            this.Controls.Add(this.rdPhoto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Get Information GG Photo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdPhoto;
        private System.Windows.Forms.RadioButton rdAlbum;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.TextBox tbOuput;
        private System.Windows.Forms.Button btGet;

    }
}

