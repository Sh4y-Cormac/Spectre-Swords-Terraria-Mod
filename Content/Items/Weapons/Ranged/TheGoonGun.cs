using Microsoft.Xna.Framework;
using SpectreSwords.Content.Items.Materials;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpectreSwords.Content.Items.Weapons.Ranged
{
    public class TheGoonGun : ModItem
    {
        public override void SetDefaults()
        {
            // Visual properties
            Item.width = 40;
            Item.height = 40;
            Item.scale = 1.00f;
            Item.useStyle = ItemUseStyleID.Shoot; // Use style for guns
            Item.rare = ItemRarityID.Blue;

             // Combat properties
            Item.damage = 40; // Gun damage + bullet damage = final damage
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = 10; // Delay between shots.
            Item.useAnimation = 30; // How long shoot animation lasts in ticks. We made it 3 times larger than useTime to make gun fire thrice
            Item.reuseDelay = 25; // How long the gun will be unable to shoot after useAnimation ends
            Item.consumeAmmoOnLastShotOnly = true; // Gun will consume only one ammo per a burst of shots
            Item.knockBack = 9.0f; // Gun knockback + bullet knockback = final knockback
            Item.autoReuse = false;

              // Other properties
            Item.value = 10000;
            Item.UseSound = SoundID.Item11; // Gun use sound

             // Gun properties
            Item.noMelee = true; // Item not dealing damage while held, we don’t hit mobs in the head with a gun
            Item.shoot = ProjectileID.PurificationPowder; // What kind of projectile the gun fires, does not mean anything here because it is replaced by ammo
            Item.shootSpeed = 16f; // Speed of a projectile. Mainly measured by eye
            Item.useAmmo = AmmoID.Bullet; // What ammo gun uses
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CardDeck>(9)
                .AddTile(TileID.Anvils)
                .Register();    

        }

        public override Vector2? HoldoutOffset() => new Vector2(-4f, 0f); // Offset in pixels at which the player will hold the gun. -Y is up

        public override bool CanConsumeAmmo(Item ammo, Player player) => Main.rand.Next(101) <= 50; // Chance in % to not consume ammo

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(10)); // Creating some shoot inaccuracy

            int NumProjectiles = Main.rand.Next(4, 8); // Our gun will be able to shoot 1-3 projectiles a shot.

            for (int i = 0; i < NumProjectiles; i++)
            {
                // New velocity for new bullets
                Vector2 NewVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(10));

                // Some random to bullet speed
                NewVelocity *= 1f - Main.rand.NextFloat(0.2f);

                // Our gun has a 1/5 chance to replace default bullets with silver ones
                if (Main.rand.NextBool(5))
                {
                    type = ProjectileID.CrystalBullet;
                }

                // Creating new projectile
                Projectile.NewProjectileDirect(
                    source,
                    position,
                    NewVelocity,
                    type,
                    damage,
                    knockback,
                    player.whoAmI
                    );
            }
            return true; // return true to allow gun to shoot
        }
    }
}