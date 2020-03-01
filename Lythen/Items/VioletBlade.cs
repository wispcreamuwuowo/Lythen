using Terraria.ID;
using Terraria.ModLoader;

namespace Lythen.Items
{
	public class VioletBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("VioletBlade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The purple orb, resonates energy to the Terrarian.");
		}

		public override void SetDefaults() 
		{
			item.damage = 36;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 400;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = (-12);
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 25);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}