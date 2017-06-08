using System;
using LuisManager.Domain.Enums;

namespace LuisManager.Domain
{
    public class Product
    {
        public string Id { get; set; }
        public string Engineer { get; set; }
        public string Name { get; set; }
        public string RawMaterial { get; set; }
        public DevelopmentStatus Status { get; set; }
        public DateTime DevelopmentStartDate { get; set; }
        public DateTime ExpectedCompletionDate { get; set; }
        public string SupplyManagementContact { get; set; }
        public string Notes { get; set; }
        public string ImageSource { get; set; }
    }
}
