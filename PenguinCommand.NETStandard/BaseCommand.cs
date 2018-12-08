using McMaster.Extensions.CommandLineUtils;

namespace PenguinCommand.NETStandard
{
    [HelpOption("--help|-h")]
    public abstract class BaseCommand
    {
        protected virtual int OnExecute(CommandLineApplication application)
        {
            return 0;
        }
    }
}
