
namespace CubariHelper
{
    partial class Form1
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpageManga = new System.Windows.Forms.TabPage();
            this.btnMangaReload = new System.Windows.Forms.Button();
            this.btnMangaSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCoverLink = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tpageChapters = new System.Windows.Forms.TabPage();
            this.btnChapGroupAdd = new System.Windows.Forms.Button();
            this.btnChapGroupSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtChapLink = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtChapGroup = new System.Windows.Forms.TextBox();
            this.gridChapters = new System.Windows.Forms.DataGridView();
            this.txtChapterCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChapterAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLUYear = new System.Windows.Forms.TextBox();
            this.txtLUDay = new System.Windows.Forms.TextBox();
            this.txtLUMonth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChapVol = new System.Windows.Forms.TextBox();
            this.txtChapterTitle = new System.Windows.Forms.TextBox();
            this.gridGroups = new System.Windows.Forms.DataGridView();
            this.tpageOutput = new System.Windows.Forms.TabPage();
            this.panelResultText = new System.Windows.Forms.Panel();
            this.txtGenerated = new System.Windows.Forms.TextBox();
            this.panelResultControls = new System.Windows.Forms.Panel();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnSaveGenerateFile = new System.Windows.Forms.Button();
            this.tpagePub = new System.Windows.Forms.TabPage();
            this.btnCopyOutputString = new System.Windows.Forms.Button();
            this.btnCopyCubariLink = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.btnPubGenerate = new System.Windows.Forms.Button();
            this.txtCubariPubLink = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGitioLink = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGithubUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpageLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tpageManga.SuspendLayout();
            this.tpageChapters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).BeginInit();
            this.tpageOutput.SuspendLayout();
            this.panelResultText.SuspendLayout();
            this.panelResultControls.SuspendLayout();
            this.tpagePub.SuspendLayout();
            this.tpageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpageManga);
            this.tabMain.Controls.Add(this.tpageChapters);
            this.tabMain.Controls.Add(this.tpageOutput);
            this.tabMain.Controls.Add(this.tpagePub);
            this.tabMain.Controls.Add(this.tpageLog);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(969, 499);
            this.tabMain.TabIndex = 4;
            // 
            // tpageManga
            // 
            this.tpageManga.Controls.Add(this.btnMangaReload);
            this.tpageManga.Controls.Add(this.btnMangaSave);
            this.tpageManga.Controls.Add(this.label15);
            this.tpageManga.Controls.Add(this.txtSummary);
            this.tpageManga.Controls.Add(this.label14);
            this.tpageManga.Controls.Add(this.txtCoverLink);
            this.tpageManga.Controls.Add(this.label13);
            this.tpageManga.Controls.Add(this.txtArtist);
            this.tpageManga.Controls.Add(this.label12);
            this.tpageManga.Controls.Add(this.txtAuthor);
            this.tpageManga.Controls.Add(this.label11);
            this.tpageManga.Controls.Add(this.txtTitle);
            this.tpageManga.Location = new System.Drawing.Point(4, 37);
            this.tpageManga.Name = "tpageManga";
            this.tpageManga.Padding = new System.Windows.Forms.Padding(3);
            this.tpageManga.Size = new System.Drawing.Size(961, 458);
            this.tpageManga.TabIndex = 0;
            this.tpageManga.Text = "Manga Details";
            this.tpageManga.UseVisualStyleBackColor = true;
            // 
            // btnMangaReload
            // 
            this.btnMangaReload.Location = new System.Drawing.Point(705, 97);
            this.btnMangaReload.Name = "btnMangaReload";
            this.btnMangaReload.Size = new System.Drawing.Size(216, 46);
            this.btnMangaReload.TabIndex = 28;
            this.btnMangaReload.Text = "Reload Details";
            this.btnMangaReload.UseVisualStyleBackColor = true;
            this.btnMangaReload.Click += new System.EventHandler(this.btnMangaReload_Click);
            // 
            // btnMangaSave
            // 
            this.btnMangaSave.Location = new System.Drawing.Point(705, 38);
            this.btnMangaSave.Name = "btnMangaSave";
            this.btnMangaSave.Size = new System.Drawing.Size(216, 46);
            this.btnMangaSave.TabIndex = 27;
            this.btnMangaSave.Text = "Save Details";
            this.btnMangaSave.UseVisualStyleBackColor = true;
            this.btnMangaSave.Click += new System.EventHandler(this.btnMangaSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 28);
            this.label15.TabIndex = 26;
            this.label15.Text = "Summary:";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(188, 277);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(492, 155);
            this.txtSummary.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 28);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cover Link:";
            // 
            // txtCoverLink
            // 
            this.txtCoverLink.Location = new System.Drawing.Point(188, 214);
            this.txtCoverLink.Name = "txtCoverLink";
            this.txtCoverLink.Size = new System.Drawing.Size(492, 34);
            this.txtCoverLink.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 28);
            this.label13.TabIndex = 22;
            this.label13.Text = "Artist:";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(188, 149);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(492, 34);
            this.txtArtist.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(188, 94);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(492, 34);
            this.txtAuthor.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Manga Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(188, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(492, 34);
            this.txtTitle.TabIndex = 4;
            // 
            // tpageChapters
            // 
            this.tpageChapters.Controls.Add(this.btnChapGroupAdd);
            this.tpageChapters.Controls.Add(this.btnChapGroupSave);
            this.tpageChapters.Controls.Add(this.label17);
            this.tpageChapters.Controls.Add(this.txtChapLink);
            this.tpageChapters.Controls.Add(this.label16);
            this.tpageChapters.Controls.Add(this.txtChapGroup);
            this.tpageChapters.Controls.Add(this.gridChapters);
            this.tpageChapters.Controls.Add(this.txtChapterCount);
            this.tpageChapters.Controls.Add(this.label7);
            this.tpageChapters.Controls.Add(this.btnChapterAdd);
            this.tpageChapters.Controls.Add(this.label6);
            this.tpageChapters.Controls.Add(this.label5);
            this.tpageChapters.Controls.Add(this.label4);
            this.tpageChapters.Controls.Add(this.txtLUYear);
            this.tpageChapters.Controls.Add(this.txtLUDay);
            this.tpageChapters.Controls.Add(this.txtLUMonth);
            this.tpageChapters.Controls.Add(this.label3);
            this.tpageChapters.Controls.Add(this.label2);
            this.tpageChapters.Controls.Add(this.label1);
            this.tpageChapters.Controls.Add(this.txtChapVol);
            this.tpageChapters.Controls.Add(this.txtChapterTitle);
            this.tpageChapters.Controls.Add(this.gridGroups);
            this.tpageChapters.Location = new System.Drawing.Point(4, 37);
            this.tpageChapters.Name = "tpageChapters";
            this.tpageChapters.Padding = new System.Windows.Forms.Padding(3);
            this.tpageChapters.Size = new System.Drawing.Size(961, 458);
            this.tpageChapters.TabIndex = 1;
            this.tpageChapters.Text = "Chapters";
            this.tpageChapters.UseVisualStyleBackColor = true;
            // 
            // btnChapGroupAdd
            // 
            this.btnChapGroupAdd.Location = new System.Drawing.Point(8, 248);
            this.btnChapGroupAdd.Name = "btnChapGroupAdd";
            this.btnChapGroupAdd.Size = new System.Drawing.Size(184, 46);
            this.btnChapGroupAdd.TabIndex = 25;
            this.btnChapGroupAdd.Text = "Add Group";
            this.btnChapGroupAdd.UseVisualStyleBackColor = true;
            this.btnChapGroupAdd.Click += new System.EventHandler(this.btnChapGroupAdd_Click);
            // 
            // btnChapGroupSave
            // 
            this.btnChapGroupSave.Location = new System.Drawing.Point(216, 248);
            this.btnChapGroupSave.Name = "btnChapGroupSave";
            this.btnChapGroupSave.Size = new System.Drawing.Size(184, 46);
            this.btnChapGroupSave.TabIndex = 24;
            this.btnChapGroupSave.Text = "Save groups";
            this.btnChapGroupSave.UseVisualStyleBackColor = true;
            this.btnChapGroupSave.Click += new System.EventHandler(this.btnChapGroupSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 28);
            this.label17.TabIndex = 23;
            this.label17.Text = "Chapter Link:";
            // 
            // txtChapLink
            // 
            this.txtChapLink.Location = new System.Drawing.Point(157, 208);
            this.txtChapLink.Name = "txtChapLink";
            this.txtChapLink.Size = new System.Drawing.Size(442, 34);
            this.txtChapLink.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 28);
            this.label16.TabIndex = 21;
            this.label16.Text = "Group name:";
            // 
            // txtChapGroup
            // 
            this.txtChapGroup.Location = new System.Drawing.Point(157, 168);
            this.txtChapGroup.Name = "txtChapGroup";
            this.txtChapGroup.Size = new System.Drawing.Size(224, 34);
            this.txtChapGroup.TabIndex = 20;
            // 
            // gridChapters
            // 
            this.gridChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChapters.Location = new System.Drawing.Point(625, 59);
            this.gridChapters.Name = "gridChapters";
            this.gridChapters.RowHeadersWidth = 51;
            this.gridChapters.RowTemplate.Height = 29;
            this.gridChapters.Size = new System.Drawing.Size(328, 391);
            this.gridChapters.TabIndex = 19;
            this.gridChapters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChapters_CellDoubleClick);
            this.gridChapters.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridChapters_CellFormatting);
            this.gridChapters.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridChapters_UserDeletedRow);
            // 
            // txtChapterCount
            // 
            this.txtChapterCount.Location = new System.Drawing.Point(157, 13);
            this.txtChapterCount.Name = "txtChapterCount";
            this.txtChapterCount.Size = new System.Drawing.Size(224, 34);
            this.txtChapterCount.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chapter Count:";
            // 
            // btnChapterAdd
            // 
            this.btnChapterAdd.Location = new System.Drawing.Point(625, 7);
            this.btnChapterAdd.Name = "btnChapterAdd";
            this.btnChapterAdd.Size = new System.Drawing.Size(328, 46);
            this.btnChapterAdd.TabIndex = 16;
            this.btnChapterAdd.Text = "Add Chapter";
            this.btnChapterAdd.UseVisualStyleBackColor = true;
            this.btnChapterAdd.Click += new System.EventHandler(this.btnChapterAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Month";
            // 
            // txtLUYear
            // 
            this.txtLUYear.Location = new System.Drawing.Point(485, 137);
            this.txtLUYear.Name = "txtLUYear";
            this.txtLUYear.Size = new System.Drawing.Size(114, 34);
            this.txtLUYear.TabIndex = 12;
            // 
            // txtLUDay
            // 
            this.txtLUDay.Location = new System.Drawing.Point(485, 96);
            this.txtLUDay.Name = "txtLUDay";
            this.txtLUDay.Size = new System.Drawing.Size(114, 34);
            this.txtLUDay.TabIndex = 11;
            // 
            // txtLUMonth
            // 
            this.txtLUMonth.Location = new System.Drawing.Point(485, 56);
            this.txtLUMonth.Name = "txtLUMonth";
            this.txtLUMonth.Size = new System.Drawing.Size(114, 34);
            this.txtLUMonth.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Updated:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Volume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chapter Title:";
            // 
            // txtChapVol
            // 
            this.txtChapVol.Location = new System.Drawing.Point(157, 96);
            this.txtChapVol.Name = "txtChapVol";
            this.txtChapVol.Size = new System.Drawing.Size(224, 34);
            this.txtChapVol.TabIndex = 6;
            // 
            // txtChapterTitle
            // 
            this.txtChapterTitle.Location = new System.Drawing.Point(157, 56);
            this.txtChapterTitle.Name = "txtChapterTitle";
            this.txtChapterTitle.Size = new System.Drawing.Size(224, 34);
            this.txtChapterTitle.TabIndex = 5;
            // 
            // gridGroups
            // 
            this.gridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGroups.Location = new System.Drawing.Point(6, 300);
            this.gridGroups.Name = "gridGroups";
            this.gridGroups.RowHeadersWidth = 51;
            this.gridGroups.RowTemplate.Height = 29;
            this.gridGroups.Size = new System.Drawing.Size(593, 150);
            this.gridGroups.TabIndex = 3;
            this.gridGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGroups_CellDoubleClick);
            // 
            // tpageOutput
            // 
            this.tpageOutput.Controls.Add(this.panelResultText);
            this.tpageOutput.Controls.Add(this.panelResultControls);
            this.tpageOutput.Location = new System.Drawing.Point(4, 37);
            this.tpageOutput.Name = "tpageOutput";
            this.tpageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tpageOutput.Size = new System.Drawing.Size(961, 458);
            this.tpageOutput.TabIndex = 2;
            this.tpageOutput.Text = "Result";
            this.tpageOutput.UseVisualStyleBackColor = true;
            // 
            // panelResultText
            // 
            this.panelResultText.Controls.Add(this.txtGenerated);
            this.panelResultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultText.Location = new System.Drawing.Point(3, 103);
            this.panelResultText.Name = "panelResultText";
            this.panelResultText.Size = new System.Drawing.Size(955, 352);
            this.panelResultText.TabIndex = 6;
            // 
            // txtGenerated
            // 
            this.txtGenerated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGenerated.Location = new System.Drawing.Point(0, 0);
            this.txtGenerated.Multiline = true;
            this.txtGenerated.Name = "txtGenerated";
            this.txtGenerated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGenerated.Size = new System.Drawing.Size(955, 352);
            this.txtGenerated.TabIndex = 2;
            // 
            // panelResultControls
            // 
            this.panelResultControls.Controls.Add(this.btnSerialize);
            this.panelResultControls.Controls.Add(this.btnSaveGenerateFile);
            this.panelResultControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultControls.Location = new System.Drawing.Point(3, 3);
            this.panelResultControls.Name = "panelResultControls";
            this.panelResultControls.Size = new System.Drawing.Size(955, 100);
            this.panelResultControls.TabIndex = 5;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(15, 14);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(166, 46);
            this.btnSerialize.TabIndex = 3;
            this.btnSerialize.Text = "Preview";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnSaveGenerateFile
            // 
            this.btnSaveGenerateFile.Location = new System.Drawing.Point(208, 14);
            this.btnSaveGenerateFile.Name = "btnSaveGenerateFile";
            this.btnSaveGenerateFile.Size = new System.Drawing.Size(166, 46);
            this.btnSaveGenerateFile.TabIndex = 4;
            this.btnSaveGenerateFile.Text = "Save";
            this.btnSaveGenerateFile.UseVisualStyleBackColor = true;
            this.btnSaveGenerateFile.Click += new System.EventHandler(this.btnSaveGenerateFile_Click);
            // 
            // tpagePub
            // 
            this.tpagePub.Controls.Add(this.btnCopyOutputString);
            this.tpagePub.Controls.Add(this.btnCopyCubariLink);
            this.tpagePub.Controls.Add(this.btnBrowseOutput);
            this.tpagePub.Controls.Add(this.btnDownloadFile);
            this.tpagePub.Controls.Add(this.btnPubGenerate);
            this.tpagePub.Controls.Add(this.txtCubariPubLink);
            this.tpagePub.Controls.Add(this.label10);
            this.tpagePub.Controls.Add(this.txtGitioLink);
            this.tpagePub.Controls.Add(this.label9);
            this.tpagePub.Controls.Add(this.txtGithubUrl);
            this.tpagePub.Controls.Add(this.label8);
            this.tpagePub.Location = new System.Drawing.Point(4, 37);
            this.tpagePub.Name = "tpagePub";
            this.tpagePub.Size = new System.Drawing.Size(961, 458);
            this.tpagePub.TabIndex = 3;
            this.tpagePub.Text = "Publish";
            this.tpagePub.UseVisualStyleBackColor = true;
            // 
            // btnCopyOutputString
            // 
            this.btnCopyOutputString.Location = new System.Drawing.Point(264, 277);
            this.btnCopyOutputString.Name = "btnCopyOutputString";
            this.btnCopyOutputString.Size = new System.Drawing.Size(290, 46);
            this.btnCopyOutputString.TabIndex = 29;
            this.btnCopyOutputString.Text = "Copy Output";
            this.btnCopyOutputString.UseVisualStyleBackColor = true;
            this.btnCopyOutputString.Click += new System.EventHandler(this.btnCopyOutputString_Click);
            // 
            // btnCopyCubariLink
            // 
            this.btnCopyCubariLink.Location = new System.Drawing.Point(588, 277);
            this.btnCopyCubariLink.Name = "btnCopyCubariLink";
            this.btnCopyCubariLink.Size = new System.Drawing.Size(290, 46);
            this.btnCopyCubariLink.TabIndex = 28;
            this.btnCopyCubariLink.Text = "Copy Cubari Link";
            this.btnCopyCubariLink.UseVisualStyleBackColor = true;
            this.btnCopyCubariLink.Click += new System.EventHandler(this.btnCopyCubariLink_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(264, 340);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(290, 46);
            this.btnBrowseOutput.TabIndex = 27;
            this.btnBrowseOutput.Text = "Browse to Output";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Location = new System.Drawing.Point(588, 82);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(290, 46);
            this.btnDownloadFile.TabIndex = 26;
            this.btnDownloadFile.Text = "Download File";
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // btnPubGenerate
            // 
            this.btnPubGenerate.Location = new System.Drawing.Point(264, 82);
            this.btnPubGenerate.Name = "btnPubGenerate";
            this.btnPubGenerate.Size = new System.Drawing.Size(290, 46);
            this.btnPubGenerate.TabIndex = 25;
            this.btnPubGenerate.Text = "Generate Cubari Gist";
            this.btnPubGenerate.UseVisualStyleBackColor = true;
            this.btnPubGenerate.Click += new System.EventHandler(this.btnPubGenerate_Click);
            // 
            // txtCubariPubLink
            // 
            this.txtCubariPubLink.Location = new System.Drawing.Point(264, 202);
            this.txtCubariPubLink.Name = "txtCubariPubLink";
            this.txtCubariPubLink.Size = new System.Drawing.Size(614, 34);
            this.txtCubariPubLink.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cubari Link:";
            // 
            // txtGitioLink
            // 
            this.txtGitioLink.Location = new System.Drawing.Point(264, 153);
            this.txtGitioLink.Name = "txtGitioLink";
            this.txtGitioLink.Size = new System.Drawing.Size(614, 34);
            this.txtGitioLink.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gitio link:";
            // 
            // txtGithubUrl
            // 
            this.txtGithubUrl.Location = new System.Drawing.Point(264, 20);
            this.txtGithubUrl.Name = "txtGithubUrl";
            this.txtGithubUrl.Size = new System.Drawing.Size(614, 34);
            this.txtGithubUrl.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Raw URL from Github:";
            // 
            // tpageLog
            // 
            this.tpageLog.Controls.Add(this.txtLog);
            this.tpageLog.Location = new System.Drawing.Point(4, 37);
            this.tpageLog.Name = "tpageLog";
            this.tpageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpageLog.Size = new System.Drawing.Size(961, 458);
            this.tpageLog.TabIndex = 4;
            this.tpageLog.Text = "Logs";
            this.tpageLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(955, 452);
            this.txtLog.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 499);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(987, 546);
            this.Name = "Form1";
            this.Text = "Cubari Helper, by Jacekun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabMain.ResumeLayout(false);
            this.tpageManga.ResumeLayout(false);
            this.tpageManga.PerformLayout();
            this.tpageChapters.ResumeLayout(false);
            this.tpageChapters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).EndInit();
            this.tpageOutput.ResumeLayout(false);
            this.panelResultText.ResumeLayout(false);
            this.panelResultText.PerformLayout();
            this.panelResultControls.ResumeLayout(false);
            this.tpagePub.ResumeLayout(false);
            this.tpagePub.PerformLayout();
            this.tpageLog.ResumeLayout(false);
            this.tpageLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpageManga;
        private System.Windows.Forms.TabPage tpageChapters;
        private System.Windows.Forms.DataGridView gridGroups;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tpageOutput;
        private System.Windows.Forms.TextBox txtGenerated;
        private System.Windows.Forms.TextBox txtChapterTitle;
        private System.Windows.Forms.TextBox txtChapVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLUYear;
        private System.Windows.Forms.TextBox txtLUDay;
        private System.Windows.Forms.TextBox txtLUMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChapterAdd;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.TextBox txtChapterCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridChapters;
        private System.Windows.Forms.Button btnSaveGenerateFile;
        private System.Windows.Forms.TabPage tpagePub;
        private System.Windows.Forms.TextBox txtGithubUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGitioLink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCubariPubLink;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPubGenerate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCoverLink;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Button btnMangaSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtChapGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtChapLink;
        private System.Windows.Forms.Button btnChapGroupSave;
        private System.Windows.Forms.Button btnMangaReload;
        private System.Windows.Forms.Button btnChapGroupAdd;
        private System.Windows.Forms.Panel panelResultControls;
        private System.Windows.Forms.Panel panelResultText;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnCopyCubariLink;
        private System.Windows.Forms.TabPage tpageLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCopyOutputString;
    }
}

