using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace api_demo
{
    class Program
    {
        /*static void Main(string[] args)
        {
            var oauth_token = "2914220049-jocy5L0H6qRqymJPg5Owsf4SMAfcQSM7l4u78PX";
            var oauth_token_secret = "d3REj754K6thNmF1Ra8mIYGprgJDUdGxiTsOjEg7kNqcY";
            var oauth_consumer_key = "NdkeE2CO7WyoHeqdLy3Fx5RMO";
            var oauth_consumer_secret = "TxYxZ7xvUWRwzzhwFv4nGQsAtocX7AnCr5RMFny2bUb6ep7Rad";
            //
            var oauth_version = "1.0";
            var oauth_signature_method = "HMAC-SHA1";
            var oauth_nonce = Convert.ToBase64String(
                                              new ASCIIEncoding().GetBytes(
                                                   DateTime.Now.Ticks.ToString()));
            var timeSpan = DateTime.UtcNow
                                              - new DateTime(1970, 1, 1, 0, 0, 0, 0,
                                                   DateTimeKind.Utc);
            var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();
            var resource_url = "https://api.twitter.com/1.1/statuses/update.json";
            var status = "YOHO 3it works.";
            //
            var baseFormat = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&status={6}";

            var baseString = string.Format(baseFormat,
                                        oauth_consumer_key,
                                        oauth_nonce,
                                        oauth_signature_method,
                                        oauth_timestamp,
                                        oauth_token,
                                        oauth_version,
                                        Uri.EscapeDataString(status)
                                        );

            baseString = string.Concat("POST&", Uri.EscapeDataString(resource_url),
                         "&", Uri.EscapeDataString(baseString));
            //
            var compositeKey = string.Concat(Uri.EscapeDataString(oauth_consumer_secret),
                        "&", Uri.EscapeDataString(oauth_token_secret));

            string oauth_signature;
            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(compositeKey)))
            {
                oauth_signature = Convert.ToBase64String(
                    hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
            }
            //
            var headerFormat = "OAuth oauth_nonce=\"{0}\", oauth_signature_method=\"{1}\", " +
                   "oauth_timestamp=\"{2}\", oauth_consumer_key=\"{3}\", " +
                   "oauth_token=\"{4}\", oauth_signature=\"{5}\", " +
                   "oauth_version=\"{6}\"";

            var authHeader = string.Format(headerFormat,
                                    Uri.EscapeDataString(oauth_nonce),
                                    Uri.EscapeDataString(oauth_signature_method),
                                    Uri.EscapeDataString(oauth_timestamp),
                                    Uri.EscapeDataString(oauth_consumer_key),
                                    Uri.EscapeDataString(oauth_token),
                                    Uri.EscapeDataString(oauth_signature),
                                    Uri.EscapeDataString(oauth_version)
                            );
            //
            var postBody = "status=" + Uri.EscapeDataString(status);

            ServicePointManager.Expect100Continue = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
            request.Headers.Add("Authorization", authHeader);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream stream = request.GetRequestStream())
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
                stream.Write(content, 0, content.Length);
                Console.Write(stream);
            }
            WebResponse response = request.GetResponse();

            /*using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();
                Console.Write(responseString);
            }
            Console.ReadLine();
        }*/
        static void Main(string[] args)
        {
            var oauth_token = "2914220049-jocy5L0H6qRqymJPg5Owsf4SMAfcQSM7l4u78PX";
            var oauth_token_secret = "d3REj754K6thNmF1Ra8mIYGprgJDUdGxiTsOjEg7kNqcY";
            var oauth_consumer_key = "NdkeE2CO7WyoHeqdLy3Fx5RMO";
            var oauth_consumer_secret = "TxYxZ7xvUWRwzzhwFv4nGQsAtocX7AnCr5RMFny2bUb6ep7Rad";
            //
            var oauth_version = "1.0";
            var oauth_signature_method = "HMAC-SHA1";
            var oauth_nonce = Convert.ToBase64String(
                                              new ASCIIEncoding().GetBytes(
                                                   DateTime.Now.Ticks.ToString()));
            var timeSpan = DateTime.UtcNow
                                              - new DateTime(1970, 1, 1, 0, 0, 0, 0,
                                                   DateTimeKind.Utc);
            var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();
             var resource_url = "https://api.twitter.com/1.1/statuses/user_timeline.json";
           // var resource_url = "https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name=twitterapi&count=2";
            var screen_name = "tarrantzhang";
            //
            var baseFormat = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&screen_name={6}";

            var baseString = string.Format(baseFormat,
                                        oauth_consumer_key,
                                        oauth_nonce,
                                        oauth_signature_method,
                                        oauth_timestamp,
                                        oauth_token,
                                        oauth_version,
                                        Uri.EscapeDataString(screen_name)
                                        );

            baseString = string.Concat("GET&", Uri.EscapeDataString(resource_url),
                         "&", Uri.EscapeDataString(baseString));
            //
            var compositeKey = string.Concat(Uri.EscapeDataString(oauth_consumer_secret),
                        "&", Uri.EscapeDataString(oauth_token_secret));

            string oauth_signature;
            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(compositeKey)))
            {
                oauth_signature = Convert.ToBase64String(
                    hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
            }
            //
            var headerFormat = "OAuth oauth_nonce=\"{0}\", oauth_signature_method=\"{1}\", " +
                   "oauth_timestamp=\"{2}\", oauth_consumer_key=\"{3}\", " +
                   "oauth_token=\"{4}\", oauth_signature=\"{5}\", " +
                   "oauth_version=\"{6}\"";

            var authHeader = string.Format(headerFormat,
                                    Uri.EscapeDataString(oauth_nonce),
                                    Uri.EscapeDataString(oauth_signature_method),
                                    Uri.EscapeDataString(oauth_timestamp),
                                    Uri.EscapeDataString(oauth_consumer_key),
                                    Uri.EscapeDataString(oauth_token),
                                    Uri.EscapeDataString(oauth_signature),
                                    Uri.EscapeDataString(oauth_version)
                            );
            //
            ServicePointManager.Expect100Continue = false;
            var postBody = "screen_name=" + Uri.EscapeDataString(screen_name);
            resource_url += "?" + postBody;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
            request.Headers.Add("Authorization", authHeader);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            /*using (Stream stream = request.GetRequestStream())
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
                stream.Write(content, 0, content.Length);
            }*/
            WebResponse response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                // use whatever method you want to save the data to the file...
                File.AppendAllText("response.txt", response.Headers.ToString());
                File.AppendAllText("response.txt", reader.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
