using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCorea.ViewComponents
{
    public class PriorityListViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke(
        int maxPriority, bool isDone)
        {
            
            return View( );
        }
      
    }

}
