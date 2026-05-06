using VectorSimInfectionStack;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(59, 38, 22, 82);
        if (DomainReviewLens.Score(item) != 172) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
