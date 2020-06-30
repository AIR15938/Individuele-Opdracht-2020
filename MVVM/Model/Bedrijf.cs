using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Bedrijf : Persoon
    {
        #region Fields
        private string openingsuren;
        private string sluitingsdagen;
        #endregion

        #region Properties
        public string Openingsuren
        {
            get { return openingsuren; }
            set { openingsuren = value; }
        }

        public string Sluitingsdagen
        {
            get { return sluitingsdagen; }
            set { sluitingsdagen = value; }
        }
        #endregion

    }
}
