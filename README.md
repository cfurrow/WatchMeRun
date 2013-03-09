# WatchMeRun

A simple file-watcher that runs a command when the file has changed.

## TOML!

Config files are written in TOML and are expected to be named "app.toml" and
for that file to be located in the same directory as the WatchMeRun.exe file.

## Example

    [directories]
      [directories.test]
        path    = "c:\\directory" #1
        watch   = "watchme"       #2
        run     = "runme.bat"     #3
  

1. The working directory to watch/run files in.
2. The file to watch for modifications. When it's LastWriteDateUtc changes, run the "run" command
3. The command to run when file #2 is changed/modified/touched

Just run WatchMeRun.exe with the above app.toml in the same directory, and it'll do the rest.

At least it should.

## Why?

I wanted a quick way to build/deploy/test from OSX and MacVim on my Parallels VM which
has ASP.NET MVC 3, IIS 7.5, etc installed. My particular project couldn't
port to Mono (easily?) so I keep with what works. I use MacVim as my IDE, and build/run
in Parallels against various IE browsers, etc. Maybe you'll find this interesting. Maybe
not. Oh well.
