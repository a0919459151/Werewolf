﻿using Wsa.Gaas.Werewolf.Domain.Objects;

namespace Wsa.Gaas.Werewolf.WebApi.ViewModels
{
    public class PlayerVm
    {
        public string Id { get; set; } = string.Empty;
        public int PlayerNumber { get; set; }

        public static PlayerVm FromDomain(Player player)
        {
            return new PlayerVm
            {
                Id = player.Id.ToString(),
                PlayerNumber = player.PlayerNumber,
            };
        }
    }
}