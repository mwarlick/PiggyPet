using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PiggyPet.Projectiles.Pets
{
    public class FlyingPiggyBank : GlobalProjectile
    {
        public override void PostAI(Projectile projectile)
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 15f) 
                //This if switches between AI states -- 97 for default flying pig animation and 11 for Shadow Ball pet AI --
            {
                // Quarter second has passed. Reset timer, etc.
                projectile.ai[0] = 0f;
                projectile.netUpdate = true;
                projectile.aiStyle = 11; //Basically, catches up w/ the player every quarter sec
            } else {
                projectile.aiStyle = 97; //Otherwise, continue the flying pig AI
            }
            projectile.rotation = 0; // This just stops the rotation that the shadow ball has
            base.PostAI(projectile);
        }
    }
}