using System;
using System.Data;
using CrossThePondApp;
using CrossThePondApp.Models;
using Dapper;

namespace CrossThePondUKToUSWords
{
    public class words : Iwords
    {
        private readonly IDbConnection _conn;

        public words(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<words> GetAllWords()
        {
            return _conn.Query<words>("SELECT * FROM CrossThePond.wordsALL;");
        }



    }
}


