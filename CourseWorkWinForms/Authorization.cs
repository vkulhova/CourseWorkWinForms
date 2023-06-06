using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWinForms
{

    public class Authorization
    {
        private List<User> userArr = new List<User>
            {
            new User("User1", "1111"),
            new User("User2", "1212")
            };

        public List<User> UserArr
        {
            get
            {
                return this.userArr;
            }
            set
            {
                this.userArr = value;
            }
        }
       
    }
}