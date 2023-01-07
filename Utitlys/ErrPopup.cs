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

using static System.Net.Mime.MediaTypeNames;

namespace MyVoiceApp3.Utitlys
{
    /// <summary>
    /// Enum Message_Box
    /// </summary>
    public enum Message_Box
    {

        /// <summary>
        /// The blankfield
        /// </summary>
        Blankfield,
        /// <summary>
        /// The notemail
        /// </summary>
        Notemail,
        /// <summary>
        /// The badlogin
        /// </summary>
        Badlogin,
        /// <summary>
        /// The emailinused
        /// </summary>
        Emailinused,
        /// <summary>
        /// The saved
        /// </summary>
        Saved,
        /// <summary>
        /// The deleted
        /// </summary>
        Deleted,
        /// <summary>
        /// The read
        /// </summary>
        Read,
        /// <summary>
        /// The error
        /// </summary>
        Error
    }

    /// <summary>
    /// Class Popup.
    /// </summary>
    public partial class  ErrPopup
    {
        /// <summary>
        /// The box
        /// </summary>
        private Message_Box _Box;
        /// <summary>
        /// The message
        /// </summary>
       public string message = string.Empty;


        /// <summary>
        /// The cancellation token source
        /// </summary>
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        /// <summary>
        /// Initializes a new instance of the <see cref="Popup"/> class.
        /// </summary>
        /// <param name="message_Box">The message box.</param>
        public ErrPopup(Message_Box message_Box)
        {
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
                case Message_Box.Blankfield:
                    message = "Field(s) are blank";
                    break;
                case Message_Box.Notemail:
                    message = "You must enter an email address";
                    break;
                case Message_Box.Emailinused:
                    message = "Email has been signed up already";
                    break;

                case Message_Box.Badlogin:
                    message = "Bad login";
                    break;
                case Message_Box.Saved:
                    message = "Data has been saved";
                    break;
                case Message_Box.Deleted:
                    message = "Data has been deleted";
                    break;
                case Message_Box.Read:
                    message = "Reading";
                    break;
                case Message_Box.Error:
                    message = " There has been an error";
                    break;
                default:
                    break;
            }  
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        /// 
        public async Task Show()
        {
    //          await DisplayAlert("Alert", "You have been alerted", "OK");
            
        }
   
    }
}
