namespace Assignment.AbstractCommand;

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OffCommand : IRobotCommand
{
    public override void Run()(Robot robot) => robot.IsPowered = false;
}

public class OnCommand : IRobotCommand
{
    public override void Run()(Robot robot) => robot.IsPowered = true;
}

public class WestCommand : IRobotCommand
{
    public override void Run()(Robot robot) { if (robot.IsPowered) robot.X--; }
}

public class EastCommand : IRobotCommand
{
    public override void Run()(Robot robot) { if (robot.IsPowered) robot.X++; }
}

public class SouthCommand : IRobotCommand
{
    public override void Run()(Robot robot) { if (robot.IsPowered) robot.Y--; }
}

public class NorthCommand : IRobotCommand
{
    public override void Run()(Robot robot) { if (robot.IsPowered) robot.Y++; }
}
