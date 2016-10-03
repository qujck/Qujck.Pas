using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qujck.Pas.Model
{
    public class DatabaseProperties
    {
        private readonly AbstractEntity entity;

        internal DatabaseProperties(AbstractEntity entity)
        {
            this.entity = entity;
        }

        public string schema
        {
            get
            {
                return this.entity.schema;
            }
        }

        public string table
        {
            get
            {
                return this.entity.table;
            }
        }

        public IEnumerable<string> columns
        {
            get
            {
                return this.entity.columns;
            }
        }
    }
}
