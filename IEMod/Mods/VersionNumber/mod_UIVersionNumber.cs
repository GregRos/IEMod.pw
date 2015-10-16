﻿using System.IO;
using System.Text;
using IEMod.Helpers;
using Patchwork;
using Patchwork.Attributes;
using UnityEngine;

namespace IEMod.Mods.VersionNumber {
	[ModifiesType]
	public class mod_UIVersionNumber : UIVersionNumber
	{
		
		[MemberAlias(".ctor", typeof(MonoBehaviour))]
		public void alias_MonoBehavior_ctor() {
			
		}

		[ModifiesMember(".ctor")]
		public void mod_ctor() {
			alias_MonoBehavior_ctor();
			var ieModVersion = IEMod.IEModVersion.Version;
			//GR 29/8 - there has to be some const for the version, but I haven't found it :/
			this.FormatString = $"v2.02.{{0}} {{1}} - IEMod {ieModVersion}";
			this.m_stringBuilder = new StringBuilder();
		}
	}
}
