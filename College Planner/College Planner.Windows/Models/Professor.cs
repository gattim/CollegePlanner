using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Planner.Models {
    public class Professor {
        [SQLite.PrimaryKey]
        public int Id { get; set; }
        public string name { get; set; }
        public string officeBuilding { get; set; }
        public string officeRoom { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Professor(string name, string officeBuilding, string officeRoom, string phone, string email) {
            this.name = name;
            this.officeBuilding = officeBuilding;
            this.officeRoom = officeRoom;
            this.phone = phone;
            this.email = email;
        }

        public override string ToString() {
            return name;
        }

    }
}
