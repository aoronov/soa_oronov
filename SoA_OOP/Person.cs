using System;

public abstract class Person
{
    private int _brainPower = 100;
    private int _musclePower = 100;
    private String _personName = String.Empty;
    private String _smoke = String.Empty;

    public String PersonName
    {
        get
        {
            return _personName;
        }
        set
        {

            _personName = value;
            if (value.Length >= 6)
            {
                Console.WriteLine(String.Format("Hello, {0}! You have a long name consisting of {1} letters! Let me try to spell it...", value, value.Length));

                for(int i = 0; i < value.Length; i++){
                    if (i !=  value.Length - 1)
                    {
                        Console.Write(String.Format("{0}. ", value[i]));
                    }
                    else
                    {
                        Console.WriteLine(String.Format("{0}... THIS WAS A HARD ONE!", value[i]));
                    }
                }   
            }
            else
            {
                String oddOrEven = String.Empty;
                if (value.Length %2 == 0){
                     oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }

                Console.WriteLine(String.Format("Hello, {0}! I like this name! It is only {1} letters ({2} number) and is very easy to spell!", value, value.Length, oddOrEven));
            }
            
        }
    }

    public int BrainPower
    {
        get
        {
            return _brainPower;
        }
        set
        {
            if (value >=0)
            {
                _brainPower = value;
            }
            else
            {
                throw new Exception("Brain power must be between 0 and 100.");
            }
        }
    }

    public int MusclePower
    {
        get
        {
            return _musclePower;
        }
        set
        {
            if (value >=0)
            {
                _musclePower = value;
            }
            else
            {
                throw new Exception("Muscle power must be between 0 and 100.");
            }
        }
    }
    
    public String Smoke
    {
        get
        {
            return _smoke;
        }
        set
        {
            _smoke = value;
            Console.WriteLine(String.Format("Smoking some {0}. Puff-paff.", value));
        }
    }

    public abstract void Create();
    public abstract void Drink(int time);
}