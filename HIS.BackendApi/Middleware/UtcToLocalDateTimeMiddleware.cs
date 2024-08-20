using System.Text.Json.Serialization;
using System.Text.Json;
using System.ComponentModel;
using System.Globalization;

namespace HIS.BackendApi.Middleware
{

    public class UrlDateTimeConverter
    {
        private readonly RequestDelegate _next;

        public UrlDateTimeConverter(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var query = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(context.Request.QueryString.Value);
            var updatedQuery = new Dictionary<string, string>();

            foreach (var kvp in query)
            {
                if (DateTime.TryParse(kvp.Value.ToString(), out DateTime dateTime))
                {
                    updatedQuery[kvp.Key] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    updatedQuery[kvp.Key] = kvp.Value;
                }
            }

            var newQueryString = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(string.Empty, updatedQuery);
            context.Request.QueryString = new QueryString(newQueryString);

            await _next(context);
        }
    }

    public class BodyDateTimeConverter : JsonConverter<DateTime>
    {
        private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";//"yyyy-MM-ddTHH:mm:ss.fffK";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString()).ToLocalTime();
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToLocalTime().ToString(DateTimeFormat));
        }
    }
}
