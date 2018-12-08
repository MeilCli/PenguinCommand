using McMaster.Extensions.CommandLineUtils;
using System;
using System.ComponentModel.DataAnnotations;

namespace PenguinCommand.NETStandard
{
    [Command(Description = "List the penguins.")]
    public class ListCommand : BaseCommand
    {
        [Argument(0)]
        [Required]
        [Range(1, 10)]
        public int Count { get; }

        [Option("-l|--logo")]
        public bool IsLogo { get; }

        protected override int OnExecute(CommandLineApplication application)
        {
            string text = IsLogo ? Constant.PenguinLogo : Constant.Penguin;

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(text);
            }

            return base.OnExecute(application);
        }
    }
}
