using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Represents a complete scripture with reference and words.
    /// Manages the hiding and display of scripture words.
    /// </summary>
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        /// <summary>
        /// Initializes a scripture with the given reference and text.
        /// </summary>
        /// <param name="reference">The scripture reference</param>
        /// <param name="text">The scripture text</param>
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            _random = new Random();
            
            // Split text into words and create Word objects
            // Remove empty entries to handle multiple spaces
            string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in wordArray)
            {
                _words.Add(new Word(word));
            }
        }

        /// <summary>
        /// Hides a specified number of random words that are not already hidden.
        /// Uses smart selection to avoid hiding the same word twice.
        /// </summary>
        /// <param name="count">Number of words to hide (default: 1)</param>
        public void HideRandomWords(int count = 1)
        {
            // Get list of words that are not yet hidden (smart selection)
            List<Word> availableWords = _words.Where(w => !w.IsHidden()).ToList();
            
            // Hide up to 'count' random words
            int wordsToHide = Math.Min(count, availableWords.Count);
            
            for (int i = 0; i < wordsToHide; i++)
            {
                // Select random index from available words
                int index = _random.Next(availableWords.Count);
                
                // Hide the selected word
                availableWords[index].Hide();
                
                // Remove from available list to prevent selecting again
                availableWords.RemoveAt(index);
            }
        }

        /// <summary>
        /// Checks if all words in the scripture are hidden.
        /// </summary>
        /// <returns>True if all words are hidden, false otherwise</returns>
        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden());
        }

        /// <summary>
        /// Gets the count of hidden words.
        /// </summary>
        /// <returns>Number of hidden words</returns>
        public int GetHiddenWordCount()
        {
            return _words.Count(w => w.IsHidden());
        }

        /// <summary>
        /// Gets the total word count.
        /// </summary>
        /// <returns>Total number of words</returns>
        public int GetTotalWordCount()
        {
            return _words.Count;
        }

        /// <summary>
        /// Gets the count of visible (not hidden) words.
        /// </summary>
        /// <returns>Number of visible words</returns>
        public int GetVisibleWordCount()
        {
            return _words.Count(w => !w.IsHidden());
        }

        /// <summary>
        /// Gets the complete formatted scripture text for display.
        /// Includes reference and all words (shown or hidden as underscores).
        /// </summary>
        /// <returns>Formatted scripture string</returns>
        public string GetDisplayText()
        {
            // Join all words with spaces
            string wordsDisplay = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            
            // Combine reference with words
            return $"{_reference.GetDisplayText()} {wordsDisplay}";
        }

        /// <summary>
        /// Gets the progress percentage of hidden words.
        /// </summary>
        /// <returns>Percentage of words hidden (0-100)</returns>
        public int GetProgressPercentage()
        {
            if (_words.Count == 0)
                return 0;
            
            return (GetHiddenWordCount() * 100) / _words.Count;
        }

        /// <summary>
        /// Resets all words to visible state.
        /// </summary>
        public void Reset()
        {
            foreach (Word word in _words)
            {
                word.Show();
            }
        }
    }
}
