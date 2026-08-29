using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using SpectreSwords.Content.Items.Materials;

namespace SpectreSwords.Content.Items.Weapons.Melee
{
    public class Katamoon : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.scale = 2f;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15; // How long the swing lasts in ticks (60 ticks = 1 second)
            Item.useAnimation = 15; // How long the swing animation lasts in ticks (60 ticks = 1 second)
            Item.autoReuse = true; // Can the item auto swing by holding the attack button

            Item.DamageType = DamageClass.Melee;
            Item.damage = 15;
            Item.knockBack = 3f; // How far the sword punches enemies, 20 is maximal value
            Item.crit = 5;

            Item.value = Item.buyPrice(gold: 5, silver:80);
            Item.rare = ItemRarityID.Green;

            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<MoonTablet>(10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}