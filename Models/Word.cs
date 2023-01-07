// ***********************************************************************
// Assembly         : MyVoiceApp3
// Author           : Bill  Banks
// Created          : 09-20-2022
//
// Last Modified By : Bill  Banks
// Last Modified On : 12-27-2022
// ***********************************************************************
// <copyright file="Word.cs" company="MyVoiceApp3">
//     Copyright (c) Ourweb. All rights reserved.
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
    /// Class Word.
    /// </summary>
    public class Word
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>The order.</value>
        public decimal Order
        {
            get; set;

        }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [MaxLength(25)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the phrase.
        /// </summary>
        /// <value>The phrase.</value>
        public string Phrase { get; set; }
        /// <summary>
        /// Gets or sets the group identifier.
        /// </summary>
        /// <value>The group identifier.</value>
        public int Group_Id { get; set; }

    }
}
