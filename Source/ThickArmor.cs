﻿using System.Reflection;
using System.Linq;
using Verse;
using UnityEngine;
using HarmonyLib;
using RimWorld;

namespace ThickArmor
{
	public class Mod : Verse.Mod
	{
		public static Settings settings;
		public Mod(ModContentPack content) : base(content)
		{
			// initialize settings
			settings = GetSettings<Settings>();

			Harmony harmony = new Harmony("uuugggg.rimworld.ThickArmor.main");
			
			harmony.PatchAll();
		}

		public override void DoSettingsWindowContents(Rect inRect)
		{
			base.DoSettingsWindowContents(inRect);
			settings.DoWindowContents(inRect);
		}

		public override string SettingsCategory()
		{
			return "TD.ThickArmor".Translate();
		}
	}
}