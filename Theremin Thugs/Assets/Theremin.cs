using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Theremin : MonoBehaviour
{
    float mouseWheelValue;
    int note;
    enum musicNotes{
        lowC, D, E, F, G, A, B, highC
    }
    musicNotes aNote;

    enum volume
    {
        softest, soft, loud, loudest
    }
    volume theCurrentVolumeSetting;

    enum octave
    {
        low, normal, high
    }
    octave currentOctave = (octave)1;

    public Text noteText;
    public Text volumeText;
    public Text octaveText;

    private void OnEnable()
    {
        InputReceiver.ScrollWheelUpdateEvent += receiver_pitchUpdateEvent;
        InputReceiver.keyButtonUpdateEvent += receiver_volumeUpdateEvent;
        InputReceiver.mouseClickUpdateEvent += receiver_octaveUpdateEvent;
    }

    private void Awake()
    {
        aNote = 0;
    }

    private void receiver_pitchUpdateEvent(float value)
    {
        if (value > 0)
        {
            aNote++;
            if (aNote.CompareTo(musicNotes.highC) > 0)
                aNote = 0;
        }
        else if(value < 0)
        {
            aNote--;
            if (aNote.CompareTo(musicNotes.lowC) < 0)
                aNote = musicNotes.highC;
        }
        noteText.text = aNote.ToString();
    }

    private void receiver_volumeUpdateEvent(int value)
    {
        theCurrentVolumeSetting = (volume)value;
        volumeText.text = theCurrentVolumeSetting.ToString();
    }

    private void receiver_octaveUpdateEvent(int value)
    {
        if(currentOctave.CompareTo((octave)value) > 0)
        {
            currentOctave--;
        }
        else if (currentOctave.CompareTo((octave)value) < 0)
        {
            currentOctave++;
        }
        octaveText.text = currentOctave.ToString();
    }
}
