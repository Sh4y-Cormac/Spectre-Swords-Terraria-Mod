using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using SpectreSwords.Content.Items.Materials;

namespace SpectreSwords.Content.Items.Tools
{
    public class MoonAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.scale = 2f;

            Item.useTime = 15;
            Item.useAnimation = 13;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 9;
            Item.knockBack = 2f;

            Item.value = 10000;
            Item.rare = ItemRarityID.Green;

            Item.axe = 15;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 8)
                .AddIngredient(ModContent.ItemType<MoonTablet>(), 6)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}