using System;

namespace Assignment.InterfaceCommand
{
    public interface IRobotCommand
    {
        void Run(Robot robot);
    }

    public class Robot
    {
        private IRobotCommand[] commands = new IRobotCommand[6];
        private int currentIndex = 0;

        public void LoadCommand(IRobotCommand command)
        {
            if (currentIndex < 6)
            {
                commands[currentIndex] = command;
                currentIndex++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Command limit exceeded. Cannot add more commands.");
                Console.ResetColor();
            }
        }

        public void Run()
        {
            foreach (IRobotCommand command in commands)
            {
                command?.Run(this);
            }
        }
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

    public static class Program
    {
        enum Commands
        {
            on,
            off,
            north,
            south,
            east,
            west
        }

        public static bool AssignCommand(Robot robot, string? command)
        {
            if (Enum.TryParse<Commands>(command, out Commands thisCommand))
            {
                switch (thisCommand)
                {
                    case Commands.on:
                        robot.LoadCommand(new OnCommand());
                        break;
                    case Commands.off:
                        robot.LoadCommand(new OffCommand());
                        break;
                    case Commands.north:
                        robot.LoadCommand(new NorthCommand());
                        break;
                    case Commands.south:
                        robot.LoadCommand(new SouthCommand());
                        break;
                    case Commands.east:
                        robot.LoadCommand(new EastCommand());
                        break;
                    case Commands.west:
                        robot.LoadCommand(new WestCommand());
                        break;
                }
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid command - Try again");
                Console.ResetColor();
                return false;
            }
        }

        static void Main()
        {
            Robot newRobot = new Robot();
            Console.WriteLine("Give 6 commands to the robot. Possible commands are:");
            Commands[] allCommands = (Commands[])Enum.GetValues(typeof(Commands));

            foreach (Commands command in allCommands)
            {
                Console.WriteLine(command);
            }

            for (int input = 0; input < 6; input++)
            {
                Console.Write($"Assign command #{input + 1}: ");
                bool commandAdded = AssignCommand(newRobot, Console.ReadLine());
                if (!commandAdded)
                {
                    input--;
                }
            }

            newRobot.Run();
        }
    }
}
