using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Build.Evaluation;

namespace SpectreSwords.Content.Projectiles.Melee
{
    public class MoonBlast : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.height = 16;
            Projectile.width = 16;

            Projectile.friendly = true;
            Projectile.penetrate = 3;
            Projectile.tileCollide = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 300;

            Projectile.aiStyle = ProjAIStyleID.ShortSword;
        }

        public override void AI()
        {
            base.AI();

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            DrawOriginOffsetX = 0;
            DrawOffsetX = -((24 / 2) - halfProjWidth);
            DrawOriginOffsetY = -((24 / 2) - halfProjHeight);
        }

    }
}