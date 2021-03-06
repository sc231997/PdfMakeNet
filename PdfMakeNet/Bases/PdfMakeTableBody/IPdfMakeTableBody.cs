﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeTableBody<T>
    {
        /// <summary>
        /// Add header rows.
        /// Headers are automatically repeated if the table spans over multiple pages you can declare how many rows should be treated as headers
        /// </summary>
        [JsonProperty("headerRows")]
        int HeaderRows { get; set; }
        /// <summary>
        /// Add widths to the table columns.
        /// Others possible width values: ['*', 'auto']
        /// </summary>
        [JsonProperty("widths")]
        IList<object> Widths { get; set; }
        /// <summary>
        /// Add the body of the table
        /// </summary>
        [JsonProperty("body")]
        IList<T> Body { get; set; }
        /// <summary>
        /// Add Heights to each table rows using list of int i.e [10, 20]
        /// Add Height to all the table rows using int i.e 10
        /// </summary>
        [JsonProperty("heights")]
        object Heights { get; set; }
    }
}
