using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.Localization;

namespace SpectreSwords.Content.Tiles
{
    public class RikkaBars : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileShine[Type] = 1100;
            Main.tileFrameImportant[Type] = true; 

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(200, 200, 200), Language.GetText("MapObject.MetalBar"));

        }


        public override IEnumerable<Item> GetItemDrops(int x, int y)
        {
            Tile t = Main.tile[x, y];
            int style = t.TileFrameX / 18; 

            switch (style)
            {
                case 0:
                    yield return new Item(ModContent.ItemType<Items.Placeables.RikkaBar>());
                    break;
                case 1:
                    // yield return new Item(ModContent.ItemType<Items.Placeables.YourNewBar>());
                    break;
            }
            
        }

        /*
        public override bool Drop(int x, int y)
        {
            Tile t = Main.tile[x, y];
            int style = t.TileFrameX / 16; 

            switch(style)
            {
                case 0: Item.NewItem(new EntitySource_TileBreak(x,y), x * 16, y * 16, 16, 16, ModContent.ItemType<Items.Placeables.TutorialBar>()); break;
                case 1:
                    // ADD NEW ITEM
                    break; 
            }
            
            return base.Drop(x,y);
        }
        */
    }
}