
Add-Type -AssemblyName System.Windows.Forms

$message = @"
SUGGESTIONS ON

Restore these Visual Studio settings:

1. Tools > Options
2. Text Editor > All Languages > General
   - Check Auto list members
   - Check Parameter information

3. Text Editor > Inline Suggestions > General
   - Set Inline Suggestions Invocation to Automatic

4. Click the Copilot icon in the status bar.
   - Enable suggestions globally.

Click OK to close this reminder.
"@

[System.Windows.Forms.MessageBox]::Show(
    $message,
    "Suggestion Controller - ON",
    [System.Windows.Forms.MessageBoxButtons]::OK,
    [System.Windows.Forms.MessageBoxIcon]::Information
) | Out-Null
