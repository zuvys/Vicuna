﻿namespace Vicuna.Engine.Buffers
{
    public class BufferPoolOptions
    {
        public long LRULimit { get; set; }

        public uint AsyncFlushCount { get; set; } = 32;

        public uint SyncFlushMidpoint { get; set; } = 75;
    }
}
