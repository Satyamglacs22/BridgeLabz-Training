public interface IBilling
{
    void GenerateBill();        // UC-5.1
    void RecordPayment();       // UC-5.2
    void ViewPendingBills();    // UC-5.3
    void RevenueReport();       // UC-5.4
}
