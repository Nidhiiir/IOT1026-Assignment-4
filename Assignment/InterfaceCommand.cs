namespace Assignment.InterfaceCommand;

public interface RobotCommand
{
    void Run(Robot robot); // Interfaces are public and abstract by default.
}
public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X--;
        }
    }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;
        }
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;
        }
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;
        }
    }
}

public class BachataCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            for (int repeatSteps = 0; repeatSteps < 3; repeatSteps++)
            {
                robot.X++;
                robot.X++;
                robot.X--;
                robot.X--;
                robot.X--;
            }
            robot.Y++;
            robot.X--;
            robot.Y--;
            robot.X++;
        }
    }
}


        
