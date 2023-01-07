// ***********************************************************************
// Assembly         : MyVoiceApp3
// Author           : Bill Banks
// Created          : 12-16-2022
//
// Last Modified By : Bill Banks
// Last Modified On : 12-16-2022
// ***********************************************************************
// <copyright file="CheckEmeil.cs" company="MyVoiceApp3">
//     Copyright (c) Ourweb.mt. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace MyVoiceApp3.Utitlys
{
    /// <summary>
    /// Class CheckEmeil.
    /// </summary>
    public class CheckEmeil
    {
        /// <summary>
        /// Determines whether [is valid email] [the specified email].
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns><c>true</c> if [is valid email] [the specified email]; otherwise, <c>false</c>.</returns>
        public  bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }

 } 