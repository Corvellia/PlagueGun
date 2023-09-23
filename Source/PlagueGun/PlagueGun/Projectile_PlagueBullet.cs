using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plague
{
    public class Projectile_PlagueBullet : Bullet
    {
        #region Properties

        public ThingDef_PlagueBullet Def
        {
            get
            {
                return this.def as ThingDef_PlagueBullet;
            }
        }

        #endregion Properties
    }
}
