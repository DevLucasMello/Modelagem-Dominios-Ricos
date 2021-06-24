﻿using LojaIO.Core.Messages;
using System.Threading.Tasks;

namespace LojaIO.Core.Bus
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;

        Task<bool> EnviarComando<T>(T comando) where T : Command;
    }
}
