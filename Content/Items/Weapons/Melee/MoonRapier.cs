using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using SpectreSwords.Content.Projectiles.Melee;

namespace SpectreSwords.Content.Items.Weapons.Melee
{
    public class MoonRapier : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            Item.height = 24;
            Item.width = 24;

            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 17;
            Item.knockBack = 4f;

            Item.rare = ItemRarityID.Green;
            Item.value = 100000;

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<MoonBlast>();


        }
    }
}