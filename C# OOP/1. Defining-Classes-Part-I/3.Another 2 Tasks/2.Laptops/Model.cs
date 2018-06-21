using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptops
{
   public class Model
    {
        private string modelName;
        private string series;

        public Model() { }

        public Model(string modelName)
        {
            this.ModelName = modelName;
        }

        public Model(string modelName, string series)
        {
            this.ModelName = modelName;
            this.Series = series;
        }

        public string ModelName
        {
            get { return this.modelName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Model name is mandatory!");
                }
                this.modelName = value;
            }
        }

        public string Series
        {
            get { return this.series; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Series name is mandatory!");
                }
                this.series = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.modelName, this.series);
        }

    }
}
