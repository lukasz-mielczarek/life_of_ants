using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts.Logic.Actors
{
    public class Worker:Ant
    {
        public Worker(Cell cell) : base(cell) { }


        public override bool IsNotPassable => true;

        public override char Symbol => 'W';

        public override void GenerateAnts(ref HiveMap map)
        {
            throw new NotImplementedException();
        }

        public override Tuple<int, int> PlanMove()
        {
            throw new NotImplementedException();
        }
    }
}
