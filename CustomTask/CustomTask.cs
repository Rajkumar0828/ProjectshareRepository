using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
 
public class CustomTask : Microsoft.Build.Utilities.Task
{
     static void Main(string[] args)
    {}
    [Output]
    public string OutputVersion { get; set; }
 
    public override bool Execute()
    {
        try
        {
            string version = DateTime.Now.ToString("yyyyMMddHHmmss");
            System.IO.File.WriteAllText(OutputVersion, version);
            return true;
        }
        catch (Exception ex)
        {
            Log.LogErrorFromException(ex);
            return false;
        }
    }
    }

