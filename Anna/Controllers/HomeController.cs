using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anna.Controllers
{
    public class HomeController : Controller
    {

        ServiceReference1.CountCheatServiceSoapClient client = new ServiceReference1.CountCheatServiceSoapClient("CountCheatServiceSoap12");

        Dictionary<char, int> WordValueDictionary = new Dictionary<char, int>(){
            {'A',1},
            {'B',3},
            {'C',3},
            {'D',2},
            {'E',1},
            {'F',4},
            {'G',2},
            {'H',4},
            {'I',1},
            {'J',8},
            {'K',5},
            {'L',1},
            {'M',3},
            {'N',1},
            {'O',1},
            {'P',3},
            {'Q',1},
            {'R',1},
            {'S',1},
            {'T',1},
            {'U',1},
            {'V',4},
            {'W',4},
            {'X',8},
            {'Y',4},
            {'Z',10}};

        public ActionResult Index(string q = "")
        {

            string[] Solutions = null;
            
            try
            {

                Solutions = client.LetterSolutions(q);
            }
            catch (Exception)
            {

                ViewBag.ErrorMessage = "Cannot find any words";
            }


            List<Models.Word> wordslist = new List<Models.Word>();

            if (ViewBag.ErrorMessage == null)
            {
                foreach (var solution in Solutions)
                {
                    int wordval = WordValue(solution.ToUpper());

                    wordslist.Add(new Models.Word() { Value = wordval, Solution = solution });
                }

                ViewBag.Solutions = wordslist;
            }
            ViewBag.Query = q;


            return View();
        }


        public int WordValue(string word)
        {
            int Value = 0;

            foreach (char letter in word)
            {
                if (WordValueDictionary.ContainsKey(letter))
                {
                    Value += WordValueDictionary[letter];
                }
            }

            return Value;
        }

    }
}
