using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoTDD
{
    public class DisplayMock : IDisplay
    {

        private string lastDisplayed = ""; 

        public string LastDisplayed
        {
            get { return lastDisplayed; }
        }

        public void display(string toDisplay)
        {
            lastDisplayed = toDisplay;
        }
    }
}
