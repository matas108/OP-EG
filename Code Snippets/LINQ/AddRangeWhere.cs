List<Schedule> schedules = new List<Schedule>();

foreach (Visit visit in visits)
{
    List<Visitor> visitors = new List<Visitor>();

    foreach (Schedule schedule in schedules.Where(schedule => visit.Date == schedule.ScheduleDate))
    {
        visitors.AddRange(visit.Where(visitor =>
                visitor.ArrivalTime >= schedule.Member.ConsultationStart &&
                visitor.VisitEnd <= schedule.Member.ConsultationEnd);

            schedule.AddVisit(new Visit(schedule.ScheduleDate, visitors));
        }
    }
}