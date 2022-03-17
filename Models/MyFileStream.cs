using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

static class MyFileStream
{
    /*public static async Task<string> CompText(string text, string comp)
    {
        await Task.Delay(0);
        string res = "";
        foreach (Match match in Regex.Matches(text, comp))
        {
            res += $"{match.Value}\n";
        }
        return res;
    }*/

    /*public static async Task<string> ReadFile(string? path)
    {
        await Task.Delay(0);
        if (path == null) return "Не удалось открыть файл";
        string res = File.ReadAllText(path);
        return res;
    }*/
    /*public static async Task SaveFile(string? path, string text)
    {
        await Task.Delay(0);
        if (path == null) return;
        File.AppendAllText(path, text);
    }*/
    public static string CompText(string text, string comp)
    {
        string res = "";
        foreach (Match match in Regex.Matches(text, comp))
        {
            res += $"{match.Value}\n";
        }
        return res;
    }

    public static string ReadFile(string path)
    {
        if (path == null) return "Не удалось открыть файл";
        string res = File.ReadAllText(path);
        return res;
    }
    public static void SaveFile(string path, string text)
    {
        if (path == null) return;
        File.AppendAllText(path, text);
    }
}
