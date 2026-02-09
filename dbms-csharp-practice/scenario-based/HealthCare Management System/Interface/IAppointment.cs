public interface IAppointment
{
    void BookAppointment();        // UC-3.1
    void CheckAvailability();      // UC-3.2
    void CancelAppointment();      // UC-3.3
    void RescheduleAppointment();  // UC-3.4
    void ViewDailySchedule();      // UC-3.5
}
