using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatTemplatePerfIssue
{
    public class Col
    {

        public Col(string title)
        {
            Title = title;
        }
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

    }
}
