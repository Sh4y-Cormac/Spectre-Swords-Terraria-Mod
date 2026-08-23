using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using SpectreSwords.Content.Items.Materials;
using SpectreSwords.Content.Projectiles;

namespace SpectreSwords.Content.Items.Weapons.Magic
{
    public class GordonStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.staff[Item.type] = true;
        }


        public override void SetDefaults()
        {
            // Helper method to quickly set basic magic weapon properties
            Item.DefaultToMagicWeapon(
                projType: ModContent.ProjectileType<ElectromagneticBolt>(), // Our own projectile
                singleShotTime: 35, // useTime & useAnimation
                shotVelocity: 9f,
                hasAutoReuse: true
                );
            
            Item.damage = 45;
            Item.knockBack = 10f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item94; // Some electric sound
            Item.mana = 10; // This item uses 10 mana
            Item.width = Item.height = 40;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CardDeck>(8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}