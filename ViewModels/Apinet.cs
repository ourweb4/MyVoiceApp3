using MyVoiceApp3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVoiceApp3.ViewModels
{

    /// <summary>
    /// Class Api.
    /// </summary>
    public partial class Apinet
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        [JsonProperty("token")]
        public string Token { get; set; }
    }

}
