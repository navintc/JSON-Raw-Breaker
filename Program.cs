using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers; 
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using WTHjsonitem;

namespace ConsoleProgram
{
    public class DataObject
    {
        public string Name { get; set; }
    }

    public class Class1
    {
        private const string URL = "https://5fa04c51e21bab0016dfd080.mockapi.io/wth/Post";
        private const string URL2 = "https://5fa04c51e21bab0016dfd080.mockapi.io/wth/Person";

        static void Main(string[] args)
        {
            Console.WriteLine("POST---------------------------------------------------------------------------------------------------------------------");
            Jputha();
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PERSON-------------------------------------------------------------------------------------------------------------------");
            Jputha2();
            Console.ReadKey();

        }
        
        public static async Task Jputha(){

                using (HttpClient client = new HttpClient()){
                client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format. Hol up, ai ehema header accept karanne?
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress)){
                    response.EnsureSuccessStatusCode();

                    //eliye gahuwoth doesnot exist in the current context wenawa. ekai methana gahuwe.
                    if (response.Content is object){
                        
                        var responseContent = response.Content.ReadAsStringAsync().Result;

                    
                        Console.WriteLine("Raw data heystack");

                        Console.WriteLine(responseContent);
    
                        Console.WriteLine("..................................................................");

                        //splitting
                        var cow = responseContent.Split("},{");
                        //count of stuff! every stuff
                        int cowlen = cow.Length;

                        //data row count
                        Console.WriteLine("*Row count from this resource: {0} ", cowlen);

                        //printing splitted data rows
                        for(int i=0; i<cowlen; i++){
                            Console.WriteLine(cow[i]);
                        }

                    };
                };
            }
        }

        public static async Task Jputha2(){

                using (HttpClient client = new HttpClient()){
                client.BaseAddress = new Uri(URL2);

                // Add an Accept header for JSON format. Hol up, ai ehema header accept karanne?
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress)){
                    response.EnsureSuccessStatusCode();

                    //eliye gahuwoth doesnot exist in the current context wenawa. ekai methana gahuwe.
                    if (response.Content is object){
                        // var result = response.Content.ReadAsAsync();
                        var responseContent = response.Content.ReadAsStringAsync().Result;

                        Console.WriteLine("Raw data heystack");
                        Console.WriteLine(responseContent);

                        Console.WriteLine("..................................................................");
                        // Console.WriteLine(dataObj);

                        //splitting
                        var cow = responseContent.Split("},{");
                        //count of stuff! every stuff
                        int cowlen = cow.Length;

                        //data row count
                        Console.WriteLine("*Row count from this resource: {0} ", cowlen);


                        //printing splitted data rows
                        for(int i=0; i<cowlen; i++){
                            Console.WriteLine(cow[i]);
                        }

                    };
                };
            }
        }
    }
}
