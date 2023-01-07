// ***********************************************************************
// Assembly         : MyVoiceApp3
// Author           : Bill  Banks
// Created          : 09-24-2022
//
// Last Modified By : Bill  Banks
// Last Modified On : 12-27-2022
// ***********************************************************************
// <copyright file="User.cs" company="MyVoiceApp3">
//     Copyright (c) Ourweb. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVoiceApp3.Models
{
    /// <summary>
    /// Class User.
    /// </summary>
    public partial class User
        {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the email verified at.
        /// </summary>
        /// <value>The email verified at.</value>
        [JsonProperty("email_verified_at")]
        public string EmailVerifiedAt { get; set; }

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        /// <value>The firstname.</value>
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        /// <value>The lastname.</value>
        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        /// <value>The zipcode.</value>
        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or sets the phonenumber.
        /// </summary>
        /// <value>The phonenumber.</value>
        [JsonProperty("phonenumber")]
        public string Phonenumber { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the os.
        /// </summary>
        /// <value>The os.</value>
        [JsonProperty("os")]
        public string Os { get; set; }

        /// <summary>
        /// Gets or sets the acctype.
        /// </summary>
        /// <value>The acctype.</value>
        [JsonProperty("acctype")]
        public string Acctype { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>The created at.</value>
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
