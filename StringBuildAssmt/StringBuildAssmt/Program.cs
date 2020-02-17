using System;
using System.Text;
//using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string crazyAcronym1 = "satb";                 // Strings Are The Best
        string a1 = crazyAcronym1.ToUpper();
        string crazyAcronym2 = "santb";                // Strings are not the best
        string a2 = crazyAcronym2.ToUpper();
        string badGuy = "Bigote";
        string goodGuy = "Pickles";
        Console.WriteLine("The following documents the struggle between " + goodGuy + " with the " + a1 + " and " 
            + badGuy + " with the " + a2 + ":");

        StringBuilder story = new StringBuilder();       // *Needs "using System.Text;" at top
        story.Append("\n\n\t" + goodGuy + " woke up with a headache.");
        story.Append("The last thing he remembers was being at a " + a1 + "(strings are the best) meeting.");
        story.Append(" It turns out that the " + a2 + "(strings are NOT the best) showed up and their leader, " + badGuy + ", started a physical altercation.");
        story.Append(" Apparently, after the " + a2 + " left, though, their members had a change of heart.");
        story.Append(" They joined the " + a1 + " and they are now 12 members strong today.");
        Console.WriteLine(story);
        Console.Read();
    }
}
