using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

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
    public void AddOne(Times times){
        try{           
            Console.WriteLine("In the model :" +times.name);
            foreach(var lap in times.laps){
                 Console.WriteLine(lap);
            }
            IMongoClient client = new MongoClient("mongodb://admin:171292@localhost:27017");
           
            var collection = client.GetDatabase("swimchrono").GetCollection<BsonDocument>("times");

            Console.WriteLine(times.ToBsonDocument());
            collection.InsertOneAsync(times.ToBsonDocument());

        }catch(Exception e){
            Console.WriteLine(e);
        }
    
    
    }


}
