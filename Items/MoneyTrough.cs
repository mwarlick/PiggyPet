using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace PiggyPet.Items
{
	public class MoneyTrough : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            //    if (item.type == ItemID.MoneyTrough)
            //    {
            //        item.buffType = BuffType<Buffs.PiggyBankBuff>();
            //    }
        }

    //public override void UseStyle(Item item, Player player)
    //{
    //    if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
    //    {
    //        player.AddBuff(item.buffType, 3600, true);
    //    }
    //}

    }
}

