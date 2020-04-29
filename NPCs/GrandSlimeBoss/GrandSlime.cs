using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialInfernalMod.NPCs.GrandSlimeBoss
{
    [AutoloadBossHead]
    public class GrandSlime : ModNPC
    {
        private Player player;
        private float speed;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grand Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void SetDefaults()
        {
            npc.aiStyle = 1;
            npc.lifeMax = 1000;
            npc.damage = 24;
            npc.defense = 0;
            npc.knockBackResist = 0f;
            npc.width = 50;
            npc.height = 40;
            npc.value = 3000;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            aiType = NPCID.BlueSlime;
            npc.scale = 1.5f;
            animationType = NPCID.BlueSlime;
            npc.DeathSound = SoundID.NPCDeath1;
            music = 4;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.7f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }
        public override void NPCLoot()
        {
            if(Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PixelBox);
            }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, Main.rand.Next(25, 50));
                int GrandLoot = Main.rand.Next(5);
            switch (GrandLoot)
            {
                case 0:
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SlimeStaff, Main.rand.Next(1, 2));
                break;
                case 1:
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SlimySword"), Main.rand.Next(1, 2));
                break;
                case 2:
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SlimyBow"), Main.rand.Next(1, 2));
                break;
                case 3:
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SlimyWand"), Main.rand.Next(1, 2));
                break;
                case 4:
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StickyBomb, Main.rand.Next(10, 50));
                break;
            }
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }
    }
}
