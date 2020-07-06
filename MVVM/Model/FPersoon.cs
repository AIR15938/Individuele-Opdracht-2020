using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class FPersoon : Persoon
    {
        #region fields
        private string profielfoto;
        #endregion

        #region properties
        public string Profielfoto
        {
            get { return profielfoto; }
            set { profielfoto = value; }
        }

        #endregion

    }
}

    
