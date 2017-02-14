using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0210Controller : Controller
    {
        // GET: MVC0210
        public ActionResult Index()
        {
            return View();
        }
        public async Task<bool> LaunchTasks(List<int> waitTimes)
        {
            bool result = false;
            List<Task> tasks = new List<Task>();
            try
            {
                foreach (int wait in waitTimes)
                {
                    var task1 = FirstWait(wait);
                    tasks.Add(task1);
                    var task2 = SecondWait(wait);
                    tasks.Add(task2);
                }
                Debug.WriteLine("About to await on {0} Tasks", tasks.Count);
                await Task.WhenAll(tasks);
                Debug.WriteLine("After WhenAll");
            }
            catch (Exception ex)
            {
            }

            return result;
        }
        private async Task<bool> FirstWait(int waitTime)
        {
            var task = Task.Factory.StartNew<bool>((delay) =>
            {
                try
                {
                    int count = (int)delay;
                    for (int i = 0; i < count; i++)
                    {
                        Debug.WriteLine("FirstWait is at {0}", i);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                return true;
            }, waitTime);

            await Task.WhenAll(task);
            Debug.WriteLine("After FirstWait");
            return task.Result;
        }


        private async Task<bool> SecondWait(int waitTime)
        {
            var task = Task.Factory.StartNew<bool>((delay) =>
            {
                try
                {
                    int count = (int)delay;
                    for (int i = 0; i < count; i++)
                    {
                        Debug.WriteLine("SecondWait is at {0}", i);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                return true;
            }, waitTime);
            await Task.WhenAll(task);
            Debug.WriteLine("After SecondWait");
            return task.Result;
        }

        [HttpPost]
        public ActionResult Index(int id)
        {       
            return View();
        }
        public ActionResult Index3() {
            var result = LaunchTasks(new List<int>() { 5, 3 });
            Debug.WriteLine("The final result is {0}", result.Result);
            return View();
        }
    }
}