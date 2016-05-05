using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Nest;

namespace AnalyticsData
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var node = new Uri("http://localhost:9200");

            var settings = new ConnectionSettings(
                node,
                defaultIndex: "pmi-data");

            var clientNest = new ElasticClient(settings);

            var person = new Person
            {
                Id = 14,
                FirstName = "Louis",
                LastName = "Laubscher"
            };

            var index = clientNest.Index(person);


            var person2 = new Person
            {
                Id = 118,
                FirstName = "Melany",
                LastName = "Dinnematin"
            };

            var index2 = clientNest.Index(person2);
        }

        private void ParseExcelData()
        {

        }
    }

    public class Person
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
}
