using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public Theremin anInstance;
    public Theremin.musicNotes deathNote;
    public Theremin.octave deathOctave;
    public Theremin.volume deathVolume;

    private void OnEnable()
    {
        InputReceiver.keyButtonUpdateEvent += receiver_VolumeTriggeredEvent;
    }

    private void receiver_VolumeTriggeredEvent(int volumeButton)
    {
        Debug.Log("Event Triggered current volume is " + (Theremin.volume)volumeButton + " current note is " + anInstance.aNote 
            + " current octave is " + anInstance.currentOctave);

        Debug.Log("Conditions to kill ghost are volume: " + deathVolume + " the octave needs to be " + deathOctave 
            + " the note has to be " + deathNote);
        if ((deathVolume.Equals((Theremin.volume)volumeButton)) && (deathNote.Equals(anInstance.aNote) ) && (deathOctave.Equals(anInstance.currentOctave)))
        {
            Debug.Log("Conditions met");
            this.gameObject.SetActive(false);
        }
    }
}
