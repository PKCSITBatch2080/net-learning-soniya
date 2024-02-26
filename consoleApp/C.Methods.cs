class Methods
{
    public void Greet()
    {
        Console.WriteLine("Hey, there");
    }
    public void Greet(string greeting)
    {
        Console.WriteLine($"{greeting}, there"); // string interpolation
    }


    public float CalculateBMI(float weightInkg, float heightInft)
    {
        float heightInM = heightInft * 0.3048f;
        var bmi = weightInkg / (heightInM * heightInM);
        return bmi;
    }
}
