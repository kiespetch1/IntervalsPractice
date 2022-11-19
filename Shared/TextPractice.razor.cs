using IntervalsPractice.BaseClasses;
using Microsoft.AspNetCore.Components;
// ReSharper disable InconsistentNaming

namespace IntervalsPractice.Shared;
public partial class TextPractice
{
    private static Interval? CurrentInterval;
    private string? CurrentTaskText = PlayTextPractice();
    private string? answer;
    private string? ValidationAnswer;
    private bool IsAnswerCorrect;
    private bool IsTaskChanged;
    private string? AnswerDetails;
    private string? Hint;
    private string? Characteristic;
    private string? BaseInterval;
    public static string PlayTextPractice()
    {
        var obj = new DiatonicIntervals();

        var pitch = Scale.CreatePitch();
        var interval = DiatonicIntervals.CreateInterval();
        var octave = new[] {'C', 'D', 'E', 'F', 'G', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'A', 'B'};

        byte pitchName = 0;
        for (byte i = 0; i < 7; i++)
        {
            if (pitch.GetName() == octave[i])
            {
                pitchName = i;
                break;
            }
        }

        var secondPitchName = pitchName;
        short halfsteps = 0;
        var octaveSign = false;
        bool sharp = false, flat = false;

        if (interval.GetHalfsteps() != 0 && interval.GetHalfsteps() != 12)
        {
            for (byte i = 1; i < interval.GetPitches(); i++)
            {
                if (octave[secondPitchName] == 'E' || octave[secondPitchName] == 'B')
                {
                    halfsteps++;
                    secondPitchName++;
                }
                else
                {
                    halfsteps += 2;
                    secondPitchName++;
                }
            }

            var dh = interval.GetHalfsteps() - halfsteps;
            if (!pitch.GetAug() && !pitch.GetDim())
            {
                if (dh == -1) flat = true;
                else if (dh == 1) sharp = true;
            }
            else if (pitch.GetAug())
            {
                if (dh == 0) sharp = true;
                else if (dh == 1)
                {
                    pitch.SetAug(false);
                    pitch.SetDim(true);
                }
            }
            else
            {
                if (dh == -1)
                {
                    pitch.SetDim(false);
                    pitch.SetAug(true);
                }
                else if (dh == 0) flat = true;

            }
        }

        else if (interval.GetHalfsteps() == 12)
        {
            octaveSign = true;
            if (pitch.GetAug()) sharp = true;
            else if (pitch.GetDim()) flat = true;
        }

        else
        {
            if (pitch.GetAug()) sharp = true;
            else if (pitch.GetDim()) flat = true;
        }
        var taskText = "Name the interval: ";
        taskText += pitch.Print();
        taskText += $" - {octave[secondPitchName]}";
        if (sharp) taskText += "#";
        else if (flat) taskText += "b";
        if (octaveSign) taskText += "1";
        CurrentInterval = interval;
        return taskText;
    }
    
    private void ValidateTextPractice()
    {
        string validationAnswer;
        answer = Characteristic + " " + BaseInterval;
        if (!string.Equals(answer, CurrentInterval.GetTitle()))
        {
            validationAnswer = "Wrong, try again";
            AnswerDetails = string.Empty;
            Hint = string.Empty;
        }
        else
        {
            validationAnswer = " Correct!";
            IsAnswerCorrect = true;
            AnswerDetails = "This is " + CurrentInterval.Print();
            Hint = "Click \"New task\" for a new exercise";
        }
        ValidationAnswer = validationAnswer;
        IsTaskChanged = false;
    }
    
    private void RefreshTask()
    {
        CurrentTaskText = PlayTextPractice();
        IsTaskChanged = true;
    }
    
}
    