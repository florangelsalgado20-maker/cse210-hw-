using System;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Represents a scripture reference including book, chapter, and verse(s).
    /// Handles both single verses (John 3:16) and verse ranges (Proverbs 3:5-6).
    /// </summary>
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int? _endVerse;

        /// <summary>
        /// Initializes a reference for a single verse.
        /// Example: new Reference("John", 3, 16) → "John 3:16"
        /// </summary>
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = verse;
            _endVerse = null;
        }

        /// <summary>
        /// Initializes a reference for a verse range.
        /// Example: new Reference("Proverbs", 3, 5, 6) → "Proverbs 3:5-6"
        /// </summary>
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            
            // Only set endVerse if it's greater than startVerse
            if (endVerse > startVerse)
            {
                _endVerse = endVerse;
            }
            else
            {
                _endVerse = null;
            }
        }

        /// <summary>
        /// Gets the formatted reference string for display.
        /// </summary>
        /// <returns>Formatted reference like "John 3:16" or "Proverbs 3:5-6"</returns>
        public string GetDisplayText()
        {
            if (_endVerse.HasValue)
            {
                return $"{_book} {_chapter}:{_startVerse}-{_endVerse.Value}";
            }
            return $"{_book} {_chapter}:{_startVerse}";
        }

        /// <summary>
        /// Gets the book name.
        /// </summary>
        public string GetBook()
        {
            return _book;
        }

        /// <summary>
        /// Gets the chapter number.
        /// </summary>
        public int GetChapter()
        {
            return _chapter;
        }
    }
}
