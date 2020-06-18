using System;

namespace StopWatchSimulator
{
    public class Stopwatch
    {
        DateTime _startTime;
        DateTime _stopTime;
        Boolean _isRunning = false;

        public void Start()
        {
            if(_isRunning)            
                throw new InvalidOperationException("Cannot start: The stopwatch is already running");
            
            _isRunning = true;
            _startTime = DateTime.Now;

        }
               

        public void Stop()
        { 
            if (!_isRunning)
                throw new InvalidOperationException("Cannot stop: The stopwatch is already stopped");
            
            _stopTime = DateTime.Now;
            _isRunning = false;


        }

        public TimeSpan ElapsedTime()
        {
            if (_isRunning)
               return  DateTime.Now - _startTime;
            else 
            return _stopTime - _startTime;
        }

             

    }
}
