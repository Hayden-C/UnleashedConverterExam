# Currency To English Words - Unleashed Software Test

An ASP.NET web application that can convert a number to an English word currency representation.

## Running instructions

This solution requires [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)

I have tested and ran this application using Visual Studio 2019 on a Windows Machine using IIS express and the Google Chrome web browser. Any platform that can run .NET Core web applications should be able to run this project, however I have not tested them.

## Usage

From the home page of the web application enter a number into the input box and press enter. This will show the English word representation of the number below the input.

## Assumptions & Limitations
For this test I assumed it was OK to use the NuGet package "Humanizer" to convert decimal values to English words, and completed the task this way as it was a safer and faster way to get the job done. If this is unacceptable I am happy to write my own method to perform this conversion.

I did not match the title case text that was given in the example output from the original spec, I assumed this was unimportant for the result and decided not to spend the time adding it.

I assumed that the a number greater than the max long value `9223372036854775807` would not need to be converted. 

The word `minus` is appended before any negative numbers. 

If no decimal value is provided then only a dollar amount will be displayed

If there is no dollar value a `Zero Dollars` string will be shown