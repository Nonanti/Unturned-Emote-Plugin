using System;
using System.Collections.Generic;
using Rocket.API;
using Rocket.API.Extensions;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace EmotePlugin
{
	public class CommandDo : IRocketCommand
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
				return "do";
			}
		}
		public string Help
		{
			get
			{
				return "Emote Plugin /do komutu.";
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
					"Do"
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
				if (Vector3.Distance(unturnedPlayer.Position, unturnedPlayer2.Position) <= 50f)
				{
					UnturnedChat.Say(unturnedPlayer2, unturnedPlayer.DisplayName + " " + parameterString, UnityEngine.Color.green);
				}
			}
		}
	}
}
