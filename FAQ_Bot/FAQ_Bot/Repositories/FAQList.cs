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
            faqList.Add("> Please review this journal: https://www.deviantart.com/artspacious/journal/Feature-Requests-and-FAQ-839151383. " + Environment.NewLine +
                "Below you will find questions that have already been asked in this server. " + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **1.) Is the site ready/open yet? **" + Environment.NewLine +
                "Answer: ArtSpacious is not open yet.The project was started on April 20th, 2020.We do not yet have an estimated date for when the site will be ready." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **2.) Are there any screenshots of the site? **" + Environment.NewLine +
                "Answer: There are currently no screenshots of the site yet.We have not yet decided on a UI or theme or anything.The main focus currently is functionality and security." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **3.) How many themes will there be? Will the theme be easy to read? Do you have an example or mockups of the UI? **" + Environment.NewLine +
                "Answer: As ArtSpacious is still in the early development stages, we do not have a definitive answer for this yet. We will however be ensuring that our themes and site are accesible to as many people as possible." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **4.) Will the new website still have the comment sections be the same as it was in the original DA?**" + Environment.NewLine +
                "Answer: We can't say whether they will be identical to DA's comments, but we can say that we will most certainly have comments and they will be optimized as we feel they can be for AS." + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **5.) Will we beable to remove our comments section?**" + Environment.NewLine +
                "Answer: We do intend to allow members to customize their profiles fully -- including elements like comments. So yes, you, you should be able to remove your comments section on your profile if you dislike it, as well as disable comments in journals/submissions like normal!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **6.) Will there be settings to help with colourblindness?**" + Environment.NewLine +
                "Answer: Yes, ArtSpacious will be designed for the colourblind, and non-colourblind members. ArtSpacious will have a layout friendly in all aspects/colouration and layout settings for individuals with colourblindness. In fact AS's lead developer is colourblind!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **7.) Will animations, both 2D and 3D, be allowed?**" + Environment.NewLine +
                "Answer: Yes! 2D, 3D, Traditional, Graphic design, Oil paints and many other genres for artwork will be allowed and welcomed on ArtSpacious!" + Environment.NewLine + Environment.NewLine);
            faqList.Add("> **8.) When it comes to the tag systems, will the tags include software tags like Photoshop, Procreate,  Krita, etc? It would help artists who use the same programs connect.**" + Environment.NewLine +
                "Answer: In terms of what tags are decided on, that will be up to Brady(Ruanly) and the site management team. We do not have an answer for this question at this time, but this is a great suggestion!" + Environment.NewLine + Environment.NewLine);

        }

        public List<string> ReturnList()
        {
            return faqList;
        }
    }
}
