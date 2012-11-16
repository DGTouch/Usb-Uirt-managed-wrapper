using System;

namespace UsbUirt.EventArgs
{
    /// <summary>
    /// Event args passed to the Learning event.
    /// </summary>
    public class LearningEventArgs : System.EventArgs
    {
        private readonly uint _carrierFreq;
        private readonly uint _progress;
        private readonly uint _sigQuality;
        private readonly object _userState;

        internal LearningEventArgs(
            uint progress,
            uint sigQuality,
            uint carrierFreq,
            object userState
            )
        {
            _progress = progress;
            _sigQuality = sigQuality;
            _carrierFreq = carrierFreq;
            _userState = userState;
        }

        /// <summary>
        /// Gets the currently detected carrier frequency.
        /// </summary>
        public int CarrierFrequency
        {
            get { return Convert.ToInt32(_carrierFreq); }
        }

        /// <summary>
        /// Gets the progress, from 0 to 100.
        /// </summary>
        public int Progress
        {
            get { return Convert.ToInt32(_progress); }
        }

        /// <summary>
        /// Gets the currently detected signal quality.
        /// </summary>
        public int SignalQuality
        {
            get { return Convert.ToInt32(_sigQuality); }
        }

        /// <summary>
        /// Gets the optional user state.
        /// </summary>
        public object UserState
        {
            get { return _userState; }
        }
    }
}