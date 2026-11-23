
Add-Type -AssemblyName System.Windows.Forms

$message = @"
SUGGESTIONS OFF

Configure these Visual Studio settings:

1. Tools > Options
2. Text Editor > All Languages > General
   - Uncheck Auto list members
   - Uncheck Parameter information

3. Text Editor > Inline Suggestions > General
   - Set Inline Suggestions Invocation to Manual

4. Click the Copilot icon in the status bar.
   - Disable suggestions globally.

Click OK to close this reminder.
"@

[System.Windows.Forms.MessageBox]::Show(
    $message,
    "Suggestion Controller - OFF",
    [System.Windows.Forms.MessageBoxButtons]::OK,
    [System.Windows.Forms.MessageBoxIcon]::Information
) | Out-Null
