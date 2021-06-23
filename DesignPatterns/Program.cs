using System.Collections.Generic;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var musicalNotes = new MusicalNotes();

            var music = new List<INote>
            {
                musicalNotes.Get("do"),
                musicalNotes.Get("re"),
                musicalNotes.Get("mi"),
                musicalNotes.Get("fa"),
                musicalNotes.Get("fa"),
                musicalNotes.Get("fa"),
                musicalNotes.Get("do"),
                musicalNotes.Get("re"),
                musicalNotes.Get("do"),
                musicalNotes.Get("re"),
                musicalNotes.Get("re"),
                musicalNotes.Get("re"),
                musicalNotes.Get("do"),
                musicalNotes.Get("sol"),
                musicalNotes.Get("fa"),
                musicalNotes.Get("mi"),
                musicalNotes.Get("mi"),
                musicalNotes.Get("mi"),
                musicalNotes.Get("do"),
                musicalNotes.Get("re"),
                musicalNotes.Get("mi"),
                musicalNotes.Get("fa"),
                musicalNotes.Get("fa"),
                musicalNotes.Get("fa"),
            };

            var piano = new Piano();
            piano.Play(music);
        }
    }
}
