using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPPHelper.Reader
{
    public class EPPlusReader : IReader
    {
        public EPPlusReader(IParser parser)
        {
            Parser = parser ?? throw new ArgumentNullException(nameof(parser));
            Context = parser.Context as ReadingContext ?? throw new InvalidOperationException($"For {nameof(IParser)} to be used in {nameof(EPPlusReader)}, {nameof(IParser.Context)} must also implement {nameof(ReadingContext)}.");
        }

        #region Property

        public virtual ReadingContext Context { get; set; }

        public virtual IParser Parser { get; set; }

        #endregion Property

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> EnumerateRecords<T>(T record)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetRecords<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetRecords<T>(T anonymousTypeDefinition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetRecords(Type type)
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool ReadHeader()
        {
            throw new NotImplementedException();
        }
    }
}
