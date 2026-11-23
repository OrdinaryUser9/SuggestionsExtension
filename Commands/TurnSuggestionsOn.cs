
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TextTemplating.VSHost;
using System;
using System.ComponentModel.Design;

namespace SuggestionController.Commands;

internal sealed class TurnSuggestionsOn
{
    public const int CommandId = 0x0101;

    public static void Initialize(
        OleMenuCommandService commandService)
    {
        var commandID = new CommandID(
            CommandIds.CommandSet,
            CommandId);

        var command = new MenuCommand(
            Execute,
            commandID);

        commandService.AddCommand(command);
    }

    private static void Execute(object sender, EventArgs e)
    {
        SuggestionManager.Enable();
    }
}
