using Blueshift.EntityFrameworkCore.MongoDB.Annotations;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace CityApi.Entities
{
    [MongoDatabase("CityInfoDb")]
    public class CityInfoContext: DbContext
    {
        public DbSet<City> Cities {get; set;}

        public DbSet<PointsOfInterest> PointsOfInterest { get; set; }


        public CityInfoContext()
            :this(new DbContextOptions<CityInfoContext>())
        {
        }

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            :base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "mongodb://localhost";

            var mongoURL = new MongoUrl(connectionString);

            MongoClientSettings settings = MongoClientSettings.FromUrl(mongoURL);

            MongoClient mongoClient = new MongoClient(settings);

            optionsBuilder.UseMongoDb(mongoClient);
        }
        
        
    }
}