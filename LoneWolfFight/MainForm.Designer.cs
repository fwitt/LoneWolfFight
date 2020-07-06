namespace LoneWolfFight
{
    partial class MainForm
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
            this.playerStartHpLabel = new System.Windows.Forms.Label();
            this.playerStartHpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.enemyStartHpLabel = new System.Windows.Forms.Label();
            this.enemyStartHpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.enemySkillNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.enemySkillLabel = new System.Windows.Forms.Label();
            this.playerSkillNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerSkillLabel = new System.Windows.Forms.Label();
            this.skillDifferenceLabel = new System.Windows.Forms.Label();
            this.skillDifferenceTextBox = new System.Windows.Forms.TextBox();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.diceRollColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerHpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enemyHpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enemyEndHpLabel = new System.Windows.Forms.Label();
            this.playerEndHpLabel = new System.Windows.Forms.Label();
            this.playerEndHpTextBox = new System.Windows.Forms.TextBox();
            this.enemyEndHpTextBox = new System.Windows.Forms.TextBox();
            this.fightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerStartHpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyStartHpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySkillNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSkillNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // playerStartHpLabel
            // 
            this.playerStartHpLabel.AutoSize = true;
            this.playerStartHpLabel.Location = new System.Drawing.Point(13, 13);
            this.playerStartHpLabel.Name = "playerStartHpLabel";
            this.playerStartHpLabel.Size = new System.Drawing.Size(58, 15);
            this.playerStartHpLabel.TabIndex = 0;
            this.playerStartHpLabel.Text = "Player HP";
            // 
            // playerStartHpNumericUpDown
            // 
            this.playerStartHpNumericUpDown.Location = new System.Drawing.Point(77, 11);
            this.playerStartHpNumericUpDown.Name = "playerStartHpNumericUpDown";
            this.playerStartHpNumericUpDown.Size = new System.Drawing.Size(62, 23);
            this.playerStartHpNumericUpDown.TabIndex = 1;
            this.playerStartHpNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.playerStartHpNumericUpDown.ValueChanged += new System.EventHandler(this.StartHpNumericUpDown_ValueChanged);
            // 
            // enemyStartHpLabel
            // 
            this.enemyStartHpLabel.AutoSize = true;
            this.enemyStartHpLabel.Location = new System.Drawing.Point(181, 13);
            this.enemyStartHpLabel.Name = "enemyStartHpLabel";
            this.enemyStartHpLabel.Size = new System.Drawing.Size(62, 15);
            this.enemyStartHpLabel.TabIndex = 2;
            this.enemyStartHpLabel.Text = "Enemy HP";
            // 
            // enemyStartHpNumericUpDown
            // 
            this.enemyStartHpNumericUpDown.Location = new System.Drawing.Point(249, 11);
            this.enemyStartHpNumericUpDown.Name = "enemyStartHpNumericUpDown";
            this.enemyStartHpNumericUpDown.Size = new System.Drawing.Size(62, 23);
            this.enemyStartHpNumericUpDown.TabIndex = 1;
            this.enemyStartHpNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.enemyStartHpNumericUpDown.ValueChanged += new System.EventHandler(this.StartHpNumericUpDown_ValueChanged);
            // 
            // enemySkillNumericUpDown
            // 
            this.enemySkillNumericUpDown.Location = new System.Drawing.Point(249, 40);
            this.enemySkillNumericUpDown.Name = "enemySkillNumericUpDown";
            this.enemySkillNumericUpDown.Size = new System.Drawing.Size(62, 23);
            this.enemySkillNumericUpDown.TabIndex = 1;
            this.enemySkillNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.enemySkillNumericUpDown.ValueChanged += new System.EventHandler(this.SkillNumericUpDown_ValueChanged);
            // 
            // enemySkillLabel
            // 
            this.enemySkillLabel.AutoSize = true;
            this.enemySkillLabel.Location = new System.Drawing.Point(181, 42);
            this.enemySkillLabel.Name = "enemySkillLabel";
            this.enemySkillLabel.Size = new System.Drawing.Size(67, 15);
            this.enemySkillLabel.TabIndex = 2;
            this.enemySkillLabel.Text = "Enemy Skill";
            // 
            // playerSkillNumericUpDown
            // 
            this.playerSkillNumericUpDown.Location = new System.Drawing.Point(77, 40);
            this.playerSkillNumericUpDown.Name = "playerSkillNumericUpDown";
            this.playerSkillNumericUpDown.Size = new System.Drawing.Size(62, 23);
            this.playerSkillNumericUpDown.TabIndex = 1;
            this.playerSkillNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.playerSkillNumericUpDown.ValueChanged += new System.EventHandler(this.SkillNumericUpDown_ValueChanged);
            // 
            // playerSkillLabel
            // 
            this.playerSkillLabel.AutoSize = true;
            this.playerSkillLabel.Location = new System.Drawing.Point(13, 42);
            this.playerSkillLabel.Name = "playerSkillLabel";
            this.playerSkillLabel.Size = new System.Drawing.Size(63, 15);
            this.playerSkillLabel.TabIndex = 0;
            this.playerSkillLabel.Text = "Player Skill";
            // 
            // skillDifferenceLabel
            // 
            this.skillDifferenceLabel.AutoSize = true;
            this.skillDifferenceLabel.Location = new System.Drawing.Point(350, 42);
            this.skillDifferenceLabel.Name = "skillDifferenceLabel";
            this.skillDifferenceLabel.Size = new System.Drawing.Size(85, 15);
            this.skillDifferenceLabel.TabIndex = 3;
            this.skillDifferenceLabel.Text = "Skill Difference";
            // 
            // skillDifferenceTextBox
            // 
            this.skillDifferenceTextBox.Location = new System.Drawing.Point(438, 39);
            this.skillDifferenceTextBox.Name = "skillDifferenceTextBox";
            this.skillDifferenceTextBox.ReadOnly = true;
            this.skillDifferenceTextBox.Size = new System.Drawing.Size(62, 23);
            this.skillDifferenceTextBox.TabIndex = 4;
            this.skillDifferenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultsListView
            // 
            this.resultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diceRollColumn,
            this.playerHpColumn,
            this.enemyHpColumn});
            this.resultsDataGridView.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight };
            this.resultsDataGridView.Location = new System.Drawing.Point(13, 77);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.RowHeadersVisible = false;
            this.resultsDataGridView.Size = new System.Drawing.Size(487, 254);
            this.resultsDataGridView.TabIndex = 5;
            // 
            // diceRollColumn
            // 
            this.diceRollColumn.Name = "diceRollColumn";
            this.diceRollColumn.HeaderText = "Roll";
            this.diceRollColumn.FillWeight = 40;    
            // 
            // playerHpColumn
            // 
            this.playerHpColumn.Name = "playerHpColumn";
            this.playerHpColumn.HeaderText = "Player HP";
            this.playerHpColumn.FillWeight = 40;
            // 
            // enemyHpColumn
            // 
            this.enemyHpColumn.Name = "enemyHpColumn";
            this.enemyHpColumn.HeaderText = "Enemy HP";
            this.enemyHpColumn.FillWeight = 40;
            // 
            // enemyEndHpLabel
            // 
            this.enemyEndHpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enemyEndHpLabel.AutoSize = true;
            this.enemyEndHpLabel.Location = new System.Drawing.Point(181, 352);
            this.enemyEndHpLabel.Name = "enemyEndHpLabel";
            this.enemyEndHpLabel.Size = new System.Drawing.Size(62, 15);
            this.enemyEndHpLabel.TabIndex = 2;
            this.enemyEndHpLabel.Text = "Enemy HP";
            // 
            // playerEndHpLabel
            // 
            this.playerEndHpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerEndHpLabel.AutoSize = true;
            this.playerEndHpLabel.Location = new System.Drawing.Point(13, 352);
            this.playerEndHpLabel.Name = "playerEndHpLabel";
            this.playerEndHpLabel.Size = new System.Drawing.Size(58, 15);
            this.playerEndHpLabel.TabIndex = 0;
            this.playerEndHpLabel.Text = "Player HP";
            // 
            // playerEndHpTextBox
            // 
            this.playerEndHpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerEndHpTextBox.Location = new System.Drawing.Point(77, 349);
            this.playerEndHpTextBox.Name = "playerEndHpTextBox";
            this.playerEndHpTextBox.ReadOnly = true;
            this.playerEndHpTextBox.Size = new System.Drawing.Size(62, 23);
            this.playerEndHpTextBox.TabIndex = 4;
            this.playerEndHpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enemyEndHpTextBox
            // 
            this.enemyEndHpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enemyEndHpTextBox.Location = new System.Drawing.Point(249, 349);
            this.enemyEndHpTextBox.Name = "enemyEndHpTextBox";
            this.enemyEndHpTextBox.ReadOnly = true;
            this.enemyEndHpTextBox.Size = new System.Drawing.Size(62, 23);
            this.enemyEndHpTextBox.TabIndex = 4;
            this.enemyEndHpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fightButton
            // 
            this.fightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fightButton.Location = new System.Drawing.Point(438, 349);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(62, 23);
            this.fightButton.TabIndex = 6;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 387);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.enemyEndHpTextBox);
            this.Controls.Add(this.playerEndHpTextBox);
            this.Controls.Add(this.playerEndHpLabel);
            this.Controls.Add(this.enemyEndHpLabel);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.skillDifferenceTextBox);
            this.Controls.Add(this.skillDifferenceLabel);
            this.Controls.Add(this.playerSkillLabel);
            this.Controls.Add(this.playerSkillNumericUpDown);
            this.Controls.Add(this.enemySkillLabel);
            this.Controls.Add(this.enemySkillNumericUpDown);
            this.Controls.Add(this.enemyStartHpNumericUpDown);
            this.Controls.Add(this.enemyStartHpLabel);
            this.Controls.Add(this.playerStartHpNumericUpDown);
            this.Controls.Add(this.playerStartHpLabel);
            this.MinimumSize = new System.Drawing.Size(532, 426);
            this.Name = "MainForm";
            this.Text = "Lone Wolf Fight";
            ((System.ComponentModel.ISupportInitialize)(this.playerStartHpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyStartHpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySkillNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSkillNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerStartHpLabel;
        private System.Windows.Forms.NumericUpDown playerStartHpNumericUpDown;
        private System.Windows.Forms.Label enemyStartHpLabel;
        private System.Windows.Forms.NumericUpDown enemyStartHpNumericUpDown;
        private System.Windows.Forms.NumericUpDown enemySkillNumericUpDown;
        private System.Windows.Forms.Label enemySkillLabel;
        private System.Windows.Forms.NumericUpDown playerSkillNumericUpDown;
        private System.Windows.Forms.Label playerSkillLabel;
        private System.Windows.Forms.Label skillDifferenceLabel;
        private System.Windows.Forms.TextBox skillDifferenceTextBox;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn diceRollColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerHpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enemyHpColumn;
        private System.Windows.Forms.Label enemyEndHpLabel;
        private System.Windows.Forms.Label playerEndHpLabel;
        private System.Windows.Forms.TextBox playerEndHpTextBox;
        private System.Windows.Forms.TextBox enemyEndHpTextBox;
        private System.Windows.Forms.Button fightButton;
    }
}

