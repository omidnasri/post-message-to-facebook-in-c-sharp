using System;
using System.Collections.Generic;

namespace PostMessageToFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // پارامتر اول کد دریافتی از فیس بوک در گام سوم دریافت نمودید درج خواهد شد
            Console.WriteLine(PostFacebookWall("Access Token", "Your Message"));
        }
        private static string PostFacebookWall(string accessToken, string message)
        {
            var responsePost = "";
            try
            {
                //create the facebook account object
                var objFacebookClient = new Facebook.FacebookClient(accessToken);
                var parameters = new Dictionary<string, object>();
                parameters["message"] = message;
                responsePost = objFacebookClient.Post("feed", parameters).ToString();
            }
            catch (Exception ex)
            {
                responsePost = "Facebook Posting Error Message: " + ex.Message;
            }
            return responsePost;
        }
    }
}
