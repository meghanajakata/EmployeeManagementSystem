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
                _flight.Price = flight.Price;
                _context.SaveChanges();
            }
        }

        public Flight GetFlightByName(string Name)
        {
            var _flight = _context.Flights.SingleOrDefault(flight => flight.Name == Name);
            return _flight;
        }


        public bool AddFlight(Flight flight)
        {
            var _flight = GetFlightByName(flight.Name);
            if(_flight != null)
                return false;
            _context.Flights.Add(flight);
            _context.SaveChanges();
            return true;
        }

        public void DeleteFlight(int id)
        {
            var _flight = _context.Flights.FirstOrDefault(flight => flight.Id == id);
            if(_flight != null)
            {
                _context.Remove(_flight);
                _context.SaveChanges();
            }
        }
    }
}
