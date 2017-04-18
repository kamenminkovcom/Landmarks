using System.Collections.Generic;
using System.Linq;
using DeltaDucks.Data.IInfrastructure;
using DeltaDucks.Models;

namespace DeltaDucks.Data.IRepositories
{
    public interface ILandmarkRepository : IRepository<Landmark>
    {
        Landmark GetLandmarkById(int id);
        Landmark GetLandmarkByName(string landmarkName);
        Landmark GetLandmarkByNumber(int number);
       // IEnumerable<Landmark> GetPageOfLendmarks(int take, int skip);
        IEnumerable<Landmark> GetUserVisitedLandmarks(string id);
        IEnumerable<Landmark> GetUserNotVisitedLandmarks(string id);
        void IncreaseVisits(int id);
    }
}