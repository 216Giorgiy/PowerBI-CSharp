// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for capacity workload settings list
    /// </summary>
    public partial class ODataResponseListWorkload
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListWorkload class.
        /// </summary>
        public ODataResponseListWorkload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListWorkload class.
        /// </summary>
        /// <param name="value">The capacity workload settings list</param>
        public ODataResponseListWorkload(string odatacontext = default(string), IList<Workload> value = default(IList<Workload>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the capacity workload settings list
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Workload> Value { get; set; }

    }
}