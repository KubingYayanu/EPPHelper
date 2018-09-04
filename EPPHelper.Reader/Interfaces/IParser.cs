using System;

namespace EPPHelper.Reader
{
    public interface IParser : IDisposable
    {
        ReadingContext Context { get; }
    }
}