using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public static class Utils
{
	public static void SetOptions<T> (this Dropdown dropdown) where T : struct
	{
		if (!typeof (T).IsEnum) throw new Exception ("Not an enum!");
		dropdown.ClearOptions ();
		string[] names = Enum.GetNames (typeof (T));
		Dropdown.OptionData[] options = Array.ConvertAll (names, BuildOptionData);
		List<Dropdown.OptionData> optionsList = new List<Dropdown.OptionData> (options);
		dropdown.AddOptions (optionsList);
	}
    public static Stack<Carta> Shuffle(this Stack<Carta> cards)
    {
        return new Stack<Carta>(cards.OrderBy(x => UnityEngine.Random.Range(0, 52)));
    }
    private static Dropdown.OptionData BuildOptionData (string name)
	{
		return new Dropdown.OptionData (name);
	}

	public static T GetValue<T> (this Dropdown dropdown) where T : struct
	{
		int index = dropdown.value;
		string selected = dropdown.options[index].text;
		return (T)Enum.Parse(typeof(T), selected);
	}
}
