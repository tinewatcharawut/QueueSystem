public class QueueService
{
    private string _currentQueue = "A0";
    private DateTime _lastQueueTime = DateTime.Now;
    private bool _isReset = true;

    public string CurrentQueue => _isReset ? "00" : _currentQueue;
    public DateTime LastQueueTime => _lastQueueTime;

    public string NextQueue()
    {
        if (_isReset)
        {
            _currentQueue = "A0";
            _isReset = false;
        }
        else
        {
            char letter = _currentQueue[0];
            int number = int.Parse(_currentQueue[1].ToString());

            number++;

            if (number > 9)
            {
                number = 0;
                letter++;

                if (letter > 'Z')
                    letter = 'A';
            }

            _currentQueue = $"{letter}{number}";
        }
        _lastQueueTime = DateTime.Now;
        return _currentQueue;
    }

    public void Reset()
    {
        _currentQueue = "A0";
        _isReset = true;
        _lastQueueTime = DateTime.Now;
    }
}
