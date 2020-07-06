using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoneWolfFight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly Dictionary<int, Dictionary<int, HpLoss>> SkillDifferenceCharts = new Dictionary<int, Dictionary<int, HpLoss>>
        {
            { -6, new Dictionary<int, HpLoss> { { 1, new HpLoss(null, 0) }, { 2, new HpLoss(null, 0) }, { 3, new HpLoss(8, 0) }, { 4, new HpLoss(8, 0) }, { 5, new HpLoss(7, 1) }, { 6, new HpLoss(6, 2) }, { 7, new HpLoss(5, 3) }, { 8, new HpLoss(4, 4) }, { 9, new HpLoss(3, 5) }, { 10, new HpLoss(0, 6) }, } },
            { -5, new Dictionary<int, HpLoss> { { 1, new HpLoss(null, 0) }, { 2, new HpLoss(8, 0) }, { 3, new HpLoss(7, 0) }, { 4, new HpLoss(7, 1) }, { 5, new HpLoss(6, 2) }, { 6, new HpLoss(6, 3) }, { 7, new HpLoss(5, 4) }, { 8, new HpLoss(4, 5) }, { 9, new HpLoss(3, 6) }, { 10, new HpLoss(0, 7) }, } },
            { -4, new Dictionary<int, HpLoss> { { 1, new HpLoss(8, 0) }, { 2, new HpLoss(7, 0) }, { 3, new HpLoss(6, 1) }, { 4, new HpLoss(6, 2) }, { 5, new HpLoss(5, 3) }, { 6, new HpLoss(5, 4) }, { 7, new HpLoss(4, 5) }, { 8, new HpLoss(3, 6) }, { 9, new HpLoss(2, 7) }, { 10, new HpLoss(0, 8) }, } },
            { -3, new Dictionary<int, HpLoss> { { 1, new HpLoss(6, 0) }, { 2, new HpLoss(6, 1) }, { 3, new HpLoss(5, 2) }, { 4, new HpLoss(5, 3) }, { 5, new HpLoss(4, 4) }, { 6, new HpLoss(4, 5) }, { 7, new HpLoss(3, 6) }, { 8, new HpLoss(2, 7) }, { 9, new HpLoss(0, 8) }, { 10, new HpLoss(0, 9) }, } },
            { -2, new Dictionary<int, HpLoss> { { 1, new HpLoss(6, 1) }, { 2, new HpLoss(5, 2) }, { 3, new HpLoss(5, 3) }, { 4, new HpLoss(4, 4) }, { 5, new HpLoss(4, 5) }, { 6, new HpLoss(3, 6) }, { 7, new HpLoss(2, 7) }, { 8, new HpLoss(1, 8) }, { 9, new HpLoss(0, 9) }, { 10, new HpLoss(0, 10) }, } },
            { -1, new Dictionary<int, HpLoss> { { 1, new HpLoss(5, 2) }, { 2, new HpLoss(5, 3) }, { 3, new HpLoss(4, 4) }, { 4, new HpLoss(4, 5) }, { 5, new HpLoss(3, 6) }, { 6, new HpLoss(2, 7) }, { 7, new HpLoss(2, 8) }, { 8, new HpLoss(0, 9) }, { 9, new HpLoss(0, 10) }, { 10, new HpLoss(0, 11) }, } },
            { 0, new Dictionary<int, HpLoss> { { 1, new HpLoss(5, 3) }, { 2, new HpLoss(4, 4) }, { 3, new HpLoss(4, 5) }, { 4, new HpLoss(3, 6) }, { 5, new HpLoss(2, 7) }, { 6, new HpLoss(2, 8) }, { 7, new HpLoss(1, 9) }, { 8, new HpLoss(0, 10) }, { 9, new HpLoss(0, 11) }, { 10, new HpLoss(0, 12) }, } },
            { 1, new Dictionary<int, HpLoss> { { 1, new HpLoss(5, 4) }, { 2, new HpLoss(4, 5) }, { 3, new HpLoss(3, 6) }, { 4, new HpLoss(3, 7) }, { 5, new HpLoss(2, 8) }, { 6, new HpLoss(2, 9) }, { 7, new HpLoss(1, 10) }, { 8, new HpLoss(0, 11) }, { 9, new HpLoss(0, 12) }, { 10, new HpLoss(0, 14) }, } },
            { 2, new Dictionary<int, HpLoss> { { 1, new HpLoss(4, 5) }, { 2, new HpLoss(3, 6) }, { 3, new HpLoss(3, 7) }, { 4, new HpLoss(3, 8) }, { 5, new HpLoss(2, 9) }, { 6, new HpLoss(2, 10) }, { 7, new HpLoss(1, 11) }, { 8, new HpLoss(0, 12) }, { 9, new HpLoss(0, 14) }, { 10, new HpLoss(0, 16) }, } },
            { 3, new Dictionary<int, HpLoss> { { 1, new HpLoss(4, 6) }, { 2, new HpLoss(3, 7) }, { 3, new HpLoss(3, 8) }, { 4, new HpLoss(2, 9) }, { 5, new HpLoss(2, 10) }, { 6, new HpLoss(1, 11) }, { 7, new HpLoss(0, 12) }, { 8, new HpLoss(0, 14) }, { 9, new HpLoss(0, 16) }, { 10, new HpLoss(0, 18) }, } },
            { 4, new Dictionary<int, HpLoss> { { 1, new HpLoss(4, 7) }, { 2, new HpLoss(3, 8) }, { 3, new HpLoss(2, 9) }, { 4, new HpLoss(2, 10) }, { 5, new HpLoss(2, 11) }, { 6, new HpLoss(1, 12) }, { 7, new HpLoss(0, 14) }, { 8, new HpLoss(0, 16) }, { 9, new HpLoss(0, 18) }, { 10, new HpLoss(0, null) }, } },
            { 5, new Dictionary<int, HpLoss> { { 1, new HpLoss(3, 8) }, { 2, new HpLoss(3, 9) }, { 3, new HpLoss(2, 10) }, { 4, new HpLoss(2, 11) }, { 5, new HpLoss(2, 12) }, { 6, new HpLoss(1, 14) }, { 7, new HpLoss(0, 16) }, { 8, new HpLoss(0, 18) }, { 9, new HpLoss(0, null) }, { 10, new HpLoss(0, null) }, } },
            { 6, new Dictionary<int, HpLoss> { { 1, new HpLoss(3, 9) }, { 2, new HpLoss(2, 10) }, { 3, new HpLoss(2, 11) }, { 4, new HpLoss(2, 12) }, { 5, new HpLoss(1, 14) }, { 6, new HpLoss(1, 16) }, { 7, new HpLoss(0, 18) }, { 8, new HpLoss(0, null) }, { 9, new HpLoss(0, null) }, { 10, new HpLoss(0, null) }, } },
        };

        private void FightButton_Click(object sender, EventArgs e)
        {
            this.ClearResults();

            int skillDifferenceFactor = (int)Math.Round((this.playerSkillNumericUpDown.Value - this.enemySkillNumericUpDown.Value) / 2, MidpointRounding.AwayFromZero);
            skillDifferenceFactor = Math.Min(skillDifferenceFactor, 6);
            skillDifferenceFactor = Math.Max(skillDifferenceFactor, -6);
            int playerHp = (int)this.playerStartHpNumericUpDown.Value;
            int enemyHp = (int)this.enemyStartHpNumericUpDown.Value;

            var skillDifferenceChart = SkillDifferenceCharts[skillDifferenceFactor];
            var random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                var roll = random.Next(1, 11);
                var hpLoss = skillDifferenceChart[roll];
                playerHp = (int)(hpLoss.Player == null ? 0 : playerHp - hpLoss.Player);
                enemyHp = (int)(hpLoss.Enemy == null ? 0 : enemyHp - hpLoss.Enemy);

                this.resultsDataGridView.Rows.Add(roll.ToString(), playerHp.ToString(), enemyHp.ToString());
            }

            this.playerEndHpTextBox.Text = playerHp.ToString();
            this.enemyEndHpTextBox.Text = enemyHp.ToString();
        }

        private void StartHpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.ClearResults();
        }

        private void ClearResults()
        {
            this.resultsDataGridView.Rows.Clear();
            this.playerEndHpTextBox.Text = string.Empty;
            this.enemyEndHpTextBox.Text = string.Empty;
        }

        private void SkillNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.skillDifferenceTextBox.Text = (this.playerSkillNumericUpDown.Value - this.enemySkillNumericUpDown.Value).ToString();
        }

        private class HpLoss
        {
            public HpLoss(int? player, int? enemy)
            {
                Player = player;
                Enemy = enemy;
            }

            public int? Player { get; }
            public int? Enemy { get; }
        }
    }
}
