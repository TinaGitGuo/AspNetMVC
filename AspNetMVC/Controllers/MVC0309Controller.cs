using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Speech.Synthesis;
namespace AspNetMVC.Controllers
{
     
    public class MVC0309Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0309
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult SpeechPlay()
        {
            Task task = new Task(Function2);
            task.Start();
            return Content("ok");
        }
        public void Function2()
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Rate = -1;
            voice.Volume = 100;
            voice.SpeakAsync("Hello World Hello World Hello World Hello World Hello World i like speech");
        }
        public ActionResult Index2() {
            return View();
        }
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        SpeechSynthesizer voice = new SpeechSynthesizer(); //Create Object
        //        voice.Rate = -1; //set Speed [-10,10]
        //        voice.Volume = 100; //set volume [0,100]
        //        voice.SpeakAsync("Hello World"); //Play the specified string (asynchronous)
        //        Console.ReadKey();
        //        //The following code for some of the attributes of the 'SpeechSynthesizer' see actual situation whether need to use
        //        //voice.Dispose(); //Release all voice resources
        //        //voice.SpeakAsyncCancelAll(); //Cancel to read
        //        //voice.Speak("Hello World"); //Synchronous read
        //        //voice.Pause(); //Pause
        //        //voice.Resume(); //go on
        //    }
        //}


        //public ActionResult SpeechPlay()
        //{
        //    Task<bool> task = new Task<bool>(() =>
        //    {
        //        bool res = Function();
        //        return res;
        //    });
        //    task.Start();
        //    task.Wait();
        //    if (task.Result)
        //    {
        //        return Content("ok");
        //    }
        //    return Content("no");
        //}
        //public bool Function()
        //{
        //    bool isSuccess;
        //    try
        //    {
        //        SpeechSynthesizer voice = new SpeechSynthesizer();
        //        voice.Rate = -1;
        //        voice.Volume = 100;
        //        voice.SpeakAsync("Hello Wrold");
        //        isSuccess = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        isSuccess = false;
        //    }
        //    return isSuccess;
        //}
    }
}
 