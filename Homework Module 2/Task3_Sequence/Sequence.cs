namespace Homework_Module_2.Task3_Sequence;

public class Sequence
{
    public void Run()
    {
        const int STEP = 7;

        int startNumber = 5;
        int endNumber = 103;
        
        for (int i = startNumber; i <= endNumber; i += STEP)
        {
            Console.Write(i + " ");
        }
    }
}