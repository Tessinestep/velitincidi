public int SumEmployeeTickets(string fullName)
{
    int totalPoints = 0;
    foreach (var ticket in Tickets)
    {
        if (ticket.Employee.FullName == fullName)
        {
            totalPoints += ticket.Points;
        }
    }
    return totalPoints;
}
