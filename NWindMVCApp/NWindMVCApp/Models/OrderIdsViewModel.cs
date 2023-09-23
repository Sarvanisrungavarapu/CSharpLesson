using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindMVCApp.Models
{
    public class OrderIdsViewModel
    {
        public int Id{get; set;}
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIdsViewModel(List<int> OrderIds)
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (var no in OrderIds)
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}