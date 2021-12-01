using System;

public class Student : Person
{
    public override void Create()
    {
        if (base.BrainPower >= 0 && base.MusclePower >= 0)
        {
            Console.WriteLine("Assigning favourite student activities...");
            this.WriteHomeworks();
            this.AskQuestions();
            this.TrainHard();
            this.SleepWell();
        }
        else
        {
            throw new Exception("Student is Low on Power... Please recharge with training or sleeping.");
        }
    }

    public override void Drink(int time)
    {
        if (time > 12)
        {
            Console.WriteLine(String.Format("Student is drinking some tea. It's LATE - {0} o'clock.", time));
        }
        else
        {
            Console.WriteLine(String.Format("Student is drinking some mineral water. It's EARLY - {0} o'clock.", time));
        }
    }

    private void WriteHomeworks()
    {
        base.BrainPower -= 10;
        base.MusclePower -= 10;
        Console.WriteLine("- Writing Homeworks. You lose power. Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }
    private void AskQuestions()
    {
        base.BrainPower -= 15;
        base.MusclePower -= 15;
        Console.WriteLine("- Asking Questions. You lose power. Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }

    private void TrainHard()
    {
        base.BrainPower += 10;
        base.MusclePower += 10;
        Console.WriteLine("- Training Hard. You gain power. Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }

    private void SleepWell()
    {
        base.BrainPower += 15;
        base.MusclePower += 15;
        Console.WriteLine("- Sleeping Well. You gain power. Brain Power: " + base.BrainPower + " Muscle Power: " + base.MusclePower);
    }

    public void SmokeShisha()
    {
        base.Smoke = "shisha";
    }
}