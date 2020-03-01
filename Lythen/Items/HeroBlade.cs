using Terraria.ID;
using Terraria.ModLoader;

namespace Lythen.Items
{
	public class HeroBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("HeroBlade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A legendary dragon slayer used to wield this blade.");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 75;
			item.useAnimation = 1;
			item.useStyle = 25;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.GoldBroadsword, 1);
			recipe.AddIngredient(ItemID.GoldShortsword, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}