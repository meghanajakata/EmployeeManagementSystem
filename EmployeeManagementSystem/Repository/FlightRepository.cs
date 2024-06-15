using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Repository
{
    public class FlightRepository : IFlightRepository
    {
        public EmployeeManagementSystemContext _context { get; set; }
        public FlightRepository(EmployeeManagementSystemContext context) 
        {
            _context = context;
        }
        public List<Flight> GetFlights()
        {
            var flights = _context.Flights.ToList();
            return flights;
        }

        public Flight GetFlightById(int id)
        {
            var flight = _context.Flights.SingleOrDefault(f => f.Id == id);
            if (flight == null)
                return null;
            return flight;
        }

        public void UpdateFlight(Flight flight)
        {
            var _flight = GetFlightById(flight.Id);
            if(_flight != null)
            {
                _flight.Name = flight.Name;
                _context.SaveChanges();
            }
        }
    }
}
