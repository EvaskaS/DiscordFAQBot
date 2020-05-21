using System;
using System.Collections.Generic;
using System.Text;

namespace FAQ_Bot.Repositories
{
    public class FAQList
    {
        List<String> faqList = new List<String>();

        public List<String> GenerateList()
        {
            //FAQ List
            faqList.Add("Thank you for using FAQBot! Please review this journal: https://www.deviantart.com/artspacious/journal/Feature-Requests-and-FAQ-839151383. " +
                "Below you will find questions that have already been asked in this server. ");
            faqList.Add("1.) Is the site ready/open yet? ");
            faqList.Add("Answer: ArtSpacious is not open yet. The project was started on April 20th, 2020. We do not yet have an estimated date for when the site will be ready.");
            faqList.Add("2.) Are there any screenshots of the site? ");
            faqList.Add("Answer: There are currently no screenshots of the site yet. We have not yet decided on a UI or theme or anything. The main focus currently is functionality and security.");
            faqList.Add("3.) How many themes will there be? Will the theme be easy to read? Do you have an example or mockups of the UI? ");
            faqList.Add("Answer: As ArtSpacious is still in the early development stages, we do not have a definitive answer for this yet. We will however be ensuring that our themes and site are accesible to as many people as possible.");

            return faqList;
        }
    }
}
