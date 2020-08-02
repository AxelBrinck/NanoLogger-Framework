# NanoLogger
An ASP.NET.Core light-weight framework to quickly start logging in a fancy way.

It provides the minimum tools needed to format and log to different outputs, like the console, or file.

You can log at several outputs at the same time.

You can define your outputs. This means that if you want to log to a database, you can define the procedure and add it as an output.

You can define your own displaying formats, or choose to use the default provided in the framework.

```
[Debug       ] - 16:18:03 - Main: 'Program started'
[Information ] - 16:18:03 - Main: 'Program terminated'
[Debug       ] - 18:58:39 - Main: 'Program started'
[Debug       ] - 18:58:39 - Other module: 'Hallo!'
[Information ] - 18:58:39 - Main: 'Program terminated'
[Debug       ] - 18:59:13 - Main: 'Program started'
[Notice      ] - 18:59:13 - Other module: 'Hallo!'
[Information ] - 18:59:13 - Main: 'Program terminated'
```

## Installation

There is a NuGet package released in this repository.

## Usage

### Logging to a file

Specify the desired format. This is the default format.
You can create your format by creating a class and implementing IFormat.
```
var format = new DefaultFormat();
```

Set up the file stream and pass it to the StreamOutput object.
StreamOutput requires custom formatting in the constructor so we specify the default one created before.
```
var fileStream = File.OpenWrite("log.txt");
var fileOutput = new StreamOutput(fileStream, format);
```

We can now create our main Logger object.

```
var logger = new Logger();
```

We set its output to be our stream file.
```
logger.AddOutput(fileOutput);
```

We can now log like this.
```
logger.Log(new Log(Severity.Debug, DateTime.Now, "Main", "Program started"));
logger.Log(new Log(Severity.Debug, DateTime.Now, "Other module", "Hallo!"));
logger.Log(new Log(Severity.Information, DateTime.Now, "Main", "Program terminated"));
```

### Logging to console
```
var format = new DefaultFormat();
            
var consoleStream = Console.OpenStandardOutput();
var consoleOutput = new StreamOutput(consoleStream, format);

var logger = new Logger();

logger.AddOutput(consoleOutput);

logger.Log(new Log(Severity.Debug, DateTime.Now, "Main", "Program started"));
logger.Log(new Log(Severity.Debug, DateTime.Now, "Other module", "Hallo!"));
logger.Log(new Log(Severity.Information, DateTime.Now, "Main", "Program terminated"));
```

### Logging to console and file
```
var format = new DefaultFormat();
            
var fileStream = File.OpenWrite("log.txt");
var fileOutput = new StreamOutput(fileStream, format);

var consoleStream = Console.OpenStandardOutput();
var consoleOutput = new StreamOutput(consoleStream, format);

var logger = new Logger();
logger.AddOutput(fileOutput);
logger.AddOutput(consoleOutput);

logger.Log(new Log(Severity.Debug, DateTime.Now, "Main", "Program started"));
logger.Log(new Log(Severity.Notice, DateTime.Now, "Other module", "Hallo!"));
logger.Log(new Log(Severity.Information, DateTime.Now, "Main", "Program terminated"));
```

## Security
There is a minimum-security check implemented that will throw an exception if you did not specify any output to the log.

## Collaborations
Please feel free to open an issue if you find that this could be enhanced in any way! Thank you very much for visiting my GitHub! :heart: