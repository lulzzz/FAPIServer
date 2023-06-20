﻿using FAPIServer.RequestHandling.Requests;

namespace FAPIServer.RequestHandling.Contexts;

public class TokenIntrospectionContext
{
    public TokenIntrospectionContext(ClientAuthRequest authRequest, TokenIntrospectionRequest request, Uri requestedUri, string validTokenIssuer)
    {
        if (string.IsNullOrEmpty(validTokenIssuer))
            throw new ArgumentException($"'{nameof(validTokenIssuer)}' cannot be null or empty.", nameof(validTokenIssuer));

        AuthRequest = authRequest ?? throw new ArgumentNullException(nameof(authRequest));
        Request = request ?? throw new ArgumentNullException(nameof(request));
        RequestedUri = requestedUri ?? throw new ArgumentNullException(nameof(requestedUri));
        ValidTokenIssuer = validTokenIssuer;
    }

    public ClientAuthRequest AuthRequest { get; set; }
    public TokenIntrospectionRequest Request { get; set; }
    public Uri RequestedUri { get; set; }
    public string ValidTokenIssuer { get; set; }
}
