using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FrameNetOnline
{
    public class FrameNetOnline
    {
        public List<string> output = new List<string>();
        public FrameNetOnline(string input)
        {
            try
            {

                string url = "http://demo.ark.cs.cmu.edu/parse/api/v1/parse?sentence=" + input.Replace(" ", "+");

                var request = WebRequest.Create(url);
                request.ContentType = "application/json; charset=utf-8";
                string text;
                var response = (HttpWebResponse)request.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                }

                JObject o = JObject.Parse(text);
                RootObject newTarget = JsonConvert.DeserializeObject<RootObject>(o.ToString());
                
                foreach (var sentence in newTarget.sentences)
                {
                    foreach (var item2 in sentence.frames)
                    {
                        output.Add(item2.target.name);
                    }
                }

            }
            catch (Exception ex)
            {

            }

        }



    }
}



