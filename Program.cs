﻿using ApplicationIdentity;
using GraphHttp;

// Default Scope
string[] scopes = { "https://graph.microsoft.com/.default" };
string tenantId = "common";
string clientId = "3d04380f-2420-4eb9-ba3b-28f07e1ef5f4";

// Create new Token
Token token = new(tenantId, clientId, scopes);
string? accessToken = token.GetToken().Result;

if (accessToken != null)
{
    // Create new GraphClient
    GraphClient graphClient = new(accessToken);

    // GET new GraphUser
    GraphUser graphUser = new(graphClient);

    Console.WriteLine($"Id: {graphUser.Id}");
    Console.WriteLine($"DisplayName: {graphUser.DisplayName}");
    Console.WriteLine($"Mail: {graphUser.Mail}");
}
else
{
    Console.WriteLine("Failed to get access token");
}