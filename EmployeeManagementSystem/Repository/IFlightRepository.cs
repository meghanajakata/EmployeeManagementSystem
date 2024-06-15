﻿using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Repository
{
    public interface IFlightRepository
    {
        public List<Flight> GetFlights();

        public Flight GetFlightById(int Id);

        public void UpdateFlight(Flight flight);
    }
}
