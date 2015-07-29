##FakeSmtp

A C# console app that simulates an smtp server and save emails as html files. This is a very lightweight tool and therefore does not contain all the features of a full-fledged smtp server.

The source code is setup as a Visual Studio 2010 solution and does not have any external dependencies outside of Microsoft's .NET 4 Framework

The base source for FakeSmtp comes from various free sources available on the net (sorry, it was awhile ago and I didn't keep track) combined with some new features, such as the saving of each email to a html file.

##Usage

FakeSmtp is very easy to use, just double click the executable or run it from a command line. By default, emails are formatted in HTML and written to disk.

To use FakeSmtp purely from the console and prevent files from being written to disk, use the `--no-files` command line argument.

The tool listens on port 25 for email messages.

## License
Released under the [MIT license](http://www.opensource.org/licenses/MIT).

## Retard
I'm exercising my free speech by saying that this program is so easy a retard could use it.
