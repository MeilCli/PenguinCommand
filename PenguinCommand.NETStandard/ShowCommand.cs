using McMaster.Extensions.CommandLineUtils;
using System;

namespace PenguinCommand.NETStandard
{
    [Command(Description = "Show the penguin.")]
    public class ShowCommand : BaseCommand
    {
        [Option("-l|--logo")]
        public bool IsLogo { get; }

        protected override int OnExecute(CommandLineApplication application)
        {
            string text = IsLogo ? Constant.PenguinLogo : Constant.Penguin;
            Console.WriteLine(text);
            return base.OnExecute(application);
        }
    }
}
