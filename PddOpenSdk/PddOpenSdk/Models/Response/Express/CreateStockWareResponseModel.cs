using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class CreateStockWareResponseModel : PddResponseModel
    {
        /// <summary>
        /// 货品id
        /// </summary>
        [JsonProperty("open_api_response")]
        public int? OpenApiResponse { get; set; }

    }

}
