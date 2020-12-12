namespace Media_Converter
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Convert_Button = new System.Windows.Forms.Button();
            this.Input_Label = new System.Windows.Forms.Label();
            this.Output_Label = new System.Windows.Forms.Label();
            this.Input_Box = new System.Windows.Forms.TextBox();
            this.Output_Box = new System.Windows.Forms.TextBox();
            this.Input_Button = new System.Windows.Forms.Button();
            this.Output_Button = new System.Windows.Forms.Button();
            this.Input_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Output_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Format_Choice = new System.Windows.Forms.ComboBox();
            this.Info_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Convert_Button
            // 
            this.Convert_Button.Location = new System.Drawing.Point(12, 88);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(103, 23);
            this.Convert_Button.TabIndex = 0;
            this.Convert_Button.Text = "Convert!";
            this.Convert_Button.UseVisualStyleBackColor = true;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // Input_Label
            // 
            this.Input_Label.AutoSize = true;
            this.Input_Label.Location = new System.Drawing.Point(12, 12);
            this.Input_Label.Name = "Input_Label";
            this.Input_Label.Size = new System.Drawing.Size(31, 13);
            this.Input_Label.TabIndex = 5;
            this.Input_Label.Text = "Input";
            // 
            // Output_Label
            // 
            this.Output_Label.AutoSize = true;
            this.Output_Label.Location = new System.Drawing.Point(12, 34);
            this.Output_Label.Name = "Output_Label";
            this.Output_Label.Size = new System.Drawing.Size(39, 13);
            this.Output_Label.TabIndex = 6;
            this.Output_Label.Text = "Output";
            // 
            // Input_Box
            // 
            this.Input_Box.AllowDrop = true;
            this.Input_Box.Location = new System.Drawing.Point(60, 9);
            this.Input_Box.Name = "Input_Box";
            this.Input_Box.Size = new System.Drawing.Size(135, 20);
            this.Input_Box.TabIndex = 7;
            // 
            // Output_Box
            // 
            this.Output_Box.Location = new System.Drawing.Point(60, 31);
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(135, 20);
            this.Output_Box.TabIndex = 8;
            // 
            // Input_Button
            // 
            this.Input_Button.Location = new System.Drawing.Point(201, 9);
            this.Input_Button.Name = "Input_Button";
            this.Input_Button.Size = new System.Drawing.Size(23, 20);
            this.Input_Button.TabIndex = 9;
            this.Input_Button.Text = "...";
            this.Input_Button.UseVisualStyleBackColor = true;
            this.Input_Button.Click += new System.EventHandler(this.Input_Button_Click);
            // 
            // Output_Button
            // 
            this.Output_Button.Location = new System.Drawing.Point(201, 31);
            this.Output_Button.Name = "Output_Button";
            this.Output_Button.Size = new System.Drawing.Size(23, 20);
            this.Output_Button.TabIndex = 10;
            this.Output_Button.Text = "...";
            this.Output_Button.UseVisualStyleBackColor = true;
            this.Output_Button.Click += new System.EventHandler(this.Output_Button_Click);
            // 
            // Input_Dialog
            // 
            this.Input_Dialog.Title = "Please choose input file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Output format";
            // 
            // Format_Choice
            // 
            this.Format_Choice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Format_Choice.Items.AddRange(new object[] {
            "mp4",
            "mkv",
            "avi",
            "webm",
            "wmv",
            "mov",
            "flv"});
            this.Format_Choice.Location = new System.Drawing.Point(89, 61);
            this.Format_Choice.Name = "Format_Choice";
            this.Format_Choice.Size = new System.Drawing.Size(135, 21);
            this.Format_Choice.TabIndex = 12;
            // 
            // Info_Button
            // 
            this.Info_Button.Location = new System.Drawing.Point(121, 88);
            this.Info_Button.Name = "Info_Button";
            this.Info_Button.Size = new System.Drawing.Size(103, 23);
            this.Info_Button.TabIndex = 13;
            this.Info_Button.Text = "Info";
            this.Info_Button.UseVisualStyleBackColor = true;
            this.Info_Button.Click += new System.EventHandler(this.Info_Button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 117);
            this.Controls.Add(this.Info_Button);
            this.Controls.Add(this.Format_Choice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output_Button);
            this.Controls.Add(this.Input_Button);
            this.Controls.Add(this.Output_Box);
            this.Controls.Add(this.Input_Box);
            this.Controls.Add(this.Output_Label);
            this.Controls.Add(this.Input_Label);
            this.Controls.Add(this.Convert_Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Media Converter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Input_Label;
        private System.Windows.Forms.Label Output_Label;
        private System.Windows.Forms.TextBox Input_Box;
        private System.Windows.Forms.TextBox Output_Box;
        private System.Windows.Forms.Button Input_Button;
        private System.Windows.Forms.Button Output_Button;
        private System.Windows.Forms.OpenFileDialog Input_Dialog;
        private System.Windows.Forms.FolderBrowserDialog Output_Dialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Format_Choice;
        public System.Windows.Forms.Button Convert_Button;
        private System.Windows.Forms.Button Info_Button;
    }
}

