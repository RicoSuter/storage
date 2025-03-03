﻿using System;
using Newtonsoft.Json;

namespace Storage.Net.Microsoft.Azure.DataLake.Store.Gen2.Models
{
   public class DirectoryItem
   {
      [JsonProperty("contentLength")] public int? ContentLength { get; set; }

      [JsonProperty("etag")] public DateTime Etag { get; set; }

      [JsonProperty("group")] public string Group { get; set; }

      [JsonProperty("isDirectory")] public bool IsDirectory { get; set; }

      [JsonProperty("lastModified")] public DateTime LastModified { get; set; }

      [JsonProperty("name")] public string Name { get; set; }

      [JsonProperty("owner")] public string Owner { get; set; }

      [JsonProperty("permissions")] public string Permissions { get; set; }
   }
}