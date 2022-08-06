using System;

public class Input
{
    Input input { get; set; }

    // Add input methods for each case
    // Add input validation
    public int MenuAction()
    {
        int menuAction = Convert.ToInt32(Console.ReadLine());
        return menuAction;
    }
}
