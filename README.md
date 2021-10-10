# CubariHelper - Simplify Cubari gist creation with the power of GUI!

# Pre-requisite

* Download app from [latest release](https://github.com/Jacekun/CubariHelper/releases/latest).
* Github Account and a repository containing your manga.
* Time and Patience.

# Github account and repo creation

1. Go to https://github.com/join and fill up required info.
2. Log-in to your new account and click on your **Profile**.
3. Click on **Repositories** tab, then click on **New** button.
4. Name your repository something like **"CubariManga"**, *or whatever you prefer*.
    * Note: Leave everything else as it is.
5. Click on **Create repository** at the bottom of the page.
6. Click on the text saying **"Get started by creating a new file"**.
7. Name the file something like **"manga_name/details.json"**, *or whatever you prefer*.
    * Note: Remember the name as it will be required later.
8. Put anything on the commit messsage located at the bottom of the page.
    * Something like **"Added new manga"**.
9. Click on **Commit new file**  button.
10. You're done! Now remember this repo and the first file you committed.

# How to Use

First, open the App. It is named **"CubariHelper.exe"**.

# Creating new manga Cubari gist
1. Fill up the information on **Manga Details** tab.
2. Go to **Chapters** tab and fill up information using this guide:
    * **Chapter Count** = Chapter number. (Eg: 1, 2, 2.5, etc.)
    * **Chapter Title** = Title of the chapter. Same for every group release.
    * **Volume** = Volume number where the chapter belongs. Or *empty* if no Volume.
3. Add *chapter release* by following this guide:
    * **Group name** = Scanlator name. Or you can input **"No group"**.
    * **Chapter Link** = It automatically fills the required URL. You only need to input the Imgur Id at the end of it.
      * The Imgur Id is located at the end of the ImgurLink, after the last **/** from the url.
4. Click **"Add Group"** after you're sure of the details.
    * Note: You can add multiple scanlator releases for the same chapter number. Repeat from step **3**.
    * Note: You can edit previously created group release by double-clicking on its entry on the table below the **"Add Group"** button.
      * It will prompt you if there's an existing group, and if you want to replace that.
5. Click on **"Save groups"** to make the changes.
6. After adding group releases, click **"Add Chapter"** to Add the chapter to the Manga gist.
    * Note: You can add multiple chapters for a single gist. Repeat from step **2**.
    * Note: You can edit previously created chapters by double-clicking on its entry on the table on the right-most side.
      * It will prompt you if there's an existing chapter with the same chapter number, and if you want to replace that.
7. You can see how your file will look by going to **Result** tab and clicking **"Preview"**.
8. When you're entirely sure of the details, click **"Save"** to write the result to a file.
9. Go back to Github and locate the file you committed earlier at Step **7** of **"Github account and repo creation"**.
10. Click on it, and click on the **Pencil** icon.
11. Go back to the App and under **Publish** tab, click on **"Copy Output"** button.
12. Go back to Github and paste the contents there.
13. On the bottom page, input any commit message. Something like **"first commit"**.
14. Click on **"Commit changes"** button.
15. Click on **"Raw"** button, located at the Top-Right corner (left side of the **Pencil** icon).
16. Copy the URL on your browser. Its typically located at the upper part of your browser.
17. Go back to the App, and paste the url under **"Raw URL from Github"** textbox.
18. Click on **"Generate Cubari Gist"** button, and wait for it to finish.
    * Note: It might take a couple seconds, depending on your internet speed.
19. There should be links created below the button. Click on **"Copy Cubari Link"** button.
20. You're done! You can share the link to Reddit or anywhere else you like.
    * Note: You cannot rename or moved the file created. Otherwise, the link will point to non-existing gist.
    * Note: However, you can edit its contents. For more info, see below.

# Updating existing gist
1. Go to your github repo and locate the file you want to add chapters to.
2. Click on **"Raw"** button, located at the Top-Right corner (left side of the **Pencil** icon).
3. Copy the URL on your browser. Its typically located at the upper part of your browser.
4. Go to the App, and click on **Publish** tab.
5. Paste the url under **"Raw URL from Github"** textbox.
6. Click on **"Download File"** button, and wait for it to finish fetching the file.
7. Follow the same procedure detailed in **"Creating new manga Cubari gist"**, and stop after doing Step **7**.
8. Go to **Publish** tab, and click on **"Copy Output"** button.
9. Go to your github repo again, and locate the file the same as in Step **1**.
10. Click on it, and click on the **Pencil** icon.
11. Remove all previous contents, and paste your new contents.
12. On the bottom page, input any commit message. Something like **"add new chapter"**.
13. Click on **"Commit changes"** button.
14. You're done! You can now refresh your Cubari gist link and see the changes.
    * Note: Sometimes, it'll take a couple minutes before the changes reflect.