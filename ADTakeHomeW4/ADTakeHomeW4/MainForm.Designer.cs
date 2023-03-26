namespace ADTakeHomeW4
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
            this.labelsoccerteamlist = new System.Windows.Forms.Label();
            this.labelchoosecountry = new System.Windows.Forms.Label();
            this.labelchooseteam = new System.Windows.Forms.Label();
            this.labeladdingteam = new System.Windows.Forms.Label();
            this.labelteamname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelplayername = new System.Windows.Forms.Label();
            this.labelplayernumber = new System.Windows.Forms.Label();
            this.labelplayerposition = new System.Windows.Forms.Label();
            this.labeladdingplayer = new System.Windows.Forms.Label();
            this.combochoosecountry = new System.Windows.Forms.ComboBox();
            this.combochooseteam = new System.Windows.Forms.ComboBox();
            this.comboplayerposition = new System.Windows.Forms.ComboBox();
            this.textboxteamname = new System.Windows.Forms.TextBox();
            this.textboxteamcountry = new System.Windows.Forms.TextBox();
            this.textboxteamcity = new System.Windows.Forms.TextBox();
            this.textboxplayername = new System.Windows.Forms.TextBox();
            this.textboxplayernumber = new System.Windows.Forms.TextBox();
            this.listboxplayer = new System.Windows.Forms.ListBox();
            this.buttonaddteam = new System.Windows.Forms.Button();
            this.buttonaddplayer = new System.Windows.Forms.Button();
            this.buttonremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsoccerteamlist
            // 
            this.labelsoccerteamlist.AutoSize = true;
            this.labelsoccerteamlist.Location = new System.Drawing.Point(12, 9);
            this.labelsoccerteamlist.Name = "labelsoccerteamlist";
            this.labelsoccerteamlist.Size = new System.Drawing.Size(132, 20);
            this.labelsoccerteamlist.TabIndex = 0;
            this.labelsoccerteamlist.Text = "Soccer Team List";
            // 
            // labelchoosecountry
            // 
            this.labelchoosecountry.AutoSize = true;
            this.labelchoosecountry.Location = new System.Drawing.Point(12, 51);
            this.labelchoosecountry.Name = "labelchoosecountry";
            this.labelchoosecountry.Size = new System.Drawing.Size(127, 20);
            this.labelchoosecountry.TabIndex = 1;
            this.labelchoosecountry.Text = "Choose Country:";
            // 
            // labelchooseteam
            // 
            this.labelchooseteam.AutoSize = true;
            this.labelchooseteam.Location = new System.Drawing.Point(12, 111);
            this.labelchooseteam.Name = "labelchooseteam";
            this.labelchooseteam.Size = new System.Drawing.Size(112, 20);
            this.labelchooseteam.TabIndex = 2;
            this.labelchooseteam.Text = "Choose Team:";
            // 
            // labeladdingteam
            // 
            this.labeladdingteam.AutoSize = true;
            this.labeladdingteam.Location = new System.Drawing.Point(421, 29);
            this.labeladdingteam.Name = "labeladdingteam";
            this.labeladdingteam.Size = new System.Drawing.Size(103, 20);
            this.labeladdingteam.TabIndex = 3;
            this.labeladdingteam.Text = "Adding Team";
            // 
            // labelteamname
            // 
            this.labelteamname.AutoSize = true;
            this.labelteamname.Location = new System.Drawing.Point(319, 56);
            this.labelteamname.Name = "labelteamname";
            this.labelteamname.Size = new System.Drawing.Size(99, 20);
            this.labelteamname.TabIndex = 4;
            this.labelteamname.Text = "Team Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Team Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team City:";
            // 
            // labelplayername
            // 
            this.labelplayername.AutoSize = true;
            this.labelplayername.Location = new System.Drawing.Point(604, 56);
            this.labelplayername.Name = "labelplayername";
            this.labelplayername.Size = new System.Drawing.Size(102, 20);
            this.labelplayername.TabIndex = 7;
            this.labelplayername.Text = "Player Name:";
            // 
            // labelplayernumber
            // 
            this.labelplayernumber.AutoSize = true;
            this.labelplayernumber.Location = new System.Drawing.Point(604, 98);
            this.labelplayernumber.Name = "labelplayernumber";
            this.labelplayernumber.Size = new System.Drawing.Size(116, 20);
            this.labelplayernumber.TabIndex = 8;
            this.labelplayernumber.Text = "Player Number:";
            // 
            // labelplayerposition
            // 
            this.labelplayerposition.AutoSize = true;
            this.labelplayerposition.Location = new System.Drawing.Point(604, 137);
            this.labelplayerposition.Name = "labelplayerposition";
            this.labelplayerposition.Size = new System.Drawing.Size(116, 20);
            this.labelplayerposition.TabIndex = 9;
            this.labelplayerposition.Text = "Player Position:";
            // 
            // labeladdingplayer
            // 
            this.labeladdingplayer.AutoSize = true;
            this.labeladdingplayer.Location = new System.Drawing.Point(698, 29);
            this.labeladdingplayer.Name = "labeladdingplayer";
            this.labeladdingplayer.Size = new System.Drawing.Size(114, 20);
            this.labeladdingplayer.TabIndex = 10;
            this.labeladdingplayer.Text = "Adding Players";
            // 
            // combochoosecountry
            // 
            this.combochoosecountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combochoosecountry.FormattingEnabled = true;
            this.combochoosecountry.Location = new System.Drawing.Point(145, 48);
            this.combochoosecountry.Name = "combochoosecountry";
            this.combochoosecountry.Size = new System.Drawing.Size(150, 28);
            this.combochoosecountry.TabIndex = 11;
            this.combochoosecountry.SelectedIndexChanged += new System.EventHandler(this.combochoosecountry_SelectedIndexChanged);
            // 
            // combochooseteam
            // 
            this.combochooseteam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combochooseteam.FormattingEnabled = true;
            this.combochooseteam.Location = new System.Drawing.Point(145, 108);
            this.combochooseteam.Name = "combochooseteam";
            this.combochooseteam.Size = new System.Drawing.Size(150, 28);
            this.combochooseteam.TabIndex = 12;
            this.combochooseteam.SelectedIndexChanged += new System.EventHandler(this.combochooseteam_SelectedIndexChanged);
            // 
            // comboplayerposition
            // 
            this.comboplayerposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboplayerposition.FormattingEnabled = true;
            this.comboplayerposition.Location = new System.Drawing.Point(726, 134);
            this.comboplayerposition.Name = "comboplayerposition";
            this.comboplayerposition.Size = new System.Drawing.Size(147, 28);
            this.comboplayerposition.TabIndex = 13;
            // 
            // textboxteamname
            // 
            this.textboxteamname.Location = new System.Drawing.Point(438, 56);
            this.textboxteamname.Name = "textboxteamname";
            this.textboxteamname.Size = new System.Drawing.Size(139, 26);
            this.textboxteamname.TabIndex = 14;
            // 
            // textboxteamcountry
            // 
            this.textboxteamcountry.Location = new System.Drawing.Point(438, 98);
            this.textboxteamcountry.Name = "textboxteamcountry";
            this.textboxteamcountry.Size = new System.Drawing.Size(139, 26);
            this.textboxteamcountry.TabIndex = 15;
            // 
            // textboxteamcity
            // 
            this.textboxteamcity.Location = new System.Drawing.Point(438, 137);
            this.textboxteamcity.Name = "textboxteamcity";
            this.textboxteamcity.Size = new System.Drawing.Size(139, 26);
            this.textboxteamcity.TabIndex = 16;
            // 
            // textboxplayername
            // 
            this.textboxplayername.Location = new System.Drawing.Point(726, 56);
            this.textboxplayername.Name = "textboxplayername";
            this.textboxplayername.Size = new System.Drawing.Size(147, 26);
            this.textboxplayername.TabIndex = 17;
            // 
            // textboxplayernumber
            // 
            this.textboxplayernumber.Location = new System.Drawing.Point(726, 98);
            this.textboxplayernumber.Name = "textboxplayernumber";
            this.textboxplayernumber.Size = new System.Drawing.Size(147, 26);
            this.textboxplayernumber.TabIndex = 18;
            // 
            // listboxplayer
            // 
            this.listboxplayer.FormattingEnabled = true;
            this.listboxplayer.ItemHeight = 20;
            this.listboxplayer.Location = new System.Drawing.Point(16, 173);
            this.listboxplayer.Name = "listboxplayer";
            this.listboxplayer.Size = new System.Drawing.Size(279, 184);
            this.listboxplayer.TabIndex = 19;
            // 
            // buttonaddteam
            // 
            this.buttonaddteam.Location = new System.Drawing.Point(438, 188);
            this.buttonaddteam.Name = "buttonaddteam";
            this.buttonaddteam.Size = new System.Drawing.Size(70, 33);
            this.buttonaddteam.TabIndex = 20;
            this.buttonaddteam.Text = "Add";
            this.buttonaddteam.UseVisualStyleBackColor = true;
            this.buttonaddteam.Click += new System.EventHandler(this.buttonaddteam_Click);
            // 
            // buttonaddplayer
            // 
            this.buttonaddplayer.Location = new System.Drawing.Point(726, 186);
            this.buttonaddplayer.Name = "buttonaddplayer";
            this.buttonaddplayer.Size = new System.Drawing.Size(66, 35);
            this.buttonaddplayer.TabIndex = 21;
            this.buttonaddplayer.Text = "Add";
            this.buttonaddplayer.UseVisualStyleBackColor = true;
            this.buttonaddplayer.Click += new System.EventHandler(this.buttonaddplayer_Click);
            // 
            // buttonremove
            // 
            this.buttonremove.Location = new System.Drawing.Point(16, 363);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(90, 29);
            this.buttonremove.TabIndex = 22;
            this.buttonremove.Text = "Remove";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.buttonaddplayer);
            this.Controls.Add(this.buttonaddteam);
            this.Controls.Add(this.listboxplayer);
            this.Controls.Add(this.textboxplayernumber);
            this.Controls.Add(this.textboxplayername);
            this.Controls.Add(this.textboxteamcity);
            this.Controls.Add(this.textboxteamcountry);
            this.Controls.Add(this.textboxteamname);
            this.Controls.Add(this.comboplayerposition);
            this.Controls.Add(this.combochooseteam);
            this.Controls.Add(this.combochoosecountry);
            this.Controls.Add(this.labeladdingplayer);
            this.Controls.Add(this.labelplayerposition);
            this.Controls.Add(this.labelplayernumber);
            this.Controls.Add(this.labelplayername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelteamname);
            this.Controls.Add(this.labeladdingteam);
            this.Controls.Add(this.labelchooseteam);
            this.Controls.Add(this.labelchoosecountry);
            this.Controls.Add(this.labelsoccerteamlist);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsoccerteamlist;
        private System.Windows.Forms.Label labelchoosecountry;
        private System.Windows.Forms.Label labelchooseteam;
        private System.Windows.Forms.Label labeladdingteam;
        private System.Windows.Forms.Label labelteamname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelplayername;
        private System.Windows.Forms.Label labelplayernumber;
        private System.Windows.Forms.Label labelplayerposition;
        private System.Windows.Forms.Label labeladdingplayer;
        private System.Windows.Forms.ComboBox combochoosecountry;
        private System.Windows.Forms.ComboBox combochooseteam;
        private System.Windows.Forms.ComboBox comboplayerposition;
        private System.Windows.Forms.TextBox textboxteamname;
        private System.Windows.Forms.TextBox textboxteamcountry;
        private System.Windows.Forms.TextBox textboxteamcity;
        private System.Windows.Forms.TextBox textboxplayername;
        private System.Windows.Forms.TextBox textboxplayernumber;
        private System.Windows.Forms.ListBox listboxplayer;
        private System.Windows.Forms.Button buttonaddteam;
        private System.Windows.Forms.Button buttonaddplayer;
        private System.Windows.Forms.Button buttonremove;
    }
}

