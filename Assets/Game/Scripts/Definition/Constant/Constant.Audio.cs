using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Constant
{
    public static class Audio
    {
        public const float FadeVolumeDuration = 1f;
        //// music
        //public const string LobbyBgm = "bgm_主场景1";
        //// sound
        //public static readonly SoundInfo ThrowRodSound = new SoundInfo("音效_xxx", 0, false, 1f, 0f);
    }
}

public struct SoundInfo
{
    public string assetName;
    public int priority;
    public bool loop;
    public float volumeInSoundGroup;
    public float spatialBlend;

    public SoundInfo(string assetName, int priority, bool loop, float volumeInSoundGroup, float spatialBlend)
    {
        this.assetName = assetName;
        this.priority = priority;
        this.loop = loop;
        this.volumeInSoundGroup = volumeInSoundGroup;
        this.spatialBlend = spatialBlend;
    }
}
