// ***********************************************************************
// Assembly         : MyVoiceApp3
// Author           : Bill Banks
// Created          : 12-04-2022
//
// Last Modified By : Bill Banks
// Last Modified On : 12-06-2022
// ***********************************************************************
// <copyright file="Popup.cs" company="MyVoiceApp3">
//     Copyright (c) Ourweb.mt. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace MyVoiceApp3.Utitlys
{

    /// <summary>
    /// Class Popup.
    /// </summary>
    public partial class Popup
    {
        /// <summary>
        /// The box
        /// </summary>
        private MessageBox _Box;
        /// <summary>
        /// The message
        /// </summary>
        private string message = string.Empty;


        /// <summary>
        /// The cancellation token source
        /// </summary>
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        /// <summary>
        /// Initializes a new instance of the <see cref="Popup"/> class.
        /// </summary>
        /// <param name="message_Box">The message box.</param>
        public Popup(MessageBox message_Box)
        {
            MessageBox message_Box1 = message_Box;
            _Box = message_Box;
            Convert();

        }

        /// <summary>
        /// Converts this instance.
        /// </summary>
        private void Convert()
        {
            switch (_Box)
            {
                case MessageBox.Blankfield:
                    message = "Field(s) are blank";
                    break;
                case MessageBox.Notemail:
                    message = "You must enter an email address";
                    break;
                case MessageBox.Emailinused:
                    message = "Email has been signed up already";
                    break;

                case MessageBox.Badlogin:
                    message = "Bad login";
                    break;
                case MessageBox.Saved:
                    message = "Data has been saved";
                    break;
                case MessageBox.Deleted:
                    message = "Data has been deleted";
                    break;
                case MessageBox.Read:
                    message = "Reading";
                    break;
                case MessageBox.Error:
                    message = " There has been an error";
                    break;
                default:
                    break;
            }  
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
   
    }
}
