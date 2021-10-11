using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace CubariHelper
{
    public partial class Form1 : Form
    {
        public string linkProxyImgur = "/proxy/api/imgur/chapter/";
        public string lnkCubariGist = "https://guya.moe/proxy/gist/";
        public string linkGitio = "https://git.io/";
        public string outputFile = "";
        public string outputString = "";
        public Entity manga = null;
        public BindingList<KeyValuePair<string, ChapterDetails>> bindChapters = null;
        public BindingList<KeyValuePair<string, string>> bindGroups = null;
        public ChapterDetails selectedChapter = null;
        public Form1()
        {
            InitializeComponent();
        }
        #region Static methods
        public static void Alert(string msg)
        {
            MessageBox.Show(msg);
        }
        public static bool AlertYesNo(string msg)
        {
            DialogResult dialogResult = MessageBox.Show(msg, "Confirmation alert", MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }
        public static void SetupGridView<T>(DataGridView grid, BindingList<T> bindingList)
        {
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AllowUserToResizeRows = false;
            grid.DataSource = bindingList;
        }
        public static async Task<string> GenerateGitio(string link)
        {
            return await Task.Run( async() =>
            {
                try
                {
                    string content = "";
                    var client = new HttpClient();
                    var requestContent = new FormUrlEncodedContent(new[] {
                        new KeyValuePair<string, string>("url", link),
                    });
                    HttpResponseMessage response = await client.PostAsync(
                        "https://git.io/create",
                        requestContent);
                    HttpContent responseContent = response.Content;

                    content = await responseContent.ReadAsStringAsync();
                    return content;
                    //// Get the stream of the content.
                    //using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                    //{
                    //    // Write the output.
                    //    content = await reader.ReadToEndAsync();
                    //    return content;
                    //}
                }
                catch { throw; }
            });
        }
        #endregion

        #region Methods
        public void Log(string log)
        {
            txtLog.AppendText($"[{DateTime.Now.ToString("HH:mm:ss,fff")}]: {log}{Environment.NewLine}");
        }
        public void LogErr(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Log(ex.ToString());
        }
        public void SaveMangaToFile()
        {
            GenerateChapterList(); // Generate Chapters list
            outputString = JsonConvert.SerializeObject(manga, Formatting.Indented);
            using (var stream = new StreamWriter(outputFile))
            {
                stream.Write(outputString);
                stream.Close();
            }
        }
        public void LoadMangaDetailsFile()
        {
            // Clear prev entries
            bindChapters.Clear();
            bindGroups.Clear();
            // Load previous file 'details.json'
            outputFile = Path.Combine(Application.StartupPath, "details.json");
            Log($"Loading Manga details from file => {outputFile}");
            try
            {
                if (File.Exists(outputFile))
                {
                    string contents = File.ReadAllText(outputFile);
                    manga = JsonConvert.DeserializeObject<Entity>(contents);
                    if (manga.chapters != null)
                    {
                        foreach (var item in manga.chapters)
                        {
                            bindChapters.Add(item);
                        }
                    }
                    txtTitle.Text = manga.title;
                    txtArtist.Text = manga.artist;
                    txtAuthor.Text = manga.author;
                    txtCoverLink.Text = manga.cover;
                    txtSummary.Text = manga.description;
                }
            }
            catch (Exception ex) { LogErr(ex); }
            if (manga == null)
            {
                manga = new Entity();
                manga.title = "";
                manga.description = "";
                manga.artist = "";
                manga.author = "";
                manga.cover = "";
                manga.chapters = new Dictionary<string, ChapterDetails>();
            }
            // Clear UI
            ClearChapterInfo();
            txtGenerated.Text = "";
            try
            {
                var firstChapter = manga.chapters.First();
                LoadChapter(firstChapter.Key, firstChapter.Value);
            }
            catch (Exception ex) { LogErr(ex); }
        }
        public void LoadChapter(string chapterCount, ChapterDetails item)
        {
            try
            {
                if (item != null)
                {
                    selectedChapter = item; // set selected manga
                    txtChapterCount.Text = chapterCount;
                    txtChapterTitle.Text = item.title;
                    txtChapVol.Text = item.volume;
                    try
                    {
                        long.TryParse(item.last_updated, out long secondsLong);
                        var date = ConvertFromUnixTimestamp(secondsLong);
                        txtLUMonth.Text = date.Month.ToString();
                        txtLUDay.Text = date.Day.ToString();
                        txtLUYear.Text = date.Year.ToString();
                    }
                    catch (Exception ex) { LogErr(ex); }
                    LoadGroups(item.groups);
                }
            }
            catch (Exception ex) { LogErr(ex); }
        }
        public void LoadGroups(Dictionary<string, string> data)
        {
            bindGroups.Clear();
            foreach (var entry in data)
            {
                bindGroups.Add(entry);
            }
            if (data.Count > 0)
            {
                LoadSingleGroup(data.First());
            }
        }
        public void LoadSingleGroup(KeyValuePair<string, string> item)
        {
            if (item.Key != null)
            {
                txtChapGroup.Text = item.Key;
                txtChapLink.Text = item.Value;
            }
        }
        public void ResetChapterLink()
        {
            txtChapLink.Text = linkProxyImgur; // Reset link
        }
        public void ClearChapterInfo()
        {
            ResetChapterLink();
            txtChapterTitle.Text = "";
            txtChapterCount.Text = "";
            txtChapVol.Text = "";
            txtChapGroup.Text = "";
            txtLUYear.Text = DateTime.Now.Year.ToString();
            txtLUMonth.Text = DateTime.Now.Month.ToString();
            txtLUDay.Text = DateTime.Now.Day.ToString();
            bindGroups.Clear();
        }
        public void GenerateChapterList()
        {
            manga.chapters.Clear(); // clear previous
            foreach (var item in bindChapters)
            {
                manga.chapters.Add(item.Key, item.Value);
            }
        }
        #endregion

        // Designer Events
        private void Form1_Load(object sender, EventArgs e)
        {
            bindChapters = new BindingList<KeyValuePair<string, ChapterDetails>>();
            SetupGridView(gridChapters, bindChapters);

            gridChapters.Columns["Value"].Visible = false;
            gridChapters.Columns["Key"].HeaderText = "Chapter";
            gridChapters.Columns["Key"].FillWeight = 40F;
            
            gridChapters.Columns.Add("title", "Title");
            gridChapters.Columns["title"].DataPropertyName = "Value.title";
            gridChapters.Columns["title"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            bindGroups = new BindingList<KeyValuePair<string, string>>();
            SetupGridView(gridGroups, bindGroups);
            gridGroups.Columns["Key"].HeaderText = "Group Name";
            gridGroups.Columns["Key"].FillWeight = 50F;
            gridGroups.Columns["Value"].HeaderText = "Link";

            LoadMangaDetailsFile();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            gridChapters.Width = (tpageChapters.ClientRectangle.Right - gridChapters.Left) - 8;
            gridChapters.Height = (tpageChapters.ClientRectangle.Bottom - gridChapters.Top) - 8;

            gridGroups.Height = (tpageChapters.ClientRectangle.Bottom - gridGroups.Top) - 8;
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            // Generate Chapters list
            GenerateChapterList();
            outputString = JsonConvert.SerializeObject(manga, Formatting.Indented);
            txtGenerated.Text = outputString;
        }

        private void btnChapterAdd_Click(object sender, EventArgs e)
        {
            string chapterCount = txtChapterCount.Text;
            if (manga.chapters.ContainsKey(chapterCount))
            {
                if (AlertYesNo("Chapter already exists!\nReplace chapter?") == false)
                {
                    txtChapterCount.Focus();
                    txtChapterCount.SelectAll();
                    return;
                }
                else
                {
                    manga.chapters.Remove(chapterCount);
                    bindChapters.Remove(bindChapters.First(item => item.Key.Equals(chapterCount)));
                }
            }
            var chapter = new ChapterDetails();
            chapter.title = txtChapterTitle.Text;
            chapter.volume = txtChapVol.Text;
            DateTime date = DateTime.Now;
            try
            {
                date = DateTime.ParseExact($"{txtLUMonth.Text.PadLeft(2, '0')}-{txtLUDay.Text.PadLeft(2, '0')}-{txtLUYear.Text}", "MM-dd-yyyy", null);
            }
            catch (Exception ex) { LogErr(ex); Alert("Invalid date!"); } 
            // NOTE: Somehow, converting from DateTime loses 1 day, so add that lost.
            chapter.last_updated = ConvertToUnixTimestamp(date.AddDays(1)).ToString();

            // Set group releases
            chapter.groups = new Dictionary<string, string>();
            foreach (var grp in bindGroups)
            {
                chapter.groups.Add(grp.Key, grp.Value);
            }
            manga.chapters.Add(chapterCount, chapter);
            bindChapters.Add(new KeyValuePair<string, ChapterDetails>(chapterCount, chapter));
            // Clear prev entry
            selectedChapter = null;
            ClearChapterInfo();
        }

        private void gridChapters_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = gridChapters.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Contains("."))
            {
                object data = gridChapters.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i]).GetValue(data);
                gridChapters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
            }
        }

        private void btnSaveGenerateFile_Click(object sender, EventArgs e)
        {
            // TODO: Put into global method
            using (var stream = new StreamWriter(outputFile))
            {
                stream.Write(outputString);
                stream.Close();
            }
        }

        private void gridChapters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                string key = gridChapters.Rows[index].Cells["Key"].Value.ToString();
                var item = manga.chapters.Where(x => x.Key.Equals(key)).FirstOrDefault();
                LoadChapter(item.Key, item.Value);
            }
            catch (Exception ex) { LogErr(ex); }
        }

        private void btnMangaReload_Click(object sender, EventArgs e)
        {
            LoadMangaDetailsFile();
        }

        private void gridGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                string key = gridGroups.Rows[index].Cells["Key"].Value.ToString();
                var item = bindGroups.Where(x => x.Key.Equals(key)).FirstOrDefault();
                LoadSingleGroup(item);
            }
            catch (Exception ex) { LogErr(ex); }
        }

        private void btnChapGroupSave_Click(object sender, EventArgs e)
        {
            if (selectedChapter == null)
            {
                Alert("No chapter selected!");
                return;
            }
            // clear previous groups
            selectedChapter.groups.Clear();
            foreach (var item in bindGroups)
            {
                selectedChapter.groups.Add(item.Key, item.Value);
            }
        }

        private void btnChapGroupAdd_Click(object sender, EventArgs e)
        {
            if (selectedChapter == null)
            {
                Alert("No chapter selected!");
                return;
            }
            string groupName = txtChapGroup.Text;
            string link = txtChapLink.Text;
            if (String.IsNullOrWhiteSpace(groupName))
            {
                Alert("Empty Group Name!");
                return;
            }
            if (String.IsNullOrWhiteSpace(link) || link.Trim().Equals(linkProxyImgur))
            {
                Alert("No link to chapter!");
                return;
            }

            if (bindGroups.All(x => x.Key.Equals(groupName)))
            {
                if (AlertYesNo("Group release already exists!\nReplace group release?") == false)
                {
                    txtChapGroup.Focus();
                    txtChapGroup.SelectAll();
                    return;
                }
                else
                {
                    selectedChapter.groups.Remove(groupName);
                    bindGroups.Remove(bindGroups.First(item => item.Key.Equals(groupName)));
                }
            }
            link = link.Trim();
            if (!link.EndsWith('/'))
                link += "/";

            bindGroups.Add(new KeyValuePair<string, string>(groupName, link));
            selectedChapter.groups.Add(groupName, link);
        }

        private void gridChapters_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            selectedChapter = null;
            ClearChapterInfo();
        }

        private async void btnDownloadFile_Click(object sender, EventArgs e)
        {
            string link = txtGithubUrl.Text;
            Log($"Downloading file.. => {link}");
            await Task.Run(() =>
            {
                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }
                using (var client = new WebClient())
                {
                    client.DownloadFile(link, outputFile);
                }
                Alert("Download complete!");
            });
            LoadMangaDetailsFile();
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(outputFile))
                {
                    return;
                }
                string argument = "/select, \"" + outputFile + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
            catch (Exception ex) { LogErr(ex); }
        }

        private void btnCopyCubariLink_Click(object sender, EventArgs e)
        {
            string link = txtCubariPubLink.Text.Trim();
            if (!String.IsNullOrWhiteSpace(link))
            {
                Clipboard.SetText(link);
            }
        }

        private async void btnPubGenerate_Click(object sender, EventArgs e)
        {
            string rawLink = txtGithubUrl.Text;
            string result = "";
            if (!String.IsNullOrWhiteSpace(rawLink))
            {
                try
                {
                    result = await GenerateGitio(rawLink);
                    Log($"Result: {result}");
                    txtGitioLink.Text = $"{linkGitio}{result.Trim()}";
                    txtCubariPubLink.Text = $"{lnkCubariGist}{result.Trim()}";
                    Alert("Generated Link!");
                    return;
                }
                catch (Exception ex) { LogErr(ex); }
                Alert("Error occured!");
                return;
            }
            Alert("Empty link!");
            txtGithubUrl.Focus();
            txtGithubUrl.SelectAll();
        }

        private void btnCopyOutputString_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(outputString))
            {
                Clipboard.SetText(outputString);
                Alert("Output copied!\nPaste it to your Github repo file.");
            }
        }

        private void btnMangaSave_Click(object sender, EventArgs e)
        {
            manga.title = txtTitle.Text;
            manga.description = txtSummary.Text;
            manga.author = txtAuthor.Text;
            manga.artist = txtArtist.Text;
            manga.cover = txtCoverLink.Text;
            SaveMangaToFile();
            Alert("Manga info saved!");
        }
    }
}
