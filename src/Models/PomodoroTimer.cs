/*namespace Pomodoro.Models;

public class PomodoroTimer
{
    public int TimeLeft { get; set; } = 25 * 60;
    public bool IsRunning { get; set; }
    public bool IsBreak { get; set; }
    public DateTime? LastTick { get; set; }

    public void Start()
    {
        IsRunning = true;
        LastTick = DateTime.UtcNow;
    }

    public void Pause()
    {
        IsRunning = false;
        LastTick = null;
    }

    public void Reset()
    {
        IsRunning = false;
        IsBreak = false;
        TimeLeft = 25 * 60;
        LastTick = null;
    }

    public bool Tick()
    {
        if (TimeLeft > 0)
        {
            TimeLeft--;
            return false;
        }
        return true;
    }

    public void SwitchMode()
    {
        IsBreak = !IsBreak;
        TimeLeft = IsBreak ? 5 * 60 : 25 * 60;
    }

    public void UpdateTime()
    {
        if (IsRunning && LastTick.HasValue)
        {
            var elapsed = (int)(DateTime.UtcNow - LastTick.Value).TotalSeconds;
            TimeLeft = Math.Max(0, TimeLeft - elapsed);
            LastTick = DateTime.UtcNow;
            
            if (TimeLeft == 0)
            {
                SwitchMode();
            }
        }
    }
}
*/