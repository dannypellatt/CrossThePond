using System;
using CrossThePondApp.Models;
using CrossThePondUKToUSWords;

namespace CrossThePondApp
{
    public interface Iwords
    {
        public IEnumerable<words> GetAllWords();
    }
}

