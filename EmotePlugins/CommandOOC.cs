﻿using System;
using System.Collections.Generic;
using Rocket.API;
using Rocket.API.Extensions;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace EmotePlugin
{
	public class CommandOOC : IRocketCommand
	{
		public AllowedCaller AllowedCaller
		{
			get
			{
				return (AllowedCaller)1;
			}
		}
		public string Name
		{
			get
			{
				return "ooc";
			}
		}
		public string Help
		{
			get
			{
				return "Emote Plugin /ooc komutu.";
			}
		}
		public string Syntax
		{
			get
			{
				return "<message>";
			}
		}
		public List<string> Aliases
		{
			get
			{
				return new List<string>();
			}
		}
		public List<string> Permissions
		{
			get
			{
				return new List<string>
				{
					"ooc"
				};
			}
		}
		public void Execute(IRocketPlayer caller, string[] command)
		{
			string parameterString = RocketCommandExtensions.GetParameterString(command, 0);
			UnturnedPlayer unturnedPlayer = (UnturnedPlayer)caller;
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				UnturnedPlayer unturnedPlayer2 = UnturnedPlayer.FromSteamPlayer(steamPlayer);
				if (Vector3.Distance(unturnedPlayer.Position, unturnedPlayer2.Position) <= 99999999999f)
				{
					UnturnedChat.Say(unturnedPlayer2, unturnedPlayer.DisplayName + " " + parameterString, UnityEngine.Color.green);
				}
			}
		}
	}
}
