using System;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Represents a single word in a scripture with its hidden/shown state.
    /// </summary>
    public class Word
    {
        private string _text;
        private bool _isHidden;

        /// <summary>
        /// Initializes a new Word with the given text.
        /// </summary>
        /// <param name="text">The word text to store</param>
        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        /// <summary>
        /// Hides the word by setting its state to hidden.
        /// </summary>
        public void Hide()
        {
            _isHidden = true;
        }

        /// <summary>
        /// Shows the word by setting its state to visible.
        /// </summary>
        public void Show()
        {
            _isHidden = false;
        }

        /// <summary>
        /// Gets the display text - either the word or underscores matching its length.
        /// Each hidden word is replaced with underscores matching the EXACT number of letters.
        /// Example: "faith" → "_____" (5 underscores), "God" → "___" (3 underscores)
        /// </summary>
        /// <returns>The word or underscores if hidden</returns>
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                return new string('_', _text.Length);
            }
            return _text;
        }

        /// <summary>
        /// Checks if the word is currently hidden.
        /// </summary>
        /// <returns>True if hidden, false if shown</returns>
        public bool IsHidden()
        {
            return _isHidden;
        }

        /// <summary>
        /// Gets the original text of the word.
        /// </summary>
        /// <returns>The word text</returns>
        public string GetText()
        {
            return _text;
        }
    }
}
