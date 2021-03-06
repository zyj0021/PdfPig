﻿namespace UglyToad.PdfPig.Tokenization.Scanner
{
    using System;
    using Core;
    using Tokens;

    /// <summary>
    /// Tokenizes objects from bytes in a PDF file.
    /// </summary>
    internal interface IPdfTokenScanner : ISeekableTokenScanner, IDisposable
    {
        /// <summary>
        /// Tokenize the object with a given object number.
        /// </summary>
        /// <param name="reference">The object number for the object to tokenize.</param>
        /// <returns>The tokenized object.</returns>
        ObjectToken Get(IndirectReference reference);
    }
}