using System;
using System.Collections.Generic;

public class RandomizedSet {
    private Dictionary<int, int> dict; // يخزن القيمة وموقعها في القائمة
    private List<int> list; // يخزن القيم المدخلة للوصول العشوائي
    private static Random rand = new Random(); // كائن عشوائي ثابت لتجنب إعادة التهيئة 

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
    }

    public bool Insert(int val) {
        if (dict.ContainsKey(val))
            return false;

        dict[val] = list.Count;
        list.Add(val);
        return true;
    }

    public bool Remove(int val) {
        if (!dict.ContainsKey(val))
            return false;

        int index = dict[val]; // موقع العنصر في القائمة
        int lastElement = list[list.Count - 1]; // آخر عنصر في القائمة

        list[index] = lastElement;  // استبدال العنصر المحذوف بآخر عنصر
        dict[lastElement] = index;  // تحديث موقع العنصر الأخير في القاموس

        list.RemoveAt(list.Count - 1); // حذف آخر عنصر
        dict.Remove(val); 

        return true;
    }

    public int GetRandom() {
        return list[rand.Next(list.Count)];
    }
}