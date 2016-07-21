using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xNet.Net;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Get_Link_Google_Photo
{
    
    public class GGPhoTo
    {
        public string count;
        private HttpRequest _request = new HttpRequest();
        private List<string> RemoveDuplica(List<string> sList)
        {
            for (int i = 0; i < sList.Count; i++)
            {
                bool check = false;
                for (int j = i + 1; j < sList.Count; j++)
                {
                    if (sList[i] == sList[j])
                    {
                        sList.RemoveAt(j);
                        j--;
                        check = true;
                    }
                }
                if (check == true)
                {
                    sList.RemoveAt(i);
                    i--;
                }
            }
            return sList;
        }
        public string InfoPicture(string Url)
        {
            string html = _request.Get(Url).ToString();
            string keyPhoto = Regex.Match(Url, "photo.([-\\w]+)").Groups[1].Value;
            string keyID = Regex.Match(Url, "key.([-\\w]+)").Groups[1].Value;
            string freq = @"[[[73756775,[{""73756775"":[""keyPhoto"",1,""keyID""]}],null,null,0]]]".Replace("keyPhoto", keyPhoto).Replace("keyID", keyID);
            _request.AddParam("f.req", freq);
            html =_request.Post("https://photos.google.com/_/PhotosUi/data").ToString();
            string[] temp = html.Trim().Split('"');
            //string info = temp.Where(x => x.Contains(".jpg"))
            return temp[9] + "  |  " +Url;
        }
        public string InfoAlbum(string UrlAlbum)
        {
            
            string html = _request.Get(UrlAlbum).ToString();
            var temps = Regex.Matches(html,@"(AF1[-\w]+)");
            List<string> list = new List<string>();
            string temp = "";
            foreach (Match item in temps)
            {
                list.Add(item.Groups[1].Value);
            }
            list = RemoveDuplica(list);
            foreach (var item in list)
            {
                string url = UrlAlbum.Replace("?key", @"/photo/" + item.Trim() + "?key");
                temp += InfoPicture(url)  + Environment.NewLine + Environment.NewLine;
            }
            count = list.Count.ToString();
            return temp;

        }
    }
}
