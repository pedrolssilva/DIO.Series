using System;

namespace DIO.Series
{
  public class Serie : BaseEntity
  {
    private Gender Gender { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Year { get; set; }
    private bool Deleted { get; set; }

    public Serie(int id, Gender gender, string title, string description, int year)
    {
      this.Id = id;
      this.Gender = gender;
      this.Title = title;
      this.Description = description;
      this.Year = year;
      this.Deleted = false;
    }

    public override string ToString()
    {
      string toString = string.Empty;
      toString += "Gender:" + this.Gender + Environment.NewLine;
      toString += "Title:" + this.Title + Environment.NewLine;
      toString += "Description:" + this.Description + Environment.NewLine;
      toString += "StartYear:" + this.Year + Environment.NewLine;
      toString += "Deleted:" + this.Deleted + Environment.NewLine;
      return toString;
    }

    public string GetTitle()
    {
      return this.Title;
    }

    public int getId()
    {
      return this.Id;
    }

    public void Delete()
    {
      this.Deleted = true;
    }

    public bool GetDeleted(){
      return this.Deleted;
    }

  }
}