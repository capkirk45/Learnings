using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings
{
    public delegate void NameChangedDelegate(string oldvalue, string newvalue);


    public static class DelegateConsumer
    {
        public static void ChangeNameInGradeBook()
        {
            var gb = new GradeBook();
            gb.Name = "Kirk";

            gb.NameChanged += OnNameChanged;
            gb.NameChanged += OnNameChanged2;
            //gb.NameChanged = new NameChangedDelegate(OnNameChanged);


            gb.Name = "Miller";
        }

        private static void OnNameChanged(string oldvalue, string newvalue)
        {
            Console.WriteLine(string.Format("Old Name: {0}, New Name: {1}", oldvalue, newvalue));
        }

        private static void OnNameChanged2(string oldvalue, string newvalue)
        {
            Console.WriteLine(string.Format("Something different: {0}, New something different: {1}", oldvalue, newvalue));
        }

    }

    public class GradeBook
    {

        public GradeBook() { }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name != value)
                {
                    var oldName = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(oldName, value);
                    }
                }
            }
        }
        public NameChangedDelegate NameChanged;

    }
}
