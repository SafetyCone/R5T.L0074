using System;
using System.IO;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0180;


namespace R5T.L0074
{
    [FunctionalityMarker]
    public partial interface IFileOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0066.IFileOperator _Platform => L0066.FileOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public StreamWriter Open_ForWrite(
            IFilePath filePath,
            bool overwrite = L0066.IValues.Default_OverwriteValue_Constant)
        {
            return _Platform.Open_ForWrite(
                filePath.Value,
                overwrite);
        }

        public Task Write_ToFile_FromIntermediateMemoryStream(
            IFilePath filePath,
            Action<StreamWriter> memoryStreamWriterAction,
            bool overwrite = L0066.IValues.Default_OverwriteValue_Constant)
        {
            return _Platform.Write_ToFile_FromIntermediateMemoryStream(
                filePath.Value,
                memoryStreamWriterAction,
                overwrite);
        }
    }
}
