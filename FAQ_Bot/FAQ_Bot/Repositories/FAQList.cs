using System;
using System.Collections.Generic;
using System.Text;

namespace FAQ_Bot.Repositories
{
    public class FAQList
    {
        List<string> faqList = new List<string>();

        public FAQList()
        {
            //FAQ List
            faqList.Add("``Thank you for using FAQBot! Please review this journal: https://www.deviantart.com/artspacious/journal/Feature-Requests-and-FAQ-839151383. " + Environment.NewLine +
                "Below you will find questions that have already been asked in this server. " + Environment.NewLine);
            faqList.Add("1.) Is the site ready/open yet? ``" + Environment.NewLine);
            faqList.Add("Answer: ArtSpacious is not open yet. The project was started on April 20th, 2020. We do not yet have an estimated date for when the site will be ready." + Environment.NewLine);
            faqList.Add("2.) Are there any screenshots of the site? " + Environment.NewLine);
            faqList.Add("Answer: There are currently no screenshots of the site yet. We have not yet decided on a UI or theme or anything. The main focus currently is functionality and security." + Environment.NewLine);
            faqList.Add("3.) How many themes will there be? Will the theme be easy to read? Do you have an example or mockups of the UI? " + Environment.NewLine);
            faqList.Add("Answer: As ArtSpacious is still in the early development stages, we do not have a definitive answer for this yet. We will however be ensuring that our themes and site are accesible to as many people as possible." + Environment.NewLine);

        }

        public List<string> ReturnList()
        {
           
            return faqList;
        }
    }
}
