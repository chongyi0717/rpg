namespace F74087028_practice_6_2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.warrior_button = new System.Windows.Forms.Button();
            this.tank_button = new System.Windows.Forms.Button();
            this.ranger_button = new System.Windows.Forms.Button();
            this.work_label = new System.Windows.Forms.Label();
            this.monster_label = new System.Windows.Forms.Label();
            this.text_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.work_hp_label = new System.Windows.Forms.Label();
            this.work_mp_label = new System.Windows.Forms.Label();
            this.work_atk_label = new System.Windows.Forms.Label();
            this.attack_button = new System.Windows.Forms.Button();
            this.skill_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.monster_atk_label = new System.Windows.Forms.Label();
            this.monster_mp_label = new System.Windows.Forms.Label();
            this.monster_hp_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.round_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇職業";
            // 
            // warrior_button
            // 
            this.warrior_button.Location = new System.Drawing.Point(123, 19);
            this.warrior_button.Name = "warrior_button";
            this.warrior_button.Size = new System.Drawing.Size(75, 32);
            this.warrior_button.TabIndex = 1;
            this.warrior_button.Text = "戰士";
            this.warrior_button.UseVisualStyleBackColor = true;
            this.warrior_button.Click += new System.EventHandler(this.warrior_button_Click);
            // 
            // tank_button
            // 
            this.tank_button.Location = new System.Drawing.Point(231, 19);
            this.tank_button.Name = "tank_button";
            this.tank_button.Size = new System.Drawing.Size(75, 32);
            this.tank_button.TabIndex = 2;
            this.tank_button.Text = "坦克";
            this.tank_button.UseVisualStyleBackColor = true;
            this.tank_button.Click += new System.EventHandler(this.tank_button_Click);
            // 
            // ranger_button
            // 
            this.ranger_button.Location = new System.Drawing.Point(332, 19);
            this.ranger_button.Name = "ranger_button";
            this.ranger_button.Size = new System.Drawing.Size(75, 32);
            this.ranger_button.TabIndex = 3;
            this.ranger_button.Text = "遊俠";
            this.ranger_button.UseVisualStyleBackColor = true;
            this.ranger_button.Click += new System.EventHandler(this.ranger_button_Click);
            // 
            // work_label
            // 
            this.work_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_label.Location = new System.Drawing.Point(34, 98);
            this.work_label.Name = "work_label";
            this.work_label.Size = new System.Drawing.Size(112, 49);
            this.work_label.TabIndex = 4;
            this.work_label.Text = "職業";
            // 
            // monster_label
            // 
            this.monster_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monster_label.Location = new System.Drawing.Point(628, 98);
            this.monster_label.Name = "monster_label";
            this.monster_label.Size = new System.Drawing.Size(112, 49);
            this.monster_label.TabIndex = 5;
            this.monster_label.Text = "魔物";
            // 
            // text_label
            // 
            this.text_label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.text_label.Location = new System.Drawing.Point(174, 98);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(419, 488);
            this.text_label.TabIndex = 6;
            this.text_label.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "MP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ATK:";
            // 
            // work_hp_label
            // 
            this.work_hp_label.AutoSize = true;
            this.work_hp_label.Location = new System.Drawing.Point(89, 177);
            this.work_hp_label.Name = "work_hp_label";
            this.work_hp_label.Size = new System.Drawing.Size(46, 17);
            this.work_hp_label.TabIndex = 10;
            this.work_hp_label.Text = "label5";
            // 
            // work_mp_label
            // 
            this.work_mp_label.AutoSize = true;
            this.work_mp_label.Location = new System.Drawing.Point(89, 227);
            this.work_mp_label.Name = "work_mp_label";
            this.work_mp_label.Size = new System.Drawing.Size(46, 17);
            this.work_mp_label.TabIndex = 11;
            this.work_mp_label.Text = "label6";
            // 
            // work_atk_label
            // 
            this.work_atk_label.AutoSize = true;
            this.work_atk_label.Location = new System.Drawing.Point(89, 282);
            this.work_atk_label.Name = "work_atk_label";
            this.work_atk_label.Size = new System.Drawing.Size(46, 17);
            this.work_atk_label.TabIndex = 12;
            this.work_atk_label.Text = "label7";
            // 
            // attack_button
            // 
            this.attack_button.Location = new System.Drawing.Point(42, 354);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(75, 34);
            this.attack_button.TabIndex = 19;
            this.attack_button.Text = "攻擊";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.attack_button_Click);
            // 
            // skill_button
            // 
            this.skill_button.Location = new System.Drawing.Point(42, 411);
            this.skill_button.Name = "skill_button";
            this.skill_button.Size = new System.Drawing.Size(75, 40);
            this.skill_button.TabIndex = 20;
            this.skill_button.Text = "技能";
            this.skill_button.UseVisualStyleBackColor = true;
            this.skill_button.Click += new System.EventHandler(this.skill_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(741, 549);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(75, 34);
            this.continue_button.TabIndex = 21;
            this.continue_button.Text = "繼續";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // monster_atk_label
            // 
            this.monster_atk_label.AutoSize = true;
            this.monster_atk_label.Location = new System.Drawing.Point(704, 282);
            this.monster_atk_label.Name = "monster_atk_label";
            this.monster_atk_label.Size = new System.Drawing.Size(46, 17);
            this.monster_atk_label.TabIndex = 27;
            this.monster_atk_label.Text = "label7";
            // 
            // monster_mp_label
            // 
            this.monster_mp_label.AutoSize = true;
            this.monster_mp_label.Location = new System.Drawing.Point(704, 227);
            this.monster_mp_label.Name = "monster_mp_label";
            this.monster_mp_label.Size = new System.Drawing.Size(46, 17);
            this.monster_mp_label.TabIndex = 26;
            this.monster_mp_label.Text = "label6";
            // 
            // monster_hp_label
            // 
            this.monster_hp_label.AutoSize = true;
            this.monster_hp_label.Location = new System.Drawing.Point(704, 177);
            this.monster_hp_label.Name = "monster_hp_label";
            this.monster_hp_label.Size = new System.Drawing.Size(46, 17);
            this.monster_hp_label.TabIndex = 25;
            this.monster_hp_label.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(641, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "ATK:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "MP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(642, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "HP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "關卡：";
            // 
            // round_label
            // 
            this.round_label.AutoSize = true;
            this.round_label.Location = new System.Drawing.Point(686, 26);
            this.round_label.Name = "round_label";
            this.round_label.Size = new System.Drawing.Size(46, 17);
            this.round_label.TabIndex = 29;
            this.round_label.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 595);
            this.Controls.Add(this.round_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monster_atk_label);
            this.Controls.Add(this.monster_mp_label);
            this.Controls.Add(this.monster_hp_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.skill_button);
            this.Controls.Add(this.attack_button);
            this.Controls.Add(this.work_atk_label);
            this.Controls.Add(this.work_mp_label);
            this.Controls.Add(this.work_hp_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.monster_label);
            this.Controls.Add(this.work_label);
            this.Controls.Add(this.ranger_button);
            this.Controls.Add(this.tank_button);
            this.Controls.Add(this.warrior_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button warrior_button;
        private System.Windows.Forms.Button tank_button;
        private System.Windows.Forms.Button ranger_button;
        private System.Windows.Forms.Label work_label;
        private System.Windows.Forms.Label monster_label;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label work_hp_label;
        private System.Windows.Forms.Label work_mp_label;
        private System.Windows.Forms.Label work_atk_label;
        private System.Windows.Forms.Button attack_button;
        private System.Windows.Forms.Button skill_button;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.Label monster_atk_label;
        private System.Windows.Forms.Label monster_mp_label;
        private System.Windows.Forms.Label monster_hp_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label round_label;
    }
}

