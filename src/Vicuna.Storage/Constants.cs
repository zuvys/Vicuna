﻿namespace Vicuna.Engine
{
    public static class Constants
    {
        public const int KB = 1024;

        public const int MB = 1024 * KB;

        public const int PageDepth = 1 << 20;

        public const int PageSize = 16 * KB;

        public const int PageTailerSize = 8;

        public const int PageHeaderSize = 96;

        public const int PageBodySize = PageSize - PageHeaderSize - PageTailerSize;
    }
}
