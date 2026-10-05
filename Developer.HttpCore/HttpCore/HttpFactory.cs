using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Developer.HttpCore
{
    public class HttpFactory
    {
        public string _phraseIdentifyRejection;
        public readonly HttpClient _client;
        private readonly bool _configureAwait;

        public HttpFactory(IHttpClientFactory factory, string factoryName, bool configureAwait = false, string phraseIdentifyRejection = null)
        {
            _client = factory.CreateClient(factoryName);
            _configureAwait = configureAwait;
            _phraseIdentifyRejection = phraseIdentifyRejection;
        }

        #region Get

        public async Task<ResultHttp> GetAsync(string requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> GetAsync(Uri requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, completionOption, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.GetAsync(requestUri, completionOption, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Get

        #region Post

        public async Task<ResultHttp> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PostStringContentAsync(string requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PostStringContentAsync(Uri requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PostAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Post

        #region Put

        public async Task<ResultHttp> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, content, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PutStringContentAsync(string requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> PutStringContentAsync(Uri requestUri, string json, Encoding encoding, string mediaType = "application/json", CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.PutAsync(requestUri, new StringContent(json, encoding, mediaType), cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Put

        #region Delete

        public async Task<ResultHttp> DeleteAsync(string requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.DeleteAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        public async Task<ResultHttp> DeleteAsync(Uri requestUri, CancellationToken cancellationToken = default)
        {
            using (HttpResponseMessage response = await _client.DeleteAsync(requestUri, cancellationToken).ConfigureAwait(_configureAwait))
            {
                return await GetResultHttp(response);
            }
        }

        #endregion Delete

        private async Task<ResultHttp> GetResultHttp(HttpResponseMessage response)
        {
            ResultHttp resultHttp = new ResultHttp() { Response = response, HttpStatusCode = response.StatusCode };

            try
            {
                resultHttp.DataString = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                resultHttp.Success = false;
                resultHttp.Message = ex.Message;
            }

            try
            {
                resultHttp.DataBytes = await response.Content.ReadAsByteArrayAsync();
            }
            catch (Exception ex)
            {
                resultHttp.Success = false;
                resultHttp.Message = ex.Message;
            }

            try
            {
                resultHttp.DataStream = await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                resultHttp.Success = false;
                resultHttp.Message = ex.Message;
            }

            if (resultHttp.DataString != null || resultHttp.DataBytes != null || resultHttp.DataStream != null)
            {
                resultHttp.Success = true;
                resultHttp.Message = null;
            }

            if (_phraseIdentifyRejection != null)
            {
                resultHttp.RequestRejected = resultHttp.DataString.ToUpper().Contains(_phraseIdentifyRejection.ToUpper());
            }

            return resultHttp;
        }

    }
}
