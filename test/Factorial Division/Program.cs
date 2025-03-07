using System.Threading.Channels;

internal class Team
{
    public Team(string name, string creatorName)
    {
        this.Name = name;
        this.Creator = creatorName;
    }

    public string Name { get; set; }
    public string Creator { get; set; }

    public List<string> Members { get; set; }

    public override string ToString()
    {
        return $"{Name}/n" + $"- {Creator}" + $"-- {GetMembersString()}";
    }

    private string GetMembersString()
    {
        Members = Members
            .OrderBy(name => name)
            .ToList();

        string result = "";

        for (int i = 0; i < Members.Count - 1; i++)
        {
            result += $"-- {Members[i]}/n";
        }

        result += $"-- {Members[Members.Count - 1]}/n";

        return result;
    }
}

internal class program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Team> teams = new List<Team>();

        for (int i = 0; i < n; i++)
        {
            string[] teamCommands = Console.ReadLine().Split("-");
            string teamName = teamCommands[1];
            string creatorName = teamCommands[0];

            Team team = new Team(teamName, creatorName);
            Team sameTeamFound = teams.Find(t => t.Name == team.Name);
            Team sameCreatorFound = teams.Find(t => t.Creator == creatorName);

            if (sameTeamFound != null)
            {
                Console.WriteLine($"Team {team.Name} was already created!");
                continue;
            }

            teams.Add(team);

            Console.WriteLine($"Team {team.Name} has been created by {team.Creator}");
        }
    }
}