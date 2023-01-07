// ***********************************************************************
// Assembly         : MyVoiceApp3
// Author           : Bill Banks
// Created          : 01-07-2023
//
// Last Modified By : Bill Banks
// Last Modified On : 12-27-2022
// ***********************************************************************
// <copyright file="Group.cs" company="MyVoiceApp3">
//     Copyright (c) Ourweb.mt. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVoiceApp3.Models
{
    /// <summary>
    /// Class Group.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>The order.</value>
        public decimal Order { get; set; }


    }
}
