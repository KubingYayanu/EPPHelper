using System;
using System.Collections.Generic;

namespace EPPHelper.Reader
{
    public interface IReader : IReaderRow, IDisposable
    {
        IParser Parser { get; }

        bool ReadHeader();

        bool Read();

        IEnumerable<T> GetRecords<T>();

        IEnumerable<T> GetRecords<T>(T anonymousTypeDefinition);

        IEnumerable<object> GetRecords(Type type);

        IEnumerable<T> EnumerateRecords<T>(T record);
    } 
}