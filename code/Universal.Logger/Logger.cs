using System;
using System.Collections.Generic;
namespace Universal.Logger
{
  public class FileLogger
  {
    public void Write(string data)
    {
      // Write data to file
    }
    public void WriteLine(string data)
    {
      // Write data to file with CRLF
    }
  }

  public class EventLogger
  {
    public void Log(string data)
    {
      // Log data
    }
  }

  public class TwitterLogger
  {
    public void Tweet(string data)
    {
      // Tweet data
    }
  }
}
