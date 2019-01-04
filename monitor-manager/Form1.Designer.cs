namespace monitor_manager
{
    partial class main_window
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
            this.save_current_config = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.load_config = new System.Windows.Forms.Button();
            this.preview_box = new System.Windows.Forms.GroupBox();
            this.config_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save_current_config
            // 
            this.save_current_config.Location = new System.Drawing.Point(12, 12);
            this.save_current_config.Name = "save_current_config";
            this.save_current_config.Size = new System.Drawing.Size(110, 23);
            this.save_current_config.TabIndex = 0;
            this.save_current_config.Text = "Save current config";
            this.save_current_config.UseVisualStyleBackColor = true;
            this.save_current_config.Click += new System.EventHandler(this.save_current_config_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // load_config
            // 
            this.load_config.Location = new System.Drawing.Point(128, 12);
            this.load_config.Name = "load_config";
            this.load_config.Size = new System.Drawing.Size(121, 23);
            this.load_config.TabIndex = 2;
            this.load_config.Text = "Load config";
            this.load_config.UseVisualStyleBackColor = true;
            // 
            // preview_box
            // 
            this.preview_box.Location = new System.Drawing.Point(12, 80);
            this.preview_box.Name = "preview_box";
            this.preview_box.Size = new System.Drawing.Size(237, 171);
            this.preview_box.TabIndex = 3;
            this.preview_box.TabStop = false;
            this.preview_box.Text = "Preview Selected Configuration";
            // 
            // config_name
            // 
            this.config_name.Location = new System.Drawing.Point(12, 41);
            this.config_name.Name = "config_name";
            this.config_name.Size = new System.Drawing.Size(110, 20);
            this.config_name.TabIndex = 4;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 258);
            this.Controls.Add(this.config_name);
            this.Controls.Add(this.preview_box);
            this.Controls.Add(this.load_config);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.save_current_config);
            this.Name = "main_window";
            this.Text = "Monitor Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_current_config;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button load_config;
        private System.Windows.Forms.GroupBox preview_box;
        private System.Windows.Forms.TextBox config_name;
    }
}

