using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace SMAP.Models
{
    public class MapActivityItem : BindableBase
    {
        public MapActivityItem()
        {
        }
    }
}



/*
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Favors.Model
{
    public class ListingModel : BindableBase
    {
        public Guid ListingId { get; set; }
        string _title;
        string _description;
        string _experienceLevel;
        bool _timeFlexibility;
        bool _locationFlexibility;
        bool _listOnUserApp;
        StatusEnum _status;
        bool _bookmarked;
        ICommand bookmarkCommand;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public string ExperienceLevel
        {
            get { return _experienceLevel; }
            set { SetProperty(ref _experienceLevel, value); }
        }

        public bool TimeFlexibility
        {
            get { return _timeFlexibility; }
            set { SetProperty(ref _timeFlexibility, value); }
        }

        public bool LocationFlexibility
        {
            get { return _locationFlexibility; }
            set { SetProperty(ref _locationFlexibility, value); }
        }

        public bool ListOnUserApp
        {
            get { return _listOnUserApp; }
            set { SetProperty(ref _listOnUserApp, value); }
        }

        public StatusEnum Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }
      
        public Guid FavorCatId { get; set; }
        public string CategoryCode { get; set; }

        public UserModel Earner { get; set; }

        public bool Bookmarked
        {
            get { return _bookmarked; }
            set { SetProperty(ref _bookmarked, value); }
        }

        public Func<ListingModel, Task> BookmarkAction { get; set; }
        public ICommand BookmarkCommand
        {
            get { return bookmarkCommand ?? (bookmarkCommand = new DelegateCommand(async () => await BookmarkAction(this))); }

        }
    }
}
*/