using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFCRUD
{
    public class Person : INotifyPropertyChanged // !!!!
    {
        public int Id { get; set; }
		private string name;

		public string Name
		{
			get { return name; }  // propfull tab tab
			set {
                name = value;
                OnPropertyChanged();
            }
		}
		

		private int age;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Age
		{
			get { return age; }
			set {
                age = value;
                OnPropertyChanged();
            }
		}

        public Person()
        {
            Id = 0;
        }

        public Person(string name, int age)
        {
            Id = 0;
            Name = name;
            Age = age;
        }

        public override string? ToString()
        {
            return $"{name} - {age} ({Id})";
        }
        private void OnPropertyChanged([CallerMemberName]string name = null) 
        {
            if (name != null && PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name)); // ? --> megnézi hogy 0-e
        }
    }
}
