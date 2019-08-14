namespace TestCPractice.Views
{
    partial class CharacterGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGenerator));
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Identity = new System.Windows.Forms.TabPage();
            this.IdentityTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.Abilities = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.DexLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.SocialLabel = new System.Windows.Forms.Label();
            this.DexDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.IntellectDataLabel = new System.Windows.Forms.Label();
            this.EducationDataLabel = new System.Windows.Forms.Label();
            this.SocialDataLabel = new System.Windows.Forms.Label();
            this.Skills = new System.Windows.Forms.TabPage();
            this.Character = new System.Windows.Forms.TabPage();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.Identity.SuspendLayout();
            this.IdentityTableLayout.SuspendLayout();
            this.Abilities.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(443, 425);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(138, 44);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(16, 425);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(136, 44);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Identity);
            this.MainTabControl.Controls.Add(this.Abilities);
            this.MainTabControl.Controls.Add(this.Skills);
            this.MainTabControl.Controls.Add(this.Character);
            this.MainTabControl.Location = new System.Drawing.Point(4, 53);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(595, 341);
            this.MainTabControl.TabIndex = 1;
            // 
            // Identity
            // 
            this.Identity.Controls.Add(this.IdentityTableLayout);
            this.Identity.Location = new System.Drawing.Point(4, 24);
            this.Identity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Identity.Name = "Identity";
            this.Identity.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Identity.Size = new System.Drawing.Size(587, 313);
            this.Identity.TabIndex = 0;
            this.Identity.Text = "Identity";
            this.Identity.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayout
            // 
            this.IdentityTableLayout.ColumnCount = 4;
            this.IdentityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.Controls.Add(this.FirstNameDataLabel, 1, 0);
            this.IdentityTableLayout.Controls.Add(this.FirstNameLabel, 0, 0);
            this.IdentityTableLayout.Controls.Add(this.LastNameDataLabel, 1, 1);
            this.IdentityTableLayout.Controls.Add(this.GenerateNameButton, 2, 3);
            this.IdentityTableLayout.Controls.Add(this.LastNameLabel, 0, 1);
            this.IdentityTableLayout.Location = new System.Drawing.Point(4, 4);
            this.IdentityTableLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdentityTableLayout.Name = "IdentityTableLayout";
            this.IdentityTableLayout.RowCount = 4;
            this.IdentityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.IdentityTableLayout.Size = new System.Drawing.Size(605, 327);
            this.IdentityTableLayout.TabIndex = 0;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Location = new System.Drawing.Point(4, 81);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(143, 81);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.White;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayout.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(155, 0);
            this.FirstNameDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(446, 81);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(4, 0);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(143, 81);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.White;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayout.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(155, 81);
            this.LastNameDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(446, 81);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateNameButton
            // 
            this.IdentityTableLayout.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(306, 247);
            this.GenerateNameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(285, 62);
            this.GenerateNameButton.TabIndex = 0;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // Abilities
            // 
            this.Abilities.Controls.Add(this.tableLayoutPanel1);
            this.Abilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abilities.Location = new System.Drawing.Point(4, 24);
            this.Abilities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Abilities.Name = "Abilities";
            this.Abilities.Size = new System.Drawing.Size(587, 313);
            this.Abilities.TabIndex = 3;
            this.Abilities.Text = "Abilities";
            this.Abilities.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.23932F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StrengthLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DexLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EnduranceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntellectLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EducationLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SocialLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DexDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EnduranceDataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntellectDataLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EducationDataLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SocialDataLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.810126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.White;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(209, 0);
            this.StrengthDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(87, 38);
            this.StrengthDataLabel.TabIndex = 0;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(4, 0);
            this.StrengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(197, 38);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexLabel
            // 
            this.DexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexLabel.Location = new System.Drawing.Point(4, 38);
            this.DexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(197, 38);
            this.DexLabel.TabIndex = 0;
            this.DexLabel.Text = "Dexterity";
            this.DexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(4, 76);
            this.EnduranceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(197, 38);
            this.EnduranceLabel.TabIndex = 0;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.Location = new System.Drawing.Point(4, 114);
            this.IntellectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(197, 38);
            this.IntellectLabel.TabIndex = 0;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.Location = new System.Drawing.Point(4, 152);
            this.EducationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(197, 38);
            this.EducationLabel.TabIndex = 0;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocialLabel
            // 
            this.SocialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialLabel.Location = new System.Drawing.Point(4, 190);
            this.SocialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SocialLabel.Name = "SocialLabel";
            this.SocialLabel.Size = new System.Drawing.Size(197, 38);
            this.SocialLabel.TabIndex = 0;
            this.SocialLabel.Text = "Social Standing";
            this.SocialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexDataLabel
            // 
            this.DexDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexDataLabel.BackColor = System.Drawing.Color.White;
            this.DexDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexDataLabel.Location = new System.Drawing.Point(209, 38);
            this.DexDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DexDataLabel.Name = "DexDataLabel";
            this.DexDataLabel.Size = new System.Drawing.Size(87, 38);
            this.DexDataLabel.TabIndex = 0;
            this.DexDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.White;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(209, 76);
            this.EnduranceDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(87, 38);
            this.EnduranceDataLabel.TabIndex = 0;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntellectDataLabel
            // 
            this.IntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDataLabel.BackColor = System.Drawing.Color.White;
            this.IntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDataLabel.Location = new System.Drawing.Point(209, 114);
            this.IntellectDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntellectDataLabel.Name = "IntellectDataLabel";
            this.IntellectDataLabel.Size = new System.Drawing.Size(87, 38);
            this.IntellectDataLabel.TabIndex = 0;
            this.IntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EducationDataLabel
            // 
            this.EducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDataLabel.BackColor = System.Drawing.Color.White;
            this.EducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDataLabel.Location = new System.Drawing.Point(209, 152);
            this.EducationDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EducationDataLabel.Name = "EducationDataLabel";
            this.EducationDataLabel.Size = new System.Drawing.Size(87, 38);
            this.EducationDataLabel.TabIndex = 0;
            this.EducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocialDataLabel
            // 
            this.SocialDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialDataLabel.BackColor = System.Drawing.Color.White;
            this.SocialDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialDataLabel.Location = new System.Drawing.Point(209, 190);
            this.SocialDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SocialDataLabel.Name = "SocialDataLabel";
            this.SocialDataLabel.Size = new System.Drawing.Size(87, 38);
            this.SocialDataLabel.TabIndex = 0;
            this.SocialDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Skills
            // 
            this.Skills.Location = new System.Drawing.Point(4, 24);
            this.Skills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Skills.Name = "Skills";
            this.Skills.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Skills.Size = new System.Drawing.Size(587, 313);
            this.Skills.TabIndex = 1;
            this.Skills.Text = "Skills";
            this.Skills.UseVisualStyleBackColor = true;
            // 
            // Character
            // 
            this.Character.Location = new System.Drawing.Point(4, 24);
            this.Character.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(587, 313);
            this.Character.TabIndex = 2;
            this.Character.Text = "Character Sheet";
            this.Character.UseVisualStyleBackColor = true;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MainToolStrip.Size = new System.Drawing.Size(598, 25);
            this.MainToolStrip.TabIndex = 3;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(598, 24);
            this.MainMenuStrip.TabIndex = 2;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // GenerateAbilitiesButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(304, 278);
            this.GenerateAbilitiesButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(269, 27);
            this.GenerateAbilitiesButton.TabIndex = 0;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // CharacterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(598, 480);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CharacterGenerator";
            this.Text = "Character Generator";
            this.MainTabControl.ResumeLayout(false);
            this.Identity.ResumeLayout(false);
            this.IdentityTableLayout.ResumeLayout(false);
            this.Abilities.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Identity;
        private System.Windows.Forms.TabPage Skills;
        private System.Windows.Forms.TabPage Character;
        private System.Windows.Forms.TabPage Abilities;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label DexLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label DexDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label IntellectDataLabel;
        private System.Windows.Forms.Label EducationDataLabel;
        private System.Windows.Forms.Label SocialDataLabel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
    }
}
