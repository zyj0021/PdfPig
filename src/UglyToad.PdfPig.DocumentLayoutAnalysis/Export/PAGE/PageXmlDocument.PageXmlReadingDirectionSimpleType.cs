﻿namespace UglyToad.PdfPig.DocumentLayoutAnalysis.Export.PAGE
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Xml.Serialization;

    public partial class PageXmlDocument
    {
        /// <remarks/>
        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCode("xsd", "4.6.1055.0")]
        [Serializable()]
        [XmlType(Namespace = "http://schema.primaresearch.org/PAGE/gts/pagecontent/2019-07-15")]
        public enum PageXmlReadingDirectionSimpleType
        {

            /// <remarks/>
            [XmlEnum("left-to-right")]
            LeftToRight,

            /// <remarks/>
            [XmlEnum("right-to-left")]
            RightToLeft,

            /// <remarks/>
            [XmlEnum("top-to-bottom")]
            TopToBottom,

            /// <remarks/>
            [XmlEnum("bottom-to-top")]
            BottomToTop,
        }
    }
}
