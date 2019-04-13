using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum Note
{

}
public struct NoteData
{
    Note note;
    float pitch;
    float volume;
    NoteData(Note n, float p, float v = 1)
    {
        note = n;
        pitch = p;
        volume = v;
    }
}

public abstract class NoteReader : MonoBehaviour
{
    public Action<NoteData> OnGetNote = delegate (NoteData data) { };

    public virtual NoteData GetNote(float x, float y)
    {
        NoteData data = new NoteData();
        OnGetNote(data);
        return data;
    }
}
