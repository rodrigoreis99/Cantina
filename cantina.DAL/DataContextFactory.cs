using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina.DAL
{
    public class DataContextFactory
    {
        private static cantinaDataContext dataContext; //cria um objeto do tipo cantinaDataContext
            public static cantinaDataContext DataContext{
                get
                {
                if (dataContext == null)
                    dataContext = new cantinaDataContext();
                return dataContext;
                }
            }             
    }
}
