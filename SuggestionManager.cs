using Microsoft.VisualStudio.Debugger.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuggestionController;

public static class SuggestionManager
{
    private static void RunScript(string scriptName)
    {
        string assemblyDirectory = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location)!;

        string scriptPath = Path.Combine(
            assemblyDirectory,
            "Scripts",
            scriptName);

        if (!File.Exists(scriptPath))
        {
            throw new FileNotFoundException(
                "Could not find PowerShell script: " + scriptPath
                );
        }

        var startInfo = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            Arguments = $"-NoProfile -STA -File \"{scriptPath}\"",
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process.Start(startInfo);
    }

    public static void Enable()
    {
        RunScript("EnableSuggestions.ps1");
    }

    public static void Disable()
    {
        RunScript("DisableSuggestions.ps1");
    }
    
}
