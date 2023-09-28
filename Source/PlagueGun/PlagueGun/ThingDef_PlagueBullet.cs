using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace AJ.PlagueGun
{
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float AddHediffChance = 0.05f; //The default chance of adding a hediff
        public HediffDef HediffToAdd = HediffDefOf.Plague;
    }
}
