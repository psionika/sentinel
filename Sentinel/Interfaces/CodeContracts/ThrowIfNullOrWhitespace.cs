using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Sentinel.Interfaces.CodeContracts
{
    public static partial class CodeContractExtensions
    {
        [ContractAbbreviator]
        [DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNullOrWhiteSpace(
            [ValidatedNotNull] this string value,
            string parameterName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(value));
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}