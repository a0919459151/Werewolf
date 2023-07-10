﻿using Wsa.Gaas.Werewolf.Domain.Common;

namespace Wsa.Gaas.Werewolf.Application.Common
{
    public interface IGameEventHandler
    {
        Task Handle(GameEvent events, CancellationToken cancellationToken = default);
    }
}