using System.Collections.Generic;

namespace DesignPatterns
{
    public class MusicalNotes
    {
        private static IDictionary<string, INote> Notes =>
            new Dictionary<string, INote>
            {
                { "do", new Do() },
                { "re", new Re() },
                { "mi", new Mi() },
                { "fa", new Fa() },
                { "sol", new Sol() },
                { "la", new La() },
                { "si", new Si() },
            };

        public INote Get(string note)
        {
            return Notes[note];
        }
    }
}
