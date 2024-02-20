using MongoDB.Driver;
using MongoDB.Bson;
namespace ProjectSwimChronoADBack.Models;

public class TimesDBViewModel 
{


   public void getOne(){
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
}
