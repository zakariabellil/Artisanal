using Artisanal.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisanal.UTILEMETIER
{
    static class Utile
    {
        public static void CreateTable()
        {
            var initializer = new CreateDatabaseIfNotExists<ContextEf>();
            initializer.InitializeDatabase(new ContextEf());
        }

        public static void InitTable()
        {
            var initializer = new InitDonneeArtisanal();
            initializer.InitializeDatabase(new ContextEf());

        }

    }
}
