using VectorSimInfectionStack;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(60, 96, 9, 16, 12);
        if (Policy.Score(signalcase_1) != 162) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "accept") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(98, 98, 13, 21, 11);
        if (Policy.Score(signalcase_2) != 197) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(92, 99, 27, 17, 10);
        if (Policy.Score(signalcase_3) != 177) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
