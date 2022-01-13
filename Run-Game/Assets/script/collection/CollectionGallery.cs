using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum distinction
{
	character1,
	character2,
	character3,
	character4,
	character5,
	character6,
	character7,
	character8,
	character9,
	character10,
	character11,
	character12,
	character13,
	character14,
	character15,
	character16,
	character17,
	character18,
	character19,
	character20,
	character21,
	character22,
	character23,
	character24,
	character25,
	character26,
	character27,
	character28,
	character29,
	character30,
	character31,
	character32,
	character33,
	character34,
	character35,
	character36,
	character37,
	character38,
	character39,
	character40,
	character41,
	character42,
	character43,
	character44,
	character45,
	character46,
	character47,
	character48,
	character49,
	character50,
}

public class CollectionGallery
{
	public static bool get_character2 = false;
	public static bool get_character3 = false;
	public static bool get_character1 = false;
	public static bool get_character4 = false;
	public static bool get_character5 = false;
	public static bool get_character6 = false;
	public static bool get_character7 = false;
	public static bool get_character8 = false;
	public static bool get_character9 = false;
	public static bool get_character10 = false;
	public static bool get_character11 = false;
	public static bool get_character12 = false;
	public static bool get_character13 = false;
	public static bool get_character14 = false;
	public static bool get_character15 = false;
	public static bool get_character16 = false;
	public static bool get_character17 = false;
	public static bool get_character18 = false;
	public static bool get_character19 = false;
	public static bool get_character20 = false;
	public static bool get_character21 = false;
	public static bool get_character22 = false;
	public static bool get_character23 = false;
	public static bool get_character24 = false;
	public static bool get_character25 = false;
	public static bool get_character26 = false;
	public static bool get_character27 = false;
	public static bool get_character28 = false;
	public static bool get_character29 = false;
	public static bool get_character30 = false;
	public static bool get_character31 = false;
	public static bool get_character32 = false;
	public static bool get_character33 = false;
	public static bool get_character34 = false;
	public static bool get_character35 = false;
	public static bool get_character36 = false;
	public static bool get_character37 = false;
	public static bool get_character38 = false;
	public static bool get_character39 = false;
	public static bool get_character40 = false;
	public static bool get_character41 = false;
	public static bool get_character42 = false;
	public static bool get_character43 = false;
	public static bool get_character44 = false;
	public static bool get_character45 = false;
	public static bool get_character46 = false;
	public static bool get_character47 = false;
	public static bool get_character48 = false;
	public static bool get_character49 = false;
	public static bool get_character50 = false;

	public void OpenIllust(distinction _dis)
	{
		distinction distinction;
		distinction = _dis;

		switch (distinction)
		{
			case distinction.character1:
				get_character1 = true;
				break;
			case distinction.character2:
				get_character2 = true;
				break;
			case distinction.character3:
				get_character3 = true;
				break;
			case distinction.character4:
				get_character4 = true;
				break;
			case distinction.character5:
				get_character5 = true;
				break;
			case distinction.character6:
				get_character6 = true;
				break;
			case distinction.character7:
				get_character7 = true;
				break;
			case distinction.character8:
				get_character8 = true;
				break;
			case distinction.character9:
				get_character9 = true;
				break;
			case distinction.character10:
				get_character10 = true;
				break;
			case distinction.character11:
				get_character11 = true;
				break;
			case distinction.character12:
				get_character12 = true;
				break;
			case distinction.character13:
				get_character13 = true;
				break;
			case distinction.character14:
				get_character14 = true;
				break;
			case distinction.character15:
				get_character15 = true;
				break;
			case distinction.character16:
				get_character16 = true;
				break;
			case distinction.character17:
				get_character17 = true;
				break;
			case distinction.character18:
				get_character18 = true;
				break;
			case distinction.character19:
				get_character19 = true;
				break;
			case distinction.character20:
				get_character20 = true;
				break;
			case distinction.character21:
				get_character21 = true;
				break;
			case distinction.character22:
				get_character22 = true;
				break;
			case distinction.character23:
				get_character23 = true;
				break;
			case distinction.character24:
				get_character24 = true;
				break;
			case distinction.character25:
				get_character25 = true;
				break;
			case distinction.character26:
				get_character26 = true;
				break;
			case distinction.character27:
				get_character27 = true;
				break;
			case distinction.character28:
				get_character28 = true;
				break;
			case distinction.character29:
				get_character29 = true;
				break;
			case distinction.character30:
				get_character30 = true;
				break;
			case distinction.character31:
				get_character31 = true;
				break;
			case distinction.character32:
				get_character32 = true;
				break;
			case distinction.character33:
				get_character33 = true;
				break;
			case distinction.character34:
				get_character34 = true;
				break;
			case distinction.character35:
				get_character35 = true;
				break;
			case distinction.character36:
				get_character36 = true;
				break;
			case distinction.character37:
				get_character37 = true;
				break;
			case distinction.character38:
				get_character38 = true;
				break;
			case distinction.character39:
				get_character39 = true;
				break;
			case distinction.character40:
				get_character40 = true;
				break;
			default:
				break;
		}
	}

	public bool GetGet_character(int num)
	{
		switch (num)
		{
			case 1:
				return get_character1;
			case 2:
				return get_character2;
			case 3:
				return get_character3;
			case 4:
				return get_character4;
			case 5:
				return get_character5;
			case 6:
				return get_character6;
			case 7:
				return get_character7;
			case 8:
				return get_character8;
			case 9:
				return get_character9;
			case 10:
				return get_character10;
			case 11:
				return get_character11;
			case 12:
				return get_character12;
			case 13:
				return get_character13;
			case 14:
				return get_character14;
			case 15:
				return get_character15;
			case 16:
				return get_character16;
			case 17:
				return get_character17;
			case 18:
				return get_character18;
			case 19:
				return get_character19;
			case 20:
				return get_character20;
			case 21:
				return get_character21;
			case 22:
				return get_character22;
			case 23:
				return get_character23;
			case 24:
				return get_character24;
			case 25:
				return get_character25;
			case 26:
				return get_character26;
			case 27:
				return get_character27;
			case 28:
				return get_character28;
			case 29:
				return get_character29;
			case 30:
				return get_character30;
			case 31:
				return get_character31;
			case 32:
				return get_character32;
			case 33:
				return get_character33;
			case 34:
				return get_character34;
			case 35:
				return get_character35;
			case 36:
				return get_character36;
			case 37:
				return get_character37;
			case 38:
				return get_character38;
			case 39:
				return get_character39;
			case 40:
				return get_character40;
			case 41:
				return get_character41;
			case 42:
				return get_character42;
			case 43:
				return get_character43;
			case 44:
				return get_character44;
			case 45:
				return get_character45;
			case 46:
				return get_character46;
			case 47:
				return get_character47;
			case 48:
				return get_character48;
			case 49:
				return get_character49;
			case 50:
				return get_character50;
			default:
				return false;
		}
	}
}
