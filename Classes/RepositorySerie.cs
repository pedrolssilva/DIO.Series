using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  public class RepositorySerie : IRepository<Serie>
  {
    private List<Serie> serieList = new List<Serie>();
    public void Delete(int id)
    {
      serieList[id].Delete();
    }

    public void Insert(Serie @object)
    {
      serieList.Add(@object);
    }

    public List<Serie> List()
    {
      return serieList;
    }

    public int NextId()
    {
      return serieList.Count;
    }

    public Serie ReturnById(int id)
    {
      return serieList[id];
    }

    public void Update(int id, Serie @object)
    {
      serieList[id] = @object;
    }
  }
}