using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAQ_Bot.Repositories
{
    public class FAQList
    {
        List<string> faqList = new List<string>();

        public FAQList()
        {
            //FAQ List
            faqList.Add("``` Please give the bot 5 seconds to load all questions after pinging the system.```");
            faqList.Add("> Please review this journal: https://www.deviantart.com/artspacious/journal/Feature-Requests-and-FAQ-839151383. " + Environment.NewLine +
                "> Below you will find questions that have already been asked in this server. " + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **1.) Is the site ready/open yet? **" + Environment.NewLine +
                "Answer: ArtSpacious is not open yet.The project was started on April 20th, 2020.We do not yet have an estimated date for when the site will be ready." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **2.) Are there any screenshots of the site? **" + Environment.NewLine +
                "Answer: There are currently no screenshots of the site yet.We have not yet decided on a UI or theme or anything.The main focus currently is functionality and security." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **3.) How many themes will there be? Will the theme be easy to read? Do you have an example or mockups of the UI? **" + Environment.NewLine +
                "Answer: As ArtSpacious is still in the early development stages, we do not have a definitive answer for this yet. We will however be ensuring that our themes and site are accesible to as many people as possible." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **4.) Will the new website still have the comment sections be the same as it was in the original DA?**" + Environment.NewLine +
                "Answer: We can't say whether they will be identical to DA's comments, but we can say that we will most certainly have comments and they will be optimized as we feel they can be for AS." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **5.) Will we be able to remove our comments section?**" + Environment.NewLine +
                "Answer: We do intend to allow members to customize their profiles fully -- including elements like comments. So yes, you, you should be able to remove your comments section on your profile if you dislike it, as well as disable comments in journals/submissions like normal!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **6.) Will there be settings to help with colourblindness?**" + Environment.NewLine +
                "Answer: Yes, ArtSpacious will be designed for the colourblind, and non-colourblind members. ArtSpacious will have a layout friendly in all aspects/colouration and layout settings for individuals with colourblindness. In fact AS's lead developer is colourblind!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **7.) Will animations, both 2D and 3D, be allowed?**" + Environment.NewLine +
                "Answer: Yes! 2D, 3D, Traditional, Graphic design, Oil paints and many other genres for artwork will be allowed and welcomed on ArtSpacious!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **8.) When it comes to the tag systems, will the tags include software tags like Photoshop, Procreate,  Krita, etc? It would help artists who use the same programs connect.**" + Environment.NewLine +
                "Answer: In terms of what tags are decided on, that will be up to Brady(Ruanly) and the site management team. We do not have an answer for this question at this time, but this is a great suggestion!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **9.) What will AS do for the spam bots?**" + Environment.NewLine +
                "Answer: In terms of spam bots, there will be a dedicated staff group who will be handling and taking tickets from Moderator Requests and Insights sent via a Mod-Box like dropbox on the site. Members will be able to report anything that violates  ArtSpacious' TOS. Reports can also include other offenses such as harassment, stalking, bullying, theft, stealing information, and spam. Email verification will be utilized to help combat spam accounts." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **10.) Will Mature, Fetish, and Gore content be allowed on ArtSpacious? Such as Literature or pure artworks?**" + Environment.NewLine +
                "Answer: In terms of Fetish and Mature content, they will and can be black-listed or white-listed via your profile settings. So if a member does not want to see a specific genre of work, they can avoid that through the use of these lists (It's also good to note that white-listing something is more effective than black-listing). Mature content additionally will not be displayed on the front page, nor will it be available unless you are logged in with a verification of 18+. We will have white-lists, black-lists and a maturity filter to help safeguard everyone (especially minors)" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **11.) Is straight up porn allowed on ArtSpacious?**" + Environment.NewLine +
                "Answer: In regards to porn (fetishes in some cases), we will be allowing Fetish posts, but they will be required to use extreme warning and tag systems on the posts AND uploads. Certain types of porn will not be allowed on ArtSpacious ever, especially those that violate U.S. Laws such as child pornography. There is a zero tolerance policy for child pornography and will absolutely not be tolerated in any way shape or form on AS." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **12.) Will file extensions change from PSD to JPEG?**" + Environment.NewLine +
                "Answer: We do not have the specifics on what file types we will allow/disallow but file extentions will not change. If you upload a .PNG file it will remain a .PNG file and so on." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **13.) Will there be some type of activity feed where you can view what watched artists added to their collections/favourites? Its a great way to discover new artists to follow.**" + Environment.NewLine +
                "Answer: There are plans for an activity feed to keep track of what's going on within the groups you are a member of, as well as those you follow. We do not have specific details on this particular feature yet, but the goal is to make it as quick and easy as possible for you to catch up where you've left off whether you've been gone for a few hours or an entire week." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **14.) Will there be purchasable ad space on AS?**" + Environment.NewLine +
                "Answer: We have not fully discussed partnerships/ads nor have we fully decided how the front page will work in terms of what is displayed." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **15.) Will AS have its own currency? What will it be called?**" + Environment.NewLine +
                "Answer: We do have a currency in mind to be used on ArtSpacious, and at this time we are still going over what the currency will be called and other functions for the currency on site. You will be able to use it for various actions across our plat form however!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **16.) Would we have the option to choose to display our sexual orientation, and pronouns on our profiles?**" + Environment.NewLine +
                "Answer: Our developer is going to create areas for gender pronouns, and our profiles will be customizable so you can add that information to your pages if that is something you would like to display!" + Environment.NewLine + Environment.NewLine);

        }

        public List<string> ReturnList()
        {
            return faqList;
        }
    }
}
