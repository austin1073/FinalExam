using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Models
{
    public interface IEntertainerRepository
    {
        IQueryable<Entertainer> Entertainers { get; }
        void AddEntertainer(Entertainer entertainer);
        void DeleteEntertainer(int id);
        void UpdateEntertainer(int id, Entertainer entertainer);
        Entertainer GetEntertainerById(int id);
    }
}
