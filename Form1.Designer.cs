namespace Windows
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.beforePageBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.pauseButn = new System.Windows.Forms.Button();
            this.startButn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Volume = new System.Windows.Forms.Label();
            this.настроикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageNum = new System.Windows.Forms.TextBox();
            this.ToPageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ToPageBtn);
            this.splitContainer1.Panel1.Controls.Add(this.pageNum);
            this.splitContainer1.Panel1.Controls.Add(this.Volume);
            this.splitContainer1.Panel1.Controls.Add(this.beforePageBtn);
            this.splitContainer1.Panel1.Controls.Add(this.NextPageBtn);
            this.splitContainer1.Panel1.Controls.Add(this.volumeBar);
            this.splitContainer1.Panel1.Controls.Add(this.pauseBtn);
            this.splitContainer1.Panel1.Controls.Add(this.startBtn);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pdfViewer);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // beforePageBtn
            // 
            this.beforePageBtn.Location = new System.Drawing.Point(4, 137);
            this.beforePageBtn.Name = "beforePageBtn";
            this.beforePageBtn.Size = new System.Drawing.Size(75, 23);
            this.beforePageBtn.TabIndex = 5;
            this.beforePageBtn.Text = "Пред. стр";
            this.beforePageBtn.UseVisualStyleBackColor = true;
            this.beforePageBtn.Click += new System.EventHandler(this.BeforePgeBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Location = new System.Drawing.Point(85, 137);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(75, 23);
            this.NextPageBtn.TabIndex = 4;
            this.NextPageBtn.Text = "Сл. стр";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(4, 200);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(151, 45);
            this.volumeBar.SmallChange = 5;
            this.volumeBar.TabIndex = 3;
            this.volumeBar.Value = 1;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(86, 98);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(68, 23);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Пауза";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 98);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(68, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(163, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.настроикиToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(633, 450);
            this.pdfViewer.TabIndex = 0;
            // 
            // pauseButn
            // 
            this.pauseButn.Location = new System.Drawing.Point(0, 0);
            this.pauseButn.Name = "pauseButn";
            this.pauseButn.Size = new System.Drawing.Size(75, 23);
            this.pauseButn.TabIndex = 0;
            // 
            // startButn
            // 
            this.startButn.Location = new System.Drawing.Point(0, 0);
            this.startButn.Name = "startButn";
            this.startButn.Size = new System.Drawing.Size(75, 23);
            this.startButn.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(3, 184);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(62, 13);
            this.Volume.TabIndex = 6;
            this.Volume.Text = "Громкость";
            // 
            // настроикиToolStripMenuItem
            // 
            this.настроикиToolStripMenuItem.Name = "настроикиToolStripMenuItem";
            this.настроикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настроикиToolStripMenuItem.Text = "Настроики ";
            this.настроикиToolStripMenuItem.Click += new System.EventHandler(this.настроикиToolStripMenuItem_Click);
            // 
            // pageNum
            // 
            this.pageNum.Location = new System.Drawing.Point(12, 407);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(81, 20);
            this.pageNum.TabIndex = 7;
            // 
            // ToPageBtn
            // 
            this.ToPageBtn.Location = new System.Drawing.Point(99, 407);
            this.ToPageBtn.Name = "ToPageBtn";
            this.ToPageBtn.Size = new System.Drawing.Size(64, 20);
            this.ToPageBtn.TabIndex = 8;
            this.ToPageBtn.Text = "Озвучить";
            this.ToPageBtn.UseVisualStyleBackColor = true;
            this.ToPageBtn.Click += new System.EventHandler(this.ToPageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button pauseButn;
        private System.Windows.Forms.Button startButn;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button beforePageBtn;
        public System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.ToolStripMenuItem настроикиToolStripMenuItem;
        private System.Windows.Forms.Button ToPageBtn;
        private System.Windows.Forms.TextBox pageNum;
    }
}

