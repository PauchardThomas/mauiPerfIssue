using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatTemplatePerfIssue
{
    public class Row
    {
        public Row(string title, string description, ObservableCollection<Col> cols)
        {
            Title = title;
            Description = description;
            Cols = cols;
        }
        private string _Title;

        private string _Description;

        private ObservableCollection<Col> _Cols;

        public ObservableCollection<Col> Cols
        {
            get { return _Cols; }
            set { _Cols = value; }
        }


        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

    }
}
