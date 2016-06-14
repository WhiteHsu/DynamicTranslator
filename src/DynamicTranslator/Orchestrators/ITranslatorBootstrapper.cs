﻿using System;
using System.Threading.Tasks;

using DynamicTranslator.Orchestrators.Event;

namespace DynamicTranslator.Orchestrators
{
    public interface ITranslatorBootstrapper : IDisposable, IEvents
    {
        bool IsInitialized { get; }

        void Initialize();

        Task InitializeAsync();

        void SubscribeShutdownEvents();
    }
}