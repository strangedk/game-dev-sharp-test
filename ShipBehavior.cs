using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestingTaskFramework;
using VRageMath;

namespace TestingTask
{
    // TODO: Modify 'OnUpdate' method, find asteroids in World (property Ship.World) and shoot them.
    class ShipBehavior : IShipBehavior
    {
        /// <summary>
        /// The ship which has this behavior.
        /// </summary>
        public Ship Ship { get; set; }

        /// <summary>
        /// Called when ship is being updated, Ship property is never null when OnUpdate is called.
        /// </summary>
        public void OnUpdate()
        {
            Ship.Shoot(Vector3.Forward);
        }
    }
}
