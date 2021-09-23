using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_List
{
    public delegate void ChooseEventHandler(object source, ChooseEventArgs e);

    public class ChooseEventArgs : EventArgs
    {
        private string _cell0;
        private string _cell1;

        public ChooseEventArgs(string cell0, string cell1) 
        {
            _cell0 = cell0;
            _cell1 = cell1;
        }

        public string Cell0Value
        {
            get { return _cell0; }
        }

        public string Cell1Value
        {
            get { return _cell1; }
        }
    }
}
