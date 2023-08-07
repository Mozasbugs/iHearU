/*
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour
{
    public Animator avatarAnimator;
    public InputField textToCheck;

    private void Start()
    {
        // Set up the avatar animator
    }

    public void checkText()
    {
        string[] words = textToCheck.text.Trim().ToLower().Split(' ');

        // Create a dictionary to map words to their corresponding animation triggers
        Dictionary<string, string> animationTriggers = new Dictionary<string, string>()
        {
            { "now", "Now" },
            { "hello", "Hello" },
            { "nice", "Nice" },
            { "yes", "Yes" },
            { "problem", "Problem" },
            { "bye", "Bye" },
            { "i", "I" },
            { "iam", "I" },
            { "name", "Name" },
            { "good", "Good" },
            { "later", "Later" },
            { "no", "No" },
            { "see", "See" },
            { "meet", "Meet" },
            { "and", "And" },
            { "old", "Old" },
            { "age", "Old" },
            { "sorry", "Sorry" },
            { "you", "You" },
            { "thank", "ThankU" },
            { "thanks", "ThankU" },
            { "thankyou", "ThankU" },
            {"how", "How" }
        };

        // Create a list of animation triggers corresponding to the words in the input text
        List<KeyValuePair<int, string>> animationTriggerList = new List<KeyValuePair<int, string>>();
        for (int i = 0; i < words.Length; i++)
        {
            if (animationTriggers.ContainsKey(words[i]))
            {
                animationTriggerList.Add(new KeyValuePair<int, string>(i, animationTriggers[words[i]]));
            }
        }

        // Sort the list based on the position of the words in the input text
        animationTriggerList.Sort((x, y) => x.Key.CompareTo(y.Key));

        // Trigger the animations in the correct order
        StartCoroutine(TriggerAnimations(animationTriggerList.Select(x => x.Value).ToList()));

        // Clear the input text
        textToCheck.text = "";
    }

    private IEnumerator TriggerAnimations(List<string> animationTriggerList)
    {
        foreach (string trigger in animationTriggerList)
        {
            avatarAnimator.SetTrigger(trigger);
            yield return new WaitForSeconds(avatarAnimator.GetCurrentAnimatorStateInfo(0).length + 1f);
        }
    }
} */

/*
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour
{
    public Animator avatarAnimator;
    public InputField textToCheck;

    private void Start()
    {
        // Set up the avatar animator
    }

    public void checkText()
    {
        string[] words = textToCheck.text.Trim().ToLower().Split(' ');

        // Create a dictionary to map words to their corresponding animation triggers
        Dictionary<string, string> animationTriggers = new Dictionary<string, string>()
        {
            { "now", "Now" },
            { "hello", "Hello" },
            { "nice", "Nice" },
            { "yes", "Yes" },
            { "problem", "Problem" },
            { "bye", "Bye" },
            { "i", "I" },
            { "iam", "I" },
            { "name", "Name" },
            { "good", "Good" },
            { "later", "Later" },
            { "no", "No" },
            { "see", "See" },
            { "meet", "Meet" },
            { "and", "And" },
            { "old", "Old" },
            { "age", "Old" },
            { "sorry", "Sorry" },
            { "you", "You" },
            { "thank", "ThankU" },
            { "thanks", "ThankU" },
            { "thankyou", "ThankU" },
            {"how", "How" }
        };

        // Create a list of animation triggers corresponding to the words in the input text
        List<KeyValuePair<int, string>> animationTriggerList = new List<KeyValuePair<int, string>>();
        for (int i = 0; i < words.Length; i++)
        {
            if (animationTriggers.ContainsKey(words[i]))
            {
                animationTriggerList.Add(new KeyValuePair<int, string>(i, animationTriggers[words[i]]));
            }
        }

        // Sort the list based on the position of the words in the input text
        animationTriggerList.Sort((x, y) => x.Key.CompareTo(y.Key));

        // Set "Begin" parameter to true before triggering animations
        avatarAnimator.SetBool("Begin", true);

        // Trigger the animations in the correct order
        StartCoroutine(TriggerAnimations(animationTriggerList.Select(x => x.Value).ToList()));

        // Clear the input text
        textToCheck.text = "";
    }

    private IEnumerator TriggerAnimations(List<string> animationTriggerList)
    {
        foreach (string trigger in animationTriggerList)
        {
            avatarAnimator.SetTrigger(trigger);
            yield return new WaitForSeconds(avatarAnimator.GetCurrentAnimatorStateInfo(0).length + 1f);
        }

        // Set "Begin" parameter to false after all animations are triggered
        avatarAnimator.SetBool("Begin", false);
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour
{
    public Animator avatarAnimator;
    public InputField textToCheck;

    private void Start()
    {
        // Set up the avatar animator
    }

    public void checkText()
    {
        string[] words = textToCheck.text.Trim().ToLower().Split(' ');

        // Create a dictionary to map words to their corresponding animation triggers
        Dictionary<string, string> animationTriggers = new Dictionary<string, string>()
        {
             { "now", "Now" },
            { "hello", "Hello" },
            { "hi", "Hello" },
            { "nice", "Nice" },
            { "yes", "Yes" },
            { "problem", "Problem" },
            { "bye", "Bye" },
            { "i", "I" },
            { "me", "I" },
            { "iam", "I" },
            { "name", "Name" },
            { "good", "Good" },
            { "later", "Later" },
            { "no", "No" },
            { "see", "See" },
            { "meet", "Meet" },
            { "and", "And" },
            { "old", "Old" },
            { "age", "Old" },
            { "sorry", "Sorry" },
            { "you", "You" },
            { "thank", "ThankU" },
            { "thanks", "ThankU" },
            { "thankyou", "ThankU" },
            {"how", "How" }
        };

        // Create a list of animation triggers corresponding to the words in the input text
        List<KeyValuePair<int, string>> animationTriggerList = new List<KeyValuePair<int, string>>();
        for (int i = 0; i < words.Length; i++)
        {
            if (animationTriggers.ContainsKey(words[i]))
            {
                animationTriggerList.Add(new KeyValuePair<int, string>(i, animationTriggers[words[i]]));
            }
        }

        // Sort the list based on the position of the words in the input text
        animationTriggerList.Sort((x, y) => x.Key.CompareTo(y.Key));

        // Set "Begin" parameter to true before triggering animations
        avatarAnimator.SetBool("Begin", true);

        // Trigger the animations in the correct order
        StartCoroutine(TriggerAnimations(animationTriggerList.Select(x => x.Value).ToList(), () =>
        {
            // Perform actions after all animations are triggered
            avatarAnimator.SetTrigger("End");
        }));

        // Clear the input text
        textToCheck.text = "";
    }

    private IEnumerator TriggerAnimations(List<string> animationTriggerList, System.Action onAnimationComplete)
    {
        foreach (string trigger in animationTriggerList)
        {
            avatarAnimator.SetTrigger(trigger);
            yield return new WaitForSeconds(avatarAnimator.GetCurrentAnimatorStateInfo(0).length + 1f);
        }

        // Set "Begin" parameter to false after all animations are triggered
        avatarAnimator.SetBool("Begin", false);

        // Invoke the onAnimationComplete action
        onAnimationComplete.Invoke();
    }
}
