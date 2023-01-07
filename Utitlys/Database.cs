// ***********************************************************************
// Assembly         : MyVoiceApp
// Author           : Bill Banks
// Created          : 03-15-2019
//
// Last Modified By : Bill Banks
// Last Modified On : 11-29-2022
// ***********************************************************************
// <copyright file="Database.cs" company="MyVoiceApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using MyVoiceApp3.Models;
using SQLite;

namespace MyVoiceApp3.Utitlys
{
    /// <summary>
    /// Class Database.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The connection
        /// </summary>
        private SQLiteConnection conn;

        /// <summary>
        /// Initializes a new instance of the <see cref="Database" /> class.
        /// </summary>
        public Database()
        {
            // Get an absolute path to the database file
            // var databasePath = App.DatabaseLocation;
            // Get an absolute path to the database file
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");


            conn = new SQLiteConnection(databasePath);

            // Tables
            conn.CreateTable<Word>();
            //   conn.CreateTable<Group>();
        }

        // Word Access

        /// <summary>
        /// Reads the words.
        /// </summary>
        /// <param name="gno">The gno.</param>
        /// <returns>IList&lt;Word&gt;.</returns>
        public IList<Word> ReadWords(int gno = 0)
        {
            IList<Word> Words = new List<Word>();
            if (gno == 0)
            {
                Words = conn.Table<Word>()
                    .OrderBy(e => e.Order)
                    .ThenBy(e => e.Title)
                    .ToList();
            }
            else
            {
                Words = conn.Table<Word>()
                    .Where(e => e.Group_Id == gno)
     .OrderBy(e => e.Order)
     .ThenBy(e => e.Title)
     .ToList();
            }

            return Words;
        }

        /// <summary>
        /// Writes the word.
        /// </summary>
        /// <param name="rec">The record.</param>
        /// <returns>System.Int32.</returns>
        public int WriteWord(Word rec)
        {
            int i = 0;
            if (rec.Id == 0)
            {
                i = conn.Insert(rec);
            }
            else
            {
                i = conn.Update(rec);
            }

            return i;
        }

        /// <summary>
        /// Deletes the word.
        /// </summary>
        /// <param name="rec">The record.</param>
        public void DeleteWord(Word rec)
        {
            conn.Delete(rec);
        }

        // Group Access

        /// <summary>
        /// Reads the groups.
        /// </summary>
        /// <returns>IList&lt;Group&gt;.</returns>
        public IList<Group> ReadGroups()
        {
            IList<Group> groups = new List<Group>();

            groups = conn.Table<Group>().ToList();

            return groups;
        }

        /// <summary>
        /// Writes the group.
        /// </summary>
        /// <param name="rec">The record.</param>
        /// <returns>System.Int32.</returns>
        public int WriteGroup(Group rec)
        {
            int i = 0;
            if (rec.Id == 0)
            {
                i = conn.Insert(rec);
            }
            else
            {
                i = conn.Update(rec);
            }

            return i;
        }

        /// <summary>
        /// Deletes the group.
        /// </summary>
        /// <param name="rec">The record.</param>
        public void DeleteGroup(Group rec)
        {
            var words = ReadWords(rec.Id);
            foreach (var w in words)
                DeleteWord(w);

            conn.Delete(rec);
        }


        /// <summary>
        /// Finalizes an instance of the <see cref="Database" /> class.
        /// </summary>
        ~Database()
        {
            conn.Close();
        }
    }
}
