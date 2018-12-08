using McMaster.Extensions.CommandLineUtils;

namespace PenguinCommand.NETStandard
{
    [Command]
    [Subcommand("show", typeof(ShowCommand))]
    [Subcommand("list", typeof(ListCommand))]
    public class Command : BaseCommand
    {
        protected override int OnExecute(CommandLineApplication application)
        {
            application.ShowHelp();
            return base.OnExecute(application);
        }
    }
}
