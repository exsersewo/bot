﻿namespace Miki.API.Imageboards.Objects
{
    using Newtonsoft.Json;

    public class BooruPost
	{
		[JsonProperty("tags")]
		public string Tags { get; set; }

		[JsonProperty("width")]
		public string Width { get; set; }

		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("score")]
		public string Score { get; set; }
	}
}