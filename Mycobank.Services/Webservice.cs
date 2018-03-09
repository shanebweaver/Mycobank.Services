using Mycobank.Services.Models;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Web.Http;

namespace Mycobank.Services
{
    public abstract class Webservice
    {
        private static readonly Uri SERVER_ADDRESS = new Uri("http://www.mycobank.org/Services/Generic/SearchService.svc/rest/xml");

        public string TableName { get; private set; }
        public string KeyNumber { get; private set; }

        internal Webservice(string tableName, string keyNumber)
        {
            TableName = tableName;
            KeyNumber = keyNumber;
        }

        public async Task<Results> Perform<T>(Search<T> search)
        {
            var requestStringBuilder = new StringBuilder($"?layout={KeyNumber}&filter={search.ToString()}");
            if (search.Limit != null)
            {
                requestStringBuilder.Append($"&limit={search.Limit}");
            }

            var requestUri = new Uri(SERVER_ADDRESS, requestStringBuilder.ToString());

            Results returnValue = null;

            try
            {
                //Send the GET request asynchronously and retrieve the response as a string.
                var httpClient = new HttpClient();
                var httpResponse = new HttpResponseMessage();
                httpResponse = await httpClient.GetAsync(requestUri);
                httpResponse.EnsureSuccessStatusCode();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Results));
                using (var inputStream = await httpResponse.Content.ReadAsInputStreamAsync())
                {
                    returnValue = (Results)xmlSerializer.Deserialize(inputStream.AsStreamForRead());
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message);
            }

            return returnValue;
        }
    }
}