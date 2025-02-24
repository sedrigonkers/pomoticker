
namespace PomoTicker
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.TimerLabel = new System.Windows.Forms.Label();
            this.StartPauseButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PhaseLabel = new System.Windows.Forms.Label();
            this.WorkMinutesInput = new System.Windows.Forms.NumericUpDown();
            this.BreakMinutesInput = new System.Windows.Forms.NumericUpDown();
            this.WorkNumpadLabel = new System.Windows.Forms.Label();
            this.ApplySettingsButton = new System.Windows.Forms.Button();
            this.BreakNumpadLabel = new System.Windows.Forms.Label();
            this.SkipPhaseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WorkMinutesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakMinutesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.TimerLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(285, 242);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(126, 57);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "25:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartPauseButton
            // 
            this.StartPauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartPauseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartPauseButton.Location = new System.Drawing.Point(269, 323);
            this.StartPauseButton.Name = "StartPauseButton";
            this.StartPauseButton.Size = new System.Drawing.Size(154, 46);
            this.StartPauseButton.TabIndex = 0;
            this.StartPauseButton.Text = "START";
            this.StartPauseButton.UseVisualStyleBackColor = true;
            this.StartPauseButton.Click += new System.EventHandler(this.StartPauseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(269, 388);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(154, 46);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PhaseLabel
            // 
            this.PhaseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhaseLabel.AutoSize = true;
            this.PhaseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.PhaseLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhaseLabel.ForeColor = System.Drawing.Color.White;
            this.PhaseLabel.Location = new System.Drawing.Point(300, 188);
            this.PhaseLabel.Name = "PhaseLabel";
            this.PhaseLabel.Size = new System.Drawing.Size(97, 38);
            this.PhaseLabel.TabIndex = 4;
            this.PhaseLabel.Text = "Work!";
            this.PhaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkMinutesInput
            // 
            this.WorkMinutesInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorkMinutesInput.AutoSize = true;
            this.WorkMinutesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.WorkMinutesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkMinutesInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkMinutesInput.ForeColor = System.Drawing.Color.White;
            this.WorkMinutesInput.Location = new System.Drawing.Point(75, 82);
            this.WorkMinutesInput.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.WorkMinutesInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WorkMinutesInput.Name = "WorkMinutesInput";
            this.WorkMinutesInput.Size = new System.Drawing.Size(150, 30);
            this.WorkMinutesInput.TabIndex = 3;
            this.WorkMinutesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkMinutesInput.ThousandsSeparator = true;
            this.WorkMinutesInput.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // BreakMinutesInput
            // 
            this.BreakMinutesInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BreakMinutesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.BreakMinutesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BreakMinutesInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakMinutesInput.ForeColor = System.Drawing.Color.White;
            this.BreakMinutesInput.Location = new System.Drawing.Point(269, 82);
            this.BreakMinutesInput.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.BreakMinutesInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BreakMinutesInput.Name = "BreakMinutesInput";
            this.BreakMinutesInput.Size = new System.Drawing.Size(150, 30);
            this.BreakMinutesInput.TabIndex = 4;
            this.BreakMinutesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BreakMinutesInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // WorkNumpadLabel
            // 
            this.WorkNumpadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorkNumpadLabel.AutoSize = true;
            this.WorkNumpadLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkNumpadLabel.ForeColor = System.Drawing.Color.White;
            this.WorkNumpadLabel.Location = new System.Drawing.Point(75, 56);
            this.WorkNumpadLabel.Name = "WorkNumpadLabel";
            this.WorkNumpadLabel.Size = new System.Drawing.Size(117, 23);
            this.WorkNumpadLabel.TabIndex = 7;
            this.WorkNumpadLabel.Text = "Work minutes";
            // 
            // ApplySettingsButton
            // 
            this.ApplySettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplySettingsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApplySettingsButton.Location = new System.Drawing.Point(452, 82);
            this.ApplySettingsButton.Name = "ApplySettingsButton";
            this.ApplySettingsButton.Size = new System.Drawing.Size(117, 30);
            this.ApplySettingsButton.TabIndex = 5;
            this.ApplySettingsButton.Text = "APPLY\r\n";
            this.ApplySettingsButton.UseVisualStyleBackColor = true;
            this.ApplySettingsButton.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // BreakNumpadLabel
            // 
            this.BreakNumpadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BreakNumpadLabel.AutoSize = true;
            this.BreakNumpadLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakNumpadLabel.ForeColor = System.Drawing.Color.White;
            this.BreakNumpadLabel.Location = new System.Drawing.Point(269, 56);
            this.BreakNumpadLabel.Name = "BreakNumpadLabel";
            this.BreakNumpadLabel.Size = new System.Drawing.Size(119, 23);
            this.BreakNumpadLabel.TabIndex = 9;
            this.BreakNumpadLabel.Text = "Break minutes";
            // 
            // SkipPhaseButton
            // 
            this.SkipPhaseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SkipPhaseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipPhaseButton.Location = new System.Drawing.Point(432, 255);
            this.SkipPhaseButton.Name = "SkipPhaseButton";
            this.SkipPhaseButton.Size = new System.Drawing.Size(40, 44);
            this.SkipPhaseButton.TabIndex = 2;
            this.SkipPhaseButton.Text = "->";
            this.SkipPhaseButton.UseVisualStyleBackColor = true;
            this.SkipPhaseButton.Click += new System.EventHandler(this.SkipPhaseButton_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(707, 598);
            this.Controls.Add(this.SkipPhaseButton);
            this.Controls.Add(this.BreakNumpadLabel);
            this.Controls.Add(this.ApplySettingsButton);
            this.Controls.Add(this.WorkNumpadLabel);
            this.Controls.Add(this.BreakMinutesInput);
            this.Controls.Add(this.WorkMinutesInput);
            this.Controls.Add(this.PhaseLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartPauseButton);
            this.Controls.Add(this.TimerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "TimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PomoTicker";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkMinutesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakMinutesInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button StartPauseButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label PhaseLabel;
        private System.Windows.Forms.NumericUpDown WorkMinutesInput;
        private System.Windows.Forms.NumericUpDown BreakMinutesInput;
        private System.Windows.Forms.Label WorkNumpadLabel;
        private System.Windows.Forms.Label BreakNumpadLabel;
        private System.Windows.Forms.Button ApplySettingsButton;
        private System.Windows.Forms.Button SkipPhaseButton;
    }
}

