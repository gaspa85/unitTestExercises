namespace LibraryShop.businessModel;

public class TimeRange
{
    public TimeRange(DateTime Start, DateTime End)
    {
        if (Start.CompareTo(End) <= 0)
        {
            throw new ArgumentException("start date is over end date");
        }
        this.Start = Start;
        this.End = End;
    }

    public DateTime Start { get; }
    public DateTime End { get; }
}
