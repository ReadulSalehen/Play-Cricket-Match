using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketMatch
{
    public class OverInfo
    {
        public int Id { get; set; }
        public int TotalBall { get; set; }
        public int PlayerId { get; set; }
        public List<BallInfo> BallInfos { get; set; }

        public OverInfo()
        {
            this.TotalBall = 6;
            this.BallInfos = new List<BallInfo>();
        }

    }
}
