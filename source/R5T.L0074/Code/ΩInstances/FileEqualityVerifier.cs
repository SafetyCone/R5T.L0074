using System;


namespace R5T.L0074
{
    public class FileEqualityVerifier : IFileEqualityVerifier
    {
        #region Infrastructure

        public static IFileEqualityVerifier Instance { get; } = new FileEqualityVerifier();


        private FileEqualityVerifier()
        {
        }

        #endregion
    }
}
