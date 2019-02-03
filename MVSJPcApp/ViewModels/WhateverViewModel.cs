using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.UserDataTasks;
using Windows.UI.Xaml.Data;
using MVSJPcApp.Annotations;


namespace MVSJPcApp.ViewModels
{
    class WhateverViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<User> UserList { get; set; }
        public static ObservableCollection<User> AtilÅUserList { get; set; }

        public WhateverViewModel()
        {

            UserList = new ObservableCollection<User>();
            UserList.Add(new User("Køge", "Beredskab", "adolf", "wrx55555"));
            UserList.Add(new User("Køge", "Beredskab", "Dame", "Wrx12345"));
            UserList.Add(new User("Køge", "Beredskab", "Egon", "Wrx12341"));
            UserList.Add(new User("Køge", "Beredskab", "Bodil", "Wrx12342"));
            UserList.Add(new User("Køge", "Beredskab", "Cecil", "Wrx12343"));
            UserList.Add(new User("Køge", "Beredskab", "Filip", "Wrx12344"));

            //Brug Ny frame med CollectionViewSource med sortering efter bogstaver. Lav ny Frame for hver sortering. 
           
            AtilÅUserList = new ObservableCollection<User>(UserList.OrderBy(x => x.Navn).ToList());
        }

      
       






        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;
       
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
