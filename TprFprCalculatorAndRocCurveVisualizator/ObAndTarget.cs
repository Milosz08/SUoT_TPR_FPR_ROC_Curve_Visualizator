namespace RocCurveAICalculator
{
    public class ObAndTarget
    {
        public double Ob { get; set; }
        public string Target { get; set; }
    }

    public class ConfusionMatrixData
    {
        public double[,] ConfusionMatrix { get; set; }
        public string ObEstimate { get; set; }
    }
}
