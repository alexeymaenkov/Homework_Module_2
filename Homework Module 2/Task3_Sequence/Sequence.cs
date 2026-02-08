namespace Homework_Module_2.Task3_Sequence;

public class Sequence
{
    public void Run()
    {
        const int STEP = 7;

        int startNumber = 5;
        
        while (startNumber <= 103)
        {
            Console.Write(startNumber + " ");
            startNumber += STEP;
        }
    }
}