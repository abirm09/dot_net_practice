using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace practice.Properties
{
    internal class Data
    {
        private static readonly HttpClient client = new HttpClient();

        public class TodoItem
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
        }
        public static async Task Todo()
        {
            var stringTask = client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            var msg = await stringTask;
            //Console.Write(msg);

            var todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(msg);



            //foreach (var item in todoItems)
            //{
            //    Console.WriteLine($"ID: {item.Id}, Title: {item.Title}, - - - - Completed: {item.Completed}");
            //}
        }
    }
}