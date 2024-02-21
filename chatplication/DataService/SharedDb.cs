﻿using System.Collections.Concurrent;
using chatplication.Models;

namespace chatplication.DataService;

public class SharedDb
{
    private readonly ConcurrentDictionary<string, UserConnection> _connections = new ConcurrentDictionary<string, UserConnection>();

    public ConcurrentDictionary<string, UserConnection> connections => _connections;
}
