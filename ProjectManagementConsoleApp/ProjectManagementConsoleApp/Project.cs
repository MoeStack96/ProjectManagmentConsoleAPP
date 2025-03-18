using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementConsoleApp
{
    internal class Project
    {
        public Guid ID { get; set; } // Projektnummer(Genereras automatiskt)

        public string Name { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Status { get; set; } = null!;

        public string Service { get; set; } = null!;

        public double Price { get; set; }

    }
}
