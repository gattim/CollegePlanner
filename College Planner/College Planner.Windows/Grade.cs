using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner {

    public class Grade {

        public string type { get; }
        public double percent { get; }

        public Grade(string type, double precent) {
            this.type = type;
            this.percent = percent;
        }

    }
}
