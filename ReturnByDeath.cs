using System.Net.Http.Headers;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;

using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;

using Terraria.UI;
using Terraria.IO;


namespace ReturnByDeath
{
	public class ReturnByDeath : ModPlayer
	{
        public ReturnByDeath()
        {
            
        }

        public override bool OnPickup(Item item)
        {
            if(item.Name == "Dirt Block")
            {
                if(System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr"))
                {
                    if(System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");                   
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                    }

                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                    }

                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                    }

                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                    }

                }

             Main.LocalPlayer.HealEffect(50);
                return base.OnPickup(item);
            }
            return base.OnPickup(item);
        }

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            //PlayerFileData playerFile = Player.GetFileData("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr", false);
            //Player.SavePlayer(playerFile, true);
            //System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr");
            //System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr.bak");
           // System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr");
            //System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr.bak");
            
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString());
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\BEans.plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr.bak");
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\BEans.tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr");
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\BEans.tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr.bak");
            //Player.LoadPlayer("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr", false);
            //Player.FixLoadedData();
            //WorldFile.SaveWorld();
            //Main.WorldPath = "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\The_Underwear_of_Carnage.wld";
            //WorldFile.LoadWorld(false);
            //WorldFile.SaveWorld();

            //Player.FixLoadedData();
            Main.LocalPlayer.HealEffect(50);

            //Player.SavePlayer("BEans.plr", false);
            //base.Kill(damage, hitDirection, pvp, damageSource);
        }
       

    }
}