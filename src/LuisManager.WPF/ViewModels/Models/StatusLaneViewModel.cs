using System.Collections.Generic;
using Caliburn.Micro;
using LuisManager.Domain.Enums;

namespace LuisManager.WPF.ViewModels.Models
{
    public class StatusLaneViewModel : Screen
    {
        public DevelopmentStatus Status { get; set; }

        public IEnumerable<ItemViewModel> Items { get; set; }

        public int CascadeLevel { get; set; }        
    }
}