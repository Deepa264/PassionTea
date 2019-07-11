using PassionTea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Pages.Executors
{
    class WelcomePageExecutor : WelcomePageLocator
    {
        public void ClickOnHerbalTeaCollectionButton()
        {
            SeaColletionHerbalTeaButton.ClickWithWait();
        }
        public void ClickOnLooseTeaCollectionButton()
        {
            SeaColletionLooseteaColletionButton.ClickWithWait();
        }

        public void ClickOnFlavoredTeaCollectionButton()
        {
            SeaColletionFlavouredTeaCollectionButton.ClickWithWait();
        }

    }
}
