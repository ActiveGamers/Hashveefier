namespace Hashveefier
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl = new TabControl();
            tabVerify = new TabPage();
            pnlVerifyResult = new Panel();
            lblVerifyResult = new Label();
            picVerifyResult = new PictureBox();
            btnCopyComputedHash = new Button();
            txtComputedHash = new TextBox();
            label3 = new Label();
            btnVerify = new Button();
            prgVerify = new ProgressBar();
            btnLoadExpectedHash = new Button();
            txtExpectedHash = new TextBox();
            label2 = new Label();
            btnBrowseVerify = new Button();
            txtVerifyFilePath = new TextBox();
            label1 = new Label();
            tabGenerate = new TabPage();
            btnSaveToFile = new Button();
            btnCopyGenerated = new Button();
            txtGeneratedHash = new TextBox();
            label6 = new Label();
            btnGenerate = new Button();
            prgGenerate = new ProgressBar();
            btnBrowseGen = new Button();
            txtGenFilePath = new TextBox();
            label4 = new Label();
            btnAbout = new Button();
            lblStatus = new Label();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tabControl.SuspendLayout();
            tabVerify.SuspendLayout();
            pnlVerifyResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVerifyResult).BeginInit();
            tabGenerate.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabVerify);
            tabControl.Controls.Add(tabGenerate);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(660, 350);
            tabControl.TabIndex = 0;
            // 
            // tabVerify
            // 
            tabVerify.Controls.Add(pnlVerifyResult);
            tabVerify.Controls.Add(btnVerify);
            tabVerify.Controls.Add(prgVerify);
            tabVerify.Controls.Add(btnLoadExpectedHash);
            tabVerify.Controls.Add(txtExpectedHash);
            tabVerify.Controls.Add(label2);
            tabVerify.Controls.Add(btnBrowseVerify);
            tabVerify.Controls.Add(txtVerifyFilePath);
            tabVerify.Controls.Add(label1);
            tabVerify.Location = new Point(4, 24);
            tabVerify.Name = "tabVerify";
            tabVerify.Padding = new Padding(3);
            tabVerify.Size = new Size(652, 322);
            tabVerify.TabIndex = 0;
            tabVerify.Text = "Verify Hash";
            tabVerify.UseVisualStyleBackColor = true;
            // 
            // pnlVerifyResult
            // 
            pnlVerifyResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlVerifyResult.BackColor = SystemColors.ControlLight;
            pnlVerifyResult.BorderStyle = BorderStyle.FixedSingle;
            pnlVerifyResult.Controls.Add(lblVerifyResult);
            pnlVerifyResult.Controls.Add(picVerifyResult);
            pnlVerifyResult.Controls.Add(btnCopyComputedHash);
            pnlVerifyResult.Controls.Add(txtComputedHash);
            pnlVerifyResult.Controls.Add(label3);
            pnlVerifyResult.Location = new Point(9, 160);
            pnlVerifyResult.Name = "pnlVerifyResult";
            pnlVerifyResult.Size = new Size(634, 150);
            pnlVerifyResult.TabIndex = 8;
            pnlVerifyResult.Visible = false;
            // 
            // lblVerifyResult
            // 
            lblVerifyResult.AutoSize = true;
            lblVerifyResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVerifyResult.Location = new Point(50, 15);
            lblVerifyResult.Name = "lblVerifyResult";
            lblVerifyResult.Size = new Size(57, 21);
            lblVerifyResult.TabIndex = 4;
            lblVerifyResult.Text = "Result";
            // 
            // picVerifyResult
            // 
            picVerifyResult.Location = new Point(15, 15);
            picVerifyResult.Name = "picVerifyResult";
            picVerifyResult.Size = new Size(32, 32);
            picVerifyResult.TabIndex = 3;
            picVerifyResult.TabStop = false;
            // 
            // btnCopyComputedHash
            // 
            btnCopyComputedHash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyComputedHash.Location = new Point(540, 80);
            btnCopyComputedHash.Name = "btnCopyComputedHash";
            btnCopyComputedHash.Size = new Size(75, 25);
            btnCopyComputedHash.TabIndex = 2;
            btnCopyComputedHash.Text = "Copy";
            btnCopyComputedHash.UseVisualStyleBackColor = true;
            btnCopyComputedHash.Click += BtnCopyComputedHash_Click;
            // 
            // txtComputedHash
            // 
            txtComputedHash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtComputedHash.Font = new Font("Consolas", 9F);
            txtComputedHash.Location = new Point(15, 80);
            txtComputedHash.Multiline = true;
            txtComputedHash.Name = "txtComputedHash";
            txtComputedHash.ReadOnly = true;
            txtComputedHash.Size = new Size(519, 55);
            txtComputedHash.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 60);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Computed Hash:";
            // 
            // btnVerify
            // 
            btnVerify.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVerify.BackColor = Color.FromArgb(43, 108, 176);
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(9, 120);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(634, 34);
            btnVerify.TabIndex = 7;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += BtnVerify_Click;
            // 
            // prgVerify
            // 
            prgVerify.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgVerify.Location = new Point(9, 120);
            prgVerify.Name = "prgVerify";
            prgVerify.Size = new Size(634, 34);
            prgVerify.Style = ProgressBarStyle.Continuous;
            prgVerify.TabIndex = 6;
            prgVerify.Visible = false;
            // 
            // btnLoadExpectedHash
            // 
            btnLoadExpectedHash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadExpectedHash.Location = new Point(568, 75);
            btnLoadExpectedHash.Name = "btnLoadExpectedHash";
            btnLoadExpectedHash.Size = new Size(75, 25);
            btnLoadExpectedHash.TabIndex = 5;
            btnLoadExpectedHash.Text = "Load...";
            btnLoadExpectedHash.UseVisualStyleBackColor = true;
            btnLoadExpectedHash.Click += BtnLoadExpectedHash_Click;
            // 
            // txtExpectedHash
            // 
            txtExpectedHash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExpectedHash.Font = new Font("Consolas", 9F);
            txtExpectedHash.Location = new Point(9, 77);
            txtExpectedHash.Name = "txtExpectedHash";
            txtExpectedHash.PlaceholderText = "Paste SHA-256 hash here (64 hex characters)";
            txtExpectedHash.Size = new Size(553, 22);
            txtExpectedHash.TabIndex = 4;
            txtExpectedHash.TextChanged += TxtExpectedHash_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 59);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Expected Hash:";
            // 
            // btnBrowseVerify
            // 
            btnBrowseVerify.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseVerify.Location = new Point(568, 27);
            btnBrowseVerify.Name = "btnBrowseVerify";
            btnBrowseVerify.Size = new Size(75, 25);
            btnBrowseVerify.TabIndex = 2;
            btnBrowseVerify.Text = "Browse...";
            btnBrowseVerify.UseVisualStyleBackColor = true;
            btnBrowseVerify.Click += BtnBrowseVerify_Click;
            // 
            // txtVerifyFilePath
            // 
            txtVerifyFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVerifyFilePath.Location = new Point(9, 29);
            txtVerifyFilePath.Name = "txtVerifyFilePath";
            txtVerifyFilePath.ReadOnly = true;
            txtVerifyFilePath.Size = new Size(553, 23);
            txtVerifyFilePath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Select file to verify:";
            // 
            // tabGenerate
            // 
            tabGenerate.Controls.Add(btnSaveToFile);
            tabGenerate.Controls.Add(btnCopyGenerated);
            tabGenerate.Controls.Add(txtGeneratedHash);
            tabGenerate.Controls.Add(label6);
            tabGenerate.Controls.Add(btnGenerate);
            tabGenerate.Controls.Add(prgGenerate);
            tabGenerate.Controls.Add(btnBrowseGen);
            tabGenerate.Controls.Add(txtGenFilePath);
            tabGenerate.Controls.Add(label4);
            tabGenerate.Location = new Point(4, 24);
            tabGenerate.Name = "tabGenerate";
            tabGenerate.Padding = new Padding(3);
            tabGenerate.Size = new Size(652, 322);
            tabGenerate.TabIndex = 1;
            tabGenerate.Text = "Generate Hash";
            tabGenerate.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveToFile.Location = new Point(568, 160);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(75, 25);
            btnSaveToFile.TabIndex = 8;
            btnSaveToFile.Text = "Save...";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += BtnSaveToFile_Click;
            // 
            // btnCopyGenerated
            // 
            btnCopyGenerated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyGenerated.Location = new Point(487, 160);
            btnCopyGenerated.Name = "btnCopyGenerated";
            btnCopyGenerated.Size = new Size(75, 25);
            btnCopyGenerated.TabIndex = 7;
            btnCopyGenerated.Text = "Copy";
            btnCopyGenerated.UseVisualStyleBackColor = true;
            btnCopyGenerated.Click += BtnCopyGenerated_Click;
            // 
            // txtGeneratedHash
            // 
            txtGeneratedHash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGeneratedHash.Font = new Font("Consolas", 9F);
            txtGeneratedHash.Location = new Point(9, 100);
            txtGeneratedHash.Multiline = true;
            txtGeneratedHash.Name = "txtGeneratedHash";
            txtGeneratedHash.ReadOnly = true;
            txtGeneratedHash.Size = new Size(634, 54);
            txtGeneratedHash.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 82);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 5;
            label6.Text = "Generated Hash:";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerate.BackColor = Color.FromArgb(43, 108, 176);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(9, 50);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(634, 29);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate SHA-256";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // prgGenerate
            // 
            prgGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgGenerate.Location = new Point(9, 50);
            prgGenerate.Name = "prgGenerate";
            prgGenerate.Size = new Size(634, 29);
            prgGenerate.Style = ProgressBarStyle.Continuous;
            prgGenerate.TabIndex = 3;
            prgGenerate.Visible = false;
            // 
            // btnBrowseGen
            // 
            btnBrowseGen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseGen.Location = new Point(568, 21);
            btnBrowseGen.Name = "btnBrowseGen";
            btnBrowseGen.Size = new Size(75, 25);
            btnBrowseGen.TabIndex = 2;
            btnBrowseGen.Text = "Browse...";
            btnBrowseGen.UseVisualStyleBackColor = true;
            btnBrowseGen.Click += BtnBrowseGen_Click;
            // 
            // txtGenFilePath
            // 
            txtGenFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGenFilePath.Location = new Point(9, 23);
            txtGenFilePath.Name = "txtGenFilePath";
            txtGenFilePath.ReadOnly = true;
            txtGenFilePath.Size = new Size(553, 23);
            txtGenFilePath.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 5);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 0;
            label4.Text = "Select file to hash:";
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbout.Location = new Point(597, 368);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 25);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += BtnAbout_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 373);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "All files|*.*";
            openFileDialog.Title = "Select file";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            saveFileDialog.Title = "Save hash to file";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 401);
            Controls.Add(lblStatus);
            Controls.Add(btnAbout);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 440);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hashveefier - SHA-256 File Hasher & Verifier";
            tabControl.ResumeLayout(false);
            tabVerify.ResumeLayout(false);
            tabVerify.PerformLayout();
            pnlVerifyResult.ResumeLayout(false);
            pnlVerifyResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVerifyResult).EndInit();
            tabGenerate.ResumeLayout(false);
            tabGenerate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabVerify;
        private TabPage tabGenerate;
        private Button btnAbout;
        private Label lblStatus;
        private Label label1;
        private TextBox txtVerifyFilePath;
        private Button btnBrowseVerify;
        private TextBox txtExpectedHash;
        private Label label2;
        private Button btnLoadExpectedHash;
        private ProgressBar prgVerify;
        private Button btnVerify;
        private Panel pnlVerifyResult;
        private Label label3;
        private TextBox txtComputedHash;
        private Button btnCopyComputedHash;
        private PictureBox picVerifyResult;
        private Label lblVerifyResult;
        private Label label4;
        private TextBox txtGenFilePath;
        private Button btnBrowseGen;
        private ProgressBar prgGenerate;
        private Button btnGenerate;
        private TextBox txtGeneratedHash;
        private Label label6;
        private Button btnCopyGenerated;
        private Button btnSaveToFile;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}