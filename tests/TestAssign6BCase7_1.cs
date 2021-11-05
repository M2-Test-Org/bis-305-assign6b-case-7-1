using Xunit;
using System.IO;
using System;
using System.Text;

public class TestAssign6BCase7_1
{

    [Fact]
    public void TestCase()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var lastYearInput = "2";
        var thisYearInput = "3";
        var contestant1Name = "Jill";
        var contestant1TalentCode = "S";
        var contestant2Name = "Mikia";
        var contestant2TalentCode = "M";
        var contestant3Name = "Sarah";
        var contestant3TalentCode = "D";
        var endInput = "Z";
        //separte multiple inputs with a new line break
        var stringReaderInput = new StringBuilder();
        stringReaderInput.Append(lastYearInput);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(thisYearInput);
        stringReaderInput.Append(Environment.NewLine);
        //contestant 1
        stringReaderInput.Append(contestant1Name);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(contestant1TalentCode);
        stringReaderInput.Append(Environment.NewLine);
        //contestant 2
        stringReaderInput.Append(contestant2Name);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(contestant2TalentCode);
        stringReaderInput.Append(Environment.NewLine);
        //contestant 3
        stringReaderInput.Append(contestant3Name);
        stringReaderInput.Append(Environment.NewLine);
        stringReaderInput.Append(contestant3TalentCode);
        stringReaderInput.Append(Environment.NewLine);
        //end input
        stringReaderInput.Append(endInput);

        var input = new StringReader(stringReaderInput.ToString());
        Console.SetIn(input);
        
        GreenvilleRevenue.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter number of contestants last year >> ");
        expectedOutcome.Append("Enter number of contestants this year >> ");
        expectedOutcome.AppendLine(string.Format("Last year's competition had {0} contestants, and this year's has {1} contestants",lastYearInput, thisYearInput));
        expectedOutcome.AppendLine("Revenue expected this year is $75.00");
        expectedOutcome.AppendLine("The competition is bigger than ever!");
        expectedOutcome.Append("Enter contestant name >> ");
        expectedOutcome.AppendLine("Talent codes are:");
        expectedOutcome.AppendLine("  S   Singing");
        expectedOutcome.AppendLine("  D   Dancing");
        expectedOutcome.AppendLine("  M   Musical instrument");
        expectedOutcome.AppendLine("  O   Other");
        expectedOutcome.Append("       Enter talent code >> ");
        expectedOutcome.Append("Enter contestant name >> ");
        expectedOutcome.AppendLine("Talent codes are:");
        expectedOutcome.AppendLine("  S   Singing");
        expectedOutcome.AppendLine("  D   Dancing");
        expectedOutcome.AppendLine("  M   Musical instrument");
        expectedOutcome.AppendLine("  O   Other");
        expectedOutcome.Append("       Enter talent code >> ");
        expectedOutcome.Append("Enter contestant name >> ");
        expectedOutcome.AppendLine("Talent codes are:");
        expectedOutcome.AppendLine("  S   Singing");
        expectedOutcome.AppendLine("  D   Dancing");
        expectedOutcome.AppendLine("  M   Musical instrument");
        expectedOutcome.AppendLine("  O   Other");
        expectedOutcome.Append("       Enter talent code >> ");
        expectedOutcome.AppendLine("The types of talent are:");
        expectedOutcome.AppendLine("Singing                   1");
        expectedOutcome.AppendLine("Dancing                   1");
        expectedOutcome.AppendLine("Musical instrument        1");
        expectedOutcome.AppendLine("Other                     0");
        //expectedOutcome.AppendLine("");
        expectedOutcome.Append("Enter a talent type or Z to quit >> ");
        //Enter a talent type or Z to quit >>
        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }
}
