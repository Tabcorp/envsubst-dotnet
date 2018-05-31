# envsubst-dotnet
## Environment variables substitution in C# for .NET

This tool will do in-place replacement for environment variables in the given file.
The environment variable format is `%NAME%` following Windows convention.
It is a replacement for **[GNU envsubst](https://www.gnu.org/software/gettext/manual/html_node/envsubst-Invocation.html)** for Windows.

It can be useful for Windows docker to substitute configuration files with the environment variables during bootstrap.

## Usage

```
envsubst.exe <file>
```

## Example

This example runs under Mac using mono

```
$ cat example.txt
Hello %WORLD%!

# If environment variable is undefined, leave it as is. The result is echoed back.
$ mono download/envsubst.exe example.txt
Hello %WORLD%!

# Define environment variable this time and try again
$ export WORLD=World
$ mono download/envsubst.exe example.txt
Hello World!

# The text file has been updated
$ cat example.txt
Hello World!
```

## Download

[Binary compiled with .NET Framework v4.6.1](download/envsubst.exe)
