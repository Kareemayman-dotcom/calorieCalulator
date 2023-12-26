using System;

public class Person
{
    public double currentWeight { get; set; }
    public double targetWeight { get; set; }
    public int timeFrame { get; set; }
    public double currentHeight { get; set; }
    public double targetCalories { get; set; }
    public Person(double currentWeight, double targetWeight, int timeFrame, double currentHeight, double targetCalories)
    {
        this.currentWeight = currentWeight;
        this.targetWeight = targetWeight;
        this.timeFrame = timeFrame;
        this.currentHeight = currentHeight;
        this.targetCalories = targetCalories;   
    }
}
