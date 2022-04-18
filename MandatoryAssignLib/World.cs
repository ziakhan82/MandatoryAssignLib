using MandatoryAssignLib.Interfaces;
using System;
using System.Diagnostics;

namespace MandatoryAssignLib
{
    public class World:IWorld
    {

        public int maxX { get; set; }
        public int maxY { get; set; }

        public World()
        {
                
        }
        private  void GetConFig()
        {
            Configuration.ReadConfiguration();
            Configuration.MaxWorld = maxX;
            Configuration.MinWorld = maxY;

            Tracing.log(TraceEventType.Information,message:"The World was created with x and y values");
        }


    }
}
