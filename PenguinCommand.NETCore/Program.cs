using McMaster.Extensions.CommandLineUtils;
using PenguinCommand.NETStandard;
using System;
using System.Text;

namespace PenguinCommand.NETCore
{
    internal class Program
    {
        private static void Main(string[] args) => CommandLineApplication.Execute<Command>(args);
    }
}
