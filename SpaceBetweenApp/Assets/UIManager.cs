using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //canvases
    public GameObject startScreen;
    public GameObject warmUpScreen;
    public GameObject LessonTypeScreen;
    public GameObject DemoScreen;
    public GameObject HelpScreen;
    public GameObject NavScreen;
    public GameObject IntimateScreen;
    public GameObject PersonalScreen;
    public GameObject SocialScreen;
    public GameObject SettingsScreen;

    //button events
    public void toWarmUp()
    {
        if(startScreen.activeInHierarchy)
        {
            startScreen.SetActive(false);
            warmUpScreen.SetActive(true);
        }
        
        else if (DemoScreen.activeInHierarchy)
        {
            DemoScreen.SetActive(false);
            warmUpScreen.SetActive(true);
        }

        else
        {
            LessonTypeScreen.SetActive(false);
            warmUpScreen.SetActive(true);
        }

    }

    public void toHelp()
    {
        if(startScreen.activeInHierarchy)
        {
            startScreen.SetActive(false);
            HelpScreen.SetActive(true);
        }

        else if(SettingsScreen.activeInHierarchy)
        {
            SettingsScreen.SetActive(false);
            HelpScreen.SetActive(true);
        }

        else
        {
            NavScreen.SetActive(false);
            HelpScreen.SetActive(true);
        }
    }

    public void toStart()
    {
        if(warmUpScreen.activeInHierarchy)
        {
            warmUpScreen.SetActive(false);
            startScreen.SetActive(true);
        }

        else
        {
            HelpScreen.SetActive(false);
            startScreen.SetActive(true);
        }
    }

    public void toDemo()
    {
        if(warmUpScreen.activeInHierarchy)
        {
            warmUpScreen.SetActive(false);
            DemoScreen.SetActive(true);
        }

        else if(IntimateScreen.activeInHierarchy)
        {
            IntimateScreen.SetActive(false);
            DemoScreen.SetActive(true);
        }

        else if (PersonalScreen.activeInHierarchy)
        {
            PersonalScreen.SetActive(false);
            DemoScreen.SetActive(true);
        }

        else
        {
            SocialScreen.SetActive(false);
            DemoScreen.SetActive(true);
        }
    }

    public void toInstructionType()
    {
        if (warmUpScreen.activeInHierarchy)
        {
            warmUpScreen.SetActive(false);
            LessonTypeScreen.SetActive(true);
        }

        else if(IntimateScreen.activeInHierarchy)
        {
            IntimateScreen.SetActive(false);
            LessonTypeScreen.SetActive(true);
        }

        else if (PersonalScreen.activeInHierarchy)
        {
            PersonalScreen.SetActive(false);
            LessonTypeScreen.SetActive(true);
        }

        else if (SocialScreen.activeInHierarchy)
        {
            SocialScreen.SetActive(false);
            LessonTypeScreen.SetActive(true);
        }

        else
        {
            SettingsScreen.SetActive(false);
            LessonTypeScreen.SetActive(true);
        }
        
    }

   public void toIntimate()
    {
        LessonTypeScreen.SetActive(false);
        IntimateScreen.SetActive(true);
    }

    public void toPersonal()
    {
        LessonTypeScreen.SetActive(false);
        PersonalScreen.SetActive(true);
    }

    public void toSocial()
    {
        LessonTypeScreen.SetActive(false);
        SocialScreen.SetActive(true);
    }
    
    public void toSettings()
    {
        if(LessonTypeScreen.activeInHierarchy)
        {
            LessonTypeScreen.SetActive(false);
            SettingsScreen.SetActive(true);
        }

        else
        {
            HelpScreen.SetActive(false);
            SettingsScreen.SetActive(true);
        }
    }

    public void toNavigation()
    {
        HelpScreen.SetActive(false);
        NavScreen.SetActive(true);
    }
}
