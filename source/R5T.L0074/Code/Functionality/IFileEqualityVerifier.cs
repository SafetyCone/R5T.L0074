using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0180;


namespace R5T.L0074
{
    [FunctionalityMarker]
    public partial interface IFileEqualityVerifier : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IFileEqualityVerifier _Platform => L0066.FileEqualityVerifier.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public Task Verify_FileEquality_ByteLevel(
            IFilePath filePathA,
            IFilePath filePathB)
        {
            return _Platform.Verify_FileEquality_ByteLevel(
                filePathA.Value,
                filePathB.Value);
        }

        public void Verify_FileEquality_ByteLevel_Synchronous(
            IFilePath filePathA,
            IFilePath filePathB)
        {
            _Platform.Verify_FileEquality_ByteLevel_Synchonous(
                filePathA.Value,
                filePathB.Value);
        }
    }
}
