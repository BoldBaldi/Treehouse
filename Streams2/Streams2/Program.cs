using System;
using System.Web;
using System.Text;
using System.Net;
using System.IO;

namespace Practice
{
    class Scraper
    {
        static void Main()
        {
            new Scraper().Scrape();
            Console.ReadLine();
        }

        const string URL = "http://www.wizards.com/dndinsider/compendium/background.aspx?id=1";
        const string FIRST = "1";
        const string SECOND = "3";

        private string ExtractViewState(string s)
        {
            string viewStateNameDelimiter = "__VIEWSTATE";
            string valueDelimiter = "value=\"";

            int viewStateNamePosition = s.IndexOf(viewStateNameDelimiter);
            int viewStateValuePosition = s.IndexOf(
            valueDelimiter, viewStateNamePosition
            );

            int viewStateStartPosition = viewStateValuePosition +
            valueDelimiter.Length;
            int viewStateEndPosition = s.IndexOf("\"", viewStateStartPosition);

            return HttpUtility.UrlEncodeUnicode(
            s.Substring(
            viewStateStartPosition,
            viewStateEndPosition - viewStateStartPosition
            )
            );
        }

        private string ExtractEventValidation(string s)
        {
            string eventValidationNameDelimiter = "__EVENTVALIDATION";
            string valueDelimiter = "value=\"";

            int eventValidationNamePosition = s.IndexOf(eventValidationNameDelimiter);
            int eventValidationValuePosition = s.IndexOf(
            valueDelimiter, eventValidationNamePosition
            );

            int eventValidationStartPosition = eventValidationValuePosition +
            valueDelimiter.Length;
            int eventValidationEndPosition = s.IndexOf("\"", eventValidationStartPosition);

            return HttpUtility.UrlEncodeUnicode(
            s.Substring(
            eventValidationStartPosition,
            eventValidationEndPosition - eventValidationStartPosition
            )
            );
        }

        public void Scrape()
        {
            // first, request the login form to get the viewstate value 
            HttpWebRequest webRequest = WebRequest.Create(URL) as HttpWebRequest;
            StreamReader responseReader = new StreamReader(
            webRequest.GetResponse().GetResponseStream()
            );
            string responseData = responseReader.ReadToEnd();
            responseReader.Close();

            // extract the viewstate value and build out POST data 
            string viewState = ExtractViewState(responseData);
            string eventValidation = ExtractEventValidation(responseData);
            string postData = String.Format(
            "__VIEWSTATE={0}&TextBox1={1}&TextBox2={2}&Button1=Button&__EVENTVALIDATION={3}",
            viewState, FIRST, SECOND, eventValidation
            );

            // now post to the login form 
            webRequest = WebRequest.Create(URL) as HttpWebRequest;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            // write the form values into the request message 
            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postData);
            requestWriter.Close();

            // we don't need the contents of the response, just the cookie it issues 
            responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            responseData = responseReader.ReadToEnd();
            responseReader.Close();

            Console.WriteLine("Get the response after post back");
            Console.WriteLine(responseData);
            webRequest.GetResponse().Close();
        }
    }
}