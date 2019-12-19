﻿namespace Tower_Defense
{
    partial class LevelInfo
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
            this.waveLabel = new System.Windows.Forms.Label();
            this.SaveInfoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TerrainPanel = new System.Windows.Forms.Panel();
            this.DeepForestButton = new System.Windows.Forms.RadioButton();
            this.BarrenButton = new System.Windows.Forms.RadioButton();
            this.SnowButton = new System.Windows.Forms.RadioButton();
            this.ForestButton = new System.Windows.Forms.RadioButton();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WavesTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YSizeTextBox = new System.Windows.Forms.TextBox();
            this.XSizeTextBox = new System.Windows.Forms.TextBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TerrainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // waveLabel
            // 
            this.waveLabel.AutoSize = true;
            this.waveLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveLabel.Location = new System.Drawing.Point(3, 53);
            this.waveLabel.Name = "waveLabel";
            this.waveLabel.Size = new System.Drawing.Size(58, 18);
            this.waveLabel.TabIndex = 1;
            this.waveLabel.Text = "Waves";
            // 
            // SaveInfoButton
            // 
            this.SaveInfoButton.Location = new System.Drawing.Point(265, 139);
            this.SaveInfoButton.Name = "SaveInfoButton";
            this.SaveInfoButton.Size = new System.Drawing.Size(75, 23);
            this.SaveInfoButton.TabIndex = 2;
            this.SaveInfoButton.Text = "Save";
            this.SaveInfoButton.UseVisualStyleBackColor = true;
            this.SaveInfoButton.Click += new System.EventHandler(this.SaveInfoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terrain";
            // 
            // TerrainPanel
            // 
            this.TerrainPanel.Controls.Add(this.DeepForestButton);
            this.TerrainPanel.Controls.Add(this.BarrenButton);
            this.TerrainPanel.Controls.Add(this.SnowButton);
            this.TerrainPanel.Controls.Add(this.ForestButton);
            this.TerrainPanel.Location = new System.Drawing.Point(165, 34);
            this.TerrainPanel.Name = "TerrainPanel";
            this.TerrainPanel.Size = new System.Drawing.Size(120, 99);
            this.TerrainPanel.TabIndex = 5;
            // 
            // DeepForestButton
            // 
            this.DeepForestButton.AutoSize = true;
            this.DeepForestButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeepForestButton.Location = new System.Drawing.Point(4, 26);
            this.DeepForestButton.Name = "DeepForestButton";
            this.DeepForestButton.Size = new System.Drawing.Size(114, 21);
            this.DeepForestButton.TabIndex = 3;
            this.DeepForestButton.TabStop = true;
            this.DeepForestButton.Text = "Deep-Forest";
            this.DeepForestButton.UseVisualStyleBackColor = true;
            // 
            // BarrenButton
            // 
            this.BarrenButton.AutoSize = true;
            this.BarrenButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarrenButton.Location = new System.Drawing.Point(4, 72);
            this.BarrenButton.Name = "BarrenButton";
            this.BarrenButton.Size = new System.Drawing.Size(74, 21);
            this.BarrenButton.TabIndex = 2;
            this.BarrenButton.TabStop = true;
            this.BarrenButton.Text = "Barren";
            this.BarrenButton.UseVisualStyleBackColor = true;
            // 
            // SnowButton
            // 
            this.SnowButton.AutoSize = true;
            this.SnowButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnowButton.Location = new System.Drawing.Point(4, 49);
            this.SnowButton.Name = "SnowButton";
            this.SnowButton.Size = new System.Drawing.Size(58, 21);
            this.SnowButton.TabIndex = 1;
            this.SnowButton.TabStop = true;
            this.SnowButton.Text = "Snow";
            this.SnowButton.UseVisualStyleBackColor = true;
            // 
            // ForestButton
            // 
            this.ForestButton.AutoSize = true;
            this.ForestButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForestButton.Location = new System.Drawing.Point(4, 3);
            this.ForestButton.Name = "ForestButton";
            this.ForestButton.Size = new System.Drawing.Size(74, 21);
            this.ForestButton.TabIndex = 0;
            this.ForestButton.TabStop = true;
            this.ForestButton.Text = "Forest";
            this.ForestButton.UseVisualStyleBackColor = true;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 13);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(48, 18);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WavesTextBox);
            this.panel2.Controls.Add(this.YLabel);
            this.panel2.Controls.Add(this.XLabel);
            this.panel2.Controls.Add(this.YSizeTextBox);
            this.panel2.Controls.Add(this.XSizeTextBox);
            this.panel2.Controls.Add(this.waveLabel);
            this.panel2.Location = new System.Drawing.Point(15, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 99);
            this.panel2.TabIndex = 7;
            // 
            // WavesTextBox
            // 
            this.WavesTextBox.Location = new System.Drawing.Point(3, 73);
            this.WavesTextBox.Name = "WavesTextBox";
            this.WavesTextBox.Size = new System.Drawing.Size(95, 20);
            this.WavesTextBox.TabIndex = 8;
            this.WavesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WavesTextBox_KeyPress);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(6, 30);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(18, 18);
            this.YLabel.TabIndex = 3;
            this.YLabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(6, 4);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(18, 18);
            this.XLabel.TabIndex = 2;
            this.XLabel.Text = "X";
            // 
            // YSizeTextBox
            // 
            this.YSizeTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YSizeTextBox.Location = new System.Drawing.Point(30, 30);
            this.YSizeTextBox.Name = "YSizeTextBox";
            this.YSizeTextBox.Size = new System.Drawing.Size(68, 20);
            this.YSizeTextBox.TabIndex = 1;
            this.YSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ySizeTextBox_KeyPress);
            // 
            // XSizeTextBox
            // 
            this.XSizeTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XSizeTextBox.Location = new System.Drawing.Point(30, 3);
            this.XSizeTextBox.Name = "XSizeTextBox";
            this.XSizeTextBox.Size = new System.Drawing.Size(68, 20);
            this.XSizeTextBox.TabIndex = 0;
            this.XSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xSizeTextBox_KeyPress);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Courier New", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.Location = new System.Drawing.Point(46, 146);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(197, 16);
            this.WarningLabel.TabIndex = 8;
            this.WarningLabel.Text = "This will reset your level!";
            // 
            // LevelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 175);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TerrainPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveInfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LevelInfo";
            this.Text = "Level Info";
            this.TerrainPanel.ResumeLayout(false);
            this.TerrainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label waveLabel;
        private System.Windows.Forms.Button SaveInfoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel TerrainPanel;
        private System.Windows.Forms.RadioButton DeepForestButton;
        private System.Windows.Forms.RadioButton BarrenButton;
        private System.Windows.Forms.RadioButton SnowButton;
        private System.Windows.Forms.RadioButton ForestButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox YSizeTextBox;
        private System.Windows.Forms.TextBox XSizeTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox WavesTextBox;
        private System.Windows.Forms.Label WarningLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

