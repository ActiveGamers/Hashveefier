using System.Security.Cryptography;
using System.Text;

namespace Hashveefier
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource _cancellationTokenSource;

        public MainForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            AllowDrop = true;
            DragEnter += MainForm_DragEnter;
            DragDrop += MainForm_DragDrop;

            var toolTip = new ToolTip();
            toolTip.SetToolTip(btnLoadExpectedHash, "Load hash from a text file");
            toolTip.SetToolTip(btnCopyComputedHash, "Copy computed hash to clipboard");
            toolTip.SetToolTip(btnCopyGenerated, "Copy generated hash to clipboard");
            toolTip.SetToolTip(btnSaveToFile, "Save hash to text file");

            btnCopyComputedHash.Enabled = false;
            btnCopyGenerated.Enabled = false;
            btnSaveToFile.Enabled = false;
        }

        #region Drag & Drop Support
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && File.Exists(files[0]))
            {
                var currentTab = tabControl.SelectedTab;
                if (currentTab == tabVerify)
                {
                    txtVerifyFilePath.Text = files[0];
                }
                else if (currentTab == tabGenerate)
                {
                    txtGenFilePath.Text = files[0];
                }
            }
        }
        #endregion

        #region Verify Tab Methods
        private void BtnBrowseVerify_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtVerifyFilePath.Text = openFileDialog.FileName;
            }
        }

        private void BtnLoadExpectedHash_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Text files|*.txt|All files|*.*",
                Title = "Load expected hash from file"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var content = File.ReadAllText(dialog.FileName);
                    foreach (var line in content.Split('\n'))
                    {
                        var trimmed = line.Trim();
                        if (trimmed.Length == 64 && System.Text.RegularExpressions.Regex.IsMatch(trimmed, @"^[0-9a-fA-F]+$"))
                        {
                            txtExpectedHash.Text = trimmed;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowError($"Failed to read hash file: {ex.Message}");
                }
            }
        }

        private void TxtExpectedHash_TextChanged(object sender, EventArgs e)
        {
            var hash = txtExpectedHash.Text.Trim();
            var isValid = hash.Length == 64 && System.Text.RegularExpressions.Regex.IsMatch(hash, @"^[0-9a-fA-F]+$");

            btnVerify.Enabled = isValid && File.Exists(txtVerifyFilePath.Text);
        }

        private async void BtnVerify_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtVerifyFilePath.Text))
            {
                ShowError("Please select a valid file first.");
                return;
            }

            var expectedHash = txtExpectedHash.Text.Trim().ToLowerInvariant();
            if (expectedHash.Length != 64 || !System.Text.RegularExpressions.Regex.IsMatch(expectedHash, @"^[0-9a-f]+$"))
            {
                ShowError("Expected SHA-256 appears invalid (should be 64 hex characters).");
                return;
            }

            await StartOperationAsync(async (progress, ct) =>
            {
                var computedHash = await ComputeFileSha256Async(txtVerifyFilePath.Text, progress, ct);

                this.Invoke(new Action(() =>
                {
                    DisplayVerifyResult(computedHash, expectedHash);
                }));
            }, prgVerify, btnVerify);
        }

        private void DisplayVerifyResult(string computedHash, string expectedHash)
        {
            pnlVerifyResult.Visible = true;
            txtComputedHash.Text = computedHash;
            btnCopyComputedHash.Enabled = true;

            bool isMatch = string.Equals(computedHash, expectedHash, StringComparison.OrdinalIgnoreCase);

            if (isMatch)
            {
                picVerifyResult.Image = SystemIcons.Shield.ToBitmap();
                lblVerifyResult.Text = "MATCH - Hash Verified Successfully";
                lblVerifyResult.ForeColor = System.Drawing.Color.Green;
                SetStatus("Verification successful - hashes match");
            }
            else
            {
                picVerifyResult.Image = SystemIcons.Error.ToBitmap();
                lblVerifyResult.Text = "MISMATCH - Hashes Do Not Match";
                lblVerifyResult.ForeColor = System.Drawing.Color.Red;
                SetStatus("Verification failed - hashes do not match");
            }
        }

        private void BtnCopyComputedHash_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtComputedHash.Text))
            {
                Clipboard.SetText(txtComputedHash.Text);
                SetStatus("Hash copied to clipboard");
            }
        }
        #endregion

        #region Generate Tab Methods
        private void BtnBrowseGen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtGenFilePath.Text = openFileDialog.FileName;
            }
        }

        private async void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtGenFilePath.Text))
            {
                ShowError("Please select a valid file first.");
                return;
            }

            await StartOperationAsync(async (progress, ct) =>
            {
                var hash = await ComputeFileSha256Async(txtGenFilePath.Text, progress, ct);

                Invoke(new Action(() =>
                  {
                      txtGeneratedHash.Text = hash;
                      btnCopyGenerated.Enabled = true;
                      btnSaveToFile.Enabled = true;
                      SetStatus("Hash generated successfully");
                  }));
            }, prgGenerate, btnGenerate);
        }

        private void BtnCopyGenerated_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGeneratedHash.Text))
            {
                Clipboard.SetText(txtGeneratedHash.Text);
                SetStatus("Hash copied to clipboard");
            }
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtGeneratedHash.Text);
                    SetStatus($"Hash saved to {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    ShowError($"Failed to save file: {ex.Message}");
                }
            }
        }
        #endregion

        #region Core SHA-256 Computation
        public static async Task<string> ComputeFileSha256Async(string filePath, IProgress<double> progress = null, CancellationToken ct = default)
        {
            const int bufferSize = 1024 * 64;
            using var sha256 = SHA256.Create();
            using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, useAsync: true);

            var buffer = new byte[bufferSize];
            long totalBytesRead = 0;
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, ct).ConfigureAwait(false)) > 0)
            {
                ct.ThrowIfCancellationRequested();
                sha256.TransformBlock(buffer, 0, bytesRead, null, 0);
                totalBytesRead += bytesRead;

                if (progress != null && stream.Length > 0)
                {
                    progress.Report((double)totalBytesRead / stream.Length);
                }
            }

            sha256.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
            var hashBytes = sha256.Hash;

            var sb = new StringBuilder(hashBytes.Length * 2);
            foreach (var b in hashBytes)
                sb.AppendFormat("{0:x2}", b);

            return sb.ToString();
        }
        #endregion

        #region Operation Management
        private async Task StartOperationAsync(Func<IProgress<double>, CancellationToken, Task> operation, ProgressBar progressBar, Button operationButton)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            progressBar.Visible = true;
            progressBar.Value = 0;
            operationButton.Enabled = false;
            SetStatus("Processing...");

            var progress = new Progress<double>(p =>
            {
                progressBar.Value = (int)(p * 100);
            });

            try
            {
                await operation(progress, _cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                SetStatus("Operation cancelled");
            }
            catch (Exception ex)
            {
                ShowError($"Operation failed: {ex.Message}");
            }
            finally
            {
                progressBar.Visible = false;
                operationButton.Enabled = true;
                _cancellationTokenSource = null;
            }
        }
        #endregion

        #region UI Helpers
        private void SetStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetStatus($"Error: {message}");
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new Form
            {
                Text = "About Hashveefier",
                Size = new System.Drawing.Size(400, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var label = new Label
            {
                Text = "Hashveefier V1.0\n\nMade With ♥ By ActiveGamers In Iran\n\nGithub: https://github.com/ActiveGamers/Hashveefier",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            };

            var linkLabel = new LinkLabel
            {
                Text = "Open GitHub Repository",
                Dock = DockStyle.Bottom,
                Height = 30,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            linkLabel.Click += (s, args) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/ActiveGamers/Hashveefier",
                    UseShellExecute = true
                });
            };

            aboutForm.Controls.Add(label);
            aboutForm.Controls.Add(linkLabel);
            aboutForm.ShowDialog();
        }
        #endregion
    }
}