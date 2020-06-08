using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public class Movies
    {
        // Mock Data

        string name = "Rick";
        int numOfTimes = 4;

        public string GetMockDataName()
        {
            return name;
        }

        public int GetMockDataNumTimes()
        {
            return numOfTimes;
        }
    }
}
