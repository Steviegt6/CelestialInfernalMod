using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class RoyalMushroomSlime : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 24;
            npc.damage = 10;
            npc.defense = 5;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 50f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 1;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 1f;
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Mushroom, Main.rand.Next(2, 5));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, Main.rand.Next(1, 4));
        }
    }
}
