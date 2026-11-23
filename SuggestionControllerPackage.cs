
using Microsoft.VisualStudio.Shell;
using SuggestionController.Commands;
using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace SuggestionController;

[PackageRegistration(
    UseManagedResourcesOnly = true,
    AllowsBackgroundLoading = true)]
[ProvideMenuResource("Menus.ctmenu", 1)]
[Guid(PackageGuidString)]
public sealed class SuggestionControllerPackage : AsyncPackage
{
    public const string PackageGuidString =
        "f88467bc-fb00-4ddd-8225-cc21a0ec17e8";

    protected override async Task InitializeAsync(
        CancellationToken cancellationToken,
        IProgress<ServiceProgressData> progress)
    {
        await JoinableTaskFactory.SwitchToMainThreadAsync(
            cancellationToken);

        var commandService =
            await GetServiceAsync(typeof(IMenuCommandService))
                as OleMenuCommandService;

        if (commandService != null)
        {
            TurnSuggestionsOff.Initialize(commandService);
            TurnSuggestionsOn.Initialize(commandService);
        }
    }
}
