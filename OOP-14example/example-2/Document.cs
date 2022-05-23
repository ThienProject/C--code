using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    internal class Document
    {
        protected int idDoc260;

        public Document(int idDoc260
            )
        {
            this.idDoc260 = idDoc260;
        }

        protected string publishingHouse260;
        protected string docNum260;

        public Document(int idDoc260, string publishingHouse260, string docNum260)
        {
            this.idDoc260 = idDoc260;
            this.publishingHouse260 = publishingHouse260;
            this.docNum260 = docNum260;
        }

    }
}
