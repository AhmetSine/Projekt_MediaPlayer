namespace MediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDateiOeffnen = new System.Windows.Forms.Button();
            this.labelNoFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WindowsMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNoFile);
            this.panel2.Controls.Add(this.buttonDateiOeffnen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 47);
            this.panel2.TabIndex = 2;
            // 
            // buttonDateiOeffnen
            // 
            this.buttonDateiOeffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDateiOeffnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateiOeffnen.Location = new System.Drawing.Point(652, 12);
            this.buttonDateiOeffnen.Name = "buttonDateiOeffnen";
            this.buttonDateiOeffnen.Size = new System.Drawing.Size(136, 23);
            this.buttonDateiOeffnen.TabIndex = 2;
            this.buttonDateiOeffnen.Text = "Datei öffnen";
            this.buttonDateiOeffnen.UseVisualStyleBackColor = true;
            this.buttonDateiOeffnen.Click += new System.EventHandler(this.buttonDateiOeffnen_Click);
            // 
            // labelNoFile
            // 
            this.labelNoFile.AutoSize = true;
            this.labelNoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoFile.Location = new System.Drawing.Point(23, 12);
            this.labelNoFile.Name = "labelNoFile";
            this.labelNoFile.Size = new System.Drawing.Size(198, 20);
            this.labelNoFile.TabIndex = 3;
            this.labelNoFile.Text = "Keine Datei ausgewählt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.WindowsMP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 455);
            this.panel1.TabIndex = 0;
            // 
            // WindowsMP
            // 
            this.WindowsMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMP.Enabled = true;
            this.WindowsMP.Location = new System.Drawing.Point(0, 0);
            this.WindowsMP.Name = "WindowsMP";
            this.WindowsMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMP.OcxState")));
            this.WindowsMP.Size = new System.Drawing.Size(800, 455);
            this.WindowsMP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MediaPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDateiOeffnen;
        private System.Windows.Forms.Label labelNoFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMP;
    }
}

