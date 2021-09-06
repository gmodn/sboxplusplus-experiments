﻿using Sandbox;

partial class SandboxPlayer
{
	ModelEntity pants;
	ModelEntity jacket;
	ModelEntity shoes;
	ModelEntity hat;

	bool dressed = false;

	public void Dress()
	{
		if ( dressed ) return;
		dressed = true;

		if ( true )
		{
			var model = Rand.FromArray( new[]
			{
				"models/citizen_clothes/trousers/trousers.jeans.vmdl",
				"models/citizen_clothes/trousers/trousers.lab.vmdl",
				"models/citizen_clothes/trousers/trousers.police.vmdl",
				"models/citizen_clothes/trousers/trousers.smart.vmdl",
				"models/citizen_clothes/trousers/trousers.smarttan.vmdl",
				"models/citizen/clothes/trousers_tracksuit.vmdl",
				"models/citizen_clothes/trousers/trousers_tracksuitblue.vmdl",
				"models/citizen_clothes/trousers/trousers_tracksuit.vmdl",
				"models/citizen_clothes/shoes/shorts.cargo.vmdl",
			} );

			pants = new ModelEntity();
			pants.SetModel( model );
			pants.SetParent( this, true );
			pants.EnableShadowInFirstPerson = true;
			pants.EnableHideInFirstPerson = true;

			SetBodyGroup( "Legs", 1 );
		}

		if ( true )
		{
			var model = Rand.FromArray( new[]
			{
				"models/citizen_clothes/jacket/labcoat.vmdl",
				"models/citizen_clothes/jacket/jacket.red.vmdl",
				"models/citizen_clothes/jacket/jacket.tuxedo.vmdl",
				"models/citizen_clothes/jacket/jacket_heavy.vmdl",
			} );

			jacket = new ModelEntity();
			jacket.SetModel( model );
			jacket.SetParent( this, true );
			jacket.EnableShadowInFirstPerson = true;
			jacket.EnableHideInFirstPerson = true;

			var propInfo = jacket.GetModel().GetPropData();
			if ( propInfo.ParentBodyGroupName != null )
			{
				SetBodyGroup( propInfo.ParentBodyGroupName, propInfo.ParentBodyGroupValue );
			}
			else
			{
				SetBodyGroup( "Chest", 0 );
			}
		}

		if ( true )
		{
			var model = Rand.FromArray( new[]
			{
				"models/citizen_clothes/shoes/trainers.vmdl",
				"models/citizen_clothes/shoes/shoes.workboots.vmdl"
			} );

			shoes = new ModelEntity();
			shoes.SetModel( model );
			shoes.SetParent( this, true );
			shoes.EnableShadowInFirstPerson = true;
			shoes.EnableHideInFirstPerson = true;

			SetBodyGroup( "Feet", 1 );
		}

		if ( true )
		{
			var model = Rand.FromArray( new[]
			{
				"models/citizen/hdme_visor/hdme_visor.vmdl",
				"models/sboxhardhatbase.vmdl",
			} );

			hat = new ModelEntity();
			hat.SetModel( model );
			hat.SetParent( this, true );
			hat.EnableShadowInFirstPerson = true;
			hat.EnableHideInFirstPerson = true;
		}
	}
}
