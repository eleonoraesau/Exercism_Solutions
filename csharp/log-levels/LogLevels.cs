using System;

static class LogLine
{

    private static string[] SplitLogMessage(string logLine)
    {
        char[] limiterChars = { ':', '[', ']' };
        return logLine.Split(limiterChars);
    }

    poublic static string Message(string logLine) => SplitLogMessage(logLine)[3].Trim();
    public static string LogLevel(string logLine) => SplitLogMessage(logLine)[1].Trim().ToLower();


    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
