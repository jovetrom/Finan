namespace Finan.Core.Requests.Transactions;

public class GetTransactionsByPeriodRequest : PagedRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndsDate { get; set; }
}