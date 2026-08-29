using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace SpectreSwords.Content.Items.Materials
{
    public class MoonTablet : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999; // How many items can be in one inventory slot
            Item.value = 1400; // Item sell price in copper coins
            Item.rare = ItemRarityID.Green;
        }
    }
}