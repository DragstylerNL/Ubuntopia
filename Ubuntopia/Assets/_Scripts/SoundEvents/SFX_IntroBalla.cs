﻿using UnityEngine;

public class SFX_IntroBalla : MonoBehaviour {
    private string name = "Intro_Balla_";
    
    // References.
    [SerializeField, Header("Drag AudioManager here.")]
    private AudioManager _audioManager;
    
    public void PlaySFX() {
        _audioManager.PlayLanguage(name);
    }
}