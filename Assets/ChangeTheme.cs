using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTheme : MonoBehaviour{
    private bool changed = true;
    
    public Image background;
    public Image classes;
    public Image title;
    public Image botBar;
    public Image time;
    
    public Sprite cleanBackground;
    public Sprite cleanClasses;
    public Sprite cleanTitle;
    public Sprite cleanTime;
    
    public Sprite comicBackground;
    public Sprite comicClasses;
    public Sprite comicTitle;
    public Sprite comicTime;
    
    public void ChangeThemeFunction(){
        if (changed){
            background.sprite = comicBackground;
            classes.sprite = comicClasses;
            title.sprite = comicTitle;
            botBar.enabled = false;
            time.sprite = comicTime;
            changed = false;
        }
        else{
            background.sprite = cleanBackground;
            classes.sprite = cleanClasses;
            title.sprite = cleanTitle;
            botBar.enabled = true;
            time.sprite = cleanTime;
            changed = true;
        }
    }
}
