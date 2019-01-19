using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrianglesWebAPI.Models
{
    public class AppDataContext
    {


        public static string GetTriangleName(string findCords)
        {

            var myDicList = new MakeList<string, string>();
            myDicList.Add("A1", "1,2,3");
            myDicList.Add("A2", "3,2,4");
            myDicList.Add("A3", "3,4,5");
            myDicList.Add("A4", "5,4,6");
            myDicList.Add("A5", "5,6,7");
            myDicList.Add("A6", "7,6,8");
            myDicList.Add("A7", "7,8,9");
            myDicList.Add("A8", "9,8,10");
            myDicList.Add("A9", "9,10,11");
            myDicList.Add("A10", "11,10,12");
            myDicList.Add("A11", "11,12,13");
            myDicList.Add("A12", "13,12,14");
            myDicList.Add("B1", "15,1,16");
            myDicList.Add("B2", "16,1,3");
            myDicList.Add("B3", "16,3,17");
            myDicList.Add("B4", "13,3,5");
            myDicList.Add("B5", "17,5,18");
            myDicList.Add("B6", "18,5,7");
            myDicList.Add("B7", "18,7,19");
            myDicList.Add("B8", "19,7,9");
            myDicList.Add("B9", "18,9,20");
            myDicList.Add("B10", "20,9,11");
            myDicList.Add("B11", "20,11,21");
            myDicList.Add("B12", "21,11,13");
            myDicList.Add("C1", "22,15,23");
            myDicList.Add("C2", "23,16,24");
            myDicList.Add("C3", "21,16,24");
            myDicList.Add("C4", "24,16,17");
            myDicList.Add("C5", "24,17,25");
            myDicList.Add("C6", "25,17,18");
            myDicList.Add("C7", "26,18,26");
            myDicList.Add("C8", "26,18,19");
            myDicList.Add("C9", "26,18,27");
            myDicList.Add("C10", "27,19,20");
            myDicList.Add("C11", "27,20,28");
            myDicList.Add("C12", "28,20,21");
            myDicList.Add("D1", "29,22,30");
            myDicList.Add("D2", "30,22,23");
            myDicList.Add("D3", "30,23,31");
            myDicList.Add("D4", "31,23,24");
            myDicList.Add("D5", "31,24,32");
            myDicList.Add("D6", "32,24,25");
            myDicList.Add("D7", "23,25,33");
            myDicList.Add("D8", "33,25,26");
            myDicList.Add("D9", "33,26,34");
            myDicList.Add("D10", "34,26,27");
            myDicList.Add("D11", "34,27,35");
            myDicList.Add("D12", "35,27,28");
            myDicList.Add("E1", "36,29,37");
            myDicList.Add("E2", "37,29,30");
            myDicList.Add("E3", "37,30,38");
            myDicList.Add("E4", "38,30,31");
            myDicList.Add("E5", "38,31,39");
            myDicList.Add("E6", "39,32,32");
            myDicList.Add("E7", "39,32,40");
            myDicList.Add("E8", "40,32,33");
            myDicList.Add("E9", "40,33,41");
            myDicList.Add("E10", "40,33,34");
            myDicList.Add("E11", "21,34,42");
            myDicList.Add("E12", "42,34.35");
            myDicList.Add("F1", "43,36,44");
            myDicList.Add("F2", "44,36,37");
            myDicList.Add("F3", "44,37,45");
            myDicList.Add("F4", "45,37,38");
            myDicList.Add("F5", "45,38.46");
            myDicList.Add("F6", "46,38,38");
            myDicList.Add("F7", "46,39,47");
            myDicList.Add("F8", "47,39,40");
            myDicList.Add("F9", "47,40,48");
            myDicList.Add("F10", "48,40,41");
            myDicList.Add("F11", "48,41,49");
            myDicList.Add("F12", "49,41,42");



            var uniqueResults = myDicList
                .Where(item => item.Value.Contains(findCords))
                .Select(item => item.Key)
                .Distinct().FirstOrDefault();

            return uniqueResults;

        }

       

    }

    public class MakeList<K, T> : Dictionary<K, List<T>>
    {
        public void Add(K key, T addObject)
        {
            if (!ContainsKey(key)) Add(key, new List<T>());
            if (!base[key].Contains(addObject)) base[key].Add(addObject);
        }
    }


}