using System;

namespace CSharpIntermediate
{
    public class StopWatch
    {
        private DateTime _startTime = new DateTime();
        private TimeSpan _duration = new TimeSpan();
        private bool _isRunning;

        public TimeSpan Duration
        {
            get
            {
                if (this._isRunning)
                {
                    return DateTime.Now - this._startTime;
                }
                return this._duration;
            }
            private set
            {
                this._duration = value;
            }
        }

        public void Start()
        {
            if (this._isRunning)
            {
                throw new InvalidOperationException("_isRunning");
            }
            this._startTime = DateTime.Now;
            this._isRunning = true;
        }

        public void Stop()
        {
            if(!this._isRunning)
            {
                throw new InvalidOperationException("_isRunning");
            }
            this.Duration = DateTime.Now - this._startTime;
            this._isRunning = false;
            this._startTime = new DateTime();
        }
    }
}
