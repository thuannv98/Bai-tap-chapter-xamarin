using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    class Global
    {
        private static Global _instance;
        public String myData { get; set; }

        private Global()
        {
        }

        public static Global Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }

    }
}
