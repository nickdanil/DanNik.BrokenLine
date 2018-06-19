namespace DanNik.BrokenLine.BusinessObjects.Contracts
{
    public interface IBrokenLineService
    {
		double GetBrokenLineLength(BrokenLinePoint[] brokenLine);
    }
}
