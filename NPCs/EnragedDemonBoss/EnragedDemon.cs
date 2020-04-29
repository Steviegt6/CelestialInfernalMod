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
using CelestialInfernalMod.Projectiles.Boss;

namespace CelestialInfernalMod.NPCs.EnragedDemonBoss
{
    [AutoloadBossHead]
    public class EnragedDemon : ModNPC
    {
        private Player player;
        private float speed;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enraged Demon");
            Main.npcFrameCount[npc.type] = 14;
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 3600;
            npc.damage = 30;
            npc.defense = 12;
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
            npc.value = 10000;
            npc.npcSlots = 1f;
            npc.boss = true;
            bossBag = mod.ItemType("TwoHeadedDemonBag");
            npc.lavaImmune = true;
            npc.onFire = false;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[24] = true;
            npc.buffImmune[31] = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss1;
        }

        public override void AI()
        {
            Target();

            DespawnHandler();

            Move(new Vector2(0, -100f));

            npc.ai[1]++;
            
            if (npc.ai[1] >= 140)
            {
                int DemonAttack = Main.rand.Next(3);
				switch (DemonAttack)
				{
					case 0:
					if (npc.ai[1] % 40 == 0)
					{
						NPC.NewNPC((int)npc.Center.X + 20, (int)npc.Center.Y, NPCID.Demon);
					}
					if (npc.ai[1] == 180)
					{    
						npc.ai[1] = 0;
					}
					break;
				case 1:
					if (npc.ai[1] % 14 == 0)
					{
						float Speed = 5f;
						Vector2 vector8 = new Vector2(npc.position.X + (npc.width), npc.position.Y + (npc.height / 2));
						int damage = 25;
						int type = ModContent.ProjectileType<EnragedScythe>();
						Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 1);
						float rotation = (float)Math.Atan2(vector8.Y - (player.position.Y + (player.height * 0.5f)), vector8.X - (player.position.X + (player.width * 0.5f)));
						int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
					}
					if (npc.ai[1] >= 180)
					{    
						npc.ai[1] = 0;
					}
					break;
				case 2:
					if (npc.ai[1] % 20 == 0)
					{
						float SickleSpeed = 8f;
						Vector2 vector9 = new Vector2(npc.position.X + (npc.width), npc.position.Y + (npc.height / 2));
						int SickleDamage = 20;
						int SickleType = ProjectileID.DemonSickle;
						Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 8);
						float SickleRotation = (float)Math.Atan2(vector9.Y - (player.position.Y + (player.height * 0.5f)), vector9.X - (player.position.X + (player.width * 0.5f)));
						int num55 = Projectile.NewProjectile(vector9.X, vector9.Y, (float)((Math.Cos(SickleRotation) * SickleSpeed) * -1), (float)((Math.Sin(SickleRotation) * SickleSpeed) * -1), SickleType, SickleDamage, 0f, 0);
					}
					if (npc.ai[1] >= 180)
					{    
						npc.ai[1] = 0;
					}
					break;
				}
                
                if (npc.ai[1] >= 180)
                {    
					npc.ai[1] = 0;
                }
            }
        }
        private void Target()
        {
            player = Main.player[npc.target];
        }

        private void Move(Vector2 offset)
        {
            speed = 5f;
            Vector2 moveTo = player.Center + offset;
            Vector2 move = moveTo - npc.Center;
            float magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            float turnResistance = 10f;
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }

        private void DespawnHandler()
        {
            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if (!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -10f);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                }
                return;
            }
        }
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter++;
            if (npc.ai[1] >= 140)
            {
                if (npc.frameCounter < 7) {
					npc.frame.Y = 2 * frameHeight;
				}
				else if (npc.frameCounter < 10) {
					npc.frame.Y = 4 * frameHeight;
				}
				else if (npc.frameCounter < 14) {
					npc.frame.Y = 5 * frameHeight;
				}
                else if (npc.frameCounter < 20) {
					npc.frame.Y = 7 * frameHeight;
				}
				else {
					npc.frameCounter = 0;
				} 
            }
            else
            {
                if (npc.frameCounter < 10) {
					npc.frame.Y = 0 * frameHeight;
				}
				else if (npc.frameCounter < 20) {
					npc.frame.Y = 1 * frameHeight;
				}
				else {
					npc.frameCounter = 0;
				} 
            }
        }
        public override void NPCLoot()
        {
            if(!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TwoHeadedDemonBag"));
            }
            else
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DemonFlesh"), Main.rand.Next(12, 16));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Hellstone, Main.rand.Next(15, 24));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Obsidian, Main.rand.Next(15, 24));
            }
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DemonicScythe"), Main.rand.Next(1, 2));
        }
    }
}
