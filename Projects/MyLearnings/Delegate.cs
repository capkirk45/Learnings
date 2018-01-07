using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings
{
    public delegate void NameChangedDelegate(Object sender, NameChangedEventArgs args);


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

        private static void OnNameChanged(Object sender, NameChangedEventArgs args)
        {
            Console.WriteLine(string.Format("Old Name: {0}, New Name: {1}", args.OldValue, args.NewValue));
        }

        private static void OnNameChanged2(Object sender, NameChangedEventArgs args)
        {
            Console.WriteLine(string.Format("Something different: {0}, New something different: {1}", args.OldValue, args.NewValue));
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
                        var args = new NameChangedEventArgs();
                        args.OldValue = _name;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }
                }
            }
        }
        public event NameChangedDelegate NameChanged;

    }

    public class NameChangedEventArgs : EventArgs
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }

}
