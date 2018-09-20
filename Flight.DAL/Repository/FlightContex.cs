namespace Flight.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Flight.Model;

    public class FlightContex : DbContext
    {
        // Your context has been configured to use a 'FlightContex' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Flight.DAL.FlightContex' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FlightContex' 
        // connection string in the application configuration file.
        public FlightContex()
            : base("name=FlightContex")
        {
        }

        public DbSet<CurrencyModel> Currency { get; set; }
        public DbSet<FlightSegmentDTO> FlightSegment { get; set; }
        public DbSet<FlightBoundDTO> FlightBound { get; set; }
        public DbSet<FlightItinearyDTO> FlightIntenary { get; set; }
        public DbSet<PriceSegmentDTO>  Price{ get; set; }
        public DbSet<FlightSearchResultDTO> Result { get; set; }
        public DbSet<FlightSearchResponeDTO> Respone { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}