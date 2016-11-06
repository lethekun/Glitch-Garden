using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY  = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume >= 0 && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
            Debug.Log("Volume is set to " + volume);
        }
        else
            Debug.LogError("Master Volume out of range!");
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if (level <= Application.levelCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // Use 1 for true.
        }
        else
        {
            Debug.LogError("Trying to unlock a level that does not exist?!?!?!? .s.s");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        if(level<=Application.levelCount-1)
        {
            if ((PlayerPrefs.GetInt(LEVEL_KEY + level.ToString())) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            Debug.LogError("You are trying to ask for a level that does not exist .s.s");
            return false;
        }
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= 1 && difficulty <= 3)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
            Debug.Log("Difficulty is set to "+difficulty);
        }
        else
        {
            Debug.LogError("Invalid difficulty value!");
        }
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
