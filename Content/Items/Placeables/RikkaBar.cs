using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace SpectreSwords.Content.Items.Placeables
{
    public class RikkaBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
            ItemID.Sets.SortingPriorityMaterials[Type] = 76; // The higher the value, the higher it sorts in the inventory
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(silver: 12);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 16;
            Item.useTime = 10;
            Item.useTurn = true;
            Item.autoReuse = true; 

            Item.createTile = ModContent.TileType<Tiles.RikkaBars>();
            Item.placeStyle = 0;

        }
    }

}        