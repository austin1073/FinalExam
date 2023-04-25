using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Models
{
    public class EFEntertainerRepository : IEntertainerRepository
    {
        private EntertainmentAgencyExampleContext context {get;set;}

        public EFEntertainerRepository (EntertainmentAgencyExampleContext temp)
        {
            context = temp;
        }

        public IQueryable<Entertainer> Entertainers => context.Entertainers;

        public void AddEntertainer(Entertainer entertainer)
        {
            context.Entertainers.Add(entertainer);
            context.SaveChanges();
        }

        public Entertainer GetEntertainerById(int id)
        {
            return context.Entertainers.FirstOrDefault(e => e.EntertainerId == id);
        }

        public void DeleteEntertainer(int id)
        {
            Entertainer entertainer = context.Entertainers.Find(id);
            context.Entertainers.Remove(entertainer);
            context.SaveChanges();
        }

        public void UpdateEntertainer(int id, Entertainer entertainer)
        {
            Entertainer oldEntertainer = context.Entertainers.Find(id);

            if (oldEntertainer != null)
            {
                oldEntertainer.EntStageName = entertainer.EntStageName;
                oldEntertainer.EntSsn = entertainer.EntSsn;
                oldEntertainer.EntStreetAddress = entertainer.EntStreetAddress;
                oldEntertainer.EntCity = entertainer.EntCity;
                oldEntertainer.EntState = entertainer.EntState;
                oldEntertainer.EntZipCode = entertainer.EntZipCode;
                oldEntertainer.EntPhoneNumber = entertainer.EntPhoneNumber;
                oldEntertainer.EntEmailAddress = entertainer.EntEmailAddress;

                context.SaveChanges();
            }
        }




    }
}
