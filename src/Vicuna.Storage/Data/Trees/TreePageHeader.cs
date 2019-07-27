﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vicuna.Engine.Paging;

namespace Vicuna.Engine.Data.Trees
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = SizeOf)]
    public unsafe struct TreePageHeader
    {
        internal const int SizeOf = 96;

        [FieldOffset(0)]
        public PageHeaderFlags Flags;

        [FieldOffset(1)]
        public int FileId;

        [FieldOffset(5)]
        public long PageNumber;

        [FieldOffset(13)]
        public long LSN;

        [FieldOffset(21)]
        public long PrevPageNumber;

        [FieldOffset(29)]
        public long NextPageNumber;

        [FieldOffset(37)]
        public ushort Low;

        [FieldOffset(39)]
        public ushort Upper;

        [FieldOffset(41)]
        public ushort Count;

        [FieldOffset(43)]
        public ushort UsedSize;

        [FieldOffset(45)]
        public TreeNodeFlags NodeFlags;

        [FieldOffset(46)]
        public long LastTransactionId;

        [FieldOffset(54)]
        public fixed byte Reserved[SizeOf - 53 - 1];
    }
}
