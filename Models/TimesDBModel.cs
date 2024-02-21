using MongoDB.Driver;
using MongoDB.Bson;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
namespace ProjectSwimChronoADBack.Models;

public class TimesDBViewModel 
{


   public void GetOne(){
        try{
            
            var client = new MongoClient("mongodb://admin:171292@localhost:27017");
           
            var collection = client.GetDatabase("swimchrono").GetCollection<BsonDocument>("times");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", 0);
            var document = collection.Find(filter).FirstOrDefault();
            Console.WriteLine(document);

        }catch(Exception e){
            Console.WriteLine(e);
        }
    
    
    }
    public void AddOne(List<Object> times){
        try{
            
            var client = new MongoClient("mongodb://admin:171292@localhost:27017");
           
            var collection = client.GetDatabase("swimchrono").GetCollection<BsonDocument>("times");
            
            collection.InsertOne(times.ToBsonDocument());

        }catch(Exception e){
            Console.WriteLine(e);
        }
    
    
    }


}
