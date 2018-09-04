namespace EPPHelper.Reader
{
    public class RecordManager
    {
        public RecordManager(EPPlusReader reader)
        {
            this.reader = reader;
        }

        #region Property

        private EPPlusReader reader { get; }

        #endregion Property
    }
}