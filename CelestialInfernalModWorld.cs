  
using System;
using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;
using Terraria.Utilities;


namespace CelestialInfernalMod
{
    public class CelestialInfernalModWorld : ModWorld
    {
        public static bool downedGrandSlime;
        public static bool downedMushroomKing;
        public static bool downedEnragedDemon;
        public static bool downedPutridCoagulation;
        public static bool downedHigherPixie;
        public static bool downedMossMonarch;
        public static int sizeMult = (int)(Math.Round(Main.maxTilesX / 4200f)); //Small = 2; Medium = ~3; Large = 4;

        public override void Initialize()
        {
            sizeMult = (int)(Math.Floor(Main.maxTilesX / 4200f));
            downedGrandSlime = false;
            downedMushroomKing = false;
            downedEnragedDemon = false;
            downedPutridCoagulation = false;
            downedHigherPixie = false;
            downedMossMonarch = false;

        }

        public override void Load(TagCompound tag)
        {
            IList<string> downed = tag.GetList<string>("downed");
            downedGrandSlime = downed.Contains("GrandSlime");
            downedMushroomKing = downed.Contains("MushroomKing");
            downedEnragedDemon = downed.Contains("EnragedDemon");
            downedPutridCoagulation = downed.Contains("PutridCoagulation");
            downedHigherPixie = downed.Contains("HigherPixie");
            downedMossMonarch = downed.Contains("MossMonarch");
        }

        public override TagCompound Save()
        {
            TagCompound tag = new TagCompound();
            var downed = new List<string>();
            bool obs = false;
            int pwr = 0;
            if (downedGrandSlime) downed.Add("GrandSlime");
            if (downedMushroomKing) downed.Add("MushroomKing");
            if (downedEnragedDemon) downed.Add("EnragedDemon");
            if (downedPutridCoagulation) downed.Add("PutridCoagulation");
            if (downedHigherPixie) downed.Add("HigherPixie");
            if (downedMossMonarch) downed.Add("MossMonarch");
            

            return new TagCompound {
                {"downed", downed},
            };
            return tag;
        }
        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = downedGrandSlime;
            flags[1] = downedMushroomKing;
            flags[2] = downedEnragedDemon;
            flags[3] = downedPutridCoagulation;
            flags[4] = downedHigherPixie;
            flags[5] = downedMossMonarch;

            writer.Write(flags);
        }
        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            downedGrandSlime = flags[0];
            downedMushroomKing = flags[1];
            downedEnragedDemon = flags[2];
            downedPutridCoagulation = flags[3];
            downedHigherPixie = flags[4];
            downedMossMonarch = flags[5];
        }
	}
}