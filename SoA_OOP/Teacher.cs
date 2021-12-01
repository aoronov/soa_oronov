using System;

public class Teacher : Person
{
    public override void Create()
    {
        if (base.BrainPower >= 0 && base.MusclePower >= 0)
        {
            Console.WriteLine("Assigning favourite teacher activities...");
            this.CheckHomeworks();
            this.AnswerQuestions();
            this.TrainHard();
            this.SleepWell();
        }
        else
        {
            throw new Exception("Teacher is Low on Power... Please recharge with training or sleeping.");
        }
    }

    public override void Drink(int time)
    {
        if (time > 12)
        {
            Console.WriteLine(String.Format("Teacher is drinking some whishkey. It's LATE - {0} o'clock.", time));
        }
        else
        {
            Console.WriteLine(String.Format("Teacher is drinking some vodka. It's EARLY - {0} o'clock.", time));
        }
    }


    private void CheckHomeworks()
    {
        base.BrainPower -= 5;
        base.MusclePower -= 5;
        Console.WriteLine("- Checking Homeworks. You lose power. Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }
    private void AnswerQuestions()
    {
        base.BrainPower -= 10;
        base.MusclePower -= 10;
        Console.WriteLine("- Answering Questions. You lose power. Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }

    private void TrainHard()
    {
        base.BrainPower += 5;
        base.MusclePower += 5;
        Console.WriteLine("- Training Hard. You gain power! Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }

    private void SleepWell()
    {
        base.BrainPower += 10;
        base.MusclePower += 10;
        Console.WriteLine("- Sleeping Well. You gain power! Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }

    public void SmokeCigarettes()
    {
        base.Smoke = "cigarettes";
    }
}