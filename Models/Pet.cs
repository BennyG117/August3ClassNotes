//! add to top of Model pages to temp disable the warning*
#pragma warning disable CS8618

namespace August3ClassNotes.Models;

//adding get set allows the class field to be edited
public class Pet
{
    public string Name {get; set;}
    public string Species {get; set;}
    public bool IsFriendly {get; set;}
    public int Age {get; set;}
}



