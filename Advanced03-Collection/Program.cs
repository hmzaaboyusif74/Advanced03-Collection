using Advanced03_Collection.Q1_studentGrade;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Advanced03_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //StudentGrade studentGrade = new StudentGrade();
            //Console.WriteLine("Grades of student");
            //studentGrade.printGrade();
            //Console.WriteLine("count of list");
            //studentGrade.countoflist();
            //Console.WriteLine("capacity of list");
            //studentGrade.Capcityoflist();
            //Console.WriteLine("Grades of student after sorted");
            //studentGrade.sortStudentGrade();
            //Console.WriteLine("the first grade above 90");
            //studentGrade.Above90();
            //Console.WriteLine("the Grade below 75");
            //studentGrade.Below75();
            //Console.WriteLine("list after Removing");
            //studentGrade.Removebelow75();
            //Console.WriteLine("list checking have 100");
            //studentGrade.checkList();
            //Console.WriteLine("list after convert to string");
            //studentGrade.Converttostring();
            #endregion
            #region Q02
            //SortedDictionary<int, string> LeaderBoard = new SortedDictionary<int, string>()
            //{
            //    { 500 , "Ahmed" },
            //    {200 , "Sara" },
            //    {800 , "Ali" },
            //    { 350 , "Mona" }
            //};
            //#region Q1-Q02
            //Console.WriteLine("the all data in dictionary::");
            //foreach(var item in LeaderBoard)
            //{
            //    Console.WriteLine($"Score::{item.Key} and his name is ::{item.Value}");
            //}
            //#endregion
            //#region Q2-Q02
            //Console.WriteLine("the first key and Value::");
            //Console.WriteLine(LeaderBoard.First());
            //#endregion
            //#region  Q3-Q02
            //Console.WriteLine("checking for score 500::");
            //var res = LeaderBoard.Keys.Contains(500);
            //Console.WriteLine(res);
            //#endregion
            //#region  Q4-Q02
            //Console.WriteLine("getPlayer score 999");
            //var getPlayer= LeaderBoard.TryGetValue(999,out string? res);
            //Console.WriteLine(getPlayer);
            //#endregion
            //#region Q5-Q02
            //Console.WriteLine("dictionary after remove");
            //LeaderBoard.Remove(200);
            //foreach (var item in LeaderBoard)
            //{
            //    Console.WriteLine($"Score::{item.Key} and his name is ::{item.Value}");
            //}
            //#endregion
            #endregion
            #region Q03
            //#region Q1-Q03
            //Dictionary<string, string> Contact = new Dictionary<string, string>()
            //{
            //    {"hmza","0106643215" },
            //    {"ahmed","0106123205" },
            //    {"muhamed","0110643215" },
            //    {"yosef","0106123215" }

            //};
            //#endregion
            //#region  Q2-Q03
            //Console.WriteLine("try adding contact that exsit");
            //Contact["yosef"] = "012564312512";//add or update
            //foreach (var item in Contact)
            //{
            //    Console.WriteLine(item);
            //}
            //#endregion
            //Contact.Add("omer", "01235441201");//add only not duplicated

            //try
            //{
            //    Contact.Add("omer", "01235441201");//have duplicated
            //}
            //catch (Exception ex)
            //{
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //#region Q3-Q03
            //Console.WriteLine("Search for a contact that doesn’t exist");
            //Console.WriteLine(Contact.ContainsKey("nour"));
            //#endregion
            //#region Q4-Q03
            //Console.WriteLine("Get a contact with a fallback of Not Found");
            //Console.WriteLine(Contact.GetValueOrDefault("hmza", "not found"));
            //#endregion
            //#region Q5-Q03
            //Console.WriteLine("keys in one line");
            //Console.WriteLine(string.Join(", ", Contact.Keys)); 
            //Console.WriteLine("values in one line");
            //Console.WriteLine(string.Join(", ", Contact.Values));
            //#endregion
            #endregion
            #region Q04
            // #region Q1-Q2-Q04
            // HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            // {
            //     "ahmed@test.com",
            //     "AHMED@test.com",
            //     "sara@test.com",
            //     "Sara@Test.Com"
            // };
            // #endregion
            // #region  Q3-Q04
            // Console.WriteLine("count of Hashset");
            // Console.WriteLine(Emails.Count);// count=2 becouse hashset remove any duplicate
            // #endregion
            // #region Q4-Q5-Q04
            // Console.WriteLine("--------------------------------");
            // HashSet<int> A = new HashSet<int> { 1, 2, 3, 4, 5 };
            // HashSet<int> B = new HashSet<int> { 4, 5, 6, 7, 8 };
            // HashSet<int> union = new HashSet<int> (A);


            // Console.WriteLine("the function of Hashset");
            //// union.IntersectWith(B);
            //// union.ExceptWith(B);
            ////  union.UnionWith(B);
            // foreach (var item in union)
            // {
            //     Console.WriteLine(item);
            // }
            // #endregion
            // #region Q6-Q04
            // Console.WriteLine("---------------------------");
            // Console.WriteLine("IsSubset Function");
            // HashSet<int> D = new HashSet<int> { 1, 2 };
            // Console.WriteLine(D.IsSubsetOf(A));
            // #endregion
            #endregion
            #region Q05
            // #region Q1-Q05
            // Queue<string> Decuments = new Queue<string>();
            // Decuments.Enqueue("Report.pdf");
            // Decuments.Enqueue("Invoice.pdf");
            // Decuments.Enqueue("Letter.docx");
            // Decuments.Enqueue("Resume.pdf");
            // Decuments.Enqueue("Photo.jpg");

            // Console.WriteLine("the item in Queue ");
            // foreach (var item in Decuments)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("------------");
            // Console.WriteLine(Decuments.Count);
            // #endregion
            // #region Q2-Q05
            // Console.WriteLine("---------------------");
            // Console.WriteLine("which document will print by peak");
            // Console.WriteLine(Decuments.Peek());
            // #endregion
            // #region Q3-Q05
            // Console.WriteLine("------------------------------");
            // Console.WriteLine("Dequeue");
            // Console.WriteLine("-------------------------------");
            // while ( Decuments.Count>0)
            // {
            //     Console.WriteLine($"nameFile ::{Decuments.Dequeue()}");
            // }
            // #endregion
            // #region Q4-Q05
            // Console.WriteLine("-----------------------");
            //var result= Decuments.TryDequeue(out string? res); //false beacouse it return bool and queue is empty  
            // Console.WriteLine(result);

            // #endregion
            #endregion
            #region Q06
           // #region Q1-Q06
           // Stack<string> URLS = new Stack<string>();
           // URLS.Push("google.com");
           // URLS.Push("github.com");
           // URLS.Push("stackoverflow.com");
           // URLS.Push("youtube.com");
           // URLS.Push("claude.ai");
           // #endregion
           // #region  Q2-Q06
           // Console.WriteLine("---------------------");
           // Console.WriteLine("top of stack  ");
           // Console.WriteLine("---------------------");
           // Console.WriteLine(URLS.Peek());
           // #endregion
           // #region  Q3-Q06
           // Console.WriteLine("----------------------");
           // Console.WriteLine(" Pop");
           // Console.WriteLine("----------------------");
           // for (int i = 0; i < 3; i++)
           // {
           //     {
           //         Console.WriteLine(URLS.Pop());
           //     }
           // }
           //#endregion
           //#region Q4-Q06
           // Console.WriteLine("---------------------------------");
           //   foreach (var item in URLS)
           //     {
           //       Console.WriteLine(item);
           //     }
           //     Console.WriteLine("--------------------------------------");
           // #endregion
           // #region Q4-Q06

           // #endregion
           // #region  Q5-Q06

           // Console.WriteLine("make the stack empty");
           // for (int i = 0; i < 2; i++)
           // {
           //     {
           //         Console.WriteLine(URLS.Pop()); //make stack empty
           //     }
           // }
           // Console.WriteLine("------------try pop empty stack--------------");
           // Console.WriteLine(URLS.TryPop(out string? res)); 
           // #endregion
            #endregion
        }
    }
    }
