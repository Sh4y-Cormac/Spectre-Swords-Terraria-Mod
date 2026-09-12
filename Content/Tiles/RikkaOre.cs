using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Net.Http.Headers;
using Terraria.GameContent.ItemDropRules;
using Terraria.Audio;

namespace SpectreSwords.Content.Tiles
{
    public class RikkaOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true; // adds this into the sets of ore in the game

            Main.tileSolid[Type] = true; // does this block have collision or not. (furniture no collision)
            Main.tileMergeDirt[Type] = true; //will use dirt-mixing textures when merging with dirt
            Main.tileBlockLight[Type] = true; // allows light to pass through or not
            Main.tileShine[Type] = 900; // frequency of dust particles when mining it
            Main.tileShine2[Type] = true; // 
            Main.tileSpelunker[Type] = true; // will shine when using spelunker
            Main.tileOreFinderPriority[Type] = 350; // the priority when using Metal Detector, higher value = higher

            AddMapEntry(new Color(200, 200, 200), CreateMapEntryName());

            DustType = DustID.MagicMirror;
            // ItemDrop = ModContent.ItemType<Items.Placeables.RikkaOre>();
            // SoundType = SoundID.Tink;
            HitSound = SoundID.Tink;

            MineResist = 1.5f;
            MinPick = 60;
            


        }
    }
}