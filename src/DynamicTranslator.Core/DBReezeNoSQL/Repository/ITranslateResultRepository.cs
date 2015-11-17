﻿namespace DynamicTranslator.Core.DBReezeNoSQL.Repository
{
    #region using

    using System.Threading.Tasks;
    using Orchestrators;

    #endregion

    public interface ITranslateResultRepository
    {
        CompositeTranslateResult GetTranslateResult(string key);

        Task<CompositeTranslateResult> GetTranslateResultAsync(string key);

        CompositeTranslateResult SetTranslateResult(string key, CompositeTranslateResult result);

        Task<CompositeTranslateResult> SetTranslateResultAsync(string key, CompositeTranslateResult result);
    }
}