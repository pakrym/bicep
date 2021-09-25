// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure;
using Bicep.Core.RegistryClient.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Bicep.Core.RegistryClient
{
    internal interface IContainerRegistryAuthenticationClient
    {
        Task<Response<AcrRefreshToken>> ExchangeAadAccessTokenForAcrRefreshTokenAsync(string service, string aadAccessToken, CancellationToken token = default);
        Response<AcrRefreshToken> ExchangeAadAccessTokenForAcrRefreshToken(string service, string aadAccessToken, CancellationToken token = default);

        Task<Response<AcrAccessToken>> ExchangeAcrRefreshTokenForAcrAccessTokenAsync(string service, string scope, string acrRefreshToken, TokenGrantType grantType = TokenGrantType.RefreshToken, CancellationToken cancellationToken = default);
        Response<AcrAccessToken> ExchangeAcrRefreshTokenForAcrAccessToken(string service, string scope, string acrRefreshToken, TokenGrantType grantType = TokenGrantType.RefreshToken, CancellationToken cancellationToken = default);
    }
}
