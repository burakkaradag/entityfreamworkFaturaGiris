using faturaProje.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faturaProje.REP
{
   public static  class DBsingleTone
    {
       public static FaturaContext db;
       public static  FaturaContext GetInstance()
        {
            if (db==null)
            {
                db = new FaturaContext();
            }
            return db;
        }
        
    }
}
