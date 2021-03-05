using dikom.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikom
{
    public class Context
    {
        private static dicomEntities context;
        
        private Context() { }

        public static dicomEntities DBContext
        {
            get
            {
                if (context == null)
                    context = new dicomEntities();

                return context;
            }
        }
         ~Context()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }
        
    }
}
