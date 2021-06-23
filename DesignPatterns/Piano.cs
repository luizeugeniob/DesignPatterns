using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Piano
    {
        public void Play(IList<INote> music)
        {
            foreach (var note in music)
            {
                Console.Beep(note.Frequency, 300);
            }
        }
    }
}
