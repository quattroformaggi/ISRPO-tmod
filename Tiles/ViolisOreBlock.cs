using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Tiles
{
    public class ViolisOreBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLavaDeath[Type] = true;

            drop = ItemType<Items.ViolisOre>();
            dustType = DustID.Demonite;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Violis");
            AddMapEntry(Color.DarkViolet, name);
            minPick = 80;
        }
    }
}
