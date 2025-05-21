using System;

namespace EsportManager.Models;

public class Tournament
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Entry {get; set;}
    public decimal Prize { get; set; }
    public int MinSkillRequired { get; set; }
}