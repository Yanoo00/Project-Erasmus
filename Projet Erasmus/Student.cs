using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Erasmus
{
    public class Student
    {
        #region private attributs
        private string name;
        private Boolean isCapt;
        private List<int> listOfChoices = null;
        #endregion private attributs

        #region constructor

        public Student(string name, Boolean isCapt, List<int> listOfChoices)
        {
            this.name = name;
            this.isCapt = isCapt;
            this.listOfChoices = listOfChoices;
        }
        #endregion constructor

        #region punlic accessors and mutators (get/set)

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public Boolean IsCapt
        {
            get
            {
                return this.isCapt;
            }
        }

        public List<int> ListOfChoices
        {
            get
            {
                return this.listOfChoices;
            }
        }

        #endregion punlic accessors and mutators (get/set)
    }
}
