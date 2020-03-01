using Terraria.ID;
using Terraria.ModLoader;

namespace Lythen.Items
{
	public class DeepBlue : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeepBlue"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The sword was originally forged by Poseidon, but as he dissapeared out of nowhere, the sword lost it's power.");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 15); 
			recipe.AddIngredient(ItemID.Sapphire, 4);
			recipe.AddIngredient(ItemID.Diamond, 2);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
		    recipe.AddTile(TileID.Anvils);
	        recipe.SetResult(this);     
			recipe.AddRecipe();
		}
	}
}